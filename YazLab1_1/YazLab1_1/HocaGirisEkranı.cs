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
    public partial class HocaGirisEkranı : Form
    {
        public HocaGirisEkranı()
        {
            InitializeComponent();

        }

        private void hocaGirisBtn_Click(object sender, EventArgs e)
        {

            try
            {

                using (var dbContext = new Context())
                {

                    var hoca = dbContext.Ogretmenler.FirstOrDefault(a => a.sicilNo == txtSicilNo.Text);

                    if (hoca != null)
                    {

                        if (hoca.ogretmenSifre == txtHocaSifre.Text)
                        {
                            this.Hide();
                            HocaAnaPanel hocaPanel = new HocaAnaPanel(hoca.ogretmenAdi, hoca.sicilNo);
                            hocaPanel.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sifre Yanlis.");
                        }


                    }
                    else
                    {

                        MessageBox.Show("Boyle bir hoca bulunamadi.");
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
