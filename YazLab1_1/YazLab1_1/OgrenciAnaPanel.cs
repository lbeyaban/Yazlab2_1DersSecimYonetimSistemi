using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

namespace YazLab1_1
{
    public partial class OgrenciAnaPanel : Form
    {
        Ogrenci ogr;
        GenelAyarlar genelAyarlar;
        GeriSayim geriSayim;

        public OgrenciAnaPanel()
        {
            InitializeComponent();
        }

        public void dataGridDoldur()
        {
            

            using (var dbContext = new Context())
            {

                var query = from transcript in dbContext.Transcripts
                            where transcript.ogrenciNo == ogr.ogrenciNo
                            join ders in dbContext.Dersler on transcript.dersId equals ders.dersId
                            select new
                            {

                                DersAdi = ders.dersAdi,
                                DersNotu = transcript.dersNotu

                            };

                dataGridView1.DataSource = query.ToList();

            }

        }

        public void transcriptKontrol()
        {
            using (var dbContext = new Context())
            {
                var transcript = dbContext.Transcripts.Where(a => a.ogrenciNo == ogr.ogrenciNo).ToList();

                if (transcript.Count == 0)
                {

                    dersSecimBtn.Enabled = false;

                }
                else
                {
                    dersSecimBtn.Enabled = true;
                    MessageBox.Show("Transcript Başarılı Bir Şekilde Eklendi. Proje talebi oluşturabilirsiniz.");
                }

                if (genelAyarlar.asama != 1)
                {

                    dersSecimBtn.Enabled = false;
                    hocaListeleBtn.Enabled = false;
                    lblGeriSayim.Text = "0";

                }
                

            }
        }

        public OgrenciAnaPanel(string ogrenciAdi , string ogrenciNo)
        {
            InitializeComponent();

            using (var dbContext = new Context())
            {

                genelAyarlar = dbContext.GenelAyarlars.FirstOrDefault();
                if(genelAyarlar.asama == 1)
                {
                    geriSayim = new GeriSayim(genelAyarlar.dersSecimSüresi, lblGeriSayim, dersSecimBtn);
                    geriSayim.Start();
                }

                var ogrenci = dbContext.Ogrencis.FirstOrDefault(a => a.ogrenciNo == ogrenciNo);

                if(ogrenci != null)
                {
                    ogr = ogrenci;

                }else
                {

                    MessageBox.Show("Ogrenciye ulasilamadi...");
                    Application.Exit();

                }

            }

            lblOgrenciAdi.Text = ogr.ogrenciAdi;
            lblOgrenciNo.Text = ogr.ogrenciNo;
            ortalamaLbl.Text = ogr.ogrenciGenelOrtalama.ToString();
            transcriptKontrol();
            dataGridDoldur();

        }

        private void dersSecimBtn_Click(object sender, EventArgs e)
        {

            OgrenciDersSecimEkrani ogrenciDersSecimEkrani = new OgrenciDersSecimEkrani(ogr.ogrenciNo);
            ogrenciDersSecimEkrani.Show();

        }

        public void bulVeEkle(string devamText)
        {
            string dersAdi = "";
            int i;
            for (i = 0; i < devamText.Length; i++)
            {
                if(Convert.ToChar(devamText[i]) == '(')
                {

                    break;

                }else
                {
                    dersAdi += Convert.ToChar(devamText[i]);
                }
            }
            dersAdi = dersAdi.Trim();

            MatchCollection matches = Regex.Matches(devamText, @"\b(AA|BA|BB|CB|CC|DC|DD|FD|FF| D| E| G| N| K| S)\b");

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {

                    using (var dbContext = new Context())
                    {
                        double dersNotu;
                        var ders = dbContext.Dersler.FirstOrDefault(a => a.dersAdi == dersAdi);
                        if (match.Value == "AA")
                            dersNotu = 4;
                        else if (match.Value == "BA")
                            dersNotu = 3.5;
                        else if (match.Value == "BB")
                            dersNotu = 3;
                        else if (match.Value == "CB")
                            dersNotu = 2.5;
                        else if (match.Value == "CC")
                            dersNotu = 2;
                        else if (match.Value == "DC")
                            dersNotu = 1.5;
                        else if (match.Value == "DD")
                            dersNotu = 1;
                        else
                            dersNotu = 0;


                        if (ders == null)
                        {
                            dbContext.Dersler.Add(new Dersler { dersAdi = dersAdi });
                            dbContext.SaveChanges();

                            var dersIdd = dbContext.Dersler.FirstOrDefault(a => a.dersAdi == dersAdi);

                            if(dersIdd != null)
                            {
                                dbContext.Transcripts.Add(new Transcript { dersId = dersIdd.dersId, ogrenciNo = ogr.ogrenciNo, dersNotu = dersNotu });
                                dbContext.SaveChanges();
                            }

                        }
                        else
                        {

                            dbContext.Transcripts.Add(new Transcript { dersId = ders.dersId, ogrenciNo = ogr.ogrenciNo, dersNotu = dersNotu });
                            dbContext.SaveChanges();
                            
                        }

                    }
                }
            }
            else
            {
                Console.WriteLine("Belirtilen ifadeler bulunamadı.");
            }

        }

