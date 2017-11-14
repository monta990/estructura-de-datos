namespace esdat
{
    partial class FrmMaximoComunDivisor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lbMCDresultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBentero2 = new System.Windows.Forms.TextBox();
            this.tBentero1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btLimpiar);
            this.groupBox1.Controls.Add(this.btSalir);
            this.groupBox1.Controls.Add(this.btCalcular);
            this.groupBox1.Controls.Add(this.lbMCDresultado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tBentero2);
            this.groupBox1.Controls.Add(this.tBentero1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese 2 numeros enteros";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(10, 163);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 8;
            this.btLimpiar.Text = "&Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(135, 163);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 7;
            this.btSalir.Text = "&Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(135, 99);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 6;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lbMCDresultado
            // 
            this.lbMCDresultado.AutoSize = true;
            this.lbMCDresultado.Location = new System.Drawing.Point(63, 104);
            this.lbMCDresultado.Name = "lbMCDresultado";
            this.lbMCDresultado.Size = new System.Drawing.Size(13, 13);
            this.lbMCDresultado.TabIndex = 5;
            this.lbMCDresultado.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MCD =";
            // 
            // tBentero2
            // 
            this.tBentero2.Location = new System.Drawing.Point(66, 62);
            this.tBentero2.Name = "tBentero2";
            this.tBentero2.Size = new System.Drawing.Size(100, 20);
            this.tBentero2.TabIndex = 3;
            // 
            // tBentero1
            // 
            this.tBentero1.Location = new System.Drawing.Point(66, 17);
            this.tBentero1.Name = "tBentero1";
            this.tBentero1.Size = new System.Drawing.Size(100, 20);
            this.tBentero1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entero 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entero 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::esdat.Properties.Resources.MCD;
            this.pictureBox1.Location = new System.Drawing.Point(235, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMaximoComunDivisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 359);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMaximoComunDivisor";
            this.Text = "Maximo Común Divisor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lbMCDresultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBentero2;
        private System.Windows.Forms.TextBox tBentero1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btSalir;
    }
}