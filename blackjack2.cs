using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese el número de jugadores (mínimo 2, máximo 5): ");
            int jugadores = int.Parse(Console.ReadLine());
            while (jugadores < 2 || jugadores > 5) {
                Console.Write("Error. Mínimo 2 jugadores, máximo 5: ");
                jugadores = int.Parse(Console.ReadLine());
            }
            Random aleatorio = new Random();
            int turno = 1;
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0;
            while (turno <= jugadores) {
                Console.WriteLine("Bienvenido, jugador " + turno);
                int carta = aleatorio.Next(1, 11), segunda = aleatorio.Next(1, 11), total = carta + segunda;
                Console.WriteLine("Sus cartas son: " + carta + " y " + segunda);
                Console.WriteLine("Total: " + total);
                Console.WriteLine("Desea continuar? (s/n): ");
                string respuesta = Console.ReadLine();
                while (respuesta != "s" && respuesta != "n") {
                    Console.WriteLine("Respuesta no válida. ¿Desea continuar? (s/n): ");
                    respuesta = Console.ReadLine();
                }
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
                        total = 0;
                        respuesta = "n";
                    }
                }
                if (turno == 1) c1 = total;
                else if (turno == 2) c2 = total;
                else if (turno == 3) c3 = total;
                else if (turno == 4) c4 = total;
                else if (turno == 5) c5 = total;
                turno += 1;
            }
            Console.WriteLine("Jugador 1: " + c1 + " puntos.");
            Console.WriteLine("Jugador 2: " + c2 + " puntos.");
            if (jugadores > 2){
                Console.WriteLine("Jugador 3: " + c3 + " puntos.");
                if (jugadores > 3) {
                    Console.WriteLine("Jugador 4: " + c4 + " puntos.");
                    if (jugadores > 4) Console.WriteLine("Jugador 5: " + c5 + " puntos.");
                }
            }
            if (c1 > c2 && c1 > c3 && c1 > c4 && c1 > c5) Console.WriteLine("El Jugador 1 es el ganador.");
            else if (c2 > c1 && c2 > c3 && c2 > c4 && c2 > c5) Console.WriteLine("El Jugador 2 es el ganador.");
            else if (c3 > c2 && c3 > c1 && c3 > c4 && c3 > c5) Console.WriteLine("El Jugador 3 es el ganador.");
            else if (c4 > c2 && c4 > c1 && c4 > c1 && c4 > c5) Console.WriteLine("El Jugador 4 es el ganador.");
            else if (c5 > c2 && c5 > c1 && c5 > c4 && c5 > c1) Console.WriteLine("El Jugador 5 es el ganador.");
            Console.WriteLine("Gracias por participar");
            Console.Read();
        }
    }
}
