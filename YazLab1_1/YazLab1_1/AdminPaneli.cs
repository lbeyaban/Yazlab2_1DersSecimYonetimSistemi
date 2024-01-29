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
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void picBoxOgrenci_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using(var dbContext = new Context())
            {

                var ogrenciler = dbContext.Ogrencis.ToList();

                dataGrid.DataSource = ogrenciler;


            }


        }
    }
}
