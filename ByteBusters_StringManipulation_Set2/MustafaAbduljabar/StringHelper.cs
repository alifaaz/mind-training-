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
        public static string ExtractPhoneNumber(string str)
        {
            // Extracts phone numbers from the string.
            str = SafteyCheckUsingLoop(str);
            string NewString = string.Empty;
            try
            {
                str = TrimEndAndStart(str); // Trim leading and trailing whitespace
                foreach (char c in str)
                {
                    if (char.IsDigit(c) || c == '+')
                    {
                        NewString += c;
                    }
                }
                return NewString;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;
            }
        }
        public static string TrimStringToMaximumOf10Chars(string str)
        {
            // Trims the string to a maximum of 10 characters.
            str = SafteyCheckUsingLoop(str);
            string NewString = string.Empty;
            try
            {
                str = str.Replace(' ', '_'); // Replace spaces with underscores
                if (str.Length < 10)
                {
                    return str; // If the string is less than 10 characters, return it as is
                }
                else
                {
                    for (int i = 0; i < str.Length; i += 10)
                    {
                        if (i + 10 <= str.Length)
                        {
                            NewString += str.Substring(i, 10) + ","; // Take 10 characters at a time and add a comma
                        }
                        else
                        {
                            NewString += str.Substring(i); // Take the remaining characters if less than 10
                        }
                    }
                    return NewString.Trim(); // Return the trimmed string
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;
            }
        }
        public static string AddSpaceAfterEveryComma(string str)
        {
            // Adds a space after every comma in the string.
            str = SafteyCheckUsingLoop(str);
            try
            {
                str = TrimEndAndStart(str); // Trim leading and trailing whitespace
                return str.Replace(",", ", "); // Replace commas with commas followed by a space
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;
            }
        }
        public static string ConvertDecimalToBinary(string decimalString)
        {
            // Converts a decimal string to its binary equivalent.
            decimalString = SafteyCheckUsingLoop(decimalString);
            try
            {
                int number = Convert.ToInt32(decimalString); // Convert string to integer
                return Convert.ToString(number, 2); // Convert integer to binary string
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid decimal format. Please enter a valid decimal number.");
                return string.Empty;
            }
        }
        public static string ConvertBinaryToDecimal(string binaryString)
        {
            // Converts a binary string to its decimal equivalent.
            binaryString = SafteyCheckUsingLoop(binaryString);
            try
            {
                return Convert.ToInt32(binaryString, 2).ToString(); // Convert binary to decimal
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid binary format. Please enter a valid binary string.");
                return string.Empty;
            }
        }
        public static string ReplaceEmojisWithAsterisks(string str)
        {
            // Replaces all emojis in the string with asterisks.
            str = SafteyCheckUsingLoop(str);
            try
            {
                str = TrimEndAndStart(str); // Trim leading and trailing whitespace
                return Regex.Replace(str, @"[\p{So}]", "[Emoji]"); // Replace emojis with asterisks
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;
            }
        }
        public static bool CheckStringIfOnlyWhiteSpace(string str)
        {
            str = SafteyCheckUsingLoop(str);
            try
            {
                return str.All(char.IsWhiteSpace); // Check if the string contains only whitespace characters;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return false;
            }
        }
        public static string RemoveVowels(string str)
        {
            // Removes all vowels from the string.
            str = SafteyCheckUsingLoop(str);
            string NewString = string.Empty;
            try
            {
                str = TrimEndAndStart(str); // Trim leading and trailing whitespace
                str = FindAllLetters(str); // Extract only letters from the string
                foreach (char c in str)
                {
                    if (!"aeiouAEIOU".Contains(c)) // Check if the character is not a vowel
                    {
                        NewString += c; // Append non-vowel characters to the new string
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;
            }
            return NewString; // Return the modified string without vowels
        }
        public static int CountOfCapitalizedWords(string str)
        {
            // Counts the number of capitalized words in the string.
            str = SafteyCheckUsingLoop(str);
            int count = 0;
            try
            {
                str = TrimEndAndStart(str); // Trim leading and trailing whitespace
                string[] ArrayOfStrings = str.Split(' '); // Split the string into words
                for (int i = 0; i < ArrayOfStrings.Length; i++)
                {
                    ArrayOfStrings[i] = FindAllLetters(ArrayOfStrings[i]); // Extract only letters from each word
                }
                foreach (var item in ArrayOfStrings)
                {
                    if (item.Length > 0 && char.IsUpper(item[0])) // Check if the first character of the word is uppercase
                    {
                        count++; // Increment the count for each capitalized word
                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return 0;
            }
            return count; // Return the count of capitalized words
        }
        public static string ReplaceNumricsWithAsterisks(string str)
        {
            // Replaces all numeric characters in the string with Hashtag.
            str = SafteyCheckUsingLoop(str);
            try
            {
                str = TrimEndAndStart(str); // Trim leading and trailing whitespace
                foreach (char c in str)
                {
                    if (char.IsDigit(c)) // Check if the character is a digit
                    {
                        str = str.Replace(c, '#'); // Replace digit with an Hashtag
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;
            }
            return str; // Return the modified string
        }
        public static string CamalCaseToSnakeCase(string str)
        {
            // Converts a CamelCase string to snake_case.
            str = SafteyCheckUsingLoop(str);
            string snake_string = string.Empty;
            try
            {
                str = TrimEndAndStart(str); // Trim leading and trailing whitespace
                str = FindAllLetters(str); // Extract only letters from the string
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsUpper(str[i]) && i > 0) // Check if the character is uppercase and not the first character
                    {
                        snake_string += "_"; // Add an underscore before uppercase letters
                    }
                    snake_string += char.ToLower(str[i]); // Convert the character to lowercase and add it to the result
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;
            }
            return snake_string; // Return the resulting snake_case string
        }
        public static string SnakeCaseToCamalCase(string str)
        {
            str = SafteyCheckUsingLoop(str);
            string[] SplitStrings;
            try
            {
                str = TrimEndAndStart(str);
                if (str.IndexOf('_') == 0)
                {
                    str = str.Substring(1); // Remove leading underscore if present
                }
                foreach (var item in str)
                {
                    str = str.Replace('.', '_');
                    str = str.Replace(' ', '_'); // Replace spaces and dots with underscores
                }
                SplitStrings = str.Split('_'); // Split the string by underscores
                for (int i = 1; i < SplitStrings.Length; i++)
                {
                    if (SplitStrings[i].Length > 0) //check if the string is not empty and length is greater than 0
                    {
                        SplitStrings[i] = char.ToUpper(SplitStrings[i][0]) + SplitStrings[i].Substring(1).ToLower(); // Capitalize Only first letter
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;

            }
            return string.Join("", SplitStrings); // Join the strings without any separator


        }
        public static int CountOfChar(string str, char c)
        {
            // Counts the number of characters in the string.
            str = SafteyCheckUsingLoop(str);
            int count = 0;
            try
            {
                for (int i = 0; i < str.Length; i++) // Loop through each character in the string
                {
                    if (str[i] == c)
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
        public static bool IsContainSpecialChar(string str)
        {
            // Checks if the string contains any special characters.
            str = SafteyCheckUsingLoop(str);
            try
            {
                str = TrimEndAndStart(str); // Trim leading and trailing whitespace

                return str.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)); // Check for any character that is not a letter, digit, or whitespace
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return false;
            }
        }
        public static string ConvertDateFormat(string date)
        {
            // Converts a date string to a formatted string.
            date = SafteyCheckUsingLoop(date);
            try
            {
                date = TrimEndAndStart(date); // Trim leading and trailing whitespace
                return date = date.Replace("-", "/"); // Replace slashes with dashes

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date format. Please enter a valid date.");
                return string.Empty;
            }

        }
        public static string ReplaceNewLineWithSpace(string str)
        {
            // Replaces all new line characters in the string with spaces.
            str = SafteyCheckUsingLoop(str);
            try
            {
                return str.Replace('\n', ' '); // Replace new line characters with one space
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;
            }
        }
        public static string ExtractExtension(string str)
        {
            str = SafteyCheckUsingLoop(str);
            string extension = string.Empty;
            try
            {
                int LocationOfDot = str.LastIndexOf('.');
                if (LocationOfDot != -1 && LocationOfDot < str.Length - 1)
                {
                    extension = str.Substring(LocationOfDot + 1); // Extract the substring after the last dot
                }
                else
                {
                    extension = "No extension found"; // If no dot is found or it's at the end of the string
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;
            }
            return extension;

        }
        public static string removeDuplicate(string str)
        {
            str = SafteyCheckUsingLoop(str);
            str = TrimEndAndStart(str);
            string NewString = string.Empty;
            try
            {
                string[] _strings = str.Split(' ');
                foreach (var item in _strings)
                {
                    if (!NewString.Contains(item))
                    {
                        NewString += item + " ";
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;
            }
            return NewString;
        }
        public static string ConvertStringToAsciiArray(string str)
        {
            str = SafteyCheckUsingLoop(str);
            int[] Ascii = new int[str.Length];
            try
            {
                for (int i = 0; i < str.Length; i++)
                {
                    Ascii[i] = (int)str[i];
                }
            }
            catch (Exception)
            {

                throw;
            }
            return string.Join(",", Ascii);
        }
        public static string MaskEmail(string email)
        {
            // Masks the email address by replacing the characters before the "@" with asterisks.
            email = SafteyCheckUsingLoop(email);
            try
            {
                email = TrimEndAndStart(email); // Trim leading and trailing whitespace
                int atIndex = email.IndexOf('@');
                if (IsEmail(email))
                {
                    string UserEmail = email.Substring(0, 3); // Get the part before the "@"
                    string domain = email.Substring(atIndex); // Get the part after the "@"
                    string maskedEmail = UserEmail + "****" + domain; // Mask the user part with asterisks
                    return maskedEmail;
                }
                else
                {
                    return "not valid email"; // Return the original email if "@" is not found
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;
            }
        }
        public static string FindAllLetters(string str)
        {
            // Finds all Letter in the string and returns them as a new string.
            str = SafteyCheckUsingLoop(str);
            string NewString = string.Empty;
            try
            {
                foreach (char c in str)
                {
                    if (char.IsLetter(c))
                    {
                        NewString = NewString + c;
                    }
                }
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
            string NewString = string.Empty;
            try
            {
                foreach (char c in str)
                {
                    if (char.IsDigit(c))
                    {
                        NewString += c;
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return string.Empty;
            }
            return NewString;
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
