using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMenu.Items.Add("McHamburger");
            cmbMenu.Items.Add("McAlaturca");
            cmbMenu.Items.Add("McChicken");
            cmbMenu.Items.Add("McAdamBurger");
        }
        int fiyat = 0;
        int fiyatHepsiToplam = 0;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            ListViewItem lst = new ListViewItem();
            lst.Text = cmbMenu.SelectedItem.ToString();
            int hamburgerFiyat = 0;
            if (cmbMenu.SelectedItem.ToString() == "McHamburger")
            {
                hamburgerFiyat += 40;
            }
            if (cmbMenu.SelectedItem.ToString() == "McAlaturca")
            {
                hamburgerFiyat += 30;
            }
            if (cmbMenu.SelectedItem.ToString() == "McChicken")
            {
                hamburgerFiyat += 15;
            }
            if (cmbMenu.SelectedItem.ToString() == "McAdamBurger")
            {
                hamburgerFiyat += 25;
            }
            fiyat += hamburgerFiyat;
            hamburgerFiyat = 0;

            string ebat = "";
            int ebatFiyat = 0;
            if (rdOrta.Checked)
            {
                ebat = "Orta";
            }
            if (rdBuyuk.Checked)
            {
                ebat = "Büyük";
                ebatFiyat += 5;
            }
            if (rdKing.Checked)
            {
                ebat = "King";
                ebatFiyat += 10;
            }
            fiyat += ebatFiyat;
            ebatFiyat = 0;

            if (!rdOrta.Checked&&!rdBuyuk.Checked&&!rdKing.Checked)
            {
                MessageBox.Show("Lütfen bir boy seçimi yapınız!","Boy Seçimi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            lst.SubItems.Add(ebat);
            lst.SubItems.Add(SosHesaplama());
            lst.SubItems.Add(nudAdet.Value.ToString());
            fiyat = fiyat * Convert.ToInt32(nudAdet.Value);
            lst.SubItems.Add(fiyat.ToString());
            listView1.Items.Add(lst);
            fiyatHepsiToplam += fiyat;
            fiyat = 0;
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show(string.Format("Sipariş bedeliniz toplam {0} Siparişinizi tamamlamak istiyor musunuz?",fiyatHepsiToplam), "Sipariş", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            fiyatHepsiToplam = 0;
            if (dr == DialogResult.Yes)
            {
                listView1.Items.Clear();
            }
        }
        string SosHesaplama()
        {
            string sosRanchVar = "";
            string sosBarbekuVar = "";
            string sosBuffaloVar = "";
            string sosHardalVar = "";
            string sosMayonezVar = "";
            string sosBalliHardalVar = "";
            int sosFiyat = 0;
            if (chkRanch.Checked)
            {
                sosRanchVar = "Ranch Sos";
                sosFiyat += 2;
            }
            if (chkBarbeku.Checked)
            {
                sosBarbekuVar = "Barbekü Sos";
                sosFiyat += 2;
            }
            if (chkBuffalo.Checked)
            {
                sosBuffaloVar = "Buffalo Sos";
                sosFiyat += 2;
            }
            if (chkHardal.Checked)
            {
                sosHardalVar = "Hardal";
                sosFiyat += 2;
            }
            if (chkMayonez.Checked)
            {
                sosMayonezVar = "Mayonez";
                sosFiyat += 2;
            }
            if (chkBalliHardal.Checked)
            {
                sosBalliHardalVar = "Ballı Hardal";
                sosFiyat += 2;
            }
            fiyat += sosFiyat;
            string deger = string.Format("{0} {1} {2} {3} {4} {5}", sosRanchVar, sosBarbekuVar, sosBuffaloVar, sosHardalVar, sosMayonezVar, sosBalliHardalVar);
            sosRanchVar = "";
            sosBarbekuVar = "";
            sosBuffaloVar = "";
            sosHardalVar = "";
            sosMayonezVar = "";
            sosBalliHardalVar = "";
            return deger;
        }
    }
}
