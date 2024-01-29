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
    public partial class GenelAyarMenusu : Form
    {
        public GenelAyarMenusu()
        {
            InitializeComponent();

            using(var dbContext = new Context())
            {

                var genelAyarlar = dbContext.GenelAyarlars.FirstOrDefault();

                if(genelAyarlar != null)
                {
                    ayarId.Text = genelAyarlar.id.ToString();
                    mesajSiniriTxt.Text = genelAyarlar.mesajKarakterSiniri.ToString();
                    secimSuresiTxt.Text = genelAyarlar.dersSecimSüresi.ToString();
                    farkliHocaTxt.Text = genelAyarlar.farkliHocadanAlabilirMi.ToString();
                    asamaTxt.Text = genelAyarlar.asama.ToString();
                }

            }

        }


        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dbContext = new Context())
                {

                    var guncellenecekVeri = dbContext.GenelAyarlars.FirstOrDefault(a => a.id.ToString() == ayarId.Text);

                    if (guncellenecekVeri != null)
                    {
                        guncellenecekVeri.mesajKarakterSiniri = Convert.ToUInt16(mesajSiniriTxt.Text);
                        guncellenecekVeri.dersSecimSüresi = Convert.ToUInt16(secimSuresiTxt.Text);
                        guncellenecekVeri.farkliHocadanAlabilirMi = Convert.ToUInt16(farkliHocaTxt.Text);
                        guncellenecekVeri.asama = Convert.ToUInt16(asamaTxt.Text);
                        dbContext.SaveChanges();

                    }

                }

                MessageBox.Show("Ayarlar Guncellendi.");

            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
