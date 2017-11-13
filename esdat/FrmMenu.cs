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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
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
            
        }

        private void mCDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMaximoComunDivisor().ShowDialog();
        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBusquedaBinaria().ShowDialog();
        }

        private void fractalDeHilbertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmHilbert().ShowDialog();
        }

        private void pruebaDeFibonnachiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPruebaFibonacci().ShowDialog();
        }

        private void memoramaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmMemoramaSelector().ShowDialog();
        }

        private void matrizToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void metodosDeOrdenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmOrdenamientoBusqueda();
        }

        private void cuadradoMagicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCuadradoMagico().ShowDialog();
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmGenMatriz().ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void imagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTreeImagen().ShowDialog();
        }

        private void conDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTreeDatos().ShowDialog();
        }

        private void recorridoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTreeRecorrido().ShowDialog();
        }

        private void operacionPosfijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPosfijas().ShowDialog();
        }

        private void pilaGenericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmStackGen().ShowDialog();
        }
    }
}
