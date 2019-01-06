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
    public partial class gesClipboard : Form
    {
        private String dirArchivo;
        private String copiado;
        private StreamWriter escritor;
        private StreamReader lector;

        public gesClipboard()
        {
            InitializeComponent();
            
            txtAreaEstado.ForeColor = Color.Red;
            txtAreaEstado.Text = "DETENIDO...\n";

        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (!timerAutoCopiar.Enabled) { 
                txtAreaEstado.ForeColor = Color.Green;
                txtAreaEstado.AppendText("INICIADO...\n");

                timerAutoCopiar.Enabled = true;
                timerAutoCopiar.Start();
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog miFBD = new FolderBrowserDialog();
            miFBD.Description = "Indique la carpeta donde se va a guardar el archivo.";

            if (miFBD.ShowDialog() == DialogResult.OK)
            {
                dirArchivo = miFBD.SelectedPath + "\\COPIADO";
                if (rtbnArchHtml.Checked)
                    dirArchivo = dirArchivo + ".html";
                else
                {
                    if (rbtnArchText.Checked)
                        dirArchivo = dirArchivo + ".txt";
                    else
                        dirArchivo = dirArchivo + ".rtf";
                }
            }

        }

        private void btnDetener_Click(object sender, EventArgs e){
            if (timerAutoCopiar.Enabled){
                timerAutoCopiar.Stop();
                timerAutoCopiar.Enabled = false;

                txtAreaEstado.ForeColor = Color.Red;
                txtAreaEstado.Text = "DETENIDO...\n";
            }
        }

        //EVENTO
        private void timerAutoCopiar_Tick(object sender, EventArgs e)
        {
            if (dirArchivo != null)
            {
                txtDirArchivo.Text = dirArchivo;
                if (rtbnDatoText.Checked)
                    copiado = Clipboard.GetText(TextDataFormat.Text);
                else{
                    if (rtbnDatoHtml.Checked)
                        copiado = Clipboard.GetText(TextDataFormat.Html);
                    else
                        copiado = Clipboard.GetText(TextDataFormat.Rtf);
                }

                escritor = new StreamWriter(dirArchivo);

                if (rtbnArchHtml.Checked){
                    String linea = lector.ReadLine();
                    while ( linea != null)
                        linea = lector.ReadLine();
                    }

                else{
                    if (rbtnArchText.Checked)
                        return;
                    else
                        return;
                }

                //abrir archivo
                //copiar y pegar
                txtAreaEstado.ForeColor = Color.Blue;
                txtAreaEstado.AppendText("texto copiado\n");
            }
            
        }
    }
}
