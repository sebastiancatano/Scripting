using System;

namespace Valores_Extremos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Video explicación https://drive.google.com/file/d/1C5oh8vAIc_r5HIBv9KQnBbLPhnApsLnN/view?usp=sharing
            double total = 0;
            Console.WriteLine("Cuantos datos ingresará? ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 200;
            string nombre = "", nombreMayor = "", nombreMenor = "";
            while (i < n)
            {
                Console.WriteLine("Nombre:");
                nombre = (Console.ReadLine());
                Console.WriteLine("Edad:");
                int edad = int.Parse(Console.ReadLine());
                if (edad > max) {
                    max = edad;
                    nombreMayor = nombre;
                }
                if (edad < min)
                {
                    min = edad;
                    nombreMenor = nombre;
                }

                    total += edad;
                i++;
                Console.WriteLine(" ");

            }
            double promedio = total / n;
            Console.WriteLine("Promedio:" + promedio);
            Console.WriteLine("Mayor:" + nombreMayor + " " + max + " años");
            Console.WriteLine("Menor:" + nombreMenor + " " + min + " años");

        }
    }
}
