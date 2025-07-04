using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace strings
{
    public static class StringHelper
    {
        public static string ArrayOfString(string str)
        {
            // Converts a string to an array of strings, where each character is separated by a comma.
            str = SafteyCheckUsingLoop(str);
            string NewString = string.Empty;

            try
            {
                string[] _strings = str.Split(' ');
                NewString = string.Join(",", _strings);

            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;
            }
            return NewString;
        }

        public static string FindAllDigits(string str)
        {
            // Finds all digits in the string and returns them as a new string.
            str = SafteyCheckUsingLoop(str);
            StringBuilder sb = new StringBuilder(); 
            try
            {
                foreach (char c in str)
                {
                    if (char.IsDigit(c)) 
                    {
                        sb.Append(c);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;
            }
            return sb.ToString();
        }
        public static bool CheckIfTwoStringsAreAnagrams(string str1, string str2)
        {
            // Checks if two strings are anagrams of each other, contains same chars instead of locations
            str1 = SafteyCheckUsingLoop(str1);
            str2 = SafteyCheckUsingLoop(str2);
            try
            {
                if (str1.Length != str2.Length)
                    return false; // If lengths are not equal, they cannot be anagrams
                char[] charArray1 = str1.ToLower().ToCharArray(); // Convert to lowercase and to char array
                char[] charArray2 = str2.ToLower().ToCharArray(); // Convert to lowercase and to char array
                Array.Sort(charArray1); // Sort the char arrays here we sort according to char value
                Array.Sort(charArray2);
                return new string(charArray1) == new string(charArray2); //
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return false;
            }
        }
        public static string ReplaceCommasWithSemicolons(string str)
        {
            // Replaces all commas in the string with Semicolons.
            str = SafteyCheckUsingLoop(str);
            str = TrimEndAndStart(str); // Trim leading and trailing whitespace
            try
            {
                return str.Replace(',', ';');
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;
            }
        }
        public static string GetLast3Characters(string str)
        {
            // Returns the last 3 characters of the string.
            str = SafteyCheckUsingLoop(str);
            try
            {
                str = TrimEndAndStart(str); // Trim leading and trailing whitespace
                //check the length of the string
                if (str.Length < 3) // we dont put equality in condition because its start from 0 
                {
                    return str;
                }
                return str.Substring(str.Length - 3);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;
            }
        }
        public static string GetFirst5Characters(string str)
        {
            // Returns the first 5 characters of the string.
            str = SafteyCheckUsingLoop(str);
            try
            {
                str = TrimEndAndStart(str); // Trim leading and trailing whitespace
                //check the length of the string
                if (str.Length < 5)
                {
                    return str;
                }
                return str.Substring(0, 5);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;
            }
        }
        public static bool IsEmail(string str)
        {
            // Checks if the input string is a valid email address.
            str = SafteyCheckUsingLoop(str);
            try
            {
                string trimmedEmail = str.Trim();
                return Regex.IsMatch(trimmedEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return false;
            }
        }
        public static int CountWhiteSpaces(string str)
        {
            //Return No. of Spaces into strings
            int count = 0;
            str = SafteyCheckUsingLoop(str);
            try
            {
                foreach (var item in str)
                {
                    if (char.IsWhiteSpace(item))
                    {
                        count++;
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return 0;
            }
            return count;
        }
        public static string TrimEndAndStart(string str)
        {
            // Trims the leading and trailing whitespace from the string.
            str = SafteyCheckUsingLoop(str);
            try
            {
                return str.Trim();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;
            }
        }
        public static string CapitalizeFirstLetter(string input)
        {
            // Capitalizes the first letter of the string.
            input = SafteyCheckUsingLoop(input);
            try
            {
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                return textInfo.ToTitleCase(input.ToLowerInvariant());
                //return char.ToUpper(input[0]) + input.Substring(1);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;
            }
        }
        public static bool OnlyDigit(string input)
        {
            // Checks if the input string contains only digits.
            input = SafteyCheckUsingLoop(input);
            try
            {
                return input.All(char.IsDigit);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return false;
            }

        }
        public static bool OnlyLetters(string input)
        {
            // Checks if the input string contains only Letters.
            input = SafteyCheckUsingLoop(input);
            try
            {
                return input.All(char.IsLetter);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return false;
            }

        }
        public static bool CheckStartPrefex(string input, string prefex)
        {
            // Checks if the input string starts with the specified prefix.
            input = SafteyCheckUsingLoop(input);
            prefex = SafteyCheckUsingLoop(prefex);
            try
            {
                return input.StartsWith(prefex);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return false;
            }

        }
        public static bool CheckEndPrefex(string input, string prefex)
        {
            // Checks if the input string ends with the specified prefix.
            input = SafteyCheckUsingLoop(input);
            prefex = SafteyCheckUsingLoop(prefex);
            try
            {
                return input.EndsWith(prefex);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return false;
            }

        }

        public static string ToUpperCase(string input)
        {
            // Returns the input string in uppercase.
            input = SafteyCheckUsingLoop(input);
            try
            {
                input = input.ToUpperInvariant();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
            }
            return input;
        }
        public static string ToLowerCase(string input)
        {
            // Returns the input string in lowecase.
            input = SafteyCheckUsingLoop(input);
            try
            {
                input = input.ToLowerInvariant();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
            }
            return input;
        }
        public static int Length(string input)
        {
            // Returns the length of the string.
            int count = 0;
            input = SafteyCheckUsingLoop(input);
            try
            {
                count = input.Length;
            }
            catch (Exception)
            {

                Console.WriteLine("An error occurred while calculating the length of the string. Please try again.");
            }
            Console.WriteLine($"The length of the string is: {count}");
            return count;
        }
        private static string SafteyCheckUsingLoop(string input)
        {
            while (input == string.Empty)
            {
                Console.Write("Re Input string: ");
                input = Console.ReadLine();
            }

            return input;
        }


    }
}
