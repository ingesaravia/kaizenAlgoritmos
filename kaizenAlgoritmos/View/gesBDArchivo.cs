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
    public partial class gesBDArchivo : Form
    {
        public string dirArchivo;
        public gesBDArchivo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (File.Exists(dirArchivo)) {
                StreamWriter escritor = new StreamWriter(dirArchivo);

                //contar cantidad de filas del archivo
                escritor.WriteLine("numero;" + txtNomAp.Text + ";" + txtDomicilio.Text + ";");
                escritor.Close();
            }
        }

        private void gesBDArchivo_Load(object sender, EventArgs e)
        {
            //cargar DataGridView
            if (File.Exists(dirArchivo)) {
                StreamReader lector = new StreamReader(dirArchivo);

                int i = 0;
                string linea = lector.ReadLine();
                while (linea != null)
                {
                    string numero; //= linea.Substring
                    string nombre; // = linea.Substring
                    string domicilio; // = linea.Substring
                    dataGridViewBDArchivo.Rows[i].Cells[0].Value = "numero";
                    dataGridViewBDArchivo.Rows[i].Cells[1].Value = "nombre";
                    dataGridViewBDArchivo.Rows[i].Cells[2].Value = "domicilio";
                    linea = lector.ReadLine();
                    i++;
                }
                lector.Close();
            }
            
        }
    }
}
