using System;

namespace Tipos_de_contrato___Switch_case
{
    class Program
    {
        static void Main(string[] args)
        //Video explicación https://drive.google.com/file/d/1q24zsYEy3cIrY0PIGVrbBGHydWVKaI6B/view?usp=sharing
        //Minuto explicación ejercicio excel: 2:12
        {
            Console.WriteLine("Ingrese su salario: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tipo de contrato " + "1. Dependiente 2. Independiente: ");
            double tipo_de_contrato = double.Parse(Console.ReadLine());
            int smmlv = 908526;
            double EPS = 0, pension = 0, ARL = 0;
            double cotizacion = salario * 0.4;
            if (cotizacion <= smmlv) { cotizacion = smmlv; }           
            double prima = 0;
            switch (tipo_de_contrato) 
            {
                case 1:             
                EPS = cotizacion * 0.04;
                pension = cotizacion * 0.04;
                prima = salario;
                break;

                case 2:             
                Console.WriteLine("Ingrese su tipo de riesgo: ");
                double riesgo = double.Parse(Console.ReadLine());
                switch (riesgo)
                {
                    case 1: riesgo = 0.00522; break;
                    case 2: riesgo = 0.01044; break;
                    case 3: riesgo = 0.02436; break;
                    case 4: riesgo = 0.0435; break;
                    case 5: riesgo = 0.0696; break;
                    default: Console.WriteLine("Esa categoría no existe."); break;
                }            
                ARL = cotizacion * riesgo;
                EPS = cotizacion * 0.125;
                pension = cotizacion * 0.16;
                break;
            }
            double salario_real = salario - EPS - pension - ARL;
            double salario_anual = salario_real * 12 + prima;

            Console.WriteLine("Base Cotizacion: " + cotizacion);
            Console.WriteLine("Salario real: " + salario_real);
            Console.WriteLine("Salario Anual: " + salario_anual);
            Console.WriteLine("ARL: " + ARL);
            Console.WriteLine("EPS: " + EPS);
            Console.WriteLine("Pension: " + pension);
            Console.WriteLine("Prima: " + prima);


        }
    }
}
