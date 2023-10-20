using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arrays = new int[6][];
            int j = 0;
            for (int i = 10; i <= 100000; i*=10)
            {
                arrays[j] = new int[i];
                ArrayTools.FillArray(ref arrays[j]);
                j++;
            }

            Stopwatch sw = new Stopwatch();
            bool restart = true;
            while (restart)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Search for a value in linear search Recursive");
                Console.WriteLine("2. Search for a value in linear search Itarative");
                Console.WriteLine("3. Search for a value in binary search Recursive");
                Console.WriteLine("4. Search for a value in binary search Itarative");
                Console.WriteLine("5. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n=================================\n");
                int val = 0;
                if (option != 5)
                {
                    Console.Write("Enter the value you want to search for:\t");
                    val = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n=================================");
                }
                int k = 0;
                int idx;
                switch (option)
                {
                    case 1:
                        for (int i = 10; i <= 100000; i *= 10)
                        {
                            sw.Start();
                            idx = ArrayTools.LinearSearchR(arrays[k], val, 0);
                            sw.Stop();
                            Console.WriteLine(idx == -1 ? "value not found" : "value found at index " + idx);
                            Console.WriteLine("Recursive linear search in {0} items took {1} ms", i,sw.Elapsed);
                            sw.Reset();
                            k++;
                        }
                        break;

                    case 2:
                        for (int i = 10; i <= 100000; i *= 10)
                        {
                            sw.Start();
                            idx = ArrayTools.LinearSearchI(arrays[k], val);
                            sw.Stop();
                            Console.WriteLine(idx == -1 ? "value not found" : "value found at index " + idx);
                            Console.WriteLine("Iterative linear search in {0} items took {1} ms", i, sw.Elapsed);
                            sw.Reset();
                            k++;
                        }
                        break;
                    case 3:
                        for (int i = 10; i <= 100000; i *= 10)
                        {
                            sw.Start();
                            idx = ArrayTools.BinarySearchR(arrays[k], val, 0, arrays[k].Length - 1);
                            sw.Stop();
                            Console.WriteLine(idx == -1 ? "value not found" : "value found at index " + idx);
                            Console.WriteLine("Recursive binary search in {0} items took {1} ms", i, sw.Elapsed);
                            sw.Reset();
                            k++;
                        }
                        break;
                    case 4:
                        for (int i = 10; i <= 100000; i *= 10)
                        {
                            sw.Start();
                            idx = ArrayTools.BinarySearchI(arrays[k], val);
                            sw.Stop();
                            Console.WriteLine(idx == -1 ? "value not found" : "value found at index " + idx);
                            Console.WriteLine("Iterative binary search in {0} items took {1} ms", i, sw.Elapsed);
                            sw.Reset();
                            k++;
                        }
                        break;
                    case 5:
                        restart = false;
                        break;

                }
                Console.WriteLine("\n=================================");
            }
        }
    }
}
