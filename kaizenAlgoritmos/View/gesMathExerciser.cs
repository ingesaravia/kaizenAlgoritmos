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
    public partial class gesMathExerciser : Form
    {
        public gesMathExerciser()
        {
            InitializeComponent();
        }

        private void cmbTipoNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcionSeleccionada = cmbTipoNumero.SelectedItem.ToString();

            if (opcionSeleccionada == "Natural")
            {
                cmbAlgebraica.Items.Clear();
                cmbAlgebraica.Items.Add("Paridad");
                cmbAlgebraica.Items.Add("Descomponer Factores");
                cmbAlgebraica.Items.Add("Criba de Eratostenes");
                cmbAlgebraica.Items.Add("Descomponer Binario");
            }
            else
                if (opcionSeleccionada == "Racional")
            {
                cmbAlgebraica.Items.Clear();
                cmbAlgebraica.Items.Add("Convertir a Fraccionario");
                cmbAlgebraica.Items.Add("Notación Científica");
            }
            else
                    if (opcionSeleccionada == "Irracional")
            {
                cmbAlgebraica.Items.Clear();
                cmbAlgebraica.Items.Add("Convertir a Fraccionario");
                cmbAlgebraica.Items.Add("Contar Decimales");
            }
            else
                        if (opcionSeleccionada == "Fraccionario")
            {
                cmbAlgebraica.Items.Clear();
                cmbAlgebraica.Items.Add("Convertir a Decimal");
            }
            else
                            if (opcionSeleccionada == "Complejo")
            {
                cmbAlgebraica.Items.Clear();
                cmbAlgebraica.Items.Add("Módulo");
                cmbAlgebraica.Items.Add("Conjugado");
            }
            else {
                //Entero
                cmbAlgebraica.Items.Clear();
                cmbAlgebraica.Items.Add("Valor Absoluto");
            }
        }

        private void cmbBinumerico_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBinumAlgebraica.Items.Clear();
            cmbBinumAlgebraica.Items.Add("Suma");
            cmbBinumAlgebraica.Items.Add("Resta");
            cmbBinumAlgebraica.Items.Add("Producto");
            cmbBinumAlgebraica.Items.Add("Division");
            cmbBinumAlgebraica.Items.Add("Potenciacion");
            cmbBinumAlgebraica.Items.Add("Radicacion");
        }

        private void btnBinumEjecutar_Click(object sender, EventArgs e)
        {
            if (cmbBinumerico.SelectedItem.ToString() == "Natural")
            {
                if (cmbBinumAlgebraica.SelectedItem.ToString() == "Suma")
                {
                    Random rand = new Random();
                    int cantEjer = Int32.Parse(numEjerc.Value.ToString());
                    int cantTerm = Int32.Parse(numTerm.Value.ToString());

                    int ej = 0;
                    
                    string ejercicio;
                    string signo = "+";

                    while (ej < cantEjer)
                    {
                        ejercicio = null;
                        numNatural mNatural = new numNatural();
                        mNatural.numero = rand.Next(-100, 100);
                        if (mNatural.numero > 0)
                            ejercicio = signo + mNatural.numero.ToString();
                        else
                            ejercicio = mNatural.numero.ToString();
                        int term = 0;

                        while (term < cantTerm)
                        {
                            numNatural mNatural2 = new numNatural();
                            mNatural2.numero = rand.Next(-100, 100);
                            if (mNatural2.numero > 0)
                                ejercicio = ejercicio + signo + mNatural2.numero.ToString();
                            else
                                ejercicio = ejercicio + mNatural2.numero.ToString();
                            term++;
                        }
                        ej++;
                        rtxtBinumResult.AppendText(ejercicio + "=" + "\n");
                    }
                }
            }


        }
    }
}
