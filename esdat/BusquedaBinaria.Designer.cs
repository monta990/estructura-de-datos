﻿namespace esdat
{
    partial class BusquedaBinaria
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
            this.dGViewElementos = new System.Windows.Forms.DataGridView();
            this.tBelementos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBlimite = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btGenerar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewElementos)).BeginInit();
            this.SuspendLayout();
            // 
            // dGViewElementos
            // 
            this.dGViewElementos.AllowUserToAddRows = false;
            this.dGViewElementos.AllowUserToDeleteRows = false;
            this.dGViewElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewElementos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dGViewElementos.Location = new System.Drawing.Point(13, 13);
            this.dGViewElementos.Name = "dGViewElementos";
            this.dGViewElementos.ReadOnly = true;
            this.dGViewElementos.Size = new System.Drawing.Size(198, 233);
            this.dGViewElementos.TabIndex = 0;
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
            this.label3.Location = new System.Drawing.Point(231, 155);
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(347, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 20);
            this.textBox3.TabIndex = 6;
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
            this.btBuscar.Location = new System.Drawing.Point(516, 150);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 8;
            this.btBuscar.Text = "&Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Elementos";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // BusquedaBinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 258);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btGenerar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tBlimite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBelementos);
            this.Controls.Add(this.dGViewElementos);
            this.Name = "BusquedaBinaria";
            this.Text = "BusquedaBinaria";
            ((System.ComponentModel.ISupportInitialize)(this.dGViewElementos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGViewElementos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox tBelementos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBlimite;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btGenerar;
        private System.Windows.Forms.Button btBuscar;
    }
}