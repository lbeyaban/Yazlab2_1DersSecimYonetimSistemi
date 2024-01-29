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
    public partial class AdminOgretmenPanel : Form
    {
        public AdminOgretmenPanel()
        {
            InitializeComponent();

            try
            {
                using (var dbContext = new Context())
                {

                    var ilgiListesi = dbContext.IlgiAlanlari.ToList();

                    foreach (var item in ilgiListesi)
                    {

                        ilgiListesi1.Items.Add(item.ilgiAlaniAdi);

                    }

                }

                using (var dbContext = new Context())
                {

                    var dersListesi = dbContext.Dersler.ToList();

                    foreach (var item in dersListesi)
                    {

                        verdigiDersListesi.Items.Add(item.dersAdi);

                    }

                }

                using (var dbContext = new Context())
                {

                    var ogretmenListesi = dbContext.Ogretmenler.ToList();

                    dataGridView1.DataSource = ogretmenListesi;

                }


            }
            catch (Exception)
            {

                throw;
            }
            


        }

        private void AdminOgretmenPanel_Load(object sender, EventArgs e)
        {

        }

        private void ogrenciEkleBtn_Click(object sender, EventArgs e)
        {

            try
            {

                using (var dbContext = new Context())
                {
                    var ogretmenVarMi = dbContext.Ogretmenler.FirstOrDefault(a => a.sicilNo == sicilNoTxt.Text);
                    if (ogretmenVarMi == null)
                    {
                        dbContext.Ogretmenler.Add(new Ogretmen { sicilNo = sicilNoTxt.Text, ogretmenAdi = ogretmenAdiTxt.Text, ogretmenSoyAdi = soyadTxt.Text, ogretmenSifre = ogretmenSifreTxt.Text , kontenjan = ogretmenKontenjanTxt.Text});
                        dbContext.SaveChanges();

                        dataGridView1.DataSource = dbContext.Ogretmenler.ToList();

                        for (int i = 0; i <= (ilgiListesi1.Items.Count - 1); i++)
                        {
                            if (ilgiListesi1.GetItemChecked(i))
                            {
                                string ilgiAlaniAdi = ilgiListesi1.Items[i].ToString();
                                var secilenİlgiAlani = dbContext.IlgiAlanlari.FirstOrDefault(a => a.ilgiAlaniAdi == ilgiAlaniAdi);

                                if (secilenİlgiAlani != null)
                                {

                                    dbContext.IlgiAlaniOgretmens.Add(new IlgiAlaniOgretmen { ilgiAlaniId = secilenİlgiAlani.ilgiAlaniId, sicilNo = sicilNoTxt.Text });
                                    dbContext.SaveChanges();

                                }

                            }
                        }

                        for (int i = 0; i <= (verdigiDersListesi.Items.Count - 1); i++)
                        {
                            if (verdigiDersListesi.GetItemChecked(i))
                            {
                                string dersAdi = verdigiDersListesi.Items[i].ToString();
                                var secilenDers = dbContext.Dersler.FirstOrDefault(a => a.dersAdi == dersAdi);

                                Console.WriteLine(dersAdi + "  " + secilenDers.dersId);

                                if (secilenDers != null)
                                {

                                    dbContext.OgretmenDers.Add(new OgretmenDers { dersId = secilenDers.dersId, sicilNo = sicilNoTxt.Text });
                                    dbContext.SaveChanges();

                                }

                            }
                        }

                        MessageBox.Show("Ogretmen Kaydedildi.");

                    }
                    else
                    {
                        MessageBox.Show("Bu Ogretmen Sistemde Kayitli.");
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

            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            sicilNoTxt.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ogretmenAdiTxt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyadTxt.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            ogretmenSifreTxt.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            ogretmenKontenjanTxt.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();


            using (var dbContext = new Context())
            {

                var ogretmenIlgiAlanlari = dbContext.IlgiAlaniOgretmens
                    .Where(oia => oia.sicilNo == sicilNoTxt.Text)
                    .Select(oia => oia.IlgiAlanlari)
                    .ToList();


                for (int i = 0; i <= (ilgiListesi1.Items.Count - 1); i++)
                {

                    ilgiListesi1.SetItemChecked(i , false);

                }

                for (int i = 0; i <= (ilgiListesi1.Items.Count - 1); i++)
                {
                    foreach (var item in ogretmenIlgiAlanlari)
                    {

                        if (ilgiListesi1.Items[i].ToString() == item.ilgiAlaniAdi)
                        {
                            ilgiListesi1.SetItemChecked(i, true);

                        }

                    }


                }

            }

            using (var dbContext = new Context())
            {

                var verilenDersler = dbContext.OgretmenDers
                    .Where(vd => vd.sicilNo == sicilNoTxt.Text)
                    .Select(oia => oia.Dersler)
                    .ToList();


                for (int i = 0; i <= (verdigiDersListesi.Items.Count - 1); i++)
                {

                    verdigiDersListesi.SetItemChecked(i, false);

                }

                for (int i = 0; i <= (verdigiDersListesi.Items.Count - 1); i++)
                {
                    foreach (var item in verilenDersler)
                    {

                        if (verdigiDersListesi.Items[i].ToString() == item.dersAdi)
                        {
                            verdigiDersListesi.SetItemChecked(i, true);

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

                    var guncellenecekOgretmen = dbContext.Ogretmenler.FirstOrDefault(a => a.sicilNo == sicilNoTxt.Text);

                    if(guncellenecekOgretmen != null)
                    {
                        guncellenecekOgretmen.ogretmenAdi = ogretmenAdiTxt.Text;
                        guncellenecekOgretmen.ogretmenSoyAdi = soyadTxt.Text;
                        guncellenecekOgretmen.ogretmenSifre = ogretmenSifreTxt.Text;
                        guncellenecekOgretmen.kontenjan = ogretmenKontenjanTxt.Text;
                        guncellenecekOgretmen.sicilNo = sicilNoTxt.Text;

                        dbContext.SaveChanges();

                        dataGridView1.DataSource = dbContext.Ogretmenler.ToList();

                    }

                    var verilenDersler = dbContext.OgretmenDers
                    .Where(vd => vd.sicilNo == sicilNoTxt.Text)
                    .ToList();

                    dbContext.OgretmenDers.RemoveRange(verilenDersler);

                    var ilgiAlanlari = dbContext.IlgiAlaniOgretmens
                    .Where(vd => vd.sicilNo == sicilNoTxt.Text)
                    .ToList();

                    dbContext.IlgiAlaniOgretmens.RemoveRange(ilgiAlanlari);

                    for (int i = 0; i <= (ilgiListesi1.Items.Count - 1); i++)
                    {
                        if (ilgiListesi1.GetItemChecked(i))
                        {
                            string ilgiAlaniAdi = ilgiListesi1.Items[i].ToString();
                            var secilenİlgiAlani = dbContext.IlgiAlanlari.FirstOrDefault(a => a.ilgiAlaniAdi == ilgiAlaniAdi);

                            if (secilenİlgiAlani != null)
                            {

                                dbContext.IlgiAlaniOgretmens.Add(new IlgiAlaniOgretmen { ilgiAlaniId = secilenİlgiAlani.ilgiAlaniId, sicilNo = sicilNoTxt.Text });
                                dbContext.SaveChanges();

                            }

                        }
                    }

                    for (int i = 0; i <= (verdigiDersListesi.Items.Count - 1); i++)
                    {
                        if (verdigiDersListesi.GetItemChecked(i))
                        {
                            string dersAdi = verdigiDersListesi.Items[i].ToString();
                            var secilenDers = dbContext.Dersler.FirstOrDefault(a => a.dersAdi == dersAdi);

                            Console.WriteLine(dersAdi + "  " + secilenDers.dersId);

                            if (secilenDers != null)
                            {

                                dbContext.OgretmenDers.Add(new OgretmenDers { dersId = secilenDers.dersId, sicilNo = sicilNoTxt.Text });
                                dbContext.SaveChanges();

                            }

                        }
                    }


                    dbContext.SaveChanges();

                    MessageBox.Show("Ogretmen Guncellendi.");

                }





            }
            catch (Exception)
            {

                throw;
            }






        }

        private void ogrenciSilBtn_Click(object sender, EventArgs e)
        {

            try
            {

                using(var dbContext = new Context())
                {

                    var silinecekOgretmen = dbContext.Ogretmenler.FirstOrDefault(a => a.sicilNo == sicilNoTxt.Text);

                    if(silinecekOgretmen != null)
                    {
                        var verilenDersler = dbContext.OgretmenDers
                        .Where(vd => vd.sicilNo == sicilNoTxt.Text)
                        .ToList();

                        dbContext.OgretmenDers.RemoveRange(verilenDersler);

                        var ilgiAlanlari = dbContext.IlgiAlaniOgretmens
                        .Where(vd => vd.sicilNo == sicilNoTxt.Text)
                        .ToList();

                        dbContext.IlgiAlaniOgretmens.RemoveRange(ilgiAlanlari);

                        dbContext.Ogretmenler.Remove(silinecekOgretmen);
                        dbContext.SaveChanges();
                        MessageBox.Show("Ogretmen Silindi");

                        dataGridView1.DataSource = dbContext.Ogretmenler.ToList();

                    }
                    

                }


            }
            catch (Exception)
            {

                throw;
            }



        }
    }
}
