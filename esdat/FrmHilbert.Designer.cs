namespace esdat
{
    partial class FrmHilbert
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.chkRefresh = new System.Windows.Forms.CheckBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.cbDepth = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCanvas.Location = new System.Drawing.Point(108, 0);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(581, 466);
            this.picCanvas.TabIndex = 9;
            this.picCanvas.TabStop = false;
            // 
            // chkRefresh
            // 
            this.chkRefresh.Location = new System.Drawing.Point(6, 19);
            this.chkRefresh.Name = "chkRefresh";
            this.chkRefresh.Size = new System.Drawing.Size(64, 16);
            this.chkRefresh.TabIndex = 8;
            this.chkRefresh.Text = "Si";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(7, 144);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(95, 24);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "Dibujar";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(67, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Profundidad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkRefresh);
            this.groupBox1.Location = new System.Drawing.Point(7, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 67);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ver dibujado";
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(7, 192);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(95, 23);
            this.btGuardar.TabIndex = 11;
            this.btGuardar.Text = "Guardar Imegen";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(7, 443);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(95, 23);
            this.btSalir.TabIndex = 12;
            this.btSalir.Text = "&Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // cbDepth
            // 
            this.cbDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepth.FormattingEnabled = true;
            this.cbDepth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbDepth.Location = new System.Drawing.Point(7, 38);
            this.cbDepth.Name = "cbDepth";
            this.cbDepth.Size = new System.Drawing.Size(95, 21);
            this.cbDepth.TabIndex = 13;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 251);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(84, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mas información";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmHilbert
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 467);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cbDepth);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmHilbert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fractal de Hilbert";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHilbert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox picCanvas;
        internal System.Windows.Forms.CheckBox chkRefresh;
        internal System.Windows.Forms.Button btnGo;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.ComboBox cbDepth;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

