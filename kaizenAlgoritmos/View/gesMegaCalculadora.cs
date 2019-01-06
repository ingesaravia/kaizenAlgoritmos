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
    public partial class gesMegaCalculadora : Form
    {
        private double numDouble;
        private int numInt;
        private float numFloat;

        private Class.numNatural miNumNatural;
        private Class.numRacional miNumRacional;
        private Class.numIrracional miNumIrracional;
        
        public gesMegaCalculadora()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (cmbAlgebraica.SelectedItem != null) {
                string opcion = cmbAlgebraica.SelectedItem.ToString();
                
                if (opcion == "Descomponer Factores")
                    descomponerFactores();
                if (opcion == "Criba de Eratostenes")
                    generarCriba();
                if (opcion == "Paridad")
                    consultarParidad();
                if (opcion == "Descomponer Binario")
                    descomponerBinario();
                if (opcion == "Convertir a Fraccionario")
                    convertirFraccionario();
                if (opcion == "Contar Decimales")
                    contarDecimales();
            }
        }

        private void contarDecimales() {
            numDouble = Double.Parse(txtNum.Text);

            miNumIrracional = new Class.numIrracional();
            miNumIrracional.numero = numDouble;
            miNumIrracional.contarDecimales();

            txtResultados.AppendText("Cantidad de Decimales: \n");
            txtResultados.AppendText(miNumIrracional.cantidadDecimales.ToString());

        }

        private void convertirFraccionario() {
            numDouble = Double.Parse(txtNum.Text);

            
        }

        private void generarCriba() {
            numInt = Int32.Parse(txtNum.Text);

            miNumNatural = new Class.numNatural();
            miNumNatural.numero = numInt;
            miNumNatural.generarCribaB();

            txtResultados.AppendText("Criba de Eratostenes \n");
            foreach (int fact in miNumNatural.cribaPrimos)
            {
                txtResultados.AppendText(fact.ToString() + " ");
            }
            txtResultados.AppendText("\n");

        }

        private void descomponerFactores() {
            numInt = Int32.Parse(txtNum.Text);

            //Descomposicion en Factores
            miNumNatural = new Class.numNatural();
            miNumNatural.numero = numInt;
            miNumNatural.factorizar(miNumNatural);

            txtResultados.AppendText("Factores de " + txtNum.Text + "=");
            foreach (int fact in miNumNatural.factores)
            {
                txtResultados.AppendText(fact.ToString() + "*");
            }
            txtResultados.AppendText("\n");
        }

        private void consultarParidad() {
            numInt = Int32.Parse(txtNum.Text);

            miNumNatural = new Class.numNatural();
            miNumNatural.numero = numInt;
            miNumNatural.factorizar(miNumNatural);

            if (miNumNatural.esPar(numInt))
                txtResultados.AppendText(txtNum.Text + " es PAR \n");
            else
                txtResultados.AppendText(txtNum.Text + " es IMPAR \n");
        }

        private void descomponerBinario() {
            numInt = Int32.Parse(txtNum.Text);

            miNumNatural = new Class.numNatural();
            miNumNatural.numero = numInt;
            miNumNatural.factorizar(miNumNatural);
        }

        private void cmbTipoNumero_SelectedIndexChanged(object sender, EventArgs e)
        {

                string opcionSeleccionada = cmbTipoNumero.SelectedItem.ToString();

                if (opcionSeleccionada == "Natural") {
                    cmbAlgebraica.Items.Clear();
                    cmbAlgebraica.Items.Add("Paridad");
                    cmbAlgebraica.Items.Add("Descomponer Factores");
                    cmbAlgebraica.Items.Add("Criba de Eratostenes");
                    cmbAlgebraica.Items.Add("Descomponer Binario");
                }
                else
                    if (opcionSeleccionada == "Racional") {
                    cmbAlgebraica.Items.Clear();
                    cmbAlgebraica.Items.Add("Convertir a Fraccionario");
                    cmbAlgebraica.Items.Add("Notación Científica");
                    }
                    else
                        if (opcionSeleccionada == "Irracional") {
                            cmbAlgebraica.Items.Clear();
                            cmbAlgebraica.Items.Add("Convertir a Fraccionario");
                            cmbAlgebraica.Items.Add("Contar Decimales");
                        }
                        else
                            if (opcionSeleccionada == "Fraccionario") {
                                cmbAlgebraica.Items.Clear();
                                cmbAlgebraica.Items.Add("Convertir a Decimal");
                            }
                            else
                                if (opcionSeleccionada == "Complejo") {
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
    }
}
