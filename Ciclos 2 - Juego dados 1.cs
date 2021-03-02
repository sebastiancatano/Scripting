using System;

namespace Ciclos_2___Juego_dados_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // video https://drive.google.com/file/d/1FR_BqGClu5C70N36yQRTNFY6_PFO6bTk/view?usp=sharing

            Random aleatorio = new Random();
            int total = 0, dado = 0, vidas = 3, unos = 0, tiroAnterior = 0, dadoEspecial = 2;
            string respuesta = "";
            Console.WriteLine("Desea jugar?: (S/N) ");
            respuesta = Console.ReadLine();
            while (respuesta != "S" && respuesta != "N" && respuesta != "s" && respuesta != "n")
            { Console.WriteLine("Porfavor ingrese una respuesta valida"); respuesta = Console.ReadLine(); }
            if (respuesta == "S" || respuesta == "s")
            {
                while ((total < 100) && (respuesta == "S" || respuesta == "s") && (vidas > 0))
                {
                    while (dadoEspecial > 0 && (respuesta == "S" || respuesta == "s"))
                    {
                        Console.WriteLine("\nDados especiales restantes: " + dadoEspecial);
                        Console.WriteLine("Tirar dado especial?(S/N)");
                        respuesta = Console.ReadLine();
                        while (respuesta != "S" && respuesta != "N" && respuesta != "s" && respuesta != "n")
                        { Console.WriteLine("Porfavor ingrese una respuesta valida"); respuesta = Console.ReadLine(); }
                        if (respuesta == "S" || respuesta == "s")
                        {
                            dado = aleatorio.Next(1, 13);
                            Console.WriteLine("Dado especial: " + dado);
                            total += dado;
                            Console.WriteLine("Total: " + total);
                            Console.WriteLine("Vidas: " + vidas);
                            
                            if (dado == 1) { unos++; }
                            if (unos == 2) { vidas -= 1; total -= 10; Console.WriteLine("Sacaste dos veces 1. Pierdes una vida y 10 puntos."); unos = 0; }
                            if (dado == 6 && tiroAnterior == 6 && vidas < 3) { vidas++; Console.WriteLine("Sacaste dos 6 consecutivos, recuperas una vida"); }
                            dadoEspecial -= 1;
                            tiroAnterior = dado;
                        }
                        else { break; }
                    }                                      
                    Console.WriteLine("\nTirar dados?(S/N)");
                    respuesta = Console.ReadLine();
                    while (respuesta != "S" && respuesta != "N" && respuesta != "s" && respuesta != "n")
                    { Console.WriteLine("Porfavor ingrese una respuesta valida"); respuesta = Console.ReadLine(); }
                    if (respuesta == "S" || respuesta == "s")
                    {
                        dado = aleatorio.Next(1, 7);
                        Console.WriteLine("Dado: " + dado);
                        total += dado;
                        Console.WriteLine("Total: " + total);
                        Console.WriteLine("Vidas: " + vidas);                        
                        if (dado == 1) { unos++; }
                        if ((unos != 0) && (unos % 2 == 0)) { vidas -= 1; total -= 10; Console.WriteLine("Sacaste dos veces 1. Pierdes una vida y 1o puntos."); unos = 0; }
                        if (dado == 6 && tiroAnterior == 6 && vidas < 3) { vidas++; Console.WriteLine("Sacaste dos 6 consecutivos, recuperas una vida"); }
                        tiroAnterior = dado;                  
                    }
                    else { Console.WriteLine("Te has retirado"); }               
                }
            }
            if (total >= 100) { Console.WriteLine("\nGanaste!"); }
        }
    }
}
