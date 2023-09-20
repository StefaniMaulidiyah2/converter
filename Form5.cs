using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converter
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value1 = comboBox1.SelectedItem.ToString();
            string value2 = comboBox2.SelectedItem.ToString();

            double angka = double.Parse(bunifuTextBox1.Text);

            double hasil = 0;

            if (value1 == "km")
            {
                if (value2 == "km")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "hm")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "dam")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "m")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "dm")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "cm")
                {
                    hasil = angka * 100000;
                }
                else if (value2 == "mm")
                {
                    hasil = angka * 1000000;
                }
            }
            if (value1 == "hm")
            {
                if (value2 == "km")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "hm")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "dam")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "m")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "dm")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "cm")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "mm")
                {
                    hasil = angka * 100000;
                }
            }
            if (value1 == "dam")
            {
                if (value2 == "km")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "hm")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "dam")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "m")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "dm")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "cm")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "mm")
                {
                    hasil = angka * 10000;
                }
            }
            if (value1 == "m")
            {
                if (value2 == "km")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "hm")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "dam")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "m")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "dm")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "cm")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "mm")
                {
                    hasil = angka * 1000;
                }
            }
            if (value1 == "dm")
            {
                if (value2 == "km")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "hm")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "dam")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "m")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "dm")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "cm")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "mm")
                {
                    hasil = angka * 100;
                }
            }
            if (value1 == "cm")
            {
                if (value2 == "km")
                {
                    hasil = angka / 100000;
                }
                else if (value2 == "hm")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "dam")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "m")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "dm")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "cm")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "mm")
                {
                    hasil = angka * 10;
                }
            }
            if (value1 == "mm")
            {
                if (value2 == "km")
                {
                    hasil = angka / 1000000;
                }
                else if (value2 == "hm")
                {
                    hasil = angka / 100000;
                }
                else if (value2 == "dam")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "m")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "dm")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "cm")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "mm")
                {
                    hasil = angka * 1;
                }
            }
            bunifuTextBox2.Text = ("  " + hasil);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bunifuImageButton1.Click += new
                EventHandler(bunifuImageButton1_Click);
            Controls.Add(bunifuImageButton1);
            form2 fm2 = new form2();
            fm2.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
