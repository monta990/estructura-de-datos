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
    public partial class FrmPosfijas : Form
    {
        private Stack<int> pilaint = new Stack<int>();
        private int op1, op2;
        private bool truena = false;
        public FrmPosfijas()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Imprimir pila
        /// </summary>
        private void Imprimirpila()
        {
            dGVposfija.Rows.Clear();
            foreach (int item in pilaint)
            {
                dGVposfija.Rows.Add(item.ToString());
            }
        }
        private void Limpiar()
        {
            lblResultado.Text = "0";
            dGVposfija.Rows.Clear();
            tbExpresion.Clear();
            pilaint.Clear();
        }

        private void btmPasoaPaso_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "0";
            pilaint.Clear();
            dGVposfija.Rows.Clear();
            string[] expresion = tbExpresion.Text.Split(' ');
            for (int i = 0; i < expresion.Length; i++)
            {
                try
                {
                    int operando = int.Parse(expresion[i]);
                    pilaint.Push(operando);
                    MessageBox.Show(expresion[i] + " es un operando, va a la pila", "Es operando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception deter)
                {
                    switch (expresion[i])
                    {
                        case "+":
                            if (pilaint.Count >= 2)
                            {
                                op1 = pilaint.Pop();
                                op2 = pilaint.Pop();
                                int suma = op2 + op1;
                                MessageBox.Show("Push(" + op2 + " + " + op1 + ")", "Suma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                pilaint.Push(suma);
                                MessageBox.Show("Por lo cual: " + suma + " va a la pila", "A la Pila", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                truena = true;                
                            }
                            break;
                        case "-":
                            if (pilaint.Count >= 2)
                            {
                                op1 = pilaint.Pop();
                                op2 = pilaint.Pop();
                                int resta = op2 - op1;
                                MessageBox.Show("Push(" + op2 + " - " + op1 + ")", "Resta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                pilaint.Push(resta);
                                MessageBox.Show("Por lo cual: " + resta + " va a la pila", "A la Pila", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                truena = true;
                            }
                            break;
                        case "*":
                            if (pilaint.Count == 2)
                            {
                                op1 = pilaint.Pop();
                                op2 = pilaint.Pop();
                                int multi = op2 * op1;
                                MessageBox.Show("Push(" + op2 + " * " + op1 + ")", "Multiplicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                pilaint.Push(multi);
                                MessageBox.Show("Por lo cual: " + multi + " va a la pila", "A la Pila", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                truena = true;
                            }
                            break;
                        case "/":
                            
                            if (pilaint.Count == 2)
                            {
                                op1 = pilaint.Pop();
                                op2 = pilaint.Pop();
                                int dividir = op2 / op1;
                                MessageBox.Show("Push(" + op2 + " / " + op1 + ")", "Divición", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                pilaint.Push(dividir);
                                MessageBox.Show("Por lo cual: " + dividir + " va a la pila", "A la Pila", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                truena = true;
                            }
                            break;
                        default:
                            MessageBox.Show("No fue operando ni operarador, caracter incorrecto","Caracter no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                Imprimirpila();
                if (truena) //salir del for en caso de fallo
                break;
            }
            if (truena == true)
            {
                lblResultado.Text = "";
                MessageBox.Show("Error en la expresión se termino con un operando", "Expresión incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (pilaint.Count == 1)
                {
                    MessageBox.Show("El resultado es: " + pilaint.Peek(), "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblResultado.Text = pilaint.Peek().ToString();
                }
                else
                {
                    lblResultado.Text = "";
                    MessageBox.Show("Error en la expresión", "Expresión incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEjemplo1_Click(object sender, EventArgs e)
        {
            Limpiar();
            tbExpresion.Text = "1 2 - 3 * 4 / 5 + 6 +";
        }

        private void btnEjemplo2_Click(object sender, EventArgs e)
        {
            Limpiar();
            tbExpresion.Text = "1 2 - 3 * 4 / 5 + 6 + 7 * 8 + 9 +";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReinicar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            pilaint.Clear();
            dGVposfija.Rows.Clear();
            string[] expresion = tbExpresion.Text.Split(' ');
            for (int i = 0; i < expresion.Length; i++)
            {
                try
                {
                    int operando = int.Parse(expresion[i]);
                    pilaint.Push(operando);
                }
                catch (Exception deter)
                {
                    switch (expresion[i])
                    {
                        case "+":
                            if (pilaint.Count >= 2)
                            {
                                op1 = pilaint.Pop();
                                op2 = pilaint.Pop();
                                int suma = op2 + op1;
                                pilaint.Push(suma);
                            }
                            else
                            {
                                truena = true;
                            }
                            break;
                        case "-":
                            if (pilaint.Count >= 2)
                            {
                                op1 = pilaint.Pop();
                                op2 = pilaint.Pop();
                                int resta = op2 - op1;
                                pilaint.Push(resta);
                            }
                            else
                            {
                                truena = true;
                            }
                            break;
                        case "*":
                            if (pilaint.Count == 2)
                            {
                                op1 = pilaint.Pop();
                                op2 = pilaint.Pop();
                                int multi = op2 * op1;
                                pilaint.Push(multi);
                            }
                            else
                            {
                                truena = true;
                            }
                            break;
                        case "/":

                            if (pilaint.Count == 2)
                            {
                                op1 = pilaint.Pop();
                                op2 = pilaint.Pop();
                                int dividir = op2 / op1;
                                pilaint.Push(dividir);
                            }
                            else
                            {
                                truena = true;
                            }
                            break;
                        default:
                            MessageBox.Show("No fue operando ni operarador, caracter incorrecto", "Caracter no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                Imprimirpila();
                if (truena) //salir del for en caso de fallo
                    break;
            }
            if (truena == true)
            {
                lblResultado.Text = "";
                MessageBox.Show("Error en la expresión se termino con un operando", "Expresión incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (pilaint.Count == 1)
                {
                    MessageBox.Show("El resultado es: " + pilaint.Peek(), "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblResultado.Text = pilaint.Peek().ToString();
                }
                else
                {
                    lblResultado.Text = "";
                    MessageBox.Show("Error en la expresión", "Expresión incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dGVposfija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
