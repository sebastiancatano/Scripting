using System;

namespace Tutoría_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Nezuko", "Tanjiro", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 153, 165, 164.5, 164, 180, 156, 176 };
            double[] distanciaPro = new double[estatura.Length];
            double total = 0, min = 200;
            int indice = 0;
            for (int i = 0; i < estatura.Length; i++)
            {
                total += estatura[i];
            }
            double promedio = total / estatura.Length;
            Console.WriteLine("PROMEDIO " + promedio);
            for (int i = 0; i < estatura.Length - 1; i++)
            {
                distanciaPro[i] = Math.Abs(promedio - estatura[i]);
                if (distanciaPro[i] < min)
                {
                    min = distanciaPro[i];
                    indice = i;
                }
            }           
            Console.WriteLine("Distancia menor " + estatura[indice] + " " + nombres[indice]);
            //Ordenamiento de datos
            for (int k = 0; k < estatura.Length; k++)
            {
                for (int i = 0; i < estatura.Length - 1; i++)
                {
                    if (estatura[i] > estatura[i + 1])
                    {
                        double tmp = estatura[i];
                        estatura[i] = estatura[i + 1];
                        estatura[i + 1] = tmp;
                        string tmp2 = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i + 1] = tmp2;
                    }
                }
            }
            for (int i = 0; i < estatura.Length; i++)
            {
                Console.WriteLine(estatura[i] + " " + nombres[i]);
            }
        }
    }
}
