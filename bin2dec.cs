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
            Console.WriteLine("Ingrese el primer digito: ");
            double b0 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo digito: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer digito: ");
            double b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto digito: ");
            double b3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el ultimo digito: ");
            double b4 = double.Parse(Console.ReadLine());
            double r0 = b0 * Math.Pow(2, 4);
            double r1 = b1 * Math.Pow(2, 3);
            double r2 = b2 * Math.Pow(2, 2);
            double r3 = b3 * Math.Pow(2, 1);
            double r4 = b4 * Math.Pow(2, 0);
            double resultado = r0 + r1 + r2 + r3 + r4;
            Console.WriteLine("El numero en decimal es " + resultado);
            Console.ReadLine();


        }
    }
}
