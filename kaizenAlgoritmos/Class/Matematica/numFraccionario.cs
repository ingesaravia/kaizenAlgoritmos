using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaizenAlgoritmos.Class
{
    ///<sumary>
    ///clase que trabaja con numeros fraccionarios
    ///</sumary>
    class numFraccionario
    {
        public int numerador;
        public int denominador;

        public numFraccionario() {
          
        }

        public numFraccionario(int num, int den) {
            this.numerador = num;
            if (den > 0)
                this.denominador = den;
        }

        public numFraccionario sumaFraccionario(numFraccionario num1, numFraccionario num2) {
            numFraccionario miSuma = new numFraccionario();

            miSuma.denominador = num1.denominador * num2.denominador;
            miSuma.numerador = num1.numerador * num2.denominador + num2.numerador * num1.denominador;

            return (miSuma);
        }

        public double convertirFraccDecimal(numFraccionario num) {
            double numDec;

            numDec = num.numerador / num.denominador;

            return (numDec);
        }

        public numFraccionario encontrarReducible (numFraccionario num) {
            numFraccionario mReducible = new numFraccionario();

            //Encontrar la fracción reducible

            return (mReducible);
        }
        
    }
}
