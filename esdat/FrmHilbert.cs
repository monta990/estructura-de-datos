using System;
using System.Drawing;
using System.Windows.Forms;
namespace esdat
{
    public partial class FrmHilbert : Form
    {
        public FrmHilbert() => InitializeComponent();
        private bool DoRefresh;
        private float LastX, LastY;
        private Bitmap HilbertImage;
        private void Guardar()
        {
            if (picCanvas.Image == null) //vei
            {
                MessageBox.Show("No hay imagen que guardar", "Sin Imagen que guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveFileDialog Imagen = new SaveFileDialog();
                Imagen.Filter = "Archivo de Imagen (*.jpg)|*.jpg";
                if (Imagen.ShowDialog() == DialogResult.OK)
                {
                    picCanvas.Image.Save(Imagen.FileName);
                    System.Diagnostics.Process.Start(Imagen.FileName); //abrimos imagen con el visor default de windows
                }
            }
        }
        private void Dibujar()
        {
            int depth = int.Parse(cbDepth.Text);
            if (depth >= 8)
            {
                if (MessageBox.Show("A mayor profundidad el tiempo de dibujado sera mayor (y sera todo casi de color negro). Continuar?",
                    "Tiempo de dibujado alto", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            // See if we should refresh as we draw.
            DoRefresh = chkRefresh.Checked;
            // Get the parameters.
            float total_length, start_x, start_y, start_length;
            // See how big we can make the curve.
            if (picCanvas.ClientSize.Height < picCanvas.ClientSize.Width)
            {
                total_length = (float)(0.9 * picCanvas.ClientSize.Height);
            }
            else
            {
                total_length = (float)(0.9 * picCanvas.ClientSize.Width);
            }
            start_x = (picCanvas.ClientSize.Width - total_length) / 2;
            start_y = (picCanvas.ClientSize.Height - total_length) / 2;
            // Compute the side length for this level.
            start_length = (float)(total_length / (Math.Pow(2, depth) - 1));
            HilbertImage = new Bitmap(picCanvas.ClientSize.Width, picCanvas.ClientSize.Height);
            picCanvas.Image = HilbertImage;
            using (Graphics gr = Graphics.FromImage(HilbertImage))
            {
                // Draw the curve.
                gr.Clear(picCanvas.BackColor);
                LastX = (int)start_x;
                LastY = (int)start_y;
                Hilbert(gr, depth, start_length, 0);
            }
            // Display the result.
            picCanvas.Refresh();
            this.Cursor = Cursors.Default;
        }
        private void btnGo_Click(object sender, EventArgs e) => Dibujar(); //se llama al metodo de dibujar
        // Draw a Hilbert curve.
        private void Hilbert(Graphics gr, int depth, float dx, float dy)
        {
            if (depth > 1) Hilbert(gr, depth - 1, dy, dx);
            DrawRelative(gr, dx, dy);
            if (depth > 1) Hilbert(gr, depth - 1, dx, dy);
            DrawRelative(gr, dy, dx);
            if (depth > 1) Hilbert(gr, depth - 1, dx, dy);
            DrawRelative(gr, -dx, -dy);
            if (depth > 1) Hilbert(gr, depth - 1, -dy, -dx);
            if (DoRefresh) picCanvas.Refresh();
        }
        private void btSalir_Click(object sender, EventArgs e) => this.Close();
        private void btGuardar_Click(object sender, EventArgs e) => Guardar();
        private void FrmHilbert_Load(object sender, EventArgs e) => cbDepth.Text = cbDepth.Items[3].ToString(); //empezando con 4
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/Curva_de_Hilbert");
        // Draw the line (LastX, LastY)-(LastX + dx, LastY + dy) and
        // update LastX = LastX + dx, LastY = LastY + dy.
        private void DrawRelative(Graphics gr, float dx, float dy)
        {
            gr.DrawLine(Pens.Black, LastX, LastY, LastX + dx, LastY + dy);
            LastX = LastX + dx;
            LastY = LastY + dy;
        }
    }
}