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
    public partial class proceso : Form
    {
        public proceso()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            gracias frrmMain = new gracias();
            frrmMain.Show();

            MessageBox.Show("Espere un Momento", "Cajero Automatico", MessageBoxButtons.OKCancel);
        
    }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            gracias frrmMain = new gracias();
            frrmMain.Show();

            MessageBox.Show("Espere un Momento", "Cajero Automatico", MessageBoxButtons.OKCancel);
        }
    }
}
