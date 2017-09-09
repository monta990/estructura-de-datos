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
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tBlimite.Text, out int s)) //verificar si es entero
            {
                dataGridView1.Rows.Clear();
                double a = 0;
                double b = 1;
                for (double c = 0; c <= int.Parse(tBlimite.Text);) //se establece limite (c), 
                {
                    dataGridView1.Rows.Add(c.ToString()); //se agrega c
                    if (c == 1)
                    {
                        dataGridView1.Rows.Add("1");
                    }
                    c = a + b;
                    a = b;
                    b = c;
                }
            }
            else
            {
                MessageBox.Show("El limite incorrecto");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            tBlimite.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/Sucesi%C3%B3n_de_Fibonacci");
        }
    }
}