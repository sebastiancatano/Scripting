using System;

namespace Desafío_02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diagrama de flujo https://app.diagrams.net/?src=about#G1cLvdOTM4Auh7uPxhtrZTsDtdQxS3DB4S
            //Link al video sustentación (para los 3 programas - 02-01, 02-02, 02-03) https://drive.google.com/file/d/1etVsmGef340Z2exUSSN561hez0KeLhRe/view?usp=sharing
            //Entradas
            Console.Write("Ingrese el lado Z: ");
            double z = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el ángulo C: ");
            double c = double.Parse(Console.ReadLine());

            //Procesos
            double cRad = c * Math.PI / 180;
            double t = z / Math.Sin(cRad);
            double aRad = Math.Acos(z / t);
            double y = Math.Sqrt((t * t) - (z * z));
          
            //Salida
           double a = aRad * 180 / Math.PI;

            t = Math.Round(t, 2);
            y = Math.Round(y, 2);
            a = Math.Round(a, 2);

            Console.WriteLine("t es igual a:" + t);
            Console.WriteLine("a es igual a:" + a);
            Console.WriteLine("y es igual a:" + y);
        }
    }
}
