using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazLab1_1
{
    public partial class HocaKriterDersEkleme : Form
    {
        public Ogretmen ogr;
        public void kriterDersListele()
        {
            try
            {

                using(var dbContext = new Context())
                {

                    var query1 = from kriterDers in dbContext.KriterDersListesis
                                 where kriterDers.sicilNo == ogr.sicilNo
                                 join ders in dbContext.Dersler on kriterDers.dersId equals ders.dersId
                                 select new
                                 {

                                     DersAdi = ders.dersAdi,
                                     DersId = ders.dersId,
                                     KatSayisi = kriterDers.katSayisi

                                 };

                    var dersListesi = dbContext.Dersler.ToList();
                    dersListesiCombo.Items.Clear();
                    foreach (var item in dersListesi)
                    {
                        dersListesiCombo.Items.Add(item.dersAdi);
                    }

                    kriterDersListesi.Items.Clear();
                    foreach (var item in query1)
                    {
                        kriterDersListesi.Items.Add(item.DersAdi + "  (" + item.KatSayisi + ")");
                    }


                }

            }
            catch (Exception)
            {

                throw;
            }


        }
        public HocaKriterDersEkleme(Ogretmen ogr)
        {
            InitializeComponent();
            this.ogr = ogr;
            kriterDersListele();
        }

        private void kriterDersEkle_Click(object sender, EventArgs e)
        {

            try
            {

                using (var dbContext = new Context())
                {
                    string secilenDersAdi = dersListesiCombo.SelectedItem.ToString();

                    var ders = dbContext.Dersler.FirstOrDefault(a => a.dersAdi == secilenDersAdi);

                    if(ders != null)
                    {

                        dbContext.KriterDersListesis.Add(new KriterDersListesi { dersId = ders.dersId, sicilNo = ogr.sicilNo, katSayisi = Convert.ToDouble(katSayisiTxt.Text) });
                        dbContext.SaveChanges();

                    }

                    MessageBox.Show("Kriter Ders Eklendi.");

                }

                kriterDersListele();


            }
            catch (Exception)
            {

                throw;
            }


        }

        private void ogrenciListele_Click(object sender, EventArgs e)
        {

            try
            {

                using (var dbContext = new Context())
                {

                    var kriterDersler = dbContext.KriterDersListesis.Where(a => a.sicilNo == ogr.sicilNo).ToList();
                    var ogrencilerinDersleri = from transcript in dbContext.Transcripts
                                               join ogrenci in dbContext.Ogrencis on transcript.ogrenciNo equals ogrenci.ogrenciNo
                                               join ders in dbContext.Dersler on transcript.dersId equals ders.dersId
                                               select new
                                               {

                                                   OgrenciNo = ogrenci.ogrenciNo,
                                                   OgrenciAdi = ogrenci.ogrenciAdi,
                                                   DersId = ders.dersId,
                                                   DersAdi = ders.dersAdi,
                                                   DersNot = transcript.dersNotu,

                                               };

                    double formulSonucu = 0;

                    var liste = ogrencilerinDersleri.ToList();

                    Console.WriteLine("Liste Sayisi : " + liste.Count);
                    Console.WriteLine("Kriter Sayisi : " + kriterDersler.Count);

                    List<KriterListeleme> ogrenciListesi = new List<KriterListeleme>();

                    for (int i = 0; i < liste.Count; i++)
                    {
                        
                        for (int j = 0; j < kriterDersler.Count; j++)
                        {

                            if (kriterDersler[j].dersId == liste[i].DersId)
                            {
                                formulSonucu += liste[i].DersNot * kriterDersler[j].katSayisi;
                                break;
                            }

                        }

                        Console.WriteLine("i :" + i);

                        if ((i + 1) == liste.Count - 1)
                        {
                            Console.WriteLine(liste[i].OgrenciNo + " Ortalama : " + formulSonucu);
                            ogrenciListesi.Add(new KriterListeleme(liste[i].OgrenciNo, liste[i].OgrenciAdi, formulSonucu));
                            break;
                        }

                        if (liste[i].OgrenciNo != liste[i + 1].OgrenciNo)
                        {
                            Console.WriteLine(liste[i].OgrenciNo + " Ortalama : " + formulSonucu);
                            ogrenciListesi.Add(new KriterListeleme(liste[i].OgrenciNo, liste[i].OgrenciAdi, formulSonucu));
                            formulSonucu = 0;
                        }

                    }

                    dataGridView1.DataSource = ogrenciListesi;

                }

            }
            catch (Exception)
            {

                throw;
            }


        }

        
        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            


        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            //if (e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.Columns.Count)
            //{
            //    DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];

            //    if (!isAscending)
            //    {
            //        dataGridView1.Sort(column, System.ComponentModel.ListSortDirection.Ascending);
            //        isAscending = true;
            //    }
            //    else
            //    {
            //        dataGridView1.Sort(column, System.ComponentModel.ListSortDirection.Descending);
            //        isAscending = false;
            //    }
            //}

            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            string ogrenciNo = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            HocaZorunluDersSecme zrn = new HocaZorunluDersSecme(ogr.sicilNo, ogrenciNo);
            zrn.Show();
        }
    }
}
