using System;

namespace Ciclos_2__Juego_dados_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // video https://drive.google.com/file/d/1FR_BqGClu5C70N36yQRTNFY6_PFO6bTk/view?usp=sharing
            Random aleatorio = new Random();
            int total = 0, dado = 0, dado2 = 0,  vidas = 3, turnos = 1;
            string respuesta = "";
            Console.WriteLine("Desea jugar?: (S/N) ");
            respuesta = Console.ReadLine();
            while (respuesta != "S" && respuesta != "N" && respuesta != "s" && respuesta != "n")
            { Console.WriteLine("Porfavor ingrese una respuesta valida"); respuesta = Console.ReadLine(); }
            if (respuesta == "S" || respuesta == "s")
            {
                while ((total < 100) && (respuesta == "S" || respuesta == "s") && (vidas > 0))
                {

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
                        Console.WriteLine("Turno actual " + turnos);
                        if (turnos % 2 == 0) { vidas -= 1; Console.WriteLine("-1 vida."); }
                        if (turnos % 3 == 0 && turnos != 1) 
                        {
                            dado2 = aleatorio.Next(1, 7);
                            Console.WriteLine("Segundo dado del turno: " + dado2);
                            total += dado2;
                            Console.WriteLine("Total: " + total);
                            Console.WriteLine("Vidas: " + vidas);
                            Console.WriteLine("Turno actual: " + turnos);
                            if(dado == dado2) { vidas++; Console.WriteLine("Ganaste una vida exrta."); }
                        }

                    }

                    else { Console.WriteLine("Te has retirado"); }
                    turnos += 1;
                    //Console.WriteLine("Turno siguiente " + turnos);
                }
            }
            if (total >= 100) { Console.WriteLine("\nGanaste!"); }
        }
    }
}
