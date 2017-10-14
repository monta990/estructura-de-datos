namespace esdat
{
    partial class FrmInversa
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
            this.dGVmatrizA = new System.Windows.Forms.DataGridView();
            this.dGVmatrizAdjunta = new System.Windows.Forms.DataGridView();
            this.dGVnatrizInveraAT = new System.Windows.Forms.DataGridView();
            this.dGVmatrizResultado = new System.Windows.Forms.DataGridView();
            this.dGVverificacion = new System.Windows.Forms.DataGridView();
            this.lblMatrizA = new System.Windows.Forms.Label();
            this.lblMatrizInveraAT = new System.Windows.Forms.Label();
            this.lblNombreDeterminante = new System.Windows.Forms.Label();
            this.lblDeterminante = new System.Windows.Forms.Label();
            this.lblMatrizAdjunta = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblVerificacion = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnEjemplo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVmatrizA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVmatrizAdjunta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVnatrizInveraAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVmatrizResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVverificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVmatrizA
            // 
            this.dGVmatrizA.AllowUserToAddRows = false;
            this.dGVmatrizA.AllowUserToDeleteRows = false;
            this.dGVmatrizA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVmatrizA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVmatrizA.Location = new System.Drawing.Point(91, 13);
            this.dGVmatrizA.Name = "dGVmatrizA";
            this.dGVmatrizA.Size = new System.Drawing.Size(240, 150);
            this.dGVmatrizA.TabIndex = 0;
            // 
            // dGVmatrizAdjunta
            // 
            this.dGVmatrizAdjunta.AllowUserToAddRows = false;
            this.dGVmatrizAdjunta.AllowUserToDeleteRows = false;
            this.dGVmatrizAdjunta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVmatrizAdjunta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVmatrizAdjunta.Location = new System.Drawing.Point(538, 13);
            this.dGVmatrizAdjunta.Name = "dGVmatrizAdjunta";
            this.dGVmatrizAdjunta.ReadOnly = true;
            this.dGVmatrizAdjunta.Size = new System.Drawing.Size(240, 150);
            this.dGVmatrizAdjunta.TabIndex = 1;
            // 
            // dGVnatrizInveraAT
            // 
            this.dGVnatrizInveraAT.AllowUserToAddRows = false;
            this.dGVnatrizInveraAT.AllowUserToDeleteRows = false;
            this.dGVnatrizInveraAT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVnatrizInveraAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVnatrizInveraAT.Location = new System.Drawing.Point(91, 199);
            this.dGVnatrizInveraAT.Name = "dGVnatrizInveraAT";
            this.dGVnatrizInveraAT.ReadOnly = true;
            this.dGVnatrizInveraAT.Size = new System.Drawing.Size(240, 150);
            this.dGVnatrizInveraAT.TabIndex = 2;
            // 
            // dGVmatrizResultado
            // 
            this.dGVmatrizResultado.AllowUserToAddRows = false;
            this.dGVmatrizResultado.AllowUserToDeleteRows = false;
            this.dGVmatrizResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVmatrizResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVmatrizResultado.Location = new System.Drawing.Point(538, 199);
            this.dGVmatrizResultado.Name = "dGVmatrizResultado";
            this.dGVmatrizResultado.ReadOnly = true;
            this.dGVmatrizResultado.Size = new System.Drawing.Size(240, 150);
            this.dGVmatrizResultado.TabIndex = 3;
            // 
            // dGVverificacion
            // 
            this.dGVverificacion.AllowUserToAddRows = false;
            this.dGVverificacion.AllowUserToDeleteRows = false;
            this.dGVverificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVverificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVverificacion.Location = new System.Drawing.Point(879, 96);
            this.dGVverificacion.Name = "dGVverificacion";
            this.dGVverificacion.ReadOnly = true;
            this.dGVverificacion.Size = new System.Drawing.Size(240, 150);
            this.dGVverificacion.TabIndex = 4;
            // 
            // lblMatrizA
            // 
            this.lblMatrizA.AutoSize = true;
            this.lblMatrizA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatrizA.Location = new System.Drawing.Point(13, 71);
            this.lblMatrizA.Name = "lblMatrizA";
            this.lblMatrizA.Size = new System.Drawing.Size(42, 24);
            this.lblMatrizA.TabIndex = 5;
            this.lblMatrizA.Text = "A= ";
            // 
            // lblMatrizInveraAT
            // 
            this.lblMatrizInveraAT.AutoSize = true;
            this.lblMatrizInveraAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatrizInveraAT.Location = new System.Drawing.Point(11, 278);
            this.lblMatrizInveraAT.Name = "lblMatrizInveraAT";
            this.lblMatrizInveraAT.Size = new System.Drawing.Size(74, 24);
            this.lblMatrizInveraAT.TabIndex = 6;
            this.lblMatrizInveraAT.Text = "(A*)ᵀ= ";
            this.lblMatrizInveraAT.Click += new System.EventHandler(this.lblMatrizInveraAT_Click);
            // 
            // lblNombreDeterminante
            // 
            this.lblNombreDeterminante.AutoSize = true;
            this.lblNombreDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDeterminante.Location = new System.Drawing.Point(359, 53);
            this.lblNombreDeterminante.Name = "lblNombreDeterminante";
            this.lblNombreDeterminante.Size = new System.Drawing.Size(46, 24);
            this.lblNombreDeterminante.TabIndex = 7;
            this.lblNombreDeterminante.Text = "|A|=";
            // 
            // lblDeterminante
            // 
            this.lblDeterminante.AutoSize = true;
            this.lblDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeterminante.Location = new System.Drawing.Point(362, 77);
            this.lblDeterminante.Name = "lblDeterminante";
            this.lblDeterminante.Size = new System.Drawing.Size(21, 24);
            this.lblDeterminante.TabIndex = 8;
            this.lblDeterminante.Text = "0";
            // 
            // lblMatrizAdjunta
            // 
            this.lblMatrizAdjunta.AutoSize = true;
            this.lblMatrizAdjunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatrizAdjunta.Location = new System.Drawing.Point(412, 71);
            this.lblMatrizAdjunta.Name = "lblMatrizAdjunta";
            this.lblMatrizAdjunta.Size = new System.Drawing.Size(50, 24);
            this.lblMatrizAdjunta.TabIndex = 9;
            this.lblMatrizAdjunta.Text = "A* =";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(362, 278);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(168, 24);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "A= A-1/|A| (A*)ᵀ=";
            // 
            // lblVerificacion
            // 
            this.lblVerificacion.AutoSize = true;
            this.lblVerificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificacion.Location = new System.Drawing.Point(782, 174);
            this.lblVerificacion.Name = "lblVerificacion";
            this.lblVerificacion.Size = new System.Drawing.Size(91, 24);
            this.lblVerificacion.TabIndex = 11;
            this.lblVerificacion.Text = "I = A.A-1";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(91, 374);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 12;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnEjemplo
            // 
            this.btnEjemplo.Location = new System.Drawing.Point(256, 374);
            this.btnEjemplo.Name = "btnEjemplo";
            this.btnEjemplo.Size = new System.Drawing.Size(75, 23);
            this.btnEjemplo.TabIndex = 13;
            this.btnEjemplo.Text = "Ejemplo";
            this.btnEjemplo.UseVisualStyleBackColor = true;
            this.btnEjemplo.Click += new System.EventHandler(this.btnEjemplo_Click);
            // 
            // FrmInversa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 413);
            this.Controls.Add(this.btnEjemplo);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.lblVerificacion);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblMatrizAdjunta);
            this.Controls.Add(this.lblDeterminante);
            this.Controls.Add(this.lblNombreDeterminante);
            this.Controls.Add(this.lblMatrizInveraAT);
            this.Controls.Add(this.lblMatrizA);
            this.Controls.Add(this.dGVverificacion);
            this.Controls.Add(this.dGVmatrizResultado);
            this.Controls.Add(this.dGVnatrizInveraAT);
            this.Controls.Add(this.dGVmatrizAdjunta);
            this.Controls.Add(this.dGVmatrizA);
            this.Name = "FrmInversa";
            this.Text = "Matriz Inversa";
            ((System.ComponentModel.ISupportInitialize)(this.dGVmatrizA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVmatrizAdjunta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVnatrizInveraAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVmatrizResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVverificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVmatrizA;
        private System.Windows.Forms.DataGridView dGVmatrizAdjunta;
        private System.Windows.Forms.DataGridView dGVnatrizInveraAT;
        private System.Windows.Forms.DataGridView dGVmatrizResultado;
        private System.Windows.Forms.DataGridView dGVverificacion;
        private System.Windows.Forms.Label lblMatrizA;
        private System.Windows.Forms.Label lblMatrizInveraAT;
        private System.Windows.Forms.Label lblNombreDeterminante;
        private System.Windows.Forms.Label lblDeterminante;
        private System.Windows.Forms.Label lblMatrizAdjunta;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblVerificacion;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnEjemplo;
    }
}