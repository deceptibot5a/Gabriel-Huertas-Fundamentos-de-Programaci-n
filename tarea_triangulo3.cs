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
            //Entrada de datos
            Console.Write("Ingrese el cateto 'z': ");
            double z = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el ángulo 'c': ");
            double cG = double.Parse(Console.ReadLine());

            //De grados a radianes
            double c = cG * (Math.PI / 180.0);

            //Cálculos lados y ángulo
            double y = (z / Math.Tan(c));
            double t = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(y, 2));
            double a = Math.Asin(y / t);

            //De radianes a grados
            double aG = a * (180.0 / Math.PI);
        
            //Salida
            Console.WriteLine("El otro cateto es: " + y);
            Console.WriteLine("La hipotenusa es: " + t);
            Console.WriteLine("Los otros ángulos son: 90° " + aG + "°");

            Console.Read();
        }
    }
}
