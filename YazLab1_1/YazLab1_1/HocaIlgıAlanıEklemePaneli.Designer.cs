namespace YazLab1_1
{
    partial class HocaIlgıAlanıEklemePaneli
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
            this.ilgiAlaniCheckBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ilgiAlaniGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ilgiAlaniCheckBox
            // 
            this.ilgiAlaniCheckBox.FormattingEnabled = true;
            this.ilgiAlaniCheckBox.Location = new System.Drawing.Point(12, 56);
            this.ilgiAlaniCheckBox.Name = "ilgiAlaniCheckBox";
            this.ilgiAlaniCheckBox.Size = new System.Drawing.Size(314, 184);
            this.ilgiAlaniCheckBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(107, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ILGI ALANLARI";
            // 
            // ilgiAlaniGuncelle
            // 
            this.ilgiAlaniGuncelle.Location = new System.Drawing.Point(213, 256);
            this.ilgiAlaniGuncelle.Name = "ilgiAlaniGuncelle";
            this.ilgiAlaniGuncelle.Size = new System.Drawing.Size(113, 33);
            this.ilgiAlaniGuncelle.TabIndex = 2;
            this.ilgiAlaniGuncelle.Text = "GUNCELLE";
            this.ilgiAlaniGuncelle.UseVisualStyleBackColor = true;
            this.ilgiAlaniGuncelle.Click += new System.EventHandler(this.ilgiAlaniGuncelle_Click);
            // 
            // HocaIlgıAlanıEklemePaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 342);
            this.Controls.Add(this.ilgiAlaniGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ilgiAlaniCheckBox);
            this.Name = "HocaIlgıAlanıEklemePaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HocaIlgıAlanıEklemePaneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ilgiAlaniCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ilgiAlaniGuncelle;
    }
}