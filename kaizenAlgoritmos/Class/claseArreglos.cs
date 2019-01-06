using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaizenAlgoritmos.Class
{
    class claseArreglos
    {
        //UNIDIMENSIONALES
        private string[] arregloCadena;
        private int[] arregloEntero;
        private char[] arregloCaracter;

        //BIDIMENSIONALES NXN
        private string[,] matrizCadena;
        private int[,] matrizEntero;
        private char[,] matrizCaracter;

        public claseArreglos() {

            this.arregloCadena = new string[100];
            this.arregloEntero = new int[100];
            this.arregloCaracter = new char[100];

            this.matrizCadena = new string[100, 100];
            this.matrizEntero = new int[100, 100];
            this.matrizCaracter = new char[100, 100];
        }

        public claseArreglos(int longitud) {
            this.arregloCadena = new string[longitud];
            this.arregloEntero = new int[longitud];
            this.arregloCaracter = new char[longitud];

            this.matrizCadena = new string[longitud, longitud];
            this.matrizEntero = new int[longitud, longitud];
            this.matrizCaracter = new char[longitud, longitud];

        }

        public void cargarArregloEnteroRandom() {
            Random miRand = new Random();

            for (int i = 0; i < this.arregloEntero.Length; i++)
            {
                this.arregloEntero[i] = miRand.Next(-1000, 1000);
            }
        }

        public void mostrarArregloEntero() {
            
        }
    }
}
