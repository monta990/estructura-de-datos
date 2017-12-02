using System;
using System.Windows.Forms;
namespace esdat
{
    public partial class FrmTreeIcono : Form
    {
        public FrmTreeIcono() => InitializeComponent();
        private void treeView1_Click(object sender, EventArgs e)
        {
            foreach (TreeNode item in ((TreeView)sender).Nodes)
            {
                if (item.Parent== null)
                {
                    if (item.IsSelected)
                    {
                        item.ImageIndex = 3;
                    }
                    else
                    {
                        item.ImageIndex = 0;
                    }
                }
                else
                {
                    item.ImageIndex = 1;
                }
            }
        }
        private void btnSalir_Click(object sender, EventArgs e) => this.Close();
    }
}