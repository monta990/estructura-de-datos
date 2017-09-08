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
    public partial class TipoDatos : Form
    {
        public TipoDatos()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            new Practica1(selected_RadioButton()).ShowDialog();
        }

        private string selected_RadioButton()
        {
            string resultado = null;
            resultado = rBint.Checked == true ? "INT" : resultado;
            resultado = rBdouble.Checked == true ? "DOUBLE" : resultado;
            resultado = rBdecimal.Checked == true ? "DECIMAL" : resultado;
            resultado = rBchar.Checked == true ? "CHAR" : resultado;
            resultado = rBstring.Checked == true ? "STRING" : resultado;
            //resultado = radioButton6.Checked == true ? "..." : resultado;
            //resultado = radioButton7.Checked == true ? "..." : resultado;

            return resultado;
        }

    }
}
