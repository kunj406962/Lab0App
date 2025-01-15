using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
    /// <summary>
    /// Methods for getting and validating input data and relevant calculation
    /// </summary>
    internal static class Utilities
    {
        /// <summary>
        /// reads positive int
        /// </summary>
        /// <param name="prompt"> name used in error messages</param>
        /// <returns>int value read that is > 0</returns>
        public static int GetPositiveInt(string prompt)
        {
            bool gotIt = false;
            int result = 0;
            string input;

            while (!gotIt) 
            {
                Console.WriteLine($"Enter {prompt}:"); 
                input = Console.ReadLine() ?? ""; 

                if (Int32.TryParse(input, out result)) // result is assigned the parsed value
                {
                    if (result > 0)
                    {
                        gotIt = true;
                    }
                    else
                    {
                        Console.WriteLine($"Error: {prompt} must be positive");
                    }
                }
                else // could not parse - not a int
                {
                    Console.WriteLine($"Error: {prompt} must be a whole number");
                }
            }
            return result;
        }

        /// <summary>
        /// reads int in range
        /// </summary>
        /// <param name="prompt">name used in error messages</param>
        /// <param name="minValue">minimum value for the range</param>
        /// <param name="maxValue">maximum value for the range</param>
        /// <returns>int value read that is within range</returns>
        public static int GetIntInRange(string prompt, int minValue, int maxValue)
        {
            bool gotIt = false;
            int result = 0;
            string input;

            while (!gotIt)
            {
                Console.WriteLine($"Enter {prompt}:");
                input = Console.ReadLine() ?? "";

                if (Int32.TryParse(input, out result)) // result is assigned the parsed value
                {
                    if (result >= minValue && result <= maxValue)
                    {
                        gotIt = true;
                    }
                    else
                    {
                        if(minValue == Int32.MinValue)
                            Console.WriteLine($"Error: {prompt} must be less than or equal to {maxValue}");
                        else if(maxValue == Int32.MaxValue)
                            Console.WriteLine($"Error: {prompt} must be greater than or equal to {minValue}");
                        else
                            Console.WriteLine($"Error: {prompt} must be within range {minValue} - {maxValue}");
                    }
                }
                else // could not parse - not a int
                {
                    Console.WriteLine($"Error: {prompt} must be a whole number");
                }
            }
            return result;
        }

        public static bool PrimeNumber(int number) 
        {
            bool result=false;
            if (number == 2 || number==3)
            {
                result = true;
            }
            else if (number % 2 != 0 && number %3 != 0)
            {
                result = true;

            }
            
            return (result);
        }

    }//class
}// namespace
