using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUdemyPractice6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a number. Compute the factorial of the number and 
            //print it on the console. For example, if the user enters 5, 
            //the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            int number;
            int fact;
            Console.WriteLine("Enter a whole number:");
            number = int.Parse(Console.ReadLine()); //parse the number into an integer 
            fact = number; //assign the value of number to fact variable
            for (var i = number - 1; i >= 1; i--)  //start at original number -1 and decrement
            {
                fact = fact * i; //fact multiplied by fact-1 each time is reassigned to fact
            }
            Console.WriteLine("{0}! = {1}", number, fact);

        }
    }
}
