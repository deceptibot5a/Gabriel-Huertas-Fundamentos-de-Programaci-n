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
            double a = Math.Asin(y / t);
            double c = Math.Asin(z / t);
            double aG = a * (180 / Math.PI);
            double cG = c * (180 / Math.PI);

            Console.WriteLine("Los ángulos son: 90° " + aG + "° y " + cG + "°");

            Console.Read();
        }
    }
}
