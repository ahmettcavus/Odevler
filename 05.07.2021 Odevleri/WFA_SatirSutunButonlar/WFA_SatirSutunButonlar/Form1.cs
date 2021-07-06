using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SatirSutunButonlar
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

        private void button1_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flw = new FlowLayoutPanel();
            flw.Width = 850;
            flw.Height = 320;
            this.Controls.Add(flw);

            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Button btn = new Button();
                    btn.Text = (i.ToString() +"x"+ j.ToString());
                    flw.Controls.Add(btn);
                }
            }
        }
    }
}
