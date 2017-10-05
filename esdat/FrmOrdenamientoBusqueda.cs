﻿using System;
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
        }
        /// <summary>
        /// Organiza los datos con metodo burbuja
        /// </summary>
        private void Burbuja()
        {
            ImprimirArreglo(dGVburbuja, arBurbuja);
        }
        /// <summary>
        /// Organiza los datos con metodo Insert
        /// </summary>
        private void Insert()
        {
            ImprimirArreglo(dGVinsert, arInsert);
        }
        /// <summary>
        /// Organiza los datos con metodo Shell
        /// </summary>
        private void Shell()
        {
            ImprimirArreglo(dGVshell, arShell);
        }
        /// <summary>
        /// Organiza los datos con metodo QuickSort
        /// </summary>
        private void QuickSort()
        {
            ImprimirArreglo(dGVqucksort, arQuickSort);
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
            Insert();
            Shell();
            QuickSort();
        }
    }
}