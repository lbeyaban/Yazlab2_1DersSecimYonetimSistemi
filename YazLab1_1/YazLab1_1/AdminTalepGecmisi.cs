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
    public partial class AdminTalepGecmisi : Form
    {
        public AdminTalepGecmisi()
        {
            InitializeComponent();

            try
            {
                using (var dbContext = new Context())
                {

                    var talepler =  from DersTalepleri in dbContext.DersTalepleris
                                    join ders in dbContext.Dersler on DersTalepleri.dersId equals ders.dersId
                                    join ogretmen in dbContext.Ogretmenler on DersTalepleri.sicilNo equals ogretmen.sicilNo
                                    join ogrenci in dbContext.Ogrencis on DersTalepleri.ogrenciNo equals ogrenci.ogrenciNo
                                    select new
                                    {
                                        OgrenciNo = ogrenci.ogrenciNo,
                                        OgrenciAdi = ogrenci.ogrenciAdi,
                                        OgrenciSoyAdi = ogrenci.ogrenciSoyAdi,
                                        DersAdi = ders.dersAdi,
                                        OgretmenAdi = ogretmen.ogretmenAdi,
                                        OgretmenSoyadi = ogretmen.ogretmenSoyAdi,
                                        OnayDurmu = DersTalepleri.onay
                                    };

                    dataGridView1.DataSource = talepler.ToList();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata : " + ex);

            }
            

        }
    }
}
