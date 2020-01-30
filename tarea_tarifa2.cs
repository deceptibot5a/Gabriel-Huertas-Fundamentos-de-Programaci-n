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
            Console.Write("Ingrese su salario: ");
            int salario = int.Parse(Console.ReadLine());

            int minimo = 877803;
            int usuario = salario / minimo;


            if (usuario < 2)
            {
                Console.WriteLine("Usted debe pagar la tarifa A");
                Console.WriteLine("Valor de cuota moderadora: $3400");

            }
            else if (2 <= usuario && usuario < 5)
            {
                Console.WriteLine("Usted debe pagar la tarifa B");
                Console.WriteLine("Valor de cuota moderadora: $13500");

            }
            else
            {
                Console.WriteLine("Usted debe pagar la tarifa C");
                Console.WriteLine("Valor de cuota moderadora: $35600");
            }
            


            Console.Read();
        }
    }
}
