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
/// 3 niveles de dificultad (ajustar mini segundos) check
/// Mensajes para intentos
/// 8-12
/// 12-24
/// 24 ->
/// Pedir nombre con Comic Sans, mas profesional


namespace esdat
{
    public partial class MemoramaNino : Form
    {
        public MemoramaNino(int dificultad, string nombre)
        {
            InitializeComponent();
            this.nombre = nombre; //cargar de manera local el nombre
        }
        public int dificultad = 1000; //milisegundo de segundos de volteo de tarjeta, nivel 1 = 1000, nivel = 500 , nivel =250
        private int[] set = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8}; //arreglo para cartas
        private bool esperando = false; //esperando la segunda tarjeta
        private int temporal;
        private string nombre;
        private PictureBox imagentemporal; //control de tarjeta volteada
        private int intentos; //contador de intentos
        private void restart()
        {
            set = set.OrderBy(s => Guid.NewGuid()).ToArray(); //generar shuffle
            for (int i = 1; i <= 16; i++)
            {
                //pictureBox[i].Image = Properties.Resources.reverso;
            }
            pictureBox1.Image = Properties.Resources.reverso;
            pictureBox2.Image = Properties.Resources.reverso;
            pictureBox3.Image = Properties.Resources.reverso;
            pictureBox4.Image = Properties.Resources.reverso;
            pictureBox5.Image = Properties.Resources.reverso;
            pictureBox6.Image = Properties.Resources.reverso;
            pictureBox7.Image = Properties.Resources.reverso;
            pictureBox8.Image = Properties.Resources.reverso;
            pictureBox9.Image = Properties.Resources.reverso;
            pictureBox10.Image = Properties.Resources.reverso;
            pictureBox11.Image = Properties.Resources.reverso;
            pictureBox12.Image = Properties.Resources.reverso;
            pictureBox13.Image = Properties.Resources.reverso;
            pictureBox14.Image = Properties.Resources.reverso;
            pictureBox15.Image = Properties.Resources.reverso;
            pictureBox16.Image = Properties.Resources.reverso;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox9.Enabled = true;
            pictureBox1.Enabled = true;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            pictureBox13.Enabled = true;
            pictureBox14.Enabled = true;
            pictureBox15.Enabled = true;
            pictureBox16.Enabled = true;
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
            voltear.Enabled = false; //fix click en si mismo
            voltear.Update(); //actualiza el picturebox
            if (esperando == false) //al seleccionar la primera carta
            {
                temporal = elemento;
                imagentemporal = voltear;
                esperando = true;
            }
            else
            {
                intentos++; //suma uno al intento
                tSSlintentos.Text = intentos.ToString(); //muestra la cantidad de intentos
                if (set[elemento]==set[temporal]) //verificar pares, si precionado tiene el el valor del actual
                {
                    //MessageBox.Show("Que buena memoria tienes."); //debug
                    imagentemporal.Enabled = false;
                    imagentemporal.Visible = false;
                    voltear.Enabled = false;
                    voltear.Visible = false;
                }
                else //si no fueron iguales las 2 cartas elegidas
                {
                    Thread.Sleep(dificultad); //tiempo que se muestra un par erroneo, seleccionada desde el menu dificultad
                    imagentemporal.Image = Properties.Resources.reverso; //regreso al reverso
                    voltear.Image = Properties.Resources.reverso; //regreso al reverso
                    imagentemporal.Enabled = true; //fix click en si mismo
                    voltear.Enabled = true; //fix click en si mismo

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

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            flip(pictureBox16, 15);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            flip(pictureBox15, 14);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            flip(pictureBox14, 13);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            flip(pictureBox13, 12);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            flip(pictureBox12, 11);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            flip(pictureBox11, 10);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            flip(pictureBox10, 9);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            flip(pictureBox9, 8);
        }
        private void Memorama_Load(object sender, EventArgs e)
        {
            restart();
            axWMP1.URL = @"D:\BGM.mp3"; //archivo a reproducir
            axWMP1.Visible = false;
            tSSLnombre.Text = this.nombre;
        }

        private void reinicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restart();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nivel1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dificultad = 1000; //nivel 1
            restart();
        }

        private void nivel2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dificultad = 500; //nivel 2
            restart();
        }

        private void nivel3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dificultad = 250; //nivel 3
            restart();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
