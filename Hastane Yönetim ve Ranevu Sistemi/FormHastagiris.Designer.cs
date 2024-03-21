namespace Hastane_Yönetim_ve_Ranevu_Sistemi
{
    partial class FormHastagiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MSKTC = new System.Windows.Forms.MaskedTextBox();
            this.TXTSIFRE = new System.Windows.Forms.TextBox();
            this.BTNGIRIS = new System.Windows.Forms.Button();
            this.LINKKAYIT = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 129);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(120, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA GİRİŞ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(52, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC KİMLİK ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(52, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "ŞİFRE";
            // 
            // MSKTC
            // 
            this.MSKTC.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.MSKTC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MSKTC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MSKTC.ForeColor = System.Drawing.Color.White;
            this.MSKTC.Location = new System.Drawing.Point(244, 197);
            this.MSKTC.Mask = "00000000000";
            this.MSKTC.Name = "MSKTC";
            this.MSKTC.Size = new System.Drawing.Size(162, 29);
            this.MSKTC.TabIndex = 1;
            this.MSKTC.ValidatingType = typeof(int);
            // 
            // TXTSIFRE
            // 
            this.TXTSIFRE.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TXTSIFRE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTSIFRE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TXTSIFRE.ForeColor = System.Drawing.Color.White;
            this.TXTSIFRE.Location = new System.Drawing.Point(244, 287);
            this.TXTSIFRE.Name = "TXTSIFRE";
            this.TXTSIFRE.Size = new System.Drawing.Size(162, 29);
            this.TXTSIFRE.TabIndex = 2;
            // 
            // BTNGIRIS
            // 
            this.BTNGIRIS.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNGIRIS.FlatAppearance.BorderSize = 0;
            this.BTNGIRIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNGIRIS.ForeColor = System.Drawing.Color.White;
            this.BTNGIRIS.Location = new System.Drawing.Point(303, 348);
            this.BTNGIRIS.Name = "BTNGIRIS";
            this.BTNGIRIS.Size = new System.Drawing.Size(103, 36);
            this.BTNGIRIS.TabIndex = 3;
            this.BTNGIRIS.Text = "GİRİŞ";
            this.BTNGIRIS.UseVisualStyleBackColor = false;
            // 
            // LINKKAYIT
            // 
            this.LINKKAYIT.ActiveLinkColor = System.Drawing.Color.White;
            this.LINKKAYIT.AutoSize = true;
            this.LINKKAYIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LINKKAYIT.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LINKKAYIT.LinkColor = System.Drawing.SystemColors.WindowFrame;
            this.LINKKAYIT.Location = new System.Drawing.Point(448, 287);
            this.LINKKAYIT.Name = "LINKKAYIT";
            this.LINKKAYIT.Size = new System.Drawing.Size(116, 35);
            this.LINKKAYIT.TabIndex = 4;
            this.LINKKAYIT.TabStop = true;
            this.LINKKAYIT.Text = "KAYIT OL";
            this.LINKKAYIT.VisitedLinkColor = System.Drawing.SystemColors.WindowFrame;
            // 
            // FormHastagiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(632, 440);
            this.Controls.Add(this.LINKKAYIT);
            this.Controls.Add(this.BTNGIRIS);
            this.Controls.Add(this.TXTSIFRE);
            this.Controls.Add(this.MSKTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Carlito", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormHastagiris";
            this.Text = "FormHastagiris";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MSKTC;
        private System.Windows.Forms.TextBox TXTSIFRE;
        private System.Windows.Forms.Button BTNGIRIS;
        private System.Windows.Forms.LinkLabel LINKKAYIT;
    }
}