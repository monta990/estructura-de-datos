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
    public partial class FrmInversa : Form
    {
        public FrmInversa()
        {
            InitializeComponent();
            Generar();
        }
        private Random R = new Random();
        /// <summary>
        /// Cargar columns 
        /// </summary>
        private void Generar()
        {
            dGVmatrizA.Columns.Clear();
            dGVmatrizA.Rows.Clear();
            dGVmatrizAdjunta.Columns.Clear();
            dGVmatrizAdjunta.Rows.Clear();
            dGVnatrizInveraAT.Columns.Clear();
            dGVnatrizInveraAT.Rows.Clear();
            dGVmatrizResultado.Columns.Clear();
            dGVmatrizResultado.Rows.Clear();
            dGVverificacion.Columns.Clear();
            dGVverificacion.Rows.Clear();
            for (int c = 0; c < 3; c++)
            {
                dGVmatrizA.Columns.Add("C" + (c + 1), "C" + (c + 1));
                dGVmatrizAdjunta.Columns.Add("C" + (c + 1), "C" + (c + 1));
                dGVnatrizInveraAT.Columns.Add("C" + (c + 1), "C" + (c + 1));
                dGVmatrizResultado.Columns.Add("C" + (c + 1), "C" + (c + 1));
                dGVverificacion.Columns.Add("C" + (c + 1), "C" + (c + 1));
            }
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
            dGVmatrizA.Columns.Clear();
            dGVmatrizA.Rows.Clear();
            dGVmatrizAdjunta.Columns.Clear();
            dGVmatrizAdjunta.Rows.Clear();
            dGVnatrizInveraAT.Columns.Clear();
            dGVnatrizInveraAT.Rows.Clear();
            dGVmatrizResultado.Columns.Clear();
            dGVmatrizResultado.Rows.Clear();
            dGVverificacion.Columns.Clear();
            dGVverificacion.Rows.Clear();
            for (int c = 0; c < 3; c++)
            {
                dGVmatrizA.Columns.Add("C" + (c + 1), "C" + (c + 1));
                dGVmatrizAdjunta.Columns.Add("C" + (c + 1), "C" + (c + 1));
                dGVnatrizInveraAT.Columns.Add("C" + (c + 1), "C" + (c + 1));
                dGVmatrizResultado.Columns.Add("C" + (c + 1), "C" + (c + 1));
                dGVverificacion.Columns.Add("C" + (c + 1), "C" + (c + 1));
            }
            
            for (int r = 0; r < 3; r++)
            {
                dGVmatrizA.Rows.Add();
                dGVmatrizAdjunta.Rows.Add();
                dGVnatrizInveraAT.Rows.Add();
                dGVmatrizResultado.Rows.Add();
                dGVverificacion.Rows.Add();
            }
            dGVmatrizA[0, 0].Value = "3".ToString();
            dGVmatrizA[1, 0].Value = "2".ToString();
            dGVmatrizA[2, 0].Value = "1".ToString();
            dGVmatrizA[0, 1].Value = "0".ToString();
            dGVmatrizA[1, 1].Value = "2".ToString();
            dGVmatrizA[2, 1].Value = "-5".ToString();
            dGVmatrizA[0, 2].Value = "-2".ToString();
            dGVmatrizA[1, 2].Value = "1".ToString();
            dGVmatrizA[2, 2].Value = "4".ToString();
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
    }
}
