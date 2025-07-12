using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahraa_RegEx
{
    public class helpers
    {
        public static void ValidateInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException(nameof(input));
        }
        public static string GetUserInput(string input)
        {
            Console.WriteLine("Please Enter the " + input + " you wish to process: ");
            return Console.ReadLine();
        }
    }
}
