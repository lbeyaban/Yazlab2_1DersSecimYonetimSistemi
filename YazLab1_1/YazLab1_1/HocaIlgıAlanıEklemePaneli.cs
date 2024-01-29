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
    public partial class HocaIlgıAlanıEklemePaneli : Form
    {
        public Ogretmen ogr;
        public HocaIlgıAlanıEklemePaneli()
        {
            InitializeComponent();

        }

        public void comboYenile()
        {

            try
            {
                using (var dbContext = new Context())
                {

                    var ilgiAlanlari = dbContext.IlgiAlanlari.ToList();
                    var hocaninIlgıAlanlari = dbContext.IlgiAlaniOgretmens.Where(a => a.sicilNo == ogr.sicilNo).ToList();


                    foreach (var item in ilgiAlanlari)
                    {

                        ilgiAlaniCheckBox.Items.Add(item.ilgiAlaniAdi);

                    }

                    for (int i = 0; i < ilgiAlanlari.Count; i++)
                    {
                        for (int j = 0; j < hocaninIlgıAlanlari.Count; j++)
                        {
                            if (ilgiAlanlari[i].ilgiAlaniAdi == hocaninIlgıAlanlari[j].IlgiAlanlari.ilgiAlaniAdi)
                            {
                                ilgiAlaniCheckBox.SetItemChecked(i, true);
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

        public HocaIlgıAlanıEklemePaneli(Ogretmen ogr)
        {
            InitializeComponent();
            this.ogr = ogr;
            comboYenile();

        }

        private void ilgiAlaniGuncelle_Click(object sender, EventArgs e)
        {

            using (var dbContext = new Context())
            {

                var silinecekVeri = dbContext.IlgiAlaniOgretmens.Where(a => a.sicilNo == ogr.sicilNo).ToList();

                if(silinecekVeri != null)
                {

                    dbContext.IlgiAlaniOgretmens.RemoveRange(silinecekVeri);
                    dbContext.SaveChanges();

                }

                for (int i = 0; i <= (ilgiAlaniCheckBox.Items.Count - 1); i++)
                {
                    if (ilgiAlaniCheckBox.GetItemChecked(i))
                    {
                        string ilgiAlaniAdi = ilgiAlaniCheckBox.Items[i].ToString();
                        var secilenİlgiAlani = dbContext.IlgiAlanlari.FirstOrDefault(a => a.ilgiAlaniAdi == ilgiAlaniAdi);

                        if (secilenİlgiAlani != null)
                        {

                            dbContext.IlgiAlaniOgretmens.Add(new IlgiAlaniOgretmen { ilgiAlaniId = secilenİlgiAlani.ilgiAlaniId, sicilNo = ogr.sicilNo });

                        }

                    }
                }

                dbContext.SaveChanges();
                MessageBox.Show("Ilgi Alanlari Eklendi.");

            }

        }
    }
}
