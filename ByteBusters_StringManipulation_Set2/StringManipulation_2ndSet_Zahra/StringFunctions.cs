using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringManipulation_2ndSet_Zahra
{
    static class StringFunctions
    {
        public static int CountCharacters(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            return string1.Length;
        }

        public static string ToUpper(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            return string1.ToUpper();
        }

        public static string ToLower(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            return string1.ToLower();
        }

        public static bool StartsWithPrefix(string string1, string prefix)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            if (prefix == null)
                throw new ArgumentNullException(nameof(prefix));
            return string1.StartsWith(prefix);
        }

        public static bool EndsWithSuffix(string string1, string suffix)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            if (suffix == null)
                throw new ArgumentNullException(nameof(suffix));
            return string1.EndsWith(suffix);
        }

        public static bool ContainsOnlyDigits(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            foreach (char c in string1)
                if (!char.IsDigit(c))
                    return false;
            return true;
        }

        public static bool ContainsOnlyLetters(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            foreach (char c in string1)
                if (!char.IsLetter(c))
                    return false;
            return true;
        }

        public static string CapitalizeFirstCharacter(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            if (string1.Length == 0)
                throw new ArgumentException("Input string cannot be empty.", nameof(string1));
            return char.ToUpper(string1[0]) + string1.Substring(1);
        }

        public static string SwapCase(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            char[] swapped = new char[string1.Length];
            for (int i = 0; i < string1.Length; i++)
            {
                if (char.IsUpper(string1[i]))
                    swapped[i] = char.ToLower(string1[i]);
                else
                    swapped[i] = char.ToUpper(string1[i]);
            }
            return new string(swapped);
        }

        public static string[] SplitIntoWords(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            return string1.Split(' ');
        }

        public static string TrimWhitespace(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            return string1.Trim();
        }

        public static int CountSpaces(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            int count = 0;
            foreach (char c in string1)
            {
                if (c == ' ')
                    count++;
            }
            return count;
        }

        public static string GetFirstFiveCharacters(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            if (string1.Length < 5)
                return string1;
            return string1.Substring(0, 5);
        }

        public static string GetLastThreeCharacters(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            if (string1.Length < 3)
                return string1;
            return string1.Substring(string1.Length - 3);
        }

        public static string ReplaceCommasWithSemicolons(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            return string1.Replace(',', ';');
        }

        public static string JoinWords(string[] words)
        {
            if (words == null)
                throw new ArgumentNullException(nameof(words));
            return string.Join(" ", words);
        }

        public static bool AreAnagrams(string str1, string str2)
        {
            if (str1 == null)
                throw new ArgumentNullException(nameof(str1));
            if (str2 == null)
                throw new ArgumentNullException(nameof(str2));
            char[] arr1 = str1.ToLower().ToCharArray();
            char[] arr2 = str2.ToLower().ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            return new string(arr1) == new string(arr2);
        }

        public static bool IsEmailAddress(string email)
        {
            if (email == null)
                throw new ArgumentNullException(nameof(email));
            return Regex.IsMatch(email, ".*@.*\\..*");
        }

        public static char[] FindDigits(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            List<char> digits = new List<char>();
            foreach (char c in string1)
            {
                if (char.IsDigit(c))
                {
                    digits.Add(c);
                }
            }
            return digits.ToArray();
        }

        public static char[] FindLetter(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            List<char> Letters = new List<char>();
            foreach (char c in string1)
            {
                if (char.IsLetter(c))
                {
                    Letters.Add(c);
                }
            }
            return Letters.ToArray();
        }

        public static string MaskEmailAddress(string email)
        {
            if (email == null)
                throw new ArgumentNullException(nameof(email));
            if (Regex.IsMatch(email, ".*@.*\\..*"))
            {
                int AtIndex = email.IndexOf('@');
                if (AtIndex > 1)
                {
                    return email[0] + new string('*', AtIndex - 1) + email.Substring(AtIndex);
                }
                return email;
            }
            else
            {
                throw new ArgumentException("Invalid email Address!");
            }
        }

        public static List<int> ConvertToAsciiCodes(string word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));
            List<int> asciiCodes = new List<int>();
            foreach (char c in word)
            {
                asciiCodes.Add((int)c);
            }
            return asciiCodes;
        }

        public static string RemoveDuplicateWords(string sentence)
        {
            if (sentence == null)
                throw new ArgumentNullException(nameof(sentence));
            return string.Join(" ", sentence.Split(' ').Distinct());
        }

        public static string ExtractFileExtension(string filename)
        {
            if (filename == null)
                throw new ArgumentNullException(nameof(filename));
            int dotIndex = filename.LastIndexOf('.');
            if (dotIndex >= 0)
            {
                return filename.Substring(dotIndex + 1);
            }
            return "No extention found :(";
        }

        public static string ReplaceNewlinesWithSpaces(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            return string1.Replace("\n", " ");
        }

        public static string ConvertDateFormat(string date)
        {
            if (date == null)
                throw new ArgumentNullException(nameof(date));
            string[] parts = date.Split('-');
            if (parts.Length == 3)
            {
                return $"{parts[2]}/{parts[1]}/{parts[0]}";
            }
            else
            {
                throw new ArgumentException("مترهم try using 'YYYY-MM-DD'.");
            }
        }

        public static int CountCharacters(string string1, char character)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            int count = 0;
            foreach (char c in string1)
            {
                if (c == character)
                {
                    count++;
                }
            }
            return count;
        }

        public static bool ContainsSpecialCharacters(string str1)
        {
            if (str1 == null)
                throw new ArgumentNullException(nameof(str1));
            return str1.Any(c => !char.IsLetterOrDigit(c));
        }

        public static string ConvertSnakeToCamel(string snakeCase)
        {
            if (snakeCase == null)
                throw new ArgumentNullException(nameof(snakeCase));
            string[] parts = snakeCase.Split('_');
            for (int i = 1; i < parts.Length; i++)
            {
                if (parts[i].Length > 0)
                {
                    parts[i] = char.ToUpper(parts[i][0]) + parts[i].Substring(1);
                }
            }
            return string.Join("", parts);
        }

        public static string ConvertCamelToSnake(string camelCase)
        {
            if (camelCase == null)
                throw new ArgumentNullException(nameof(camelCase));
            for (int i = 1; i < camelCase.Length; i++)
            {
                if (char.IsUpper(camelCase[i]))
                {
                    camelCase = camelCase.Insert(i, "_").ToLower();
                    i++;
                }
            }
            return camelCase;
        }

        public static string ReplaceNumbersWithHash(string str1)
        {
            if (str1 == null)
                throw new ArgumentNullException(nameof(str1));
            return str1.Replace("0", "#")
                        .Replace("1", "#")
                        .Replace("2", "#")
                        .Replace("3", "#")
                        .Replace("4", "#")
                        .Replace("5", "#")
                        .Replace("6", "#")
                        .Replace("7", "#")
                        .Replace("8", "#")
                        .Replace("9", "#");
        }

        public static int HowManyCapitalized(string str1)
        {
            if (str1 == null)
                throw new ArgumentNullException(nameof(str1));
            int count = 0;
            string[] words = str1.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                if (word.Any(c => char.IsUpper(c)))
                {
                    count++;
                }
            }
            return count;
        }

        public static string RemoveVowels(string str1)
        {
            if (str1 == null)
                throw new ArgumentNullException(nameof(str1));
            StringBuilder result = new StringBuilder();
            foreach (char c in str1)
            {
                if (!"aeiouAEIOU".Contains(c))
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }

        public static bool ContainsOnlyWhitespace(string str1)
        {
            if (str1 == null)
                throw new ArgumentNullException(nameof(str1));
            return str1.All(char.IsWhiteSpace);
        }

        public static int ConvertBinaryToDecimal(string binaryString)
        {
            if (binaryString == null)
                throw new ArgumentNullException(nameof(binaryString));
            return Convert.ToInt32(binaryString, 2);
        }

        public static string CreatePattern(string str1)
        {
            if (str1 == null)
                throw new ArgumentNullException(nameof(str1));
            return string.Join("-", str1.ToCharArray());
        }

        public static string AddSpaceAfterComma(string str1)
        {
            if (str1 == null)
                throw new ArgumentNullException(nameof(str1));
            return str1.Replace(",", ", ");
        }

        public static string TrimToMax10Characters(string str1)
        {
            if (str1 == null)
                throw new ArgumentNullException(nameof(str1));
            if (str1.Length <= 10)
                return str1;
            return str1.Substring(0, 10);
        }

        public static string FormatPhoneNumber(string phoneNumber)
        {
            if (phoneNumber == null)
                throw new ArgumentNullException(nameof(phoneNumber));
            if (phoneNumber.StartsWith("+"))
            {
                return "00" + phoneNumber.Substring(1);
            }
            return phoneNumber;
        }

        public static List<string> IdentifyVerbs(string sentence)
        {
            if (sentence == null)
                throw new ArgumentNullException(nameof(sentence));
            string[] verbs = { "run", "jump", "swim", "walk", "play", "eat", "drink", "sleep" };
            List<string> foundVerbs = new List<string>();
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                if (verbs.Contains(word.ToLower()))
                {
                    foundVerbs.Add(word);
                }
            }
            return foundVerbs;
        }
    }
}
