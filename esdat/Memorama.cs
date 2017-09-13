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
    public partial class Memorama : Form
    {
        public Memorama()
        {
            InitializeComponent();
        }
        private int[] set = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 ,8, 8 };

        private void flip(PictureBox voltear, int elemento) //voltear la carta
        {
            //voltear.Enabled = false;
            //voltear.Visible = false;
            if (set[elemento] == 1)
            {
                voltear.Image = esdat.Properties.Resources._1;
            }
            if (set[elemento] == 2)
            {
                voltear.Image = esdat.Properties.Resources._2;
            }
            if (set[elemento] == 3)
            {
                voltear.Image = esdat.Properties.Resources._3;
            }
            if (set[elemento] == 4)
            {
                voltear.Image = esdat.Properties.Resources._4;
            }
            if (set[elemento] == 5)
            {
                voltear.Image = esdat.Properties.Resources._5;
            }
            if (set[elemento] == 6)
            {
                voltear.Image = esdat.Properties.Resources._6;
            }
            if (set[elemento] == 7)
            {
                voltear.Image = esdat.Properties.Resources._7;
            }
            if (set[elemento] == 8)
            {
                voltear.Image = esdat.Properties.Resources._8;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            flip(pictureBox1,0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            flip(pictureBox2,1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            flip(pictureBox3,2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            flip(pictureBox4,3);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            flip(pictureBox5,4);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            flip(pictureBox6,5);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            flip(pictureBox7,6);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            flip(pictureBox8,7);
        }

        private void btShuffle_Click(object sender, EventArgs e)
        {
            set = set.OrderBy(s => Guid.NewGuid()).ToArray(); //generar shuffle
            MessageBox.Show(string.Join("  ",set));
        }
    }
}
