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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        bool dah = true;
        double a, b, c;
        string a1, b1, c1;
        int g = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            if (g == 0 )
            {
                if (textBox1.Text != "")
                {
                    label1.Text = "";
                    a = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = null;
                    c = Math.Sqrt(a);
                    textBox3.Text = c.ToString();
                    
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (g == 0 || g == 6)
            {
                if (textBox1.Text != "")
                {
                    if (dah == true)
                    {
                        a = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = null;
                        dah = false;
                        a1 = a.ToString();
                        label1.Text = a1;
                        g = 6;
                        label2.Text = " Введите значение степени";
                    }
                    else
                    {
                        b = Convert.ToDouble(textBox1.Text);
                        b1 = b.ToString();
                        c = Math.Pow(a, b);
                        c1 = c.ToString();
                        label1.Text = a1 + " в степени " + b1 + " = " + c1;
                        textBox3.Text = c.ToString();
                        a = 0;
                        b = 0;
                        textBox1.Text = null;
                        dah = true;
                        g = 0;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) |
                e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (g==0 || g==1)
            {
                if (textBox1.Text != "")
                {
                    if (dah == true)
                    {
                        a = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = null;
                        dah = false;
                        a1 = a.ToString();
                        label1.Text = a1;
                        g = 1;
                    }
                    else
                    {
                        b = Convert.ToDouble(textBox1.Text);
                        b1 = b.ToString();
                        c = a + b;
                        c1 = c.ToString();
                        label1.Text = a1 + " + " + b1 + " = " + c1;
                        textBox3.Text = c.ToString();
                        a = 0;
                        b = 0;
                        textBox1.Text = null;
                        dah = true;
                        g = 0;
                    }
                }
            } 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (g == 0 || g == 2)
            {
                if (textBox1.Text != "")
                {
                    if (dah == true)
                    {
                        a = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = null;
                        dah = false;
                        a1 = a.ToString();
                        label1.Text = a1;
                        g = 2;
                    }
                    else
                    {
                        b = Convert.ToDouble(textBox1.Text);
                        b1 = b.ToString();
                        c = a - b;
                        c1 = c.ToString();
                        label1.Text = a1 + " - " + b1 + " = " + c1;
                        textBox3.Text = c.ToString();
                        a = 0;
                        b = 0;
                        textBox1.Text = null;
                        dah = true;
                        g = 0;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (g == 0 || g == 3)
            {
                if (textBox1.Text != "")
                {
                    if (dah == true)
                    {
                        a = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = null;
                        dah = false;
                        a1 = a.ToString();
                        label1.Text = a1;
                        g = 3;
                    }
                    else
                    {
                        b = Convert.ToDouble(textBox1.Text);
                        b1 = b.ToString();
                        c = a * b;
                        c1 = c.ToString();
                        label1.Text = a1 + " X " + b1 + " = " + c1;
                        textBox3.Text = c.ToString();
                        a = 0;
                        b = 0;
                        textBox1.Text = null;
                        dah = true;
                        g = 0;
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (g == 0 || g == 4)
            {
                if (textBox1.Text != "")
                {
                    if (dah == true)
                    {
                        a = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = null;
                        dah = false;
                        a1 = a.ToString();
                        label1.Text = a1;
                        g = 4;
                    }
                    else
                    {
                        b = Convert.ToDouble(textBox1.Text);
                        b1 = b.ToString();
                        c = a / b;
                        c1 = c.ToString();
                        label1.Text = a1 + " / " + b1 + " = " + c1;
                        textBox3.Text = c.ToString();
                        a = 0;
                        b = 0;
                        textBox1.Text = null;
                        dah = true;
                        g = 0;
                    }
                }
            }
        }
    }
}
