using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
///To-Do
/// Version niño y niña
/// 3 niveles de dificultad (ajustar mini segundos)
/// Mensajes para intentos
/// 8-12
/// 12-24
/// 24 ->
/// 


namespace esdat
{
    public partial class Memorama : Form
    {
        public Memorama()
        {
            InitializeComponent();
        }
        private int[] set = { 1, 1, 2, 2, 3, 3, 4, 4};
        private bool esperando = false;
        private int temporal;
        private PictureBox imagentemporal;
        private int intentos;
        private void restart()
        {
            set = set.OrderBy(s => Guid.NewGuid()).ToArray(); //generar shuffle
            //MessageBox.Show(string.Join("  ", set));
            pictureBox1.Image = Properties.Resources.reverso;
            pictureBox2.Image = Properties.Resources.reverso;
            pictureBox3.Image = Properties.Resources.reverso;
            pictureBox4.Image = Properties.Resources.reverso;
            pictureBox5.Image = Properties.Resources.reverso;
            pictureBox6.Image = Properties.Resources.reverso;
            pictureBox7.Image = Properties.Resources.reverso;
            pictureBox8.Image = Properties.Resources.reverso;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            intentos = 0; //reincia contador de intentos
            tSSlintentos.Text = intentos.ToString(); //reinicia label de intentos
        }

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
            voltear.Update();
            if (esperando == false)
            {
                temporal = elemento;
                imagentemporal = voltear;
                esperando = true;
            }
            else
            {
                intentos++;
                tSSlintentos.Text = intentos.ToString();
                if (set[elemento]==set[temporal]) //verificar pares, si precionado tiene el el valor del actual
                {
                    //MessageBox.Show("Que buena memoria tienes.");
                    imagentemporal.Enabled = false;
                    imagentemporal.Visible = false;
                    voltear.Enabled = false;
                    voltear.Visible = false;
                }
                else
                {
                    Thread.Sleep(250); //tiempo que se muestra un par erroneo
                    imagentemporal.Image = Properties.Resources.reverso; //regreso al reverso
                    voltear.Image = Properties.Resources.reverso; //regreso al reverso
                }
                esperando = false;
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

        private void Memorama_Load(object sender, EventArgs e)
        {
            restart();
            axWMP1.URL = @"D:\BGM.mp3"; //archivo a reproducior
            axWMP1.Visible = false;
        }

        private void reinicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restart();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
