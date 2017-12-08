using esdat.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace esdat
{
	public class FrmInver : Form
	{
		private double[,] Matriz;
		private double[,] MatrizAdjunta;
		private double[,] MatrizTranspuestaAdjunta;
		private double[,] MatrizInvertida;
		private double[,] MatrizIdentidad;
		private int mcg;
		private Random r = new Random();
		private double esdatdeMatriz;
		private IContainer components = null;
		private Button btn_ok;
		private DataGridView grid_Matriz;
		private DataGridView grid2;
		private DataGridView gridtrans;
		private DataGridView gridinversa;
		private DataGridView grididentiti;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
        private Label label7;
        private TextBox txt_x;
        private Button btn_datos;
        private Label label8;
        private TextBox txt_respuesta;
        private Button btlimpiar;
        private Label label6;

		public FrmInver()
		{
			this.InitializeComponent();
			this.mcg = this.r.Next(3, 5);
			this.txt_x.Text = this.mcg.ToString();
			this.CrearMatriz(this.mcg);
		}
		private void btn_datos_Click(object sender, EventArgs e)
		{
			this.mcg = int.Parse(this.txt_x.Text);
			this.CrearMatriz(this.mcg);
		}
		private void CrearMatriz(int mc)
		{
			this.grid_Matriz.Rows.Clear();
			this.grid_Matriz.Columns.Clear();
			this.gridinversa.Rows.Clear();
			this.gridinversa.Columns.Clear();
			this.grid2.Rows.Clear();
			this.grid2.Columns.Clear();
			this.gridtrans.Rows.Clear();
			this.gridtrans.Columns.Clear();
			this.grididentiti.Rows.Clear();
			this.grididentiti.Columns.Clear();
			this.Matriz = new double[mc, mc];
			for (int i = 0; i < mc; i++)
			{
				this.grid_Matriz.Columns.Add("Columna" + i.ToString(), i.ToString());
				this.grid_Matriz.Columns[i].Width = 60;
				this.grid2.Columns.Add("Columna" + i.ToString(), i.ToString());
				this.grid2.Columns[i].Width = 60;
				this.gridtrans.Columns.Add("Columna" + i.ToString(), i.ToString());
				this.gridtrans.Columns[i].Width = 60;
				this.gridinversa.Columns.Add("Columna" + i.ToString(), i.ToString());
				this.gridinversa.Columns[i].Width = 60;
				this.grididentiti.Columns.Add("Columna" + i.ToString(), i.ToString());
				this.grididentiti.Columns[i].Width = 60;
			}
			this.grid_Matriz.Rows.Add(mc);
			this.grid2.Rows.Add(mc);
			this.gridtrans.Rows.Add(mc);
			this.gridinversa.Rows.Add(mc);
			this.grididentiti.Rows.Add(mc);
			for (int i = 0; i < mc; i++)
			{
				for (int j = 0; j < mc; j++)
				{
					int num = this.r.Next(0, 10);
					this.grid_Matriz.Rows[i].Cells[j].Value = num;
				}
			}
		}
		private void btn_ok_Click(object sender, EventArgs e)
		{
			this.esdatdeMatriz = 0.0;
			for (int i = 0; i < this.mcg; i++)
			{
				for (int j = 0; j < this.mcg; j++)
				{
                    try
                    {
                        this.Matriz[i, j] = double.Parse(this.grid_Matriz.Rows[i].Cells[j].Value.ToString());
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("La celda esta vacia", "Celda Vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("No es entero", "No es entero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
				}
			}
			this.esdatdeMatriz = this.esdat(this.Matriz);
			this.txt_respuesta.Text = this.esdatdeMatriz.ToString();
			this.MatrizAdjunta = this.Adjunta(this.Matriz);
			for (int i = 0; i < this.mcg; i++)
			{
				for (int j = 0; j < this.mcg; j++)
				{
					this.grid2.Rows[i].Cells[j].Value = this.MatrizAdjunta[i, j];
				}
			}
			this.MatrizTranspuestaAdjunta = this.TransponerMatriz(this.MatrizAdjunta);
			for (int i = 0; i < this.mcg; i++)
			{
				for (int j = 0; j < this.mcg; j++)
				{
					this.gridtrans.Rows[i].Cells[j].Value = this.MatrizTranspuestaAdjunta[i, j];
				}
			}
			this.MatrizInvertida = this.matrizmenosuno(this.MatrizTranspuestaAdjunta, this.esdatdeMatriz);
			for (int i = 0; i < this.mcg; i++)
			{
				for (int j = 0; j < this.mcg; j++)
				{
					this.gridinversa.Rows[i].Cells[j].Value = this.MatrizInvertida[i, j];
				}
			}
			this.MatrizIdentidad = this.identidad(this.MatrizInvertida, this.Matriz);
			for (int i = 0; i < this.mcg; i++)
			{
				for (int j = 0; j < this.mcg; j++)
				{
					this.grididentiti.Rows[i].Cells[j].Value = this.MatrizIdentidad[i, j];
				}
			}
		}
		private double[,] identidad(double[,] inmi, double[,] inm)
		{
			int num = Convert.ToInt32(Math.Pow(double.Parse(inmi.Length.ToString()), 0.5));
			double[,] array = new double[num, num];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						array[i, j] += inm[i, k] * inmi[k, j];
					}
				}
			}
			return array;
		}
		private double[,] matrizmenosuno(double[,] mta, double deter)
		{
			int num = Convert.ToInt32(Math.Pow(double.Parse(mta.Length.ToString()), 0.5));
			double[,] array = new double[num, num];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					array[i, j] = mta[i, j] / deter;
				}
			}
			return array;
		}
		private double[,] TransponerMatriz(double[,] inmattrans)
		{
			int num = Convert.ToInt32(Math.Pow(double.Parse(inmattrans.Length.ToString()), 0.5));
			double[,] array = new double[num, num];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					array[i, j] = inmattrans[j, i];
				}
			}
			return array;
		}
		private double[,] Adjunta(double[,] inMatriz3)
		{
			int num = Convert.ToInt32(Math.Pow(double.Parse(inMatriz3.Length.ToString()), 0.5));
			double[,] array = new double[num, num];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					array[i, j] = Math.Pow(-1.0, (double)(i + j)) * this.esdat(this.ConseguirMatrizAlterna(inMatriz3, i, j));
				}
			}
			return array;
		}
		private double esdat(double[,] inMatriz)
		{
			double num = 0.0;
			double num2 = Math.Pow(double.Parse(inMatriz.Length.ToString()), 0.5);
			if (num2 == 2.0)
			{
				num = inMatriz[0, 0] * inMatriz[1, 1] - inMatriz[0, 1] * inMatriz[1, 0];
			}
			else
			{
				int num3 = Convert.ToInt32(num2 - 1.0);
				double[,] inMatriz2 = new double[num3, num3];
				int num4 = 0;
				while ((double)num4 < num2)
				{
					inMatriz2 = this.ConseguirMatrizAlterna(inMatriz, 0, num4);
					num += Math.Pow(-1.0, (double)num4) * inMatriz[0, num4] * this.esdat(inMatriz2);
					num4++;
				}
			}
			return num;
		}
		private double[,] ConseguirMatrizAlterna(double[,] inMatriz2, int posicioni, int posicionj)
		{
			int num = Convert.ToInt32(Math.Pow(double.Parse(inMatriz2.Length.ToString()), 0.5)) - 1;
			double[,] array = new double[num, num];
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				if (i == posicionj)
				{
					num2 = 1;
				}
				if (num2 == 0)
				{
					int num3 = 0;
					for (int j = 0; j < num; j++)
					{
						if (j == posicioni)
						{
							num3 = 1;
						}
						if (num3 == 0)
						{
							array[j, i] = inMatriz2[j, i];
						}
						else
						{
							array[j, i] = inMatriz2[j + 1, i];
						}
					}
				}
				else
				{
					int num3 = 0;
					for (int j = 0; j < num; j++)
					{
						if (j == posicioni)
						{
							num3 = 1;
						}
						if (num3 == 0)
						{
							array[j, i] = inMatriz2[j, i + 1];
						}
						else
						{
							array[j, i] = inMatriz2[j + 1, i + 1];
						}
					}
				}
			}
			return array;
		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_ok = new System.Windows.Forms.Button();
            this.grid_Matriz = new System.Windows.Forms.DataGridView();
            this.grid2 = new System.Windows.Forms.DataGridView();
            this.gridtrans = new System.Windows.Forms.DataGridView();
            this.gridinversa = new System.Windows.Forms.DataGridView();
            this.grididentiti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.btn_datos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_respuesta = new System.Windows.Forms.TextBox();
            this.btlimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Matriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridtrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridinversa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grididentiti)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(386, 293);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(91, 32);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "Calcular";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // grid_Matriz
            // 
            this.grid_Matriz.AllowUserToAddRows = false;
            this.grid_Matriz.AllowUserToDeleteRows = false;
            this.grid_Matriz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_Matriz.BackgroundColor = System.Drawing.Color.White;
            this.grid_Matriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Matriz.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Matriz.DefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Matriz.Location = new System.Drawing.Point(5, 120);
            this.grid_Matriz.Name = "grid_Matriz";
            this.grid_Matriz.RowHeadersVisible = false;
            this.grid_Matriz.Size = new System.Drawing.Size(372, 155);
            this.grid_Matriz.TabIndex = 4;
            this.grid_Matriz.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Matriz_CellEndEdit);
            // 
            // grid2
            // 
            this.grid2.AllowUserToAddRows = false;
            this.grid2.AllowUserToDeleteRows = false;
            this.grid2.BackgroundColor = System.Drawing.Color.White;
            this.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid2.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid2.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid2.Location = new System.Drawing.Point(5, 343);
            this.grid2.Name = "grid2";
            this.grid2.ReadOnly = true;
            this.grid2.RowHeadersVisible = false;
            this.grid2.Size = new System.Drawing.Size(372, 138);
            this.grid2.TabIndex = 5;
            this.grid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid2_CellContentClick);
            // 
            // gridtrans
            // 
            this.gridtrans.AllowUserToAddRows = false;
            this.gridtrans.AllowUserToDeleteRows = false;
            this.gridtrans.BackgroundColor = System.Drawing.Color.White;
            this.gridtrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridtrans.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridtrans.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridtrans.Location = new System.Drawing.Point(483, 343);
            this.gridtrans.Name = "gridtrans";
            this.gridtrans.ReadOnly = true;
            this.gridtrans.RowHeadersVisible = false;
            this.gridtrans.Size = new System.Drawing.Size(372, 138);
            this.gridtrans.TabIndex = 6;
            // 
            // gridinversa
            // 
            this.gridinversa.AllowUserToAddRows = false;
            this.gridinversa.AllowUserToDeleteRows = false;
            this.gridinversa.BackgroundColor = System.Drawing.Color.White;
            this.gridinversa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridinversa.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridinversa.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridinversa.Location = new System.Drawing.Point(876, 212);
            this.gridinversa.Name = "gridinversa";
            this.gridinversa.ReadOnly = true;
            this.gridinversa.RowHeadersVisible = false;
            this.gridinversa.Size = new System.Drawing.Size(372, 155);
            this.gridinversa.TabIndex = 6;
            // 
            // grididentiti
            // 
            this.grididentiti.AllowUserToAddRows = false;
            this.grididentiti.AllowUserToDeleteRows = false;
            this.grididentiti.BackgroundColor = System.Drawing.Color.White;
            this.grididentiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grididentiti.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grididentiti.DefaultCellStyle = dataGridViewCellStyle5;
            this.grididentiti.Location = new System.Drawing.Point(483, 120);
            this.grididentiti.Name = "grididentiti";
            this.grididentiti.ReadOnly = true;
            this.grididentiti.RowHeadersVisible = false;
            this.grididentiti.Size = new System.Drawing.Size(372, 155);
            this.grididentiti.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "INGRESAR MATRIZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "MATRIZ ADJUNTA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(893, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "MATRIZ INVERSA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(487, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "MATRIZ TRANSPUESTA DE LA ADJUNTA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(483, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(372, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "MATRIZ IDENTIDAD";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 45);
            this.label6.TabIndex = 8;
            this.label6.Text = "Matriz Inversa";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(98, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cantidad de filas y columnas";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(101, 60);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(61, 20);
            this.txt_x.TabIndex = 1;
            this.txt_x.Text = "3";
            this.txt_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_datos
            // 
            this.btn_datos.Location = new System.Drawing.Point(168, 60);
            this.btn_datos.Name = "btn_datos";
            this.btn_datos.Size = new System.Drawing.Size(107, 21);
            this.btn_datos.TabIndex = 0;
            this.btn_datos.Text = "Crear";
            this.btn_datos.UseVisualStyleBackColor = true;
            this.btn_datos.Click += new System.EventHandler(this.btn_datos_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(383, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Determinante";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_respuesta
            // 
            this.txt_respuesta.Location = new System.Drawing.Point(383, 185);
            this.txt_respuesta.Name = "txt_respuesta";
            this.txt_respuesta.Size = new System.Drawing.Size(94, 20);
            this.txt_respuesta.TabIndex = 1;
            this.txt_respuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btlimpiar
            // 
            this.btlimpiar.Location = new System.Drawing.Point(386, 458);
            this.btlimpiar.Name = "btlimpiar";
            this.btlimpiar.Size = new System.Drawing.Size(91, 23);
            this.btlimpiar.TabIndex = 9;
            this.btlimpiar.Text = "Salir";
            this.btlimpiar.UseVisualStyleBackColor = true;
            this.btlimpiar.Click += new System.EventHandler(this.btlimpiar_Click);
            // 
            // FrmInver
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1254, 497);
            this.Controls.Add(this.btlimpiar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grididentiti);
            this.Controls.Add(this.gridinversa);
            this.Controls.Add(this.gridtrans);
            this.Controls.Add(this.grid2);
            this.Controls.Add(this.grid_Matriz);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_respuesta);
            this.Controls.Add(this.txt_x);
            this.Controls.Add(this.btn_datos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInver";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matriz Inversa";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Matrices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Matriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridtrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridinversa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grididentiti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void grid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_Matriz_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (double.TryParse(grid_Matriz.CurrentCell.Value.ToString(), out double r))
                {
                    //valido
                }
                else
                {
                    MessageBox.Show("Solo numeros por favor", "Solo numeros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("La celda esta vacia", "Celda Vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btlimpiar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Matrices_Load(object sender, EventArgs e)
        {
            txt_x.Clear();
            txt_x.Text = "3";
        }
    }
}