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
    public partial class FrmOrdenamientoBusqueda : Form
    {

        int[] arOriginal = new int[50000];
        int[] arBurbuja = new int[50000];
        int[] arInsert = new int[50000];
        int[] arShell = new int[50000];
        int[] arQuickSort = new int[50000];
        /// <summary>
        /// Generar los numeros para el datagridview original
        /// </summary>
        private void Generar()
        {
            dGVoriginal.Rows.Clear(); //limpiar datagridview
            Random R = new Random(); //declarando random
            int L = int.Parse(tBlimiteinferior.Text); //textbox de limite inferior
            int S = int.Parse(tBlimitesuperior.Text); //textbox de limite superior
            lblStartOriginal.Text = "Empezo: " + DateTime.Now.ToLongTimeString();
            lblStartOriginal.Update();
            for (int i = 0; i < 50000; i++) //cantidad de numeros a generar
            {
                arOriginal[i] = R.Next(L, S); //guardando numeros random en el arreglo orifinal
            }
            ImprimirArreglo(dGVoriginal, arOriginal); //impresion del arreglo original en el dGVoriginal
            lblEndOriginal.Text = "Finalizo: "+ DateTime.Now.ToLongTimeString();
            arBurbuja = arOriginal; //igualando
            arInsert = arBurbuja; //igualando
            arShell = arBurbuja; //igualando
            arQuickSort = arBurbuja; //igualando
        }
        /// <summary>
        /// Limpia todo los campos en el form
        /// </summary>
        private void Limpiar()
        {
            dGVoriginal.Rows.Clear();
            tBlimiteinferior.Clear();
            tBlimitesuperior.Clear();
            tBlimiteinferior.Focus();
        }
        /// <summary>
        /// Impresión a datagridview del arrreglo suministrado en el datagridview suministrado
        /// </summary>
        /// <param name="view">datagrid a imprimir</param>
        /// <param name="arreglo">arreglo a imprimir</param>
        private void ImprimirArreglo(DataGridView view, int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                view.Rows.Add(arreglo[i].ToString());
                view.Rows[i].HeaderCell.Value = i.ToString();
            }
            view.Update(); //actualizar modo grafico
        }
        /// <summary>
        /// Organiza los datos con metodo burbuja
        /// </summary>
        private void Burbuja()
        {
            lblStartBurbuja.Text = "Empezo: " + DateTime.Now.ToLongTimeString();
            lblStartBurbuja.Update();
            int temp = 0;
            double cont = 0;
            for (int i = 0; i < arBurbuja.Length; i++) //primer numero
            {
                for (int j = 0; j < arBurbuja.Length; j++) //segundo numero
                {
                    cont++;
                    if (arBurbuja[i]< arBurbuja[j]) //verificación de los numero
                    {
                        temp = arBurbuja[i]; //se guradar el primero
                        arBurbuja[i] = arBurbuja[j]; //se realiza el cambio
                        arBurbuja[j] = temp; //y se guarda el segundo numero
                    }
                }
            }
            ImprimirArreglo(dGVburbuja, arBurbuja);
            lblEndBurbuja.Text = "Finalizo: " + DateTime.Now.ToLongTimeString();
            lblEndBurbuja.Update();
            lblIeracionBurbuja.Text = cont.ToString();
        }
        /// <summary>
        /// Organiza los datos con metodo Insert
        /// </summary>
        private void Insert()
        {
            lblStartInsert.Text = "Empezo: " + DateTime.Now.ToLongTimeString();
            lblStartInsert.Update();
            ImprimirArreglo(dGVinsert, arInsert);
            lblEndInsert.Text = "Finalizo: " + DateTime.Now.ToLongTimeString();
            lblEndInsert.Update();
        }
        /// <summary>
        /// Organiza los datos con metodo Shell
        /// </summary>
        private void Shell()
        {
            lblStartShell.Text = "Empezo: " + DateTime.Now.ToLongTimeString();
            lblStartShell.Update();
            ImprimirArreglo(dGVshell, arShell);
            lblEndShell.Text = "Finalizo: " + DateTime.Now.ToLongTimeString();
            lblEndShell.Update();
        }
        /// <summary>
        /// Organiza los datos con metodo QuickSort
        /// </summary>
        private void QuickSort()
        {
            lblStartQuickSort.Text = "Empezo: " + DateTime.Now.ToLongTimeString();
            lblStartShell.Update();
            ImprimirArreglo(dGVqucksort, arQuickSort);
            lblEndQuickSort.Text = "Finalizo: " + DateTime.Now.ToLongTimeString();
            lblEndQuickSort.Update();
        }
        public FrmOrdenamientoBusqueda()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Generar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Burbuja();
            //Insert();
            //Shell();
            //QuickSort();
        }
    }
}