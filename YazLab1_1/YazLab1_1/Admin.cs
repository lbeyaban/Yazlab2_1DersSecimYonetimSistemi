using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace YazLab1_1
{
    public partial class Admin : Form
    {
        List<string> arastırmaAlacaklar = new List<string>();
        List<string> bitirmeAlacaklar = new List<string>();
        public Admin()
        {
            InitializeComponent();
        }

        public void aldimiKontrol()
        {
            int arastırmaVarMi = 0;
            int bitirmeVarMi = 0;
            try
            {

                using (var dbContext = new Context())
                {

                    var ogrenciler = dbContext.Ogrencis.ToList();

                    foreach (var item in ogrenciler)
                    {
                        var aldıgıProjeler = dbContext.OgrenciDers.Where(a => a.ogrenciNo == item.ogrenciNo).ToList();

                        foreach (var item1 in aldıgıProjeler)
                        {
                            if (item1.dersId == 100)
                            {
                                arastırmaVarMi = 1;
                            }
                            if (item1.dersId == 101)
                            {
                                bitirmeVarMi = 1;
                            }

                        }

                        if (arastırmaVarMi == 0)
                        {
                            arastırmaAlacaklar.Add(item.ogrenciNo);
                        }
                        else
                        {
                            arastırmaVarMi = 0;
                        }

                        if (bitirmeVarMi == 0)
                        {

                            bitirmeAlacaklar.Add(item.ogrenciNo);

                        }
                        else
                        {
                            bitirmeVarMi = 0;
                        }

                    }

                }
            }catch
            {

            }
        }

        public void aldimiOrtalamaKontrol()
        {
            int arastırmaVarMi = 0;
            int bitirmeVarMi = 0;
            try
            {

                using (var dbContext = new Context())
                {

                    var ogrenciler = dbContext.Ogrencis
                        .OrderByDescending(ogrenci => ogrenci.ogrenciGenelOrtalama)
                        .ToList();
                    

                    foreach (var item in ogrenciler)
                    {
                        var aldıgıProjeler = dbContext.OgrenciDers.Where(a => a.ogrenciNo == item.ogrenciNo).ToList();

                        foreach (var item1 in aldıgıProjeler)
                        {
                            if (item1.dersId == 100)
                            {
                                arastırmaVarMi = 1;
                            }
                            if (item1.dersId == 101)
                            {
                                bitirmeVarMi = 1;
                            }

                        }

                        if (arastırmaVarMi == 0)
                        {
                            arastırmaAlacaklar.Add(item.ogrenciNo);
                        }
                        else
                        {
                            arastırmaVarMi = 0;
                        }

                        if (bitirmeVarMi == 0)
                        {

                            bitirmeAlacaklar.Add(item.ogrenciNo);

                        }
                        else
                        {
                            bitirmeVarMi = 0;
                        }

                    }

                }
            }
            catch
            {

            }
        }

        public Admin(string adminAdi , string adminNo)
        {
            InitializeComponent();
            lblYoneticiAdi.Text = adminAdi;
            lblYoneticiNo.Text = adminNo;
          
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void ogrenciListeleBtn_Click(object sender, EventArgs e)
        {

            AdminOgrenciPanel adminOgrenciPanel = new AdminOgrenciPanel();
            adminOgrenciPanel.Show();

        }

        private void ogrenciEkle_Click(object sender, EventArgs e)
        {
            AdminOgrenciPanel ogrEkle = new AdminOgrenciPanel();
            ogrEkle.Show();

        }

        private void programAyariBtn_Click(object sender, EventArgs e)
        {

            GenelAyarMenusu genelAyarMenu = new GenelAyarMenusu();
            genelAyarMenu.Show();

        }

        private void dersPanelBtn_Click(object sender, EventArgs e)
        {

            AdminDersPaneli adminDersPanel = new AdminDersPaneli();
            adminDersPanel.Show();

        }

        private void ilgiAlaniPanel_Click(object sender, EventArgs e)
        {

            AdminIlgıAlaniPanel adminIlgiAlani = new AdminIlgıAlaniPanel();
            adminIlgiAlani.Show();

        }

        private void ogretmenPanelBtn_Click(object sender, EventArgs e)
        {

            AdminOgretmenPanel adminOgretmenPanel = new AdminOgretmenPanel();
            adminOgretmenPanel.Show();

        }

        private void topluOgrenciOlustur_Click(object sender, EventArgs e)
        {

            try
            {

                List<string> Isimler = new List<string>
                    {
                        "Ahmet", "Ayşe", "Mehmet", "Elif", "Emir", "Zeynep", "Can", "Selma", "Burak", "Aslı",
                        "Cem", "İrem", "Umut", "Deniz", "Nazlı", "Kerem", "Gözde", "Ali", "Selen", "Baran",
                        "Gamze", "İsmail", "Yasemin", "Ömer", "Ela", "Arda", "Yasmin", "Metin", "Melek", "Serkan",
                        "Ceren", "Berk", "Ebru", "Kaan", "Melis", "Alp", "Aysu", "Mert", "Sude", "Cihan", "Sedef",
                        "Onur", "Şeyma", "Ege", "Pınar", "Taner", "İpek", "Batuhan", "Begüm", "Emre", "Merve",
                        "Kerem", "Gül", "Ali", "Aylin", "Orhan", "Sibel", "Uğur", "Cansu", "İlker", "Deniz",
                        "Yasemin", "Sefa", "Duygu", "Özgür", "Selin", "Ercan", "Gizem", "Ferhat", "Nur", "Selim",
                        "Esra", "Gökhan", "Derya", "Tolga", "Pelin", "Hüseyin", "Elif", "Ulaş", "Asude", "Eray",
                        "Selcan", "Levent", "Ebru", "Ahmet", "Gizem", "Eren", "Gülcan", "Kerem", "Süreyya", "Serhat"
                    };

                List<string> soyisimler = new List<string>
                    {
                        "Yılmaz", "Kaya", "Şahin", "Koç", "Aydın", "Demir", "Çelik", "Arslan", "Erdoğan", "Karadağ",
                        "Bulut", "Sarı", "Türk", "Öztürk", "Kurt", "Çakır", "Güneş", "Uysal", "Kartal", "Aksu",
                        "Doğan", "Gökçe", "Eren", "Gürbüz", "Taşkın", "Savaş", "Karadeniz", "Güler", "Alkan", "Kaplan",
                        "Kurtuluş", "Koçak", "Kayaalp", "Yavuz", "Kılıç", "Soylu", "Karakuş", "Sarıkaya", "Taş", "Özdemir",
                        "Kocabaş", "Erkul", "Şen", "Yalçın", "Aktaş", "Şimşek", "Ataman", "Çetin", "Cengiz", "Aksoy",
                        "Alp", "Şeker", "Günay", "Arıkan", "Karahan", "Duman", "Avcı", "Çınar", "Kıraç", "Karaman",
                        "Büyük", "Dağdelen", "Çolak", "Eroğlu", "Tunç", "Demirci", "Çetinkaya", "Gökgöz", "Toprak", "Güzel",
                        "Orman", "Kart", "Bulut", "Yavuz", "Ak", "Özen", "Gür", "Güngör", "Demirel", "Bakır", "Göçmen",
                        "Küçük", "Küçüker", "Tuncel", "Soydan", "Önal", "Şener", "Alpsoy", "Mazlum", "Baş", "Akalın"
                    };

                List<Dersler> dersListesi;
                List<Double> notlar = new List<double> { 0, 0.5, 1, 1.5, 2, 2.5, 3, 3.5, 4 };

                if(ogrenciSayisi.Text != "")
                {
                    Console.WriteLine(Isimler.Count + "  " + soyisimler.Count);
                    Random rnd = new Random();
                    for (int i = 0; i < Convert.ToInt16(ogrenciSayisi.Text); i++)
                    {
                        double ortalama = 0;
                        Thread.Sleep(100);
                        int sayi = rnd.Next(0, 91);
                        int sayi2 = rnd.Next(0, 91);

                        string isim = Isimler[sayi];
                        string soyisim = soyisimler[sayi];

                        Console.WriteLine(isim + "  " + soyisim);

                        Thread.Sleep(100);

                        int ogrenciId = rnd.Next(210000000, 210999999);

                        using (var dbContext = new Context())
                        {
                            dersListesi = dbContext.Dersler.ToList();
                            dbContext.Ogrencis.Add(new Ogrenci { ogrenciAdi = isim, ogrenciSoyAdi = soyisim, ogrenciNo = ogrenciId.ToString(), ogrenciSifre = "123", transcriptPdf = "rastgele.pdf", ogrenciGenelOrtalama = 0 });
                            dbContext.SaveChanges();

                            for (int j = 0; j < 10; j++)
                            {
                                Thread.Sleep(100);

                                int dersId = dersListesi[rnd.Next(0, dersListesi.Count - 1)].dersId;

                                var transcriptler = dbContext.Transcripts.FirstOrDefault(a => a.dersId == dersId && a.ogrenciNo == ogrenciId.ToString());
                                double not = notlar[rnd.Next(0, 9)];

                                if (transcriptler == null)
                                {

                                    dbContext.Transcripts.Add(new Transcript { dersId = dersId, dersNotu = not, ogrenciNo = ogrenciId.ToString() });

                                } else
                                {
                                    while (true)
                                    {
                                        dersId = dersListesi[rnd.Next(0, dersListesi.Count - 1)].dersId;
                                        transcriptler = dbContext.Transcripts.FirstOrDefault(a => a.dersId == dersId && a.ogrenciNo == ogrenciId.ToString());
                                        if (transcriptler == null)
                                        {

                                            dbContext.Transcripts.Add(new Transcript { dersId = dersId, dersNotu = not, ogrenciNo = ogrenciId.ToString() });
                                            break;
                                        }
                                    }

                                }

                                ortalama += not;

                            }

                            var guncelle = dbContext.Ogrencis.FirstOrDefault(a => a.ogrenciNo == ogrenciId.ToString());

                            if(guncelle != null)
                            {
                                ortalama /= 10;
                                guncelle.ogrenciGenelOrtalama = ortalama;
                            }

                            dbContext.SaveChanges();

                        }

                    }
                    MessageBox.Show("Ogrenci ve Transcipt başarılı bir şekilde eklendi");
                }
                else
                {
                    MessageBox.Show("Ogrenci Sayisi Giriniz.");
                }

            }
            catch (Exception a)
            {

                Console.WriteLine("Hata : ", a.Message);
                throw;

            }



        }

        private void rastgeleAta_Click(object sender, EventArgs e)
        {
            try
            {
                aldimiKontrol();

                Random rnd = new Random();
                using (var dbContext = new Context())
                {

                    var query = from ogretmenDers in dbContext.OgretmenDers
                                join ders in dbContext.Dersler on ogretmenDers.dersId equals ders.dersId
                                join ogretmen in dbContext.Ogretmenler on ogretmenDers.sicilNo equals ogretmen.sicilNo
                                select new
                                {
                                    DersAdi = ders.dersAdi,
                                    OgretmenAdi = ogretmen.ogretmenAdi,
                                    OgretmenSoyadi = ogretmen.ogretmenSoyAdi,
                                    DersId = ders.dersId,
                                    SicilNo = ogretmen.sicilNo,
                                    Kontenjan = ogretmen.kontenjan

                                };

                    var ogretmenler = dbContext.Ogretmenler.ToList();

                    foreach (var item in ogretmenler)
                    {
                        string sicilNo = item.sicilNo;

                        int toplamVerdigiProjeDersi = dbContext.OgrenciDers.Where(a => a.sicilNo == item.sicilNo && (a.dersId == 100 || a.dersId == 101)).ToList().Count;

                        int kalanKontenjan = Convert.ToInt16(item.kontenjan) - toplamVerdigiProjeDersi;

                        for (int i = 0; i < kalanKontenjan; i++)
                        {

                            if (arastırmaAlacaklar.Count > 0)
                            {
                                int sayi = rnd.Next(0, arastırmaAlacaklar.Count);
                                dbContext.OgrenciDers.Add(new OgrenciDers { dersId = 100, ogrenciNo = arastırmaAlacaklar[sayi], sicilNo = sicilNo });
                                dbContext.SaveChanges();
                                arastırmaAlacaklar.RemoveAt(sayi);
                            }
                            else if (bitirmeAlacaklar.Count > 0)
                            {
                                int sayi = rnd.Next(0, bitirmeAlacaklar.Count);
                                dbContext.OgrenciDers.Add(new OgrenciDers { dersId = 101, ogrenciNo = bitirmeAlacaklar[sayi], sicilNo = sicilNo });
                                dbContext.SaveChanges();
                                bitirmeAlacaklar.RemoveAt(sayi);
                            }

                        }

                        sicilNo = "";

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ortalamayaGoreAta_Click(object sender, EventArgs e)
        {
            try
            {
                aldimiOrtalamaKontrol();

                using (var dbContext = new Context())
                {

                    foreach (var item in arastırmaAlacaklar)
                    {
                        Console.WriteLine(item);

                    }

                    var query = from ogretmenDers in dbContext.OgretmenDers
                                join ders in dbContext.Dersler on ogretmenDers.dersId equals ders.dersId
                                join ogretmen in dbContext.Ogretmenler on ogretmenDers.sicilNo equals ogretmen.sicilNo
                                select new
                                {
                                    DersAdi = ders.dersAdi,
                                    OgretmenAdi = ogretmen.ogretmenAdi,
                                    OgretmenSoyadi = ogretmen.ogretmenSoyAdi,
                                    DersId = ders.dersId,
                                    SicilNo = ogretmen.sicilNo,
                                    Kontenjan = ogretmen.kontenjan

                                };

                    var ogretmenler = dbContext.Ogretmenler.ToList();

                    foreach (var item in ogretmenler)
                    {
                        string sicilNo = item.sicilNo;

                        int toplamVerdigiProjeDersi = dbContext.OgrenciDers.Where(a => a.sicilNo == item.sicilNo && (a.dersId == 100 || a.dersId == 101)).ToList().Count;

                        int kalanKontenjan = Convert.ToInt16(item.kontenjan) - toplamVerdigiProjeDersi;

                        for (int i = 0; i < kalanKontenjan; i++)
                        {

                            if (arastırmaAlacaklar.Count > 0)
                            {
                                dbContext.OgrenciDers.Add(new OgrenciDers { dersId = 100, ogrenciNo = arastırmaAlacaklar[0], sicilNo = sicilNo });
                                dbContext.SaveChanges();
                                arastırmaAlacaklar.RemoveAt(0);
                            }
                            else if (bitirmeAlacaklar.Count > 0)
                            {
                                dbContext.OgrenciDers.Add(new OgrenciDers { dersId = 101, ogrenciNo = bitirmeAlacaklar[0], sicilNo = sicilNo });
                                dbContext.SaveChanges();
                                bitirmeAlacaklar.RemoveAt(0);
                            }

                        }

                        sicilNo = "";

                    }



                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void talepGecmisiList_Click(object sender, EventArgs e)
        {

            try
            {

                AdminTalepGecmisi admin = new AdminTalepGecmisi();
                admin.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex);
            }



        }
    }
}
