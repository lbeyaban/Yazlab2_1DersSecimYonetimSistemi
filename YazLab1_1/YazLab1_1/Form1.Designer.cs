namespace YazLab1_1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ogrenciGirisBtn = new System.Windows.Forms.Button();
            this.hocaGirisBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.yoneticiGirisBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ogrenciGirisBtn
            // 
            this.ogrenciGirisBtn.Location = new System.Drawing.Point(93, 158);
            this.ogrenciGirisBtn.Name = "ogrenciGirisBtn";
            this.ogrenciGirisBtn.Size = new System.Drawing.Size(243, 69);
            this.ogrenciGirisBtn.TabIndex = 0;
            this.ogrenciGirisBtn.Text = "OGRENCİ ";
            this.ogrenciGirisBtn.UseVisualStyleBackColor = true;
            this.ogrenciGirisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // hocaGirisBtn
            // 
            this.hocaGirisBtn.Location = new System.Drawing.Point(93, 250);
            this.hocaGirisBtn.Name = "hocaGirisBtn";
            this.hocaGirisBtn.Size = new System.Drawing.Size(243, 69);
            this.hocaGirisBtn.TabIndex = 1;
            this.hocaGirisBtn.Text = "HOCA";
            this.hocaGirisBtn.UseVisualStyleBackColor = true;
            this.hocaGirisBtn.Click += new System.EventHandler(this.hocaGirisBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(49, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Öğrenci Proje Yönetim Sistemi";
            // 
            // yoneticiGirisBtn
            // 
            this.yoneticiGirisBtn.Location = new System.Drawing.Point(93, 349);
            this.yoneticiGirisBtn.Name = "yoneticiGirisBtn";
            this.yoneticiGirisBtn.Size = new System.Drawing.Size(243, 69);
            this.yoneticiGirisBtn.TabIndex = 7;
            this.yoneticiGirisBtn.Text = "YONETICI";
            this.yoneticiGirisBtn.UseVisualStyleBackColor = true;
            this.yoneticiGirisBtn.Click += new System.EventHandler(this.yoneticiGirisBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 510);
            this.Controls.Add(this.yoneticiGirisBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hocaGirisBtn);
            this.Controls.Add(this.ogrenciGirisBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ogrenciGirisBtn;
        private System.Windows.Forms.Button hocaGirisBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button yoneticiGirisBtn;
    }
}

