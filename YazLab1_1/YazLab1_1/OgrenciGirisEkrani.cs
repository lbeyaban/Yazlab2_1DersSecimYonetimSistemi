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
    public partial class OgrenciGirisEkrani : Form
    {
        public OgrenciGirisEkrani()
        {
            InitializeComponent();
        }

        private void OgrenciGirisEkrani_Load(object sender, EventArgs e)
        {
            
        }

        private void ogrGirisBtn_Click(object sender, EventArgs e)
        {

            try
            {

                using (var dbContext = new Context())
                {

                    var ogrenci = dbContext.Ogrencis.FirstOrDefault(a => a.ogrenciNo == txtOgrenciNo.Text);

                    if (ogrenci != null)
                    {

                        if (ogrenci.ogrenciSifre == txtOgrenciSifre.Text)
                        {
                            this.Hide();
                            OgrenciAnaPanel ogrAnaPanel = new OgrenciAnaPanel(ogrenci.ogrenciAdi, ogrenci.ogrenciNo);
                            ogrAnaPanel.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sifre Yanlis.");
                        }


                    }
                    else
                    {

                        MessageBox.Show("Boyle bir ogrenci bulunamadi.");
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
