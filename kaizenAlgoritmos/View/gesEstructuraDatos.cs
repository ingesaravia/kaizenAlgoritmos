using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kaizenAlgoritmos.Class;

namespace kaizenAlgoritmos.View
{
    public partial class gesEstructuraDatos : Form
    {
        private claseListas miListas;
        private claseArreglos miArreglos;
        private int tipoLista;

        public gesEstructuraDatos()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenLista_Click(object sender, EventArgs e)
        {
            miListas = new claseListas();

            //Seleccionar el radiobutton adecuado
            if (rdListaEnt.Checked)
            {
                tipoLista = 1;
                miListas.genListaEnterosRandom();
            }
            else
                if (rdListaCar.Checked) {
                tipoLista = 2;
                miListas.genListaCaracteresRandom();
            }
                
            else {
                tipoLista = 3;
                miListas.genListaCadenasRandom();
            }
                
        }

        private void btnEjecLista_Click(object sender, EventArgs e)
        {
            if (cmbOrdenLista.SelectedItem != null) {
                string opcion = cmbOrdenLista.SelectedItem.ToString();
                if (opcion == "Buscar Repetidos")
                    buscarRepetidosLista();
                if (opcion == "Eliminar Repetidos")
                    eliminarRepetidosLista();
            }
        }

        private void ordenarLista() {
            if (miListas != null) {
                if (tipoLista == 1)
                    miListas.ordenarListaEnteros();
            }
        }
        private void buscarRepetidosLista() {

        }

        private void eliminarRepetidosLista() {

        }
    }
}
