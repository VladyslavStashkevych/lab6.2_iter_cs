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
            int n, index = -1;

            Console.Write("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());

            a = new int[n];
            ArrayBuilder(a);
            Console.Write("\nArray:");
            PrintArray(a);

            index = MaxOddElement(a);
            if (index != -1)
                Console.WriteLine($"\nMax odd element: {a[index]}\n");
            else
                Console.WriteLine("\nThere is no odd element in array.\n");
        }
        static int[] ArrayBuilder(int []a) {
            var rand = new Random();
            for (int i = 0; i < a.Length; i++) {
                a[i] = rand.Next(-1000, 1000);
            }

            return a;
        }
        public static int MaxOddElement(int []a) {
            int index = -1,
                max = 0;
            for (int i = 0; i < a.Length; i++) {
                if (a[i] % 2 == 1) {
                    max = a[i];
                    index = i;
                    break;
                }
            }

            if (index != -1) {
                for (int i = 0; i < a.Length; i++) {
                    if (a[i] % 2 != 0 && a[i] > max) {
                        max = a[i];
                        index = i;
                    }
                }
            }

            return index;
        }
        static void PrintArray(int []a) {
            foreach (int el in a) {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
        }
    }
}
