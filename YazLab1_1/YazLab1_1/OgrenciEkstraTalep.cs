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
    public partial class OgrenciEkstraTalep : Form
    {
        List<int> dersIdleri = new List<int>();
        string ogrenciNo;
        string sicilNo;
        public OgrenciEkstraTalep(string ogrenciNo , string sicilNo)
        {
            InitializeComponent();
            this.ogrenciNo = ogrenciNo;
            this.sicilNo = sicilNo;

            using (var dbContext = new Context())
            {
                var dersler = from ogretmenDers in dbContext.OgretmenDers
                            where ogretmenDers.sicilNo == sicilNo
                            join ders in dbContext.Dersler on ogretmenDers.dersId equals ders.dersId
                            select new
                            {
                                DersAdi = ders.dersAdi,
                                DersId = ders.dersId
                            };

                foreach (var item in dersler)
                {

                    comboBox1.Items.Add(item.DersAdi);
                    dersIdleri.Add(item.DersId);

                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                using (var dbContext = new Context())
                {

                    var genelAyarlar = dbContext.GenelAyarlars.FirstOrDefault();
                    int index = comboBox1.SelectedIndex;

                    if (genelAyarlar.farkliHocadanAlabilirMi == 1)
                    {
                        dbContext.DersTalepleris.Add(new DersTalepleri { dersId = dersIdleri[index], ogrenciNo = ogrenciNo, sicilNo = sicilNo });
                        dbContext.SaveChanges();
                        MessageBox.Show("Talep Gonderildi.");
                    }
                    else
                    {
                        int dersId = dersIdleri[index];

                        var dersVarMi = dbContext.OgrenciDers.FirstOrDefault(a => a.ogrenciNo == ogrenciNo && a.dersId == dersId);
                        
                        if(dersVarMi == null)
                        {
                            dbContext.DersTalepleris.Add(new DersTalepleri { dersId = dersIdleri[index], ogrenciNo = ogrenciNo, sicilNo = sicilNo });
                            dbContext.SaveChanges();
                            MessageBox.Show("Talep Gonderildi.");
                        }else
                        {

                            MessageBox.Show("Genel Ayarlar sebebi ile dersleri tek hocadan alabilirsiniz.");

                        }

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
