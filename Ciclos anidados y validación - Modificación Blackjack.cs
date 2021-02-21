using System;

namespace Ciclos_anidados_y_validación___Modificación_Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            //link video https://drive.google.com/file/d/13RIsGKe2Nnyk1U2NPOKOtYj-uCt80Gxd/view?usp=sharing
            Random aleatorio = new Random();
            int[] totales = new int[5];
            string respuesta = "", si = "S", no = "N";
            int total = 0, carta1 = 0, carta2 = 0, carta_adicional = 0, jugadores = 0, totalJugadores = 0;                      
            Console.WriteLine("Porfavor ingrese el numero de jugadores (entre 2 y 5)");
            jugadores = int.Parse(Console.ReadLine());          
            while ((2 <= jugadores && jugadores <= 5) == false)
            {
                Console.WriteLine("Error");
                jugadores = int.Parse(Console.ReadLine());
            }
           
            for (int i = 0; i < jugadores; i++)
            {
                Console.WriteLine("\nBienvenido jugador " + (i + 1));
                Console.WriteLine("Comenzar?(S/N): ");
                respuesta = Console.ReadLine();
                while (respuesta != si && respuesta != no)
                {
                    Console.WriteLine("Porfavor ingrese una respuesta válida");
                    respuesta = Console.ReadLine();                  
                }
                if (respuesta == si)
                {
                    carta1 = aleatorio.Next(1, 11);
                    Console.WriteLine("Carta 1: " + carta1);
                    carta2 = aleatorio.Next(1, 11);
                    Console.WriteLine("Carta 2: " + carta2);

                    total = (carta1 + carta2);
                    Console.WriteLine("Total: " + total);
                    while ((total < 21) && (respuesta == si))
                    {
                        Console.WriteLine("Desea agregar una carta?(S/N)");
                        respuesta = Console.ReadLine();
                        while (respuesta != si && respuesta != no)
                        {
                            Console.WriteLine("Porfavor ingrese una respuesta válida");
                            respuesta = Console.ReadLine();
                        }
                        if (respuesta == si)
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
            int h = 0, max = 0, numJugador = 0, y = 0;
            
            Console.WriteLine("Las partidas que no han excedido 21 han sido:");
            while (h < totales.Length)
            {
                if (totales[h] != 0) {  Console.WriteLine("Jugador " + (h + 1) + ": " + totales[h]); } 
                h++; 
            }
            Console.WriteLine("------------------------------------------------------");
            while (y < totales.Length)
            //for (int y = 0; y < totales.Length; y++)
            {
                if (totales[y] == 21) { Console.WriteLine("Jugador " + (y + 1) + ": es un ganador con 21 exacto!"); } 
                y++;
               
            }
            for (int i = 0; i < totales.Length; i++)
            {
                if(totales[i] > max)
                {
                    max = totales[i];
                    numJugador = i+1;
                }
            }
            Console.WriteLine("los ganadores han sido los que tengan un total de " + max);                     
        }
    }
}
