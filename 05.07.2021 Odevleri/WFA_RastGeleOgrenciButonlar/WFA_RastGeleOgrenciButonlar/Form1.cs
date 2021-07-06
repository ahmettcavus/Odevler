using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_RastGeleOgrenciButonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string[] sinifListesi = { "ABDULKADİR GÜL", "AHMET ALİBEŞE", "AHMET ÇAVUŞ", "ALİ FIRAT KARDAŞ", "ALPER SARMAN", "BERKAY SARMAN", "BURCU ÖZCAN", "GÖKÇEN AKÇA", "GÖKHAN ERYALÇIN", "İBRAHİM BERKAY KAÇAR", "İREM BUSE PINAR", "KAAN KİLİM", "KADİR KENAN", "SALİM FARUK POLAT", "YASİN SAF" };
        int sayac2 = 0;

        Random rnd = new Random();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int red = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);

            Button btn = new Button();

            btn.Width = 180;
            btn.Height = 20;

            int random = rnd.Next(0, sinifListesi.Length);

            if (sayac2 == sinifListesi.Length - 1)
            {
                btnEkle.Enabled = false;
            }
            btn.Text = sinifListesi[random] + " " + sayac2;
            sayac2++;


            btn.BackColor = Color.FromArgb(red, green, blue);
            int x = rnd.Next(0, this.ClientSize.Width - btn.Width);
            int y = rnd.Next(0, this.ClientSize.Height - btn.Height);

            btn.Left = x;
            btn.Top = y;

            this.Controls.Add(btn);

            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;//unboxing
            MessageBox.Show(btn.Text);
        }
    }
}
