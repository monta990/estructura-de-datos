namespace esdat
{
    partial class FrmMemoramaSelector
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBexperto = new System.Windows.Forms.RadioButton();
            this.rBintermedio = new System.Windows.Forms.RadioButton();
            this.rBprincipiante = new System.Windows.Forms.RadioButton();
            this.btNina = new System.Windows.Forms.Button();
            this.btNino = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vamos a jugar a Memorama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Me puedes decir tu nombre:";
            // 
            // tBnombre
            // 
            this.tBnombre.Location = new System.Drawing.Point(13, 251);
            this.tBnombre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tBnombre.Name = "tBnombre";
            this.tBnombre.Size = new System.Drawing.Size(422, 24);
            this.tBnombre.TabIndex = 3;
            this.tBnombre.Leave += new System.EventHandler(this.tBnombre_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Eres:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBexperto);
            this.groupBox1.Controls.Add(this.rBintermedio);
            this.groupBox1.Controls.Add(this.rBprincipiante);
            this.groupBox1.Location = new System.Drawing.Point(13, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(422, 138);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona la dificultad";
            // 
            // rBexperto
            // 
            this.rBexperto.AutoSize = true;
            this.rBexperto.Location = new System.Drawing.Point(27, 90);
            this.rBexperto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rBexperto.Name = "rBexperto";
            this.rBexperto.Size = new System.Drawing.Size(374, 22);
            this.rBexperto.TabIndex = 2;
            this.rBexperto.TabStop = true;
            this.rBexperto.Text = "Experto (ver cartas por un cuarto de segundo)";
            this.rBexperto.UseVisualStyleBackColor = true;
            this.rBexperto.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rBintermedio
            // 
            this.rBintermedio.AutoSize = true;
            this.rBintermedio.Location = new System.Drawing.Point(27, 58);
            this.rBintermedio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rBintermedio.Name = "rBintermedio";
            this.rBintermedio.Size = new System.Drawing.Size(347, 22);
            this.rBintermedio.TabIndex = 1;
            this.rBintermedio.TabStop = true;
            this.rBintermedio.Text = "Intermedio (ver cartas por medio segundo)";
            this.rBintermedio.UseVisualStyleBackColor = true;
            this.rBintermedio.CheckedChanged += new System.EventHandler(this.rBintermedio_CheckedChanged);
            // 
            // rBprincipiante
            // 
            this.rBprincipiante.AutoSize = true;
            this.rBprincipiante.Location = new System.Drawing.Point(27, 26);
            this.rBprincipiante.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rBprincipiante.Name = "rBprincipiante";
            this.rBprincipiante.Size = new System.Drawing.Size(328, 22);
            this.rBprincipiante.TabIndex = 0;
            this.rBprincipiante.TabStop = true;
            this.rBprincipiante.Text = "Principiante (ver cartas por un segundo)";
            this.rBprincipiante.UseVisualStyleBackColor = true;
            this.rBprincipiante.CheckedChanged += new System.EventHandler(this.rBprincipiante_CheckedChanged);
            // 
            // btNina
            // 
            this.btNina.BackColor = System.Drawing.Color.White;
            this.btNina.Image = global::esdat.Properties.Resources.niña;
            this.btNina.Location = new System.Drawing.Point(310, 319);
            this.btNina.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btNina.Name = "btNina";
            this.btNina.Size = new System.Drawing.Size(125, 188);
            this.btNina.TabIndex = 5;
            this.btNina.UseVisualStyleBackColor = false;
            this.btNina.Click += new System.EventHandler(this.btNina_Click);
            // 
            // btNino
            // 
            this.btNino.BackColor = System.Drawing.Color.White;
            this.btNino.Image = global::esdat.Properties.Resources.niño;
            this.btNino.Location = new System.Drawing.Point(13, 319);
            this.btNino.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btNino.Name = "btNino";
            this.btNino.Size = new System.Drawing.Size(125, 188);
            this.btNino.TabIndex = 4;
            this.btNino.UseVisualStyleBackColor = false;
            this.btNino.Click += new System.EventHandler(this.btNino_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 404);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(449, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.sToolStripMenuItem.Text = "Salir a Menú Principal";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // SelectorMemorama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 529);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btNina);
            this.Controls.Add(this.btNino);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SelectorMemorama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selector de Memorama";
            this.Load += new System.EventHandler(this.SelectorMemorama_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBexperto;
        private System.Windows.Forms.RadioButton rBintermedio;
        private System.Windows.Forms.RadioButton rBprincipiante;
        private System.Windows.Forms.Button btNino;
        private System.Windows.Forms.Button btNina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
    }
}