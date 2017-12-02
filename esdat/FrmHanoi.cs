using System;
using System.Collections.Generic;
using System.Linq;
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
        }
        /// <summary>
        /// Autosolve
        /// </summary>
        private void Resolver(Stack<PictureBox> Pila1, Stack<PictureBox> Pila2, PictureBox pictureBox, Panel panel)
        {
                Validador(pila1, Pila2, pictureBox);
                pictureBox.Parent = panel;
                panel1.Update();
                panel2.Update();
                panel3.Update();
                pictureBox.BringToFront();
                pictureBox.Update();
                Thread.Sleep(500); //espacio entre movimientos
            //if (Validador(pila1, Pila2, pictureBox))
            //{
            //    pictureBox.Parent = panel;
            //    panel1.Update();
            //    panel2.Update();
            //    panel3.Update();
            //    pictureBox.BringToFront();
            //    pictureBox.Update();
            //    Thread.Sleep(500); //espacio entre movimientos
            //}
        }
        #region Movimiento de discos
        private bool Validador(Stack<PictureBox> Origen, Stack<PictureBox> Destino, PictureBox pictureBox)
        {
            if (
                (Destino.Count == 0 && pictureBox.Tag == Origen.Peek().Tag)

                ||

                (Destino.Count != 0 &&
                int.Parse(Destino.Peek().Tag.ToString()) > int.Parse(pictureBox.Tag.ToString()) &&
                pictureBox.Tag.ToString() == Origen.Peek().Tag.ToString()
                )
                )
            {
                Destino.Push(Origen.Pop());
                pictureBox.Top = panel1.Height - pictureBox.Height - Destino.Count * pictureBox.Height;
                lblMovimientos.Text = (++contador).ToString();
                lblMovimientos.Update();
                return true;
            }
            else return false;

            //Destino.Push(Origen.Pop());
            //pictureBox.Top = panel1.Height - picBoxbase1.Height - Destino.Count * pictureBox.Height;
            //lblMovimientos.Text = (++contador).ToString();
            //lblMovimientos.Update();
            //return true;

            //if ((Destino.Count == 0 && pictureBox.Tag == Origen.Peek().Tag))
            //{
            //    Destino.Push(Origen.Pop());
            //    pictureBox.Top = panel1.Height - picBoxbase1.Height - Destino.Count * pictureBox.Height;
            //    lblMovimientos.Text = (++contador).ToString();
            //    lblMovimientos.Update();
            //    return true;
            //}
            //else if (Destino.Count != 0 && int.Parse(Destino.Peek().Tag.ToString()) > int.Parse(pictureBox.Tag.ToString()) && pictureBox.Tag.ToString() == Origen.Peek().Tag.ToString())
            //{
            //    Destino.Push(Origen.Pop());
            //    pictureBox.Top = panel1.Height - picBoxbase1.Height - Destino.Count * pictureBox.Height;
            //    lblMovimientos.Text = (++contador).ToString();
            //    lblMovimientos.Update();
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
    //        if ((Destino.Count == 0 && pictureBox.Tag == Origen.Peek().Tag) || (Destino.Count != 0 && int.Parse(Destino.Peek().Tag.ToString())
    //> int.Parse(pictureBox.Tag.ToString()) && Origen.Peek().Tag == pictureBox.Tag))
    //        {
    //            Destino.Push(Origen.Pop());
    //            pictureBox.Top = panel1.Height - picBoxbase1.Height - Destino.Count * pictureBox.Height;
    //            lblMovimientos.Text = (++contador).ToString();
    //            lblMovimientos.Update();
    //        }
            //else return false;
            return true;

        }
        /// <summary>
        /// Mueve el disco y aumenta el contador en uno
        /// </summary>
        private void Mover(PictureBox pic)
        {
            origen = pic.Parent.Name.ToString(); //picturebox a controlar
            pic.DoDragDrop(pic, DragDropEffects.Move); //para mover
            if (!SetPosition(pic, origen))
            {
                switch (origen)
                {
                    case "panel1": pic.Parent = panel1; break;
                    case "panel2": pic.Parent = panel2; break;
                    case "panel3": pic.Parent = panel3; break;
                }
            }
            pic.BringToFront(); //sobreposiciona el picturebox
        }
        private bool SetPosition(PictureBox pic, string origen)
        {
            //if (origen == pic.Parent.Name) return false;
            switch (pic.Parent.Name.ToString()) //panel de destino y al panel que va
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
        private void btnSolucion_Click(object sender, EventArgs e)
        {
            FrmHanoi_Load(sender, e);
            //Resolver(pila1, pila2, picBoxDisc5, panel2);
            //Resolver(pila1, pila3, picBoxDisc4, panel3);
            //Resolver(pila2, pila3, picBoxDisc5, panel3);
            //Resolver(pila1, pila2, picBoxDisc3, panel2);//4
            //Resolver(pila3, pila1, picBoxDisc5, panel1);
            //Resolver(pila3, pila2, picBoxDisc4, panel2);
            //Resolver(pila1, pila2, picBoxDisc5, panel2);
            //Resolver(pila1, pila3, picBoxDisc2, panel3);
            //Resolver(pila2, pila1, picBoxDisc5, panel1);
            //Resolver(pila1, pila3, picBoxDisc5, panel3);
            //Resolver(pila2, pila1, picBoxDisc4, panel1);
            //Resolver(pila3, pila1, picBoxDisc5, panel1);
            //Resolver(pila2, pila3, picBoxDisc3, panel3);
            //Resolver(pila1, pila2, picBoxDisc5, panel2);
            //Resolver(pila1, pila3, picBoxDisc4, panel3);
            //Resolver(pila2, pila3, picBoxDisc5, panel3);
            //Resolver(pila3, pila1, picBoxDisc5, panel1);
            //Resolver(pila3, pila2, picBoxDisc4, panel2);
            //Resolver(pila1, pila2, picBoxDisc5, panel2);
            //Resolver(pila2, pila1, picBoxDisc5, panel1);
            //Resolver(pila1, pila3, picBoxDisc5, panel3);
            //Resolver(pila2, pila1, picBoxDisc4, panel1);
            //Resolver(pila3, pila1, picBoxDisc5, panel1);
            //Resolver(pila3, pila2, picBoxDisc3, panel2);
            //Resolver(pila1, pila3, picBoxDisc5, panel3);
            //Resolver(pila1, pila2, picBoxDisc4, panel2);
            //Resolver(pila3, pila1, picBoxDisc5, panel1);
            //Resolver(pila2, pila3, picBoxDisc4, panel3);
            //Resolver(pila1, pila3, picBoxDisc5, panel3);
            //Resolver(pila2, pila1, picBoxDisc3, panel1);
            //Resolver(pila3, pila2, picBoxDisc5, panel2);
            //Resolver(pila3, pila1, picBoxDisc4, panel1);
            //Resolver(pila2, pila1, picBoxDisc5, panel1);
            //Resolver(pila3, pila2, picBoxDisc2, panel2);
            //Resolver(pila1, pila2, picBoxDisc5, panel2);
            //Resolver(pila1, pila3, picBoxDisc4, panel3);
            //Resolver(pila2, pila3, picBoxDisc5, panel3);
            //Resolver(pila1, pila2, picBoxDisc3, panel2);
            //Resolver(pila3, pila1, picBoxDisc5, panel1);
            //Resolver(pila3, pila2, picBoxDisc4, panel2);
            //Resolver(pila3, pila1, 5, panel1);
            //Resolver(pila1, pila2, 5, panel2);
            //Resolver(pila1, pila3, 1, panel3);
            //Resolver(pila2, pila3, 5, panel3);
            //Resolver(pila2, pila1, 4, panel1);
            //Resolver(pila3, pila1, 5, panel1);
            //Resolver(pila2, pila3, 3, panel3);
            //Resolver(pila1, pila3, 5, panel3);
            //Resolver(pila1, pila2, 4, panel2);

            //Resolver(pila3, pila2, 5, panel2);
            //Resolver(pila3, pila1, 3, panel1);
            //Resolver(pila2, pila3, D5, panel3);
            //Resolver(pila2, pila1, D4, panel1);
            //Resolver(pila3, pila1, D5, panel1);
            //Resolver(pila2, pila3, D2, panel3);

            //Resolver(pila1, pila3, picBoxDisc5, panel3);
            //Resolver(pila1, pila2, picBoxDisc4, panel2);
            //Resolver(pila3, pila2, picBoxDisc5, panel2);

            //Resolver(pila1, pila3, picBoxDisc3, panel3);
            //Resolver(pila2, pila1, picBoxDisc5, panel1);
            //Resolver(pila2, pila3, picBoxDisc4, panel3);
            //Resolver(pila1, pila3, picBoxDisc5, panel3);

            Resolver(this.pila1, this.pila2, this.picBoxDisc5, this.panel2); //1
            Resolver(this.pila2, this.pila3, this.picBoxDisc5, this.panel3);
            Resolver(this.pila1, this.pila2, this.picBoxDisc5, this.panel2);
            Resolver(this.pila1, this.pila3, this.picBoxDisc4, this.panel3); //2
            Resolver(this.pila2, this.pila1, this.picBoxDisc5, this.panel1);
            Resolver(this.pila1, this.pila3, this.picBoxDisc5, this.panel3);
            Resolver(this.pila3, this.pila2, this.picBoxDisc4, this.panel2);
            Resolver(this.pila3, this.pila2, this.picBoxDisc5, this.panel2);
            //Resolver(this.pila1, this.pila2, this.picBoxDisc3, this.panel2);
            //MessageBox.Show("Pila 3 antes de paso 3: " + pila3.Count.ToString());
            //MessageBox.Show("Pila 2 antes de paso 3: " + pila2.Count.ToString());
            //Resolver(this.pila2, this.pila3, this.picBoxDisc5, this.panel3); //3

            //MessageBox.Show("Pila 2: " + pila2.Count.ToString());
            //MessageBox.Show("Pila 3: " + pila3.Count.ToString());
            //MessageBox.Show("Pila 1: " + pila1.Count.ToString());
            //Resolver(this.pila1, this.pila2, this.picBoxDisc3, this.panel2); //4
            //Resolver(pila3, pila1, picBoxDisc5, panel1); //5
            //Resolver(pila3, pila2, picBoxDisc4, panel2); //6
            //Resolver(pila1, pila2, picBoxDisc5, panel2); //7
            //Resolver(pila1, pila3, picBoxDisc2, panel3); //8
            //Resolver(pila2, pila1, picBoxDisc5, panel2); //9
            //Resolver(pila2, pila3, picBoxDisc4, panel3); //10
            //Resolver(pila1, pila3, picBoxDisc5, panel3); //11
        }
    }
}