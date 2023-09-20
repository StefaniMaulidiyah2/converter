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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value1 = comboBox1.SelectedItem.ToString();
            string value2 = comboBox2.SelectedItem.ToString();

            double angka = double.Parse(bunifuTextBox1.Text);

            double hasil = 0;

            if (value1 == "detik")
            {
                if (value2 == "detik")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "menit")
                {
                    hasil = angka / 60;
                }
                else if (value2 == "jam")
                {
                    hasil = angka / 3600;
                }
                else if (value2 == "hari")
                {
                    hasil = angka / 86400;
                }
                else if (value2 == "minggu")
                {
                    hasil = angka / 604800;
                }
            }
            if (value1 == "menit")
            {
                if (value2 == "detik")
                {
                    hasil = angka * 60;
                }
                else if (value2 == "menit")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "jam")
                {
                    hasil = angka / 60;
                }
                else if (value2 == "hari")
                {
                    hasil = angka / 1440;
                }
                else if (value2 == "minggu")
                {
                    hasil = angka / 10080;
                }
            }
            if (value1 == "jam")
            {
                if (value2 == "detik")
                {
                    hasil = angka / 60;
                }
                else if (value2 == "menit")
                {
                    hasil = angka * 60;
                }
                else if (value2 == "jam")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "hari")
                {
                    hasil = angka / 24;
                }
                else if (value2 == "minggu")
                {
                    hasil = angka / 169;
                }
            }
            if (value1 == "hari")
            {
                if (value2 == "detik")
                {
                    hasil = angka * 86400;
                }
                else if (value2 == "menit")
                {
                    hasil = angka * 1440;
                }
                else if (value2 == "jam")
                {
                    hasil = angka * 24;
                }
                else if (value2 == "hari")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "minggu")
                {
                    hasil = angka / 7;
                }
            }
            if (value1 == "minggu")
            {
                if (value2 == "detik")
                {
                    hasil = angka * 604800;
                }
                else if (value2 == "menit")
                {
                    hasil = angka * 10080;
                }
                else if (value2 == "jam")
                {
                    hasil = angka * 168;
                }
                else if (value2 == "hari")
                {
                    hasil = angka * 7;
                }
                else if (value2 == "minggu")
                {
                    hasil = angka * 1;
                }
            }
            bunifuTextBox2.Text = ("  " + hasil);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}                                                                                      