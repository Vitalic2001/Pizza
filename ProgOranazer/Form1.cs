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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Timerpg Timerpg = new Timerpg();
            Timerpg.Show();
        }

        private void zametki_Click(object sender, EventArgs e)
        {
            this.Hide();
            zametki22 zametki22 = new zametki22();
            zametki22.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kalendar Kalendar = new Kalendar();
            Kalendar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Konvert Konvert = new Konvert();
            Konvert.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
