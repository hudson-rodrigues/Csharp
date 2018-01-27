using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process_Image_Two
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passaAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Passa_alta f = new Passa_alta();
                this.Hide();
                f.ShowDialog();
            }
            finally
            {
                Menu m = new Menu();
                this.Hide();
                m.ShowDialog();
            }
        }

        private void histogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Histograma hi = new Histograma();
                this.Hide();
                hi.ShowDialog();
            }
            finally
            {
                Menu m = new Menu();
                this.Hide();
                m.ShowDialog();
            }

        }
    }
}
