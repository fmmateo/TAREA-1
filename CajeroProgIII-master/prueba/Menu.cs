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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            retiro retiro = new retiro();
            retiro.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pin pin = new Pin();
            pin.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Consulta Consulta = new Consulta();
            Consulta.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            newdeposito Consulta = new newdeposito();
            Consulta.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
