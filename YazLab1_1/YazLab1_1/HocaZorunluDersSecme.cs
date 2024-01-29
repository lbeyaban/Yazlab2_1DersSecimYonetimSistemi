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
    public partial class HocaZorunluDersSecme : Form
    {
        Ogretmen ogr;
        public string ogrenciId;
        public HocaZorunluDersSecme(string sicilNo)
        {
            InitializeComponent();

            using(var dbContext = new Context())
            {

                ogr = dbContext.Ogretmenler.FirstOrDefault(a => a.sicilNo == sicilNo);

                var ogrenciler = dbContext.Ogrencis.ToList();

                foreach (var item in ogrenciler)
                {
                    ogrenciCombo.Items.Add(item.ogrenciAdi);
                }

                var query1 = from ogretmenDers in dbContext.OgretmenDers
                             where ogretmenDers.sicilNo == ogr.sicilNo
                             join ders in dbContext.Dersler on  ogretmenDers.dersId equals ders.dersId
                             select new
                             {

                                 DersAdi = ders.dersAdi,
                                 DersId = ders.dersId
                                
                             };


                foreach (var item in query1)
                {
                    dersCombo.Items.Add(item.DersAdi);
                }


            }


        }

        public HocaZorunluDersSecme(string sicilNo , string ogrenciNo)
        {
            InitializeComponent();

            using (var dbContext = new Context())
            {

                ogr = null;

                ogr = dbContext.Ogretmenler.FirstOrDefault(a => a.sicilNo == sicilNo);

                var ogrenci = dbContext.Ogrencis.FirstOrDefault(a=> a.ogrenciNo == ogrenciNo);
                this.ogrenciId = ogrenci.ogrenciNo;
                if (ogrenci != null)
                {
                    ogrenciCombo.Items.Add(ogrenci.ogrenciAdi);
                    
                }

                var query1 = from ogretmenDers in dbContext.OgretmenDers
                             where ogretmenDers.sicilNo == ogr.sicilNo
                             join ders in dbContext.Dersler on ogretmenDers.dersId equals ders.dersId
                             select new
                             {

                                 DersAdi = ders.dersAdi,
                                 DersId = ders.dersId

                             };


                foreach (var item in query1)
                {
                    dersCombo.Items.Add(item.DersAdi);
                }


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(ogrenciId != null) {

                using (var dbContext = new Context())
                {
                    var kontenjan = dbContext.OgrenciDers.Where(a => a.sicilNo == ogr.sicilNo && a.dersId == 100 && a.dersId == 101).ToList();

                    if(kontenjan.Count <= Convert.ToInt16(ogr.kontenjan))
                    {

                        MessageBox.Show("Kontenjan Dolmuştur.");

                    }else
                    {
                        string dersAdi = dersCombo.SelectedItem.ToString();
                        var ders = dbContext.Dersler.FirstOrDefault(a => a.dersAdi == dersAdi);

                        dbContext.OgrenciDers.Add(new OgrenciDers { ogrenciNo = ogrenciId, dersId = ders.dersId, sicilNo = ogr.sicilNo });
                        dbContext.SaveChanges();
                        MessageBox.Show("Ogrenci eklendi.");
                    }

                }

            } else
            {
                using (var dbContext = new Context())
                {
                    var kontenjan = dbContext.OgrenciDers.Where(a => a.sicilNo == ogr.sicilNo && a.dersId == 100 && a.dersId == 101).ToList();

                    if (kontenjan.Count <= Convert.ToInt16(ogr.kontenjan))
                    {
                        MessageBox.Show("Kontenjan Dolmuştur.");

                    }
                    else
                    {
                        string ogrenciAdi = ogrenciCombo.SelectedItem.ToString();
                        var ogrenci = dbContext.Ogrencis.FirstOrDefault(a => a.ogrenciAdi == ogrenciAdi);

                        string dersAdi = dersCombo.SelectedItem.ToString();
                        var ders = dbContext.Dersler.FirstOrDefault(a => a.dersAdi == dersAdi);

                        dbContext.OgrenciDers.Add(new OgrenciDers { ogrenciNo = ogrenci.ogrenciNo, dersId = ders.dersId, sicilNo = ogr.sicilNo });
                        dbContext.SaveChanges();
                        MessageBox.Show("Ogrenci eklendi.");
                    }

                }
            }
            

        }
    }
}
