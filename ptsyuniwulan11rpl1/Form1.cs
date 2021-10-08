using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptsyuniwulan11rpl1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val1, val2, result;
            val1 = int.Parse(this.textBox1.Text);
            val2 = int.Parse(this.textBox2.Text);
            result = val1 + val2;
            this.textBox3.Text = result.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int val1, val2, result;
            val1 = int.Parse(this.textBox1.Text);
            val2 = int.Parse(this.textBox2.Text);
            result = val1 - val2;
            this.textBox3.Text = result.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int val1, val2, result;
            val1 = int.Parse(this.textBox1.Text);
            val2 = int.Parse(this.textBox2.Text);
            result = val1 * val2;
            this.textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int val1;
            double val2, result;
            val1 = int.Parse(this.textBox1.Text);
            val2 = int.Parse(this.textBox2.Text);
            result = val1 / val2;
            this.textBox3.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to exit ?", "Exit Application", MessageBoxButtons.YesNo);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
