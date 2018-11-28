using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2QuickSort
{
    class Proceso
    {
        public double[] QuickSort(double[] vector, int inicio, int final)
        {
            double pivote = vector[(inicio + (final - inicio) / 2)]; //Pivote
            int izquierda = inicio; //Primer valor a evaluar
            int derecha = final; //Ultimo valor a evaluar
            while (izquierda <= derecha)
            {
                while (vector[izquierda] < pivote)
                {
                    izquierda++;
                }
                while (vector[derecha] > pivote)
                {
                    derecha--;
                }
                if (izquierda <= derecha)
                {
                    Cambiar(vector, izquierda, derecha);
                    izquierda++;
                    derecha--;
                }
            }
            if (inicio < derecha)
            {
                QuickSort(vector, inicio, izquierda - 1);
            }
            if (final > izquierda)
            {
                QuickSort(vector, derecha + 1, final);
            }

            return vector; //Retorna el vector ordenado
        }

        public void Cambiar(double[] vector, int izquierda, int derecha) //Acomoda los datos
        {
            double temporal = vector[izquierda];
            vector[izquierda] = vector[derecha];
            vector[derecha] = temporal;
        }
    }
}
