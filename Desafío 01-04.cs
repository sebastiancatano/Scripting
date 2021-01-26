using System;

namespace Desafío_01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diagramas de flujo (Los 4 cálculos/entredas) https://app.diagrams.net/?src=about#G1vrI_0tvj5EWqPRk3fSqVNTdif2Vlqhbq
            // Link al  video sustentación https://drive.google.com/file/d/1jzz3-I53iO069y_wOp_h8tSLN7Tb6TKA/view?usp=sharing
            //Primer cálculo 
            //Entradas
            Console.Write("Ingrese el ángulo b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el lado z: ");
            double z = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el lado y: ");
            double y = double.Parse(Console.ReadLine());

            //Procesos
            double bRad = b * Math.PI / 180;
            double aRad = Math.Atan(y / z);
            double x = Math.Tan(bRad + aRad) * z - y;
            x = Math.Round(x, 2);

            //Salida
            Console.WriteLine("x es igual a:" + x);
            Console.WriteLine(" ");

            //Segundo cálculo
            //Entradas
            Console.Write("Ingrese el ángulo d: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el ángulo b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el lado y: ");
            y = double.Parse(Console.ReadLine());

            //Procesos
            double dRad = d * Math.PI / 180;
            aRad = Math.PI / 2 - dRad - bRad;
            z = y / Math.Tan(aRad);
            z = Math.Round(z, 2);

            //Salida
            Console.WriteLine("z es igual a:" + z); 
            Console.WriteLine(" ");

            //Tercer cálculo
            //Entradas           
            Console.Write("Ingrese el lado w: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el ángulo d: ");
            d = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el lado x: ");
            x = double.Parse(Console.ReadLine());

            //Procesos
            dRad = d * Math.PI / 180;
            y = Math.Cos(dRad) * w - x;
            y = Math.Round(y, 2);

            //Salida
            Console.WriteLine("y es igual a:" + y);
            Console.WriteLine(" ");

            //Cuarto cálculo
            //Entradas
            Console.Write("Ingrese el lado w: ");
            w = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el lado t: ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el ángulo c: ");
            double c = double.Parse(Console.ReadLine());

            //Proceso
            double cRad = c * Math.PI / 180;
            z = Math.Sin(cRad) * t;
            dRad = Math.Asin(z / w);
            y = z / Math.Tan(cRad);
            x = Math.Cos(dRad) * w - y;
            x = Math.Round(x, 2);

            //Salida
            Console.WriteLine("x es igual a:" + x);



        }
    }
}











