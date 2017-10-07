namespace esdat
{
    partial class FrmOrdenamientoBusqueda
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
            this.dGVoriginal = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVburbuja = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVinsert = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVshell = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVqucksort = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBlimiteinferior = new System.Windows.Forms.TextBox();
            this.tBlimitesuperior = new System.Windows.Forms.TextBox();
            this.lblIteraciones1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblIeracionBurbuja = new System.Windows.Forms.Label();
            this.lblIteracionInsert = new System.Windows.Forms.Label();
            this.lblInteracionShell = new System.Windows.Forms.Label();
            this.lblIteracionesQuickSort = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblStartOriginal = new System.Windows.Forms.Label();
            this.lblEndOriginal = new System.Windows.Forms.Label();
            this.lblEndBurbuja = new System.Windows.Forms.Label();
            this.lblStartBurbuja = new System.Windows.Forms.Label();
            this.lblEndInsert = new System.Windows.Forms.Label();
            this.lblStartInsert = new System.Windows.Forms.Label();
            this.lblEndShell = new System.Windows.Forms.Label();
            this.lblStartShell = new System.Windows.Forms.Label();
            this.lblEndQuickSort = new System.Windows.Forms.Label();
            this.lblStartQuickSort = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVoriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVburbuja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVinsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVshell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVqucksort)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVoriginal
            // 
            this.dGVoriginal.AllowUserToAddRows = false;
            this.dGVoriginal.AllowUserToDeleteRows = false;
            this.dGVoriginal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVoriginal.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGVoriginal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVoriginal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVoriginal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dGVoriginal.Location = new System.Drawing.Point(12, 25);
            this.dGVoriginal.Name = "dGVoriginal";
            this.dGVoriginal.ReadOnly = true;
            this.dGVoriginal.Size = new System.Drawing.Size(152, 322);
            this.dGVoriginal.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Original";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dGVburbuja
            // 
            this.dGVburbuja.AllowUserToAddRows = false;
            this.dGVburbuja.AllowUserToDeleteRows = false;
            this.dGVburbuja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVburbuja.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGVburbuja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVburbuja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVburbuja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dGVburbuja.Location = new System.Drawing.Point(170, 25);
            this.dGVburbuja.Name = "dGVburbuja";
            this.dGVburbuja.ReadOnly = true;
            this.dGVburbuja.Size = new System.Drawing.Size(149, 322);
            this.dGVburbuja.TabIndex = 1;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Burbuja";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dGVinsert
            // 
            this.dGVinsert.AllowUserToAddRows = false;
            this.dGVinsert.AllowUserToDeleteRows = false;
            this.dGVinsert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVinsert.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGVinsert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVinsert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVinsert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3});
            this.dGVinsert.Location = new System.Drawing.Point(325, 25);
            this.dGVinsert.Name = "dGVinsert";
            this.dGVinsert.ReadOnly = true;
            this.dGVinsert.Size = new System.Drawing.Size(149, 322);
            this.dGVinsert.TabIndex = 2;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Insert";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // dGVshell
            // 
            this.dGVshell.AllowUserToAddRows = false;
            this.dGVshell.AllowUserToDeleteRows = false;
            this.dGVshell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVshell.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGVshell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVshell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVshell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4});
            this.dGVshell.Location = new System.Drawing.Point(480, 25);
            this.dGVshell.Name = "dGVshell";
            this.dGVshell.ReadOnly = true;
            this.dGVshell.Size = new System.Drawing.Size(151, 322);
            this.dGVshell.TabIndex = 3;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Shell";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dGVqucksort
            // 
            this.dGVqucksort.AllowUserToAddRows = false;
            this.dGVqucksort.AllowUserToDeleteRows = false;
            this.dGVqucksort.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVqucksort.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGVqucksort.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVqucksort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVqucksort.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5});
            this.dGVqucksort.Location = new System.Drawing.Point(637, 25);
            this.dGVqucksort.Name = "dGVqucksort";
            this.dGVqucksort.ReadOnly = true;
            this.dGVqucksort.Size = new System.Drawing.Size(150, 322);
            this.dGVqucksort.TabIndex = 4;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "QuickSort";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Burbuja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Insert";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Shell";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(633, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "QuickSort";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Li =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ls =";
            // 
            // tBlimiteinferior
            // 
            this.tBlimiteinferior.Location = new System.Drawing.Point(44, 399);
            this.tBlimiteinferior.Name = "tBlimiteinferior";
            this.tBlimiteinferior.Size = new System.Drawing.Size(120, 20);
            this.tBlimiteinferior.TabIndex = 12;
            // 
            // tBlimitesuperior
            // 
            this.tBlimitesuperior.Location = new System.Drawing.Point(44, 426);
            this.tBlimitesuperior.Name = "tBlimitesuperior";
            this.tBlimitesuperior.Size = new System.Drawing.Size(120, 20);
            this.tBlimitesuperior.TabIndex = 13;
            // 
            // lblIteraciones1
            // 
            this.lblIteraciones1.AutoSize = true;
            this.lblIteraciones1.Location = new System.Drawing.Point(170, 405);
            this.lblIteraciones1.Name = "lblIteraciones1";
            this.lblIteraciones1.Size = new System.Drawing.Size(62, 13);
            this.lblIteraciones1.TabIndex = 14;
            this.lblIteraciones1.Text = "Iteraciones:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Iteraciones:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(477, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Iteraciones:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(634, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Iteraciones:";
            // 
            // lblIeracionBurbuja
            // 
            this.lblIeracionBurbuja.AutoSize = true;
            this.lblIeracionBurbuja.Location = new System.Drawing.Point(238, 405);
            this.lblIeracionBurbuja.Name = "lblIeracionBurbuja";
            this.lblIeracionBurbuja.Size = new System.Drawing.Size(13, 13);
            this.lblIeracionBurbuja.TabIndex = 18;
            this.lblIeracionBurbuja.Text = "0";
            // 
            // lblIteracionInsert
            // 
            this.lblIteracionInsert.AutoSize = true;
            this.lblIteracionInsert.Location = new System.Drawing.Point(390, 405);
            this.lblIteracionInsert.Name = "lblIteracionInsert";
            this.lblIteracionInsert.Size = new System.Drawing.Size(13, 13);
            this.lblIteracionInsert.TabIndex = 19;
            this.lblIteracionInsert.Text = "0";
            // 
            // lblInteracionShell
            // 
            this.lblInteracionShell.AutoSize = true;
            this.lblInteracionShell.Location = new System.Drawing.Point(545, 406);
            this.lblInteracionShell.Name = "lblInteracionShell";
            this.lblInteracionShell.Size = new System.Drawing.Size(13, 13);
            this.lblInteracionShell.TabIndex = 20;
            this.lblInteracionShell.Text = "0";
            // 
            // lblIteracionesQuickSort
            // 
            this.lblIteracionesQuickSort.AutoSize = true;
            this.lblIteracionesQuickSort.Location = new System.Drawing.Point(702, 406);
            this.lblIteracionesQuickSort.Name = "lblIteracionesQuickSort";
            this.lblIteracionesQuickSort.Size = new System.Drawing.Size(13, 13);
            this.lblIteracionesQuickSort.TabIndex = 21;
            this.lblIteracionesQuickSort.Text = "0";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(170, 426);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(149, 23);
            this.btnGenerar.TabIndex = 22;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(325, 426);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(149, 23);
            this.btnCalcular.TabIndex = 23;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(480, 426);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(151, 23);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(637, 426);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 23);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblStartOriginal
            // 
            this.lblStartOriginal.AutoSize = true;
            this.lblStartOriginal.Location = new System.Drawing.Point(13, 350);
            this.lblStartOriginal.Name = "lblStartOriginal";
            this.lblStartOriginal.Size = new System.Drawing.Size(48, 13);
            this.lblStartOriginal.TabIndex = 26;
            this.lblStartOriginal.Text = "Empezo:";
            // 
            // lblEndOriginal
            // 
            this.lblEndOriginal.AutoSize = true;
            this.lblEndOriginal.Location = new System.Drawing.Point(13, 373);
            this.lblEndOriginal.Name = "lblEndOriginal";
            this.lblEndOriginal.Size = new System.Drawing.Size(45, 13);
            this.lblEndOriginal.TabIndex = 27;
            this.lblEndOriginal.Text = "Finalizo:";
            // 
            // lblEndBurbuja
            // 
            this.lblEndBurbuja.AutoSize = true;
            this.lblEndBurbuja.Location = new System.Drawing.Point(170, 373);
            this.lblEndBurbuja.Name = "lblEndBurbuja";
            this.lblEndBurbuja.Size = new System.Drawing.Size(45, 13);
            this.lblEndBurbuja.TabIndex = 29;
            this.lblEndBurbuja.Text = "Finalizo:";
            // 
            // lblStartBurbuja
            // 
            this.lblStartBurbuja.AutoSize = true;
            this.lblStartBurbuja.Location = new System.Drawing.Point(170, 350);
            this.lblStartBurbuja.Name = "lblStartBurbuja";
            this.lblStartBurbuja.Size = new System.Drawing.Size(48, 13);
            this.lblStartBurbuja.TabIndex = 28;
            this.lblStartBurbuja.Text = "Empezo:";
            // 
            // lblEndInsert
            // 
            this.lblEndInsert.AutoSize = true;
            this.lblEndInsert.Location = new System.Drawing.Point(322, 373);
            this.lblEndInsert.Name = "lblEndInsert";
            this.lblEndInsert.Size = new System.Drawing.Size(45, 13);
            this.lblEndInsert.TabIndex = 31;
            this.lblEndInsert.Text = "Finalizo:";
            // 
            // lblStartInsert
            // 
            this.lblStartInsert.AutoSize = true;
            this.lblStartInsert.Location = new System.Drawing.Point(322, 350);
            this.lblStartInsert.Name = "lblStartInsert";
            this.lblStartInsert.Size = new System.Drawing.Size(48, 13);
            this.lblStartInsert.TabIndex = 30;
            this.lblStartInsert.Text = "Empezo:";
            // 
            // lblEndShell
            // 
            this.lblEndShell.AutoSize = true;
            this.lblEndShell.Location = new System.Drawing.Point(480, 373);
            this.lblEndShell.Name = "lblEndShell";
            this.lblEndShell.Size = new System.Drawing.Size(45, 13);
            this.lblEndShell.TabIndex = 33;
            this.lblEndShell.Text = "Finalizo:";
            // 
            // lblStartShell
            // 
            this.lblStartShell.AutoSize = true;
            this.lblStartShell.Location = new System.Drawing.Point(480, 350);
            this.lblStartShell.Name = "lblStartShell";
            this.lblStartShell.Size = new System.Drawing.Size(48, 13);
            this.lblStartShell.TabIndex = 32;
            this.lblStartShell.Text = "Empezo:";
            // 
            // lblEndQuickSort
            // 
            this.lblEndQuickSort.AutoSize = true;
            this.lblEndQuickSort.Location = new System.Drawing.Point(639, 373);
            this.lblEndQuickSort.Name = "lblEndQuickSort";
            this.lblEndQuickSort.Size = new System.Drawing.Size(45, 13);
            this.lblEndQuickSort.TabIndex = 35;
            this.lblEndQuickSort.Text = "Finalizo:";
            // 
            // lblStartQuickSort
            // 
            this.lblStartQuickSort.AutoSize = true;
            this.lblStartQuickSort.Location = new System.Drawing.Point(639, 350);
            this.lblStartQuickSort.Name = "lblStartQuickSort";
            this.lblStartQuickSort.Size = new System.Drawing.Size(48, 13);
            this.lblStartQuickSort.TabIndex = 34;
            this.lblStartQuickSort.Text = "Empezo:";
            // 
            // FrmOrdenamientoBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 472);
            this.Controls.Add(this.lblEndQuickSort);
            this.Controls.Add(this.lblStartQuickSort);
            this.Controls.Add(this.lblEndShell);
            this.Controls.Add(this.lblStartShell);
            this.Controls.Add(this.lblEndInsert);
            this.Controls.Add(this.lblStartInsert);
            this.Controls.Add(this.lblEndBurbuja);
            this.Controls.Add(this.lblStartBurbuja);
            this.Controls.Add(this.lblEndOriginal);
            this.Controls.Add(this.lblStartOriginal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblIteracionesQuickSort);
            this.Controls.Add(this.lblInteracionShell);
            this.Controls.Add(this.lblIteracionInsert);
            this.Controls.Add(this.lblIeracionBurbuja);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblIteraciones1);
            this.Controls.Add(this.tBlimitesuperior);
            this.Controls.Add(this.tBlimiteinferior);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVqucksort);
            this.Controls.Add(this.dGVshell);
            this.Controls.Add(this.dGVinsert);
            this.Controls.Add(this.dGVburbuja);
            this.Controls.Add(this.dGVoriginal);
            this.Name = "FrmOrdenamientoBusqueda";
            this.Text = "Formulario Ordenamiento y Busqueda";
            ((System.ComponentModel.ISupportInitialize)(this.dGVoriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVburbuja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVinsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVshell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVqucksort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVoriginal;
        private System.Windows.Forms.DataGridView dGVburbuja;
        private System.Windows.Forms.DataGridView dGVinsert;
        private System.Windows.Forms.DataGridView dGVshell;
        private System.Windows.Forms.DataGridView dGVqucksort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBlimiteinferior;
        private System.Windows.Forms.TextBox tBlimitesuperior;
        private System.Windows.Forms.Label lblIteraciones1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblIeracionBurbuja;
        private System.Windows.Forms.Label lblIteracionInsert;
        private System.Windows.Forms.Label lblInteracionShell;
        private System.Windows.Forms.Label lblIteracionesQuickSort;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblStartOriginal;
        private System.Windows.Forms.Label lblEndOriginal;
        private System.Windows.Forms.Label lblEndBurbuja;
        private System.Windows.Forms.Label lblStartBurbuja;
        private System.Windows.Forms.Label lblEndInsert;
        private System.Windows.Forms.Label lblStartInsert;
        private System.Windows.Forms.Label lblEndShell;
        private System.Windows.Forms.Label lblStartShell;
        private System.Windows.Forms.Label lblEndQuickSort;
        private System.Windows.Forms.Label lblStartQuickSort;
    }
}