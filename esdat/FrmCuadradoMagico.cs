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
        private void CuadroMagico() //configuración inicial de cuadro magico
        {
            dGVcuadradoMagico.Width = 123; //ancho de datagridview
            dGVcuadradoMagico.Height = 92; //alto de datagridview
            for (int i = 0; i <= 3; i++) //numero de columnas
            {
                dGVcuadradoMagico.Columns[i].Width = 30; //tamaño de columna
                dGVcuadradoMagico.Rows.Add(); //agregar renglon
            }
        }
        private void Ejemplo1() //desde boton ejemplo 1
        {
            dGVcuadradoMagico.Rows.Clear();
            dGVcuadradoMagico.Rows.Add("0", "0", "0", "0");
            dGVcuadradoMagico.Rows.Add("0", "0", "0", "0");
            dGVcuadradoMagico.Rows.Add("0", "0", "0", "0");
            dGVcuadradoMagico.Rows.Add("0", "0", "0", "0");
        }
        private void Ejemplo2() //desde boton ejemplo 2
        {
            dGVcuadradoMagico.Rows.Clear();
            dGVcuadradoMagico.Rows.Add("16", "3", "2", "13");
            dGVcuadradoMagico.Rows.Add("5", "10", "11", "8");
            dGVcuadradoMagico.Rows.Add("9", "6", "7", "12");
            dGVcuadradoMagico.Rows.Add("4", "15", "14", "1");
        }
        private void Limpiar() //limpia cuadromagico
        {
            dGVcuadradoMagico.Rows.Clear();
            dGVcuadradoMagico.Rows.Add();
            dGVcuadradoMagico.Rows.Add();
            dGVcuadradoMagico.Rows.Add();
            dGVcuadradoMagico.Rows.Add();
        }
        private void Calcular() //calculo del cuadro magico
        {

        }
        private void FrmCuadradoMagico_Load(object sender, EventArgs e)
        {
            CuadroMagico();
        }
        private void btEjemplo1_Click(object sender, EventArgs e)
        {
            Ejemplo1();
        }
        private void btEjemplo2_Click(object sender, EventArgs e)
        {
            Ejemplo2();
        }
        private void btLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btCalcular_Click(object sender, EventArgs e)
        {

        }
    }
}