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
using System.Text.RegularExpressions;

namespace esdat
{
    public partial class FrmStackGen : Form
    {
        Stack<string> pilastring = new Stack<string>();
        Regex valida = new Regex(@"^[a-zA-Z0-9]+$"); //solo numeros, letras mayusculas y minusculas 
        public FrmStackGen() => InitializeComponent();
        /// <summary>
        /// Limpia campos necesarios
        /// </summary>
        private void Limpiar()
        {
            tBelemento.Clear();
            btnPush.Text = "Push()";
            btnContains.Text = "Contains()";
            btnElementAT.Text = "ElementAt()";
            tBelemento.Focus();
        }
        /// <summary>
        /// Limpiar pila de elementos
        /// </summary>
        private void Clear()
        {
            if (pilastring.Count == 0)
            {
                MessageBox.Show("La pila esta vacia", "Pila vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pilastring.Clear();
                Imprimirpila();
            }
        }
        /// <summary>
        /// Push a la pila
        /// </summary>
        private void Push()
        {
            if (valida.IsMatch(tBelemento.Text))
            {
                pilastring.Push(tBelemento.Text);
                Imprimirpila();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Solo se pueden ingresar numero entero, \n letras mayusculas y minisculas","Carater no soportado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("El elemeto extraido es: "+ pilastring.Pop().ToString(), "Elemento extraido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Imprimirpila();
                Limpiar();
            }
        }
        /// <summary>
        /// Pick a la pila
        /// </summary>
        private void Peek()
        {
            if (pilastring.Count == 0)
            {
                MessageBox.Show("La pila esta vacia", "Pila vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El elemento en tope de la pila es: \n" + pilastring.Peek(), "Elemento al tope", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Limpiar();
        }
        /// <summary>
        /// Verificar su la pila contine un el elemento indicado en el combobox
        /// </summary>
        private void Contains()
        {
            if (pilastring.Contains(tBelemento.Text))
            {
                MessageBox.Show("La pila si contiene el elemento " + tBelemento.Text, "Elemento encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Elemento no encontrado \n Pruebe con otro","No encontrado",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Limpiar();
        }
        /// <summary>
        /// Buscar elemento en la posición indicada
        /// </summary>
        private void ElementAt()
        {
            if (int.TryParse(tBelemento.Text, out int elemento) && elemento <= pilastring.Count())
            {
                MessageBox.Show("El elemento en la posición: "+elemento+" es: "+ pilastring.ElementAt(elemento), "Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El indice a buscar solo puede ser un numero entero","Solo enteros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Limpiar();
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
        /// <summary>
        /// Pila a revertir
        /// </summary>
        /// <param name="input">Imgresa la pila a revertir de tipo string</param>
        private void Reverse(Stack<string> input)
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
        private void btnSalir_Click(object sender, EventArgs e) => this.Close();
        private void btnPush_Click(object sender, EventArgs e) => Push();
        /// <summary>
        /// Prepara los botones con el texto necesario, tomandolo del textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBelemento_TextChanged(object sender, EventArgs e)
        {
            btnPush.Text = "Push(\""+tBelemento.Text+"\")";
            btnContains.Text = "Contains(\"" + tBelemento.Text + "\")";
            if (int.TryParse(tBelemento.Text, out int elemento)) //cambia el texto solo si es numero entero
            {
                btnElementAT.Text = "ElementAt(\"" + elemento + "\")";
            }
            else
            {
                btnElementAT.Text = "ElementAt(\"\")";
            }
        }
        private void btnPop_Click(object sender, EventArgs e) => Pop();
        private void btnPeek_Click(object sender, EventArgs e) => Peek();
        private void btnClear_Click(object sender, EventArgs e) => Clear();
        private void btnReversa_Click(object sender, EventArgs e) => Reverse(pilastring);
        private void btnContains_Click(object sender, EventArgs e) => Contains();
        private void btnElementAT_Click(object sender, EventArgs e) => ElementAt();
        private void llblInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/Pila_(inform%C3%A1tica)");
    }
}