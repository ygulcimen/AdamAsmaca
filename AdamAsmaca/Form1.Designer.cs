namespace AdamAsmaca
{
    partial class Form1
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
            this.rtbKelime = new System.Windows.Forms.RichTextBox();
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.btnYeniKelime = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHarf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKalanHak = new System.Windows.Forms.Label();
            this.lblKelime = new System.Windows.Forms.Label();
            this.lblHarfUyari = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAranan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbKelime
            // 
            this.rtbKelime.Enabled = false;
            this.rtbKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbKelime.Location = new System.Drawing.Point(22, 77);
            this.rtbKelime.Name = "rtbKelime";
            this.rtbKelime.ReadOnly = true;
            this.rtbKelime.Size = new System.Drawing.Size(594, 54);
            this.rtbKelime.TabIndex = 0;
            this.rtbKelime.Text = "";
            this.rtbKelime.UseWaitCursor = true;
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.Location = new System.Drawing.Point(22, 192);
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(115, 36);
            this.btnTahminEt.TabIndex = 1;
            this.btnTahminEt.Text = "Tahmin Et";
            this.btnTahminEt.UseVisualStyleBackColor = true;
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // btnYeniKelime
            // 
            this.btnYeniKelime.Location = new System.Drawing.Point(483, 152);
            this.btnYeniKelime.Name = "btnYeniKelime";
            this.btnYeniKelime.Size = new System.Drawing.Size(133, 47);
            this.btnYeniKelime.TabIndex = 2;
            this.btnYeniKelime.Text = "Yeni Kelime";
            this.btnYeniKelime.UseVisualStyleBackColor = true;
            this.btnYeniKelime.Click += new System.EventHandler(this.btnYeniKelime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lütfen bir harf giriniz!";
            // 
            // tbHarf
            // 
            this.tbHarf.Location = new System.Drawing.Point(25, 164);
            this.tbHarf.MaxLength = 1;
            this.tbHarf.Name = "tbHarf";
            this.tbHarf.Size = new System.Drawing.Size(162, 22);
            this.tbHarf.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kalan Hakkınız: ";
            // 
            // lblKalanHak
            // 
            this.lblKalanHak.AutoSize = true;
            this.lblKalanHak.Location = new System.Drawing.Point(129, 247);
            this.lblKalanHak.Name = "lblKalanHak";
            this.lblKalanHak.Size = new System.Drawing.Size(16, 17);
            this.lblKalanHak.TabIndex = 6;
            this.lblKalanHak.Text = "3";
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelime.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblKelime.Location = new System.Drawing.Point(368, 40);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(0, 25);
            this.lblKelime.TabIndex = 7;
            this.lblKelime.Visible = false;
            // 
            // lblHarfUyari
            // 
            this.lblHarfUyari.AutoSize = true;
            this.lblHarfUyari.ForeColor = System.Drawing.Color.Red;
            this.lblHarfUyari.Location = new System.Drawing.Point(194, 168);
            this.lblHarfUyari.Name = "lblHarfUyari";
            this.lblHarfUyari.Size = new System.Drawing.Size(151, 17);
            this.lblHarfUyari.TabIndex = 8;
            this.lblHarfUyari.Text = "Boş karakter girilemez!";
            this.lblHarfUyari.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAranan
            // 
            this.lblAranan.AutoSize = true;
            this.lblAranan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAranan.Location = new System.Drawing.Point(166, 40);
            this.lblAranan.Name = "lblAranan";
            this.lblAranan.Size = new System.Drawing.Size(179, 25);
            this.lblAranan.TabIndex = 10;
            this.lblAranan.Text = "Aranan Kelime = ";
            this.lblAranan.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 340);
            this.Controls.Add(this.lblAranan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHarfUyari);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.lblKalanHak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHarf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYeniKelime);
            this.Controls.Add(this.btnTahminEt);
            this.Controls.Add(this.rtbKelime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adam Asmaca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbKelime;
        private System.Windows.Forms.Button btnTahminEt;
        private System.Windows.Forms.Button btnYeniKelime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHarf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKalanHak;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Label lblHarfUyari;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAranan;
    }
}

