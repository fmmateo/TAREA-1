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
    public partial class Pin : Form
    {
  

        public Pin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPassActual.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPassActual.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPassActual.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtPassActual.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtPassActual.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtPassActual.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtPassActual.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtPassActual.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtPassActual.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtPassActual.Text += "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();

            if (txtPassActual.Text == "20152723")
            { 
                this.Hide();
                newPin fpMain = new newPin();
                fpMain.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Pin Incorrecto", "Cajero Automatico", MessageBoxButtons.OKCancel);
            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 flMain = new Form1();
            flMain.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtPassActual.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string content;

            content = txtPassActual.Text;
            content = content.Remove(content.Length - 1);

            txtPassActual.Text = content;

        }
    }
}
