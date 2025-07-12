using System.Text.RegularExpressions;
using Zahraa_RegEx;

namespace StringManipulation_2ndSet_Zahra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                string UserInput = helpers.GetUserInput("string");
                Console.WriteLine(Regex_functions.ExtractArabicNumerals(UserInput));
 
            }
            

        }
    }
}