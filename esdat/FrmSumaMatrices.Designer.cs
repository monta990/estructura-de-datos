namespace esdat
{
    partial class FrmSumaMatrices
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
            this.dGVmatriz1 = new System.Windows.Forms.DataGridView();
            this.dGVmatriz2 = new System.Windows.Forms.DataGridView();
            this.dGVresultado = new System.Windows.Forms.DataGridView();
            this.btnIgual = new System.Windows.Forms.Button();
            this.lblMas = new System.Windows.Forms.Label();
            this.lblMatriz1 = new System.Windows.Forms.Label();
            this.lblMatriz2 = new System.Windows.Forms.Label();
            this.lblMatrizResultado = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pBsumarmatriz = new System.Windows.Forms.PictureBox();
            this.gBopciones = new System.Windows.Forms.GroupBox();
            this.btnEjemplo = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVmatriz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVmatriz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVresultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBsumarmatriz)).BeginInit();
            this.gBopciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVmatriz1
            // 
            this.dGVmatriz1.AllowUserToAddRows = false;
            this.dGVmatriz1.AllowUserToDeleteRows = false;
            this.dGVmatriz1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVmatriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVmatriz1.Location = new System.Drawing.Point(25, 47);
            this.dGVmatriz1.Name = "dGVmatriz1";
            this.dGVmatriz1.Size = new System.Drawing.Size(240, 150);
            this.dGVmatriz1.TabIndex = 0;
            this.dGVmatriz1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVmatriz1_CellValueChanged);
            // 
            // dGVmatriz2
            // 
            this.dGVmatriz2.AllowUserToAddRows = false;
            this.dGVmatriz2.AllowUserToDeleteRows = false;
            this.dGVmatriz2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVmatriz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVmatriz2.Location = new System.Drawing.Point(310, 47);
            this.dGVmatriz2.Name = "dGVmatriz2";
            this.dGVmatriz2.Size = new System.Drawing.Size(240, 150);
            this.dGVmatriz2.TabIndex = 1;
            // 
            // dGVresultado
            // 
            this.dGVresultado.AllowUserToAddRows = false;
            this.dGVresultado.AllowUserToDeleteRows = false;
            this.dGVresultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVresultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVresultado.Location = new System.Drawing.Point(605, 47);
            this.dGVresultado.Name = "dGVresultado";
            this.dGVresultado.Size = new System.Drawing.Size(240, 150);
            this.dGVresultado.TabIndex = 2;
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(556, 98);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(43, 44);
            this.btnIgual.TabIndex = 3;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // lblMas
            // 
            this.lblMas.AutoSize = true;
            this.lblMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMas.Location = new System.Drawing.Point(271, 102);
            this.lblMas.Name = "lblMas";
            this.lblMas.Size = new System.Drawing.Size(37, 37);
            this.lblMas.TabIndex = 4;
            this.lblMas.Text = "+";
            // 
            // lblMatriz1
            // 
            this.lblMatriz1.AutoSize = true;
            this.lblMatriz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatriz1.Location = new System.Drawing.Point(20, 19);
            this.lblMatriz1.Name = "lblMatriz1";
            this.lblMatriz1.Size = new System.Drawing.Size(97, 25);
            this.lblMatriz1.TabIndex = 5;
            this.lblMatriz1.Text = "Matriz 1";
            // 
            // lblMatriz2
            // 
            this.lblMatriz2.AutoSize = true;
            this.lblMatriz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatriz2.Location = new System.Drawing.Point(305, 19);
            this.lblMatriz2.Name = "lblMatriz2";
            this.lblMatriz2.Size = new System.Drawing.Size(97, 25);
            this.lblMatriz2.TabIndex = 6;
            this.lblMatriz2.Text = "Matriz 2";
            // 
            // lblMatrizResultado
            // 
            this.lblMatrizResultado.AutoSize = true;
            this.lblMatrizResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatrizResultado.Location = new System.Drawing.Point(600, 19);
            this.lblMatrizResultado.Name = "lblMatrizResultado";
            this.lblMatrizResultado.Size = new System.Drawing.Size(190, 25);
            this.lblMatrizResultado.TabIndex = 7;
            this.lblMatrizResultado.Text = "Matriz Resultado";
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(6, 19);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(228, 47);
            this.btnRandom.TabIndex = 8;
            this.btnRandom.Text = "Generar Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(6, 109);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(228, 47);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // pBsumarmatriz
            // 
            this.pBsumarmatriz.Image = global::esdat.Properties.Resources.suma_matrices;
            this.pBsumarmatriz.Location = new System.Drawing.Point(310, 233);
            this.pBsumarmatriz.Name = "pBsumarmatriz";
            this.pBsumarmatriz.Size = new System.Drawing.Size(320, 150);
            this.pBsumarmatriz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBsumarmatriz.TabIndex = 10;
            this.pBsumarmatriz.TabStop = false;
            // 
            // gBopciones
            // 
            this.gBopciones.Controls.Add(this.btnEjemplo);
            this.gBopciones.Controls.Add(this.btnRandom);
            this.gBopciones.Controls.Add(this.btnSalir);
            this.gBopciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBopciones.Location = new System.Drawing.Point(25, 214);
            this.gBopciones.Name = "gBopciones";
            this.gBopciones.Size = new System.Drawing.Size(240, 173);
            this.gBopciones.TabIndex = 11;
            this.gBopciones.TabStop = false;
            this.gBopciones.Text = "Opciones";
            // 
            // btnEjemplo
            // 
            this.btnEjemplo.Location = new System.Drawing.Point(6, 73);
            this.btnEjemplo.Name = "btnEjemplo";
            this.btnEjemplo.Size = new System.Drawing.Size(228, 30);
            this.btnEjemplo.TabIndex = 10;
            this.btnEjemplo.Text = "Ejemplo";
            this.btnEjemplo.UseVisualStyleBackColor = true;
            this.btnEjemplo.Click += new System.EventHandler(this.btnEjemplo_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(310, 214);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(252, 16);
            this.lblSuma.TabIndex = 12;
            this.lblSuma.Text = "Como resolver la suma de matrices";
            // 
            // FrmSumaMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 399);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.gBopciones);
            this.Controls.Add(this.pBsumarmatriz);
            this.Controls.Add(this.lblMatrizResultado);
            this.Controls.Add(this.lblMatriz2);
            this.Controls.Add(this.lblMatriz1);
            this.Controls.Add(this.lblMas);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.dGVresultado);
            this.Controls.Add(this.dGVmatriz2);
            this.Controls.Add(this.dGVmatriz1);
            this.Name = "FrmSumaMatrices";
            this.Text = "Suma de Matrices";
            this.Load += new System.EventHandler(this.FrmSumaMatrices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVmatriz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVmatriz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVresultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBsumarmatriz)).EndInit();
            this.gBopciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVmatriz1;
        private System.Windows.Forms.DataGridView dGVmatriz2;
        private System.Windows.Forms.DataGridView dGVresultado;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Label lblMas;
        private System.Windows.Forms.Label lblMatriz1;
        private System.Windows.Forms.Label lblMatriz2;
        private System.Windows.Forms.Label lblMatrizResultado;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pBsumarmatriz;
        private System.Windows.Forms.GroupBox gBopciones;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Button btnEjemplo;
    }
}