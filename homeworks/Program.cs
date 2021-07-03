using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch
            //Console.WriteLine("Enter num1: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter num2: ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Choose the operation: + - / * :");
            //string operation = Console.ReadLine();
            //if(b == 0 && operation == "/")
            //{
            //    Console.WriteLine("You can't divide by 0!");
            //}
            //else
            //{
            //    switch (operation)
            //    {
            //        case "+":
            //            Console.WriteLine("num1 + num2 = " + (a + b));
            //            break;
            //        case "-":
            //            Console.WriteLine("num1 - num2 = " + (a - b));
            //            break;
            //        case "*":
            //            Console.WriteLine("num1 * num2 = " + (a * b));
            //            break;
            //        case "/":
            //            Console.WriteLine("num1 / num2 = " + (a / b));
            //            break;
            //        default:
            //            Console.WriteLine("Error.");
            //            break;
            //    }
            //}
            //if
            //Console.WriteLine("Enter num1: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter num2: ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Choose the operation: + - / * :");
            //string operation = Console.ReadLine();
            //if (b == 0 && operation == "/")
            //{
            //    Console.WriteLine("You can't divide by 0!");
            //}
            //else
            //{
            //    if(operation == "+")
            //    {
            //        Console.WriteLine("num1 + num2 = " + (a + b));
            //    }
            //    if (operation == "-")
            //    {
            //        Console.WriteLine("num1 - num2 = " + (a - b));
            //    }
            //    if (operation == "*")
            //    {
            //        Console.WriteLine("num1 * num2 = " + (a * b));
            //    }
            //    if (operation == "/")
            //    {
            //        Console.WriteLine("num1 / num2 = " + (a / b));
            //    }

            //}


            //while number of even and odd in current borders
            Console.WriteLine("Enter first border: ");
            int border1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter last border: ");
            int border2 = Convert.ToInt32(Console.ReadLine());
            if (border1 > border2)
            {
                int tmp = border2;
                border2 = border1;
                border1 = tmp;
            }

            int countEven = 0;
            int SumEven = 0;

            int countOdd = 0;
            int SumOdd = 0;
            for (int i = border1; i <= border2; i++)
            {
                if (border1 % 2 == 0)
                {
                    countEven++;
                    SumEven += border1;
                }
                else
                {
                    countOdd++;
                    SumOdd += border1;
                }
                border1++;
            }
            
            Console.WriteLine("Number of Even = " + countEven);
            Console.WriteLine("Sum of Even = " + SumEven);
            Console.WriteLine("Number of Odd = " + countOdd);
            Console.WriteLine("Sum of Odd = " + SumOdd);
        }
    }
}
