using System;

namespace String___Buscador_de_palabras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Video https://drive.google.com/file/d/1gwvCZOG0EXYSTZUkCXG2-1biqJuwRHP-/view?usp=sharing
            string frase = "Actividad : el usuario ingresa una frase y una palabra . El programa busca cuantas veces se repite la palabra en la frase y en qué posiciones se encuentra . Deben usar la función ToUpper() para garantizar que no haya problemas si la palabra buscada no coincide en por mayus .";
            string[] palabras = frase.Split(' ');
            Console.WriteLine(frase);
            Console.WriteLine("\nCual palabra desea buscar?");
            string buscador = Console.ReadLine(); buscador = buscador.ToUpper();
            int contador = 0, posicion = 0;
            int[] posiciones = new int[palabras.Length];           
            for(int i = 0; i < palabras.Length; i++)
            {
                palabras[i] = palabras[i].ToUpper();              
                posicion++;
                if (buscador == palabras[i])
                {
                    contador++;
                    posiciones[contador] = posicion;
                }               
            } 
            Console.WriteLine("La palabra se repite " + contador + " veces, en las posiciones:");
            for (int i = 1; i <= contador; i++) { Console.WriteLine(posiciones[i]); }
        }
    }
}
