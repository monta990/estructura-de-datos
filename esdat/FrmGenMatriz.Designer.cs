namespace esdat
{
    partial class FrmGenMatriz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBdatos = new System.Windows.Forms.GroupBox();
            this.lblColumnas = new System.Windows.Forms.Label();
            this.lblRenglones = new System.Windows.Forms.Label();
            this.tBcolumnas = new System.Windows.Forms.TextBox();
            this.tBrenglones = new System.Windows.Forms.TextBox();
            this.Generar = new System.Windows.Forms.Button();
            this.gBdatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBdatos
            // 
            this.gBdatos.Controls.Add(this.tBrenglones);
            this.gBdatos.Controls.Add(this.tBcolumnas);
            this.gBdatos.Controls.Add(this.lblRenglones);
            this.gBdatos.Controls.Add(this.lblColumnas);
            this.gBdatos.Location = new System.Drawing.Point(12, 12);
            this.gBdatos.Name = "gBdatos";
            this.gBdatos.Size = new System.Drawing.Size(260, 124);
            this.gBdatos.TabIndex = 0;
            this.gBdatos.TabStop = false;
            this.gBdatos.Text = "Ingresa columnas y renglones";
            // 
            // lblColumnas
            // 
            this.lblColumnas.AutoSize = true;
            this.lblColumnas.Location = new System.Drawing.Point(7, 20);
            this.lblColumnas.Name = "lblColumnas";
            this.lblColumnas.Size = new System.Drawing.Size(53, 13);
            this.lblColumnas.TabIndex = 0;
            this.lblColumnas.Text = "Columnas";
            // 
            // lblRenglones
            // 
            this.lblRenglones.AutoSize = true;
            this.lblRenglones.Location = new System.Drawing.Point(7, 71);
            this.lblRenglones.Name = "lblRenglones";
            this.lblRenglones.Size = new System.Drawing.Size(58, 13);
            this.lblRenglones.TabIndex = 1;
            this.lblRenglones.Text = "Renglones";
            // 
            // tBcolumnas
            // 
            this.tBcolumnas.Location = new System.Drawing.Point(10, 37);
            this.tBcolumnas.Name = "tBcolumnas";
            this.tBcolumnas.Size = new System.Drawing.Size(244, 20);
            this.tBcolumnas.TabIndex = 2;
            this.tBcolumnas.Text = "3";
            // 
            // tBrenglones
            // 
            this.tBrenglones.Location = new System.Drawing.Point(10, 88);
            this.tBrenglones.Name = "tBrenglones";
            this.tBrenglones.Size = new System.Drawing.Size(244, 20);
            this.tBrenglones.TabIndex = 3;
            this.tBrenglones.Text = "3";
            // 
            // Generar
            // 
            this.Generar.Location = new System.Drawing.Point(104, 142);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(75, 23);
            this.Generar.TabIndex = 1;
            this.Generar.Text = "Generar";
            this.Generar.UseVisualStyleBackColor = true;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // FrmGenMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.gBdatos);
            this.Name = "FrmGenMatriz";
            this.Text = "Suma de matrices";
            this.gBdatos.ResumeLayout(false);
            this.gBdatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBdatos;
        private System.Windows.Forms.TextBox tBrenglones;
        private System.Windows.Forms.TextBox tBcolumnas;
        private System.Windows.Forms.Label lblRenglones;
        private System.Windows.Forms.Label lblColumnas;
        private System.Windows.Forms.Button Generar;
    }
}