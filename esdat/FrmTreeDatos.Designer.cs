﻿namespace esdat
{
    partial class FrmTreeDatos
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
            this.tVdatos = new System.Windows.Forms.TreeView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tVdatos
            // 
            this.tVdatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tVdatos.Location = new System.Drawing.Point(12, 12);
            this.tVdatos.Name = "tVdatos";
            this.tVdatos.Size = new System.Drawing.Size(277, 441);
            this.tVdatos.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(509, 430);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripción.Location = new System.Drawing.Point(295, 12);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(234, 100);
            this.lblDescripción.TabIndex = 3;
            this.lblDescripción.Text = "El arbol de la izquierda,\r\nfue construido con sultado\r\ndatos de un servidor MySQL" +
    "\r\nlas raices son Tablas y los\r\nNodos son sus datos";
            // 
            // FrmTreeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 465);
            this.Controls.Add(this.lblDescripción);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tVdatos);
            this.Name = "FrmTreeDatos";
            this.Text = "Arbol con Datos";
            this.Load += new System.EventHandler(this.FrmTreeDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tVdatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblDescripción;
    }
}