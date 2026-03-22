using System.Numerics;

namespace CalculadoraAvanzada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 100;
            do
            {
                Console.Clear();
                Console.WriteLine("+ + + Calculadora Avanzada + + +");
                Console.WriteLine();
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("0. Salir");
                Console.WriteLine("-----------------");
                Console.WriteLine("Seleccione una opcion: ");
                
                try
                {
                    opcion = int.Parse(Console.ReadLine()!);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
     
                }

                switch(opcion)
                {
                    case 1:
                        {
                            while (true)
                            {
                                try
                                {
                                    Console.Write("-> ");
                                    double a = double.Parse(Console.ReadLine()!);
                                    Console.Write("-> ");
                                    double b = double.Parse(Console.ReadLine()!);
                                    Console.WriteLine($"= {Sumar(a, b)}");
                                    Console.ReadKey();
                                    break;
                                }
                                catch(FormatException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            while (true)
                            {
                                try
                                {
                                    Console.Write("-> ");
                                    double a = double.Parse(Console.ReadLine()!);
                                    Console.Write("-> ");
                                    double b = double.Parse(Console.ReadLine()!);
                                    Console.WriteLine($"= {Restar(a, b)}");
                                    Console.ReadKey();
                                    break;
                                }
                                catch (FormatException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                            break ;
                        }
                    case 3:
                        {
                            while (true)
                            {
                                try
                                {
                                    Console.Write("-> ");
                                    double a = double.Parse(Console.ReadLine()!);
                                    Console.Write("-> ");
                                    double b = double.Parse(Console.ReadLine()!);
                                    Console.WriteLine($"= {Multiplicar(a, b)}");
                                    Console.ReadKey();
                                    break;
                                }
                                catch (FormatException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            while (true)
                            {
                                try
                                {
                                    Console.Write("-> ");
                                    double a = double.Parse(Console.ReadLine()!);
                                    Console.Write("-> ");
                                    double b = double.Parse(Console.ReadLine()!);
                                    Console.WriteLine($"= {Dividir(a, b)}");
                                    Console.ReadKey();
                                    break;
                                }
                                catch (FormatException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Saliendo...");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opcion no valida");
                            Console.ReadKey();
                            break;
                        }
               
                }
            
            }
            while (opcion != 0);
        }

        static double Sumar(double a, double b)
        {
            return a + b;
        }

        static double Restar(double a, double b)
        {
            return a - b;
        }

        static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Indefinido");
                return 0;
            }
            return a / b;
        }
        
    }
}