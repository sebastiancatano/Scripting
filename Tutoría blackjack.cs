using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            string respuesta = "S";
            int total = 0, carta1 = 0, carta2 = 0, carta_adicional = 0;
            Console.WriteLine("Desea jugar blackjack?: ");
            respuesta = Console.ReadLine();

            if (respuesta == "S")
            {                                                                                                   
                carta1 = aleatorio.Next(1, 11);
                Console.WriteLine("Carta 1: " + carta1);
                carta2 = aleatorio.Next(1, 11);
                Console.WriteLine("Carta 2: " + carta2);

                total = (carta1 + carta2 );
                Console.WriteLine("Total: " + total);
                while ((total < 21) && (respuesta == "S"))
                {
                    Console.WriteLine("Desea agregar una carta?");
                    respuesta = Console.ReadLine();
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
        }
    }
}
