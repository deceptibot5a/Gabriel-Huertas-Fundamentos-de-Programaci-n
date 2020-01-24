using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada catetos + salida hipotenusa
            Console.Write("Ingrese el cateto 'y': ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el cateto 'z': ");
            int z = int.Parse(Console.ReadLine());
            double t = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(y, 2));
            Console.WriteLine("La hipotenusa es: " + t);

            //Cálculo y conversión ángulos
            double aG = Math.Asin(y / t);
            double cG = Math.Asin(z / t);
            double a = aG * (180 / Math.PI);
            double c = cG * (180 / Math.PI);

            Console.WriteLine("Los ángulos son: 90° " + a + "° y " + c + "°");

            Console.Read();
        }
    }
}
