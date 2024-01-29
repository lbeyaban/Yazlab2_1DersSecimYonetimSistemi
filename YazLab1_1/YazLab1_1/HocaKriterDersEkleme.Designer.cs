namespace YazLab1_1
{
    partial class HocaKriterDersEkleme
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
            this.dersListesiCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.katSayisiTxt = new System.Windows.Forms.TextBox();
            this.kriterDersEkle = new System.Windows.Forms.Button();
            this.ogrenciListele = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.kriterDersListesi = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dersListesiCombo
            // 
            this.dersListesiCombo.FormattingEnabled = true;
            this.dersListesiCombo.Location = new System.Drawing.Point(30, 60);
            this.dersListesiCombo.Name = "dersListesiCombo";
            this.dersListesiCombo.Size = new System.Drawing.Size(216, 21);
            this.dersListesiCombo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "KRITER DERS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "KAT SAYISI";
            // 
            // katSayisiTxt
            // 
            this.katSayisiTxt.Location = new System.Drawing.Point(30, 117);
            this.katSayisiTxt.Name = "katSayisiTxt";
            this.katSayisiTxt.Size = new System.Drawing.Size(216, 20);
            this.katSayisiTxt.TabIndex = 3;
            // 
            // kriterDersEkle
            // 
            this.kriterDersEkle.Location = new System.Drawing.Point(134, 143);
            this.kriterDersEkle.Name = "kriterDersEkle";
            this.kriterDersEkle.Size = new System.Drawing.Size(112, 30);
            this.kriterDersEkle.TabIndex = 4;
            this.kriterDersEkle.Text = "EKLE";
            this.kriterDersEkle.UseVisualStyleBackColor = true;
            this.kriterDersEkle.Click += new System.EventHandler(this.kriterDersEkle_Click);
            // 
            // ogrenciListele
            // 
            this.ogrenciListele.Location = new System.Drawing.Point(134, 397);
            this.ogrenciListele.Name = "ogrenciListele";
            this.ogrenciListele.Size = new System.Drawing.Size(112, 30);
            this.ogrenciListele.TabIndex = 5;
            this.ogrenciListele.Text = "LISTELE";
            this.ogrenciListele.UseVisualStyleBackColor = true;
            this.ogrenciListele.Click += new System.EventHandler(this.ogrenciListele_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "OGRENCI LISTESI";
            // 
            // kriterDersListesi
            // 
            this.kriterDersListesi.FormattingEnabled = true;
            this.kriterDersListesi.Location = new System.Drawing.Point(30, 244);
            this.kriterDersListesi.Name = "kriterDersListesi";
            this.kriterDersListesi.Size = new System.Drawing.Size(216, 147);
            this.kriterDersListesi.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(591, 366);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // HocaKriterDersEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 438);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kriterDersListesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ogrenciListele);
            this.Controls.Add(this.kriterDersEkle);
            this.Controls.Add(this.katSayisiTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dersListesiCombo);
            this.Name = "HocaKriterDersEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HocaKriterDersEkleme";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dersListesiCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox katSayisiTxt;
        private System.Windows.Forms.Button kriterDersEkle;
        private System.Windows.Forms.Button ogrenciListele;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox kriterDersListesi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}