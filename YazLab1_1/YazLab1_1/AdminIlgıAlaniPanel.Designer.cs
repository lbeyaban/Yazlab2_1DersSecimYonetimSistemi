namespace YazLab1_1
{
    partial class AdminIlgıAlaniPanel
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
            this.ilgiAlaniRich = new System.Windows.Forms.RichTextBox();
            this.ogrenciIdLbl = new System.Windows.Forms.Label();
            this.ilgiAlaniSilBtn = new System.Windows.Forms.Button();
            this.ilgiAlaniGuncelleBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uyarıLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ilgiAlaniTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ilgiEkleBtn = new System.Windows.Forms.Button();
            this.ilgiAlaniIdLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ilgiAlaniRich
            // 
            this.ilgiAlaniRich.Location = new System.Drawing.Point(172, 124);
            this.ilgiAlaniRich.Name = "ilgiAlaniRich";
            this.ilgiAlaniRich.Size = new System.Drawing.Size(205, 96);
            this.ilgiAlaniRich.TabIndex = 99;
            this.ilgiAlaniRich.Text = "";
            // 
            // ogrenciIdLbl
            // 
            this.ogrenciIdLbl.AutoSize = true;
            this.ogrenciIdLbl.Location = new System.Drawing.Point(169, 68);
            this.ogrenciIdLbl.Name = "ogrenciIdLbl";
            this.ogrenciIdLbl.Size = new System.Drawing.Size(0, 13);
            this.ogrenciIdLbl.TabIndex = 98;
            this.ogrenciIdLbl.Visible = false;
            // 
            // ilgiAlaniSilBtn
            // 
            this.ilgiAlaniSilBtn.Location = new System.Drawing.Point(172, 339);
            this.ilgiAlaniSilBtn.Name = "ilgiAlaniSilBtn";
            this.ilgiAlaniSilBtn.Size = new System.Drawing.Size(205, 31);
            this.ilgiAlaniSilBtn.TabIndex = 97;
            this.ilgiAlaniSilBtn.Text = "SİL";
            this.ilgiAlaniSilBtn.UseVisualStyleBackColor = true;
            this.ilgiAlaniSilBtn.Click += new System.EventHandler(this.ilgiAlaniSilBtn_Click);
            // 
            // ilgiAlaniGuncelleBtn
            // 
            this.ilgiAlaniGuncelleBtn.Location = new System.Drawing.Point(172, 291);
            this.ilgiAlaniGuncelleBtn.Name = "ilgiAlaniGuncelleBtn";
            this.ilgiAlaniGuncelleBtn.Size = new System.Drawing.Size(205, 31);
            this.ilgiAlaniGuncelleBtn.TabIndex = 96;
            this.ilgiAlaniGuncelleBtn.Text = "GUNCELLE";
            this.ilgiAlaniGuncelleBtn.UseVisualStyleBackColor = true;
            this.ilgiAlaniGuncelleBtn.Click += new System.EventHandler(this.ilgiAlaniGuncelleBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(395, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 508);
            this.dataGridView1.TabIndex = 95;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(172, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(74, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 93;
            this.label5.Text = "AÇIKLAMA :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uyarıLbl
            // 
            this.uyarıLbl.AutoSize = true;
            this.uyarıLbl.ForeColor = System.Drawing.Color.Red;
            this.uyarıLbl.Location = new System.Drawing.Point(169, 86);
            this.uyarıLbl.Name = "uyarıLbl";
            this.uyarıLbl.Size = new System.Drawing.Size(0, 13);
            this.uyarıLbl.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(103, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 25);
            this.label4.TabIndex = 91;
            this.label4.Text = "EKLE | GUNCELLE";
            // 
            // ilgiAlaniTxt
            // 
            this.ilgiAlaniTxt.Location = new System.Drawing.Point(172, 86);
            this.ilgiAlaniTxt.Name = "ilgiAlaniTxt";
            this.ilgiAlaniTxt.Size = new System.Drawing.Size(205, 20);
            this.ilgiAlaniTxt.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 89;
            this.label2.Text = "ILGI ALANI ADI :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ilgiEkleBtn
            // 
            this.ilgiEkleBtn.Location = new System.Drawing.Point(172, 244);
            this.ilgiEkleBtn.Name = "ilgiEkleBtn";
            this.ilgiEkleBtn.Size = new System.Drawing.Size(205, 30);
            this.ilgiEkleBtn.TabIndex = 88;
            this.ilgiEkleBtn.Text = "EKLE";
            this.ilgiEkleBtn.UseVisualStyleBackColor = true;
            this.ilgiEkleBtn.Click += new System.EventHandler(this.ilgiEkleBtn_Click);
            // 
            // ilgiAlaniIdLbl
            // 
            this.ilgiAlaniIdLbl.AutoSize = true;
            this.ilgiAlaniIdLbl.Location = new System.Drawing.Point(13, 13);
            this.ilgiAlaniIdLbl.Name = "ilgiAlaniIdLbl";
            this.ilgiAlaniIdLbl.Size = new System.Drawing.Size(0, 13);
            this.ilgiAlaniIdLbl.TabIndex = 100;
            this.ilgiAlaniIdLbl.Visible = false;
            // 
            // AdminIlgıAlaniPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 564);
            this.Controls.Add(this.ilgiAlaniIdLbl);
            this.Controls.Add(this.ilgiAlaniRich);
            this.Controls.Add(this.ogrenciIdLbl);
            this.Controls.Add(this.ilgiAlaniSilBtn);
            this.Controls.Add(this.ilgiAlaniGuncelleBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uyarıLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ilgiAlaniTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ilgiEkleBtn);
            this.Name = "AdminIlgıAlaniPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminIlgıAlaniPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ilgiAlaniRich;
        private System.Windows.Forms.Label ogrenciIdLbl;
        private System.Windows.Forms.Button ilgiAlaniSilBtn;
        private System.Windows.Forms.Button ilgiAlaniGuncelleBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label uyarıLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ilgiAlaniTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ilgiEkleBtn;
        private System.Windows.Forms.Label ilgiAlaniIdLbl;
    }
}