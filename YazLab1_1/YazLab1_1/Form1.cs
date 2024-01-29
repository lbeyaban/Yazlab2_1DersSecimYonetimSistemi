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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {

            OgrenciGirisEkrani ogrGirisEkran = new OgrenciGirisEkrani();
            ogrGirisEkran.Show();

        }

        private void yoneticiGirisBtn_Click(object sender, EventArgs e)
        {
            AdminGirisEkranı adminGirisEkrani = new AdminGirisEkranı();
            adminGirisEkrani.Show();
        }

        private void hocaGirisBtn_Click(object sender, EventArgs e)
        {

            HocaGirisEkranı hocaGiris = new HocaGirisEkranı();
            hocaGiris.Show();

        }
    }
}
