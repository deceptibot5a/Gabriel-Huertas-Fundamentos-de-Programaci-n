using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Votos para A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Votos para B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Votos en blanco: ");
            int blancos = int.Parse(Console.ReadLine());
            Console.Write("Votos anulados: ");
            int anulados = int.Parse(Console.ReadLine());
            Console.Write("Población total: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Porcentaje de mayores de edad: ");
            int p = int.Parse(Console.ReadLine());

            double mayores = (p * n) / 100;
            int votos = a + b + blancos + anulados;

            bool azul = (a + b) > n;
            bool amarillo = (Math.Abs(a - b)) < (votos * 0.1);
            bool rojo = mayores < (n * 0.3);

            if ((azul || amarillo) && rojo) Console.WriteLine("Las elecciones deben ser repetidas.");
            else
            {
                if (a > b) Console.WriteLine("El ganador es A");
                else Console.WriteLine("El ganador es B");
            }
            Console.Read();
        }
    }
}
