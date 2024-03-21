namespace Hastane_Yönetim_ve_Ranevu_Sistemi
{
    partial class FormHastaGirisEkranı
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBLSOYAD = new System.Windows.Forms.Label();
            this.LBLAD = new System.Windows.Forms.Label();
            this.LBLTC = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CMBXBRANS = new System.Windows.Forms.ComboBox();
            this.CMBXDOKTOR = new System.Windows.Forms.ComboBox();
            this.RICHSIKAYET = new System.Windows.Forms.RichTextBox();
            this.BTNRANDEVU = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LNKBILGIDUZENLE = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1374, 153);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam Libre", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(334, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTANE BİLGİ SİSTEMİ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1374, 756);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.LBLSOYAD);
            this.groupBox1.Controls.Add(this.LBLAD);
            this.groupBox1.Controls.Add(this.LBLTC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Azure;
            this.groupBox1.Location = new System.Drawing.Point(28, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 282);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KİŞİ BİLGİSİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "AD ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "SOYAD ";
            // 
            // LBLSOYAD
            // 
            this.LBLSOYAD.AutoSize = true;
            this.LBLSOYAD.Location = new System.Drawing.Point(138, 200);
            this.LBLSOYAD.Name = "LBLSOYAD";
            this.LBLSOYAD.Size = new System.Drawing.Size(66, 30);
            this.LBLSOYAD.TabIndex = 7;
            this.LBLSOYAD.Text = "NULL";
            // 
            // LBLAD
            // 
            this.LBLAD.AutoSize = true;
            this.LBLAD.Location = new System.Drawing.Point(138, 132);
            this.LBLAD.Name = "LBLAD";
            this.LBLAD.Size = new System.Drawing.Size(66, 30);
            this.LBLAD.TabIndex = 6;
            this.LBLAD.Text = "NULL";
            // 
            // LBLTC
            // 
            this.LBLTC.AutoSize = true;
            this.LBLTC.Location = new System.Drawing.Point(138, 62);
            this.LBLTC.Name = "LBLTC";
            this.LBLTC.Size = new System.Drawing.Size(167, 30);
            this.LBLTC.TabIndex = 5;
            this.LBLTC.Text = "00000000000";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox2.Controls.Add(this.LNKBILGIDUZENLE);
            this.groupBox2.Controls.Add(this.BTNRANDEVU);
            this.groupBox2.Controls.Add(this.RICHSIKAYET);
            this.groupBox2.Controls.Add(this.CMBXDOKTOR);
            this.groupBox2.Controls.Add(this.CMBXBRANS);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.Azure;
            this.groupBox2.Location = new System.Drawing.Point(28, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 396);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RANDEVU PANELİ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 38);
            this.label11.TabIndex = 4;
            this.label11.Text = "ŞİKAYET";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 30);
            this.label12.TabIndex = 3;
            this.label12.Text = "DOKTOR";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 30);
            this.label13.TabIndex = 2;
            this.label13.Text = "BRANŞ";
            // 
            // CMBXBRANS
            // 
            this.CMBXBRANS.BackColor = System.Drawing.Color.RosyBrown;
            this.CMBXBRANS.ForeColor = System.Drawing.Color.Azure;
            this.CMBXBRANS.FormattingEnabled = true;
            this.CMBXBRANS.Location = new System.Drawing.Point(154, 56);
            this.CMBXBRANS.Name = "CMBXBRANS";
            this.CMBXBRANS.Size = new System.Drawing.Size(205, 38);
            this.CMBXBRANS.TabIndex = 2;
            // 
            // CMBXDOKTOR
            // 
            this.CMBXDOKTOR.BackColor = System.Drawing.Color.RosyBrown;
            this.CMBXDOKTOR.ForeColor = System.Drawing.Color.Azure;
            this.CMBXDOKTOR.FormattingEnabled = true;
            this.CMBXDOKTOR.Location = new System.Drawing.Point(154, 126);
            this.CMBXDOKTOR.Name = "CMBXDOKTOR";
            this.CMBXDOKTOR.Size = new System.Drawing.Size(205, 38);
            this.CMBXDOKTOR.TabIndex = 5;
            // 
            // RICHSIKAYET
            // 
            this.RICHSIKAYET.BackColor = System.Drawing.Color.RosyBrown;
            this.RICHSIKAYET.ForeColor = System.Drawing.Color.Azure;
            this.RICHSIKAYET.Location = new System.Drawing.Point(154, 194);
            this.RICHSIKAYET.Name = "RICHSIKAYET";
            this.RICHSIKAYET.Size = new System.Drawing.Size(205, 117);
            this.RICHSIKAYET.TabIndex = 6;
            this.RICHSIKAYET.Text = "";
            // 
            // BTNRANDEVU
            // 
            this.BTNRANDEVU.BackColor = System.Drawing.Color.RosyBrown;
            this.BTNRANDEVU.FlatAppearance.BorderSize = 0;
            this.BTNRANDEVU.ForeColor = System.Drawing.Color.Azure;
            this.BTNRANDEVU.Location = new System.Drawing.Point(19, 270);
            this.BTNRANDEVU.Name = "BTNRANDEVU";
            this.BTNRANDEVU.Size = new System.Drawing.Size(122, 41);
            this.BTNRANDEVU.TabIndex = 2;
            this.BTNRANDEVU.Text = "RANDEVU";
            this.BTNRANDEVU.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.ForeColor = System.Drawing.Color.Azure;
            this.groupBox3.Location = new System.Drawing.Point(448, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(914, 343);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RANDEVU GEÇMİŞİ";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.ForeColor = System.Drawing.Color.Azure;
            this.groupBox4.Location = new System.Drawing.Point(451, 525);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(911, 372);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "AKTİF RANDEVULAR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Azure;
            this.dataGridView1.Location = new System.Drawing.Point(3, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(908, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.GridColor = System.Drawing.Color.Azure;
            this.dataGridView2.Location = new System.Drawing.Point(3, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(905, 335);
            this.dataGridView2.TabIndex = 1;
            // 
            // LNKBILGIDUZENLE
            // 
            this.LNKBILGIDUZENLE.AutoSize = true;
            this.LNKBILGIDUZENLE.BackColor = System.Drawing.Color.RosyBrown;
            this.LNKBILGIDUZENLE.ForeColor = System.Drawing.Color.Azure;
            this.LNKBILGIDUZENLE.LinkColor = System.Drawing.Color.Azure;
            this.LNKBILGIDUZENLE.Location = new System.Drawing.Point(50, 346);
            this.LNKBILGIDUZENLE.Name = "LNKBILGIDUZENLE";
            this.LNKBILGIDUZENLE.Size = new System.Drawing.Size(241, 30);
            this.LNKBILGIDUZENLE.TabIndex = 7;
            this.LNKBILGIDUZENLE.TabStop = true;
            this.LNKBILGIDUZENLE.Text = "BİLGİLERİNİ DÜZENLE";
            // 
            // FormHastaGirisEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1374, 909);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Miriam Libre", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormHastaGirisEkranı";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormHastaGirisEkranı_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CMBXDOKTOR;
        private System.Windows.Forms.ComboBox CMBXBRANS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBLSOYAD;
        private System.Windows.Forms.Label LBLAD;
        private System.Windows.Forms.Label LBLTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RICHSIKAYET;
        private System.Windows.Forms.Button BTNRANDEVU;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel LNKBILGIDUZENLE;
    }
}