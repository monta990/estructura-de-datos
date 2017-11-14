namespace esdat
{
    partial class FrmBusquedaBinaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusquedaBinaria));
            this.dGViewElementos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBelementos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBlimite = new System.Windows.Forms.TextBox();
            this.tBbuscar = new System.Windows.Forms.TextBox();
            this.btGenerar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewElementos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGViewElementos
            // 
            this.dGViewElementos.AllowUserToAddRows = false;
            this.dGViewElementos.AllowUserToDeleteRows = false;
            this.dGViewElementos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGViewElementos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGViewElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewElementos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dGViewElementos.Location = new System.Drawing.Point(12, 16);
            this.dGViewElementos.Name = "dGViewElementos";
            this.dGViewElementos.ReadOnly = true;
            this.dGViewElementos.Size = new System.Drawing.Size(200, 380);
            this.dGViewElementos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Elementos";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.ToolTipText = "Arreglo de elementos";
            // 
            // tBelementos
            // 
            this.tBelementos.Location = new System.Drawing.Point(347, 13);
            this.tBelementos.Name = "tBelementos";
            this.tBelementos.Size = new System.Drawing.Size(151, 20);
            this.tBelementos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de Elementos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Limite:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Buscar:";
            // 
            // tBlimite
            // 
            this.tBlimite.Location = new System.Drawing.Point(347, 58);
            this.tBlimite.Name = "tBlimite";
            this.tBlimite.Size = new System.Drawing.Size(151, 20);
            this.tBlimite.TabIndex = 5;
            // 
            // tBbuscar
            // 
            this.tBbuscar.Location = new System.Drawing.Point(347, 209);
            this.tBbuscar.Name = "tBbuscar";
            this.tBbuscar.Size = new System.Drawing.Size(151, 20);
            this.tBbuscar.TabIndex = 6;
            // 
            // btGenerar
            // 
            this.btGenerar.Location = new System.Drawing.Point(516, 37);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(75, 23);
            this.btGenerar.TabIndex = 7;
            this.btGenerar.Text = "Generar Elementos";
            this.btGenerar.UseVisualStyleBackColor = true;
            this.btGenerar.Click += new System.EventHandler(this.btGenerar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(516, 207);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 8;
            this.btBuscar.Text = "&Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(516, 371);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 9;
            this.btSalir.Text = "&Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(234, 371);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 10;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(613, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBusquedaBinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 406);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btGenerar);
            this.Controls.Add(this.tBbuscar);
            this.Controls.Add(this.tBlimite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBelementos);
            this.Controls.Add(this.dGViewElementos);
            this.Name = "FrmBusquedaBinaria";
            this.Text = "Busqueda Binaria";
            ((System.ComponentModel.ISupportInitialize)(this.dGViewElementos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGViewElementos;
        private System.Windows.Forms.TextBox tBelementos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBlimite;
        private System.Windows.Forms.TextBox tBbuscar;
        private System.Windows.Forms.Button btGenerar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}