using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbuja
{
    class Proceso
    {
        double[] Vector;
        double Temporal;
        public Proceso(double[] Vector)
        {
            this.Vector = Vector;
        }
        public void Impresion()
        {
            for (int Contador = 0; Contador < Vector.Length; Contador++)
            {
                Console.WriteLine(Vector[Contador]);
            }
        }
        public void Acomodar()
        {
            for(int Contador1 = 1; Contador1 <= Vector.Length; Contador1++)
            {
                for(int Contador2 = 1; Contador2 < Vector.Length; Contador2++)
                {
                    if(Vector[Contador2 - 1] > Vector[Contador2])
                    {
                        Temporal = Vector[Contador2 - 1];
                        Vector[Contador2 - 1] = Vector[Contador2];
                        Vector[Contador2] = Temporal;
                    }
                }
            }
        }
    }
}
