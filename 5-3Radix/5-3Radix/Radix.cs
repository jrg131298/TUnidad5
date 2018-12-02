using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3Radix
{
    class Radix
    {
        public int[] RadixSort(int[] vector) //Metodo que permite ordenar por Radix Sort
        {
            int i, j;
            int[] temporal = new int[vector.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < vector.Length; ++i)
                {
                    bool mueve = (vector[i] << shift) >= 0;
                    if (shift == 0 ? !mueve : mueve)
                        vector[i - j] = vector[i];
                    else
                        temporal[j++] = vector[i];
                }
                Array.Copy(temporal, 0, vector, vector.Length - j, j);
            }
            return vector;
        }

        public void Impresion(int[] array) //Metodo que imprime el arreglo de valores
        {
            foreach (var Item in array)
            {
                Console.WriteLine(Item);
            }
        }
    }
}
