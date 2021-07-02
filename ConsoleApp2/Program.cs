using System;
using System.Globalization;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string s = "laxaban";
             Console.WriteLine(s);
            ///////////////////////
            string data;

            data = Console.ReadLine();

            Console.WriteLine(data + "some");
            Console.WriteLine(data);
            //////////////////////
            */

            /*string str;
            Console.WriteLine("Write 1 num:");
            str = Console.ReadLine();
            int num1 = Convert.ToInt16(str);
            Console.WriteLine("Write 2 num:");
            str = Console.ReadLine();
            int num2 = Convert.ToInt16(str);
            Console.WriteLine("Sum = " + (num1 + num2));
            */
            //ctr + k , ctr + c
            //ctr + k , ctr + u
            //double b = convert.todouble(str);
            //console.writeline(b);
            NumberFormatInfo num = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ",",
            };
            string str = "12,2";
            double number = double.Parse(str,num);
            Console.WriteLine(number);

        }
    }
}
