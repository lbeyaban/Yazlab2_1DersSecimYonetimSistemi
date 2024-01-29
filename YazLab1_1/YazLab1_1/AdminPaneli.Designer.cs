namespace YazLab1_1
{
    partial class AdminPaneli
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBoxOgrenci = new System.Windows.Forms.PictureBox();
            this.lblOgrenciAdi = new System.Windows.Forms.Label();
            this.lblOgrenciNo = new System.Windows.Forms.Label();
            this.btnPdfYukle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOgrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnCikisYap);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnPdfYukle);
            this.panel1.Controls.Add(this.lblOgrenciNo);
            this.panel1.Controls.Add(this.lblOgrenciAdi);
            this.panel1.Controls.Add(this.picBoxOgrenci);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 598);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Location = new System.Drawing.Point(198, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 49);
            this.panel2.TabIndex = 1;
            // 
            // picBoxOgrenci
            // 
            this.picBoxOgrenci.Location = new System.Drawing.Point(3, 3);
            this.picBoxOgrenci.Name = "picBoxOgrenci";
            this.picBoxOgrenci.Size = new System.Drawing.Size(62, 46);
            this.picBoxOgrenci.TabIndex = 0;
            this.picBoxOgrenci.TabStop = false;
            this.picBoxOgrenci.Click += new System.EventHandler(this.picBoxOgrenci_Click);
            // 
            // lblOgrenciAdi
            // 
            this.lblOgrenciAdi.AutoSize = true;
            this.lblOgrenciAdi.Location = new System.Drawing.Point(71, 5);
            this.lblOgrenciAdi.Name = "lblOgrenciAdi";
            this.lblOgrenciAdi.Size = new System.Drawing.Size(68, 13);
            this.lblOgrenciAdi.TabIndex = 1;
            this.lblOgrenciAdi.Text = "Ömer AYDIN";
            // 
            // lblOgrenciNo
            // 
            this.lblOgrenciNo.AutoSize = true;
            this.lblOgrenciNo.Location = new System.Drawing.Point(71, 29);
            this.lblOgrenciNo.Name = "lblOgrenciNo";
            this.lblOgrenciNo.Size = new System.Drawing.Size(61, 13);
            this.lblOgrenciNo.TabIndex = 2;
            this.lblOgrenciNo.Text = "210202109";
            // 
            // btnPdfYukle
            // 
            this.btnPdfYukle.BackColor = System.Drawing.Color.Snow;
            this.btnPdfYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPdfYukle.Location = new System.Drawing.Point(0, 114);
            this.btnPdfYukle.Name = "btnPdfYukle";
            this.btnPdfYukle.Size = new System.Drawing.Size(180, 45);
            this.btnPdfYukle.TabIndex = 3;
            this.btnPdfYukle.Text = "TRANSCRİPT  YUKLE";
            this.btnPdfYukle.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(0, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "OGRETMEN LİSTELE";
            this.button1.UseVisualStyleBackColor = false;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(198, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(198, 126);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(756, 484);
            this.dataGrid.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(0, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "İLGİ ALANI EKLE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Snow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(0, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 45);
            this.button3.TabIndex = 7;
            this.button3.Text = "PROGRAM AYARLARI";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Snow;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(0, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 45);
            this.button4.TabIndex = 8;
            this.button4.Text = "ÖĞRENCİ LİSTELE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 622);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AdminPaneli";
            this.Text = "Öğrenci Paneli";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOgrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBoxOgrenci;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOgrenciNo;
        private System.Windows.Forms.Label lblOgrenciAdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPdfYukle;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}