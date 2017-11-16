using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esdat
{
    public partial class FrmStackGen : Form
    {
        Stack<string> pilastring = new Stack<string>();
        public FrmStackGen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Push a la pila
        /// </summary>
        private void Push()
        {
            if (int.TryParse(tBelemento.Text, out int elemento))
            {
                pilastring.Push(tBelemento.Text);
                Imprimirpila();
            }
            else
            {
                MessageBox.Show("No es numero entero el que se esta ingresando","No es entero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Pop a la pila
        /// </summary>
        private void Pop()
        {
            if (pilastring.Count == 0)
            {
                MessageBox.Show("La pila esta vacia", "Pila vacía",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pilastring.Pop();
                Imprimirpila();
            }
        }
        /// <summary>
        /// Pick a la pila
        /// </summary>
        private void Peek()
        {
            pilastring.Peek();
        }
        /// <summary>
        /// Imprimir pila
        /// </summary>
        private void Imprimirpila()
        {
            dGVpila.Rows.Clear();
            foreach (string item in pilastring)
            {
                dGVpila.Rows.Add(item);
            }
            lblnumeros.Text = pilastring.Count.ToString();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            Push();
        }

        private void tBelemento_TextChanged(object sender, EventArgs e)
        {
            btnPush.Text = "Push(\""+tBelemento.Text+"\")";
            btnContains.Text = "Contains(\"" + tBelemento.Text + "\")";
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            Pop();
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            Peek();
        }

        private void FrmStackGen_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (pilastring.Count == 0)
            {
                MessageBox.Show("Pila esta vacia");
            }
            else
            {
                pilastring.Clear();
                Imprimirpila();
            }
            
        }
        /// <summary>
        /// Pila a revertir
        /// </summary>
        /// <param name="input">Imgresa la pila a revertir de tipo string</param>
        public void Reverse(Stack<string> input)
        {
            dGVpila.Rows.Clear();
            //pila temporal
            Stack<string> temp = new Stack<string>();
            //ingresar los elementos a la pila temp y hacer un pop a la imput hasta cero
            while (input.Count != 0)
                temp.Push(input.Pop());
            //agregarlos a dgv
            foreach (string item in temp)
            {
                dGVpila.Rows.Add(item);
            }
            //limpiar pila original
            pilastring.Clear();
            //mover temporal a pila original
            pilastring = temp;
        }
        private void btnReversa_Click(object sender, EventArgs e)
        {
            Reverse(pilastring);
        }
    }
}
