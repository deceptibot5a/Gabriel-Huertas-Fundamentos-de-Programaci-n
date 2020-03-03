using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
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
            int puntajeMayor = 0, puntajeDos = 0, total = 0, ganador = 0;
            int distancia = 0, distanciaMenor = 50, segundo = 0;
            while (turno <= jugadores) {
                Console.WriteLine("Bienvenido, jugador " + turno);
                int carta = aleatorio.Next(1, 11), segunda = aleatorio.Next(1, 11);
                total = carta + segunda;
                Console.WriteLine("Sus cartas son: " + carta + " y " + segunda);
                Console.WriteLine("Total: " + total);
                Console.WriteLine("Desea continuar? (s/n): ");
                string respuesta = Console.ReadLine();
                while (respuesta != "s" && respuesta != "n") {
                    Console.WriteLine("Respuesta no válida. ¿Desea continuar? (s/n): ");
                    respuesta = Console.ReadLine();
                }
                while (respuesta == "s" && total < 21) {
                    carta = aleatorio.Next(1, 11);
                    total += carta;
                    if (total < 21) {
                        Console.WriteLine("Su carta fue: " + carta);
                        Console.WriteLine("Total: " + total);
                        Console.WriteLine("¿Desea continuar? (s/n): ");
                        respuesta = Console.ReadLine();
                    }
                    else if (total == 21) {
                        Console.WriteLine("Su carta fue: " + carta);
                        Console.WriteLine("Has ganado!");
                    }
                    else {
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
            int[] puntaje = { c1, c2, c3, c4, c5 };
            for (int i = 0; i < puntaje.Length; i++) {
                if (puntaje[i] > puntajeMayor) {
                    puntajeMayor = puntaje[i];
                    ganador = i + 1;
                }
                distancia = Math.Abs(puntaje[i] - puntajeMayor);
                if (distancia < distanciaMenor) {
                    distanciaMenor = distancia;
                    puntajeDos = puntaje[i];
                    segundo = i + 1;
                }
            }

            Console.WriteLine("El ganador es el jugador " + ganador + " con " + puntajeMayor + " puntos.");
            Console.WriteLine("En segundo lugar, el jugador " + segundo + " con " + puntajeDos + " puntos.");
            Console.WriteLine("Gracias por participar");
            Console.Read();
        }
    }
}
