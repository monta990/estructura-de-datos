﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//to-do
//validaciones

namespace esdat
{
    public partial class MCD : Form
    {
        public MCD()
        {
            InitializeComponent();
        }

        private int MCDmetodo(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                a = a < 0 ? a * -1 : a;
                b = b < 0 ? b * -1 : b;
                return MCDmetodo (a,b);
            }
            else if (b > a)
            {
                return MCDmetodo(b, a);

            }
            else if (b == 0)
            {
                return a;
            }
            else return MCDmetodo(a-b,b);
                
        }
        private void btCalcular_Click(object sender, EventArgs e)
        {
            lbMCDresultado.Text=MCDmetodo(int.Parse(tBentero1.Text),int.Parse(tBentero2.Text)).ToString();
        }
    }
}
