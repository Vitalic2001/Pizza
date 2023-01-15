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
    public partial class Kalendar : Form
    {
        public Kalendar()
        {
            InitializeComponent();
        }
        DateTime date1;
        DateTime date2;
        int days;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date1 = (dateTimePicker1.Value);
            DateTime date2 = (dateTimePicker2.Value);
            int days = (date2 - date1).Days+1;
            if (days<0)
            {
                days = days * -1;
            }
            label4.Text = days.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }
    }
}
