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
        /*Count the number of characters in a string.*/
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
        /*Check if a string starts with a given prefix.*/
        public static bool StartsWithPrefix(string string1, string prefix)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            if (prefix == null)
                throw new ArgumentNullException(nameof(prefix));
            return string1.StartsWith(prefix);
        }
        //Check if a string ends with a given suffix.
        public static bool EndsWithSuffix(string string1, string suffix)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            if (suffix == null)
                throw new ArgumentNullException(nameof(suffix));
            return string1.EndsWith(suffix);
        }
        //Check if a string contains only digits
        public static bool ContainsOnlyDigits(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            foreach (char c in string1)
                if (!char.IsDigit(c))
                    return false;
            return true;
        }
        //Check if a string contains only letters
        public static bool ContainsOnlyLetters(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            foreach (char c in string1)
                if (!char.IsLetter(c))
                    return false;
            return true;
        }
        //Capitalize the first character of a string
        public static string CapitalizeFirstCharacter(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            if (string1.Length == 0)
                throw new ArgumentException("Input string cannot be empty.", nameof(string1));
            return char.ToUpper(string1[0]) + string1.Substring(1);
        }
        //Swap the case of each character in a string
        public static string SwapCase(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            // we create a new char array to hold the swapped characters
            char[] swapped = new char[string1.Length];

            // if upper turn to lower and vice versa
            for (int i = 0; i < string1.Length; i++)
            {
                if (char.IsUpper(string1[i]))
                    swapped[i] = char.ToLower(string1[i]);
                else
                    swapped[i] = char.ToUpper(string1[i]);
            }
            // here we return the new string with the swapped cases
            return new string(swapped);
        }

        // Split a string into words  Input: 'hello world' -> Output: ['hello', 'world']
        public static string[] SplitIntoWords(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            return string1.Split(' ');
        }

        // Remove leading and trailing whitespace from a string
        public static string TrimWhitespace(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            return string1.Trim();
        }

        // Count the number of spaces in a string
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

        // Get the first 5 characters of a string
        public static string GetFirstFiveCharacters(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            if (string1.Length < 5)
                // if it's less than 5 characters Return it
                return string1;
            // else return the first 5 chars
            return string1.Substring(0, 5);
        }

        // Get the last 3 characters of a string
        public static string GetLastThreeCharacters(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            if (string1.Length < 3)
                // if it's less than 3 characters return it
                return string1;
            // else return the last 3 chars
            return string1.Substring(string1.Length - 3);
        }

        // Replace commas with semicolons in a string
        public static string ReplaceCommasWithSemicolons(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            return string1.Replace(',', ';');
        }

        /*
        English: Join a list of words into a string.
        Example (English): Input: ['hello', 'world'] -> Output: 'hello world'
        */
        public static string JoinWords(string[] words)
        {
            if (words == null)
                throw new ArgumentNullException(nameof(words));
            return string.Join(" ", words);
        }

        /*English: Check if two strings are anagrams.
        Example (English): Input: 'listen', 'silent' -> Output: True 
        اولا اساوي اخليهم نفس الكيس بعدين ارتبهم و اشوف اذا متساوين يعني نفس الحروف بالطرفين
         */
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

        /*English: Check if a string is an email address format.
        Example (English): Input: 'user@example.com' -> Output: True
        */
        public static bool IsEmailAddress(string email)
        {
            if (email == null)
                throw new ArgumentNullException(nameof(email));
            return Regex.IsMatch(email, ".*@.*\\..*");
            // Regex means regular expression,
            // .* = any char any no. times,
            // @ = at least one @ symbol
            // \\ = escape character . = at least one dot
        }

        /*English: Find all the digits in a string.
        Example (English): Input: 'a1b2c3' -> Output: ['1', '2', '3'] */
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
        /*English: Find all the letters in a string.
        Example (English): Input: 'abc123' -> Output: ['a', 'b', 'c'] */
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
        /*English: Mask an email address (e.g., a***@domain.com).
        Example (English): Input: 'john.doe@example.com' -> Output: 'j***@example.com' */
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
                return email; // If the email is too short return it
            }
            else
            {
                throw new ArgumentException("Invalid email Address!");
            }

        }

        /*English: Convert a sentence into a list of ASCII codes.
        Example (English): Input: 'Hi' -> Output: [72, 105] */
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

        /*English: Remove duplicate words from a sentence.
        Example (English): Input: 'hello hello world' -> Output: 'hello world'*/
        public static string RemoveDuplicateWords(string sentence)
        {
            if (sentence == null)
                throw new ArgumentNullException(nameof(sentence));
            return string.Join(" ", sentence.Split(' ').Distinct());
            // string1.Split(' ')	يقسم الجملة إلى كلمات حسب الفراغات
            //.Distinct() يحذف الكلمات المكررة
            //string.Join(" ", )   يرجع الكلمات الفريدة كجملة واحدة مفصولة بمسافات
        }

        /*English: Extract the file extension from a filename.
        Example (English): Input: 'report.pdf' -> Output: 'pdf'*/
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

        /*English: Replace newlines with spaces in a string.
        Example (English): Input: 'hello\nworld' -> Output: 'hello world'*/
        public static string ReplaceNewlinesWithSpaces(string string1)
        {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            return string1.Replace("\n", " ");
        }

        /*English: Convert a string date from 'YYYY-MM-DD' to 'DD/MM/YYYY'.
        Example (English): Input: '2024-01-01' -> Output: '01/01/2024' */
        public static string ConvertDateFormat(string date)
        {
            if (date == null)
                throw new ArgumentNullException(nameof(date));
            // the simpilest way to do this is to split the string by '-'
            string[] parts = date.Split('-');
            if (parts.Length == 3)
            {
                // the new format
                return $"{parts[2]}/{parts[1]}/{parts[0]}";
            }
            else
            {
                throw new ArgumentException("مترهم try using 'YYYY-MM-DD'.");
            }
        }

        /*English: Find how many times a specific character appears in a string.
        Example (English): Input: 'banana', Char: 'a' -> Output: 3 */
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

        /*English: Check if a string contains any special characters.
        Example (English): Input: 'hello@!' -> Output: True */
        public static bool ContainsSpecialCharacters(string str1)
        {
            if (str1 == null)
                throw new ArgumentNullException(nameof(str1));
            return str1.Any(c => !char.IsLetterOrDigit(c));
        }

        /*English: Convert snake_case to camelCase.
        Example (English): Input: 'my_name' -> Output: 'myName'*/
        public static string ConvertSnakeToCamel(string snakeCase)
        {
            if (snakeCase == null)
                throw new ArgumentNullException(nameof(snakeCase));
            // اولشي نفرقهم
            string[] parts = snakeCase.Split('_');
            // بعدين نفتر عليهن و نشوف اول حرف من كل كلمة نكبره و طبعا نبدي من ثاني كلمة
            for (int i = 1; i < parts.Length; i++)
            {
                if (parts[i].Length > 0)
                {
                    parts[i] = char.ToUpper(parts[i][0]) + parts[i].Substring(1);
                }
            }
            // بعدين نرجع نجمعهم و نرجع النتيجة
            return string.Join("", parts);
        }

        /*Exercise 30  :
        English: Convert camelCase to snake_case.
        Example (English): Input: 'myName' -> Output: 'my_name' */
        public static string ConvertCamelToSnake(string camelCase)
        {
            if (camelCase == null)
                throw new ArgumentNullException(nameof(camelCase));
            for(int i = 1; i < camelCase.Length; i++)
            {
                // if the char is upper case we add an underscore before it
                if (char.IsUpper(camelCase[i]))
                {
                    // we add an underscore before the upper case letter and make it lower case
                    camelCase = camelCase.Insert(i, "_").ToLower();
                    // زيدلي العداد واحد حتى نطفر ال underscore اللي ضفناه
                    i++; 
                }
            }
            // بعدين نرجع النتيجة
            return camelCase;
        }

        //Replace all numeric values in a string with #.
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

        // Count how many words are capitalized.Input: 'HeLLo World' -> Output: 2

        public static int HowManyCapitalized(string str1)
        {
            if (str1 == null)
                throw new ArgumentNullException(nameof(str1));
            int count = 0;
            // Split the string into words using space
            string[] words = str1.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            // Iterate through each word
            foreach (string word in words)
            {
                // Check if the word contains any uppercase letters
                if (word.Any(c => char.IsUpper(c)))
                {
                    count++;
                }
            }
            // Return the count of capitalized words
            return count;
        }

        /*Remove all vowels from a string.
        Example (English): Input: 'education' -> Output: 'dctn' */
        public static string RemoveVowels(string str1)
        {
            if (str1 == null)
                throw new ArgumentNullException(nameof(str1));
            StringBuilder result = new StringBuilder();
            // we iterate through each character in the string
            foreach (char c in str1)
            {
                // if the character is not a vowel, we append it to the result
                if (!"aeiouAEIOU".Contains(c))
                {
                    result.Append(c);
                }
            }
            // return the new string without vowels
            return result.ToString();
        }

        // Check if a string contains only whitespace.
        public static bool ContainsOnlyWhitespace(string str1)
        {
            if (str1 == null)
                throw new ArgumentNullException(nameof(str1));
            return str1.All(char.IsWhiteSpace);
        }

        //Convert binary string to decimal.
        // we use Convert.ToInt32 to convert the binary string to decimal, 2 for binary
        public static int ConvertBinaryToDecimal(string binaryString)
        {
            if (binaryString == null)
                throw new ArgumentNullException(nameof(binaryString));
            return Convert.ToInt32(binaryString, 2);
        }

        //Create a string pattern like 'A-B-C'.
        // Example(English) : Input: 'abc' -> Output: 'a-b-c'
        public static string CreatePattern(string str1)
        {
            if (str1 == null)
                throw new ArgumentNullException(nameof(str1));
            return string.Join("-", str1.ToCharArray());
        }

        /* Add a space after every comma.
        Example (English): Input: 'a,b,c' -> Output: 'a, b, c' */
        public static string AddSpaceAfterComma(string str1)
        {
            if (str1 == null)
                throw new ArgumentNullException(nameof(str1));
            return str1.Replace(",", ", ");
        }

        /*Trim a string to a maximum of 10 characters.
        Example (English): Input: 'abcdefghijk' -> Output: 'abcdefghij'*/
        public static string TrimToMax10Characters(string str1)
        {
            if (str1 == null)
                throw new ArgumentNullException(nameof(str1));
            if (str1.Length <= 10)
                return str1;
            return str1.Substring(0, 10);
        }

        /*Format phone number to international style.
        Example (English): Input: '+9647912345678' -> Output: '009647912345678' */
        public static string FormatPhoneNumber(string phoneNumber)
        {
            if (phoneNumber == null)
                throw new ArgumentNullException(nameof(phoneNumber));
            // Check if the phone number starts with +964
            if (phoneNumber.StartsWith("+"))
            {
                // Replace +964 with 00964
                return "00" + phoneNumber.Substring(1);
            }
            // If it doesn't start with +964, return it as is
            return phoneNumber;
        }

        /*Parse a sentence and identify verbs.
        Example (English): Input: 'I run and jump' -> Verbs: ['run', 'jump'] */
        public static List<string> IdentifyVerbs(string sentence)
        {
            if (sentence == null)
                throw new ArgumentNullException(nameof(sentence));
            // طبعاغلط احله هيج المفروض استخدم مكتبة خاصة غالبا ضمن ال NLP بس هذا الموجود حاليا
            string[] verbs = { "run", "jump", "swim", "walk", "play", "eat", "drink", "sleep" };
            List<string> foundVerbs = new List<string>();
            // Split the sentence into words
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            // Iterate through each word
            foreach (string word in words)
            {
                // Check if the word is in the list of verbs
                if (verbs.Contains(word.ToLower()))
                {
                    foundVerbs.Add(word);
                }
            }
            // Return the list of found verbs
            return foundVerbs;
        }
    }
}
