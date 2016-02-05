using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeApp
{
    class Primes
    {  
        static bool IsPrime(string s)
        {  
            int x = int.Parse(s);  //converting from STRING to INT
            int count = 0; //Adding a variable "cnt" to count the number of dividers
            for (int j = 2; j <= Math.Sqrt(x); j++) // counting the number of dividers
            {
                if (x % j == 0)
                {
                    count++;
                }
            }
            return count == 0 && x != 1; //returns the value TRUE or FALSE
        }
        static void Main()
        {  
            string y = Console.ReadLine(); //variable for reading lines from the console
            string[] args = y.Split(' '); //we must split the whole line into an array using ".SPLIT"
            for (int i = 0; i < args.Length; i++) //checking the elements of array using function
            {
                if (!IsPrime(args[i]))
                {
                    Console.WriteLine(args[i] + " -NOT PRIME");
                }
                else
                {
                    Console.WriteLine(args[i] + " - PRIME");
                }
            }

        }
    }
}