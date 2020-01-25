using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            Console.Write("Ingrese el valor de 'w': ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de 't': ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de 'c': ");
            double cG = double.Parse(Console.ReadLine());

            double c = cG * (Math.PI / 180.0);

            //Se hallan los valores del triángulo pequeño
            double z = t * Math.Sin(c);
            double y = Math.Sqrt(Math.Pow(t, 2) - Math.Pow(z, 2));

            //Se toman los dos triángulos como uno y se halla el lado faltante
            double xy = Math.Sqrt(Math.Pow(w, 2) - Math.Pow(z, 2));
            double x = xy - y;

            Console.WriteLine("El valor de 'x' es: " + x);

            Console.Read();
        }
    }
}
