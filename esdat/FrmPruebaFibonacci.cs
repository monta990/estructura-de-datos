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
    public partial class FrmPruebaFibonacci : Form
    {
        public FrmPruebaFibonacci()
        {
            InitializeComponent();
        }
        private void Generar() 
        {
            dGViewFibo.Rows.Clear();
            double a = 0;
            double b = 1;
            int conteo = 1;
            int celda = 0;
            string veinte = "20";
            for (double c = 0; c <= 4200;) //se establece limite (c), 
            {
                dGViewFibo.Rows.Add(c.ToString()); //se agrega c
                dGViewFibo.Rows[celda].HeaderCell.Value = conteo.ToString();
                if (c == 1)
                {
                    dGViewFibo.Rows.Add("1");
                }
                c = a + b;
                a = b;

                b = c;
                celda++;
                conteo++;
            }
            dGViewFibo.Rows[19].HeaderCell.Value = veinte.ToString(); //fix temporal de poner el 20
        }
        private long Prueba(int valor)
        {
            if (valor == 0 || valor == 1)
            {
                return 1;
            }
            else
            {
                return Prueba(valor -1)+Prueba(valor -2);
            }
        }
        private void Buscar()
        {
            if (int.TryParse(textBox1.Text, out int r))
            {
                if (int.Parse(textBox1.Text) == 1)
                {
                    label3.Text = "El 1 numero de fibonacci es: 0";
                }
                else if (int.Parse(textBox1.Text) == 2)
                {
                    label3.Text = "El 2 numero de fibonacci es: 1";
                }
                else
                {
                    label3.Text = "El " + textBox1.Text + " numero de fibonacci es: " + Prueba(int.Parse(textBox1.Text) - 2);
                }
            }
            else
            {
                MessageBox.Show("Solo numeros enteros de 1 en adelante","Solo numeros enteros positivos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void FrmPruebaFibonacci_Load(object sender, EventArgs e)
        {
            Generar();
        }
    }
}
