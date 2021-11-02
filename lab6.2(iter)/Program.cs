// Program.cs
// <Сташкевич Владислав>
// Лабораторна робота № 6.2
// Опрацювання одновимірних масивів ітераційними та рекурсивними способами
// Варіант 19

using System;

namespace ProgramNS {
    public class Program {
        static void Main(string[] args) {
            int []a;
            int n, max;
            
            Console.Write("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());

            a = new int[n];
            ArrayBuilder(a, n);
            Console.Write("\nArray:");
            PrintArray(a, n);

            max = MaxOddElement(a, n);
            if(max != 0)
                Console.WriteLine($"\nMax odd element: {max}\n");
            else
                Console.WriteLine("\nThere is no odd element in array.\n");
        }
        static int[] ArrayBuilder(int []a, int size) {
            var rand = new Random();
            for (int i = 0; i < size; i++) {
                a[i] = rand.Next(-1000, 1000);
            }

            return a;
        }
        public static int MaxOddElement(int []a, int size) {
            int max = 0;
            for (int i = 0; i < size; i++) {
                if (a[i] % 2 == 1) {
                    max = a[i];
                    break;
                }
            }

            if (max != 0) {
                for (int i = 0; i < size; i++) {
                    if (a[i] % 2 == 1 && a[i] > max) max = a[i];
                }
            }

            return max;
        }
        static void PrintArray(int []a, int n) {
            foreach (int el in a) {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
        }
    }
}
