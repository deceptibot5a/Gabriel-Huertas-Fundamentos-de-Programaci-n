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

            }
            else if (2 <= usuario && usuario < 4)
            {
                Console.WriteLine("Usted debe pagar la tarifa B");

            }
            else
            {
                Console.WriteLine("Usted debe pagar la tarifa C");
            }
            


            Console.Read();
        }
    }
}
