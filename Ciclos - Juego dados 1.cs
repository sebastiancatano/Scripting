using System;

namespace Ciclos___Juego_Dados_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Video explicación https://drive.google.com/file/d/1C5oh8vAIc_r5HIBv9KQnBbLPhnApsLnN/view?usp=sharing
            Random aleatorio = new Random();
            string respuesta = "S";
            int total = 0, dado1 = 0, dado2 = 0, doble = 0;
            double turno = 0, seises = 0;
            Console.WriteLine("Desea jugar?: (S/N) ");
            respuesta = Console.ReadLine();                                
                while ((total < 100) && (respuesta == "S"))
                {
                    Console.WriteLine("Tirar dados?(S/N)");
                    respuesta = Console.ReadLine();
                    if (respuesta == "S")
                    {
                        dado1 = aleatorio.Next(1, 7);
                        Console.WriteLine("Dado 1: " + dado1);
                        dado2 = aleatorio.Next(1, 7);
                        Console.WriteLine("Dado 2: " + dado2);
                        if (dado1 == dado2 && (dado1 =! 1 && dado2 =! 1)) { Console.WriteLine("Par!"); doble += 1; Console.WriteLine("+ 1 Par"); }
                        if (doble == 3) { Console.WriteLine("Obtuviste 3 pares, Ganaste!"); respuesta = "n"; }
                        if (dado1 == 1 && dado2 == 1)
                        {
                            Console.WriteLine("Perdiste, obtuviste par de 1's");
                            respuesta = "n";
                        }
                        total += (dado1 + dado2);
                        Console.WriteLine("Total " + total);
                        if (dado1 + dado2 > 6) { seises += 1; }
                    }
                    else{ Console.WriteLine("Te has retirado");}
                turno++;
                }
                if (total >= 100) { Console.WriteLine("\nGanaste!");}
            Console.WriteLine("Número de turnos: " + turno);
            Console.WriteLine("Número de veces que la suma de lo sdados fue mayor a 6: " + seises);
            Console.WriteLine("Porcentaje de turnos donde la suma de los dados fue mayor a 6: " + (seises/turno)*100);




        }
    }
}
