using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int carta = aleatorio.Next(1, 11), segunda = aleatorio.Next(1, 11), total = carta + segunda;
            Console.WriteLine("Sus cartas son: " + carta + " y " + segunda);
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Desea continuar? (s/n): ");
            string respuesta = Console.ReadLine();


            while (respuesta == "s" && total < 21)
            {
                carta = aleatorio.Next(1, 11);
                total += carta;
                if (total < 21)
                {
                    Console.WriteLine("Su carta fue: " + carta);
                    Console.WriteLine("Total: " + total);
                    Console.WriteLine("¿Desea continuar? (s/n): ");
                    respuesta = Console.ReadLine();
                }
                else if (total == 21)
                {
                    Console.WriteLine("Su carta fue: " + carta);
                    Console.WriteLine("Has ganado!");
                }
                else
                {
                    Console.WriteLine("Su carta fue: " + carta);
                    Console.WriteLine("Eliminado");
                }
                
            }
            Console.WriteLine("Su total fue: " + total + " puntos");
            Console.WriteLine("Gracias por participar");
            Console.Read();


        }
    }
}
