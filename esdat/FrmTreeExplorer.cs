using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace esdat
{
    public partial class FrmTreeExplorer : Form
    {
        public FrmTreeExplorer()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Carga de directorio y archivos
        /// </summary>
        private void Cargar()
        {
            TreeNode noderoot;
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "Elije una carpeta a cargar en la lista";
            folder.SelectedPath = @"D:\Tree";
            folder.ShowDialog();
            DirectoryInfo info = new DirectoryInfo(folder.SelectedPath);
            if (info.Exists)
            {
                noderoot = new TreeNode(info.Name);
                noderoot.Tag = info;
                GetDirectories(info.GetDirectories(), noderoot);
                tVfolder.Nodes.Add(noderoot);
                FileInfo[] archivos = info.GetFiles();
                foreach (FileInfo item in archivos)
                {
                    noderoot.Nodes.Add(item.ToString());
                }
            }
            else
            {
                MessageBox.Show("Directorio no existe");
            }
        }
        private void GetDirectories(DirectoryInfo []subDirs, TreeNode nodopadre)
        {
            TreeNode nodohijo;
            DirectoryInfo[] archivosdirectorio;
            foreach (DirectoryInfo subDir in subDirs)
            {
                nodohijo = new TreeNode(subDir.Name,0,0);
                nodohijo.Tag = subDir;
                //nodohijo.ImageKey = "folder";
                archivosdirectorio = subDir.GetDirectories();
                FileInfo[] Files = subDir.GetFiles();
                if (archivosdirectorio.Length != 0)
                {
                    GetDirectories(archivosdirectorio, nodohijo);   
                }
                nodopadre.Nodes.Add(nodohijo);
                foreach (FileInfo file in Files)
                {
                    nodohijo.Nodes.Add(file.ToString());
                }
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTreeExplorer_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            btnLimpiar_Click(sender, e);
            Cargar();
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
        }
    }
}