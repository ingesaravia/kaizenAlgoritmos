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
    public partial class gesVelocidad : Form
    {
        public gesVelocidad()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double velOrigen = Double.Parse(txtUnidadDestino.Text);

            string unidadOrigen;
            string unidadDestino;

            if ((cmbUnidadOrigen.SelectedValue != null) && (cmbUnidadDestino.SelectedValue != null)
            && (cmbUnidadOrigen.SelectedValue != cmbUnidadDestino.SelectedValue))
            {
                unidadOrigen = cmbUnidadOrigen.SelectedValue.ToString();
                unidadDestino = cmbUnidadDestino.SelectedValue.ToString();
                
                    
                    
            }

        }

        private void rbtnPosicion_CheckedChanged(object sender, EventArgs e)
        {
            txtPosicion.Enabled = false;
            txtTiempo.Enabled = true;
            txtVelocidad.Enabled = true;
        }

        private void btnCalcIncognita_Click(object sender, EventArgs e)
        {
            if (rbtnVelocidad.Checked == true) {
                
            }
        }
    }
}
