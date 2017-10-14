namespace esdat
{
    partial class FrmTranspuesta
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
            this.dGVmatrizAT = new System.Windows.Forms.DataGridView();
            this.dGVmatrizA = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnTranspuesta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVmatrizAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVmatrizA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVmatrizAT
            // 
            this.dGVmatrizAT.AllowUserToAddRows = false;
            this.dGVmatrizAT.AllowUserToDeleteRows = false;
            this.dGVmatrizAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVmatrizAT.Location = new System.Drawing.Point(19, 19);
            this.dGVmatrizAT.Name = "dGVmatrizAT";
            this.dGVmatrizAT.Size = new System.Drawing.Size(469, 150);
            this.dGVmatrizAT.TabIndex = 0;
            // 
            // dGVmatrizA
            // 
            this.dGVmatrizA.AllowUserToAddRows = false;
            this.dGVmatrizA.AllowUserToDeleteRows = false;
            this.dGVmatrizA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVmatrizA.Location = new System.Drawing.Point(19, 19);
            this.dGVmatrizA.Name = "dGVmatrizA";
            this.dGVmatrizA.Size = new System.Drawing.Size(469, 150);
            this.dGVmatrizA.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVmatrizA);
            this.groupBox1.Location = new System.Drawing.Point(67, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGVmatrizAT);
            this.groupBox2.Location = new System.Drawing.Point(67, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 185);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "A=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aᵀ =";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(86, 429);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(120, 23);
            this.btnRandom.TabIndex = 6;
            this.btnRandom.Text = "Generar Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnTranspuesta
            // 
            this.btnTranspuesta.Location = new System.Drawing.Point(413, 429);
            this.btnTranspuesta.Name = "btnTranspuesta";
            this.btnTranspuesta.Size = new System.Drawing.Size(142, 23);
            this.btnTranspuesta.TabIndex = 7;
            this.btnTranspuesta.Text = "Generar Transpuesta";
            this.btnTranspuesta.UseVisualStyleBackColor = true;
            this.btnTranspuesta.Click += new System.EventHandler(this.btnTranspuesta_Click);
            // 
            // FrmTranspuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 487);
            this.Controls.Add(this.btnTranspuesta);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTranspuesta";
            this.Text = "Transpuesta";
            this.Load += new System.EventHandler(this.FrmTranspuesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVmatrizAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVmatrizA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVmatrizAT;
        private System.Windows.Forms.DataGridView dGVmatrizA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnTranspuesta;
    }
}