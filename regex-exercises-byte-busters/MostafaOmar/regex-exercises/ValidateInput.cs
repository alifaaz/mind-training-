using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regex_exercises
{
    public class ValidateInput
    {
        public static void IsInputNullOrWhiteSpaces (string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new Exception("Error! The Input is empty or contains only spaces.");
         
        }
    }
}
