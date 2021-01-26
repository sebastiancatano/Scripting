using System;

namespace Desafío_02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diagrama de flujo https://app.diagrams.net/#G1fyx9SsnMoMW2hYoXWOuXSJfW_oL-qdh6
            //Link al video sustentación (para los 3 programas - 02-01, 02-02, 02-03) https://drive.google.com/file/d/1etVsmGef340Z2exUSSN561hez0KeLhRe/view?usp=sharing
            //Entradas
            Console.Write("Ingrese el lado t: ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el ángulo a: ");
            double a = double.Parse(Console.ReadLine());

            //Procesos
            double aRad = a * Math.PI / 180;
            double cRad = Math.PI - (aRad + (Math.PI / 2));
            double y = Math.Sin(aRad) * t;
            double z = Math.Sin(cRad) * t;          

            //Salida
            double c = cRad * 180 / Math.PI;

            y = Math.Round(y, 2);
            z = Math.Round(z, 2);
            c = Math.Round(c, 2);

            Console.WriteLine("c es igual a:" + c);
            Console.WriteLine("y es igual a:" + y);
            Console.WriteLine("z es igual a:" + z);
        }
    }
}
