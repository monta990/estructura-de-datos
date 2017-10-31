namespace esdat
{
    partial class FrmTreeRecorrido
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnContraer = new System.Windows.Forms.Button();
            this.btnExpandir = new System.Windows.Forms.Button();
            this.btnAgregarPadre = new System.Windows.Forms.Button();
            this.tVfolder = new System.Windows.Forms.TreeView();
            this.lblRaiz = new System.Windows.Forms.Label();
            this.tBraiz = new System.Windows.Forms.TextBox();
            this.lblPadre = new System.Windows.Forms.Label();
            this.comboBpadre = new System.Windows.Forms.ComboBox();
            this.btnPodarnodo = new System.Windows.Forms.Button();
            this.lblHijo = new System.Windows.Forms.Label();
            this.tBhijo = new System.Windows.Forms.TextBox();
            this.btnRecorrido = new System.Windows.Forms.Button();
            this.btnAgregarHijo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(323, 366);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(166, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(323, 321);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(166, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Podar todo";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnContraer
            // 
            this.btnContraer.Location = new System.Drawing.Point(314, 157);
            this.btnContraer.Name = "btnContraer";
            this.btnContraer.Size = new System.Drawing.Size(75, 23);
            this.btnContraer.TabIndex = 9;
            this.btnContraer.Text = "Contraer";
            this.btnContraer.UseVisualStyleBackColor = true;
            this.btnContraer.Click += new System.EventHandler(this.btnContraer_Click);
            // 
            // btnExpandir
            // 
            this.btnExpandir.Location = new System.Drawing.Point(221, 157);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(75, 23);
            this.btnExpandir.TabIndex = 8;
            this.btnExpandir.Text = "Expandir";
            this.btnExpandir.UseVisualStyleBackColor = true;
            this.btnExpandir.Click += new System.EventHandler(this.btnExpandir_Click);
            // 
            // btnAgregarPadre
            // 
            this.btnAgregarPadre.Enabled = false;
            this.btnAgregarPadre.Location = new System.Drawing.Point(414, 12);
            this.btnAgregarPadre.Name = "btnAgregarPadre";
            this.btnAgregarPadre.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPadre.TabIndex = 7;
            this.btnAgregarPadre.Text = "Agregar";
            this.btnAgregarPadre.UseVisualStyleBackColor = true;
            this.btnAgregarPadre.Click += new System.EventHandler(this.btnAgregarPadre_Click);
            // 
            // tVfolder
            // 
            this.tVfolder.Location = new System.Drawing.Point(12, 12);
            this.tVfolder.Name = "tVfolder";
            this.tVfolder.Size = new System.Drawing.Size(190, 385);
            this.tVfolder.TabIndex = 6;
            // 
            // lblRaiz
            // 
            this.lblRaiz.AutoSize = true;
            this.lblRaiz.Location = new System.Drawing.Point(218, 13);
            this.lblRaiz.Name = "lblRaiz";
            this.lblRaiz.Size = new System.Drawing.Size(28, 13);
            this.lblRaiz.TabIndex = 12;
            this.lblRaiz.Text = "Raiz";
            // 
            // tBraiz
            // 
            this.tBraiz.Enabled = false;
            this.tBraiz.Location = new System.Drawing.Point(265, 13);
            this.tBraiz.Name = "tBraiz";
            this.tBraiz.Size = new System.Drawing.Size(133, 20);
            this.tBraiz.TabIndex = 13;
            // 
            // lblPadre
            // 
            this.lblPadre.AutoSize = true;
            this.lblPadre.Location = new System.Drawing.Point(218, 61);
            this.lblPadre.Name = "lblPadre";
            this.lblPadre.Size = new System.Drawing.Size(38, 13);
            this.lblPadre.TabIndex = 14;
            this.lblPadre.Text = "Padre:";
            // 
            // comboBpadre
            // 
            this.comboBpadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBpadre.FormattingEnabled = true;
            this.comboBpadre.Location = new System.Drawing.Point(265, 61);
            this.comboBpadre.Name = "comboBpadre";
            this.comboBpadre.Size = new System.Drawing.Size(133, 21);
            this.comboBpadre.TabIndex = 15;
            // 
            // btnPodarnodo
            // 
            this.btnPodarnodo.Location = new System.Drawing.Point(414, 61);
            this.btnPodarnodo.Name = "btnPodarnodo";
            this.btnPodarnodo.Size = new System.Drawing.Size(75, 23);
            this.btnPodarnodo.TabIndex = 16;
            this.btnPodarnodo.Text = "Podar";
            this.btnPodarnodo.UseVisualStyleBackColor = true;
            this.btnPodarnodo.Click += new System.EventHandler(this.btnPodarnodo_Click);
            // 
            // lblHijo
            // 
            this.lblHijo.AutoSize = true;
            this.lblHijo.Location = new System.Drawing.Point(218, 106);
            this.lblHijo.Name = "lblHijo";
            this.lblHijo.Size = new System.Drawing.Size(28, 13);
            this.lblHijo.TabIndex = 17;
            this.lblHijo.Text = "Hijo:";
            // 
            // tBhijo
            // 
            this.tBhijo.Location = new System.Drawing.Point(265, 103);
            this.tBhijo.Name = "tBhijo";
            this.tBhijo.Size = new System.Drawing.Size(133, 20);
            this.tBhijo.TabIndex = 18;
            this.tBhijo.TextChanged += new System.EventHandler(this.tBhijo_TextChanged);
            // 
            // btnRecorrido
            // 
            this.btnRecorrido.Location = new System.Drawing.Point(405, 157);
            this.btnRecorrido.Name = "btnRecorrido";
            this.btnRecorrido.Size = new System.Drawing.Size(75, 23);
            this.btnRecorrido.TabIndex = 19;
            this.btnRecorrido.Text = "Recorrido";
            this.btnRecorrido.UseVisualStyleBackColor = true;
            this.btnRecorrido.Click += new System.EventHandler(this.btnRecorrido_Click);
            // 
            // btnAgregarHijo
            // 
            this.btnAgregarHijo.Location = new System.Drawing.Point(414, 103);
            this.btnAgregarHijo.Name = "btnAgregarHijo";
            this.btnAgregarHijo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarHijo.TabIndex = 20;
            this.btnAgregarHijo.Text = "Agregar";
            this.btnAgregarHijo.UseVisualStyleBackColor = true;
            this.btnAgregarHijo.Click += new System.EventHandler(this.btnAgregarHijo_Click);
            // 
            // FrmTreeRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 406);
            this.Controls.Add(this.btnAgregarHijo);
            this.Controls.Add(this.btnRecorrido);
            this.Controls.Add(this.tBhijo);
            this.Controls.Add(this.lblHijo);
            this.Controls.Add(this.btnPodarnodo);
            this.Controls.Add(this.comboBpadre);
            this.Controls.Add(this.lblPadre);
            this.Controls.Add(this.tBraiz);
            this.Controls.Add(this.lblRaiz);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnContraer);
            this.Controls.Add(this.btnExpandir);
            this.Controls.Add(this.btnAgregarPadre);
            this.Controls.Add(this.tVfolder);
            this.Name = "FrmTreeRecorrido";
            this.Text = "Arbol Recorrido";
            this.Load += new System.EventHandler(this.FrmTreeRecorrido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnContraer;
        private System.Windows.Forms.Button btnExpandir;
        private System.Windows.Forms.Button btnAgregarPadre;
        private System.Windows.Forms.TreeView tVfolder;
        private System.Windows.Forms.Label lblRaiz;
        private System.Windows.Forms.TextBox tBraiz;
        private System.Windows.Forms.Label lblPadre;
        private System.Windows.Forms.ComboBox comboBpadre;
        private System.Windows.Forms.Button btnPodarnodo;
        private System.Windows.Forms.Label lblHijo;
        private System.Windows.Forms.TextBox tBhijo;
        private System.Windows.Forms.Button btnRecorrido;
        private System.Windows.Forms.Button btnAgregarHijo;
    }
}