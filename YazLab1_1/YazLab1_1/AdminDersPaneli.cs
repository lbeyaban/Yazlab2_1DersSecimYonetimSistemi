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
    public partial class AdminDersPaneli : Form
    {
        public AdminDersPaneli()
        {
            InitializeComponent();

            try
            {

                using (var dbContext = new Context())
                {

                    var dersler = dbContext.Dersler.ToList();
                    dataGridView1.DataSource = dersler;

                }

            }
            catch (Exception)
            {

                throw;

            }

        }

        private void dersEkleBtn_Click(object sender, EventArgs e)
        {

            try
            {

                using (var dbContext = new Context())
                {

                    dbContext.Dersler.Add(new Dersler { dersAdi = dersAdiTxt.Text, dersAciklama = dersAciklamaRich.Text });
                    dbContext.SaveChanges();
                    dataGridView1.DataSource = dbContext.Dersler.ToList();

                }
                MessageBox.Show("Ders Eklendi.");

            }
            catch (Exception)
            {

                throw;
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;

                dersId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                dersAdiTxt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                dersAciklamaRich.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }

            

        }

        private void dersGuncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {

                using (var dbContext = new Context())
                {

                    var degistirilecekVeri = dbContext.Dersler.FirstOrDefault(a => a.dersId.ToString() == dersId.Text);
                    if (degistirilecekVeri != null)
                    {

                        degistirilecekVeri.dersAdi = dersAdiTxt.Text;
                        degistirilecekVeri.dersAciklama = dersAciklamaRich.Text;
                        dbContext.SaveChanges();

                        dataGridView1.DataSource = dbContext.Dersler.ToList();

                    }

                }

                MessageBox.Show("Ders Güncellendi.");



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dersSilBtn_Click(object sender, EventArgs e)
        {
            try
            {

                using (var dbContext = new Context())
                {
                    var silinecekVeri = dbContext.Dersler.FirstOrDefault(a => a.dersId.ToString() == dersId.Text);
                    if (silinecekVeri != null)
                    {
                        dbContext.Dersler.Remove(silinecekVeri);
                        dbContext.SaveChanges();
                    }

                    dataGridView1.DataSource = dbContext.Dersler.ToList();

                }

                MessageBox.Show("Ders Silindi.");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
