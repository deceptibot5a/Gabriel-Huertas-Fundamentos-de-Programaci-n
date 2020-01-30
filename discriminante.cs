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
            Console.Write("Ingrese el valor de 'a': ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de 'b': ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de 'c': ");
            double c = double.Parse(Console.ReadLine());

            double x = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            double x1 = Math.Pow(x, 2);
            double d = (Math.Pow(b, 2) - (4 * a * c));

            if  (d == 0)
            {
                Console.WriteLine("La solución existe y es única");
                Console.Write("X1 es igual a: " + x1);
            }
            else if (d > 0)
            {
                Console.WriteLine("Existen dos posible soluciones");
                Console.Write("X1 es igual a: " + x1 + " y X2 a: " + x);
            }
            else
            {
                Console.WriteLine("No es posible calcular");
            }

            
            Console.Read();

        }
    }
}
