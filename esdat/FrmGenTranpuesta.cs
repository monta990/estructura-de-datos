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
    public partial class FrmGenTranpuesta : Form
    {
        public FrmGenTranpuesta()
        {
            InitializeComponent();
        }
        private void Verificar()
        {
            if (tBcolumnas.Text.Trim() == "" || tBrenglones.Text.Trim() == "")
            {
                MessageBox.Show("Algun campo esta vacio", "Algo esta vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (tBcolumnas.Text.Trim() == "")
                {
                    tBcolumnas.Focus();
                }
                else
                {
                    tBrenglones.Focus();
                }
            }
            else
            {
                if (int.TryParse(tBcolumnas.Text, out int c) && int.TryParse(tBrenglones.Text, out int r))
                {
                    if (int.Parse(tBcolumnas.Text) >= 1 && int.Parse(tBrenglones.Text) >= 1)
                    {
                        new FrmTranspuesta(int.Parse(tBcolumnas.Text), int.Parse(tBrenglones.Text)).Show();
                    }
                    else
                    {
                        MessageBox.Show("El numero de renglones y columnas tiene que se positivo", "Solo numeros positivos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Solo numero enteros", "Solo enteros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            Verificar();
        }
    }
}
