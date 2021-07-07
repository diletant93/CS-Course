using System;
using System.Linq;
namespace ConsoleApp4
{
    class Program
    {
        static void PrintString(char symbol, int times)
        {
            string str = "";
            for (int i = 0; i < times; i++)
            {
                str += symbol;
            }
            Console.WriteLine("Str = " + str);
        }
        static int IndexOf(int[] array , int number)
        {
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if(number == array[i])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        static void Main(string[] args)
        {
            PrintString(Convert.ToChar(Console.ReadLine()), int.Parse(Console.ReadLine()));
            int[] arr = { 1, 23, 412423, 43,123, -21312, 43, -54 };
            Console.WriteLine("Index = " + IndexOf(arr, 100));
        }
    }
}
