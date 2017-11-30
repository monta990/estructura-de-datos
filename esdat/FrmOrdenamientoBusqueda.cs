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

        #region Declaraciones
        int[] arOriginal = new int[50000];
        int[] arBurbuja = new int[50000];
        int[] arInsert = new int[50000];
        int[] arShell = new int[50000];
        int[] arQuickSort = new int[50000];
        private int contquicksort = 0;
        #endregion
        /// <summary>
        /// Generar los numeros para el datagridview original
        /// </summary>
        private void Generar()
        {
            if (tBlimiteinferior.Text.Trim()== "" || tBlimitesuperior.Text.Trim() == "")
            {
                MessageBox.Show("Algun campo esta vacio","Error campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.TryParse(tBlimiteinferior.Text, out int res ) && int.TryParse(tBlimitesuperior.Text, out int res1))
                {
                    if (int.Parse(tBlimitesuperior.Text) < int.Parse(tBlimiteinferior.Text))
                    {
                        MessageBox.Show("Limite Superior es menor que limite inferior", "Checa tus limites", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tBlimitesuperior.Focus();
                        tBlimitesuperior.SelectAll();
                    }
                    else
                    {
                        tBlimiteinferior.Enabled = false;
                        tBlimitesuperior.Enabled = false;
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
                        lblEndOriginal.Text = "Finalizo: " + DateTime.Now.ToLongTimeString();
                        arBurbuja = arOriginal; //igualando
                        arInsert = arBurbuja; //igualando
                        arShell = arBurbuja; //igualando
                        arQuickSort = arBurbuja; //igualando
                    }
                }
                else
                {
                    MessageBox.Show("No son numeros enteros", "Solo enteros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Ordena los arreglos mediante calculo matematico
        /// </summary>
        private void Calcular()
        {
            if (tBlimiteinferior.Enabled == true && tBlimitesuperior.Enabled == true)
            {
                MessageBox.Show("No hay arreglo que ordenar", "No hay que ordenar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Burbuja();
                Insert();
                Shell();
                contquicksort = 0;
                lblStartQuickSort.Text = "Empezo: " + DateTime.Now.ToLongTimeString();
                lblStartQuickSort.Update();
                QuickSort(0, arQuickSort.Length - 1);
                ImprimirArreglo(dGVqucksort, arQuickSort);
                lblEndQuickSort.Text = "Finalizo: " + DateTime.Now.ToLongTimeString();
                lblIteracionesQuickSort.Text = contquicksort.ToString();
            }
        }
        /// <summary>
        /// Limpia todo los campos en el form
        /// </summary>
        private void Limpiar()
        {
            tBlimiteinferior.Enabled = true;
            tBlimitesuperior.Enabled = true;
            lblStartBurbuja.Text = "Empezo: ";
            lblStartInsert.Text = "Empezo: ";
            lblStartOriginal.Text = "Empezo: ";
            lblStartQuickSort.Text = "Empezo: ";
            lblStartShell.Text = "Empezo: ";
            lblEndBurbuja.Text = "Finalizo: ";
            lblEndInsert.Text = "Finalizo: ";
            lblEndOriginal.Text = "Finalizo: ";
            lblEndQuickSort.Text = "Finalizo: ";
            lblEndShell.Text = "Finalizo: ";
            lblIeracionBurbuja.Text = "0";
            lblIteracionInsert.Text = "0";
            lblInteracionShell.Text = "0";
            lblIteracionesQuickSort.Text = "0";
            dGVoriginal.Rows.Clear();
            dGVburbuja.Rows.Clear();
            dGVinsert.Rows.Clear();
            dGVshell.Rows.Clear();
            dGVqucksort.Rows.Clear();
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
            int auxiciliar, j, cont = 0;
            for (int i = 0; i < arInsert.Length; i++) //desplazamiento vertical
            {
                auxiciliar = arInsert[i];
                j = i - 1;
                cont++;
                while (j >= 0 && arInsert[j] > auxiciliar) //desplamiento horizontal
                {
                    arInsert[j + 1] = arInsert[j];
                    j--;
                }
                arInsert[j + 1] = auxiciliar; //regresa numero acomodado
            }
            ImprimirArreglo(dGVinsert, arInsert);
            lblIteracionInsert.Text = cont.ToString();
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
            int salto = 0, siguiente = 0, auxiliar = 0, e = 0, cont=0;
            salto = arShell.Length/2;
            while (salto > 0)
            {
                siguiente = 1;
                while (siguiente != 0)
                {
                    siguiente = 0;
                    e = 1;
                    while (e <= (arShell.Length-salto))
                    {
                        cont++;
                        if (arShell[e-1]>arShell[(e-1)+salto])
                        {
                            auxiliar = arShell[(e - 1) + salto];
                            arShell[(e - 1) + salto] = arShell[e - 1];
                            arShell[e - 1] = auxiliar;
                            siguiente = 1;
                        }
                        e++;
                    }
                    salto = salto / 2;
                }
            }
            ImprimirArreglo(dGVshell, arShell);
            lblInteracionShell.Text = cont.ToString();
            lblEndShell.Text = "Finalizo: " + DateTime.Now.ToLongTimeString();
            lblEndShell.Update();
        }
        /// <summary>
        /// Organiza los datos con metodo QuickSort
        /// </summary>
        private void QuickSort(int primero, int ultimo)
        {
            int i, j, temp, central = (primero + ultimo) / 2;
            double privote = arQuickSort[central];
            i = primero;
            j = ultimo;
            do
            {
                while (arQuickSort[i] < privote) i++;
                while (arQuickSort[j] > privote) j--;
                if (i <= j)
                {
                    temp = arQuickSort[i];
                    arQuickSort[i] = arQuickSort[j];
                    arQuickSort[j] = temp;
                    i++;
                    j--;
                    
                }
            } while (i<=j);
            if (primero<j)
            {
                QuickSort(primero, j);
                contquicksort++;
            }
            if (i < ultimo)
            {
                QuickSort(i, ultimo);
            }
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
            Calcular();
        }
    }
}