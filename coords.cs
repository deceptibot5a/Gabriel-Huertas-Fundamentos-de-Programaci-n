using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main()
        {
            double[] CoordsX = { 0, 2, 3, 7 };
            double[] CoordsY = { 0, 1, 5, 6 };
            Random aleatorio = new Random();
            double pruebas = 0, x1= 0, x2 = 0, y1 = 0, y2 = 0;
            Console.WriteLine("Posibles valores para x: 0, 2, 3 y 7");
            Console.WriteLine("Posibles valores para y: 0, 1, 5 y 6");
            Console.WriteLine("¿Cuantas pruebas desea hacer máximo?: ");
            double respuesta = double.Parse(Console.ReadLine());

            while (pruebas < respuesta)
            {
                x1 = CoordsX[aleatorio.Next(0, CoordsX.Length - 1)];
                x2 = CoordsX[aleatorio.Next(0, CoordsX.Length - 1)];
                y1 = CoordsY[aleatorio.Next(0, CoordsY.Length - 1)];
                y2 = CoordsY[aleatorio.Next(0, CoordsY.Length - 1)];
                double m1 = (y2 - y1) / (x2 - x1);

                double x1b = CoordsX[aleatorio.Next(0, CoordsX.Length - 1)];
                double x2b = CoordsX[aleatorio.Next(0, CoordsX.Length - 1)];
                double y1b = CoordsY[aleatorio.Next(0, CoordsY.Length - 1)];
                double y2b = CoordsY[aleatorio.Next(0, CoordsY.Length - 1)];
                double m2 = (y2b - y1b) / (x2b - x1b);

                Console.WriteLine("\nValores de prueba: ");
                Console.WriteLine("Primera pendiente: x1: " + x1 + " x2: " + x2 + " y1: " + y1 + " y2: " + y2);
                Console.WriteLine("Segunda pendiente: x1: " + x1b + " x2: " + x2b + " y1: " + y1b + " y2: " + y2b);

                pruebas++;
                Console.WriteLine("Pendiente 1: " + m1 + "\nPendiente 2: " + m2);
                if (m1 != m2)
                {
                    Console.WriteLine("No pertenecen a la misma línea");
                    respuesta = 0;
                }
            }

            double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));



            Console.Read();
        }
    }
}
