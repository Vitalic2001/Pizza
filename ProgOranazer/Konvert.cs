using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgOranazer
{
    public partial class Konvert : Form
    {
        public Konvert()
        {
            InitializeComponent();
        }

        double rub, dol, ten, evr, uin;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                rub = 0;
            }
            else
            {
                rub = Convert.ToInt32(textBox1.Text);
                dol = rub / 76.1;
                ten = rub / 0.18;
                evr = rub / 89.5;
                uin = rub / 11.5;
                string result1 = dol.ToString("#.##");
                string result2 = ten.ToString("#.##");
                string result3 = evr.ToString("#.##");
                string result4 = uin.ToString("#.##");
                label6.Text = Convert.ToString(result1);
                label7.Text = Convert.ToString(result2);
                label8.Text = Convert.ToString(result3);
                label9.Text = Convert.ToString(result4);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) |
                e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
