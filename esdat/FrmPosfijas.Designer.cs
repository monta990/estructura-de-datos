namespace esdat
{
    partial class FrmPosfijas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPosfijas));
            this.lbExpresion = new System.Windows.Forms.Label();
            this.tbExpresion = new System.Windows.Forms.TextBox();
            this.lblTope = new System.Windows.Forms.Label();
            this.dGVposfija = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.btmPasoaPaso = new System.Windows.Forms.Button();
            this.btnReinicar = new System.Windows.Forms.Button();
            this.lblInfoResultado = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEjemplo1 = new System.Windows.Forms.Button();
            this.btnEjemplo2 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVposfija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbExpresion
            // 
            this.lbExpresion.AutoSize = true;
            this.lbExpresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpresion.Location = new System.Drawing.Point(13, 13);
            this.lbExpresion.Name = "lbExpresion";
            this.lbExpresion.Size = new System.Drawing.Size(83, 18);
            this.lbExpresion.TabIndex = 0;
            this.lbExpresion.Text = "Expresión";
            // 
            // tbExpresion
            // 
            this.tbExpresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExpresion.Location = new System.Drawing.Point(103, 13);
            this.tbExpresion.Name = "tbExpresion";
            this.tbExpresion.Size = new System.Drawing.Size(430, 26);
            this.tbExpresion.TabIndex = 1;
            // 
            // lblTope
            // 
            this.lblTope.AutoSize = true;
            this.lblTope.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTope.Location = new System.Drawing.Point(13, 81);
            this.lblTope.Name = "lblTope";
            this.lblTope.Size = new System.Drawing.Size(67, 18);
            this.lblTope.TabIndex = 2;
            this.lblTope.Text = "Tope ->";
            // 
            // dGVposfija
            // 
            this.dGVposfija.AllowUserToAddRows = false;
            this.dGVposfija.AllowUserToDeleteRows = false;
            this.dGVposfija.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVposfija.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVposfija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVposfija.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVposfija.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVposfija.Location = new System.Drawing.Point(103, 81);
            this.dGVposfija.Name = "dGVposfija";
            this.dGVposfija.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVposfija.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVposfija.Size = new System.Drawing.Size(232, 347);
            this.dGVposfija.TabIndex = 3;
            this.dGVposfija.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVposfija_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Operandos";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluar.Location = new System.Drawing.Point(367, 81);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(166, 27);
            this.btnEvaluar.TabIndex = 4;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            // 
            // btmPasoaPaso
            // 
            this.btmPasoaPaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmPasoaPaso.Location = new System.Drawing.Point(367, 126);
            this.btmPasoaPaso.Name = "btmPasoaPaso";
            this.btmPasoaPaso.Size = new System.Drawing.Size(166, 27);
            this.btmPasoaPaso.TabIndex = 5;
            this.btmPasoaPaso.Text = "Paso a Paso";
            this.btmPasoaPaso.UseVisualStyleBackColor = true;
            this.btmPasoaPaso.Click += new System.EventHandler(this.btmPasoaPaso_Click);
            // 
            // btnReinicar
            // 
            this.btnReinicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinicar.Location = new System.Drawing.Point(367, 175);
            this.btnReinicar.Name = "btnReinicar";
            this.btnReinicar.Size = new System.Drawing.Size(166, 27);
            this.btnReinicar.TabIndex = 6;
            this.btnReinicar.Text = "Reiniciar";
            this.btnReinicar.UseVisualStyleBackColor = true;
            // 
            // lblInfoResultado
            // 
            this.lblInfoResultado.AutoSize = true;
            this.lblInfoResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoResultado.Location = new System.Drawing.Point(364, 229);
            this.lblInfoResultado.Name = "lblInfoResultado";
            this.lblInfoResultado.Size = new System.Drawing.Size(89, 18);
            this.lblInfoResultado.TabIndex = 7;
            this.lblInfoResultado.Text = "Resultado:";
            this.lblInfoResultado.Click += new System.EventHandler(this.lblInfoResultado_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(364, 281);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 18);
            this.lblResultado.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(578, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(665, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ejemplo de como se recorreria la expresión";
            // 
            // btnEjemplo1
            // 
            this.btnEjemplo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjemplo1.Location = new System.Drawing.Point(367, 281);
            this.btnEjemplo1.Name = "btnEjemplo1";
            this.btnEjemplo1.Size = new System.Drawing.Size(166, 31);
            this.btnEjemplo1.TabIndex = 11;
            this.btnEjemplo1.Text = "Ejemplo 1";
            this.btnEjemplo1.UseVisualStyleBackColor = true;
            this.btnEjemplo1.Click += new System.EventHandler(this.btnEjemplo1_Click);
            // 
            // btnEjemplo2
            // 
            this.btnEjemplo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjemplo2.Location = new System.Drawing.Point(367, 325);
            this.btnEjemplo2.Name = "btnEjemplo2";
            this.btnEjemplo2.Size = new System.Drawing.Size(166, 31);
            this.btnEjemplo2.TabIndex = 12;
            this.btnEjemplo2.Text = "Ejemplo 2";
            this.btnEjemplo2.UseVisualStyleBackColor = true;
            this.btnEjemplo2.Click += new System.EventHandler(this.btnEjemplo2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(367, 397);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(166, 31);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmPosfijas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 447);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEjemplo2);
            this.Controls.Add(this.btnEjemplo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblInfoResultado);
            this.Controls.Add(this.btnReinicar);
            this.Controls.Add(this.btmPasoaPaso);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.dGVposfija);
            this.Controls.Add(this.lblTope);
            this.Controls.Add(this.tbExpresion);
            this.Controls.Add(this.lbExpresion);
            this.Name = "FrmPosfijas";
            this.Text = "FrmPosfijas";
            ((System.ComponentModel.ISupportInitialize)(this.dGVposfija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbExpresion;
        private System.Windows.Forms.TextBox tbExpresion;
        private System.Windows.Forms.Label lblTope;
        private System.Windows.Forms.DataGridView dGVposfija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Button btmPasoaPaso;
        private System.Windows.Forms.Button btnReinicar;
        private System.Windows.Forms.Label lblInfoResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEjemplo1;
        private System.Windows.Forms.Button btnEjemplo2;
        private System.Windows.Forms.Button btnSalir;
    }
}