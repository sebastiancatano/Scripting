using System;

namespace Ciclos___Juego_Dados_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Video explicación https://drive.google.com/file/d/1C5oh8vAIc_r5HIBv9KQnBbLPhnApsLnN/view?usp=sharing
            Random aleatorio = new Random();
            string respuesta = "S";
            int total = 0, dado = 0, libres = 3; 
            

            Console.WriteLine("Desea jugar?: (S/N) ");
            respuesta = Console.ReadLine();
            if(respuesta == "S")
            {
                for (int contador = 0; contador < libres; contador++)
                {
                    
                        switch (contador)
                        {
                            case 0: Console.WriteLine("\nTienes 3 turnos libres"); break;
                            case 1: Console.WriteLine("\nTienes 2 turnos libres"); break;
                            case 2: Console.WriteLine("\nTienes 1 turno libre"); break;
                        }
                        Console.WriteLine("Tirar dados?(S/N)");
                        respuesta = Console.ReadLine();
                    if (respuesta == "S")
                    {
                        dado = aleatorio.Next(1, 13);
                        Console.WriteLine("Dado: " + dado);
                        total += dado;
                        Console.WriteLine("\nTotal " + total);
                    }

                    else { Console.WriteLine("Te has retirado"); break; }
                }
                while ((total < 100) && (respuesta == "S"))
                {
                    Console.WriteLine("\nTirar dados?(S/N)");
                    respuesta = Console.ReadLine();
                    dado = aleatorio.Next(1, 13);
                    Console.WriteLine("Dado: " + dado);
                    total += dado;
                    Console.WriteLine("\nTotal " + total);                   
                    if (dado % 2 != 0) { Console.WriteLine("Obtuviste un número impar. Perdiste."); respuesta = "n"; }
                    if (dado == 12) 
                    {                         
                        Console.WriteLine("\nTirar dados?(S/N)");
                        respuesta = Console.ReadLine();
                        dado = aleatorio.Next(1, 13);
                        Console.WriteLine("Dado: " + dado);
                        total += dado;
                        Console.WriteLine("\nTotal " + total);
                        if (dado == 10) { Console.WriteLine("Ganaste, obtuviste un 10 después de un 12."); respuesta = "n"; }
                    }                                        
                }
                
                if (total >= 100)
                {
                    Console.WriteLine("\nGanaste!");
                }
            }
            else { Console.WriteLine("Te has retirado."); }
        }
    }
}
