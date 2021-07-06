using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int[] array = { 1, 2, 32, 3, 23, 3 };
            //Console.WriteLine(array[^2]);
            //int[] arr = array[^4..^1];
            //foreach (var item in arr)
            //{
            //    Console.Write(item + "\t");
            //}
            //Console.WriteLine();
            //arr = array;
            //foreach (var item in arr)
            //{
            //    Console.Write(item + "\t");
            //}
            //Index index = ^3;
            //Range range = 1..4;
            //string str = "Hello world!";
            //Console.WriteLine(str[^4..]);
            //int[] array = { 1, 2, 321,42142, 213, 21, 321, 312, 312, 4 };
            //foreach (var item in array[..5])
            //{
            //    Console.WriteLine($"item = {item}");
            //}
            int[,] array = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-100,100);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
