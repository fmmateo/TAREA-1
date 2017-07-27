using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{

    public partial class Form1 : Form
    {
        public String p = "20152723";
    

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text += "4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text +=  "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text += "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == p)
            {
                this.Hide();
                Menu frmMain = new Menu();
                frmMain.Show();
            }
            else 
            {
                MessageBox.Show("Pin Incorrecto", "Cajero Automatico", MessageBoxButtons.OKCancel);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length >= 0)
            {
                string val = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                textBox2.Text = val;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
