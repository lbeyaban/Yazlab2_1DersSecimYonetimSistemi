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
    public partial class DersEkleme : Form
    {


        public DersEkleme()
        {
            InitializeComponent();
        }

        private void dersEkleBtn1_Click(object sender, EventArgs e)
        {

            try
            {

                string dersAdi = dersAdiTxtBox.Text;
                string dersAciklamasi = dersAciklamasiRichBox.Text;

                if(dersAdi == "" || dersAciklamasi == "")
                {

                    uyarıLbl.ForeColor = Color.Red;
                    uyarıLbl.Text = "Boş Alan Bırakmayınız.";

                }else
                {

                    using (var dbContext = new Context())
                    {

                        dbContext.Dersler.Add(new Dersler { dersAdi = dersAdi, dersAciklama = dersAciklamasi });
                        dbContext.SaveChanges();

                    }

                    uyarıLbl.Text = "Ders Başarılı Bir Şekilde Eklenmiştir.";
                    uyarıLbl.ForeColor = Color.Green;

                }
                    

                

            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata ile Karşılaşıldı.");

            }
        }
    }
}
