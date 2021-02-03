using System;

namespace Tutoría_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Votos por el partido 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Votos por el partido 2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Votos en blanco");
            int blanco = int.Parse(Console.ReadLine());
            Console.WriteLine("Votos anulados");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("número total de la población de todas las edades");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("porcentaje (de 0 a 100) de la población que es mayor de edad");
            double p = double.Parse(Console.ReadLine());
            int mayores = (int)((n * p)/100);
            Console.WriteLine("personas mayores de edad:" + mayores);
            
            int totalVotantes = a + b + blanco + anulados;
            Console.WriteLine("Total de votante: " + totalVotantes);
            int abstencion = mayores - totalVotantes;
            Console.WriteLine("abstencion: " + abstencion);




            if (((anulados < (a + b) * 0.3) || ((a + b) > blanco)) && (abstencion < totalVotantes))
            {
                
                Console.WriteLine("Las votaciones fueron exitosas");
                if(a > b + blanco)
                {
                    Console.WriteLine("El partido ganador fue a");
                }
                else if(b > a + blanco)
                {
                    Console.WriteLine("El partido ganador fue b");
                }                
                
            }
            else Console.WriteLine("Las elecciones deben repetirse");





        }
    }
}
