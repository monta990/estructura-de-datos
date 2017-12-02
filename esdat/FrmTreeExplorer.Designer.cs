namespace esdat
{
    partial class FrmTreeExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTreeExplorer));
            this.tVfolder = new System.Windows.Forms.TreeView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnExpandir = new System.Windows.Forms.Button();
            this.btnContraer = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tVfolder
            // 
            this.tVfolder.Location = new System.Drawing.Point(5, 8);
            this.tVfolder.Name = "tVfolder";
            this.tVfolder.Size = new System.Drawing.Size(226, 385);
            this.tVfolder.TabIndex = 0;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(237, 8);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(166, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar Directorio";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnExpandir
            // 
            this.btnExpandir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpandir.Location = new System.Drawing.Point(237, 56);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(75, 23);
            this.btnExpandir.TabIndex = 2;
            this.btnExpandir.Text = "Expandir";
            this.btnExpandir.UseVisualStyleBackColor = true;
            this.btnExpandir.Click += new System.EventHandler(this.btnExpandir_Click);
            // 
            // btnContraer
            // 
            this.btnContraer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContraer.Location = new System.Drawing.Point(328, 56);
            this.btnContraer.Name = "btnContraer";
            this.btnContraer.Size = new System.Drawing.Size(75, 23);
            this.btnContraer.TabIndex = 3;
            this.btnContraer.Text = "Contraer";
            this.btnContraer.UseVisualStyleBackColor = true;
            this.btnContraer.Click += new System.EventHandler(this.btnContraer_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(237, 104);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(166, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(237, 166);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(166, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripción.Location = new System.Drawing.Point(236, 222);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(299, 160);
            this.lblDescripción.TabIndex = 6;
            this.lblDescripción.Text = resources.GetString("lblDescripción.Text");
            // 
            // FrmTreeExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 410);
            this.Controls.Add(this.lblDescripción);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnContraer);
            this.Controls.Add(this.btnExpandir);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.tVfolder);
            this.Name = "FrmTreeExplorer";
            this.Text = "Explorador con Arboles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tVfolder;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnExpandir;
        private System.Windows.Forms.Button btnContraer;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblDescripción;
    }
}