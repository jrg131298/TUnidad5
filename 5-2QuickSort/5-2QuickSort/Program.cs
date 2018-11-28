using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Jesus Ramirez Garcia"; //Pone mi nombre
            bool Salir = false; //Nos permite permanecer en el programa
            double[] Quicks; //Arreglo donde se almacenaran los valores
            int Opcion; //Almacena el valor elegido en el menu
            Proceso P = new Proceso(); //Objeto de la clase Proceso
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("*******************QuickSort*******************"); //Menu
                    Console.WriteLine("Ingresa el numero de la opcion que desee:");
                    Console.WriteLine("1.- Ordenamiento 1");
                    Console.WriteLine("2.- Ordenamiento 2");
                    Console.WriteLine("3.- Ordenamiento 3");
                    Console.WriteLine("4.- Ordenamiento 4");
                    Console.WriteLine("5.- Salir");
                    Console.WriteLine("R: ");
                    Opcion = Convert.ToInt32(Console.ReadLine()); //Captura de opcion
                    switch (Opcion) //Eleccion de un problema
                    {
                        case 1:
                            Quicks = new double[10];
                            Quicks[0] = 11;  //Captura de datos
                            Quicks[1] = 2;
                            Quicks[2] = 3;
                            Quicks[3] = 14;
                            Quicks[4] = 18;
                            Quicks[5] = 45;
                            Quicks[6] = -3;
                            Quicks[7] = -1;
                            Quicks[8] = 6;
                            Quicks[9] = 9;
                            Console.Clear();
                            Console.WriteLine("Datos Desordenados"); //Impresion de los numeros desordenados
                            foreach (var Item in Quicks)
                            {
                                Console.WriteLine(Item);
                            }
                            Quicks = P.QuickSort(Quicks, 0, Quicks.Length - 1); //Ejecucion del metodo que acomoda los valores
                            Console.WriteLine("Datos ordenados"); //Impresion de los numeros ordenados
                            foreach (var Item in Quicks)
                            {
                                Console.WriteLine(Item);
                            }
                            break;
                        case 2:
                            Quicks = new double[12];
                            Quicks[0] = 1;  //Captura de datos
                            Quicks[1] = 3;
                            Quicks[2] = 5;
                            Quicks[3] = 7;
                            Quicks[4] = 8;
                            Quicks[5] = 3;
                            Quicks[6] = 9;
                            Quicks[7] = .7071;
                            Quicks[8] = 16.5664;
                            Quicks[9] = 12;
                            Quicks[10] = 0;
                            Quicks[11] = 10;
                            Console.Clear();
                            Console.WriteLine("Datos Desordenados"); //Impresion de los numeros desordenados
                            foreach (var Item in Quicks)
                            {
                                Console.WriteLine(Item);
                            }
                            Quicks = P.QuickSort(Quicks, 0, Quicks.Length - 1); //Ejecucion del metodo que acomoda los valores
                            Console.WriteLine("Datos ordenados"); //Impresion de los numeros ordenados
                            foreach (var Item in Quicks)
                            {
                                Console.WriteLine(Item);
                            }
                            break;
                        case 3:
                            Quicks = new double[12];
                            Quicks[0] = 3;  //Captura de datos
                            Quicks[1] = 7;
                            Quicks[2] = 15;
                            Quicks[3] = 1.3333;
                            Quicks[4] = 155;
                            Quicks[5] = 100;
                            Quicks[6] = 15;
                            Quicks[7] = 1.7321;
                            Quicks[8] = 5;
                            Quicks[9] = 2;
                            Quicks[10] = 3;
                            Quicks[11] = 2;
                            Console.Clear();
                            Console.WriteLine("Datos Desordenados"); //Impresion de los numeros desordenados
                            foreach (var Item in Quicks)
                            {
                                Console.WriteLine(Item);
                            }
                            Quicks = P.QuickSort(Quicks, 0, Quicks.Length - 1); //Ejecucion del metodo que acomoda los valores
                            Console.WriteLine("Datos ordenados"); //Impresion de los numeros ordenados
                            foreach (var Item in Quicks)
                            {
                                Console.WriteLine(Item);
                            }
                            break;
                        case 4:
                            Quicks = new double[10];
                            Quicks[0] = 8;  //Captura de datos
                            Quicks[1] = 19;
                            Quicks[2] = 7;
                            Quicks[3] = 3;
                            Quicks[4] = 15;
                            Quicks[5] = 23;
                            Quicks[6] = 34;
                            Quicks[7] = 27;
                            Quicks[8] = 89;
                            Quicks[9] = 101;
                            Console.Clear();
                            Console.WriteLine("Datos Desordenados"); //Impresion de los numeros desordenados
                            foreach (var Item in Quicks)
                            {
                                Console.WriteLine(Item);
                            }
                            Quicks = P.QuickSort(Quicks, 0, Quicks.Length - 1); //Ejecucion del metodo que acomoda los valores
                            Console.WriteLine("Datos ordenados"); //Impresion de los numeros ordenados
                            foreach (var Item in Quicks)
                            {
                                Console.WriteLine(Item);
                            }
                            break;
                        case 5: 
                            Salir = true; //Nos permite salir del programa
                            break;
                        default:
                            Console.WriteLine("Ha ocurrido un error."); //Se escoge una opcion no mecionada
                            break;
                    }
                }
                catch //Captura de excepciones
                {
                    Console.WriteLine("Ha ocurrido un error.");
                }
                Console.WriteLine("Preciona una tecla para continuar.");
                Console.ReadKey();
            } while (Salir == false); //Nos permite permanecer en el programa
        }
    }
}
