﻿namespace esdat
{
    partial class FrmTreeImagen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Tabla 1", 2, 3);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tabla 2", 2, 3);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Punto_Venta", 1, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Tabla 4", 2, 3);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Tabla 5", 2, 3);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Consultorio", 1, 0, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Tabla 1");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Tabla 2", 2, 3);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Control_Escolar", 1, 0, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTreeImagen));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.iLiTree = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.iLiTree;
            this.treeView1.Location = new System.Drawing.Point(22, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 2;
            treeNode1.Name = "Node1";
            treeNode1.SelectedImageIndex = 3;
            treeNode1.Text = "Tabla 1";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "Node3";
            treeNode2.SelectedImageIndex = 3;
            treeNode2.Text = "Tabla 2";
            treeNode3.BackColor = System.Drawing.Color.Silver;
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "Node0";
            treeNode3.SelectedImageIndex = 0;
            treeNode3.Text = "Punto_Venta";
            treeNode3.ToolTipText = "Base de datos";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "Node5";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Text = "Tabla 4";
            treeNode5.ImageIndex = 2;
            treeNode5.Name = "Node6";
            treeNode5.SelectedImageIndex = 3;
            treeNode5.Text = "Tabla 5";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "Node4";
            treeNode6.SelectedImageIndex = 0;
            treeNode6.Text = "Consultorio";
            treeNode7.ImageIndex = 2;
            treeNode7.Name = "Node8";
            treeNode7.SelectedImageKey = "tbunselect.png";
            treeNode7.Text = "Tabla 1";
            treeNode8.ImageIndex = 2;
            treeNode8.Name = "Node9";
            treeNode8.SelectedImageIndex = 3;
            treeNode8.Text = "Tabla 2";
            treeNode9.ImageIndex = 1;
            treeNode9.Name = "Node7";
            treeNode9.SelectedImageIndex = 0;
            treeNode9.Text = "Control_Escolar";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(198, 371);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // iLiTree
            // 
            this.iLiTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iLiTree.ImageStream")));
            this.iLiTree.TransparentColor = System.Drawing.Color.Transparent;
            this.iLiTree.Images.SetKeyName(0, "dbselect.png");
            this.iLiTree.Images.SetKeyName(1, "dbunselect.png");
            this.iLiTree.Images.SetKeyName(2, "tbselected.png");
            this.iLiTree.Images.SetKeyName(3, "tbunselect.png");
            // 
            // FrmTreeImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 409);
            this.Controls.Add(this.treeView1);
            this.Name = "FrmTreeImagen";
            this.Text = "FrmTreeImagen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList iLiTree;
    }
}