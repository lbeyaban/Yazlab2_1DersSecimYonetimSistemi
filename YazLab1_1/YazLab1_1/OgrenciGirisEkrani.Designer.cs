namespace YazLab1_1
{
    partial class OgrenciGirisEkrani
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrenciSifre = new System.Windows.Forms.TextBox();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ogrGirisBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(97, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Öğrenci No :";
            // 
            // txtOgrenciSifre
            // 
            this.txtOgrenciSifre.Location = new System.Drawing.Point(206, 180);
            this.txtOgrenciSifre.Name = "txtOgrenciSifre";
            this.txtOgrenciSifre.Size = new System.Drawing.Size(156, 20);
            this.txtOgrenciSifre.TabIndex = 7;
            this.txtOgrenciSifre.UseSystemPasswordChar = true;
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(206, 134);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(156, 20);
            this.txtOgrenciNo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(153, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "OGRENCI GIRIS";
            // 
            // ogrGirisBtn
            // 
            this.ogrGirisBtn.Location = new System.Drawing.Point(206, 233);
            this.ogrGirisBtn.Name = "ogrGirisBtn";
            this.ogrGirisBtn.Size = new System.Drawing.Size(156, 33);
            this.ogrGirisBtn.TabIndex = 11;
            this.ogrGirisBtn.Text = "Giriş Yap";
            this.ogrGirisBtn.UseVisualStyleBackColor = true;
            this.ogrGirisBtn.Click += new System.EventHandler(this.ogrGirisBtn_Click);
            // 
            // OgrenciGirisEkrani
            // 
            this.AcceptButton = this.ogrGirisBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 369);
            this.Controls.Add(this.ogrGirisBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOgrenciSifre);
            this.Controls.Add(this.txtOgrenciNo);
            this.Name = "OgrenciGirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciGirisEkrani";
            this.Load += new System.EventHandler(this.OgrenciGirisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrenciSifre;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ogrGirisBtn;
    }
}