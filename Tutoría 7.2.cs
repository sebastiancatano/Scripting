using System;

namespace Tutoría_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            string respuesta = "";
            int total = 0, carta1 = 0, carta2 = 0, carta_adicional = 0, jugadores = 0, totalJugadores = 0, min = 200, max = 0;
            Console.WriteLine("Porfavor ingrese el numero de jugadores (entre 2 y 5)");
            jugadores = int.Parse(Console.ReadLine());
            int[] totales = new int[jugadores];
            string[] nombres = new string[jugadores];

            for (int i = 0; i < jugadores; i++)
            {
                Console.WriteLine("Nombre:");
                nombres[i] = (Console.ReadLine());
            }
            while ((2 <= jugadores && jugadores <= 5) == false)
            {
                Console.WriteLine("Error");
                jugadores = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < jugadores; i++)
            {
                Console.WriteLine("\nBienvenido " + (nombres[i]));
                Console.WriteLine("Comenzar?(S/N): ");
                respuesta = Console.ReadLine();
                while (respuesta != "S" && respuesta != "N")
                {
                    Console.WriteLine("Porfavor ingrese una respuesta válida");
                    respuesta = Console.ReadLine();
                }
                if (respuesta == "S")
                {
                    carta1 = aleatorio.Next(1, 11);
                    Console.WriteLine("Carta 1: " + carta1);
                    carta2 = aleatorio.Next(1, 11);
                    Console.WriteLine("Carta 2: " + carta2);

                    total = (carta1 + carta2);
                    Console.WriteLine("Total: " + total);
                    while ((total < 21) && (respuesta == "S"))
                    {
                        Console.WriteLine("Desea agregar una carta?(S/N)");
                        respuesta = Console.ReadLine();
                        while (respuesta != "S" && respuesta != "N")
                        {
                            Console.WriteLine("Porfavor ingrese una respuesta válida");
                            respuesta = Console.ReadLine();
                        }
                        if (respuesta == "S")
                        {
                            carta_adicional = aleatorio.Next(1, 11);
                            Console.WriteLine("Carta Adicional: " + carta_adicional);
                            total += carta_adicional;
                            Console.WriteLine("Total " + total);
                        }
                        else
                        {
                            Console.WriteLine("Te has retirado.");
                            totalJugadores = total;
                        }

                    }
                    if (total > 21)
                    {
                        total = 0;
                        Console.WriteLine("\nHas perdido");
                        respuesta = "n";

                    }
                    else if (total == 21)
                    {
                        Console.WriteLine("\nGanaste");

                    }
                }
                totales[i] = total;
            }
            int h = 0, numJugador = 0, y = 0;           
            for (int i = 0; i < totales.Length; i++)
            {
                if (totales[i] > max)
                {
                    max = totales[i];
                    numJugador = i + 1;
                }
            }
            Console.WriteLine("los ganadores han sido los que tengan un total de " + max);
            //Ordenamiento de datos
            for (int k = 0; k < totales.Length; k++)
            {
                for (int i = 0; i < totales.Length - 1; i++)
                {
                    if (totales[i + 1] > totales[i])
                    {
                        int tmp = totales[i + 1];
                        totales[i+1] = totales[i];
                        totales[i] = tmp;
                        string tmp2 = nombres[i+1];
                        nombres[i+1] = nombres[i];
                        nombres[i] = tmp2;
                    }
                }
            }
            for (int i = 0; i < totales.Length; i++)
            {
                Console.WriteLine(nombres[i] + " obtuvo " + totales[i] + " puntos.");
            }
            Console.WriteLine("Primer y segundo lugar:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(nombres[i] + " con " + totales[i] + " puntos.");
            }
        }
    }
}
