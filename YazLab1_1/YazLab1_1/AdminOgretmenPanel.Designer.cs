namespace YazLab1_1
{
    partial class AdminOgretmenPanel
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
            this.ogrenciIdLbl = new System.Windows.Forms.Label();
            this.ogrenciSilBtn = new System.Windows.Forms.Button();
            this.ogrenciGuncelleBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ogretmenSifreTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sicilNoTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uyarıLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ogretmenAdiTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ogrenciEkleBtn = new System.Windows.Forms.Button();
            this.ogretmenKontenjanTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ilgiListesi1 = new System.Windows.Forms.CheckedListBox();
            this.verdigiDersListesi = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrenciIdLbl
            // 
            this.ogrenciIdLbl.AutoSize = true;
            this.ogrenciIdLbl.Location = new System.Drawing.Point(172, 72);
            this.ogrenciIdLbl.Name = "ogrenciIdLbl";
            this.ogrenciIdLbl.Size = new System.Drawing.Size(0, 13);
            this.ogrenciIdLbl.TabIndex = 58;
            this.ogrenciIdLbl.Visible = false;
            // 
            // ogrenciSilBtn
            // 
            this.ogrenciSilBtn.Location = new System.Drawing.Point(172, 504);
            this.ogrenciSilBtn.Name = "ogrenciSilBtn";
            this.ogrenciSilBtn.Size = new System.Drawing.Size(205, 31);
            this.ogrenciSilBtn.TabIndex = 57;
            this.ogrenciSilBtn.Text = "SİL";
            this.ogrenciSilBtn.UseVisualStyleBackColor = true;
            this.ogrenciSilBtn.Click += new System.EventHandler(this.ogrenciSilBtn_Click);
            // 
            // ogrenciGuncelleBtn
            // 
            this.ogrenciGuncelleBtn.Location = new System.Drawing.Point(172, 467);
            this.ogrenciGuncelleBtn.Name = "ogrenciGuncelleBtn";
            this.ogrenciGuncelleBtn.Size = new System.Drawing.Size(205, 31);
            this.ogrenciGuncelleBtn.TabIndex = 56;
            this.ogrenciGuncelleBtn.Text = "GUNCELLE";
            this.ogrenciGuncelleBtn.UseVisualStyleBackColor = true;
            this.ogrenciGuncelleBtn.Click += new System.EventHandler(this.ogrenciGuncelleBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(399, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 466);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(15, 326);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(143, 15);
            this.label11.TabIndex = 53;
            this.label11.Text = "VERDİĞİ DERSLER : ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(45, 237);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(113, 15);
            this.label10.TabIndex = 51;
            this.label10.Text = "İLGİ ALANLARI : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(175, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 50;
            // 
            // ogretmenSifreTxt
            // 
            this.ogretmenSifreTxt.Location = new System.Drawing.Point(175, 168);
            this.ogretmenSifreTxt.Name = "ogretmenSifreTxt";
            this.ogretmenSifreTxt.Size = new System.Drawing.Size(205, 20);
            this.ogretmenSifreTxt.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(103, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 48;
            this.label7.Text = "SİFRE :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(172, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 47;
            // 
            // sicilNoTxt
            // 
            this.sicilNoTxt.Location = new System.Drawing.Point(175, 135);
            this.sicilNoTxt.Name = "sicilNoTxt";
            this.sicilNoTxt.Size = new System.Drawing.Size(205, 20);
            this.sicilNoTxt.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(85, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 45;
            this.label9.Text = "SİCİL NO :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(175, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 44;
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(175, 102);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(205, 20);
            this.soyadTxt.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(98, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "SOYAD :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uyarıLbl
            // 
            this.uyarıLbl.AutoSize = true;
            this.uyarıLbl.ForeColor = System.Drawing.Color.Red;
            this.uyarıLbl.Location = new System.Drawing.Point(172, 69);
            this.uyarıLbl.Name = "uyarıLbl";
            this.uyarıLbl.Size = new System.Drawing.Size(0, 13);
            this.uyarıLbl.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(97, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "EKLE | GUNCELLE";
            // 
            // ogretmenAdiTxt
            // 
            this.ogretmenAdiTxt.Location = new System.Drawing.Point(175, 69);
            this.ogretmenAdiTxt.Name = "ogretmenAdiTxt";
            this.ogretmenAdiTxt.Size = new System.Drawing.Size(205, 20);
            this.ogretmenAdiTxt.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(121, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "AD : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ogrenciEkleBtn
            // 
            this.ogrenciEkleBtn.Location = new System.Drawing.Point(172, 431);
            this.ogrenciEkleBtn.Name = "ogrenciEkleBtn";
            this.ogrenciEkleBtn.Size = new System.Drawing.Size(205, 30);
            this.ogrenciEkleBtn.TabIndex = 37;
            this.ogrenciEkleBtn.Text = "EKLE";
            this.ogrenciEkleBtn.UseVisualStyleBackColor = true;
            this.ogrenciEkleBtn.Click += new System.EventHandler(this.ogrenciEkleBtn_Click);
            // 
            // ogretmenKontenjanTxt
            // 
            this.ogretmenKontenjanTxt.Location = new System.Drawing.Point(175, 201);
            this.ogretmenKontenjanTxt.Name = "ogretmenKontenjanTxt";
            this.ogretmenKontenjanTxt.Size = new System.Drawing.Size(205, 20);
            this.ogretmenKontenjanTxt.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(58, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 59;
            this.label3.Text = "KONTENJAN : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ilgiListesi1
            // 
            this.ilgiListesi1.FormattingEnabled = true;
            this.ilgiListesi1.Location = new System.Drawing.Point(175, 237);
            this.ilgiListesi1.Name = "ilgiListesi1";
            this.ilgiListesi1.Size = new System.Drawing.Size(205, 79);
            this.ilgiListesi1.TabIndex = 64;
            // 
            // verdigiDersListesi
            // 
            this.verdigiDersListesi.FormattingEnabled = true;
            this.verdigiDersListesi.Location = new System.Drawing.Point(172, 326);
            this.verdigiDersListesi.Name = "verdigiDersListesi";
            this.verdigiDersListesi.Size = new System.Drawing.Size(205, 79);
            this.verdigiDersListesi.TabIndex = 65;
            // 
            // AdminOgretmenPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1055, 564);
            this.Controls.Add(this.verdigiDersListesi);
            this.Controls.Add(this.ilgiListesi1);
            this.Controls.Add(this.ogretmenKontenjanTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ogrenciIdLbl);
            this.Controls.Add(this.ogrenciSilBtn);
            this.Controls.Add(this.ogrenciGuncelleBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ogretmenSifreTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sicilNoTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soyadTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uyarıLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ogretmenAdiTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ogrenciEkleBtn);
            this.Name = "AdminOgretmenPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgretmenPanel";
            this.Load += new System.EventHandler(this.AdminOgretmenPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ogrenciIdLbl;
        private System.Windows.Forms.Button ogrenciSilBtn;
        private System.Windows.Forms.Button ogrenciGuncelleBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ogretmenSifreTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sicilNoTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox soyadTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label uyarıLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ogretmenAdiTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ogrenciEkleBtn;
        private System.Windows.Forms.TextBox ogretmenKontenjanTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox ilgiListesi1;
        private System.Windows.Forms.CheckedListBox verdigiDersListesi;
    }
}