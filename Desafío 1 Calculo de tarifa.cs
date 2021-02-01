using System;

namespace Desafío_1_Cálculo_de_tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Video https://drive.google.com/file/d/16Ce6dQfIzjztwrp_V69jEgFwiZnEW_Fd/view?usp=sharing
            Console.WriteLine("Inserte su salario mensual: ");
            double salario = double.Parse(Console.ReadLine());
            double smmlv = 908526;

            if(salario < smmlv * 2)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Su salario corresponde a la tarifa A ");
            }
            else if (smmlv*2 <= salario && salario <= smmlv * 4)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Su salario corresponde a la tarifa B ");
            }
            else if (salario > smmlv * 4)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Su salario corresponde a la tarifa C ");
            }


        }
    }
}
