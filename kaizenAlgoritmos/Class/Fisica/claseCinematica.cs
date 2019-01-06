using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaizenAlgoritmos.Class
{
    class claseCinematica
    {
        //lineal, planar, espacial
        private double posinicialX;
        private double posfinalX;
        private double posinicialY;
        private double posfinalY;
        private double posinicialZ;
        private double posfinalZ;
        private double tiempoinicial;
        private double tiempofinal;
        private double velinicialX;
        private double velfinalX;
        private double velinicialY;
        private double velfinalY; 
        private double velinicialZ;
        private double velfinalZ;
        private double acelX;
        private double acelY;
        private double acelZ;
        private double dirinicial;
        private double dirfinal;

        private double posmodulo;
        private double velmodulo;
        private double acelmodulo;
        
        //angular
        private double posangularinicial;
        private double posangularfinal;
        private double velangularinicial;
        private double velangularfinal;
        private double acelangularinicial;
        private double acelangularfinal;

        #region
        /// <summary>
        /// getters & setters
        /// </summary>
        public double PosinicialX
        {
            get
            {
                return posinicialX;
            }

            set
            {
                posinicialX = value;
            }
        }

        public double PosfinalX
        {
            get
            {
                return posfinalX;
            }

            set
            {
                posfinalX = value;
            }
        }

        public double PosinicialY
        {
            get
            {
                return posinicialY;
            }

            set
            {
                posinicialY = value;
            }
        }

        public double PosfinalY
        {
            get
            {
                return posfinalY;
            }

            set
            {
                posfinalY = value;
            }
        }

        public double PosinicialZ
        {
            get
            {
                return posinicialZ;
            }

            set
            {
                posinicialZ = value;
            }
        }

        public double PosfinalZ
        {
            get
            {
                return posfinalZ;
            }

            set
            {
                posfinalZ = value;
            }
        }



        public double VelinicialX
        {
            get
            {
                return velinicialX;
            }

            set
            {
                velinicialX = value;
            }
        }

        public double VelfinalX
        {
            get
            {
                return velfinalX;
            }

            set
            {
                velfinalX = value;
            }
        }

        public double VelinicialY
        {
            get
            {
                return velinicialY;
            }

            set
            {
                velinicialY = value;
            }
        }

        public double VelfinalY
        {
            get
            {
                return velfinalY;
            }

            set
            {
                velfinalY = value;
            }
        }

        public double VelinicialZ
        {
            get
            {
                return velinicialZ;
            }

            set
            {
                velinicialZ = value;
            }
        }

        public double VelfinalZ
        {
            get
            {
                return velfinalZ;
            }

            set
            {
                velfinalZ = value;
            }
        }

        public double AcelX
        {
            get
            {
                return acelX;
            }

            set
            {
                acelX = value;
            }
        }

        public double AcelY
        {
            get
            {
                return acelY;
            }

            set
            {
                acelY = value;
            }
        }

        public double AcelZ
        {
            get
            {
                return acelZ;
            }

            set
            {
                acelZ = value;
            }
        }

        public double Dirinicial
        {
            get
            {
                return dirinicial;
            }

            set
            {
                dirinicial = value;
            }
        }

        public double Dirfinal
        {
            get
            {
                return dirfinal;
            }

            set
            {
                dirfinal = value;
            }
        }

        public double Posangularinicial
        {
            get
            {
                return posangularinicial;
            }

            set
            {
                posangularinicial = value;
            }
        }

        public double Posangularfinal
        {
            get
            {
                return posangularfinal;
            }

            set
            {
                posangularfinal = value;
            }
        }

        public double Velangularinicial
        {
            get
            {
                return velangularinicial;
            }

            set
            {
                velangularinicial = value;
            }
        }

        public double Velangularfinal
        {
            get
            {
                return velangularfinal;
            }

            set
            {
                velangularfinal = value;
            }
        }

        public double Acelangularinicial
        {
            get
            {
                return acelangularinicial;
            }

            set
            {
                acelangularinicial = value;
            }
        }

        public double Acelangularfinal
        {
            get
            {
                return acelangularfinal;
            }

            set
            {
                acelangularfinal = value;
            }
        }

        public double Tiempoinicial
        {
            get
            {
                return tiempoinicial;
            }

            set
            {
                tiempoinicial = value;
            }
        }

        public double Tiempofinal
        {
            get
            {
                return tiempofinal;
            }

            set
            {
                tiempofinal = value;
            }
        }

        public double Posmodulo
        {
            get
            {
                return posmodulo;
            }

            set
            {
                posmodulo = value;
            }
        }

        public double Velmodulo
        {
            get
            {
                return velmodulo;
            }

            set
            {
                velmodulo = value;
            }
        }

        public double Acelmodulo
        {
            get
            {
                return acelmodulo;
            }

            set
            {
                acelmodulo = value;
            }
        }
        #endregion

        public claseCinematica() {

        }

        public double calcVelocidadMRU(double posiX, double posfX, double tiempoi, double tiempof) {
            double calc = (posfX - posiX) / (tiempof - tiempoi);
            return (calc);
        }

        public double calcVelModulo(double veliX, double velfX, double veliY, double velfY, double veliZ, double velfZ) {
            double calc = Math.Pow((Math.Pow((velfX - veliX),2.0) + Math.Pow((velfY - veliY),2.0) + Math.Pow((velfZ - veliZ),2.0)), 0.5);
            velmodulo = calc;
            return (calc);
        }

        public double calcAcelModulo(double aceliX, double acelfX, double aceliY, double acelfY, double aceliZ, double acelfZ)
        {
            double calc = Math.Pow((Math.Pow((acelfX - aceliX), 2.0) + Math.Pow((acelfY - aceliY), 2.0) + Math.Pow((acelfZ - aceliZ), 2.0)), 0.5);
            acelmodulo = calc;
            return (calc);
        }
    }
}
