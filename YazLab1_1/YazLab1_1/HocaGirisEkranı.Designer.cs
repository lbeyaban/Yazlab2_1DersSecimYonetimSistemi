namespace YazLab1_1
{
    partial class HocaGirisEkranı
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
            this.hocaGirisBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHocaSifre = new System.Windows.Forms.TextBox();
            this.txtSicilNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hocaGirisBtn
            // 
            this.hocaGirisBtn.Location = new System.Drawing.Point(209, 261);
            this.hocaGirisBtn.Name = "hocaGirisBtn";
            this.hocaGirisBtn.Size = new System.Drawing.Size(156, 31);
            this.hocaGirisBtn.TabIndex = 17;
            this.hocaGirisBtn.Text = "Giriş Yap";
            this.hocaGirisBtn.UseVisualStyleBackColor = true;
            this.hocaGirisBtn.Click += new System.EventHandler(this.hocaGirisBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(167, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "HOCA GIRIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(100, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Şifre : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(100, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sicil No :";
            // 
            // txtHocaSifre
            // 
            this.txtHocaSifre.Location = new System.Drawing.Point(209, 208);
            this.txtHocaSifre.Name = "txtHocaSifre";
            this.txtHocaSifre.Size = new System.Drawing.Size(156, 20);
            this.txtHocaSifre.TabIndex = 13;
            this.txtHocaSifre.UseSystemPasswordChar = true;
            // 
            // txtSicilNo
            // 
            this.txtSicilNo.Location = new System.Drawing.Point(209, 162);
            this.txtSicilNo.Name = "txtSicilNo";
            this.txtSicilNo.Size = new System.Drawing.Size(156, 20);
            this.txtSicilNo.TabIndex = 12;
            // 
            // HocaGirisEkranı
            // 
            this.AcceptButton = this.hocaGirisBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 369);
            this.Controls.Add(this.hocaGirisBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHocaSifre);
            this.Controls.Add(this.txtSicilNo);
            this.Name = "HocaGirisEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HocaGirisEkranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hocaGirisBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHocaSifre;
        private System.Windows.Forms.TextBox txtSicilNo;
    }
}