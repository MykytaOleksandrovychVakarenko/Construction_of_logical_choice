using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_of_logical_choice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If...else statement
            bool isInfected = true;

            if (isInfected)
            {
                Console.WriteLine("You are infected.");
            }
            else
            {
                Console.WriteLine("You are not infected.");
            }
            Console.ReadKey();

            /*Task | Checking a number for parity
             * Write a program that checks whether 
             * a number entered from the keyboard is even.
             * 
             */
            Console.Write("Enter the number:");
            int number = int.Parse(Console.ReadLine());
            if (number %2 == 0) 
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            Console.ReadKey();
        }
    }
}
