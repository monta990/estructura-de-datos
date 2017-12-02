using System;
using System.Windows.Forms;
namespace esdat
{
    public partial class Fibonacci : Form
    {
        public Fibonacci() => InitializeComponent();
        /// <summary>
        /// Valida datos
        /// </summary>
        private void Validar()
        {
            if (int.TryParse(tBlimite.Text, out int s)) //verificar si es entero
            {
                dGViewFibo.Rows.Clear();
                double a = 0;
                double b = 1;
                for (double c = 0; c <= int.Parse(tBlimite.Text);) //se establece limite (c), 
                {
                    dGViewFibo.Rows.Add(c.ToString()); //se agrega c
                    if (c == 1)
                    {
                        dGViewFibo.Rows.Add("1");
                    }
                    c = a + b;
                    a = b;
                    b = c;
                }
            }
            else
            {
                MessageBox.Show("Solo numeros enteros positivos", "El limite incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e) => Validar();
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dGViewFibo.Rows.Clear();
            tBlimite.Clear();
        }
        private void btnSalir_Click(object sender, EventArgs e) => this.Close();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/Sucesi%C3%B3n_de_Fibonacci");
    }
}