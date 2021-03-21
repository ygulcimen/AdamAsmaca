using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmaca
{
    public partial class Form1 : Form
    {
        
        AdamAsmacaOperations a1;
        public Form1()
        {
            InitializeComponent();
            a1 = new AdamAsmacaOperations();
            rtbKelime.SelectionAlignment = HorizontalAlignment.Center;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string word = a1.ChooseWord();
            rtbKelime.Text = a1.Transform(word);
            lblKelime.Text = word;
        }

        private void btnYeniKelime_Click(object sender, EventArgs e)
        {
            string word = a1.ChooseWord();
            rtbKelime.Text = a1.Transform(word);
            lblKelime.Text = word;
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            
            tbHarf.Text = tbHarf.Text.Trim();
            if (String.IsNullOrEmpty(tbHarf.Text))
            {
                lblHarfUyari.Visible = true;
                return;
            }
            else
            {
                lblHarfUyari.Visible = false;
            }
            string a = a1.HarfAcma(lblKelime.Text, rtbKelime.Text, tbHarf.Text[0]);
            if (a==rtbKelime.Text)
            {
                lblKalanHak.Text = (Convert.ToInt32(lblKalanHak.Text) - 1).ToString();
            }
            else
            {
                rtbKelime.Text = a;
            }
            if (lblKalanHak.Text=="0")
            {
                lblAranan.Visible = true;
                lblKelime.Visible = true;
                DialogResult res = MessageBox.Show("Oyunu Kaybettiniz! Yeniden denemek ister misiniz?","Oyun Sonucu", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    lblAranan.Visible = false;
                    lblKelime.Visible = false;
                    string word = a1.ChooseWord();
                    rtbKelime.Text = a1.Transform(word);
                    lblKelime.Text = word;
                    lblKalanHak.Text = "3";
                    tbHarf.Text = "";
                }
                else
                {
                    this.Close();
                }
            }
            if (a==lblKelime.Text)
            {
                lblAranan.Visible = true;
                lblKelime.Visible = true;
                DialogResult res = MessageBox.Show("Oyunu Kazandınız \nYeniden denemek ister misiniz?", "Tebrikler!!", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    lblAranan.Visible = false;
                    lblKelime.Visible = false;
                    string word = a1.ChooseWord();
                    rtbKelime.Text = a1.Transform(word);
                    lblKelime.Text = word;
                    lblKalanHak.Text = "3";
                    tbHarf.Text = "";
                }
                else
                {
                    this.Close();
                }
            }
            tbHarf.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
