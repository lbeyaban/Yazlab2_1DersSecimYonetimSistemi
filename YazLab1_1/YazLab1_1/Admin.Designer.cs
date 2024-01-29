namespace YazLab1_1
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ogrenciPanelBtn = new System.Windows.Forms.Button();
            this.ilgiAlaniPanel = new System.Windows.Forms.Button();
            this.dersPanelBtn = new System.Windows.Forms.Button();
            this.programAyariBtn = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.ogretmenPanelBtn = new System.Windows.Forms.Button();
            this.lblYoneticiNo = new System.Windows.Forms.Label();
            this.lblYoneticiAdi = new System.Windows.Forms.Label();
            this.picBoxOgrenci = new System.Windows.Forms.PictureBox();
            this.rastgeleAta = new System.Windows.Forms.Button();
            this.ortalamayaGoreAta = new System.Windows.Forms.Button();
            this.topluOgrenciOlustur = new System.Windows.Forms.Button();
            this.ogrenciSayisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.talepGecmisiList = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(198, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 49);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(262, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMİN PANELİ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.talepGecmisiList);
            this.panel1.Controls.Add(this.ogrenciPanelBtn);
            this.panel1.Controls.Add(this.ilgiAlaniPanel);
            this.panel1.Controls.Add(this.dersPanelBtn);
            this.panel1.Controls.Add(this.programAyariBtn);
            this.panel1.Controls.Add(this.btnCikisYap);
            this.panel1.Controls.Add(this.ogretmenPanelBtn);
            this.panel1.Controls.Add(this.lblYoneticiNo);
            this.panel1.Controls.Add(this.lblYoneticiAdi);
            this.panel1.Controls.Add(this.picBoxOgrenci);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 598);
            this.panel1.TabIndex = 4;
            // 
            // ogrenciPanelBtn
            // 
            this.ogrenciPanelBtn.BackColor = System.Drawing.Color.Snow;
            this.ogrenciPanelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciPanelBtn.Location = new System.Drawing.Point(0, 164);
            this.ogrenciPanelBtn.Name = "ogrenciPanelBtn";
            this.ogrenciPanelBtn.Size = new System.Drawing.Size(180, 45);
            this.ogrenciPanelBtn.TabIndex = 13;
            this.ogrenciPanelBtn.Text = "ÖĞRENCİ PANEL";
            this.ogrenciPanelBtn.UseVisualStyleBackColor = false;
            this.ogrenciPanelBtn.Click += new System.EventHandler(this.ogrenciListeleBtn_Click);
            // 
            // ilgiAlaniPanel
            // 
            this.ilgiAlaniPanel.BackColor = System.Drawing.Color.Snow;
            this.ilgiAlaniPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilgiAlaniPanel.Location = new System.Drawing.Point(0, 266);
            this.ilgiAlaniPanel.Name = "ilgiAlaniPanel";
            this.ilgiAlaniPanel.Size = new System.Drawing.Size(180, 45);
            this.ilgiAlaniPanel.TabIndex = 10;
            this.ilgiAlaniPanel.Text = "ILGI ALANI PANEL";
            this.ilgiAlaniPanel.UseVisualStyleBackColor = false;
            this.ilgiAlaniPanel.Click += new System.EventHandler(this.ilgiAlaniPanel_Click);
            // 
            // dersPanelBtn
            // 
            this.dersPanelBtn.BackColor = System.Drawing.Color.Snow;
            this.dersPanelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dersPanelBtn.Location = new System.Drawing.Point(0, 215);
            this.dersPanelBtn.Name = "dersPanelBtn";
            this.dersPanelBtn.Size = new System.Drawing.Size(180, 45);
            this.dersPanelBtn.TabIndex = 9;
            this.dersPanelBtn.Text = "DERS PANEL";
            this.dersPanelBtn.UseVisualStyleBackColor = false;
            this.dersPanelBtn.Click += new System.EventHandler(this.dersPanelBtn_Click);
            // 
            // programAyariBtn
            // 
            this.programAyariBtn.BackColor = System.Drawing.Color.Snow;
            this.programAyariBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.programAyariBtn.Location = new System.Drawing.Point(0, 502);
            this.programAyariBtn.Name = "programAyariBtn";
            this.programAyariBtn.Size = new System.Drawing.Size(180, 45);
            this.programAyariBtn.TabIndex = 7;
            this.programAyariBtn.Text = "PROGRAM AYARLARI";
            this.programAyariBtn.UseVisualStyleBackColor = false;
            this.programAyariBtn.Click += new System.EventHandler(this.programAyariBtn_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.BackColor = System.Drawing.Color.Snow;
            this.btnCikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikisYap.Location = new System.Drawing.Point(0, 553);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(180, 45);
            this.btnCikisYap.TabIndex = 5;
            this.btnCikisYap.Text = "ÇIKIŞ YAP";
            this.btnCikisYap.UseVisualStyleBackColor = false;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // ogretmenPanelBtn
            // 
            this.ogretmenPanelBtn.BackColor = System.Drawing.Color.Snow;
            this.ogretmenPanelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogretmenPanelBtn.Location = new System.Drawing.Point(0, 113);
            this.ogretmenPanelBtn.Name = "ogretmenPanelBtn";
            this.ogretmenPanelBtn.Size = new System.Drawing.Size(180, 45);
            this.ogretmenPanelBtn.TabIndex = 4;
            this.ogretmenPanelBtn.Text = "OGRETMEN PANEL";
            this.ogretmenPanelBtn.UseVisualStyleBackColor = false;
            this.ogretmenPanelBtn.Click += new System.EventHandler(this.ogretmenPanelBtn_Click);
            // 
            // lblYoneticiNo
            // 
            this.lblYoneticiNo.AutoSize = true;
            this.lblYoneticiNo.Location = new System.Drawing.Point(89, 29);
            this.lblYoneticiNo.Name = "lblYoneticiNo";
            this.lblYoneticiNo.Size = new System.Drawing.Size(61, 13);
            this.lblYoneticiNo.TabIndex = 2;
            this.lblYoneticiNo.Text = "210202109";
            // 
            // lblYoneticiAdi
            // 
            this.lblYoneticiAdi.AutoSize = true;
            this.lblYoneticiAdi.Location = new System.Drawing.Point(89, 5);
            this.lblYoneticiAdi.Name = "lblYoneticiAdi";
            this.lblYoneticiAdi.Size = new System.Drawing.Size(68, 13);
            this.lblYoneticiAdi.TabIndex = 1;
            this.lblYoneticiAdi.Text = "Ömer AYDIN";
            // 
            // picBoxOgrenci
            // 
            this.picBoxOgrenci.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxOgrenci.BackgroundImage")));
            this.picBoxOgrenci.Image = ((System.Drawing.Image)(resources.GetObject("picBoxOgrenci.Image")));
            this.picBoxOgrenci.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxOgrenci.InitialImage")));
            this.picBoxOgrenci.Location = new System.Drawing.Point(21, 5);
            this.picBoxOgrenci.Name = "picBoxOgrenci";
            this.picBoxOgrenci.Size = new System.Drawing.Size(62, 46);
            this.picBoxOgrenci.TabIndex = 0;
            this.picBoxOgrenci.TabStop = false;
            // 
            // rastgeleAta
            // 
            this.rastgeleAta.Location = new System.Drawing.Point(709, 445);
            this.rastgeleAta.Name = "rastgeleAta";
            this.rastgeleAta.Size = new System.Drawing.Size(177, 45);
            this.rastgeleAta.TabIndex = 7;
            this.rastgeleAta.Text = "RASTGELE OGRENCI ATA";
            this.rastgeleAta.UseVisualStyleBackColor = true;
            this.rastgeleAta.Click += new System.EventHandler(this.rastgeleAta_Click);
            // 
            // ortalamayaGoreAta
            // 
            this.ortalamayaGoreAta.Location = new System.Drawing.Point(709, 383);
            this.ortalamayaGoreAta.Name = "ortalamayaGoreAta";
            this.ortalamayaGoreAta.Size = new System.Drawing.Size(177, 45);
            this.ortalamayaGoreAta.TabIndex = 8;
            this.ortalamayaGoreAta.Text = "ORTALAMAYA GORE ATA";
            this.ortalamayaGoreAta.UseVisualStyleBackColor = true;
            this.ortalamayaGoreAta.Click += new System.EventHandler(this.ortalamayaGoreAta_Click);
            // 
            // topluOgrenciOlustur
            // 
            this.topluOgrenciOlustur.Location = new System.Drawing.Point(706, 234);
            this.topluOgrenciOlustur.Name = "topluOgrenciOlustur";
            this.topluOgrenciOlustur.Size = new System.Drawing.Size(177, 45);
            this.topluOgrenciOlustur.TabIndex = 9;
            this.topluOgrenciOlustur.Text = "OGRENCI OLUSTUR";
            this.topluOgrenciOlustur.UseVisualStyleBackColor = true;
            this.topluOgrenciOlustur.Click += new System.EventHandler(this.topluOgrenciOlustur_Click);
            // 
            // ogrenciSayisi
            // 
            this.ogrenciSayisi.Location = new System.Drawing.Point(706, 199);
            this.ogrenciSayisi.Name = "ogrenciSayisi";
            this.ogrenciSayisi.Size = new System.Drawing.Size(177, 20);
            this.ogrenciSayisi.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "OGRENCI SAYISI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(683, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "KISAYOL BUTONLARI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(743, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ATAMA ISLEMLERI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 597);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "by CopyPastProgrammers";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(198, 167);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(411, 328);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(289, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "UYGULAMA ACIKLAMASI";
            // 
            // talepGecmisiList
            // 
            this.talepGecmisiList.BackColor = System.Drawing.Color.Snow;
            this.talepGecmisiList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.talepGecmisiList.Location = new System.Drawing.Point(0, 317);
            this.talepGecmisiList.Name = "talepGecmisiList";
            this.talepGecmisiList.Size = new System.Drawing.Size(180, 45);
            this.talepGecmisiList.TabIndex = 14;
            this.talepGecmisiList.Text = "TALEP GEÇMİŞİ";
            this.talepGecmisiList.UseVisualStyleBackColor = false;
            this.talepGecmisiList.Click += new System.EventHandler(this.talepGecmisiList_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 622);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ogrenciSayisi);
            this.Controls.Add(this.topluOgrenciOlustur);
            this.Controls.Add(this.ortalamayaGoreAta);
            this.Controls.Add(this.rastgeleAta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOgrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button programAyariBtn;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Button ogretmenPanelBtn;
        private System.Windows.Forms.Label lblYoneticiNo;
        private System.Windows.Forms.Label lblYoneticiAdi;
        private System.Windows.Forms.PictureBox picBoxOgrenci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dersPanelBtn;
        private System.Windows.Forms.Button ilgiAlaniPanel;
        private System.Windows.Forms.Button ogrenciPanelBtn;
        private System.Windows.Forms.Button rastgeleAta;
        private System.Windows.Forms.Button ortalamayaGoreAta;
        private System.Windows.Forms.Button topluOgrenciOlustur;
        private System.Windows.Forms.TextBox ogrenciSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button talepGecmisiList;
    }
}