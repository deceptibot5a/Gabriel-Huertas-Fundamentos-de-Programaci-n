using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            double total = 0;
            int contador = 0;
            Console.WriteLine("Ingrese el número de usuarios: ");
            int usuarios = int.Parse(Console.ReadLine());
            int max = 0, min = 200;
            string nombreMayor = "", nombreMenor = "";


            while (contador < usuarios)
            {
                Console.WriteLine("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Nombre: ");
                string nombre = Console.ReadLine();
                if (edad > max)
                {
                    max = edad;
                    nombreMayor = nombre;
                }
                if (edad < min)
                {
                    min = edad;
                    nombreMenor = nombre;
                }
                total += edad;
                contador++;
            }

            double promedio = total / usuarios;
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("El mayor es " + nombreMayor + " de " + max + " años");
            Console.WriteLine("El menor es " + nombreMenor + " de " + min + " años");

            Console.Read();


        }
    }
}
