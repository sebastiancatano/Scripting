using System;

namespace Desafío_2_Calculo_de_cuota_moderadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Video https://drive.google.com/file/d/16Ce6dQfIzjztwrp_V69jEgFwiZnEW_Fd/view?usp=sharing
            Console.WriteLine("Inserte su salario mensual: ");
            double salario = double.Parse(Console.ReadLine());
            double smmlv = 908526;

            if (salario < smmlv * 2)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Su salario corresponde a la tarifa A ");
                Console.WriteLine("Valor de cuota moderadora: 3400 ");

            }
            else if (smmlv * 2 <= salario && salario <= smmlv * 5)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Su salario corresponde a la tarifa B ");
                Console.WriteLine("Valor de cuota moderadora: 13500 ");

            }
            else if (salario > smmlv * 5)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Su salario corresponde a la tarifa C ");
                Console.WriteLine("Valor de cuota moderadora: 35600 ");

            }
        }
    }
}
