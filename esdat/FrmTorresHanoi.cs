using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
namespace esdat
{
    public partial class FrmTorresHanoi : Form
    {
        private int contador = 0;
        private string origen = "";
        private Stack<PictureBox> pila1 = new Stack<PictureBox>();
        private Stack<PictureBox> pila2 = new Stack<PictureBox>();
        private Stack<PictureBox> pila3 = new Stack<PictureBox>();
        public FrmTorresHanoi()
        {
            InitializeComponent();
            foreach (Panel item in this.Controls.OfType<Panel>()) // rrecorre los controles dentro de la clase panel
            {
                // añade el metodo panel_dragenter y drop
                // asigna valo true
                item.AllowDrop = true;
                item.DragEnter += Panel_DragEnter;
                item.DragDrop += Panel_DragDrop;
            }
            //invoca el metodo mousemove y  añade el metodo mousedown
            D1.MouseMove += D1_MouseDown;
            D2.MouseMove += D2_MouseDown;
            D3.MouseMove += D3_MouseDown;
            D4.MouseMove += D4_MouseDown;
            D5.MouseMove += D5_MouseDown;
        }
        #region mousedown
        private void Mover(PictureBox pic)
        {
            // inicia el movimiento de arrastrar y colocar
            // dropeffect  especifica los posibles movimientos de arrastre y colcar
            origen = pic.Parent.Name;
            pic.DoDragDrop(pic, DragDropEffects.Move);
            if(!SetPosition(pic, origen))
            {
                switch (origen)
                {
                    case "panel1":  pic.Parent = panel1;
                        break;
                    case "panel2":  pic.Parent = panel2;
                        break;
                    case "panel3":  pic.Parent = panel3;
                        break;
                }
            }
            pic.BringToFront();
            //LbTotal.Text = contador++.ToString();
        }
        private bool SetPosition(PictureBox pic,string origen)
        {
            if (origen == pic.Parent.Name) return false;
            switch (pic.Parent.Name)
            {
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
        private void D1_MouseDown(object sender, MouseEventArgs e) => Mover(D1);
        private void D2_MouseDown(object sender, MouseEventArgs e) => Mover(D2);
        private void D3_MouseDown(object sender, MouseEventArgs e) => Mover(D3);
        private void D4_MouseDown(object sender, MouseEventArgs e) => Mover(D4);
        private void D5_MouseDown(object sender, MouseEventArgs e) => Mover(D5);
        #endregion
        private void Panel_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.Move;
        private void Panel_DragDrop(object sender, DragEventArgs e) => ((PictureBox)e.Data.GetData(typeof(PictureBox))).Parent = (Panel)sender;
        private void Torres_Load(object sender, EventArgs e)
        {
            // a los discos se les asigna el panel 1 y se invoca el metodo bingtofront  coloca enfrete de todo
            D1.Parent = panel1;
            D2.Parent = panel1;
            D3.Parent = panel1;
            D4.Parent = panel1;
            D5.Parent = panel1;
            D1.Top = panel1.Height - D1.Height - 0 * D1.Height - PicBase1.Height;
            D2.Top = panel1.Height - D2.Height - 1 * D2.Height - PicBase1.Height;
            D3.Top = panel1.Height - D3.Height - 2 * D3.Height - PicBase1.Height;
            D4.Top = panel1.Height - D4.Height - 3 * D4.Height - PicBase1.Height;
            D5.Top = panel1.Height - D5.Height - 4 * D5.Height - PicBase1.Height;
            D1.BringToFront();
            D2.BringToFront();
            D3.BringToFront();
            D4.BringToFront();
            D5.BringToFront();
            pila1.Clear();
            pila1.Push(D1);
            pila1.Push(D2);
            pila1.Push(D3);
            pila1.Push(D4);
            pila1.Push(D5);
            pila2.Clear();
            pila3.Clear();
            contador = 0;
            LbTotal.Text = "0";
        }
        private void btnSolucion_Click(object sender, EventArgs e)
        {
            Torres_Load(sender, e);
            Resolver(pila1 ,pila2, D5, panel2);
            Resolver(pila1, pila3, D4, panel3);
            Resolver(pila2, pila3, D5, panel3);
            Resolver(pila1, pila2, D3, panel2);//4
            Resolver(pila3, pila1, D5, panel1);
            Resolver(pila3, pila2, D4, panel2);
            Resolver(pila1, pila2, D5, panel2);
            Resolver(pila1, pila3, D2, panel3);
            Resolver(pila2, pila1, D5, panel1);
            Resolver(pila1, pila3, D5, panel3);
            Resolver(pila2, pila1, D4, panel1);
            Resolver(pila3, pila1, D5, panel1);
            Resolver(pila2, pila3, D3, panel3);
            Resolver(pila1, pila2, D5, panel2);
            Resolver(pila1, pila3, D4, panel3);
            Resolver(pila2, pila3, D5, panel3);
            Resolver(pila3, pila1, D5, panel1);
            Resolver(pila3, pila2, D4, panel2);
            Resolver(pila1, pila2, D5, panel2);
            Resolver(pila2, pila1, D5, panel1);
            Resolver(pila1, pila3, D5, panel3);
            Resolver(pila2, pila1, D4, panel1);
            Resolver(pila3, pila1, D5, panel1);
            Resolver(pila3, pila2, D3, panel2);
            Resolver(pila1, pila3, D5, panel3);
            Resolver(pila1, pila2, D4, panel2);
            Resolver(pila3, pila1, D5, panel1);
            Resolver(pila2, pila3, D4, panel3);
            Resolver(pila1, pila3, D5, panel3);
            Resolver(pila2, pila1, D3, panel1);
            Resolver(pila3, pila2, D5, panel2);
            Resolver(pila3, pila1, D4, panel1);
            Resolver(pila2, pila1, D5, panel1);
            Resolver(pila3, pila2, D2, panel2);
            Resolver(pila1, pila2, D5, panel2);
            Resolver(pila1, pila3, D4, panel3);
            Resolver(pila2, pila3, D5, panel3);
            Resolver(pila1, pila2, D3, panel2);
            Resolver(pila3, pila1, D5, panel1);
            Resolver(pila3, pila2, D4, panel2);
            Resolver(pila3, pila1, D5, panel1);
            Resolver(pila1, pila2, D5, panel2);
            Resolver(pila1, pila3, D1, panel3);
            Resolver(pila2, pila3, D5, panel3);
            Resolver(pila2, pila1, D4, panel1);
            Resolver(pila3, pila1, D5, panel1);
            Resolver(pila2, pila3, D3, panel3);
            Resolver(pila1, pila3, D5, panel3);
            Resolver(pila1, pila2, D4, panel2); //
            Resolver(pila3, pila2, D5, panel2);
            Resolver(pila3, pila1, D3, panel1);
            Resolver(pila2, pila3, D5, panel3);
            Resolver(pila2, pila1, D4, panel1);
            Resolver(pila3, pila1, D5, panel1);
            Resolver(pila2, pila3, D2, panel3); //
            Resolver(pila1, pila3, D5, panel3);
            Resolver(pila1, pila2, D4, panel2);
            Resolver(pila3, pila2, D5, panel2);
            Resolver(pila1, pila3, D3, panel3); //
            Resolver(pila2, pila1, D5, panel1);
            Resolver(pila2, pila3, D4, panel3);
            Resolver(pila1, pila3, D5, panel3);
        }
        private void btnReinicio_Click(object sender, EventArgs e) => Torres_Load(sender, e);
        private bool Validador(Stack<PictureBox> Origen, Stack<PictureBox> Destino,PictureBox pictureBox)
        {
            if ((Destino.Count == 0 && pictureBox.Tag == Origen.Peek().Tag) || (Destino.Count != 0 && int.Parse(Destino.Peek().Tag.ToString())
                > int.Parse(pictureBox.Tag.ToString()) && Origen.Peek().Tag == pictureBox.Tag))
            {
                Destino.Push(Origen.Pop());
                pictureBox.Top = panel1.Height - pictureBox.Height - Destino.Count * pictureBox.Height;
                LbTotal.Text = (++contador).ToString();
                LbTotal.Update();
            }
            else return false;
            return true;
        }
        private void Resolver(Stack<PictureBox> pila1,Stack<PictureBox>pila2,PictureBox pictureBox,Panel panel)
        {
            Validador(pila1,pila2,pictureBox);
            pictureBox.Parent = panel;
            panel1.Update();
            panel2.Update();
            panel3.Update();
            pictureBox.BringToFront();
            pictureBox.Update();
            Thread.Sleep(500);
        }
        private void btnSalir_Click(object sender, EventArgs e) => this.Close();
    }
}