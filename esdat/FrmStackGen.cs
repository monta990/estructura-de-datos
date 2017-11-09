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
            pilastring.Push(tBelemento.Text);
            Imprimirpila();
        }

        private void tBelemento_TextChanged(object sender, EventArgs e)
        {
            btnPush.Text = "Push(\""+tBelemento.Text+"\")";
            btnContains.Text = "Contains(\"" + tBelemento.Text + "\")";
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (pilastring.Count == 0)
            {
                MessageBox.Show("Pila vacía");
            }
            else
            {
                pilastring.Pop();
                Imprimirpila();
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {

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
        public Stack Reverse(Stack<string> input)
        {
            //Declare another stack to store the values from the passed stack
            dGVpila.Rows.Clear();
            Stack temp = new Stack();
            Stack <string>desor = input;
            //While the passed stack isn't empty, pop elements from the passed stack onto the temp stack
            while (input.Count != 0)
                temp.Push(desor.Pop());
            
            foreach (string item in temp)
            {
                dGVpila.Rows.Add(item);
            }
            return temp;
        }
        private void btnReversa_Click(object sender, EventArgs e)
        {

            Reverse(pilastring);
            //Imprimirpila();
        }
    }
}
