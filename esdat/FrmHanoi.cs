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
    public partial class FrmHanoi : Form
    {
        private int contador = 0;
        private string origen="";
        private Stack<PictureBox> pila1 = new Stack<PictureBox>();
        private Stack<PictureBox> pila2 = new Stack<PictureBox>();
        private Stack<PictureBox> pila3 = new Stack<PictureBox>();
        public FrmHanoi()
        {
            InitializeComponent();
            #region Manejo de paneles
            foreach (Panel item in this.Controls.OfType<Panel>())
            {
                item.AllowDrop = true;
                item.DragEnter += Panel_DragEnter;
                item.DragDrop += Panel_DragDrop;
            }
            #endregion
            #region Sobre carga de MouseMove de Discos
            picBoxDisc1.MouseDown += picBoxDisc1_MouseDown;
            picBoxDisc2.MouseDown += picBoxDisc2_MouseDown;
            picBoxDisc3.MouseDown += picBoxDisc3_MouseDown;
            picBoxDisc4.MouseDown += picBoxDisc4_MouseDown;
            picBoxDisc5.MouseDown += picBoxDisc5_MouseDown;
            #endregion
        }
        private void FrmHanoi_Load(object sender, EventArgs e)
        {
            #region Reiniciar discos
            picBoxDisc1.Parent = panel1; //disco a panel 1
            picBoxDisc2.Parent = panel1;
            picBoxDisc3.Parent = panel1;
            picBoxDisc4.Parent = panel1;
            picBoxDisc5.Parent = panel1;
            picBoxDisc1.Top = panel1.Height - picBoxDisc1.Height - 0 * picBoxDisc1.Height - picBoxbase1.Height;
            picBoxDisc2.Top = panel1.Height - picBoxDisc2.Height - 1 * picBoxDisc2.Height - picBoxbase1.Height;
            picBoxDisc3.Top = panel1.Height - picBoxDisc3.Height - 2 * picBoxDisc3.Height - picBoxbase1.Height;
            picBoxDisc4.Top = panel1.Height - picBoxDisc4.Height - 3 * picBoxDisc4.Height - picBoxbase1.Height;
            picBoxDisc5.Top = panel1.Height - picBoxDisc5.Height - 4 * picBoxDisc5.Height - picBoxbase1.Height;
            picBoxDisc1.BringToFront(); //dibujar a frente de torre
            picBoxDisc2.BringToFront();
            picBoxDisc3.BringToFront();
            picBoxDisc4.BringToFront();
            picBoxDisc5.BringToFront();
            pila1.Clear();
            pila1.Push(picBoxDisc1);
            pila1.Push(picBoxDisc2);
            pila1.Push(picBoxDisc3);
            pila1.Push(picBoxDisc4);
            pila1.Push(picBoxDisc5);
            pila2.Clear();
            pila3.Clear();
            contador = 0;
            lblMovimientos.Text = contador.ToString();
            #endregion
            //picBoxbarra1.Left = (panel1.Width / 2) - (picBoxbarra1.Width / 2);
            //picBoxbarra2.Left = (panel2.Width / 2) - (picBoxbarra2.Width / 2);
            //picBoxbarra3.Left = (panel3.Width / 2) - (picBoxbarra3.Width / 2);
        }
        #region Movimiento de discos
        private bool Validador(Stack<PictureBox> Origen, Stack<PictureBox> Destino, PictureBox pictureBox)
        {
            if ((Destino.Count == 0 &&
                pictureBox.Tag == Origen.Peek().Tag) || 
                (Destino.Count != 0 &&
                int.Parse(Destino.Peek().Tag.ToString()) > int.Parse(pictureBox.Tag.ToString()) &&
                Origen.Peek().Tag.ToString() == pictureBox.Tag.ToString()))
            {
                Destino.Push(Origen.Pop());
                pictureBox.Top = panel1.Height - picBoxbase1.Height - Destino.Count * pictureBox.Height;
                lblMovimientos.Text = (++contador).ToString();
                lblMovimientos.Update();
            }
            else return false;
            return true;
        }
        /// <summary>
        /// Mueve el disco y aumenta el contador en uno
        /// </summary>
        private void Mover(PictureBox pic)
        {
            origen = pic.Parent.Name; //picturebox a controlar
            pic.DoDragDrop(pic, DragDropEffects.Move); //para mover
            if (!SetPosition(pic, origen))
            {
                switch (origen)
                {
                    case "panel1": pic.Parent = panel1;
                        break;
                    case "panel2": pic.Parent = panel2;
                        break;
                    case "panel3": pic.Parent = panel3;
                        break;
                }
            }
            pic.BringToFront(); //sobreposiciona el picturebox
        }
        private bool SetPosition(PictureBox pic, string origen)
        {
            if (origen == pic.Parent.Name) return false;
            switch (pic.Parent.Name) //panel de destino y al panel que va
            {
                //la pila aun no esta cargada, usar un switch cargarla basado en el origen
                case "panel1":
                    if (origen == "panel2") return Validador(pila2, pila1, pic);
                    if (origen == "panel3") return Validador(pila3, pila1, pic);
                    break;
                case "panel2":
                    if (origen == "panel1") return Validador(pila1, pila2, pic);
                    if (origen == "panel3") return Validador(pila3, pila2, pic);
                    break;
                case "panel3":
                    if (origen == "panel1") return Validador(pila1, pila3, pic);
                    if (origen == "panel2") return Validador(pila2, pila3, pic);
                    break;
            }
            return true;
        }
        /// <summary>
        /// Mover disco al dar click en mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBoxDisc1_MouseDown(object sender, MouseEventArgs e) => Mover(picBoxDisc1);
        private void picBoxDisc2_MouseDown(object sender, MouseEventArgs e) => Mover(picBoxDisc2);
        private void picBoxDisc3_MouseDown(object sender, MouseEventArgs e) => Mover(picBoxDisc3);
        private void picBoxDisc4_MouseDown(object sender, MouseEventArgs e) => Mover(picBoxDisc4);
        private void picBoxDisc5_MouseDown(object sender, MouseEventArgs e) => Mover(picBoxDisc5);
        #endregion
        /// <summary>
        /// Mueve los picturebox en los panel con todos y las propiedades
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel_DragDrop(object sender, DragEventArgs e) => ((PictureBox)e.Data.GetData(typeof(PictureBox))).Parent = (Panel)sender;
        private void Panel_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.Move;
        private void btnSalir_Click(object sender, EventArgs e) => this.Close();
        private void linkLabelvideo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/Torres_de_Han%C3%B3i");
        private void btnReinicio_Click(object sender, EventArgs e) => FrmHanoi_Load(sender, e);
    }
}