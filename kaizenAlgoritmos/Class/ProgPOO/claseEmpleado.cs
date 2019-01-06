using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaizenAlgoritmos.Class
{
    class claseEmpleado : clasePersona
    {
        private double sueldobasico;
        private double cargo;
        private int antiguedad;
        private double salario;

        #region
        /// <summary>
        /// getters & setters
        /// </summary>
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

        public double Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
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

        public double sueldototal (double sbasico, int antiguedad) {
            double calc = sbasico * antiguedad;
            salario = calc;
            return (calc);
        }
        
    }
}
