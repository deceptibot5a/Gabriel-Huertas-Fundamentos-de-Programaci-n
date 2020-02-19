using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado = 0, total = dado, turno = 0, uno = 0, seis = 0, vidas = 3, especial = 2;
            Console.WriteLine("Desea Empezar? (s/n): ");
            string respuesta = Console.ReadLine();

            while (respuesta == "s" && total < 100)
            {
                if (especial != 0)
                { 
                    Console.WriteLine("Cuentas con " + especial + " dados especiales");
                    Console.WriteLine("¿Desea utilizar uno? (s/n)");
                    string respuestaEspecial = Console.ReadLine();
                
                    if (respuestaEspecial == "s")
                    {
                        dado = aleatorio.Next(1, 13);
                        especial -= 1;
                        total += dado;
                        turno += 1;
                        Console.WriteLine("Su dado es: " + dado);
                    }
                    else
                    { 
                        dado = aleatorio.Next(1, 7);
                        total += dado;
                        turno += 1;
                        Console.WriteLine("Su dado es: " + dado);
                    }
                }
                else
                {
                    dado = aleatorio.Next(1, 7);
                    total += dado;
                    turno += 1;
                    Console.WriteLine("Su dado es: " + dado);
                }

                if (dado == 1) uno += 1;
                else if (dado == 6) seis += 1;
                else if (dado != 6) seis = 0;

                if (uno % 2 == 0 && uno != 0)
                {
                    vidas -= 1;
                    uno = 0;
                }
                else if (seis % 2 == 0 && seis != 0)
                {
                    vidas += 1;
                    seis = 0;
                }
                else if (vidas > 3) vidas = 3;

                Console.WriteLine("Vidas: " + vidas);

                if (vidas == 0)
                {
                    Console.WriteLine("Has perdido");
                    respuesta = "n";
                }
                else
                {
                    if (total >= 100) Console.WriteLine("Has ganado!");
                    else
                    {
                        Console.WriteLine("Total: " + total);
                        Console.WriteLine("¿Desea continuar? (s/n): ");
                        respuesta = Console.ReadLine();
                    }
                }
            }
            Console.WriteLine("Su total fue: " + total + " puntos");
            Console.WriteLine("Gracias por participar");
            Console.Read();
        }
    }
}
