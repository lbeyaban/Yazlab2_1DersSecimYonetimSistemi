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
    public partial class OgrenciHocaListele : Form
    {
        List<int> ilgiAlaniIdler = new List<int>();
        List<int> filtreler = new List<int>();
        string ogrenciNo;
        public OgrenciHocaListele(string ogrenciNo)
        {
            InitializeComponent();
            this.ogrenciNo = ogrenciNo;

            try
            {

                using(var dbContext = new Context())
                {

                    var ilgiAlanlari = dbContext.IlgiAlanlari.ToList();

                    foreach (var ilgiAlani in ilgiAlanlari)
                    {

                        checkedListBox1.Items.Add(ilgiAlani.ilgiAlaniAdi);
                        ilgiAlaniIdler.Add(ilgiAlani.ilgiAlaniId);

                    }

                }


            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata : " + ex.Message);

            }



        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                filtreler.Clear();

                for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
                {

                    filtreler.Add(ilgiAlaniIdler[checkedListBox1.CheckedIndices[i]]);

                }

                foreach (var item in filtreler)
                {
                    Console.WriteLine(item);
                }

                using (var dbContext = new Context())
                {

                    var filtrele = from ogretmenIlgi in dbContext.IlgiAlaniOgretmens
                                   join ilgiAlani in dbContext.IlgiAlanlari on ogretmenIlgi.ilgiAlaniId equals ilgiAlani.ilgiAlaniId
                                   join ogretmen in dbContext.Ogretmenler on ogretmenIlgi.sicilNo equals ogretmen.sicilNo
                                   select new
                                   {

                                       OgretmenAdi = ogretmen.ogretmenAdi,
                                       OgretmenSoyadi = ogretmen.ogretmenSoyAdi,
                                       OgretmenSicil = ogretmen.sicilNo,
                                       IlgiAlaniId = ogretmenIlgi.ilgiAlaniId,
                                       IlgiAlaniAdi = ilgiAlani.ilgiAlaniAdi,
                            };

                    dataGridView1.DataSource = filtrele.Where(a => filtreler.Contains(a.IlgiAlaniId))
                        .OrderByDescending(b => b.IlgiAlaniId)
                        .ToList();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata : " + ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;

                string sicilNo = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

                OgrenciEkstraTalep ogrEkstra = new OgrenciEkstraTalep(ogrenciNo, sicilNo);
                ogrEkstra.Show();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata : " + ex.Message);

            }

        }
    }
}
