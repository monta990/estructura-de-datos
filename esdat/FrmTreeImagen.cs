using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esdat
{
    public partial class FrmTreeImagen : Form
    {
        public FrmTreeImagen()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

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
    }
}
