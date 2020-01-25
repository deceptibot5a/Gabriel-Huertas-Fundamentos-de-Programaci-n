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
            Console.Write("Ingrese el valor de 'd': ");
            double dG = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de 'x': ");
            double x = double.Parse(Console.ReadLine());

            double d = dG * (Math.PI / 180.0);

            //Se toman los dos triángulos como uno solo y se hallan sus ángulos
            double recto = 90 * (Math.PI / 180.0);
            double total = 180 * (Math.PI / 180.0);
            double ab = total - recto - d;

            //Se halla z, luego x + y, luego y
            double z = (w * Math.Sin(d));
            double xy = (w * Math.Sin(ab));
            double y = xy - x;

            Console.WriteLine("El valor de 'y' es: " + y);

            Console.Read();
        }
    }
}
