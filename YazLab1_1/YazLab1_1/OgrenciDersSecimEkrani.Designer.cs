namespace YazLab1_1
{
    partial class OgrenciDersSecimEkrani
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
            this.acilanDersListesiCBox = new System.Windows.Forms.ComboBox();
            this.mesajRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.talepOlusturBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.talepIptal = new System.Windows.Forms.Button();
            this.karakterSayaciLbl = new System.Windows.Forms.Label();
            this.talepIdLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DERS SECINIZ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "MESAJINIZI YAZINIZ :";
            // 
            // acilanDersListesiCBox
            // 
            this.acilanDersListesiCBox.FormattingEnabled = true;
            this.acilanDersListesiCBox.Location = new System.Drawing.Point(189, 105);
            this.acilanDersListesiCBox.Name = "acilanDersListesiCBox";
            this.acilanDersListesiCBox.Size = new System.Drawing.Size(293, 21);
            this.acilanDersListesiCBox.TabIndex = 2;
            // 
            // mesajRichTextBox1
            // 
            this.mesajRichTextBox1.Location = new System.Drawing.Point(189, 169);
            this.mesajRichTextBox1.Name = "mesajRichTextBox1";
            this.mesajRichTextBox1.Size = new System.Drawing.Size(293, 175);
            this.mesajRichTextBox1.TabIndex = 3;
            this.mesajRichTextBox1.Text = "";
            this.mesajRichTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mesajRichTextBox1_KeyPress);
            // 
            // talepOlusturBtn
            // 
            this.talepOlusturBtn.Location = new System.Drawing.Point(249, 388);
            this.talepOlusturBtn.Name = "talepOlusturBtn";
            this.talepOlusturBtn.Size = new System.Drawing.Size(105, 33);
            this.talepOlusturBtn.TabIndex = 4;
            this.talepOlusturBtn.Text = "TALEP ET";
            this.talepOlusturBtn.UseVisualStyleBackColor = true;
            this.talepOlusturBtn.Click += new System.EventHandler(this.talepOlusturBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(573, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ONAY BEKLEYENLER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(573, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ONAYLANMIS DERSLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(577, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(433, 188);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(577, 360);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(433, 185);
            this.dataGridView2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(172, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "DERS TALEBI OLUSTUR";
            // 
            // talepIptal
            // 
            this.talepIptal.Location = new System.Drawing.Point(377, 388);
            this.talepIptal.Name = "talepIptal";
            this.talepIptal.Size = new System.Drawing.Size(105, 33);
            this.talepIptal.TabIndex = 10;
            this.talepIptal.Text = "IPTAL ET";
            this.talepIptal.UseVisualStyleBackColor = true;
            this.talepIptal.Click += new System.EventHandler(this.talepIptal_Click);
            // 
            // karakterSayaciLbl
            // 
            this.karakterSayaciLbl.AutoSize = true;
            this.karakterSayaciLbl.Location = new System.Drawing.Point(447, 360);
            this.karakterSayaciLbl.Name = "karakterSayaciLbl";
            this.karakterSayaciLbl.Size = new System.Drawing.Size(0, 13);
            this.karakterSayaciLbl.TabIndex = 11;
            // 
            // talepIdLbl
            // 
            this.talepIdLbl.AutoSize = true;
            this.talepIdLbl.Location = new System.Drawing.Point(13, 13);
            this.talepIdLbl.Name = "talepIdLbl";
            this.talepIdLbl.Size = new System.Drawing.Size(0, 13);
            this.talepIdLbl.TabIndex = 12;
            this.talepIdLbl.Visible = false;
            // 
            // OgrenciDersSecimEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 557);
            this.Controls.Add(this.talepIdLbl);
            this.Controls.Add(this.karakterSayaciLbl);
            this.Controls.Add(this.talepIptal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.talepOlusturBtn);
            this.Controls.Add(this.mesajRichTextBox1);
            this.Controls.Add(this.acilanDersListesiCBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OgrenciDersSecimEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciDersSecimEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox acilanDersListesiCBox;
        private System.Windows.Forms.RichTextBox mesajRichTextBox1;
        private System.Windows.Forms.Button talepOlusturBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button talepIptal;
        private System.Windows.Forms.Label karakterSayaciLbl;
        private System.Windows.Forms.Label talepIdLbl;
    }
}