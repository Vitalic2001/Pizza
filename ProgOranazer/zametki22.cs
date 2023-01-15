using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProgOranazer
{
    public partial class zametki22 : Form
    {
        public zametki22()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream file1 = new FileStream((Nem.Text)+".txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);
            writer.Write(richTextBox1.Text);
            writer.Close();
            MessageBox.Show("Заметка создана в папке с программой:" + (Nem.Text) + ".txt");
        }

        private void Name_TextChanged(object sender, EventArgs e)
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
