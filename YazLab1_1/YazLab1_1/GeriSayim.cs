using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YazLab1_1
{
    public class GeriSayim
    {

        private Timer timer;
        private int zaman;
        Label lblGeriSayim;
        Button btn;
        public GeriSayim(int a , Label lblGeriSayim , Button Btn)
        {
            btn = Btn;
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
            zaman = a;
            this.lblGeriSayim = lblGeriSayim;
            lblGeriSayim.Text = zaman.ToString();

        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();

            using(var dbContext = new Context())
            {

                var guncelle = dbContext.GenelAyarlars.FirstOrDefault();

                if(guncelle != null)
                {
                    guncelle.asama = 2;
                    btn.Enabled = false;
                    dbContext.SaveChanges();
                }

            }

        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            if (zaman > 0)
            {
                zaman--;
            }
            else
            {
                Stop();
                MessageBox.Show("1. Aşama Süresi Bitmiştir.");
            }
            lblGeriSayim.Text = zaman.ToString();

        }
    }



}
