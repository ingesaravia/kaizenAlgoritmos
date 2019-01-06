using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaizenAlgoritmos.Class
{
    class clasePersona
    {
        private string nombre;
        private DateTime fechanac;

        #region
        /// <summary>
        /// getters & setters
        /// </summary>
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public DateTime Fechanac
        {
            get
            {
                return fechanac;
            }

            set
            {
                fechanac = value;
            }
        }
        #endregion
        //POLIMORFISMO
        public int calcEdad() {
            int calc;
            calc = DateTime.Today.Year - fechanac.Year;
            return (calc);
        }

        public int calcEdad(DateTime fecha) {
            int calc;
            calc = DateTime.Today.Year - fecha.Year;
            return (calc);
        }
    }
}
