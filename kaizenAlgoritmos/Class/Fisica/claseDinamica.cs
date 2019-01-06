using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaizenAlgoritmos.Class
{
    class claseDinamica : claseCinematica
    {
        private double masa;
        private double fuerzamodulo;
        
        #region
        /// <summary>
        /// getters & setters
        /// </summary>
        public double Masa
        {
            get
            {
                return masa;
            }

            set
            {
                masa = value;
            }
        }

        public double Fuerzamodulo
        {
            get
            {
                return fuerzamodulo;
            }

            set
            {
                fuerzamodulo = value;
            }
        }
        #endregion

        private double calcFuerzaModulo(double masa, double acelmodulo) {
            double calc = masa * acelmodulo;
            this.fuerzamodulo = calc;
            return (calc);
        }

        private double calcAcelModulo(double masa, double fuerzamodulo) {
            double calc = fuerzamodulo / masa;
            this.Acelmodulo = calc;
            return (calc);
        }

        private double calcMasa(double fuerzamodulo, double acelmodulo) {
            double calc = fuerzamodulo / acelmodulo;
            this.masa = calc;
            return (calc);
        }
    }
}
