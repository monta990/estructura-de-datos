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

namespace esdat
{
    public partial class MemoramaNina : Form
    {
        public MemoramaNina(int dificultad, string nombre)
        {
            InitializeComponent();
            this.nombre = nombre; //cargar de manera local el nombre
            this.dificultad = dificultad; //se asigna dificultad
        }
        public int dificultad; //milisegundo de segundos de volteo de tarjeta, nivel 1 = 1000, nivel = 500 , nivel =250
        private int[] set = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8}; //arreglo para cartas
        private bool esperando = false; //esperando la segunda tarjeta
        private int temporal; //milisegundos para mostrar la carta, principiante = 1000, intermedio = 500 , experto =250
        private string nombre; //nombre del juagador
        private PictureBox imagentemporal; //control de tarjeta volteada
        private int intentos; //contador de intentos

        private void Memorama_Load(object sender, EventArgs e)
        {
            restart();
            axWMP1.URL = @"D:\Peachs.mp3"; //archivo a reproducir
            axWMP1.Visible = false;
            axWMP1.settings.setMode("loop", true);
            tSSLnombre.Text = this.nombre;
        }
        /// <summary>
        /// Reinica el la baraja
        /// </summary>
        private void restart()
        {
            set = set.OrderBy(s => Guid.NewGuid()).ToArray(); //generar shuffle
            foreach (PictureBox p in this.Controls.OfType<PictureBox>()) //establece las mismas propiedades a un mismo tipo de recurso
            {
                p.Image = Properties.Resources.reverso;
                p.Visible = true;
                p.Enabled = true;
            }
            intentos = 0; //reinicia contador de intentos
            tSSlintentos.Text = intentos.ToString(); //reinicia label de intentos
        }
        /// <summary>
        /// Accion de verificar la primera carta volteada con la segunda
        /// </summary>
        /// <param name="voltear"></param>
        /// <param name="elemento"></param>
        private void flip(PictureBox voltear, int elemento) //voltear la carta
        {
#region asignación de arreglo de cartas y su imagen
            if (set[elemento] == 1)
            {
                voltear.Image = esdat.Properties.Resources.memorananina1;
            }
            if (set[elemento] == 2)
            {
                voltear.Image = esdat.Properties.Resources.memorananina2;
            }
            if (set[elemento] == 3)
            {
                voltear.Image = esdat.Properties.Resources.memorananina3;
            }
            if (set[elemento] == 4)
            {
                voltear.Image = esdat.Properties.Resources.memorananina4;
            }
            if (set[elemento] == 5)
            {
                voltear.Image = esdat.Properties.Resources.memorananina5;
            }
            if (set[elemento] == 6)
            {
                voltear.Image = esdat.Properties.Resources.memorananina6;
            }
            if (set[elemento] == 7)
            {
                voltear.Image = esdat.Properties.Resources.memorananina7;
            }
            if (set[elemento] == 8)
            {
                voltear.Image = esdat.Properties.Resources.memorananina8;
            }
#endregion
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
                    imagentemporal.Enabled = false;
                    imagentemporal.Visible = false;
                    voltear.Enabled = false;
                    voltear.Visible = false;
                    if (pictureBox1.Enabled == false && pictureBox2.Enabled == false && pictureBox3.Enabled == false && pictureBox4.Enabled == false && pictureBox5.Enabled == false && pictureBox6.Enabled == false && pictureBox7.Enabled == false && pictureBox8.Enabled == false && pictureBox9.Enabled == false && pictureBox10.Enabled == false && pictureBox11.Enabled == false && pictureBox12.Enabled == false && pictureBox13.Enabled == false && pictureBox14.Enabled == false && pictureBox15.Enabled == false && pictureBox16.Enabled == false)
                    {
                        if (intentos == 8) //juego perfecto
                        {
                            MessageBox.Show("Muy buena suerte" + tSSLnombre.Text + "\n terminaste en 8 intentos.", "Juego perfecto", MessageBoxButtons.OK, MessageBoxIcon.Information); //todo terminado
                        }
                        else if (intentos >= 9 || intentos <= 16) //juego intermedio
                        {
                            MessageBox.Show("Muy bien " + tSSLnombre.Text + " terminaste en: \n " + intentos + " intentos.", "Buen jugador", MessageBoxButtons.OK, MessageBoxIcon.Information); //todo terminado
                        }
                        else if (intentos >= 17) //juego regular
                        {
                            MessageBox.Show("Bien  " + tSSLnombre.Text + "  terminaste en: \n " + intentos + " sigue practicando.", "Bien sigue practicando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
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
#region click de los picturebox
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
#endregion
        private void reinicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restart(); //reiniciar el juego con un random de cartas
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWMP1.close(); //silenciar al salir
            this.Close();
        }

        private void silenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWMP1.settings.mute = true; //silenciar dentro del juego
        }

        private void reproducirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWMP1.settings.mute = false; //volver a reproducir
        }

        private void nivel1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dificultad = 1000; //dificultad principiante
            restart();
        }
        private void nivel2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dificultad = 500; //dificultad intermedio
            restart();
        }
        private void nivel3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dificultad = 250; //dificultad facil
            restart();
        }
    }
}
