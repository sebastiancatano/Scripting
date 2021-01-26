using System;

namespace Desafío_02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diagrama de flujo https://app.diagrams.net/#G1YgIXDdncnQ-BcICb9S27lytltTTCtG21
            //Link al video sustentación (para los 3 programas - 02-01, 02-02, 02-03) https://drive.google.com/file/d/1etVsmGef340Z2exUSSN561hez0KeLhRe/view?usp=sharing
            //Entradas
            Console.Write("Ingrese el lado y: ");
            double y = double.Parse(Console.ReadLine()); ;
            Console.Write("Ingrese el lado z: ");
            double z = double.Parse(Console.ReadLine()); ;

            //Procesos
            double t = Math.Sqrt((y * y) + (z * z));
            double aRad = Math.Asin(y / t);
            double cRad = Math.Asin(z / t);
    
            //Salida
            double a = aRad * 180 / Math.PI;
            double c = cRad * 180 / Math.PI;

            t = Math.Round(t, 2);
            a = Math.Round(a, 2);
            c = Math.Round(c, 2);

            Console.WriteLine("t es igual a:" + t);
            Console.WriteLine("a es igual a:" + a);
            Console.WriteLine("c es igual a:" + c);
        }
    }
}
