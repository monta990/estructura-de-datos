namespace esdat
{
    partial class Practica1
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
            this.lbElementoIngresar = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.tbLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvElementos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSeleccionado = new System.Windows.Forms.Label();
            this.txtElemento2 = new System.Windows.Forms.TextBox();
            this.lblValor2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbElementoIngresar
            // 
            this.lbElementoIngresar.AutoSize = true;
            this.lbElementoIngresar.Location = new System.Drawing.Point(8, 30);
            this.lbElementoIngresar.Name = "lbElementoIngresar";
            this.lbElementoIngresar.Size = new System.Drawing.Size(78, 13);
            this.lbElementoIngresar.TabIndex = 0;
            this.lbElementoIngresar.Text = "Elemento [0,0]:";
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(92, 27);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(134, 20);
            this.txtElemento.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(245, 30);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(11, 13);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "*";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(6, 16);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 3;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCAPTURAR_Click);
            // 
            // tbLimpiar
            // 
            this.tbLimpiar.Location = new System.Drawing.Point(106, 16);
            this.tbLimpiar.Name = "tbLimpiar";
            this.tbLimpiar.Size = new System.Drawing.Size(75, 23);
            this.tbLimpiar.TabIndex = 4;
            this.tbLimpiar.Text = "Limpiar";
            this.tbLimpiar.UseVisualStyleBackColor = true;
            this.tbLimpiar.Click += new System.EventHandler(this.tbLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Elemento Seleccionado =";
            // 
            // dgvElementos
            // 
            this.dgvElementos.AllowUserToAddRows = false;
            this.dgvElementos.AllowUserToDeleteRows = false;
            this.dgvElementos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElementos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvElementos.Location = new System.Drawing.Point(13, 123);
            this.dgvElementos.Name = "dgvElementos";
            this.dgvElementos.ReadOnly = true;
            this.dgvElementos.Size = new System.Drawing.Size(512, 150);
            this.dgvElementos.TabIndex = 6;
            this.dgvElementos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElementos_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "0";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(450, 279);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 7;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCapturar);
            this.groupBox1.Controls.Add(this.tbLimpiar);
            this.groupBox1.Location = new System.Drawing.Point(338, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 94);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblValor2);
            this.groupBox2.Controls.Add(this.txtElemento2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbElementoIngresar);
            this.groupBox2.Controls.Add(this.txtElemento);
            this.groupBox2.Controls.Add(this.lblValor);
            this.groupBox2.Location = new System.Drawing.Point(13, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 94);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos a ingresar en:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo:";
            // 
            // lbSeleccionado
            // 
            this.lbSeleccionado.AutoSize = true;
            this.lbSeleccionado.Location = new System.Drawing.Point(145, 107);
            this.lbSeleccionado.Name = "lbSeleccionado";
            this.lbSeleccionado.Size = new System.Drawing.Size(28, 13);
            this.lbSeleccionado.TabIndex = 10;
            this.lbSeleccionado.Text = "[0,0]";
            // 
            // txtElemento2
            // 
            this.txtElemento2.Location = new System.Drawing.Point(92, 54);
            this.txtElemento2.Name = "txtElemento2";
            this.txtElemento2.Size = new System.Drawing.Size(134, 20);
            this.txtElemento2.TabIndex = 4;
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(246, 60);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(11, 13);
            this.lblValor2.TabIndex = 5;
            this.lblValor2.Text = "*";
            // 
            // Practica1
            // 
            this.AcceptButton = this.btnCapturar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 314);
            this.Controls.Add(this.lbSeleccionado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.dgvElementos);
            this.Controls.Add(this.label2);
            this.Name = "Practica1";
            this.Text = "Practica 1";
            this.Load += new System.EventHandler(this.Practica1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbElementoIngresar;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button tbLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvElementos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSeleccionado;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtElemento2;
    }
}