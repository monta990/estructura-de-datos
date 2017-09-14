using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esdat
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void practicaUnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TipoDatos().ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void fibonnachiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Fibonacci().ShowDialog();
        }

        private void memoramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SelectorMemorama().ShowDialog();
        }
    }
}
