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
    public partial class GelenKutusuPaneli : Form
    {
        List<string> gelenMesajlarIdleri = new List<string>();
        List<string> tumIdler = new List<string>();
        string gonderenId;
        public GelenKutusuPaneli(string id)
        {
            InitializeComponent();

            gonderenId = id;

            using (var dbContext = new Context())
            {

                var gelenMesajlar = dbContext.Mesajlasmas.Where(a => a.gonderilenId == id).ToList();

                if(gelenMesajlar != null)
                {
                    foreach (var item in gelenMesajlar)
                    {

                        listBox1.Items.Add(item.mesaj);
                        gelenMesajlarIdleri.Add(item.gonderenId);

                    }
                }

                if (gonderenId.Length == 9)
                {

                    var ogretmenler = dbContext.Ogretmenler.ToList();

                    foreach (var item in ogretmenler)
                    {

                        comboBox1.Items.Add(item.ogretmenAdi + " " + item.ogretmenSoyAdi + " " + item.sicilNo);
                        tumIdler.Add(item.sicilNo);

                    }
                    

                }else
                {

                    var ogrenciler = dbContext.Ogrencis.ToList();

                    foreach (var item in ogrenciler)
                    {

                        comboBox1.Items.Add(item.ogrenciAdi + " " + item.ogrenciSoyAdi + " " + item.ogrenciNo);
                        tumIdler.Add(item.ogrenciNo);
                    }

                }


            }









        }
       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                richTextBox1.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
                gonderenIdLbl.Text = gelenMesajlarIdleri[listBox1.SelectedIndex];

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error  : " + ex );

            }
            


        }

        private void cevaplaBtn_Click(object sender, EventArgs e)
        {

            try
            {

                using (var dbContext = new Context())
                {

                    string gonderelicekId = tumIdler[comboBox1.SelectedIndex];

                    dbContext.Mesajlasmas.Add(new Mesajlasma { gonderenId = gonderenId, gonderilenId = gonderelicekId, mesaj = richTextBox2.Text });
                    dbContext.SaveChanges();
                    MessageBox.Show("Mesaj Gonderildi.");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata : " + ex);

            }

        }
    }
}
