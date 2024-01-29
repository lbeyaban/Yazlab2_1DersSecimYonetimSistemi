namespace YazLab1_1
{
    partial class DersEkleme
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
            this.label4 = new System.Windows.Forms.Label();
            this.dersAciklamasiRichBox = new System.Windows.Forms.RichTextBox();
            this.dersAdiTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dersEkleBtn1 = new System.Windows.Forms.Button();
            this.uyarıLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(165, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "DERS EKLEME SAYFASI";
            // 
            // dersAciklamasiRichBox
            // 
            this.dersAciklamasiRichBox.Location = new System.Drawing.Point(257, 202);
            this.dersAciklamasiRichBox.Name = "dersAciklamasiRichBox";
            this.dersAciklamasiRichBox.Size = new System.Drawing.Size(205, 96);
            this.dersAciklamasiRichBox.TabIndex = 10;
            this.dersAciklamasiRichBox.Text = "";
            // 
            // dersAdiTxtBox
            // 
            this.dersAdiTxtBox.Location = new System.Drawing.Point(257, 146);
            this.dersAdiTxtBox.Name = "dersAdiTxtBox";
            this.dersAdiTxtBox.Size = new System.Drawing.Size(205, 20);
            this.dersAdiTxtBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DERS AÇIKLAMASI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 152);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DERS ADI :";
            // 
            // dersEkleBtn1
            // 
            this.dersEkleBtn1.Location = new System.Drawing.Point(362, 334);
            this.dersEkleBtn1.Name = "dersEkleBtn1";
            this.dersEkleBtn1.Size = new System.Drawing.Size(100, 23);
            this.dersEkleBtn1.TabIndex = 6;
            this.dersEkleBtn1.Text = "DERS EKLE";
            this.dersEkleBtn1.UseVisualStyleBackColor = true;
            this.dersEkleBtn1.Click += new System.EventHandler(this.dersEkleBtn1_Click);
            // 
            // uyarıLbl
            // 
            this.uyarıLbl.AutoSize = true;
            this.uyarıLbl.ForeColor = System.Drawing.Color.Red;
            this.uyarıLbl.Location = new System.Drawing.Point(257, 111);
            this.uyarıLbl.Name = "uyarıLbl";
            this.uyarıLbl.Size = new System.Drawing.Size(0, 13);
            this.uyarıLbl.TabIndex = 12;
            // 
            // DersEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 444);
            this.Controls.Add(this.uyarıLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dersAciklamasiRichBox);
            this.Controls.Add(this.dersAdiTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dersEkleBtn1);
            this.Name = "DersEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DersEkleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox dersAciklamasiRichBox;
        private System.Windows.Forms.TextBox dersAdiTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dersEkleBtn1;
        private System.Windows.Forms.Label uyarıLbl;
    }
}