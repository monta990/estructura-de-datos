using System;
using System.Windows.Forms;
namespace esdat
{
    public partial class FrmMemoramaSelector : Form
    {
        private int dificultad;
        private string nombre;
        public FrmMemoramaSelector() => InitializeComponent();
        private void btNino_Click(object sender, EventArgs e)
        {
            if (tBnombre.Text.Trim()=="")
            {
                MessageBox.Show("Ingresa tu nombre","Falta tu nombre",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                new MemoramaNino(dificultad, nombre).ShowDialog();
            }
        }
        private void sToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();
        private void tBnombre_Leave(object sender, EventArgs e) => nombre = tBnombre.Text;
        private void rBprincipiante_CheckedChanged(object sender, EventArgs e) => dificultad = 1000;
        private void rBintermedio_CheckedChanged(object sender, EventArgs e) => dificultad = 500;
        private void radioButton3_CheckedChanged(object sender, EventArgs e) => dificultad = 250;
        private void SelectorMemorama_Load(object sender, EventArgs e) => rBprincipiante.Checked = true;
        private void btNina_Click(object sender, EventArgs e)
        {
            if (tBnombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa tu nombre", "Falta tu nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new MemoramaNina(dificultad, nombre).ShowDialog();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e) => this.Close();
    }
}