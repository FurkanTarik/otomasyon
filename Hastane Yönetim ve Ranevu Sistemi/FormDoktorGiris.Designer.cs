namespace Hastane_Yönetim_ve_Ranevu_Sistemi
{
    partial class FormDoktorGiris
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNGIRIS = new System.Windows.Forms.Button();
            this.TXTSIFRE = new System.Windows.Forms.TextBox();
            this.MSKTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 199);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.BTNGIRIS);
            this.panel2.Controls.Add(this.TXTSIFRE);
            this.panel2.Controls.Add(this.MSKTC);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 339);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara Light", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(174, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 97);
            this.label1.TabIndex = 1;
            this.label1.Text = "DOKTOR GİRİŞ";
            // 
            // BTNGIRIS
            // 
            this.BTNGIRIS.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BTNGIRIS.FlatAppearance.BorderSize = 0;
            this.BTNGIRIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNGIRIS.ForeColor = System.Drawing.Color.Linen;
            this.BTNGIRIS.Location = new System.Drawing.Point(485, 220);
            this.BTNGIRIS.Name = "BTNGIRIS";
            this.BTNGIRIS.Size = new System.Drawing.Size(103, 36);
            this.BTNGIRIS.TabIndex = 8;
            this.BTNGIRIS.Text = "GİRİŞ";
            this.BTNGIRIS.UseVisualStyleBackColor = false;
            // 
            // TXTSIFRE
            // 
            this.TXTSIFRE.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TXTSIFRE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTSIFRE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TXTSIFRE.ForeColor = System.Drawing.Color.Linen;
            this.TXTSIFRE.Location = new System.Drawing.Point(426, 159);
            this.TXTSIFRE.Name = "TXTSIFRE";
            this.TXTSIFRE.Size = new System.Drawing.Size(162, 29);
            this.TXTSIFRE.TabIndex = 6;
            // 
            // MSKTC
            // 
            this.MSKTC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MSKTC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MSKTC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MSKTC.ForeColor = System.Drawing.Color.Linen;
            this.MSKTC.Location = new System.Drawing.Point(426, 69);
            this.MSKTC.Mask = "00000000000";
            this.MSKTC.Name = "MSKTC";
            this.MSKTC.Size = new System.Drawing.Size(162, 29);
            this.MSKTC.TabIndex = 4;
            this.MSKTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(234, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "ŞİFRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(234, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC KİMLİK ";
            // 
            // FormDoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDoktorGiris";
            this.Text = "FormDoktorGiris";
            this.Load += new System.EventHandler(this.FormDoktorGiris_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNGIRIS;
        private System.Windows.Forms.TextBox TXTSIFRE;
        private System.Windows.Forms.MaskedTextBox MSKTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}