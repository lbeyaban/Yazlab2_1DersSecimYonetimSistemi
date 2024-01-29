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
    public partial class HocaAnaPanel : Form
    {
        public string sicilNo;
        public Ogretmen ogr;
        public HocaAnaPanel(string hocaAdi , string sicilNo)
        {
            InitializeComponent();
            lblHocaAdi.Text = hocaAdi;
            lblSicilNo.Text = sicilNo;
            this.sicilNo = sicilNo;

            using (var dbContext = new Context())
            {
                var ogr = dbContext.Ogretmenler.FirstOrDefault(a => a.sicilNo == sicilNo);
                this.ogr = ogr;
                var query1 = from dersTalep in dbContext.DersTalepleris
                             join ders in dbContext.Dersler on dersTalep.dersId equals ders.dersId
                             join ogretmen in dbContext.Ogretmenler on dersTalep.sicilNo equals ogretmen.sicilNo
                             select new
                             {
                                 OgrenciNo = dersTalep.ogrenciNo,
                                 OgrenciAdi = dersTalep.Ogrenci.ogrenciAdi,
                                 DersAdi = ders.dersAdi,
                                 TalepMesaji = dersTalep.talepMesaji,
                                 TalepTarihi = dersTalep.talepTarihi,
                                 OnayDurumu = dersTalep.onay,
                                 TalepId = dersTalep.talepId,
                                 SicilNo = dersTalep.sicilNo,
                                 DersId = dersTalep.dersId,
                             };

                var tumListe = query1.Where(a => a.OnayDurumu == 1).ToList();
                var hocaListe = query1.Where(a => a.SicilNo == sicilNo && a.OnayDurumu == 0).ToList();

                for (int i = 0; i < tumListe.Count; i++)
                {
                    for (int j = 0; j < hocaListe.Count; j++)
                    {
                        if(tumListe[i].OgrenciNo == hocaListe[j].OgrenciNo && tumListe[i].DersId == hocaListe[j].DersId)
                        {
                            int index = hocaListe[j].TalepId;
                            var guncellenecekVeri = dbContext.DersTalepleris.FirstOrDefault(a => a.talepId == index);

                            if (guncellenecekVeri != null)
                            {

                                guncellenecekVeri.onay = -1;
                                dbContext.SaveChanges();

                            }

                            Console.WriteLine("Ders :" + hocaListe[j].DersAdi);

                        }

                    }

                }
              
                dataGridView2.DataSource = query1.Where(a => a.SicilNo == sicilNo && a.OnayDurumu == 0).ToList();

                var aldigiDersler = from ogrenciDers in dbContext.OgrenciDers
                                    where ogrenciDers.sicilNo == ogr.sicilNo
                                    join ders in dbContext.Dersler on ogrenciDers.dersId equals ders.dersId
                                    join ogrenci in dbContext.Ogrencis on ogrenciDers.ogrenciNo equals ogrenci.ogrenciNo
                                    select new
                                    {

                                        OgrenciNo = ogrenci.ogrenciNo,
                                        OgrenciAdi = ogrenci.ogrenciAdi,
                                        DersAdi = ders.dersAdi,

                                    };

                dataGridView1.DataSource = aldigiDersler.ToList();
                
                dataGridView2.Columns[6].Visible = false;
                dataGridView2.Columns[7].Visible = false;
                dataGridView2.Columns[3].Visible = false;
                dataGridView2.Columns[8].Visible = false;

            }


        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                int secilen = dataGridView2.SelectedCells[0].RowIndex;

                ogrenciNoTxt.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
                ogrenciAdiTxt.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
                talepDersTxt.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
                talepMesajiRich.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
                talepIdLbl.Text = dataGridView2.Rows[secilen].Cells[6].Value.ToString();
                dersIdLbl.Text = dataGridView2.Rows[secilen].Cells[8].Value.ToString();

                using (var dbContext = new Context())
                {

                    var query = from ogrenciDers in dbContext.OgrenciDers
                                join ders in dbContext.Dersler on ogrenciDers.dersId equals ders.dersId
                                join ogretmen in dbContext.Ogretmenler on ogrenciDers.sicilNo equals ogretmen.sicilNo
                                select new
                                {

                                    DersAdi = ders.dersAdi,
                                    OgretmenAdi = ogretmen.ogretmenAdi,
                                    OgretmenSoyadi = ogretmen.ogretmenSoyAdi,
                                    OgrenciNo = ogrenciDers.ogrenciNo,

                                };

                    var dersler = query.Where(a => a.OgrenciNo == ogrenciNoTxt.Text).ToList();
                    almisOlduguDersList.Items.Clear();
                    foreach (var item in dersler)

                    {
                        almisOlduguDersList.Items.Add(item.DersAdi + "(" + item.OgretmenAdi + " " + item.OgretmenSoyadi + ")");
                    }

                }

            }
            catch (Exception)
            {

                throw;

            }


        }

        private void talepOnayla_Click(object sender, EventArgs e)
        {
            try
            {

                using (var dbContext = new Context())
                {
                    var hoca = dbContext.Ogretmenler.FirstOrDefault(a => a.sicilNo == sicilNo);
                    var hocaDersleri = dbContext.OgrenciDers.Where(a => a.sicilNo == sicilNo && (a.dersId == 100 || a.dersId == 101)).ToList();

                    if (Convert.ToInt16(hoca.kontenjan) > hocaDersleri.Count)
                    {
                        var talep = dbContext.DersTalepleris.FirstOrDefault(a => a.talepId.ToString() == talepIdLbl.Text);

                        if (talep != null)
                        {

                            talep.onay = 1;
                            dbContext.SaveChanges();

                            var query1 = from dersTalep in dbContext.DersTalepleris
                                         join ders in dbContext.Dersler on dersTalep.dersId equals ders.dersId
                                         join ogretmen in dbContext.Ogretmenler on dersTalep.sicilNo equals ogretmen.sicilNo
                                         select new
                                         {
                                             OgrenciNo = dersTalep.ogrenciNo,
                                             OgrenciAdi = dersTalep.Ogrenci.ogrenciAdi,
                                             DersAdi = ders.dersAdi,
                                             TalepMesaji = dersTalep.talepMesaji,
                                             TalepTarihi = dersTalep.talepTarihi,
                                             OnayDurumu = dersTalep.onay,
                                             TalepId = dersTalep.talepId,
                                             SicilNo = dersTalep.sicilNo,
                                             DersId = dersTalep.dersId,
                                         };


                            dbContext.OgrenciDers.Add(new OgrenciDers { ogrenciNo = ogrenciNoTxt.Text, sicilNo = sicilNo, dersId = Convert.ToInt16(dersIdLbl.Text) });
                            dbContext.SaveChanges();

                            var dersiniAlanlar = from ogrenciDers in dbContext.OgrenciDers
                                                 where ogrenciDers.sicilNo == sicilNo
                                                 join ders in dbContext.Dersler on ogrenciDers.dersId equals ders.dersId
                                                 join ogrenci in dbContext.Ogrencis on ogrenciDers.ogrenciNo equals ogrenci.ogrenciNo
                                                 select new
                                                {
                                                    OgrenciNo = ogrenci.ogrenciNo,
                                                    OgrenciAdi = ogrenci.ogrenciAdi,
                                                    DersAdi = ders.dersAdi,

                                                };
                            
                            dataGridView1.DataSource = dersiniAlanlar.ToList();
                            dataGridView2.DataSource = query1.Where(a => a.SicilNo == sicilNo && a.OnayDurumu == 0).ToList();
                            dataGridView1.Refresh();
                            dataGridView2.Refresh();
                            MessageBox.Show("Ders Onaylandı");

                        }

                    } else
                    {

                        MessageBox.Show("Yeterli Kontenjanınız Yok.");

                    }

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata : " + ex);
            
            }
           


        }

        private void talepReddet_Click(object sender, EventArgs e)
        {

            try
            {

                using (var dbContext = new Context())
                {
                    
                        var talep = dbContext.DersTalepleris.FirstOrDefault(a => a.talepId.ToString() == talepIdLbl.Text);

                        if (talep != null)
                        {

                            talep.onay = -1;
                            dbContext.SaveChanges();

                            var query1 = from dersTalep in dbContext.DersTalepleris
                                         join ders in dbContext.Dersler on dersTalep.dersId equals ders.dersId
                                         join ogretmen in dbContext.Ogretmenler on dersTalep.sicilNo equals ogretmen.sicilNo
                                         select new
                                         {
                                             OgrenciNo = dersTalep.ogrenciNo,
                                             OgrenciAdi = dersTalep.Ogrenci.ogrenciAdi,
                                             DersAdi = ders.dersAdi,
                                             TalepMesaji = dersTalep.talepMesaji,
                                             TalepTarihi = dersTalep.talepTarihi,
                                             OnayDurumu = dersTalep.onay,
                                             TalepId = dersTalep.talepId,
                                             SicilNo = dersTalep.sicilNo,
                                             DersId = dersTalep.dersId,
                                         };
                            
                            dataGridView2.DataSource = query1.Where(a => a.SicilNo == sicilNo && a.OnayDurumu == 0).ToList();
                            dataGridView2.Refresh();
                            MessageBox.Show("Talep Reddedildi.");
                        }

                }

            }
            catch (Exception)
            {

                throw;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            HocaZorunluDersSecme hzds = new HocaZorunluDersSecme(sicilNo);
            hzds.Show();


        }

        private void ilgiAlaniEkleBtn_Click(object sender, EventArgs e)
        {

            try
            {

                    HocaIlgıAlanıEklemePaneli hocaIlgı = new HocaIlgıAlanıEklemePaneli(ogr);
                    hocaIlgı.Show();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kriterEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
               
                    HocaKriterDersEkleme kriterDers = new HocaKriterDersEkleme(ogr);
                    kriterDers.Show();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gelenKutusuBtn_Click(object sender, EventArgs e)
        {

            try
            {

                GelenKutusuPaneli genel = new GelenKutusuPaneli(ogr.sicilNo);
                genel.Show();

            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
