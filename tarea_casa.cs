using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado = 0, total = dado, turno = 0;
            Console.WriteLine("Desea Empezar? (s/n): ");
            string respuesta = Console.ReadLine();
            int contador = 0;

            while (respuesta == "s" && total < 100)
            {
                int numero = 0;
                dado = aleatorio.Next(1, 13);
                total += dado;
                turno += 1;
                Console.WriteLine("Su dado es: " + dado);
                if (dado % 2 == 0) numero = 2;
                else numero = 1;
                if (dado == 12) contador = 1;
                if (dado != 12 && dado != 10) contador = 0;

                if (numero == 1 && turno > 3)
                {
                    Console.WriteLine("Has perdido");
                    respuesta = "n";
                }
                else
                {
                    if (total >= 100) Console.WriteLine("Has ganado!");
                    else
                    {
                        if (dado == 10 && contador == 1)
                        {
                            Console.WriteLine("Has ganado!");
                            respuesta = "n";
                        }
                        else
                        {
                            Console.WriteLine("Total: " + total);
                            Console.WriteLine("¿Desea continuar? (s/n): ");
                            respuesta = Console.ReadLine();
                        }
                    }
                }
            }
            Console.WriteLine("Su total fue: " + total + " puntos");
            Console.WriteLine("Gracias por participar");
            Console.Read();
        }
    }
}
