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
    public partial class AdminGirisEkranı : Form
    {
        public AdminGirisEkranı()
        {
            InitializeComponent();
        }

        private void adminGirisBtn_Click(object sender, EventArgs e)
        {

            try
            {

                using (var dbContext = new Context())
                {

                    var admin = dbContext.Yoneticis.FirstOrDefault(a => a.yoneticiNo == txtAdminNo.Text);

                    if(admin != null)
                    {

                        if(admin.yoneticiSifre == txtAdminSifre.Text)
                        {
                            this.Hide();
                            Admin adm = new Admin(admin.yoneticiAdi , admin.yoneticiNo);
                            adm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sifre Yanlis.");
                        }


                    }else
                    {

                        MessageBox.Show("Boyle bir admin bulunamadi.");
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
