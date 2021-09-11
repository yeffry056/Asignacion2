using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asignacion2
{
    class Cap4
    {
        public static double numeroElevado(int numero, int potencia)
        {
            double elevado;
            elevado = Math.Pow(numero, potencia);
            return elevado;
        }
        public static int []Tabla(int numero)
        {
            int []arreglo = new int[10];

            for(int i = 1; i < 11; i++)
            {
                arreglo[i-1] =numero* i;
            }
            return arreglo;
        }
        public static int[] Edades(int[] edad, int cantidad)
        {
            int []res = new int[4];
           int suma =0, promedio =0;
            int mayor, menor;
            mayor = menor = edad[0];
            for(int i = 0; i < edad.Length; i++)
            {
                if(edad[i] > mayor)
                    mayor = edad[i];
                suma += edad[i];
                
            }
            menor = mayor;
            for (int i = 0; i < edad.Length; i++)
            {
                if (edad[i] !=0 && edad[i] < menor)
                    menor = edad[i];

                
            }
            promedio = suma / cantidad;
            res[0] = promedio;
            res[1] = mayor;
            res[2] = menor;
            return res;
        }
    }
}
