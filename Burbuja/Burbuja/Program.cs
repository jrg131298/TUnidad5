using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Vector; //Donde se guardan los valores ingresados
            int Cantidad, Auxiliar; //Cantidad = Cantidad de valores en el vector
                                    //Auxiliar = Toma un valor auxiliar
            bool Salir = false;
            Proceso P;
            do
            {
                try
                {
                    //Inicio del programa
                    Console.WriteLine("Bubble Sort");
                    Console.Write("Ingresa la cantidad de valores: ");
                    Cantidad = Convert.ToInt32(Console.ReadLine());
                    Vector = new double[Cantidad];
                    //Captura de valores
                    for (int Contador = 0; Contador < Cantidad; Contador++)
                    {
                        Console.Write("Ingresa un numero: ");
                        Vector[Contador] = Convert.ToDouble(Console.ReadLine());
                    }
                    P = new Proceso(Vector);
                    Console.Clear();
                    //Impresion
                    Console.WriteLine("Valores desordenados");
                    P.Impresion();
                    //Aplicacion del metodo de la burbuja
                    P.Acomodar();
                    //Impresion
                    Console.WriteLine("\nValores ordenados");
                    P.Impresion();
                    Salir = true;
                }
                catch
                {
                    Console.WriteLine("A ocurrido un error.");
                }
                Console.WriteLine("Precione un boton para continuar."); Console.ReadKey();
            } while (Salir == false); //Nos mantiene en la captura de datos
        }
    }
}
