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
            #endregion
            #region Generar Matriz AT
            dGVmatrizAT.Columns.Clear();
            dGVmatrizAT.Rows.Clear();
            for (int c = 0; c < renglones; c++)
            {
                dGVmatrizAT.Columns.Add("C" + (c + 1), "C" + (c + 1));
            }
            for (int r = 0; r < columnas; r++)
            {
                dGVmatrizAT.Rows.Add();
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
                    dGVmatrizAT[c,r].Value = dGVmatrizA[r, c].Value.ToString();
                }
            }
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            Generar();
        }

        private void btnTranspuesta_Click(object sender, EventArgs e)
        {
            Transpuesta();
        }

        private void FrmTranspuesta_Load(object sender, EventArgs e)
        {
            Generar();
        }
    }
}
