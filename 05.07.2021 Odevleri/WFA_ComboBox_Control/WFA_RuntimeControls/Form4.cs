using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_RuntimeControls
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //ÖDEV
            //runtime'da combobox içerisinde sunulan hangi control seçilirse Flowlayoutpanel içerisinde o control buton ile beraber eklensin. (textbox,datetime) flowlayout panel içerisinde dahil edilen control'ün değeri doğrudan listbox içerisine gönderilecek.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Textbox
            //Button
            //Checkbox
            //Picturebox
            //listbox
            //Datetime
            flowLayoutPanel1.Controls.Clear();
            if (comboBox1.SelectedItem.ToString() == "Textbox")
            {
                TextBox txt = new TextBox();
                flowLayoutPanel1.Controls.Add(txt);
            }
            else if (comboBox1.SelectedItem.ToString() == "Button")
            {

            }
            else if (comboBox1.SelectedItem.ToString() == "Checkbox")
            {
                CheckBox chk = new CheckBox();
                flowLayoutPanel1.Controls.Add(chk);
            }
            else if (comboBox1.SelectedItem.ToString() == "Picturebox")
            {
                PictureBox pic = new PictureBox();
                flowLayoutPanel1.Controls.Add(pic);
            }
            else if (comboBox1.SelectedItem.ToString() == "listBox")
            {
                ListBox lst = new ListBox();
                flowLayoutPanel1.Controls.Add(lst);
            }
            else if (comboBox1.SelectedItem.ToString() == "DateTime")
            {
                DateTimePicker dtm = new DateTimePicker();
                flowLayoutPanel1.Controls.Add(dtm);
            }
                Button btn = new Button();
            btn.Width = 75;
            btn.Height = 23;
            btn.Text = "Onayla";
            flowLayoutPanel1.Controls.Add(btn);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            TextBox txt = (TextBox)sender;
            CheckBox chk = (CheckBox)sender;
            PictureBox pic = (PictureBox)sender;
            ListBox llst = (ListBox)sender;
            DateTimePicker dtm = (DateTimePicker)sender;
            if (comboBox1.SelectedItem.ToString() == "Textbox")
            {
                listBox1.Items.Add(txt.Text);
            }
            else if (comboBox1.SelectedItem.ToString() == "Button")
            {
                listBox1.Items.Add("Butona Tıkladınız!");
            }
            else if (comboBox1.SelectedItem.ToString() == "Checkbox")
            {
                if (chk.Checked)
                {
                    listBox1.Items.Add("Kutucuk şu an işaretli halde!");
                }
                else
                {
                    listBox1.Items.Add("Kutucuk işaretli halde değil!");
                }
                
            }
            else if (comboBox1.SelectedItem.ToString() == "Picturebox")
            {
                listBox1.Items.Add("Picturebox'ta hiç bir şey yok!");
            }
            else if (comboBox1.SelectedItem.ToString() == "listBox")
            {
                listBox1.Items.Add("listBox'un içi boş.");
            }
            else if (comboBox1.SelectedItem.ToString() == "DateTime")
            {
                listBox1.Items.Add(dtm.Value);
            }
        }
    }
}
