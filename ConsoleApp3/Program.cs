using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //short a = 0;
            //a--;   
            //Console.WriteLine(a);
            //int a = 5;
            //int b = 4;
            //Console.WriteLine(a<=b);
            //bool isSick = false;
            //if (isSick)
            //{
            //    Console.WriteLine("U are sick!!!");
            //}
            //else
            //{
            //    Console.WriteLine("U are not sick , u SUCK!!!");
            //}
            Console.WriteLine("Enter Currency (UAN , USD , EUR):");
            string currentCurrency = Console.ReadLine();
            Console.WriteLine("Enter amount:");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter currency to convert:");
            string currency = Console.ReadLine();
            if(currentCurrency == "USD" && currency == "UAN")
            {
                Console.WriteLine("it's " + amount * 27.5 + " UAN");
            }




        }
    }
}
