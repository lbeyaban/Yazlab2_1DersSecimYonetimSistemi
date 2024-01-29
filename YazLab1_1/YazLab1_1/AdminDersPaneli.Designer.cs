namespace YazLab1_1
{
    partial class AdminDersPaneli
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
            this.dersSilBtn = new System.Windows.Forms.Button();
            this.dersGuncelleBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uyarıLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dersAdiTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dersEkleBtn = new System.Windows.Forms.Button();
            this.dersAciklamaRich = new System.Windows.Forms.RichTextBox();
            this.dersId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrenciIdLbl
            // 
            this.ogrenciIdLbl.AutoSize = true;
            this.ogrenciIdLbl.Location = new System.Drawing.Point(171, 68);
            this.ogrenciIdLbl.Name = "ogrenciIdLbl";
            this.ogrenciIdLbl.Size = new System.Drawing.Size(0, 13);
            this.ogrenciIdLbl.TabIndex = 83;
            this.ogrenciIdLbl.Visible = false;
            // 
            // dersSilBtn
            // 
            this.dersSilBtn.Location = new System.Drawing.Point(174, 339);
            this.dersSilBtn.Name = "dersSilBtn";
            this.dersSilBtn.Size = new System.Drawing.Size(205, 31);
            this.dersSilBtn.TabIndex = 82;
            this.dersSilBtn.Text = "SİL";
            this.dersSilBtn.UseVisualStyleBackColor = true;
            this.dersSilBtn.Click += new System.EventHandler(this.dersSilBtn_Click);
            // 
            // dersGuncelleBtn
            // 
            this.dersGuncelleBtn.Location = new System.Drawing.Point(174, 291);
            this.dersGuncelleBtn.Name = "dersGuncelleBtn";
            this.dersGuncelleBtn.Size = new System.Drawing.Size(205, 31);
            this.dersGuncelleBtn.TabIndex = 81;
            this.dersGuncelleBtn.Text = "GUNCELLE";
            this.dersGuncelleBtn.UseVisualStyleBackColor = true;
            this.dersGuncelleBtn.Click += new System.EventHandler(this.dersGuncelleBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(397, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 508);
            this.dataGridView1.TabIndex = 80;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(174, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(140, 15);
            this.label5.TabIndex = 69;
            this.label5.Text = "DERS ACIKLAMASI : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uyarıLbl
            // 
            this.uyarıLbl.AutoSize = true;
            this.uyarıLbl.ForeColor = System.Drawing.Color.Red;
            this.uyarıLbl.Location = new System.Drawing.Point(171, 86);
            this.uyarıLbl.Name = "uyarıLbl";
            this.uyarıLbl.Size = new System.Drawing.Size(0, 13);
            this.uyarıLbl.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(105, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 25);
            this.label4.TabIndex = 67;
            this.label4.Text = "EKLE | GUNCELLE";
            // 
            // dersAdiTxt
            // 
            this.dersAdiTxt.Location = new System.Drawing.Point(174, 86);
            this.dersAdiTxt.Name = "dersAdiTxt";
            this.dersAdiTxt.Size = new System.Drawing.Size(205, 20);
            this.dersAdiTxt.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(78, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 65;
            this.label2.Text = "DERS ADI :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dersEkleBtn
            // 
            this.dersEkleBtn.Location = new System.Drawing.Point(174, 244);
            this.dersEkleBtn.Name = "dersEkleBtn";
            this.dersEkleBtn.Size = new System.Drawing.Size(205, 30);
            this.dersEkleBtn.TabIndex = 64;
            this.dersEkleBtn.Text = "EKLE";
            this.dersEkleBtn.UseVisualStyleBackColor = true;
            this.dersEkleBtn.Click += new System.EventHandler(this.dersEkleBtn_Click);
            // 
            // dersAciklamaRich
            // 
            this.dersAciklamaRich.Location = new System.Drawing.Point(174, 124);
            this.dersAciklamaRich.Name = "dersAciklamaRich";
            this.dersAciklamaRich.Size = new System.Drawing.Size(205, 96);
            this.dersAciklamaRich.TabIndex = 87;
            this.dersAciklamaRich.Text = "";
            // 
            // dersId
            // 
            this.dersId.AutoSize = true;
            this.dersId.Location = new System.Drawing.Point(13, 13);
            this.dersId.Name = "dersId";
            this.dersId.Size = new System.Drawing.Size(0, 13);
            this.dersId.TabIndex = 88;
            this.dersId.Visible = false;
            // 
            // AdminDersPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 564);
            this.Controls.Add(this.dersId);
            this.Controls.Add(this.dersAciklamaRich);
            this.Controls.Add(this.ogrenciIdLbl);
            this.Controls.Add(this.dersSilBtn);
            this.Controls.Add(this.dersGuncelleBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uyarıLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dersAdiTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dersEkleBtn);
            this.Name = "AdminDersPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDersPaneli";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ogrenciIdLbl;
        private System.Windows.Forms.Button dersSilBtn;
        private System.Windows.Forms.Button dersGuncelleBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label uyarıLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dersAdiTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dersEkleBtn;
        private System.Windows.Forms.RichTextBox dersAciklamaRich;
        private System.Windows.Forms.Label dersId;
    }
}