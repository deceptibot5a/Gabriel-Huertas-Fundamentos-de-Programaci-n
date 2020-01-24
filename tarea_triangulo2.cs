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
            Console.Write("Ingrese la hipotenusa: ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el ángulo 'a': ");
            double aG = double.Parse(Console.ReadLine());

            //De grados a radianes
            double a = aG * (Math.PI / 180.0);

            //Cálculos lados y ángulo
            double y = (Math.Sin(a) * t);
            double z = Math.Sqrt(Math.Pow(t, 2) - Math.Pow(y, 2));
            double c = Math.Asin(z / t);

            //De radianes a grados
            double cG = c * (180.0 / Math.PI);
        
            //Salida
            Console.WriteLine("Los catetos son: " + y + " y " + z);
            Console.WriteLine("El otro ángulo es: " + cG + "°");

            Console.Read();
        }
    }
}
