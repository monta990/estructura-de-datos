using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace esdat
{
    public partial class FrmInversa : Form
    {
        public FrmInversa()
        {
            InitializeComponent();
            Generar();
        }
        private Random R = new Random();
        private DataGridView Data;
        private Regex validar = new Regex(@"^[0-9]+$");
        /// <summary>
        /// Limpiar datagridview
        /// </summary>
        private void Clear()
        {
            foreach (DataGridView Data in this.Controls.OfType<DataGridView>())
            {
                Data.Columns.Clear();
                Data.Rows.Clear();
            }
        }
        /// <summary>
        /// Agrega columnas
        /// </summary>
        private void AddColumns()
        {
            foreach (DataGridView Data in this.Controls.OfType<DataGridView>())
            {
                for (int c = 0; c < 3; c++)
                {
                    Data.Columns.Add("C" + (c + 1), "C" + (c + 1));
                }
            }
        }
        /// <summary>
        /// Agrega renglones
        /// </summary>
        private void AddRows()
        {
            foreach (DataGridView Data in this.Controls.OfType<DataGridView>())
            {
                for (int r = 0; r < 3; r++)
                {
                    Data.Rows.Add();
                    Data.Rows[r].HeaderCell.Value= "R " + (r+1);
                }
            }
        }
        /// <summary>
        /// Cargar columns 
        /// </summary>
        private void Generar()
        {
            Clear();
            AddColumns();
            for (int r = 0; r < 3; r++)
            {
                dGVmatrizA.Rows.Add();
                for (int c = 0; c < 3; c++)
                {
                    dGVmatrizA[c, r].Value = R.Next(0, 10).ToString();
                }
                dGVmatrizAdjunta.Rows.Add();
                dGVnatrizInveraAT.Rows.Add();
                dGVmatrizResultado.Rows.Add();
                dGVverificacion.Rows.Add();
            }
        }
        /// <summary>
        /// Cargar ejemplo
        /// </summary>
        private void Ejemplo()
        {
            Clear();
            AddColumns();
            AddRows();
            dGVmatrizA[0, 0].Value = "3";
            dGVmatrizA[1, 0].Value = "2";
            dGVmatrizA[2, 0].Value = "1";
            dGVmatrizA[0, 1].Value = "0";
            dGVmatrizA[1, 1].Value = "2";
            dGVmatrizA[2, 1].Value = "-5";
            dGVmatrizA[0, 2].Value = "-2";
            dGVmatrizA[1, 2].Value = "1";
            dGVmatrizA[2, 2].Value = "4";
        }
        private void lblMatrizInveraAT_Click(object sender, EventArgs e)
        {

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Generar();
        }

        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            Ejemplo();
        }

        private void dGVmatrizA_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (validar.IsMatch(dGVmatrizA.CurrentCell.Value.ToString()))
            {
                //valido
            }
            else
            {
                MessageBox.Show("Solo numeros por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
