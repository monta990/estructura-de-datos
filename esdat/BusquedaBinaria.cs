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
    public partial class BusquedaBinaria : Form
    {
        private int[] valores;
        public BusquedaBinaria()
        {
            InitializeComponent();
        }

        private void btGenerar_Click(object sender, EventArgs e)
        {
            dGViewElementos.Rows.Clear();
            valores = new int[int.Parse(tBelementos.Text)]; //tBelementos
            Random random1 = new Random();
            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = random1.Next(int.Parse(tBlimite.Text)+1); //tBlimite.Text);
            }
            Array.Sort(valores);
            for (int i = 0; i < valores.Length; i++)
            {
                dGViewElementos.Rows.Add(valores[i].ToString());
                dGViewElementos.Rows[i].HeaderCell.Value = i.ToString();
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
