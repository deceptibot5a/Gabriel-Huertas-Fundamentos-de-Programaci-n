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
            Console.Write("Ingrese su salario mensual: ");
            double salario = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su tipo de contrato (1 = dependiente, 2 = independiente): ");
            int contrato = int.Parse(Console.ReadLine());

            double baseC = salario * 0.4;
            if (baseC < 877803)
            {
                 baseC = 877803;
            }

            if (contrato == 2)
            {
                
                Console.Write("Ingrese su nivel de riesgo (de 1 a 5): ");
                int riesgo = int.Parse(Console.ReadLine());
                double decEPS = baseC * 0.16;
                double decARL = baseC * 0.125;
                if (riesgo == 1)
                {
                    double decRIE = baseC * 0.0522;
                    double salarioR = salario - decEPS - decARL - decRIE;
                    double salarioA = (salarioR * 12);
                    Console.WriteLine("Su salario mensual real es: " + salarioR);
                    Console.WriteLine("Su salario anual es: $" + salarioA);
                }
                else if (riesgo == 2)
                {
                    double decRIE = baseC * 0.01044;
                    double salarioR = salario - decEPS - decARL - decRIE;
                    double salarioA = (salarioR * 12);
                    Console.WriteLine("Su salario mensual real es: " + salarioR);
                    Console.WriteLine("Su salario anual es: $" + salarioA);
                }
                else if (riesgo == 3)
                {
                    double decRIE = baseC * 0.02436;
                    double salarioR = salario - decEPS - decARL - decRIE;
                    double salarioA = (salarioR * 12);
                    Console.WriteLine("Su salario mensual real es: " + salarioR);
                    Console.WriteLine("Su salario anual es: $" + salarioA);
                }
                else if (riesgo == 4)
                {
                    double decRIE = baseC * 0.04350;
                    double salarioR = salario - decEPS - decARL - decRIE;
                    double salarioA = (salarioR * 12);
                    Console.WriteLine("Su salario mensual real es: " + salarioR);
                    Console.WriteLine("Su salario anual es: $" + salarioA);
                }
                else
                {
                    double decRIE = baseC * 0.06960;
                    double salarioR = salario - decEPS - decARL - decRIE;
                    double salarioA = (salarioR * 12);
                    Console.WriteLine("Su salario mensual real es: " + salarioR);
                    Console.WriteLine("Su salario anual es: $" + salarioA);
                }
                
            }
            else if (contrato == 1)
            {
                double decEPS = baseC * 0.04;
                double decARL = baseC * 0.04;
                double salarioR = salario - decEPS - decARL;
                double salarioA = (salarioR * 12) + salario;
                Console.WriteLine("Su salario mensual real es: " + salarioR);
                Console.WriteLine("Su salario anual es: $" + salarioA);

            }
            
            Console.Read();

        }
    }
}
