namespace YazLab1_1
{
    partial class HocaZorunluDersSecme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ogrenciCombo = new System.Windows.Forms.ComboBox();
            this.dersCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OGRENCI ISMI ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DERSLER";
            // 
            // ogrenciCombo
            // 
            this.ogrenciCombo.FormattingEnabled = true;
            this.ogrenciCombo.Location = new System.Drawing.Point(53, 68);
            this.ogrenciCombo.Name = "ogrenciCombo";
            this.ogrenciCombo.Size = new System.Drawing.Size(146, 21);
            this.ogrenciCombo.TabIndex = 2;
            // 
            // dersCombo
            // 
            this.dersCombo.FormattingEnabled = true;
            this.dersCombo.Location = new System.Drawing.Point(288, 68);
            this.dersCombo.Name = "dersCombo";
            this.dersCombo.Size = new System.Drawing.Size(146, 21);
            this.dersCombo.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "DERS EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HocaZorunluDersSecme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 136);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dersCombo);
            this.Controls.Add(this.ogrenciCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HocaZorunluDersSecme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HocaZorunluDersSecme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ogrenciCombo;
        private System.Windows.Forms.ComboBox dersCombo;
        private System.Windows.Forms.Button button1;
    }
}