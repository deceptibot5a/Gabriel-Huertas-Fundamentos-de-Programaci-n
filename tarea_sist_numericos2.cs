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
            Console.Write("Ingrese el valor de 'd': ");
            double dG = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de 'b': ");
            double bG = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de 'y': ");
            double y = double.Parse(Console.ReadLine());

            double d = dG * (Math.PI / 180.0);
            double b = bG * (Math.PI / 180.0);

            //Se toman los dos triángulos como uno solo y se hallan sus ángulos
            double recto = 90 * (Math.PI / 180.0);
            double total = 180 * (Math.PI / 180.0);
            double ab = total - recto - d;
            double a = ab - b;

            //Con esos datos se encuentra z
            double z = (y/Math.Tan(a));
        
            Console.WriteLine("El valor de 'z' es: " + z);

            Console.Read();
        }
    }
}
