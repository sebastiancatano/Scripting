using System;

namespace Tutoría_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int a = 0, b = 0, sumaCorrecta = 0, suma =0, oportunidades = 3;
            Console.WriteLine("Porfavor, ingrese el resultado correcto de la suma para contnuar.");
            for (int i = 0; i < oportunidades; i++)
            {
                a = aleatorio.Next(1, 11); b = aleatorio.Next(1, 11);
                Console.WriteLine(a + "+" + b + "?");
                sumaCorrecta = a + b;
                suma = int.Parse(Console.ReadLine());
                if(suma != sumaCorrecta) { Console.WriteLine("Error"); }
                else { Console.WriteLine("Correcto"); break; }    

            }
            if(suma == sumaCorrecta )Console.WriteLine("Puede continuar al programa.");
            else { Console.WriteLine("La validación fue incorrecta,no puede continuar al programa."); }
        }
    }
}
