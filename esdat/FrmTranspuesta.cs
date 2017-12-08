using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace esdat
{
    public partial class FrmTranspuesta : Form
    {
        private int columnas, renglones;
        private Random R = new Random();
        public FrmTranspuesta(int columnas, int renglones)
        {
            InitializeComponent();
            this.columnas = columnas;
            this.renglones = renglones;
        }
        /// <summary>
        /// Generar matriz A con datos
        /// </summary>
        private void Generar()
        {
            #region Generar Matriz A
            dGVmatrizA.Columns.Clear();
            dGVmatrizA.Rows.Clear();
            try
            {
                for (int c = 0; c < columnas; c++)
                {
                    dGVmatrizA.Columns.Add("C" + (c + 1), "C" + (c + 1));
                }
                for (int r = 0; r < renglones; r++)
                {
                    dGVmatrizA.Rows.Add();
                    for (int c = 0; c < columnas; c++)
                    {
                        dGVmatrizA[c, r].Value = R.Next(0, 10).ToString();
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Alguna celda vacia");
            }
            #endregion
            #region Generar Matriz AT
            dGVmatrizAT.Columns.Clear();
            dGVmatrizAT.Rows.Clear();
            try
            {
                for (int c = 0; c < renglones; c++)
                {
                    dGVmatrizAT.Columns.Add("C" + (c + 1), "C" + (c + 1));
                }
                for (int r = 0; r < columnas; r++)
                {
                    dGVmatrizAT.Rows.Add();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Alguna celda vacia");
            }
            #endregion
        }
        /// <summary>
        /// Genera matriz transpuesta
        /// </summary>
        private void Transpuesta()
        {
                for (int c = 0; c < renglones; c++)
                {
                    for (int r = 0; r < columnas; r++)
                    {
                        if ((String)dGVmatrizA.Rows[c].Cells[r].Value == null)
                        {
                            MessageBox.Show("Una celda esta vacia","Celda vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                dGVmatrizAT[c, r].Value = dGVmatrizA[r, c].Value.ToString();
                            }
                            catch (NullReferenceException)
                            {
                            MessageBox.Show("Porfin llego al try correcto");
                            }
             
                        }
                        
                    }
                }
        }
        private void btnRandom_Click(object sender, EventArgs e) => Generar();
        private void btnTranspuesta_Click(object sender, EventArgs e) => Transpuesta();
        private void dGVmatrizA_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (int.TryParse(dGVmatrizA.CurrentCell.Value.ToString(), out int r))
                {
                    //valido
                }
                else
                {
                    MessageBox.Show("Solo numeros por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Dejaste la celda vacia", "Celda vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e) => this.Close();

        private void dGVmatrizA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmTranspuesta_Load(object sender, EventArgs e) => Generar();
    }
}