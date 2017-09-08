namespace esdat
{
    partial class TipoDatos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBstring = new System.Windows.Forms.RadioButton();
            this.rBchar = new System.Windows.Forms.RadioButton();
            this.rBdecimal = new System.Windows.Forms.RadioButton();
            this.rBdouble = new System.Windows.Forms.RadioButton();
            this.rBint = new System.Windows.Forms.RadioButton();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBstring);
            this.groupBox1.Controls.Add(this.rBchar);
            this.groupBox1.Controls.Add(this.rBdecimal);
            this.groupBox1.Controls.Add(this.rBdouble);
            this.groupBox1.Controls.Add(this.rBint);
            this.groupBox1.Location = new System.Drawing.Point(13, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos soportados";
            // 
            // rBstring
            // 
            this.rBstring.AutoSize = true;
            this.rBstring.Location = new System.Drawing.Point(18, 123);
            this.rBstring.Name = "rBstring";
            this.rBstring.Size = new System.Drawing.Size(66, 17);
            this.rBstring.TabIndex = 4;
            this.rBstring.TabStop = true;
            this.rBstring.Text = "STRING";
            this.rBstring.UseVisualStyleBackColor = true;
            // 
            // rBchar
            // 
            this.rBchar.AutoSize = true;
            this.rBchar.Location = new System.Drawing.Point(18, 100);
            this.rBchar.Name = "rBchar";
            this.rBchar.Size = new System.Drawing.Size(55, 17);
            this.rBchar.TabIndex = 3;
            this.rBchar.TabStop = true;
            this.rBchar.Text = "CHAR";
            this.rBchar.UseVisualStyleBackColor = true;
            // 
            // rBdecimal
            // 
            this.rBdecimal.AutoSize = true;
            this.rBdecimal.Location = new System.Drawing.Point(18, 77);
            this.rBdecimal.Name = "rBdecimal";
            this.rBdecimal.Size = new System.Drawing.Size(72, 17);
            this.rBdecimal.TabIndex = 2;
            this.rBdecimal.TabStop = true;
            this.rBdecimal.Text = "DECIMAL";
            this.rBdecimal.UseVisualStyleBackColor = true;
            // 
            // rBdouble
            // 
            this.rBdouble.AutoSize = true;
            this.rBdouble.Location = new System.Drawing.Point(18, 54);
            this.rBdouble.Name = "rBdouble";
            this.rBdouble.Size = new System.Drawing.Size(69, 17);
            this.rBdouble.TabIndex = 1;
            this.rBdouble.TabStop = true;
            this.rBdouble.Text = "DOUBLE";
            this.rBdouble.UseVisualStyleBackColor = true;
            // 
            // rBint
            // 
            this.rBint.AutoSize = true;
            this.rBint.Location = new System.Drawing.Point(18, 31);
            this.rBint.Name = "rBint";
            this.rBint.Size = new System.Drawing.Size(43, 17);
            this.rBint.TabIndex = 0;
            this.rBint.TabStop = true;
            this.rBint.Text = "INT";
            this.rBint.UseVisualStyleBackColor = true;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(226, 250);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 1;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elige un tipo de dato de lista y a continuación,\r\nda click en Continuar";
            // 
            // TipoDatos
            // 
            this.AcceptButton = this.btnContinuar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.groupBox1);
            this.Name = "TipoDatos";
            this.Text = "Selecciona el tipo de datos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.RadioButton rBstring;
        private System.Windows.Forms.RadioButton rBchar;
        private System.Windows.Forms.RadioButton rBdecimal;
        private System.Windows.Forms.RadioButton rBdouble;
        private System.Windows.Forms.RadioButton rBint;
        private System.Windows.Forms.Label label1;
    }
}