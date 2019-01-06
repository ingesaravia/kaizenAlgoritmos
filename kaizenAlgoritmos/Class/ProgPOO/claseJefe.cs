using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaizenAlgoritmos.Class
{
    //HERENCIA
    class claseJefe : clasePersona
    {
        private double sueldobasico;
        private int antiguedad;
        private double salario;

        #region
        public double Sueldobasico
        {
            get
            {
                return sueldobasico;
            }

            set
            {
                sueldobasico = value;
            }
        }

        public int Antiguedad
        {
            get
            {
                return antiguedad;
            }

            set
            {
                antiguedad = value;
            }
        }

        public double Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }
        #endregion
        //POLIMORFISMO
        public double sueldototal(double sbasico, int antiguedad)
        {
            double calc = sbasico * antiguedad;
            salario = calc;
            return (calc);
        }

        public double sueldototal(int antiguedad)
        {
            double calc = this.Sueldobasico * antiguedad;
            this.Salario = calc;
            return (calc);
        }
    }
}
