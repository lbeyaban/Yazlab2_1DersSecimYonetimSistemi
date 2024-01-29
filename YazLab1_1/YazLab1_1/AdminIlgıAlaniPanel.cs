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
    public partial class AdminIlgıAlaniPanel : Form
    {
        public AdminIlgıAlaniPanel()
        {
            InitializeComponent();

            try
            {

                using (var dbContext = new Context())
                {

                    var ilgiAlanlari = dbContext.IlgiAlanlari.ToList();
                    dataGridView1.DataSource = ilgiAlanlari;

                }

            }
            catch (Exception)
            {

                throw;

            }
        }

        private void ilgiEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {

                using (var dbContext = new Context())
                {

                    dbContext.IlgiAlanlari.Add(new IlgiAlanlari { ilgiAlaniAdi = ilgiAlaniTxt.Text, ilgiAlaniAciklama = ilgiAlaniRich.Text });
                    dbContext.SaveChanges();
                    dataGridView1.DataSource = dbContext.IlgiAlanlari.ToList();

                }
                MessageBox.Show("İlgi Alani Eklendi.");

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;

                ilgiAlaniIdLbl.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                ilgiAlaniTxt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                ilgiAlaniRich.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            }
            catch (Exception)
            {

                throw;
            }



        }

        private void ilgiAlaniGuncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {

                using (var dbContext = new Context())
                {

                    var degistirilecekVeri = dbContext.IlgiAlanlari.FirstOrDefault(a => a.ilgiAlaniId.ToString() == ilgiAlaniIdLbl.Text);
                    if (degistirilecekVeri != null)
                    {

                        degistirilecekVeri.ilgiAlaniAdi = ilgiAlaniTxt.Text;
                        degistirilecekVeri.ilgiAlaniAciklama = ilgiAlaniRich.Text;
                        dbContext.SaveChanges();

                        dataGridView1.DataSource = dbContext.IlgiAlanlari.ToList();

                    }

                }

                MessageBox.Show("Ilgi Alani Güncellendi.");



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ilgiAlaniSilBtn_Click(object sender, EventArgs e)
        {
            try
            {

                using (var dbContext = new Context())
                {
                    var silinecekVeri = dbContext.IlgiAlanlari.FirstOrDefault(a => a.ilgiAlaniId.ToString() == ilgiAlaniIdLbl.Text);
                    if (silinecekVeri != null)
                    {
                        dbContext.IlgiAlanlari.Remove(silinecekVeri);
                        dbContext.SaveChanges();
                    }

                    dataGridView1.DataSource = dbContext.IlgiAlanlari.ToList();

                }

                MessageBox.Show("Ilgi Alani Silindi.");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
