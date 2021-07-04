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
            //Console.WriteLine("Enter first border: ");
            //int border1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter last border: ");
            //int border2 = Convert.ToInt32(Console.ReadLine());
            //if (border1 > border2)
            //{
            //    int tmp = border2;
            //    border2 = border1;
            //    border1 = tmp;
            //}

            //int countEven = 0;
            //int SumEven = 0;

            //int countOdd = 0;
            //int SumOdd = 0;
            //for (int i = border1; i <= border2; i++)
            //{
            //    if (border1 % 2 == 0)
            //    {
            //        countEven++;
            //        SumEven += border1;
            //    }
            //    else
            //    {
            //        countOdd++;
            //        SumOdd += border1;
            //    }
            //    border1++;
            //}

            //Console.WriteLine("Number of Even = " + countEven);
            //Console.WriteLine("Sum of Even = " + SumEven);
            //Console.WriteLine("Number of Odd = " + countOdd);
            //Console.WriteLine("Sum of Odd = " + SumOdd);
            //ulong i = ulong.Parse(Console.ReadLine());
            //for (; i > 0; i--)
            //{
            //    Console.WriteLine("i = " + i );
            //}
            //*
            //**
            //***
            //****
            //*****
            //****** width = 6 and height   = 6
            //break
            //Console.Write("Enter height:");
            //int height = int.Parse(Console.ReadLine());
            //int tmp3 = height;
            //for (int i = 0; i < height; i++)
            //{
            //    for (int j = --tmp3; j < height; j++)
            //    {
            //        Console.Write("#");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Write("Enter height:");
            //int height2 = int.Parse(Console.ReadLine());
            //int tmp = height2/*10*/ , tmp2 = height2/*10*/;
            //for (int i = 0; i < height2; i++)
            //{
            //    tmp--;
            //    for (int j = 0; j < tmp; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int m = --tmp2; m < height2; m++)
            //    {
            //        Console.Write("#");
            //    }
            //    Console.WriteLine();
            //}
            //
            //           *
            //          **
            //         ***
            //        ****
            //       *****
            //      ****** 
            //     *******
            //    ********
            //   *********
            //  **********
            // ***********
            //************
            //HEIGHT 12

            //int acces;
            //string truePassword = "some";
            //string pass = Console.ReadLine();

            //acces = truePassword == pass ? 10 : 15;

            //Console.WriteLine(acces);
            //Arrays

            //int[] array = Enumerable.Range(5, 10).ToArray();
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            Console.Write("Enter number of elems in array:");
            double[] array = new double[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter "+ (i+1) + " elem:");
                array[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Elem " + (i+1) + " = " + array[i] + "\t");
                if((i+1) % 5 == 0 && i != 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = array.Length-1; i >= 0 ; i--)
            {
                Console.Write("Elem " + (i + 1) + " = " + array[i] + "\t");
                if ((i + 1) % 5 == 0 && i != 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            double SumOfArray = 0;
            for (int i = 0; i < array.Length; i++)
            {
                SumOfArray += array[i];
            }
            Console.WriteLine("Sum of array = " + SumOfArray);

            double min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                min = min > array[i] ? array[i] : min;
            }
            Console.WriteLine("Min of array = " + min);
        }
    }
}
