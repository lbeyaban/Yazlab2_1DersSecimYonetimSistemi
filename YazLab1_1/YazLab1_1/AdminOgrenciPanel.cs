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
    public partial class AdminOgrenciPanel : Form
    {

        List<CheckedListItems> checkedListItems = new List<CheckedListItems>();
        public AdminOgrenciPanel()
        {

            InitializeComponent();

            using (var dbContext = new Context())
            {
                var ogrenciler = dbContext.Ogrencis.ToList();
                dataGridView1.DataSource = ogrenciler;

                var ilgiAlanlari = dbContext.IlgiAlanlari.ToList();

                foreach (var ilgiAlani in ilgiAlanlari)
                {
                    ilgiAlanlari1.Items.Add(ilgiAlani.ilgiAlaniAdi);

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
                    aldigiDersListesi.Items.Add(item.DersAdi + "(" + item.OgretmenAdi + " " + item.OgretmenSoyadi + ")");
                    checkedListItems.Add(new CheckedListItems(item.SicilNo, item.DersId));

                }



            }



        }

        public AdminOgrenciPanel(string ogrenciAdi , string ogrenciSoyadi, string ogrenciNo, string ogrenciSifre, string ogrenciTranscript, float ogrenciOrtalama)
        {

            InitializeComponent();

        }

        private void dersEkleBtn1_Click(object sender, EventArgs e)
        {

            try
            {

                using (var dbContext = new Context())
                {

                    dbContext.Ogrencis.Add(new Ogrenci { ogrenciAdi = ogrenciAdiTxt.Text, ogrenciSoyAdi = soyadTxt.Text, ogrenciNo = ogrenciNoTxt.Text, ogrenciSifre = ogrenciSifreTxt.Text, ogrenciGenelOrtalama = Convert.ToDouble(ogrenciGenelOrtalamaTxt.Text), transcriptPdf = ogrenciTranscriptTxt.Text });
                    dbContext.SaveChanges();
                    dataGridView1.DataSource = dbContext.Ogrencis.ToList();

                    for (int i = 0; i <= (ilgiAlanlari1.Items.Count - 1); i++)
                    {
                        if (ilgiAlanlari1.GetItemChecked(i))
                        {
                            string ilgiAlaniAdi = ilgiAlanlari1.Items[i].ToString();
                            var secilenİlgiAlani = dbContext.IlgiAlanlari.FirstOrDefault(a => a.ilgiAlaniAdi == ilgiAlaniAdi);

                            if (secilenİlgiAlani != null)
                            {

                                dbContext.IlgiAlanlarıOgrencis.Add(new IlgiAlanlarıOgrenci { ilgiAlaniId = secilenİlgiAlani.ilgiAlaniId, ogrenciNo = ogrenciNoTxt.Text });
                                dbContext.SaveChanges();

                            }

                        }
                    }


                    for (int i = 0; i <= (aldigiDersListesi.Items.Count - 1); i++)
                    {
                        if (aldigiDersListesi.GetItemChecked(i))
                        {

                            int dersId = checkedListItems[i].dersId;
                            string sicilNo = checkedListItems[i].sicilNo;

                            var secilenDersOgrenci = dbContext.OgrenciDers.FirstOrDefault(a => a.sicilNo == sicilNo && a.dersId == dersId && a.ogrenciNo == ogrenciNoTxt.Text);

                            if (secilenDersOgrenci == null)
                            {

                                dbContext.OgrenciDers.Add(new OgrenciDers { ogrenciNo = ogrenciNoTxt.Text, dersId = dersId , sicilNo = sicilNo });
                                dbContext.SaveChanges();

                            }

                        }
                    }

                }


                MessageBox.Show("Ogrenci Başarılı Bir Şekilde Eklendi.");


            }
            catch (Exception)
            {

                throw;

            }
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;


            ogrenciIdLbl.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            ogrenciNoTxt.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ogrenciAdiTxt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyadTxt.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            ogrenciSifreTxt.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            ogrenciTranscriptTxt.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            ogrenciGenelOrtalamaTxt.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            using (var dbContext = new Context())
            {

                var ogrenciIlgiAlanlari = dbContext.IlgiAlanlarıOgrencis
                    .Where(oia => oia.ogrenciNo == ogrenciNoTxt.Text)
                    .Select(oia => oia.IlgiAlanlari)
                    .ToList();


                for (int i = 0; i <= (ilgiAlanlari1.Items.Count - 1); i++)
                {

                    ilgiAlanlari1.SetItemChecked(i, false);

                }

                for (int i = 0; i <= (ilgiAlanlari1.Items.Count - 1); i++)
                {
                    foreach (var item in ogrenciIlgiAlanlari)
                    {

                        if (ilgiAlanlari1.Items[i].ToString() == item.ilgiAlaniAdi)
                        {
                            ilgiAlanlari1.SetItemChecked(i, true);

                        }

                    }


                }

            }

            using (var dbContext = new Context())
            {

                var ogrenciAldigiDersler = dbContext.OgrenciDers
                    .Where(oia => oia.ogrenciNo == ogrenciNoTxt.Text)
                    .Select(oia => oia)
                    .ToList();


                for (int i = 0; i <= (aldigiDersListesi.Items.Count - 1); i++)
                {

                    aldigiDersListesi.SetItemChecked(i, false);

                }

                foreach (var item in ogrenciAldigiDersler)
                {
                    for (int i = 0; i < checkedListItems.Count; i++)
                    {

                        if (item.dersId == checkedListItems[i].dersId && item.sicilNo == checkedListItems[i].sicilNo)
                        {

                            aldigiDersListesi.SetItemChecked(i, true);

                        }

                    }

                }


            }


        }

        private void ogrenciGuncelleBtn_Click(object sender, EventArgs e)
        {

            try
            {

                using (var dbContext = new Context())
                {

                    var degistirilecekVeri = dbContext.Ogrencis.FirstOrDefault(a => a.ogrenciNo.ToString() == ogrenciIdLbl.Text);
                    if (degistirilecekVeri != null)
                    {

                        degistirilecekVeri.ogrenciAdi = ogrenciAdiTxt.Text; 
                        degistirilecekVeri.ogrenciSoyAdi = soyadTxt.Text; 
                        degistirilecekVeri.ogrenciNo = ogrenciNoTxt.Text; 
                        degistirilecekVeri.ogrenciSifre = ogrenciSifreTxt.Text; 
                        degistirilecekVeri.transcriptPdf = ogrenciTranscriptTxt.Text; 
                        degistirilecekVeri.ogrenciGenelOrtalama = Convert.ToDouble(ogrenciGenelOrtalamaTxt.Text);
                        dbContext.SaveChanges();


                        var aldigiDersler = dbContext.OgrenciDers
                        .Where(vd => vd.ogrenciNo == ogrenciNoTxt.Text)
                        .ToList();

                        dbContext.OgrenciDers.RemoveRange(aldigiDersler);

                        var ilgiAlanlari = dbContext.IlgiAlanlarıOgrencis
                        .Where(vd => vd.ogrenciNo == ogrenciNoTxt.Text)
                        .ToList();

                        dbContext.IlgiAlanlarıOgrencis.RemoveRange(ilgiAlanlari);

                        for (int i = 0; i <= (ilgiAlanlari1.Items.Count - 1); i++)
                        {
                            if (ilgiAlanlari1.GetItemChecked(i))
                            {
                                string ilgiAlaniAdi = ilgiAlanlari1.Items[i].ToString();
                                var secilenİlgiAlani = dbContext.IlgiAlanlari.FirstOrDefault(a => a.ilgiAlaniAdi == ilgiAlaniAdi);

                                if (secilenİlgiAlani != null)
                                {

                                    dbContext.IlgiAlanlarıOgrencis.Add(new IlgiAlanlarıOgrenci { ilgiAlaniId = secilenİlgiAlani.ilgiAlaniId, ogrenciNo = ogrenciNoTxt.Text });
                                    dbContext.SaveChanges();

                                }

                            }
                        }

                        for (int i = 0; i <= (aldigiDersListesi.Items.Count - 1); i++)
                        {
                            if (aldigiDersListesi.GetItemChecked(i))
                            {

                                int dersId = checkedListItems[i].dersId;
                                string sicilNo = checkedListItems[i].sicilNo;

                                var secilenDersOgrenci = dbContext.OgrenciDers.FirstOrDefault(a => a.sicilNo == sicilNo && a.dersId == dersId && a.ogrenciNo == ogrenciNoTxt.Text);

                                if (secilenDersOgrenci == null)
                                {

                                    dbContext.OgrenciDers.Add(new OgrenciDers { ogrenciNo = ogrenciNoTxt.Text, dersId = dersId, sicilNo = sicilNo });
                                    dbContext.SaveChanges();

                                }

                            }
                        }


                        dbContext.SaveChanges();


                        dataGridView1.DataSource = dbContext.Ogrencis.ToList();


                    }

                    dataGridView1.Refresh();

                }

                MessageBox.Show("Ogrenci Güncellendi.");



            }
            catch (Exception)
            {

                throw;
            }


        }

        private void ogrenciSilBtn_Click_1(object sender, EventArgs e)
        {

            try
            {

                using (var dbContext = new Context())
                {
                    var silinecekVeri = dbContext.Ogrencis.FirstOrDefault(a => a.ogrenciNo == ogrenciNoTxt.Text);


                    if (silinecekVeri != null)
                    {

                        var ilgiAlanlari = dbContext.IlgiAlanlarıOgrencis
                        .Where(vd => vd.ogrenciNo == ogrenciNoTxt.Text)
                        .ToList();

                        dbContext.IlgiAlanlarıOgrencis.RemoveRange(ilgiAlanlari);

                        var aldigiDersler = dbContext.OgrenciDers
                        .Where(vd => vd.ogrenciNo == ogrenciNoTxt.Text)
                        .ToList();

                        dbContext.OgrenciDers.RemoveRange(aldigiDersler);

                        dbContext.Ogrencis.Remove(silinecekVeri);
                        dbContext.SaveChanges();

                        dataGridView1.DataSource = dbContext.Ogretmenler.ToList();
                    }

                    dataGridView1.DataSource = dbContext.Ogrencis.ToList();

                }

                MessageBox.Show("Ogrenci Silindi.");

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
