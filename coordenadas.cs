using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un valor en x: ");
            double x1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un valor en y: ");
            double y1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro valor en x: ");
            double x2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro valor en y: ");
            double y2 = int.Parse(Console.ReadLine());
            double pendiente = ((y2 - y1) / (x2 - x1));
            double intercepto = y1 - (pendiente * x1);
            double distancia = Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(x2 - x1, 2));
            Console.WriteLine("La pendiente es: " + pendiente + ", el intercepto es: " + intercepto + " y la distancia es: " + distancia);

        }
    }
}
