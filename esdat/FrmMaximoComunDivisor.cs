using System;
using System.Windows.Forms;
namespace esdat
{
    public partial class FrmMaximoComunDivisor : Form
    {
        public FrmMaximoComunDivisor() => InitializeComponent();
        private void Limpiar()
        {
            lbMCDresultado.Text = "0";
            tBentero1.Clear();
            tBentero2.Clear();
            tBentero1.Focus();
        }
        private int MCDmetodo(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                a = a < 0 ? a * -1 : a;
                b = b < 0 ? b * -1 : b;
                return MCDmetodo (a,b);
            }
            else if (b > a)
            {
                return MCDmetodo(b, a);
            }
            else if (b == 0)
            {
                return a;
            }
            else return MCDmetodo(a-b,b);
        }
        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tBentero1.Text, out int ent1)&& int.TryParse(tBentero2.Text, out int ent2))
            {
                lbMCDresultado.Text = MCDmetodo(int.Parse(tBentero1.Text), int.Parse(tBentero2.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Solo numeros entero para elemento 1 y 2", "Solo enteros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btLimpiar_Click(object sender, EventArgs e) => Limpiar();
        private void btSalir_Click(object sender, EventArgs e) => this.Close();
    }
}