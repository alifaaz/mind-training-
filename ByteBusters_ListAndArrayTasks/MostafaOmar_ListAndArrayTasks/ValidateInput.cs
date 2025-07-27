using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ListAndArrayTasks
{
    public class ValidateInput
    {
        // Check if the input is a valid number
        public static bool IsValidNumber(string input)
        {
            // first i check if its white spaces or null
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            else
            {
                // here i made a regex that check if its number
                Regex regex = new Regex(@"^-?\d+(\.\d+)?$");
                return regex.IsMatch(input);
            }
        }
    }
}
