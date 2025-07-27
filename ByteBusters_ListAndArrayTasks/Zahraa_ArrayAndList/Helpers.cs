using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Zahraa_ArrayAndList
{
    internal class Helpers
    {
        public static void ValidateInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException(nameof(input));
        }
        public static void ValidateInput(int input)
        {
            if (input < 0)
                throw new ArgumentNullException(nameof(input));
        }
        public static void ValidateInput<T>(List<T> numbers)
        {
            if (numbers.Count < 0)
                throw new ArgumentNullException(nameof(numbers));
        }

        public static void ValidateInput(List<string> strings)
        {
            if (strings == null || strings.Count == 0)
                throw new ArgumentNullException(nameof(strings), "List cannot be null or empty.");
        }
        // write a function to print a list of numbers

        public static void PrintNumbers(List<int> numbers)
        {
            try
            {
                ValidateInput(numbers);
                Console.Write("[");
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write(numbers[i]);

                    if (i < numbers.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("]");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
        public static void PrintStrings(List<string> strings)
        {
            try
            {
                ValidateInput(strings);
                Console.Write("[");
                for (int i = 0; i < strings.Count; i++)
                {
                    Console.Write(strings[i]);

                    if (i < strings.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("]");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        // A method to check if the list is empty
        public static void IsEmpty(List<int> numbers)
        {
            if (numbers.Count == 0)
                throw new InvalidOperationException("The list is empty.");
        }

        public static void IsEmpty<T>(List<T> list)
        {
            if (list == null || list.Count == 0)
                throw new ArgumentNullException(nameof(list), "The list cannot be null or empty.");
        }
    }
}
