using System;

namespace Tutoría_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese el dato a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el dato b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el dato c: ");
            double c = double.Parse(Console.ReadLine());

            //Proceso
            double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

            double d = b * b - 4 * a * c;
            if (d > 0)
            {
                Console.Write("La ecuación tiene 2 posibles soluciones: ");
                Console.Write("X1: " + x1);
                Console.Write("X2: " + x2);
            }
            else if (d == 0)
            {
                Console.Write("X1: " + x1);
            }
            else if (d < 0)
            {
                Console.Write("La ecuación no tiene una solución ");
            }
        }
    }
}
