using System;

namespace ssin_x_
{
    class Program
    {
        //Video https://drive.google.com/file/d/1bGCgusZkAKlwnvt_SCvQM18OjeLQL1fn/view?usp=sharing
        static void Main(string[] args)
        {
            double x = 0.5, n = 100, e = 0;            
            for (int i = 0; i <= n; i++)
            {
                e += ((Math.Pow(-1, i)) / Factorial(2 * i + 1)) * Math.Pow(x, 2 * i + 1);
            }
            Console.WriteLine(e);
        }
        static double Factorial(double valor)
        {
            double total = 1;
            for (int i = 1; i <= valor; i++)
            {
                total *= i;
            }
            return total;
        }
    }
}
