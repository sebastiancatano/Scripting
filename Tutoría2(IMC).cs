using System;

namespace Tutoría_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entradas
            Console.Write("Ingrese su masa corporal en kilogramos: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su estatura en metros: ");
            double a = double.Parse(Console.ReadLine());

            //Proceso

            double IMC = m / (a * a);

            if (IMC < 18.5)
            {
                Console.WriteLine("Su IMC es inferior al normal");
            }
            else if (18.5 <= IMC && IMC <= 24.9)
            {
                Console.WriteLine("Su IMC está dentro del promedio");
            }
            else if (25 <= IMC && IMC <= 29.9)
            {
                Console.WriteLine("Su IMC está sobre el promedio");
            }
            else if (IMC > 30)
            {
                Console.WriteLine("Su IMC está dentro de la categoría de obesidad");
            }






        }
    }
}
