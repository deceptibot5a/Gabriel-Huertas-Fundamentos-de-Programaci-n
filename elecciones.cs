using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Votos para A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Votos para B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Votos en blanco: ");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Votos anulados: ");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Total población: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Porcentaje de mayores de edad: ");
            double p = int.Parse(Console.ReadLine());

            double mayores = (p*n)/100;
            int votantes = a + b + blancos + anulados;
            double abstencion = mayores - votantes;
            

            bool azul = anulados < (a + b) * 0.3;
            bool amarillo = (a + b) > blancos;
            bool rojo = abstencion < votantes;

            Console.WriteLine("Votos:");
            Console.WriteLine("a: " + a + " b: " + b + " blancos: " + blancos + " anulados: " + anulados);
            Console.WriteLine("Total habitantes: " + n + " mayores de edad: " + p + "%");
            Console.WriteLine("Población mayor de edad: " + mayores);
            Console.WriteLine("Total votantes: " + votantes + " abstención: " + abstencion);

            if ((azul || amarillo) && rojo)
            {
                if (a < b) Console.WriteLine("El ganador de las elecciones es B");
                else Console.WriteLine("El ganador de las elecciones es A");
            }
            else Console.WriteLine("Hay que repetir las elecciones");

            Console.Read();
        }
    }
}
