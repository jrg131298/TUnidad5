using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3Radix
{
    class Program
    {
        static void Main(string[] args)
        {
            Radix r = new Radix(); //Objeto de la clase Radix
            bool salir = false; //Nos permite permanecer en el programa
            int opcion; //Captura la respuesta del usuario
            int[] vector; //Donde se almacenaran los valores
            do //Ciclo repetitivo que nos permite permanecer en el programa
            {
                try //Nos pemite capturar excepciones
                {
                    Console.Clear();
                    Console.WriteLine("---------------------Radix---------------------"); //Menu
                    Console.WriteLine("Ingresa el numero de la opcion");
                    Console.WriteLine("1.- Ordenamiento 1");
                    Console.WriteLine("2.- Ordenamiento 2");
                    Console.WriteLine("3.- Ordenamiento 3");
                    Console.WriteLine("4.- Ordenamiento 4");
                    Console.WriteLine("5.- Ordenamiento 5");
                    Console.WriteLine("6.- Salir");
                    opcion = Convert.ToInt32(Console.ReadLine()); //Captura de la opcion
                    switch(opcion) //Comparacion de la opcion escogida
                    {
                        case 1:
                            vector = new int[10] { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 }; //Asignacion de valores
                            Console.WriteLine("Valores desordenados");
                            r.Impresion(vector); //Impresion
                            vector = r.RadixSort(vector); //Acomodar datos
                            Console.WriteLine("\nValores ordenados");
                            r.Impresion(vector); //Impresion
                            break;
                        case 2:
                            vector = new int[9] { 8, 3, 9, 3, 11, 7, 1, 27, 12 }; //Asignacion de valores
                            Console.WriteLine("Valores desordenados");
                            r.Impresion(vector); //Impresion
                            vector = r.RadixSort(vector); //Acomodar datos
                            Console.WriteLine("\nValores ordenados");
                            r.Impresion(vector); //Impresion
                            break;
                        case 3:
                            vector = new int[8] { 10, 40, 36, 5, 24, 2, 5, 8 }; //Asignacion de valores
                            Console.WriteLine("Valores desordenados");
                            r.Impresion(vector); //Impresion
                            vector = r.RadixSort(vector); //Acomodar datos
                            Console.WriteLine("\nValores ordenados");
                            r.Impresion(vector); //Impresion
                            break;
                        case 4:
                            vector = new int[9] { 55, 42, 0, -3, 0, -1, 2, 4, 7 }; //Asignacion de valores
                            Console.WriteLine("Valores desordenados");
                            r.Impresion(vector); //Impresion
                            vector = r.RadixSort(vector); //Acomodar datos
                            Console.WriteLine("\nValores ordenados");
                            r.Impresion(vector); //Impresion
                            break;
                        case 5:
                            vector = new int[7] { 25, 108, 1024, 12, 351, 251, 39 }; //Asignacion de valores
                            Console.WriteLine("Valores desordenados");
                            r.Impresion(vector); //Impresion
                            vector = r.RadixSort(vector); //Acomodar datos
                            Console.WriteLine("\nValores ordenados");
                            r.Impresion(vector); //Impresion
                            break;
                        case 6: //Opcion para salir del programa
                            salir = true; 
                            break;
                        default: //En caso de escoger otra opcion
                            Console.WriteLine("\nA ocurrido un error.");
                            break;
                    }
                }
                catch //Mensaje en caso de excepcion
                {
                    Console.WriteLine("\nA ocurrido un error.");
                }
                Console.WriteLine("Precione una tecla para continuar.");
                Console.ReadKey();
            } while (salir == false);
        }
    }
}
