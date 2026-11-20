using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şifre_Güvenlik_Analizörü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnaliz_Click(object sender, EventArgs e)
        {
           
            {
                string sifre = txtSifre.Text;
                int puan = 0;
                string eksikler = "";

                if (sifre.Length >= 8) puan += 20;
                else eksikler += "- En az 8 karakter olmalı\n";

                if (sifre.Any(char.IsUpper)) puan += 20;
                else eksikler += "- Büyük harf eklemelisin\n";

                if (sifre.Any(char.IsLower)) puan += 20;
                else eksikler += "- Küçük harf eklemelisin\n";

                if (sifre.Any(char.IsDigit)) puan += 20;
                else eksikler += "- Rakam eklemelisin\n";

                if (sifre.Any(ch => !char.IsLetterOrDigit(ch))) puan += 20;
                else eksikler += "- Özel karakter (!, *, ? vb.) eklemelisin\n";

                pbGuc.Value = puan;

                if (puan < 60)
                {
                    lblsonuc.ForeColor = System.Drawing.Color.Red;
                    lblsonuc.Text = $"Puan: {puan}/100 - ZAYIF ŞİFRE!\nEksikler:\n{eksikler}";
                }
                else if (puan < 100)
                {
                    lblsonuc.ForeColor = System.Drawing.Color.DarkOrange;
                    lblsonuc.Text = $"Puan: {puan}/100 - ORTA SEVİYE\nEksikler:\n{eksikler}";
                }
                else
                {
                    lblsonuc.ForeColor = System.Drawing.Color.Green;
                    lblsonuc.Text = $"Puan: {puan}/100 - GÜÇLÜ ŞİFRE!\nTüm kurallara uyuyor.";
                }
            }

        }
    }
}
