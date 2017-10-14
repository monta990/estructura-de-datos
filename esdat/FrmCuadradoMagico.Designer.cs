namespace esdat
{
    partial class FrmCuadradoMagico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGVcuadradoMagico = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEjemplo1 = new System.Windows.Forms.Button();
            this.btEjemplo2 = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lbDiagonal1 = new System.Windows.Forms.Label();
            this.lbDiagonal2 = new System.Windows.Forms.Label();
            this.lbColumna1 = new System.Windows.Forms.Label();
            this.lbColumna2 = new System.Windows.Forms.Label();
            this.lbColumna3 = new System.Windows.Forms.Label();
            this.lbColumna4 = new System.Windows.Forms.Label();
            this.lbRenglon1 = new System.Windows.Forms.Label();
            this.lbRenglon2 = new System.Windows.Forms.Label();
            this.lbRenglon3 = new System.Windows.Forms.Label();
            this.lbRenglon4 = new System.Windows.Forms.Label();
            this.pBcuadradomagico = new System.Windows.Forms.PictureBox();
            this.gBcuadradoMagico = new System.Windows.Forms.GroupBox();
            this.gBopciones = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVcuadradoMagico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBcuadradomagico)).BeginInit();
            this.gBcuadradoMagico.SuspendLayout();
            this.gBopciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVcuadradoMagico
            // 
            this.dGVcuadradoMagico.AllowUserToAddRows = false;
            this.dGVcuadradoMagico.AllowUserToDeleteRows = false;
            this.dGVcuadradoMagico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVcuadradoMagico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVcuadradoMagico.ColumnHeadersVisible = false;
            this.dGVcuadradoMagico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dGVcuadradoMagico.Location = new System.Drawing.Point(6, 39);
            this.dGVcuadradoMagico.Name = "dGVcuadradoMagico";
            this.dGVcuadradoMagico.RowHeadersVisible = false;
            this.dGVcuadradoMagico.Size = new System.Drawing.Size(203, 91);
            this.dGVcuadradoMagico.TabIndex = 0;
            this.dGVcuadradoMagico.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVcuadradoMagico_CellLeave);
            // 
            // Column1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // btEjemplo1
            // 
            this.btEjemplo1.Location = new System.Drawing.Point(51, 19);
            this.btEjemplo1.Name = "btEjemplo1";
            this.btEjemplo1.Size = new System.Drawing.Size(75, 23);
            this.btEjemplo1.TabIndex = 1;
            this.btEjemplo1.Text = "Ejemplo 1";
            this.btEjemplo1.UseVisualStyleBackColor = true;
            this.btEjemplo1.Click += new System.EventHandler(this.btEjemplo1_Click);
            // 
            // btEjemplo2
            // 
            this.btEjemplo2.Location = new System.Drawing.Point(132, 19);
            this.btEjemplo2.Name = "btEjemplo2";
            this.btEjemplo2.Size = new System.Drawing.Size(75, 23);
            this.btEjemplo2.TabIndex = 2;
            this.btEjemplo2.Text = "Ejemplo 2";
            this.btEjemplo2.UseVisualStyleBackColor = true;
            this.btEjemplo2.Click += new System.EventHandler(this.btEjemplo2_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(51, 57);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 3;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(132, 57);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 4;
            this.btCalcular.Text = "&Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lbDiagonal1
            // 
            this.lbDiagonal1.AutoSize = true;
            this.lbDiagonal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiagonal1.Location = new System.Drawing.Point(215, 130);
            this.lbDiagonal1.Name = "lbDiagonal1";
            this.lbDiagonal1.Size = new System.Drawing.Size(19, 20);
            this.lbDiagonal1.TabIndex = 5;
            this.lbDiagonal1.Text = "0";
            // 
            // lbDiagonal2
            // 
            this.lbDiagonal2.AutoSize = true;
            this.lbDiagonal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiagonal2.Location = new System.Drawing.Point(215, 19);
            this.lbDiagonal2.Name = "lbDiagonal2";
            this.lbDiagonal2.Size = new System.Drawing.Size(19, 20);
            this.lbDiagonal2.TabIndex = 6;
            this.lbDiagonal2.Text = "0";
            // 
            // lbColumna1
            // 
            this.lbColumna1.AutoSize = true;
            this.lbColumna1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColumna1.Location = new System.Drawing.Point(27, 130);
            this.lbColumna1.Name = "lbColumna1";
            this.lbColumna1.Size = new System.Drawing.Size(19, 20);
            this.lbColumna1.TabIndex = 7;
            this.lbColumna1.Text = "0";
            // 
            // lbColumna2
            // 
            this.lbColumna2.AutoSize = true;
            this.lbColumna2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColumna2.Location = new System.Drawing.Point(74, 130);
            this.lbColumna2.Name = "lbColumna2";
            this.lbColumna2.Size = new System.Drawing.Size(19, 20);
            this.lbColumna2.TabIndex = 8;
            this.lbColumna2.Text = "0";
            // 
            // lbColumna3
            // 
            this.lbColumna3.AutoSize = true;
            this.lbColumna3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColumna3.Location = new System.Drawing.Point(122, 131);
            this.lbColumna3.Name = "lbColumna3";
            this.lbColumna3.Size = new System.Drawing.Size(19, 20);
            this.lbColumna3.TabIndex = 9;
            this.lbColumna3.Text = "0";
            // 
            // lbColumna4
            // 
            this.lbColumna4.AutoSize = true;
            this.lbColumna4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColumna4.Location = new System.Drawing.Point(175, 130);
            this.lbColumna4.Name = "lbColumna4";
            this.lbColumna4.Size = new System.Drawing.Size(19, 20);
            this.lbColumna4.TabIndex = 10;
            this.lbColumna4.Text = "0";
            // 
            // lbRenglon1
            // 
            this.lbRenglon1.AutoSize = true;
            this.lbRenglon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRenglon1.Location = new System.Drawing.Point(215, 40);
            this.lbRenglon1.Name = "lbRenglon1";
            this.lbRenglon1.Size = new System.Drawing.Size(19, 20);
            this.lbRenglon1.TabIndex = 11;
            this.lbRenglon1.Text = "0";
            // 
            // lbRenglon2
            // 
            this.lbRenglon2.AutoSize = true;
            this.lbRenglon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRenglon2.Location = new System.Drawing.Point(215, 62);
            this.lbRenglon2.Name = "lbRenglon2";
            this.lbRenglon2.Size = new System.Drawing.Size(19, 20);
            this.lbRenglon2.TabIndex = 12;
            this.lbRenglon2.Text = "0";
            // 
            // lbRenglon3
            // 
            this.lbRenglon3.AutoSize = true;
            this.lbRenglon3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRenglon3.Location = new System.Drawing.Point(215, 85);
            this.lbRenglon3.Name = "lbRenglon3";
            this.lbRenglon3.Size = new System.Drawing.Size(19, 20);
            this.lbRenglon3.TabIndex = 13;
            this.lbRenglon3.Text = "0";
            // 
            // lbRenglon4
            // 
            this.lbRenglon4.AutoSize = true;
            this.lbRenglon4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRenglon4.Location = new System.Drawing.Point(215, 110);
            this.lbRenglon4.Name = "lbRenglon4";
            this.lbRenglon4.Size = new System.Drawing.Size(19, 20);
            this.lbRenglon4.TabIndex = 14;
            this.lbRenglon4.Text = "0";
            // 
            // pBcuadradomagico
            // 
            this.pBcuadradomagico.Image = global::esdat.Properties.Resources.cuadradomagico;
            this.pBcuadradomagico.Location = new System.Drawing.Point(280, 29);
            this.pBcuadradomagico.Name = "pBcuadradomagico";
            this.pBcuadradomagico.Size = new System.Drawing.Size(305, 265);
            this.pBcuadradomagico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBcuadradomagico.TabIndex = 15;
            this.pBcuadradomagico.TabStop = false;
            // 
            // gBcuadradoMagico
            // 
            this.gBcuadradoMagico.Controls.Add(this.dGVcuadradoMagico);
            this.gBcuadradoMagico.Controls.Add(this.lbDiagonal1);
            this.gBcuadradoMagico.Controls.Add(this.lbRenglon4);
            this.gBcuadradoMagico.Controls.Add(this.lbDiagonal2);
            this.gBcuadradoMagico.Controls.Add(this.lbRenglon3);
            this.gBcuadradoMagico.Controls.Add(this.lbColumna1);
            this.gBcuadradoMagico.Controls.Add(this.lbRenglon2);
            this.gBcuadradoMagico.Controls.Add(this.lbColumna2);
            this.gBcuadradoMagico.Controls.Add(this.lbRenglon1);
            this.gBcuadradoMagico.Controls.Add(this.lbColumna3);
            this.gBcuadradoMagico.Controls.Add(this.lbColumna4);
            this.gBcuadradoMagico.Location = new System.Drawing.Point(12, 12);
            this.gBcuadradoMagico.Name = "gBcuadradoMagico";
            this.gBcuadradoMagico.Size = new System.Drawing.Size(262, 195);
            this.gBcuadradoMagico.TabIndex = 16;
            this.gBcuadradoMagico.TabStop = false;
            this.gBcuadradoMagico.Text = "Cuadrado Mágico";
            // 
            // gBopciones
            // 
            this.gBopciones.Controls.Add(this.btEjemplo1);
            this.gBopciones.Controls.Add(this.btEjemplo2);
            this.gBopciones.Controls.Add(this.btLimpiar);
            this.gBopciones.Controls.Add(this.btCalcular);
            this.gBopciones.Location = new System.Drawing.Point(13, 214);
            this.gBopciones.Name = "gBopciones";
            this.gBopciones.Size = new System.Drawing.Size(261, 91);
            this.gBopciones.TabIndex = 17;
            this.gBopciones.TabStop = false;
            this.gBopciones.Text = "Opciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Como resolver un cuadrado mágio";
            // 
            // FrmCuadradoMagico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gBopciones);
            this.Controls.Add(this.gBcuadradoMagico);
            this.Controls.Add(this.pBcuadradomagico);
            this.Name = "FrmCuadradoMagico";
            this.Text = "Cuadrado Mágico";
            this.Load += new System.EventHandler(this.FrmCuadradoMagico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVcuadradoMagico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBcuadradomagico)).EndInit();
            this.gBcuadradoMagico.ResumeLayout(false);
            this.gBcuadradoMagico.PerformLayout();
            this.gBopciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVcuadradoMagico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btEjemplo1;
        private System.Windows.Forms.Button btEjemplo2;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lbDiagonal1;
        private System.Windows.Forms.Label lbDiagonal2;
        private System.Windows.Forms.Label lbColumna1;
        private System.Windows.Forms.Label lbColumna2;
        private System.Windows.Forms.Label lbColumna3;
        private System.Windows.Forms.Label lbColumna4;
        private System.Windows.Forms.Label lbRenglon1;
        private System.Windows.Forms.Label lbRenglon2;
        private System.Windows.Forms.Label lbRenglon3;
        private System.Windows.Forms.Label lbRenglon4;
        private System.Windows.Forms.PictureBox pBcuadradomagico;
        private System.Windows.Forms.GroupBox gBcuadradoMagico;
        private System.Windows.Forms.GroupBox gBopciones;
        private System.Windows.Forms.Label label1;
    }
}