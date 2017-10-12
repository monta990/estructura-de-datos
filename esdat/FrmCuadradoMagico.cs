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
    public partial class FrmCuadradoMagico : Form
    {
        public FrmCuadradoMagico()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Prepara el cuadrado magico, con renglones, columnas y tamaño
        /// </summary>
        private void CuadroMagico() //configuración inicial de cuadro magico
        {
            dGVcuadradoMagico.Width = 203; //ancho de datagridview
            dGVcuadradoMagico.Height = 91; //alto de datagridview
            for (int i = 0; i <= 3; i++) //numero de columnas
            {
                dGVcuadradoMagico.Columns[i].Width = 50; //tamaño de columna
                dGVcuadradoMagico.Rows.Add(); //agregar renglon
            }
        }
        /// <summary>
        /// Carga ejemplo de botón1 (0)
        /// </summary>
        private void Ejemplo1() //desde boton ejemplo 1
        {
            dGVcuadradoMagico.Rows.Clear();
            dGVcuadradoMagico.Rows.Add("0", "0", "0", "0");
            dGVcuadradoMagico.Rows.Add("0", "0", "0", "0");
            dGVcuadradoMagico.Rows.Add("0", "0", "0", "0");
            dGVcuadradoMagico.Rows.Add("0", "0", "0", "0");
        }
        /// <summary>
        /// Carga ejemplo del botón 2
        /// </summary>
        private void Ejemplo2() //desde boton ejemplo 2
        {
            dGVcuadradoMagico.Rows.Clear();
            dGVcuadradoMagico.Rows.Add("16", "3", "2", "13");
            dGVcuadradoMagico.Rows.Add("5", "10", "11", "8");
            dGVcuadradoMagico.Rows.Add("9", "6", "7", "12");
            dGVcuadradoMagico.Rows.Add("4", "15", "14", "1");
        }
        /// <summary>
        /// Limpia el cuadrado magico y sus resultados
        /// </summary>
        private void Limpiar() //limpia cuadromagico
        {
            dGVcuadradoMagico.Rows.Clear();
            dGVcuadradoMagico.Rows.Add();
            dGVcuadradoMagico.Rows.Add();
            dGVcuadradoMagico.Rows.Add();
            dGVcuadradoMagico.Rows.Add();
            lbColumna1.Text = "0";
            lbColumna2.Text = "0";
            lbColumna3.Text = "0";
            lbColumna4.Text = "0";
            lbRenglon1.Text = "0";
            lbRenglon2.Text = "0";
            lbRenglon3.Text = "0";
            lbRenglon4.Text = "0";
            lbDiagonal1.Text = "0";
            lbDiagonal2.Text = "0";
        }
        /// <summary>
        /// Valida el datagridview antes calcular
        /// </summary>
        private void Validar() //calcular diagoanles
        {
            for (int ren = 0, cel = 0; ren < 4; ren++)
            {
                if ((String)dGVcuadradoMagico.Rows[ren].Cells[cel].Value == null)
                {
                    MessageBox.Show("Alguna celda esta vacia", "Celda Vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else
                {
                    Calcular();
                    break;
                }
            }
            
        }
        /// <summary>
        /// Calculo de diagonales, renglones y columnas del cuadrado magico, no recibe parametros
        /// </summary>
        private void Calcular()
        {
            int[] suma = new int[10];
            for (int i = 0, r = 3; i < 4; i++, r--) //todo en uno de una vez
            {
                lbDiagonal1.Text = (suma[0] += int.Parse(dGVcuadradoMagico[i, i].Value.ToString())).ToString();
                lbDiagonal2.Text = (suma[1] += int.Parse(dGVcuadradoMagico[i, r].Value.ToString())).ToString();
                lbRenglon1.Text = (suma[2] += int.Parse(dGVcuadradoMagico[i, 0].Value.ToString())).ToString();
                lbRenglon2.Text = (suma[3] += int.Parse(dGVcuadradoMagico[i, 1].Value.ToString())).ToString();
                lbRenglon3.Text = (suma[4] += int.Parse(dGVcuadradoMagico[i, 2].Value.ToString())).ToString();
                lbRenglon4.Text = (suma[5] += int.Parse(dGVcuadradoMagico[i, 3].Value.ToString())).ToString();
                lbColumna1.Text = (suma[6] += int.Parse(dGVcuadradoMagico[0, r].Value.ToString())).ToString();
                lbColumna2.Text = (suma[7] += int.Parse(dGVcuadradoMagico[1, r].Value.ToString())).ToString();
                lbColumna3.Text = (suma[8] += int.Parse(dGVcuadradoMagico[2, r].Value.ToString())).ToString();
                lbColumna4.Text = (suma[9] += int.Parse(dGVcuadradoMagico[3, r].Value.ToString())).ToString();
            }
            if (suma[9] == suma[8] && suma[8] == suma[7] && suma[7] == suma[6] && suma[6] == suma[5] && suma[5] == suma[4] && suma[4] == suma[3] && suma[3] == suma[2] && suma[2] == suma[1])
            {
                MessageBox.Show("Si es cuadrado magico", "Hay magia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No es cuadrado magico", "Sin magia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmCuadradoMagico_Load(object sender, EventArgs e)
        {
            CuadroMagico();
        }
        private void btEjemplo1_Click(object sender, EventArgs e)
        {
            Limpiar();
            Ejemplo1();
        }
        private void btEjemplo2_Click(object sender, EventArgs e)
        {
            Limpiar();
            Ejemplo2();
        }
        private void btLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btCalcular_Click(object sender, EventArgs e)
        {
            Validar();

        }
        private void dGVcuadradoMagico_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}