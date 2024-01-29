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
    public partial class OgrenciDersSecimEkrani : Form
    {
        List<CheckedListItems> checkedListItems = new List<CheckedListItems>();
        public string ogrenciNo { get; set; }
        public int karakterSiniri;
        public int farkliHoca;
        public int dersSecimSuresi;

        public void dataGrid1Guncelle()
        {
            try
            {
                using (var dbContext = new Context())
                {
                    var query1 = from dersTalep in dbContext.DersTalepleris
                                 where dersTalep.ogrenciNo == ogrenciNo
                                 join ders in dbContext.Dersler on dersTalep.dersId equals ders.dersId
                                 join ogretmen in dbContext.Ogretmenler on dersTalep.sicilNo equals ogretmen.sicilNo
                                 select new
                                 {
                                     OgrenciNo = dersTalep.ogrenciNo,
                                     DersAdi = ders.dersAdi,
                                     OgretmenAdi = ogretmen.ogretmenAdi,
                                     TalepMesaji = dersTalep.talepMesaji,
                                     TalepTarihi = dersTalep.talepTarihi,
                                     OnayDurumu = dersTalep.onay,
                                     TalepId = dersTalep.talepId,
                                 };

                    dataGridView1.DataSource = query1.Where(a => a.OnayDurumu == 0).ToList();
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        public OgrenciDersSecimEkrani(string ogrenciNo)
        {

            InitializeComponent();
           
            this.ogrenciNo = ogrenciNo;

            using (var dbContext = new Context())
            {
                var genelAyar = dbContext.GenelAyarlars.FirstOrDefault();

                if (genelAyar != null)
                {
                    karakterSiniri = genelAyar.mesajKarakterSiniri;
                    farkliHoca = genelAyar.farkliHocadanAlabilirMi;
                    dersSecimSuresi = genelAyar.dersSecimSüresi;

                }

                var query = from ogretmenDers in dbContext.OgretmenDers
                            join ders in dbContext.Dersler on ogretmenDers.dersId equals ders.dersId
                            join ogretmen in dbContext.Ogretmenler on ogretmenDers.sicilNo equals ogretmen.sicilNo
                            select new
                            {
                                DersAdi = ders.dersAdi,
                                OgretmenAdi = ogretmen.ogretmenAdi,
                                OgretmenSoyadi = ogretmen.ogretmenSoyAdi,
                                DersId = ders.dersId,
                                SicilNo = ogretmen.sicilNo

                            };


                foreach (var item in query)
                {

                    acilanDersListesiCBox.Items.Add(item.DersAdi + "(" + item.OgretmenAdi + " " + item.OgretmenSoyadi + ")");
                    checkedListItems.Add(new CheckedListItems(item.SicilNo, item.DersId));

                }

                var query1 = from dersTalep in dbContext.DersTalepleris
                            join ders in dbContext.Dersler on dersTalep.dersId equals ders.dersId
                            join ogretmen in dbContext.Ogretmenler on dersTalep.sicilNo equals ogretmen.sicilNo
                            select new
                            {
                                OgrenciNo = dersTalep.ogrenciNo,
                                DersAdi = ders.dersAdi,
                                OgretmenAdi = ogretmen.ogretmenAdi,
                                TalepMesaji = dersTalep.talepMesaji,
                                TalepTarihi = dersTalep.talepTarihi,
                                OnayDurumu = dersTalep.onay,
                                TalepId = dersTalep.talepId,
                            };

                var aldigiDersler = from ogrenciDers in dbContext.OgrenciDers
                                     join ders in dbContext.Dersler on ogrenciDers.dersId equals ders.dersId
                                     join ogretmen in dbContext.Ogretmenler on ogrenciDers.sicilNo equals ogretmen.sicilNo
                             select new
                             {
                                 DersAdi = ders.dersAdi,
                                 OgretmenAdi = ogretmen.ogretmenAdi,
                                 OgrenciId = ogrenciDers.ogrenciNo,
                             };

                dataGridView1.DataSource = query1.Where(a => a.OnayDurumu == 0 && a.OgrenciNo == ogrenciNo).ToList();
                dataGridView2.DataSource = aldigiDersler.Where(a => a.OgrenciId == ogrenciNo).ToList();
                dataGridView2.Columns[2].Visible = false;

            }
                





        }

        private void talepOlusturBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dbContext = new Context())
                {

                    var talepler = dbContext.DersTalepleris
                        .Where(a => a.onay == 1)
                        .ToList();

                    int alabilirMi = 1;

                    if(farkliHoca == 0)
                    {

                        for (int i = 0; i < talepler.Count; i++)
                        {
                            string sicilNo = talepler[i].sicilNo;

                            if (sicilNo != checkedListItems[acilanDersListesiCBox.SelectedIndex].sicilNo)
                            {
                                alabilirMi = 0;
                                break;
                            }

                        }

                        if(alabilirMi == 0)
                        {
                            MessageBox.Show("Farklı Hocalardan Ders Alamazsın");

                        } else
                        {
                            DateTime bugun = DateTime.Today;
                            dbContext.DersTalepleris.Add(new DersTalepleri { ogrenciNo = ogrenciNo, sicilNo = checkedListItems[acilanDersListesiCBox.SelectedIndex].sicilNo, dersId = checkedListItems[acilanDersListesiCBox.SelectedIndex].dersId, talepMesaji = mesajRichTextBox1.Text, talepTarihi = bugun.ToString(), onay = 0 });
                            dbContext.SaveChanges();
                            MessageBox.Show("Talep Gonderildi.");

                            dataGrid1Guncelle();
                            alabilirMi = 1;
                        }

                    } else
                    {

                        DateTime bugun = DateTime.Today;
                        dbContext.DersTalepleris.Add(new DersTalepleri { ogrenciNo = ogrenciNo, sicilNo = checkedListItems[acilanDersListesiCBox.SelectedIndex].sicilNo, dersId = checkedListItems[acilanDersListesiCBox.SelectedIndex].dersId, talepMesaji = mesajRichTextBox1.Text, talepTarihi = bugun.ToString(), onay = 0 });
                        dbContext.SaveChanges();
                        MessageBox.Show("Talep Gonderildi.");

                        dataGrid1Guncelle();

                    }
                    

                }


            }
            catch (Exception)
            {

                throw;

            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                using (var dbContext = new Context())
                {


                    int secilen = dataGridView1.SelectedCells[0].RowIndex;

                    mesajRichTextBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                    int talepId = Convert.ToInt16(dataGridView1.Rows[secilen].Cells[6].Value);

                    talepIdLbl.Text = talepId.ToString();

                    var secilenTalep = dbContext.DersTalepleris.FirstOrDefault(a => a.talepId == talepId);

                    if(secilenTalep != null)
                    {
                        for (int i = 0; i < checkedListItems.Count; i++)
                        {

                            CheckedListItems item = checkedListItems[i];

                            if (item.dersId == secilenTalep.dersId && item.sicilNo == secilenTalep.sicilNo)
                            {

                                acilanDersListesiCBox.SelectedIndex = i;

                            }
                        }
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }






        }

        private void talepIptal_Click(object sender, EventArgs e)
        {

            try
            {
                using (var dbContext = new Context())
                {

                    var silinecekTalep = dbContext.DersTalepleris.FirstOrDefault(a => a.talepId.ToString() == talepIdLbl.Text);
                    
                    if (silinecekTalep != null)
                    {
                        dbContext.DersTalepleris.Remove(silinecekTalep);
                        dbContext.SaveChanges();
                    }

                    MessageBox.Show("Talep Silindi.");

                    dataGrid1Guncelle();

                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void mesajRichTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mesajRichTextBox1.Text.Length >= karakterSiniri && e.KeyChar != 8)
            {

                e.Handled = true;

            }
            else
            {
                karakterSayaciLbl.Text = (mesajRichTextBox1.Text.Length + 1).ToString();

            }


        }
    }
}
