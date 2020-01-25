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
            //Entrada
            Console.Write("Ingrese el valor de 'b': ");
            double bG = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de 'z': ");
            double z = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de 'y': ");
            double y = double.Parse(Console.ReadLine());

            double t = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(y, 2));
            double b = bG * (Math.PI / 180.0);

            //Cálculo de los ángulos del triángulo pequeño
            double a = Math.Asin(y / t);
            double c = Math.Asin(z / t);

            //Se toman los dos triángulos como uno solo y se hallan sus ángulos
            double ab = a + b;
            double recto = 90 * (Math.PI / 180.0);
            double total = 180 * (Math.PI / 180.0);
            double d = total - recto - ab;

            //Con esos datos se encuentra x
            double x = (t * (Math.Sin(b)))/Math.Sin(d);

            Console.WriteLine("El valor de 'x' es: " + x);

            Console.Read();
        }
    }
}
