using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main()
        {
            int[] A = { 0, 15, 12, 6, 3, 12, 18, 6, 9 };
            int[] B = { 0, 4, 18, 6, 16, 6, 10, 14, 2, 12, 8, 2 };
            int[] U = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            List<int> union = new List<int>();
            List<int> interseccion = new List<int>();
            List<int> complemento = new List<int>();

            for (int i = 0; i < A.Length; i++) {
                union.Add(A[i]);
            }
            for (int i = 0; i < B.Length; i++) {
                union.Add(B[i]);
            }
            union.Sort();
            for (int i = 0; i < union.Count - 1; i++) {
                if (union[i] == union[i + 1]) {
                    union.RemoveAt(i);
                    i = 0;
                }
            }
            Console.WriteLine("Union: ");
            for (int i = 0; i < union.Count; i++) {
                Console.Write(union[i] + ", ");
            }

            for (int i = 0; i < A.Length; i++) {
                for (int j = 0; j < B.Length; j++) {
                    if (A[i] == B[j]) interseccion.Add(A[i]); 
                }
            }
            interseccion.Sort();
            for (int i = 0; i < interseccion.Count - 1; i++) {
                if (interseccion[i] == interseccion[i + 1]) {
                    interseccion.RemoveAt(i);
                    i = 0;
                }
            }
            Console.WriteLine("\n\nIntersección: ");
            for (int i = 0; i < interseccion.Count; i++) {
                Console.Write(interseccion[i] + ", ");
            }

            for (int i = 0; i < U.Length; i++) {
                complemento.Add(U[i]);
            }
            for (int i = 0; i < complemento.Count; i++) {
                for (int j = 0; j < union.Count; j++) {
                    if (complemento[i] == union[j]) {
                        complemento.RemoveAt(i);
                        i = 0;
                    }
                }
            }
            Console.WriteLine("\n\nComplemento: ");
            for (int i = 0; i < complemento.Count; i++)
            {
                Console.Write(complemento[i] + ", ");
            }

            Console.Read();
        }
    }
}
