namespace esdat
{
    partial class FrmStackGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStackGen));
            this.dGVpila = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblElemento = new System.Windows.Forms.Label();
            this.tBelemento = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnElementAT = new System.Windows.Forms.Button();
            this.btnReversa = new System.Windows.Forms.Button();
            this.lblnumelementos = new System.Windows.Forms.Label();
            this.lblnumeros = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.picPush = new System.Windows.Forms.PictureBox();
            this.picPop = new System.Windows.Forms.PictureBox();
            this.lblPush = new System.Windows.Forms.Label();
            this.lblPop = new System.Windows.Forms.Label();
            this.llblInfo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dGVpila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPop)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVpila
            // 
            this.dGVpila.AllowUserToAddRows = false;
            this.dGVpila.AllowUserToDeleteRows = false;
            this.dGVpila.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVpila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVpila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dGVpila.Location = new System.Drawing.Point(13, 13);
            this.dGVpila.Name = "dGVpila";
            this.dGVpila.ReadOnly = true;
            this.dGVpila.Size = new System.Drawing.Size(176, 439);
            this.dGVpila.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pila";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Location = new System.Drawing.Point(199, 16);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(51, 13);
            this.lblElemento.TabIndex = 1;
            this.lblElemento.Text = "Elemento";
            // 
            // tBelemento
            // 
            this.tBelemento.Location = new System.Drawing.Point(256, 13);
            this.tBelemento.Name = "tBelemento";
            this.tBelemento.Size = new System.Drawing.Size(119, 20);
            this.tBelemento.TabIndex = 2;
            this.tBelemento.TextChanged += new System.EventHandler(this.tBelemento_TextChanged);
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(397, 13);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(191, 23);
            this.btnPush.TabIndex = 3;
            this.btnPush.Text = "Push()";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(397, 62);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(191, 23);
            this.btnPop.TabIndex = 4;
            this.btnPop.Text = "Pop()";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(397, 111);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(191, 23);
            this.btnPeek.TabIndex = 5;
            this.btnPeek.Text = "Peek()";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(397, 157);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(191, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear()";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(397, 203);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(191, 23);
            this.btnContains.TabIndex = 7;
            this.btnContains.Text = "Contains()";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnElementAT
            // 
            this.btnElementAT.Location = new System.Drawing.Point(397, 248);
            this.btnElementAT.Name = "btnElementAT";
            this.btnElementAT.Size = new System.Drawing.Size(191, 23);
            this.btnElementAT.TabIndex = 8;
            this.btnElementAT.Text = "ElementAt()";
            this.btnElementAT.UseVisualStyleBackColor = true;
            this.btnElementAT.Click += new System.EventHandler(this.btnElementAT_Click);
            // 
            // btnReversa
            // 
            this.btnReversa.Location = new System.Drawing.Point(397, 291);
            this.btnReversa.Name = "btnReversa";
            this.btnReversa.Size = new System.Drawing.Size(191, 23);
            this.btnReversa.TabIndex = 9;
            this.btnReversa.Text = "Reverse()";
            this.btnReversa.UseVisualStyleBackColor = true;
            this.btnReversa.Click += new System.EventHandler(this.btnReversa_Click);
            // 
            // lblnumelementos
            // 
            this.lblnumelementos.AutoSize = true;
            this.lblnumelementos.Location = new System.Drawing.Point(199, 296);
            this.lblnumelementos.Name = "lblnumelementos";
            this.lblnumelementos.Size = new System.Drawing.Size(113, 13);
            this.lblnumelementos.TabIndex = 10;
            this.lblnumelementos.Text = "Numero de elementos:";
            // 
            // lblnumeros
            // 
            this.lblnumeros.AutoSize = true;
            this.lblnumeros.Location = new System.Drawing.Point(318, 296);
            this.lblnumeros.Name = "lblnumeros";
            this.lblnumeros.Size = new System.Drawing.Size(13, 13);
            this.lblnumeros.TabIndex = 11;
            this.lblnumeros.Text = "0";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(397, 429);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(191, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // picPush
            // 
            this.picPush.Image = ((System.Drawing.Image)(resources.GetObject("picPush.Image")));
            this.picPush.Location = new System.Drawing.Point(600, 31);
            this.picPush.Name = "picPush";
            this.picPush.Size = new System.Drawing.Size(319, 392);
            this.picPush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPush.TabIndex = 13;
            this.picPush.TabStop = false;
            // 
            // picPop
            // 
            this.picPop.Image = ((System.Drawing.Image)(resources.GetObject("picPop.Image")));
            this.picPop.Location = new System.Drawing.Point(926, 34);
            this.picPop.Name = "picPop";
            this.picPop.Size = new System.Drawing.Size(327, 385);
            this.picPop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPop.TabIndex = 14;
            this.picPop.TabStop = false;
            // 
            // lblPush
            // 
            this.lblPush.AutoSize = true;
            this.lblPush.Location = new System.Drawing.Point(600, 15);
            this.lblPush.Name = "lblPush";
            this.lblPush.Size = new System.Drawing.Size(86, 13);
            this.lblPush.TabIndex = 15;
            this.lblPush.Text = "Ejemplo de Push";
            // 
            // lblPop
            // 
            this.lblPop.AutoSize = true;
            this.lblPop.Location = new System.Drawing.Point(923, 13);
            this.lblPop.Name = "lblPop";
            this.lblPop.Size = new System.Drawing.Size(81, 13);
            this.lblPop.TabIndex = 16;
            this.lblPop.Text = "Ejemplo de Pop";
            // 
            // llblInfo
            // 
            this.llblInfo.AutoSize = true;
            this.llblInfo.Location = new System.Drawing.Point(600, 438);
            this.llblInfo.Name = "llblInfo";
            this.llblInfo.Size = new System.Drawing.Size(96, 13);
            this.llblInfo.TabIndex = 17;
            this.llblInfo.TabStop = true;
            this.llblInfo.Text = "Mas información....";
            this.llblInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblInfo_LinkClicked);
            // 
            // FrmStackGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 472);
            this.Controls.Add(this.llblInfo);
            this.Controls.Add(this.lblPop);
            this.Controls.Add(this.lblPush);
            this.Controls.Add(this.picPop);
            this.Controls.Add(this.picPush);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblnumeros);
            this.Controls.Add(this.lblnumelementos);
            this.Controls.Add(this.btnReversa);
            this.Controls.Add(this.btnElementAT);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.tBelemento);
            this.Controls.Add(this.lblElemento);
            this.Controls.Add(this.dGVpila);
            this.Name = "FrmStackGen";
            this.Text = "Manejo de Pila Generica";
            this.Load += new System.EventHandler(this.FrmStackGen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVpila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVpila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.TextBox tBelemento;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnElementAT;
        private System.Windows.Forms.Button btnReversa;
        private System.Windows.Forms.Label lblnumelementos;
        private System.Windows.Forms.Label lblnumeros;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox picPush;
        private System.Windows.Forms.PictureBox picPop;
        private System.Windows.Forms.Label lblPush;
        private System.Windows.Forms.Label lblPop;
        private System.Windows.Forms.LinkLabel llblInfo;
    }
}