        private void transcriptYukleBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                string pdfFilePath = "";

                openFileDialog1.Title = "Transcriptinizi Seciniz.";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog1.FileName;
                    pdfFilePath = selectedFilePath;
                    PdfReader pdfReader = new PdfReader(pdfFilePath);
                    string currentPageText = "";
                    for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                    {
                        ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                        currentPageText += PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);

                    }

                    pdfReader.Close();

                    using (var dbContext = new Context())
                    {
                        var transcript = dbContext.Transcripts.Where(a => a.ogrenciNo == ogr.ogrenciNo).ToList();
                        if (transcript != null)
                        {
                            dbContext.Transcripts.RemoveRange(transcript);
                            dbContext.SaveChanges();
                        }

                    }

                    string text = currentPageText;
                    string pattern = @"\b[a-zA-Z]{3}\d{3}\b";


                    MatchCollection matches = Regex.Matches(text, pattern);
                    Match lastMatch = null;
                    foreach (Match match in Regex.Matches(text, @"(4.0 Scale)\S*"))
                    {
                        lastMatch = match;
                        break;
                    }
                    string genelOrtalama = "";
                    if (lastMatch != null)
                    {
                        int baslangicIndex =  lastMatch.Index + lastMatch.Length + 1;
                        for (int i = baslangicIndex; i < text.Length; i++)
                        {

                            if(Convert.ToChar(text[i]) == ' ')
                            {
                                break;
                            } else
                            {
                                genelOrtalama += Convert.ToChar(text[i]);
                            }

                        }

                    }

                    genelOrtalama = genelOrtalama.Replace('.' , ',');

                    foreach (Match match in matches)
                    {

                        int startIndex = match.Index + match.Length;
                        string devamTexti = "";
                        for (int i = startIndex; i < text.Length; i++)
                        {

                            if (Convert.ToChar(text[i]) == 'A' && Convert.ToChar(text[i + 1]) == 'A')
                            {
                                devamTexti += Convert.ToChar(text[i]);
                                devamTexti += Convert.ToChar(text[i + 1]);
                                bulVeEkle(devamTexti);
                                break;
                            }
                            else if (Convert.ToChar(text[i]) == 'B' && Convert.ToChar(text[i + 1]) == 'A')
                            {
                                devamTexti += Convert.ToChar(text[i]);
                                devamTexti += Convert.ToChar(text[i + 1]);
                                bulVeEkle(devamTexti);
                                break;


                            }
                            else if (Convert.ToChar(text[i]) == 'B' && Convert.ToChar(text[i + 1]) == 'B')
                            {
                                devamTexti += Convert.ToChar(text[i]);
                                devamTexti += Convert.ToChar(text[i + 1]);
                                bulVeEkle(devamTexti);
                                break;

                            }
                            else if (Convert.ToChar(text[i]) == 'C' && Convert.ToChar(text[i + 1]) == 'B')
                            {
                                devamTexti += Convert.ToChar(text[i]);
                                devamTexti += Convert.ToChar(text[i + 1]);
                                bulVeEkle(devamTexti);
                                break;

                            }
                            else if (Convert.ToChar(text[i]) == 'C' && Convert.ToChar(text[i + 1]) == 'C')
                            {
                                devamTexti += Convert.ToChar(text[i]);
                                devamTexti += Convert.ToChar(text[i + 1]);
                                bulVeEkle(devamTexti);
                                break;

                            }
                            else if (Convert.ToChar(text[i]) == 'D' && Convert.ToChar(text[i + 1]) == 'C')
                            {
                                devamTexti += Convert.ToChar(text[i]);
                                devamTexti += Convert.ToChar(text[i + 1]);
                                bulVeEkle(devamTexti);
                                break;

                            }
                            else if (Convert.ToChar(text[i]) == 'D' && Convert.ToChar(text[i + 1]) == 'D')
                            {
                                devamTexti += Convert.ToChar(text[i]);
                                devamTexti += Convert.ToChar(text[i + 1]);
                                bulVeEkle(devamTexti);
                                break;

                            }
                            else if (Convert.ToChar(text[i]) == 'F' && Convert.ToChar(text[i + 1]) == 'D')
                            {
                                devamTexti += Convert.ToChar(text[i]);
                                devamTexti += Convert.ToChar(text[i + 1]);
                                bulVeEkle(devamTexti);
                                break;

                            }
                            else if (Convert.ToChar(text[i]) == 'F' && Convert.ToChar(text[i + 1]) == 'F')
                            {
                                devamTexti += Convert.ToChar(text[i]);
                                devamTexti += Convert.ToChar(text[i + 1]);
                                bulVeEkle(devamTexti);
                                break;

                            }
                            else if (Convert.ToChar(text[i]) == ' ' && Convert.ToChar(text[i + 1]) == 'D' && Convert.ToChar(text[i + 2]) == ' ')
                            {
                                devamTexti += Convert.ToChar(text[i]);
                                devamTexti += Convert.ToChar(text[i + 1]);
                                bulVeEkle(devamTexti);
                                break;

                            }
                            else if (Convert.ToChar(text[i]) == ' ' && Convert.ToChar(text[i + 1]) == 'E' && Convert.ToChar(text[i + 2]) == ' ')
                            {
                                devamTexti += Convert.ToChar(text[i]);
                                devamTexti += Convert.ToChar(text[i + 1]);
                                bulVeEkle(devamTexti);
                                break;

                            }
                            else if (Convert.ToChar(text[i]) == ' ' && Convert.ToChar(text[i + 1]) == 'G' && Convert.ToChar(text[i + 2]) == ' ')
                            {
                                devamTexti += Convert.ToChar(text[i]);
                                devamTexti += Convert.ToChar(text[i + 1]);
                                bulVeEkle(devamTexti);
                                break;

                            }
                            else if (Convert.ToChar(text[i]) == ' ' && Convert.ToChar(text[i + 1]) == 'N' && Convert.ToChar(text[i + 2]) == ' ')
                            {
                                devamTexti += Convert.ToChar(text[i]);
                                devamTexti += Convert.ToChar(text[i + 1]);
                                bulVeEkle(devamTexti);
                                break;

                            }
                            else if (Convert.ToChar(text[i]) == ' ' && Convert.ToChar(text[i + 1]) == 'K' && Convert.ToChar(text[i + 2]) == ' ')
                            {
                                devamTexti += Convert.ToChar(text[i]);
                                devamTexti += Convert.ToChar(text[i + 1]);
                                bulVeEkle(devamTexti);
                                break;

                            }

                            else if (Convert.ToChar(text[i]) == ' ' && Convert.ToChar(text[i + 1]) == 'S' && Convert.ToChar(text[i + 2]) == ' ')
                            {
                                devamTexti += Convert.ToChar(text[i]);
                                devamTexti += Convert.ToChar(text[i + 1]);
                                bulVeEkle(devamTexti);
                                break;

                            }
                            else
                            {
                                devamTexti += Convert.ToChar(text[i]);
                            }

                        }

                    }
                    transcriptKontrol();

                    using(var dbContext = new Context())
                    {
                        var guncellenecekVeri = dbContext.Ogrencis.FirstOrDefault(a => a.ogrenciNo == ogr.ogrenciNo);

                        if(guncellenecekVeri != null)
                        {
                            Console.WriteLine("Ortalama : " + genelOrtalama);
                            double ortalama = Convert.ToDouble(genelOrtalama);
                            Console.WriteLine("Ortalama : " + ortalama);
                            guncellenecekVeri.ogrenciGenelOrtalama = ortalama;
                            guncellenecekVeri.transcriptPdf = pdfFilePath;
                            dbContext.SaveChanges();
                            
                        }

                    }
                    dataGridDoldur();
                }
                else
                {

                }

            }
            catch (IOException a)
            {
                Console.WriteLine("Dosya okuma hatası: " + a.Message);
            }


        }

        private void gelenKutusuBtn_Click(object sender, EventArgs e)
        {

            try
            {

                GelenKutusuPaneli gelen = new GelenKutusuPaneli(ogr.ogrenciNo);
                gelen.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error  : " + ex);

            }


        }

        private void hocaListeleBtn_Click(object sender, EventArgs e)
        {
            try
            {

                OgrenciHocaListele ogrHocaListele = new OgrenciHocaListele(ogr.ogrenciNo);
                ogrHocaListele.Show();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata : " + ex.Message);

            }
        }
    }
}

