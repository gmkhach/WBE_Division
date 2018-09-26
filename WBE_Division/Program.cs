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
                    Console.Write("\nEnter the numerator\n\n>>> ");
                    int numerator = int.Parse(Console.ReadLine().Trim());
                    Console.Write("\nEnter the denominator\n\n>>> ");
                    int denominator = int.Parse(Console.ReadLine().Trim());
                    Console.WriteLine($"\nResult: {Division(numerator, denominator)}");
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
                // stripping the ints from their signs to simplify the process.
                int a = Math.Abs(numerator);
                int b = Math.Abs(denominator);
                // division by subtraction
                while (a >= b)
                {
                    a -= b;
                    result++;
                }
            }
            // determines the sign of the result.
            if (numerator <= 0 && denominator < 0 || numerator >= 0 && denominator > 0)
            {
                return result;
            }
            else
            {
                return 0 - result;
            }
        }
    }
}
