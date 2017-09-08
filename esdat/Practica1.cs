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
    public partial class Practica1 : Form
    {
        private int column = 0;
        private int row = 0;
        private int res; //variable para los trayparse
        public Practica1()
        {
            InitializeComponent();
        }
        public void botones() //conntrol del estado de los botones
        {
            txtElemento.Enabled = true;
            btnCapturar.Enabled = true;
        }
        private void Practica1_Load(object sender, EventArgs e)
        {
            Initialize_dgvElementos();
            txtElemento.Focus();
        }
        public Practica1(string dataType) //se obtine del el tipo de dato seleciconado en el form anterior
        {
            InitializeComponent();
            lblVALOR.Text = "(" + dataType + ")";
        }
        private void Initialize_dgvElementos() //creacion de campos para el datagredview
        {
            #region inicializa dgvElementos con datos default
            dgvElementos.Rows.Add();
            dgvElementos.Rows.Add();
            dgvElementos.Rows.Add();
            dgvElementos.Rows[0].HeaderCell.Value = "0";
            dgvElementos.Rows[1].HeaderCell.Value = "1";
            dgvElementos.Rows[2].HeaderCell.Value = "2";
            dgvElementos.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvElementos.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvElementos.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            #endregion
        }

        private void btnCAPTURAR_Click(object sender, EventArgs e)
        {
            //inicio validaciones
            #region validaciones
            if (lblVALOR.Text == "(INT)") //seleccionado int
            {
                if (txtElemento.Text.Trim() == "") //se verifica si el campo esta vacio
                {
                    MessageBox.Show("El campo a capturar esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtElemento.Focus();
                }
                else
                {
                    if (int.TryParse(txtElemento.Text, out res)) //res no se utiliza, es solo para poder hacer el parceo
                    {
                        capturar(); //captura si es valido :)
                    }
                    else
                    {
                        MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // marca el error y no captua :(
                    }
                }
            }
            if (lblVALOR.Text == "(DOUBLE)") //seleccionado double
            {
                if (txtElemento.Text.Trim() == "") //que no exista campo vacio a capturar
                {
                    MessageBox.Show("El campo a capturar esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtElemento.Focus();
                }
                else
                {
                    if (double.TryParse(txtElemento.Text, out double res)) //valida si es double
                    {
                        if (int.TryParse(res.ToString(), out int res2)) //verificar si se colo un entero
                        {
                            MessageBox.Show("Solo se permiten numeros fraccionados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //segunda verificación para descartar el entero
                        }
                        else
                        {
                            capturar(); //captura si es valido :)
                        }
                    }
                    else
                    {
                        MessageBox.Show("Solo se permiten numeros fraccionados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            if (lblVALOR.Text == "(DECIMAL)") //seleccionado decimal
            {
                if (txtElemento.Text == "")
                {
                    MessageBox.Show("El campo esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtElemento.Focus();
                }
                else
                {
                    if (decimal.TryParse(txtElemento.Text, out decimal res))
                    {
                        capturar(); //captura si es valido :)
                    }
                    else
                    {
                        MessageBox.Show("Solo se permiten cifras con decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            if (lblVALOR.Text == "(STRING)") //seleccionado string
            {
                if (txtElemento.Text == "")
                {
                    MessageBox.Show("El campo esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtElemento.Focus();
                }
                else
                {
                    if (txtElemento.Text.Length >= 2) //se valida que se cuente con mas de un caracter para ser string
                    {
                        capturar(); //captura si es valido :)
                    }
                    else
                    {
                        MessageBox.Show("Se debe caprturar uno mas caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtElemento.Focus();
                    }
                }
            }
            if (lblVALOR.Text == "(CHAR)") //seleccionado string
            {
                if (txtElemento.Text == "")
                {
                    MessageBox.Show("El campo esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtElemento.Focus();
                }
                else
                {
                    if (txtElemento.Text.Length == 1) //se valida que sa un caracter
                    {
                        capturar(); //captura si es valido :)
                    }
                    else
                    {
                        MessageBox.Show("Se debe caprturar un caracter", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtElemento.Focus();
                    }
                }
            }
            #endregion
            //fin validaciones
        }

        private void capturar() //se captura el dato ya validado
        {
            #region Codigo de captura a dgvElementos
            dgvElementos[column, row].Value = txtElemento.Text;
            column++;
            if (column == 3)
            {
                row++;
                column = 0;
            }
            if (row == 3)
            {
                txtElemento.Enabled = false;
                btnCapturar.Enabled = false;
            }
            if (row < 3)
            {
                lbElementoIngresar.Text = "Elemento [" + row + "," + column + "]:";
            }
            txtElemento.Clear();
            txtElemento.Focus();
            #endregion
        }

        private void tbLimpiar_Click(object sender, EventArgs e)
        {
            dgvElementos.Rows.Clear();
            txtElemento.Clear();
            txtElemento.Focus();
            lbElementoIngresar.Text = "Elemento [0,0]:";
            botones();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}