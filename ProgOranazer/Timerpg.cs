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
    public partial class Timerpg : Form
    {
        public Timerpg()
        {
            InitializeComponent();
        }
        int h, m, s;
        bool l = true;

        private void Start_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="")
            {
                (textBox1.Text) = "0";
            }
            if (textBox2.Text =="")
            {
                (textBox1.Text) = "0";
            }
            if (textBox3.Text =="")
            {
                (textBox1.Text) = "0";
            }
            if (l == true)
            {
                if (textBox1.Text != "")
                {
                    h = Convert.ToInt32(textBox1.Text);
                }
                if (textBox2.Text != "")
                {
                    m = Convert.ToInt32(textBox2.Text);
                }
                if (textBox3.Text != "")
                {
                    s = Convert.ToInt32(textBox3.Text);
                }
            }
            else
            {
                l = true;
            }
            timer1.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            l = false;
        }

        private void sbros_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label11.Text = "0";
            label12.Text = "0";
            label13.Text = "0";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) |
                e.KeyChar == '\b' ) return;
            else
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) |
                e.KeyChar == '\b' ) return;
            else
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) |
                e.KeyChar == '\b' ) return;
            else
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void Timerpg_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            while (s > 59)
            {
                m = m + 1;
                s = s - 60;
            }
            while (m > 59)
            {
                h = h + 1;
                m = m - 60;
            }
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }
            label11.Text = Convert.ToString(h);
            label12.Text = Convert.ToString(m);
            label13.Text = Convert.ToString(s);
            if (m == -1)
            {
                h = h - 1;
                m = 59;
            }
            if (h == 0 && m == 0 && s == 0)
            {
                timer1.Stop();
                MessageBox.Show("Время вышло!");
            }
        }
    }
}
