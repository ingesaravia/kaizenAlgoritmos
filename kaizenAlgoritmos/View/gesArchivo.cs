using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaizenAlgoritmos.View
{
    public partial class gesArchivo : Form
    {
        public string dirArchivo;
        public string dirTreeView;

        public gesArchivo()
        {
            InitializeComponent();

            dirTreeView = Path.GetTempPath();
            cargarTreeView(dirTreeView);
            listView1.MultiSelect = false;
        }

        #region
        /// <summary>
        /// METODOS DEL TREEVIEW
        /// </summary>
        public void cargarTreeView(string dirTreeView) {
            //limpiar TreeView
            if (treeView1.Nodes.Count > 0)
            treeView1.Nodes.Clear();
            
            //populate treeview
            TreeNode rootNode;
            DirectoryInfo info = new DirectoryInfo(dirTreeView);
            if (info.Exists)
            {
              rootNode = new TreeNode(info.Name);
              rootNode.Tag = info;

              getDirectories(info.GetDirectories(), rootNode);
              treeView1.Nodes.Add(rootNode);
            }
        }

        public void getDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo) {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";

                //controlar si los directorios son de sistema o no
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    getDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //se obtiene el nodo a través del argumento "e"
            TreeNode seleccionado = e.Node;
            txtDirArchivo.Text = seleccionado.FullPath + seleccionado.Name;

            //se muestra cada archivo del directorio dentro del listView
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                          {
                           new ListViewItem.ListViewSubItem(item, "Directory"),
                           new ListViewItem.ListViewSubItem(item, 
                            dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                          { new ListViewItem.ListViewSubItem(item, "File"),
                            new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listView1_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            txtPropFile.Clear();
            int seleccionado = e.Item.Index;
            listView1.Items[seleccionado].Focused = true;
            listView1.Items[seleccionado].Selected = true;
            dirArchivo = dirTreeView + listView1.Items[seleccionado].Name;
            txtPropFile.AppendText(dirArchivo);
            txtPropFile.AppendText(listView1.Items[seleccionado].SubItems[0].Text + "\n");
            txtPropFile.AppendText(listView1.Items[seleccionado].SubItems[1].Text + "\n");
            txtPropFile.AppendText(listView1.Items[seleccionado].SubItems[2].Text + "\n");

        }

        #endregion

        #region
        /// METODOS DE LOS ARCHIVOS
        ///

        #endregion


        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog mOpenFile = new OpenFileDialog();
            mOpenFile.Multiselect = false;
            mOpenFile.Title = "Seleccione un archivo";

            if (mOpenFile.ShowDialog() == DialogResult.OK)
            {
                string dirCadena = mOpenFile.FileName;
                dirTreeView = dirCadena.Replace(mOpenFile.SafeFileName, "");
                txtDirArchivo.Text = dirTreeView;
                cargarTreeView(dirTreeView);    
            }
        }



        private void readToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtPropFile.Clear();

            StreamReader lector = new StreamReader(dirArchivo);
            string linea = lector.ReadLine();
            while (linea != null)
            {
                txtPropFile.AppendText(linea + "\n");
                linea = lector.ReadLine();

            }
            lector.Close();
        }

 
    }
}
