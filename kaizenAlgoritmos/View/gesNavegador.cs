using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaizenAlgoritmos.View
{
    public partial class gesNavegador : Form
    {
        private string dirArchivo;
        private string dirURL;
        public gesNavegador()
        {
            InitializeComponent();
            webBrowser1.AllowNavigation = true;
            webBrowser1.IsWebBrowserContextMenuEnabled = true;
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.ScrollBarsEnabled = true;

            txtEstadoCliente.Text = webBrowser1.ReadyState.ToString();
            
        }

        private void btnExaminarFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog miOPF = new OpenFileDialog();
            miOPF.Filter = "html files (*.html)|*.html";
            miOPF.Title = "Seleccione el archivo offline del sitio web";
            
            if (miOPF.ShowDialog() == DialogResult.OK)
            {
                dirArchivo = miOPF.FileName;
                webBrowser1.Navigate(dirArchivo);

                conexion.Text = "Modo: OFFLINE";
            }
        }

        private void btnNavegarURL_Click(object sender, EventArgs e)
        {
        
            if (txtURL.Text != null)
            {
                conexion.Text = "Modo: ONLINE";
                dirURL = txtURL.Text;
                webBrowser1.Navigate("http:\\" + dirURL);
                txtEstadoCliente.Text = webBrowser1.ReadyState.ToString();
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            conexion.Text = "Modo: ONLINE";
            webBrowser1.Navigate(comboBox1.SelectedItem.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //AGREGAR 2 EVENTOS PARA CONTROLAR LOS ESTADOS DEL CLIENTE Y DEL SERVIDOR
    }
}
