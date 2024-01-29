namespace YazLab1_1
{
    partial class OgrenciAnaPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciAnaPanel));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ortalamaLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dersSecimBtn = new System.Windows.Forms.Button();
            this.gelenKutusuBtn = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.transcriptYukleBtn = new System.Windows.Forms.Button();
            this.lblOgrenciNo = new System.Windows.Forms.Label();
            this.lblOgrenciAdi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGeriSayim = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hocaListeleBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(198, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 49);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(262, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "OGRENCI PANELI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.hocaListeleBtn);
            this.panel1.Controls.Add(this.ortalamaLbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dersSecimBtn);
            this.panel1.Controls.Add(this.gelenKutusuBtn);
            this.panel1.Controls.Add(this.btnCikisYap);
            this.panel1.Controls.Add(this.transcriptYukleBtn);
            this.panel1.Controls.Add(this.lblOgrenciNo);
            this.panel1.Controls.Add(this.lblOgrenciAdi);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 598);
            this.panel1.TabIndex = 7;
            // 
            // ortalamaLbl
            // 
            this.ortalamaLbl.AutoSize = true;
            this.ortalamaLbl.Location = new System.Drawing.Point(98, 52);
            this.ortalamaLbl.Name = "ortalamaLbl";
            this.ortalamaLbl.Size = new System.Drawing.Size(35, 13);
            this.ortalamaLbl.TabIndex = 15;
            this.ortalamaLbl.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // dersSecimBtn
            // 
            this.dersSecimBtn.BackColor = System.Drawing.Color.Snow;
            this.dersSecimBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dersSecimBtn.Location = new System.Drawing.Point(0, 164);
            this.dersSecimBtn.Name = "dersSecimBtn";
            this.dersSecimBtn.Size = new System.Drawing.Size(180, 45);
            this.dersSecimBtn.TabIndex = 13;
            this.dersSecimBtn.Text = "DERS SEÇIM";
            this.dersSecimBtn.UseVisualStyleBackColor = false;
            this.dersSecimBtn.Click += new System.EventHandler(this.dersSecimBtn_Click);
            // 
            // gelenKutusuBtn
            // 
            this.gelenKutusuBtn.BackColor = System.Drawing.Color.Snow;
            this.gelenKutusuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelenKutusuBtn.Location = new System.Drawing.Point(0, 215);
            this.gelenKutusuBtn.Name = "gelenKutusuBtn";
            this.gelenKutusuBtn.Size = new System.Drawing.Size(180, 45);
            this.gelenKutusuBtn.TabIndex = 9;
            this.gelenKutusuBtn.Text = "GELEN KUTUSU";
            this.gelenKutusuBtn.UseVisualStyleBackColor = false;
            this.gelenKutusuBtn.Click += new System.EventHandler(this.gelenKutusuBtn_Click);
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
            // 
            // transcriptYukleBtn
            // 
            this.transcriptYukleBtn.BackColor = System.Drawing.Color.Snow;
            this.transcriptYukleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.transcriptYukleBtn.Location = new System.Drawing.Point(0, 113);
            this.transcriptYukleBtn.Name = "transcriptYukleBtn";
            this.transcriptYukleBtn.Size = new System.Drawing.Size(180, 45);
            this.transcriptYukleBtn.TabIndex = 4;
            this.transcriptYukleBtn.Text = "TRANSCRİPT YÜKLE";
            this.transcriptYukleBtn.UseVisualStyleBackColor = false;
            this.transcriptYukleBtn.Click += new System.EventHandler(this.transcriptYukleBtn_Click);
            // 
            // lblOgrenciNo
            // 
            this.lblOgrenciNo.AutoSize = true;
            this.lblOgrenciNo.Location = new System.Drawing.Point(96, 28);
            this.lblOgrenciNo.Name = "lblOgrenciNo";
            this.lblOgrenciNo.Size = new System.Drawing.Size(61, 13);
            this.lblOgrenciNo.TabIndex = 2;
            this.lblOgrenciNo.Text = "210202109";
            // 
            // lblOgrenciAdi
            // 
            this.lblOgrenciAdi.AutoSize = true;
            this.lblOgrenciAdi.Location = new System.Drawing.Point(96, 7);
            this.lblOgrenciAdi.Name = "lblOgrenciAdi";
            this.lblOgrenciAdi.Size = new System.Drawing.Size(68, 13);
            this.lblOgrenciAdi.TabIndex = 1;
            this.lblOgrenciAdi.Text = "Ömer AYDIN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(198, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 485);
            this.dataGridView1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(198, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "TRANCRIPT";
            // 
            // lblGeriSayim
            // 
            this.lblGeriSayim.AutoSize = true;
            this.lblGeriSayim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGeriSayim.Location = new System.Drawing.Point(903, 94);
            this.lblGeriSayim.Name = "lblGeriSayim";
            this.lblGeriSayim.Size = new System.Drawing.Size(51, 16);
            this.lblGeriSayim.TabIndex = 11;
            this.lblGeriSayim.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(765, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "1. Aşama Süresi : ";
            // 
            // hocaListeleBtn
            // 
            this.hocaListeleBtn.BackColor = System.Drawing.Color.Snow;
            this.hocaListeleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hocaListeleBtn.Location = new System.Drawing.Point(0, 266);
            this.hocaListeleBtn.Name = "hocaListeleBtn";
            this.hocaListeleBtn.Size = new System.Drawing.Size(180, 45);
            this.hocaListeleBtn.TabIndex = 16;
            this.hocaListeleBtn.Text = "HOCA LISTELE";
            this.hocaListeleBtn.UseVisualStyleBackColor = false;
            this.hocaListeleBtn.Click += new System.EventHandler(this.hocaListeleBtn_Click);
            // 
            // OgrenciAnaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 622);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGeriSayim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OgrenciAnaPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciAnaPanel";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dersSecimBtn;
        private System.Windows.Forms.Button gelenKutusuBtn;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Button transcriptYukleBtn;
        private System.Windows.Forms.Label lblOgrenciNo;
        private System.Windows.Forms.Label lblOgrenciAdi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGeriSayim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ortalamaLbl;
        private System.Windows.Forms.Button hocaListeleBtn;
    }
}