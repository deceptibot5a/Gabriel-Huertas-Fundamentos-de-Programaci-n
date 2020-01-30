using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su peso en kilogramos: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su estatura en metros: ");
            double estatura = double.Parse(Console.ReadLine());

            double imc = peso / (Math.Pow(estatura, 2));


            if (imc < 18.5)
            {
                Console.WriteLine("Usted está bajo de peso");
                Console.Write("Su indice de masa corporal es: " + imc);
            }
            else if (18.6 <= imc && imc <= 25)
            {
                Console.WriteLine("Usted tiene peso normal");
                Console.Write("Su indice de masa corporal es: " + imc);
            }
            else if (25 < imc && imc <= 35)
            {
                Console.WriteLine("Usted tiene sobrepeso");
                Console.Write("Su indice de masa corporal es: " + imc);
            }
            else
            {
                Console.WriteLine("Usted tiene obesidad");
                Console.Write("Su indice de masa corporal es: " + imc);
            }


            Console.Read();
        }
    }
}
