using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace esdat
{
    public partial class FrmSumaMatrices : Form
    {
        private int columnas, renglones;
        private Random R = new Random();
        private Regex validar = new Regex(@"^[0-9]+$");
        /// <summary>
        /// Suma de matrices
        /// </summary>
        /// <param name="columnas">A generar</param>
        /// <param name="renglones">A generar</param>
        public FrmSumaMatrices(int columnas, int renglones)
        {
            InitializeComponent();
            this.columnas = columnas;
            this.renglones = renglones;
        }
        /// <summary>
        /// Genera matriz como la imagen de ejemplo
        /// </summary>
        private void Ejemplo()
        {
            dGVmatriz1.Rows.Clear();
            dGVmatriz1.Columns.Clear();
            dGVmatriz2.Rows.Clear();
            dGVmatriz2.Columns.Clear();
            dGVresultado.Rows.Clear();
            dGVresultado.Columns.Clear();
            for (int c = 0; c < 3; c++)
            {
                dGVmatriz1.Columns.Add("C" + (c + 1), "C" + (c + 1));
                dGVmatriz2.Columns.Add("C" + (c + 1), "C" + (c + 1));
                dGVresultado.Columns.Add("C" + (c + 1), "C" + (c + 1));
            }
            dGVmatriz1.Rows.Add(2, 0, 1);
            dGVmatriz1.Rows.Add(3, 0, 0);
            dGVmatriz1.Rows.Add(5, 1, 1);
            dGVmatriz2.Rows.Add(1, 0, 1);
            dGVmatriz2.Rows.Add(1, 2, 1);
            dGVmatriz2.Rows.Add(1, 1, 0);
            for (int r = 0; r < 3; r++)
            {
                dGVresultado.Rows.Add();
            }
        }
        /// <summary>
        /// Generar matrices y cargar con random
        /// </summary>
        private void Generar()
        {
            dGVmatriz1.Rows.Clear();
            dGVmatriz1.Columns.Clear();
            dGVmatriz2.Rows.Clear();
            dGVmatriz2.Columns.Clear();
            dGVresultado.Rows.Clear();
            dGVresultado.Columns.Clear();
            for (int c = 0; c < columnas; c++)
            {
                dGVmatriz1.Columns.Add("C" + (c + 1), "C" + (c + 1));
                dGVmatriz2.Columns.Add("C" + (c + 1), "C" + (c + 1));
                dGVresultado.Columns.Add("C" + (c + 1), "C" + (c + 1));
            }
            for (int r = 0; r < renglones; r++)
            {
                dGVmatriz1.Rows.Add();
                for (int c = 0; c < renglones; c++)
                {
                    dGVmatriz1.Rows[r].Cells[c].Value = R.Next(0, 10).ToString();
                }
                dGVmatriz2.Rows.Add();
                for (int c = 0; c < renglones; c++)
                {
                    dGVmatriz2.Rows[r].Cells[c].Value = R.Next(0, 10).ToString();
                }
                dGVresultado.Rows.Add();
            }
        }
        /// <summary>
        /// Resolver suma de matrices
        /// </summary>
        private void Igual()
        {
            try
            {
                for (int c = 0; c < columnas; c++)
                {
                    for (int r = 0; r < renglones; r++)
                    {
                        dGVresultado[c, r].Value = int.Parse(dGVmatriz1[c, r].Value.ToString()) + int.Parse(dGVmatriz2[c, r].Value.ToString());
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Algun dato incorrecto en las tablas","Solo numeros",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnIgual_Click(object sender, EventArgs e) => Igual();
        private void btnRandom_Click(object sender, EventArgs e) => Generar();
        private void button1_Click(object sender, EventArgs e) => this.Close();
        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            Ejemplo();
        }
        private void dGVmatriz1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (validar.IsMatch(dGVmatriz1.CurrentCell.Value.ToString()))
            {
            }
            else
            {
                MessageBox.Show("Solo numeros por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dGVmatriz2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (validar.IsMatch(dGVmatriz2.CurrentCell.Value.ToString()))
            {
            }
            else
            {
                MessageBox.Show("Solo numeros por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                int colum = dGVmatriz2.CurrentCell.ColumnIndex;
                int row = dGVmatriz2.CurrentCell.RowIndex;
                dGVmatriz2.CurrentCell = dGVmatriz2.Rows[row].Cells[colum];
            }
        }
        private void FrmSumaMatrices_Load(object sender, EventArgs e)
        {
            dGVmatriz1.MultiSelect = false;
            dGVmatriz2.MultiSelect = false;
            Generar();
        }
    }
}
