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
    public partial class retiro : Form
    {
        public retiro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            proceso f2f = new proceso();
            f2f.Show();

 
        

    }

    private void button5_Click(object sender, EventArgs e)
        {
            Otracantidad Otracantidad = new Otracantidad();
            Otracantidad.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            proceso f3f = new proceso();
            f3f.Show();

   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            proceso f4f = new proceso();
            f4f.Show();

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            proceso f5f = new proceso();
            f5f.Show();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            proceso f6f = new proceso();
            f6f.Show();

        
        }
    }
}
