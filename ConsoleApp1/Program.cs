using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 1, 2, 32, 3, 23, 3 };
            Console.WriteLine(array[^2]);
            int[] arr = array[int.Parse(Console.ReadLine())..];
            foreach (var item in arr)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            arr = array;
            foreach (var item in arr)
            {
                Console.Write(item + "\t");
            }
        }
    }
}
