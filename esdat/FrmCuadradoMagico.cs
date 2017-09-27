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
    public partial class FrmCuadradoMagico : Form
    {
        public FrmCuadradoMagico()
        {
            InitializeComponent();
        }

        private void FrmCuadradoMagico_Load(object sender, EventArgs e)
        {
            dGVcuadradoMagico.Columns[0].Width = 20;
            dGVcuadradoMagico.Columns[1].Width = 20;
            dGVcuadradoMagico.Columns[2].Width = 20;
            dGVcuadradoMagico.Columns[3].Width = 20;
            dGVcuadradoMagico.Width = 83;
            dGVcuadradoMagico.Height = 91;
            dGVcuadradoMagico.Rows.Add();
            dGVcuadradoMagico.Rows.Add();
            dGVcuadradoMagico.Rows.Add();
            dGVcuadradoMagico.Rows.Add();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dGVcuadradoMagico.Rows.Clear();
            dGVcuadradoMagico.Rows.Add("0","0","0","0");
            dGVcuadradoMagico.Rows.Add("0", "0", "0", "0");
            dGVcuadradoMagico.Rows.Add("0", "0", "0", "0");
            dGVcuadradoMagico.Rows.Add("0", "0", "0", "0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dGVcuadradoMagico.Rows.Clear();
            dGVcuadradoMagico.Rows.Add("16", "3", "2", "13");
            dGVcuadradoMagico.Rows.Add("5", "10", "11", "8");
            dGVcuadradoMagico.Rows.Add("9", "6", "7", "12");
            dGVcuadradoMagico.Rows.Add("4", "15", "14", "1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dGVcuadradoMagico.Rows.Clear();
            dGVcuadradoMagico.Rows.Add();
            dGVcuadradoMagico.Rows.Add();
            dGVcuadradoMagico.Rows.Add();
            dGVcuadradoMagico.Rows.Add();
        }
    }
}
