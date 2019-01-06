using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaizenAlgoritmos.View
{
    public partial class gesConectividad : Form
    {
        public gesConectividad()
        {
            InitializeComponent();
            /* COMANDOS 
            ipconfig /all > backup.txt guarda la config de red en un archivo
                     /release IP para liberar del ip al adaptador
                     /renew renueva la dir ip para el adaptador
                     /flushdns purga la cache de resolucion de dns
                     /registerdns calcula y vuelve a registrar nombres de dns
                     /displaydns mustra el contenido de la cache de dns
            ping -t hasta que el servidor responda
                -L longitd donde con lognitud se indica el tamaño del buffer
            */
        }

        private void btnEjecutarPING_Click(object sender, EventArgs e)
        {
            string estado = "";
            string puerto = "";
            string URL = txtURL.Text;
            string comando = "/C PING ";
            // comando /C es para que se cierre luego de ejecutarse.
            ejecutar(URL, comando, estado, puerto);
        }

        private void buttonEjecutarNETSTAT_Click(object sender, EventArgs e)
        {
            string URL = "";
            string comando = "/K NETSTAT -AN|FINDSTR /C:";
            string estado = "";
            string puerto = "";

            if (radioButton1.Checked)
                estado = "LISTENING ";
            else
                if (radioButton2.Checked)
                estado = "ESTABLISHED ";
            else
                    if (radioButton3.Checked)
                estado = "CLOSE_WAIT ";
            else
                        if (radioButton4.Checked)
                estado = "TIME_WAIT ";
            else
                            if (radioButton5.Checked)
                estado = "LAST_ACK ";
            else
                                if (radioButton6.Checked)
                estado = "CLOSED ";
            else
                comando = "/K NETSTAT -AN";

            //if (comboBox1.SelectedItem != null)
            //    puerto = comboBox1.SelectedValue.ToString();

            ejecutar(URL,comando, estado, puerto);
        }

        private void ejecutar(string URL, string comando, string estado, string puerto)
        {

            txtCMDOutput.Clear();
            txtCMDOutput.Text = "Trabajando...";

            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", comando + URL + estado + puerto);

            // Indicamos que la salida del proceso se redireccione en un Stream
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            //Indica que el proceso no despliegue una pantalla negra (El proceso se ejecuta en background)
            procStartInfo.CreateNoWindow = true;
            //Inicializa el proceso

            Process miProceso = new System.Diagnostics.Process();
            miProceso.StartInfo = procStartInfo;
            miProceso.Start();
            //Consigue la salida de la Consola(Stream) y devuelve una cadena de texto
            string resultado = miProceso.StandardOutput.ReadToEnd();

            //Muestra en pantalla la salida del Comando
            txtCMDOutput.AppendText(resultado);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            string dirHosts = "C:\\WINDOWS\\System32\\drivers\\etc\\hosts";

            //usar streamreader streamwriter
            StreamReader lectorHosts = new StreamReader(dirHosts);
            string linea = lectorHosts.ReadLine();
            while (linea != null) {
                txtCMDOutput.AppendText(linea + "\n");
                linea = lectorHosts.ReadLine();
                
            }
            lectorHosts.Close();
            
        }

        private void btnAgregarDirIP_Click(object sender, EventArgs e)
        {
            
        }
    }


}
