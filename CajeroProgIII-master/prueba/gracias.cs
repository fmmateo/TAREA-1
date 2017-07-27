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
    public partial class gracias : Form
    {
        public gracias()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frrmMain = new Form1();
            frrmMain.Show();

          
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frrmMain = new Form1();
            frrmMain.Show();

          
        }
    }
}
