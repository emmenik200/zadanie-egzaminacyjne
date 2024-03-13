using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_egzaminacyjne
{
    public partial class poczta : Form
    {
        public poczta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                pictureBox1.Image = Properties.Resources.pocztowka;
                label1.Text = "cena 1zł";

            }
            else if (radioButton2.Checked)
            {
                pictureBox1.Image = Properties.Resources.list;
                label1.Text = "cena 1,5zł";
            }
            else if (radioButton3.Checked)
            {
                pictureBox1.Image = Properties.Resources.paczka;
                label1.Text = "cena 10zł";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int test;
            bool ok = int.TryParse(textBox2.Text, out test);

            if(textBox2.Text.Length != 5)
            {
                MessageBox.Show("nieprawidłowy kod pocztowy");
            }
            else if (!ok)
            {
                MessageBox.Show("kod pocztowy powieniem mieć same cyfry");
            }
            else
            {
                MessageBox.Show("Dane prawidłowe");
            }







        }
    }
}
