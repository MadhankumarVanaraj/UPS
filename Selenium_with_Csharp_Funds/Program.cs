using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Selenium_with_Csharp_Funds
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("The value of a is "+ a);

            string associateName="Madhan Kumar Vanaraj";

            Console.WriteLine("The name of the Associate is " + associateName);
            Console.WriteLine($"The name of the associate is {associateName}");

            var age = 23;
            Console.WriteLine($"The age of the Assocaite is {age}");

            dynamic height = "5.3";
            Console.WriteLine($"The height of the Associate is {height}");

            height = "Hello";

            Console.WriteLine($"The height is {height}");
		}
    }
}