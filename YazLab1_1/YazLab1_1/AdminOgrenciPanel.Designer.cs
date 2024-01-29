namespace YazLab1_1
{
    partial class AdminOgrenciPanel
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
            this.uyarıLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ogrenciAdiTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ogrenciEkleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ogrenciSifreTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ogrenciNoTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciGuncelleBtn = new System.Windows.Forms.Button();
            this.ogrenciSilBtn = new System.Windows.Forms.Button();
            this.ogrenciIdLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ogrenciTranscriptTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ogrenciGenelOrtalamaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ilgiAlanlari1 = new System.Windows.Forms.CheckedListBox();
            this.aldigiDersListesi = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uyarıLbl
            // 
            this.uyarıLbl.AutoSize = true;
            this.uyarıLbl.ForeColor = System.Drawing.Color.Red;
            this.uyarıLbl.Location = new System.Drawing.Point(171, 64);
            this.uyarıLbl.Name = "uyarıLbl";
            this.uyarıLbl.Size = new System.Drawing.Size(0, 13);
            this.uyarıLbl.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(93, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "EKLE | GUNCELLE";
            // 
            // ogrenciAdiTxt
            // 
            this.ogrenciAdiTxt.Location = new System.Drawing.Point(174, 64);
            this.ogrenciAdiTxt.Name = "ogrenciAdiTxt";
            this.ogrenciAdiTxt.Size = new System.Drawing.Size(205, 20);
            this.ogrenciAdiTxt.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "OGRENCİ ADI : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ogrenciEkleBtn
            // 
            this.ogrenciEkleBtn.Location = new System.Drawing.Point(174, 520);
            this.ogrenciEkleBtn.Name = "ogrenciEkleBtn";
            this.ogrenciEkleBtn.Size = new System.Drawing.Size(205, 31);
            this.ogrenciEkleBtn.TabIndex = 13;
            this.ogrenciEkleBtn.Text = "EKLE";
            this.ogrenciEkleBtn.UseVisualStyleBackColor = true;
            this.ogrenciEkleBtn.Click += new System.EventHandler(this.dersEkleBtn1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(174, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 22;
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(174, 97);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(205, 20);
            this.soyadTxt.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(134, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "OGRENCİ SOYADI : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(174, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 28;
            // 
            // ogrenciSifreTxt
            // 
            this.ogrenciSifreTxt.Location = new System.Drawing.Point(174, 169);
            this.ogrenciSifreTxt.Name = "ogrenciSifreTxt";
            this.ogrenciSifreTxt.Size = new System.Drawing.Size(205, 20);
            this.ogrenciSifreTxt.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(21, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "OGRENCİ SİFRE :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(171, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 25;
            // 
            // ogrenciNoTxt
            // 
            this.ogrenciNoTxt.Location = new System.Drawing.Point(174, 136);
            this.ogrenciNoTxt.Name = "ogrenciNoTxt";
            this.ogrenciNoTxt.Size = new System.Drawing.Size(205, 20);
            this.ogrenciNoTxt.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(41, 136);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(101, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "OGRENCİ NO :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(412, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(720, 623);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ogrenciGuncelleBtn
            // 
            this.ogrenciGuncelleBtn.Location = new System.Drawing.Point(174, 567);
            this.ogrenciGuncelleBtn.Name = "ogrenciGuncelleBtn";
            this.ogrenciGuncelleBtn.Size = new System.Drawing.Size(205, 31);
            this.ogrenciGuncelleBtn.TabIndex = 34;
            this.ogrenciGuncelleBtn.Text = "GUNCELLE";
            this.ogrenciGuncelleBtn.UseVisualStyleBackColor = true;
            this.ogrenciGuncelleBtn.Click += new System.EventHandler(this.ogrenciGuncelleBtn_Click);
            // 
            // ogrenciSilBtn
            // 
            this.ogrenciSilBtn.Location = new System.Drawing.Point(174, 617);
            this.ogrenciSilBtn.Name = "ogrenciSilBtn";
            this.ogrenciSilBtn.Size = new System.Drawing.Size(205, 31);
            this.ogrenciSilBtn.TabIndex = 35;
            this.ogrenciSilBtn.Text = "SİL";
            this.ogrenciSilBtn.UseVisualStyleBackColor = true;
            this.ogrenciSilBtn.Click += new System.EventHandler(this.ogrenciSilBtn_Click_1);
            // 
            // ogrenciIdLbl
            // 
            this.ogrenciIdLbl.AutoSize = true;
            this.ogrenciIdLbl.Location = new System.Drawing.Point(171, 46);
            this.ogrenciIdLbl.Name = "ogrenciIdLbl";
            this.ogrenciIdLbl.Size = new System.Drawing.Size(0, 13);
            this.ogrenciIdLbl.TabIndex = 36;
            this.ogrenciIdLbl.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(42, 211);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(100, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "TRANSCRİPT :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ogrenciTranscriptTxt
            // 
            this.ogrenciTranscriptTxt.Location = new System.Drawing.Point(174, 208);
            this.ogrenciTranscriptTxt.Name = "ogrenciTranscriptTxt";
            this.ogrenciTranscriptTxt.Size = new System.Drawing.Size(205, 20);
            this.ogrenciTranscriptTxt.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(5, 244);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(137, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "GENEL ORTALAMA :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ogrenciGenelOrtalamaTxt
            // 
            this.ogrenciGenelOrtalamaTxt.Location = new System.Drawing.Point(174, 241);
            this.ogrenciGenelOrtalamaTxt.Name = "ogrenciGenelOrtalamaTxt";
            this.ogrenciGenelOrtalamaTxt.Size = new System.Drawing.Size(205, 20);
            this.ogrenciGenelOrtalamaTxt.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "ILGI ALANLARI :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ilgiAlanlari1
            // 
            this.ilgiAlanlari1.FormattingEnabled = true;
            this.ilgiAlanlari1.Location = new System.Drawing.Point(177, 286);
            this.ilgiAlanlari1.Name = "ilgiAlanlari1";
            this.ilgiAlanlari1.Size = new System.Drawing.Size(202, 94);
            this.ilgiAlanlari1.TabIndex = 38;
            // 
            // aldigiDersListesi
            // 
            this.aldigiDersListesi.FormattingEnabled = true;
            this.aldigiDersListesi.Location = new System.Drawing.Point(174, 399);
            this.aldigiDersListesi.Name = "aldigiDersListesi";
            this.aldigiDersListesi.Size = new System.Drawing.Size(202, 94);
            this.aldigiDersListesi.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(14, 399);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(128, 15);
            this.label12.TabIndex = 39;
            this.label12.Text = "ALDIGI DERSLER :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminOgrenciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1144, 659);
            this.Controls.Add(this.aldigiDersListesi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ilgiAlanlari1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ogrenciIdLbl);
            this.Controls.Add(this.ogrenciSilBtn);
            this.Controls.Add(this.ogrenciGuncelleBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ogrenciGenelOrtalamaTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ogrenciTranscriptTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ogrenciSifreTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ogrenciNoTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soyadTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uyarıLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ogrenciAdiTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ogrenciEkleBtn);
            this.Name = "AdminOgrenciPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OGRENCİ PANELİ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uyarıLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ogrenciAdiTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ogrenciEkleBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox soyadTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ogrenciSifreTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ogrenciNoTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ogrenciGuncelleBtn;
        private System.Windows.Forms.Button ogrenciSilBtn;
        private System.Windows.Forms.Label ogrenciIdLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ogrenciTranscriptTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ogrenciGenelOrtalamaTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox ilgiAlanlari1;
        private System.Windows.Forms.CheckedListBox aldigiDersListesi;
        private System.Windows.Forms.Label label12;
    }
}