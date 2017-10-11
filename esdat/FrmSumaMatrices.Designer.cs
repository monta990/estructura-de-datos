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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMatriz1 = new System.Windows.Forms.Label();
            this.lblMatriz2 = new System.Windows.Forms.Label();
            this.lblMatrizResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVmatriz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVmatriz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVresultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVmatriz1
            // 
            this.dGVmatriz1.AllowUserToAddRows = false;
            this.dGVmatriz1.AllowUserToDeleteRows = false;
            this.dGVmatriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVmatriz1.Location = new System.Drawing.Point(25, 47);
            this.dGVmatriz1.Name = "dGVmatriz1";
            this.dGVmatriz1.Size = new System.Drawing.Size(240, 150);
            this.dGVmatriz1.TabIndex = 0;
            // 
            // dGVmatriz2
            // 
            this.dGVmatriz2.AllowUserToAddRows = false;
            this.dGVmatriz2.AllowUserToDeleteRows = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "+";
            // 
            // lblMatriz1
            // 
            this.lblMatriz1.AutoSize = true;
            this.lblMatriz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatriz1.Location = new System.Drawing.Point(18, 7);
            this.lblMatriz1.Name = "lblMatriz1";
            this.lblMatriz1.Size = new System.Drawing.Size(97, 25);
            this.lblMatriz1.TabIndex = 5;
            this.lblMatriz1.Text = "Matriz 1";
            // 
            // lblMatriz2
            // 
            this.lblMatriz2.AutoSize = true;
            this.lblMatriz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatriz2.Location = new System.Drawing.Point(303, 9);
            this.lblMatriz2.Name = "lblMatriz2";
            this.lblMatriz2.Size = new System.Drawing.Size(97, 25);
            this.lblMatriz2.TabIndex = 6;
            this.lblMatriz2.Text = "Matriz 2";
            // 
            // lblMatrizResultado
            // 
            this.lblMatrizResultado.AutoSize = true;
            this.lblMatrizResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatrizResultado.Location = new System.Drawing.Point(598, 7);
            this.lblMatrizResultado.Name = "lblMatrizResultado";
            this.lblMatrizResultado.Size = new System.Drawing.Size(118, 25);
            this.lblMatrizResultado.TabIndex = 7;
            this.lblMatrizResultado.Text = "Resultado";
            // 
            // FrmSumaMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 323);
            this.Controls.Add(this.lblMatrizResultado);
            this.Controls.Add(this.lblMatriz2);
            this.Controls.Add(this.lblMatriz1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.dGVresultado);
            this.Controls.Add(this.dGVmatriz2);
            this.Controls.Add(this.dGVmatriz1);
            this.Name = "FrmSumaMatrices";
            this.Text = "FrmSumaMatrices";
            this.Load += new System.EventHandler(this.FrmSumaMatrices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVmatriz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVmatriz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVresultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVmatriz1;
        private System.Windows.Forms.DataGridView dGVmatriz2;
        private System.Windows.Forms.DataGridView dGVresultado;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMatriz1;
        private System.Windows.Forms.Label lblMatriz2;
        private System.Windows.Forms.Label lblMatrizResultado;
    }
}