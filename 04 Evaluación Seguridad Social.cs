using System;

namespace _04_Evaluación_seguridad_Social
{
    class Program
    {
        static void Main(string[] args)
        {
            // Video explicación https://drive.google.com/file/d/1YiHe596ISvJ1rvReOnV7FTYmx6yzpsTN/view?usp=sharing
            double smmlv = 908526;
            Console.WriteLine("Inserte su salario mensual: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserte su tipo de contrato (1 para Dependiente/ 2 para Independiente): ");
            int tipo_de_contrato = int.Parse(Console.ReadLine());
            
            if(tipo_de_contrato == 1)
            {
                double cotizacion = salario * 0.4;
                if(cotizacion < smmlv)
                {
                    cotizacion = smmlv;
                }
                else
                {
                    cotizacion = cotizacion;
                }
                double pension = cotizacion * 0.04;
                double EPS = cotizacion * 0.04;
                double ARL = cotizacion * 0;
                double deduccion = pension + EPS + ARL;
                double salario_real = salario - deduccion;
                double salario_anual = salario_real * 12 + salario;

                Console.WriteLine(" ");
                Console.WriteLine("Salario Real: " + salario_real);
                Console.WriteLine("Salario Anual: " + salario_anual);
                Console.WriteLine("Pension: " + pension);
                Console.WriteLine("EPS: " + EPS);
                Console.WriteLine("ARL: " + ARL);

            }
            else if(tipo_de_contrato == 2)
            Console.WriteLine("Inserte su clase de riesgo (1 a 5): ");
            double clase_de_riesgo  = double.Parse(Console.ReadLine());
            if (clase_de_riesgo == 1) { clase_de_riesgo = 0.00522; }
            if (clase_de_riesgo == 2) { clase_de_riesgo = 0.01044; }
            if (clase_de_riesgo == 3) { clase_de_riesgo = 0.02436; }
            if (clase_de_riesgo == 4) { clase_de_riesgo = 0.0435; }
            if (clase_de_riesgo == 5) { clase_de_riesgo = 0.0696; }

            {
                double cotizacion = salario * 0.4;
                if (cotizacion < smmlv)
                {
                    cotizacion = smmlv;
                }
                else
                {
                    cotizacion = cotizacion;
                }
                double pension = cotizacion * 0.16;
                double EPS = cotizacion * 0.125;
                double ARL = cotizacion * clase_de_riesgo;
                double deduccion = pension + EPS + ARL;
                double salario_real = salario - deduccion;
                double salario_anual = salario_real * 12;

                Console.WriteLine("Salario Real: " + salario_real);
                Console.WriteLine("Salario Anual: " + salario_anual);
                Console.WriteLine("Pension: " + pension);
                Console.WriteLine("EPS: " + EPS);
                Console.WriteLine("ARL: " + ARL);
            }
        }
    }
}
