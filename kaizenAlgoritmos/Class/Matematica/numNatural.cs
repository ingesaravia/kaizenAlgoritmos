using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaizenAlgoritmos.Class
{
    class numNatural
    {
        public int numero;

        public List<int> factores;
        public List<int> cribaPrimos;
        public List<int> binarios;

        public numNatural() {

        }

        public numNatural(int num) {
            this.numero = num;
        }

        public Boolean esPrimo(int num) {
            Boolean resp;

            if (num == 2) {
                resp = true;
            }
            else {
                int i, suma = 0;

                for (i = 1; i < num - 1; i++)
                    if ((num % i) == 0)
                        suma = suma + 1;

                if (suma == 1)
                    resp = true;
                else
                    resp = false;
            }
            
            return resp;
        }
        
        public Boolean esPar(int num) {
            Boolean resp = false;

            if ((num % 2) == 0)
                resp = true;
            return resp;
        }

        public void generarCriba() {
            this.cribaPrimos = new List<int>();

            //CORREGIR
            int cont;
            int num;
            int i = 2;

            while (i <= 100) {
                cont = 0;
                num = 1;
                while (cont < 2) {
                    if ((i % num) == 0)
                        cont++;
                    num++;
                }
                if (cont == 2) {
                    this.cribaPrimos.Add(i);
                }
                i++;
            }
        }

        public void generarCribaB() {
            this.cribaPrimos = new List<int>();

            int i = 2;
            while (i <= 100) {
                if (esPrimo(i))
                {
                    this.cribaPrimos.Add(i);
                }
                i++;
            }
        }

        public void factorizar(numNatural num)
        {
            //Generar la criba para identificar después            
            num.generarCribaB();

            //Procedimiento para factorizar
            num.factores = new List<int>();
            Boolean encontrado;

            int i;
            int n = num.numero;
            int divisor;

            while (n > 1)
            {
                i = 0;
                encontrado = false;
                while (!encontrado)
                {
                    divisor = num.cribaPrimos[i];
                    if ((n % divisor) == 0)
                    {
                        encontrado = true;
                        num.factores.Add(divisor);
                        n = n / divisor;
                    }
                    i++;
                }
            }

            num.factores.Sort();
        }

        public void descomponerBinario(numNatural num) {
            num.binarios = new List<int>();

            int n = num.numero;
            
            
            
        }


        public int mcd(numNatural numA, numNatural numB) {
            int valor = 1;
            //maximo comun divisor
            //1. descomponer en factores primos
            //2. tomar los factores comunes con MENOR exponente.
            //3. multiplicarlos
            numA.factorizar(numA);
            numB.factorizar(numB);

            List<int> factA = numA.factores;
            List<int> factB = numB.factores;
            List<int> factMCD = new List<int>();

            return valor;
        }

        public int mcm(numNatural numA, numNatural numB) {
            int valor = 1;
            //minimo comun multiplo
            //1. descomponer en factores primos
            //2. tomar los factores comunes y no comunes con MAYOR exponente.
            //3. multiplicarlos

            return valor;
        }

        
    }
}
