

using System;
using System.Threading;
using System.Collections.Generic;

using System.IO;

namespace Aplicacion_de_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int tiempo = 1000;

            double[] numeros = new double[5];



            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("");
                Console.WriteLine("1. Ingresar los numeros");
                Console.WriteLine("2. Mostrar los numeros , Tener en cuenta que si no has ingresado numeros Imprimira 0 en su lugar");
                Console.WriteLine("3. Ordenar los numeros");
                Console.WriteLine("4. salir");
                Console.WriteLine("5. Guardar");
                Console.WriteLine("Elige una de las opciones");
                Console.WriteLine("");
                Console.WriteLine("______________________________________________________________________________");


                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)

                {

                    case 1:


                        //pedimos al usuario los 5 valores
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("Ingrese un valor:");

                            numeros[i] = double.Parse(Console.ReadLine());

                        }
                        break;


                    case 2:





                        Stream Archivo1 = new FileStream("Archivo.txt", FileMode.OpenOrCreate);
                        StreamReader Leer = new StreamReader(Archivo1);
                        Console.WriteLine(Leer.ReadToEnd());

                        Leer.Close();
                        Archivo1.Close();




                        Thread.Sleep(tiempo);




                        break
                        ;

                    case 3:
                        Console.WriteLine("Sub menu");

                        while (!salir)
                        {

                            Console.WriteLine("1. Ordenar de menor a mayor");
                            Console.WriteLine("2. Ordenar de mayor a menor");

                            int nueva = Convert.ToInt32(Console.ReadLine());
                            switch (nueva)
                            {
                                case 1:


                                    Array.Sort(numeros);

                                    Console.WriteLine("\nLos números ordenados de menor a mayor son:");

                                    for (int i = 0; i < 5; i++)
                                    {
                                        Console.WriteLine(numeros[i]);
                                        Thread.Sleep(tiempo);

                                    }


                                    break;



                                case 2:
                                    Array.Reverse(numeros);
                                    Console.WriteLine("\nLos números ordenados de mayor a menor son:");

                                    for (int i = 0; i < 5; i++)
                                    {
                                        Console.WriteLine(numeros[i]);
                                        Thread.Sleep(tiempo);

                                    }
                                    break;





                            }
                            break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Has elegido salir de la aplicación");
                        salir = true;
                        break;

                    case 5:
                        Stream Archivo2 = new FileStream("Archivo.txt", FileMode.OpenOrCreate);
                        StreamWriter Escribir = new StreamWriter(Archivo2);
                        for (int i = 0; i < 5; i++)
                        {
                            Escribir.WriteLine(numeros[i]);
                        }

                        Escribir.Close();
                        Archivo2.Close();


                        break;

                    default:
                        Console.WriteLine("Elige una opcion entre 1 y 4");
                        break;
                }
            }


            {




                Console.ReadKey();
            }
        }
    }
}

