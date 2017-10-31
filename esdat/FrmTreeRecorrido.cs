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
    public partial class FrmTreeRecorrido : Form
    {
        private bool control = false;
        private string Rocorridos;
        private List<String> Lista = new List<String>();
        public FrmTreeRecorrido()
        {
            InitializeComponent();
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            tVfolder.ExpandAll();
        }

        private void btnContraer_Click(object sender, EventArgs e)
        {
            tVfolder.CollapseAll();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tVfolder.Nodes.Clear();
            comboBpadre.Items.Clear();
            if (tVfolder.Nodes.Count == 0)
            {
                control = true;
                Enadis();
            }
        }
        /// <summary>
        /// Control de ENAble y DISable
        /// </summary>
        private void Enadis()
        {
            if (control)
            {
                tBraiz.Enabled = true;
                btnAgregarPadre.Enabled = true;
            }
            else
            {
                tBraiz.Enabled = false;
                btnAgregarPadre.Enabled = false;
            }
        }
        /// <summary>
        /// Carga los  nodos de ejemplo
        /// </summary>
        private void Ejemplo()
        {
            tVfolder.Nodes.Add("Node0");
            tVfolder.Nodes[0].Nodes.Add("Node1");
            tVfolder.Nodes[0].Nodes.Add("Node2");
            tVfolder.Nodes[0].Nodes[1].Nodes.Add("Node3");
            tVfolder.Nodes[0].Nodes[1].Nodes.Add("Node4");
            Lista.Add("Node0");
            Lista.Add("Node1");
            Lista.Add("Node2");
            Lista.Add("Node3");
            Lista.Add("Node4");
        }
        /// <summary>
        /// Carga de Raiz
        /// </summary>
        /// <param name="treeView">Treeview a analizar</param>
        private void CallRecursive(TreeView treeView)
        {
            TreeNodeCollection nodos = treeView.Nodes;
            foreach (TreeNode item in nodos)
            {
                ImprimirRecursivo(item);
            }
        }
        /// <summary>
        /// Carga de hijos
        /// </summary>
        /// <param name="treeNode">Treeview a analizar</param>
        private void ImprimirRecursivo(TreeNode treeNode)
        {
            comboBpadre.Items.Add(treeNode.Text);
            foreach (TreeNode item in treeNode.Nodes)
            {
                ImprimirRecursivo(item);
            }
        }
        private void CallRecursive2(TreeView treeView)
        {
            TreeNodeCollection nodos = treeView.Nodes;
            foreach (TreeNode item in nodos)
            {
                ImprimirRecursivo2(item);
            }
        }
        private void ImprimirRecursivo2(TreeNode treeNode)
        {
            foreach (TreeNode item in treeNode.Nodes)
            {
                ImprimirRecursivo2(item);
            }
            if (treeNode.Text == comboBpadre.Text)
            {
                if (Lista.Contains(tBhijo.Text))
                {
                    MessageBox.Show("Que parte de repetidos no entendiste", "REPETIDOOOOO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    treeNode.Nodes.Add(tBhijo.Text);
                    Lista.Add(tBhijo.Text);
                }
            }
        }
        /// <summary>
        /// Recorido de treeview
        /// </summary>
        /// <param name="collection"></param>
        private void Recorrido(TreeNodeCollection collection)
        {
            foreach (TreeNode item in collection)
            {
                if (item.Nodes.Count == 0)
                {
                    Rocorridos += "\n Hijo: " + item.Text;
                }
                else
                {
                    Rocorridos += "\n Padre: " + item.Text;
                    Recorrido(item.Nodes);
                }
            }
        }
        private void FrmTreeRecorrido_Load(object sender, EventArgs e)
        {
            Ejemplo();
            CallRecursive(tVfolder);
            comboBpadre.Text = comboBpadre.Items[0].ToString();
            btnExpandir_Click(sender,e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CallRecursive3(TreeView treeView)
        {
            TreeNodeCollection nodos = treeView.Nodes;
            foreach (TreeNode item in nodos)
            {
                ImprimirRecursivo3(item);
            }
        }
        private void ImprimirRecursivo3(TreeNode treeNode)
        {
            foreach (TreeNode item in treeNode.Nodes)
            {
                if (item.Text == comboBpadre.Text)
                {
                    Lista.Remove(comboBpadre.Text);
                    foreach (TreeNode hijos in item.Nodes)
                    {
                        //MessageBox.Show(hijos.Text);
                        Lista.Remove(hijos.Text);
                    }
                    item.Remove();
                    break;
                }
                else
                {
                    //MessageBox.Show(item.Text);
                    ImprimirRecursivo3(item);
                }
            }
        }
        private void btnPodarnodo_Click(object sender, EventArgs e)
        {
            
            CallRecursive3(tVfolder);
            comboBpadre.Items.Clear();
            foreach (var item in Lista)
            {
                comboBpadre.Items.Add(item.ToString());
            }
            comboBpadre.Text = comboBpadre.Items[0].ToString();
        }

        private void btnAgregarPadre_Click(object sender, EventArgs e)
        {
            tVfolder.Nodes.Add(tBraiz.Text);
            tBraiz.Clear();
            Lista.Clear();
            comboBpadre.Items.Clear();
            CallRecursive(tVfolder);
            comboBpadre.Text = comboBpadre.Items[0].ToString();
            control = false;
            Enadis();
        }

        private void btnAgregarHijo_Click(object sender, EventArgs e)
        {
            if (tBhijo.Text.Trim() == "")
            {
                MessageBox.Show("No hay texto", "ESTA VACIO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                CallRecursive2(tVfolder);
                comboBpadre.Items.Clear();
                CallRecursive(tVfolder);
                comboBpadre.Text = comboBpadre.Items[0].ToString();
                tBhijo.Clear();
                tBhijo.Focus();
            }
        }

        private void tBhijo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRecorrido_Click(object sender, EventArgs e)
        {
            Recorrido(tVfolder.Nodes);
            MessageBox.Show(Rocorridos);
        }
    }
}
