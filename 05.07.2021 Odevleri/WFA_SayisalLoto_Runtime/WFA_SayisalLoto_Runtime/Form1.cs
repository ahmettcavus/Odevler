using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SayisalLoto_Runtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                Label lbl1 = new Label();

                lbl1.BorderStyle = BorderStyle.FixedSingle;
                lbl1.AutoSize = false;
                lbl1.Width = 100;
                lbl1.Height = 100;
                lbl1.Text = "0";
                lbl1.TextAlign = ContentAlignment.MiddleCenter;
                lbl1.Left = i * 105; lbl1.Top = 10;
                this.Controls.Add(lbl1);

            }

            for (int i = 0; i < 8; i++)
            {
                ListBox lst1 = new ListBox();

                lst1.Width = 147;
                lst1.Height = 173;

                if (i >= 0 && i < 4)
                {
                    lst1.Top = 130;
                    lst1.Left = i * 150;
                }
                else
                {
                    i = i - 4;
                    lst1.Top = 135 + lst1.Height;
                    lst1.Left = i * 150;
                    i = i + 4;
                }
                int j = 0;
                while (j < 6)
                {
                    int rndSayi = rnd.Next(1, 50);
                    if (!lst1.Items.Contains(rndSayi))
                    {
                        lst1.Items.Add(rndSayi);
                        j++;
                    }

                }
                this.Controls.Add(lst1);
            }

            Button btn = new Button();
            btn.Text = "OYNA";
            btn.Width = 90;
            btn.Height = 75;
            btn.Top = 30; btn.Left = 635;
            this.Controls.Add(btn);
            btn.Click += Btn_Click;
        }

        int[] array = { 0, 0, 0, 0, 0, 0 };
        int i = 0;
        int sayac2 = 0;

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            Random rnd = new Random();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {
                    Label lab = (Label)ctrl;

                    int miniSayac = 0;
                    while (miniSayac < 1)
                    {
                        string random = rnd.Next(1, 50).ToString();
                        if (!lab.Text.Contains(random))
                        {
                            lab.Text = random;
                            array[i] = Convert.ToInt32(lab.Text);
                            i++;
                            miniSayac++;
                        }
                    }
                }
                if (ctrl is ListBox)
                {
                    ListBox lst = (ListBox)ctrl;
                    lst.Items.Add("----------------");
                    foreach (int arrayMember in array)
                    {
                        for (int k = 0; k < 6; k++)
                        {
                            if (arrayMember == Convert.ToInt32(lst.Items[k]))
                            {
                                sayac2++;
                            }
                        }
                    }
                    lst.Items.Add("Tutan Sayılar: " + sayac2);
                    sayac2 = 0;
                }
            }
        }
    }
}
