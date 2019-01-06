using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaizenAlgoritmos.Class
{
    class numIrracional
    {
        public double numero;
        public int cantidadDecimales;
        public int parteEntera;
        public int parteDecimal;
        public int parteDecimalPeriodica;

        public numIrracional() {
        }

        public numIrracional(double num) {
            this.numero = num;
        }
        
        public int contarDecimales() { 
            int cantidad = 0;

            string cadenaDec = Convert.ToString(this.numero);
            cadenaDec = cadenaDec.Substring(cadenaDec.IndexOf(',') + 1);
            cantidad = cadenaDec.Length;

            cantidadDecimales = cantidad;

            return (cantidad);
        }

        public int getParteEntera() {
            int pEntera;

            string cadenaDec = Convert.ToString(this.numero);
            cadenaDec = cadenaDec.Substring(0, cadenaDec.IndexOf(','));
            pEntera = Convert.ToInt32(cadenaDec);

            return (pEntera);
        }

        public void setParteEntera() {
            this.parteEntera = this.getParteEntera();
        }

        public int getParteDecimal() {
            int pDecimal;

            string cadenaDec = Convert.ToString(this.numero);
            cadenaDec = cadenaDec.Substring(cadenaDec.IndexOf(',') + 1, cadenaDec.Length - cadenaDec.IndexOf(','));
            pDecimal = Convert.ToInt32(cadenaDec);
            return (pDecimal);
        }

        public void setParteDecimal() {
            this.parteDecimal = this.getParteDecimal();
        }
        
        public Boolean esNoPeriodico (double num) {
            Boolean resp = false;
            return (resp);
        }
        
        public Boolean esPeriodicoPuro(double num)
        {
            Boolean resp = false;

            double auxDecimal = this.numero - Math.Truncate(this.numero);

            return (resp);
        }

        public Boolean esPeriodicoMixto(double num) {
            Boolean resp = false;
            return (resp);
        }

        public numFraccionario convertirFraccionario(double num) {
            numFraccionario mFraccionario = new numFraccionario();

            if (this.esPeriodicoPuro(this.numero)) {

                int cantidadDec = contarDecimales();

                mFraccionario.denominador = cantidadDec * 10 - 1;
                //mFraccionario.numerador = Convert.ToInt32();

            }
            else
                if (this.esPeriodicoMixto(this.numero)) {

                int cantidadDec = contarDecimales();

                
                    
                }
                else {
                //es Decimal Puro
                int cantidadDec = contarDecimales();

                mFraccionario.denominador = cantidadDec * 10;
                mFraccionario.numerador = Convert.ToInt32(this.numero * mFraccionario.denominador);
                }

            return (mFraccionario);

        }
    }
}
