/**
 * Write a function that accepts two ints a and b, and returns a/b. Must be implemented without using the division or modulo operators
 * ie: 7, 2 should return 3
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBE_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("\nEnter the numerator comma denominator\n\n>>> ");
                    string[] input = Console.ReadLine().Split(',');
                    Console.WriteLine($"\nResult: {Division(int.Parse(input[0].Trim()), int.Parse(input[1].Trim()))}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.Write("\nPress Enter to do another division...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static int Division(int numerator, int denominator)
        {
            int result = 0;
            if (denominator == 0)
            {
                // division by 0 is infinity because you can subtract 0 form any number infinit times.
                throw new Exception("\nDivision over zero. The result is infinity.");
            }
            else
            {
                // division by subtraction
                while (Math.Abs(numerator) >= Math.Abs(denominator))
                {
                    numerator -= denominator;
                    result++;
                }
            }
            // determines the sign of the result.
            // if both numbers are either positive or negative the result is positive. 
            // otherwise one of the numbers is negatie, which will yield a negative result.
            return (numerator <= 0 && denominator < 0 || numerator >= 0 && denominator > 0) ? result : 0 - result;
        }
    }
}
