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
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            bunifuImageButton3.Click += new
                EventHandler(bunifuImageButton3_Click);
            Form3 fm3 = new Form3();
            fm3.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bunifuImageButton1.Click += new
               EventHandler(bunifuImageButton1_Click);
            Form4 fm4 = new Form4();
            fm4.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            bunifuImageButton2.Click += new
               EventHandler(bunifuImageButton2_Click);
            Form5 fm5 = new Form5();
            fm5.Show();
            this.Hide();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            bunifuImageButton5.Click += new
               EventHandler(bunifuImageButton5_Click);
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Hide();
        }

        private void form2_Load(object sender, EventArgs e)
        {

        }
    }
}
