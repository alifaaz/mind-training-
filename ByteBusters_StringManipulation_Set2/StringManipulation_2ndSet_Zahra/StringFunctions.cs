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
            try
            {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            return string1.Length;
            }
            catch (Exception ex)
            {
                throw new Exception("CountCharacters expects a non-null string. " + ex.Message);
            }
        }

        public static string ToUpper(string string1)
        {
            try
            {
                if (string1 == null)
                    throw new ArgumentNullException(nameof(string1));
                return string1.ToUpper();
            }
            catch (Exception ex)
            {
                throw new Exception("ToUpper expects a non-null string. " + ex.Message);
            }

        }

        public static string ToLower(string string1)
        {
            try
            {
                if (string1 == null)
                    throw new ArgumentNullException(nameof(string1));
                return string1.ToLower();
            }
            catch (Exception ex)
            {
                throw new Exception("ToLower expects a non-null string. " + ex.Message);
            }

        }
        /*Check if a string starts with a given prefix.*/
        public static bool StartsWithPrefix(string string1, string prefix)
        {
            try
            {
            if (string1 == null)
                throw new ArgumentNullException(nameof(string1));
            if (prefix == null)
                throw new ArgumentNullException(nameof(prefix));
            return string1.StartsWith(prefix);
            }
            catch (Exception ex)
            {
                throw new Exception("StartsWithPrefix expects a non-null string. " + ex.Message);
            }

        }
        //Check if a string ends with a given suffix.
        public static bool EndsWithSuffix(string string1, string suffix)
        {
            try
            {
                if (string1 == null)
                    throw new ArgumentNullException(nameof(string1));
                if (suffix == null)
                    throw new ArgumentNullException(nameof(suffix));
                return string1.EndsWith(suffix);
            }
            catch (Exception ex)
            {
                throw new Exception("EndsWithSuffix expects a non-null string. " + ex.Message);
            }

        }
        //Check if a string contains only digits
        public static bool ContainsOnlyDigits(string string1)
        {
            try
            {
                if (string1 == null)
                    throw new ArgumentNullException(nameof(string1));
                foreach (char c in string1)
                    if (!char.IsDigit(c))
                        return false;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("ContainsOnlyDigits expects a non-null string. " + ex.Message);
            }
        }
        //Check if a string contains only letters
        public static bool ContainsOnlyLetters(string string1)
        {
            try
            {
                if (string1 == null)
                    throw new ArgumentNullException(nameof(string1));
                foreach (char c in string1)
                    if (!char.IsLetter(c))
                        return false;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("ContainsOnlyLetters expects a non-null string. " + ex.Message);
            }
        }
        //Capitalize the first character of a string
        public static string CapitalizeFirstCharacter(string string1)
        {
            try
            {
                if (string1 == null)
                    throw new ArgumentNullException(nameof(string1));
                if (string1.Length == 0)
                    throw new ArgumentException("Input string cannot be empty.", nameof(string1));
                return char.ToUpper(string1[0]) + string1.Substring(1);
            }
            catch (Exception ex)
            {
                throw new Exception("CapitalizeFirstCharacter expects a non-null string. " + ex.Message);
            }
        }
        //Swap the case of each character in a string
        public static string SwapCase(string string1)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("SwapCase expects a non-null string. " + ex.Message);
            }
        }

        // Split a string into words  Input: 'hello world' -> Output: ['hello', 'world']
        public static string[] SplitIntoWords(string string1)
        {
            try
            {
                if (string1 == null)
                    throw new ArgumentNullException(nameof(string1));
                return string1.Split(' ');
            }
            catch (Exception ex)
            {
                throw new Exception("SplitIntoWords expects a non-null string. " + ex.Message);
            }
        }

        // Remove leading and trailing whitespace from a string
        public static string TrimWhitespace(string string1)
        {
            try
            {
                if (string1 == null)
                    throw new ArgumentNullException(nameof(string1));
                return string1.Trim();
            }
            catch (Exception ex)
            {
                throw new Exception("TrimWhitespace expects a non-null string. " + ex.Message);
            }
        }

        // Count the number of spaces in a string
        public static int CountSpaces(string string1)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("CountSpaces expects a non-null string. " + ex.Message);
            }
        }

        // Get the first 5 characters of a string
        public static string GetFirstFiveCharacters(string string1)
        {
            try
            {
                if (string1 == null)
                    throw new ArgumentNullException(nameof(string1));
                if (string1.Length < 5)
                    // if it's less than 5 characters Return it
                    return string1;
                // else return the first 5 chars
                return string1.Substring(0, 5);
            }
            catch (Exception ex)
            {
                throw new Exception("GetFirstFiveCharacters expects a non-null string. " + ex.Message);
            }
        }

        // Get the last 3 characters of a string
        public static string GetLastThreeCharacters(string string1)
        {
            try
            {
                if (string1 == null)
                    throw new ArgumentNullException(nameof(string1));
                if (string1.Length < 3)
                    // if it's less than 3 characters return it
                    return string1;
                // else return the last 3 chars
                return string1.Substring(string1.Length - 3);
            }
            catch (Exception ex)
            {
                throw new Exception("GetLastThreeCharacters expects a non-null string. " + ex.Message);
            }
        }

        // Replace commas with semicolons in a string
        public static string ReplaceCommasWithSemicolons(string string1)
        {
            try
            {
                if (string1 == null)
                    throw new ArgumentNullException(nameof(string1));
                return string1.Replace(',', ';');
            }
            catch (Exception ex)
            {
                throw new Exception("ReplaceCommasWithSemicolons expects a non-null string. " + ex.Message);
            }
        }

        /*
        English: Join a list of words into a string.
        Example (English): Input: ['hello', 'world'] -> Output: 'hello world'
        */
        public static string JoinWords(string[] words)
        {
            try
            {
                if (words == null)
                    throw new ArgumentNullException(nameof(words));
                return string.Join(" ", words);
            }
            catch (Exception ex)
            {
                throw new Exception("JoinWords expects a non-null array of strings. " + ex.Message);
            }
        }

        /*English: Check if two strings are anagrams.
        Example (English): Input: 'listen', 'silent' -> Output: True 
        اولا اساوي اخليهم نفس الكيس بعدين ارتبهم و اشوف اذا متساوين يعني نفس الحروف بالطرفين
         */
        public static bool AreAnagrams(string str1, string str2)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("AreAnagrams expects non-null strings. " + ex.Message);
            }
        }

        /*English: Check if a string is an email address format.
        Example (English): Input: 'user@example.com' -> Output: True
        */
        public static bool IsEmailAddress(string email)
        {
            try
            {
                if (email == null)
                    throw new ArgumentNullException(nameof(email));
                return Regex.IsMatch(email, ".*@.*\\..*");
                // Regex means regular expression,
                // .* = any char any no. times,
                // @ = at least one @ symbol
                // \\ = escape character . = at least one dot
            }
            catch (Exception ex)
            {
                throw new Exception("IsEmailAddress expects a non-null string. " + ex.Message);
            }
        }

        /*English: Find all the digits in a string.
        Example (English): Input: 'a1b2c3' -> Output: ['1', '2', '3'] */
        public static char[] FindDigits(string string1)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("FindDigits expects a non-null string. " + ex.Message);
            }
        }
        /*English: Find all the letters in a string.
        Example (English): Input: 'abc123' -> Output: ['a', 'b', 'c'] */
        public static char[] FindLetter(string string1)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("FindLetter expects a non-null string. " + ex.Message);
            }

        }
        /*English: Mask an email address (e.g., a***@domain.com).
        Example (English): Input: 'john.doe@example.com' -> Output: 'j***@example.com' */
        public static string MaskEmailAddress(string email)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("MaskEmailAddress expects a valid email address. " + ex.Message);
            }
        }

        /*English: Convert a sentence into a list of ASCII codes.
        Example (English): Input: 'Hi' -> Output: [72, 105] */
        public static List<int> ConvertToAsciiCodes(string word)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("ConvertToAsciiCodes expects a non-null string. " + ex.Message);
            }
        }

        /*English: Remove duplicate words from a sentence.
        Example (English): Input: 'hello hello world' -> Output: 'hello world'*/
        public static string RemoveDuplicateWords(string sentence)
        {
            try
            {
                if (sentence == null)
                    throw new ArgumentNullException(nameof(sentence));
                return string.Join(" ", sentence.Split(' ').Distinct());
                // string1.Split(' ')	يقسم الجملة إلى كلمات حسب الفراغات
                //.Distinct() يحذف الكلمات المكررة
                //string.Join(" ", )   يرجع الكلمات الفريدة كجملة واحدة مفصولة بمسافات

            }
            catch (Exception ex)
            {
                throw new Exception("RemoveDuplicateWords expects a non-null string. " + ex.Message);
            }
        }

        /*English: Extract the file extension from a filename.
        Example (English): Input: 'report.pdf' -> Output: 'pdf'*/
        public static string ExtractFileExtension(string filename)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("ExtractFileExtension expects a non-null string. " + ex.Message);
            }
        }

        /*English: Replace newlines with spaces in a string.
        Example (English): Input: 'hello\nworld' -> Output: 'hello world'*/
        public static string ReplaceNewlinesWithSpaces(string string1)
        {
            try
            {
                if (string1 == null)
                    throw new ArgumentNullException(nameof(string1));
                return string1.Replace("\n", " ");
            }
            catch (Exception ex)
            {
                throw new Exception("ReplaceNewlinesWithSpaces expects a non-null string. " + ex.Message);
            }
        }

        /*English: Convert a string date from 'YYYY-MM-DD' to 'DD/MM/YYYY'.
        Example (English): Input: '2024-01-01' -> Output: '01/01/2024' */
        public static string ConvertDateFormat(string date)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("ConvertDateFormat expects a non-null string in 'YYYY-MM-DD' format. " + ex.Message);
            }
        }
        /*English: Find how many times a specific character appears in a string.
        Example (English): Input: 'banana', Char: 'a' -> Output: 3 */
        public static int CountCharacters(string string1, char character)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("CountCharacters expects a non-null string. " + ex.Message);
            }
        }

        /*English: Check if a string contains any special characters.
        Example (English): Input: 'hello@!' -> Output: True */
        public static bool ContainsSpecialCharacters(string str1)
        {
            try
            {
                if (str1 == null)
                    throw new ArgumentNullException(nameof(str1));
                return str1.Any(c => !char.IsLetterOrDigit(c));
            }
            catch (Exception ex)
            {
                throw new Exception("ContainsSpecialCharacters expects a non-null string. " + ex.Message);
            }
        }

        /*English: Convert snake_case to camelCase.
        Example (English): Input: 'my_name' -> Output: 'myName'*/
        public static string ConvertSnakeToCamel(string snakeCase)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("ConvertSnakeToCamel expects a non-null string in snake_case format. " + ex.Message);
            }
        }
        /*Exercise 30  :
        English: Convert camelCase to snake_case.
        Example (English): Input: 'myName' -> Output: 'my_name' */
        public static string ConvertCamelToSnake(string camelCase)
        {
            try
            {
                if (camelCase == null)
                    throw new ArgumentNullException(nameof(camelCase));
                for (int i = 1; i < camelCase.Length; i++)
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
            catch (Exception ex)
            {
                throw new Exception("ConvertCamelToSnake expects a non-null string in camelCase format. " + ex.Message);
            }
        }

        //Replace all numeric values in a string with #.
        public static string ReplaceNumbersWithHash(string str1)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("ReplaceNumbersWithHash expects a non-null string. " + ex.Message);
            }
        }
        // Count how many words are capitalized.Input: 'HeLLo World' -> Output: 2

        public static int HowManyCapitalized(string str1)
        {
            try
            {
                if (str1 == null)
                    throw new ArgumentNullException(nameof(str1));
                int count = 0;
                // Split the string into words using space
                string[] words = str1.Split(' ');
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
            catch (Exception ex)
            {
                throw new Exception("HowManyCapitalized expects a non-null string. " + ex.Message);
            }
        }

        /*Remove all vowels from a string.
        Example (English): Input: 'education' -> Output: 'dctn' */
        public static string RemoveVowels(string str1)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("RemoveVowels expects a non-null string. " + ex.Message);
            }
        }

        // Check if a string contains only whitespace.
        public static bool ContainsOnlyWhitespace(string str1)
        {
            try
            {
                if (str1 == null)
                    throw new ArgumentNullException(nameof(str1));
                return str1.All(char.IsWhiteSpace);
            }
            catch (Exception ex)
            {
                throw new Exception("ContainsOnlyWhitespace expects a non-null string. " + ex.Message);
            }
        }
        //Convert binary string to decimal.
        // we use Convert.ToInt32 to convert the binary string to decimal, 2 for binary
        public static int ConvertBinaryToDecimal(string binaryString)
        {
            try
            {
                if (binaryString == null)
                    throw new ArgumentNullException(nameof(binaryString));
                return Convert.ToInt32(binaryString, 2);
            }
            catch (Exception ex)
            {
                throw new Exception("ConvertBinaryToDecimal expects a non-null binary string. " + ex.Message);
            }
        }

        //Create a string pattern like 'A-B-C'.
        // Example(English) : Input: 'abc' -> Output: 'a-b-c'
        public static string CreatePattern(string str1)
        {
            try
            {
                if (str1 == null)
                    throw new ArgumentNullException(nameof(str1));
                return string.Join("-", str1.ToCharArray());
            }
            catch (Exception ex)
            {
                throw new Exception("CreatePattern expects a non-null string. " + ex.Message);
            }
        }

        /* Add a space after every comma.
        Example (English): Input: 'a,b,c' -> Output: 'a, b, c' */
        public static string AddSpaceAfterComma(string str1)
        {
            try
            {
                if (str1 == null)
                    throw new ArgumentNullException(nameof(str1));
                return str1.Replace(",", ", ");
            }
            catch (Exception ex)
            {
                throw new Exception("AddSpaceAfterComma expects a non-null string. " + ex.Message);
            }
        }

        /*Trim a string to a maximum of 10 characters.
        Example (English): Input: 'abcdefghijk' -> Output: 'abcdefghij'*/
        public static string TrimToMax10Characters(string str1)
        {
            try
            {
                if (str1 == null)
                    throw new ArgumentNullException(nameof(str1));
                if (str1.Length <= 10)
                    return str1;
                return str1.Substring(0, 10);
            }
            catch (Exception ex)
            {
                throw new Exception("TrimToMax10Characters expects a non-null string. " + ex.Message);
            }
        }

        /*Format phone number to international style.
        Example (English): Input: '+9647912345678' -> Output: '009647912345678' */
        public static string FormatPhoneNumber(string phoneNumber)
        {
            try
            {
                if (phoneNumber == null)
                    throw new ArgumentNullException(nameof(phoneNumber));
                // Check if the phone number starts with +
                if (phoneNumber.StartsWith("+"))
                {
                    // Replace + with 00
                    return "00" + phoneNumber.Substring(1);
                }
                // If it doesn't start with +, return it as is
                return phoneNumber;
            }
            catch (Exception ex)
            {
                throw new Exception("FormatPhoneNumber expects a non-null phone number string. " + ex.Message);
            }
        }

        /*Parse a sentence and identify verbs.
        Example (English): Input: 'I run and jump' -> Verbs: ['run', 'jump'] */
        public static List<string> IdentifyVerbs(string sentence)
        {
            try
            {
                if (sentence == null)
                    throw new ArgumentNullException(nameof(sentence));
                // طبعاغلط احله هيج المفروض استخدم مكتبة خاصة غالبا ضمن ال NLP بس هذا الموجود حاليا
                string[] verbs = { "run", "jump", "swim", "walk", "play", "eat", "drink", "sleep" };
                List<string> foundVerbs = new List<string>();
                // Split the sentence into words
                string[] words = sentence.Split(' ');
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
            catch (Exception ex)
            {
                throw new Exception("IdentifyVerbs expects a non-null sentence string. " + ex.Message);
            }
        }
        /*English: Redact names from a document.
        Example (English): Input: 'Ali went to school.' -> Output: '[REDACTED] went to school.' without RegEx*/
        public static string RedactNames(string document)
        {
            try
            {
                if (document == null)
                    throw new ArgumentNullException(nameof(document));
                // List of names to redact
                List<string> namesToRedact = new List<string> { "Ali", "Mostafa", "Moosa", "Aween", "Rabab", "Noor", "Zahraa" };
                // Iterate through each name and replace it with [REDACTED]
                foreach (string name in namesToRedact)
                {
                    document = document.Replace(name, "[REDACTED]");
                }
                return document;
            }
            catch (Exception ex)
            {
                throw new Exception("RedactNames expects a non-null document string. " + ex.Message);
            }
        }

        /*English: Detect language of a sentence.
        Example (English): Input: 'Hello, كيف حالك؟' -> Output: 'Arabic' using Ascii code */
        public static string DetectLanguage(string sentence)
        {
            try
            {
                if (sentence == null)
                    throw new ArgumentNullException(nameof(sentence));
                // is there Arabic characters?
                foreach (char c in sentence)
                {
                    // 0x0600 and 0x06FF are hexadecimal values representing the
                    //  start and end of the Arabic Unicode
                    if (c >= 0x0600 && c <= 0x06FF)
                    {
                        // Console.WriteLine($"Char: {c} -> Unicode: {(int)c}");
                        return "Arabic";
                    }
                }
                // No Arabic? then it's English
                return "English";
            }
            catch (Exception ex)
            {
                throw new Exception("DetectLanguage expects a non-null sentence string. " + ex.Message);
            }
        }

        /*English: Compare two strings ignoring punctuation.
        Example (English): Input: 'Hello!' vs 'Hello' -> Output: True without regex*/
        public static bool CompareIgnoringPunctuation(string str1, string str2)
        {
            try
            {
                if (str1 == null || str2 == null)
                    throw new ArgumentNullException("You have to enter 2 strings to compare!");
                foreach (char c in str1)
                {
                    // if the char is punctuation we remove it
                    if (char.IsPunctuation(c))
                    {
                        str1 = str1.Replace(c.ToString(), "");
                    }
                }
                foreach (char c in str2)
                {
                    // if the char is punctuation we remove it
                    if (char.IsPunctuation(c))
                    {
                        str2 = str2.Replace(c.ToString(), "");
                    }
                }
                // Convert both strings to lower case for case-insensitive comparison
                str1 = str1.ToLower(); str2 = str2.ToLower();
                // Finally, compare the strings
                return str1 == str2;
            }
            catch (Exception ex)
            {
                throw new Exception("CompareIgnoringPunctuation expects non-null strings. " + ex.Message);
            }
        }

        /*English: Generate acronym from a phrase.
        Example (English): Input: 'World Health Organization' -> Output: 'WHO' */
        public static string GenerateAcronym(string phrase)
        {
            try
            {
                if (phrase == null)
                    throw new ArgumentNullException(nameof(phrase));
                // Split the phrase into words
                string[] words = phrase.Split(' ');
                // Create a new string for the acronym
                string acronym = "";
                // Iterate through each word
                foreach (string word in words)
                    // add the capitalized first letter of each word to the acronym         
                    acronym += char.ToUpper(word[0]);
                return acronym.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("GenerateAcronym expects a non-null phrase string. " + ex.Message);
            }
        }

        /*English: Remove hashtags from a sentence.
        Example (English): Input: 'great day #fun #sun' -> Output: 'great day fun sun' */
        public static string RemoveHashtags(string sentence)
        {
            try
            {
                if (sentence == null)
                    throw new ArgumentNullException(nameof(sentence));
                return sentence.Replace("#", "");
            }
            catch (Exception ex)
            {
                throw new Exception("RemoveHashtags expects a non-null sentence string. " + ex.Message);
            }
        }

        /*English: Extract mentions (e.g., @user) from text.
        Example (English): Input: '@user1 hello @user2' -> Output: ['@user1', '@user2'] */
        public static List<string> ExtractMentions(string text)
        {
            try
            {
                if (text == null)
                    throw new ArgumentNullException(nameof(text));

                List<string> mentions = new List<string>();
                // Split the text into words
                string[] words = text.Split(' ');

                // Iterate through each word
                foreach (string word in words)
                {
                    // Check if the word starts with @
                    if (word.StartsWith("@"))
                    {
                        mentions.Add(word);
                    }
                }
                return mentions;
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractMentions expects a non-null text string. " + ex.Message);
            }
        }

        /*English: Count number of hashtags in a sentence.
        Example (English): Input: '#love #life' -> Output: 2 */
        public static int CountHashtags(string sentence)
        {
            try
            {
                if (sentence == null)
                    throw new ArgumentNullException(nameof(sentence));
                int count = 0;
                foreach (char c in sentence)
                {
                    // Check if the character is a hashtag
                    if (c == '#')
                    {
                        count++;
                    }
                }
                return count;
            }
            catch (Exception ex)
            {
                throw new Exception("CountHashtags expects a non-null sentence string. " + ex.Message);
            }
        }

        /*English: Insert newline after every full stop.
        Example (English): Input: 'Hi. How are you?' -> Output: 'Hi.\nHow are you?' */
        public static string InsertNewlineAfterFullStop(string sentence)
        {
            try
            {
                if (sentence == null)
                    throw new ArgumentNullException(nameof(sentence));
                // Replace each full stop with a full stop followed by a newline
                return sentence.Replace(".", ".\n");
            }
            catch (Exception ex)
            {
                throw new Exception("InsertNewlineAfterFullStop expects a non-null sentence string. " + ex.Message);
            }
        }

        /*English: Reverse word order in a sentence.
        Example (English): Input: 'I am fine' -> Output: 'fine am I' */
        public static string ReverseWordOrder(string sentence)
        {
            try
            {
                if (sentence == null)
                    throw new ArgumentNullException(nameof(sentence));
                // Split the sentence into words
                string[] words = sentence.Split(' ');
                // Reverse the order of the words
                Array.Reverse(words);
                // Join the reversed words back into a sentence
                return string.Join(" ", words);
            }
            catch (Exception ex)
            {
                throw new Exception("ReverseWordOrder expects a non-null sentence string. " + ex.Message);
            }
        }

        /*English: Sort words alphabetically in a sentence.
        Example (English): Input: 'banana apple' -> Output: 'apple banana' */
        public static string SortWordsAlphabetically(string sentence)
        {
            try
            {
                if (sentence == null)
                    throw new ArgumentNullException(nameof(sentence));
                // Split the sentence into words
                string[] words = sentence.Split(' ');
                // Sort the words alphabetically
                Array.Sort(words);
                // Join the sorted words back into a sentence
                return string.Join(" ", words);
            }
            catch (Exception ex)
            {
                throw new Exception("SortWordsAlphabetically expects a non-null sentence string. " + ex.Message);
            }
        }

        /*English: Generate a slug from a title.
        Example (English): Input: 'My Title' -> Output: 'my-title' */
        public static string GenerateSlug(string title)
        {
            try
            {
                if (title == null)
                    throw new ArgumentNullException(nameof(title));
                // Convert the title to lower case
                title = title.ToLower();
                // Replace spaces with hyphens
                title = title.Replace(" ", "-");
                return title;
            }
            catch (Exception ex)
            {
                throw new Exception("GenerateSlug expects a non-null title string. " + ex.Message);
            }
        }

        /*English: Count the number of uppercase letters.
        Example (English): Input: 'Hi There' -> Output: 2 */
        public static int CountUpperLetters(string str1)
        {
            try
            {
                if (str1 == null)
                    throw new ArgumentNullException(nameof(str1));
                int count = 0;
                foreach (char c in str1)
                {
                    if (char.IsUpper(c))
                    {
                        count++;
                    }
                }
                return count;
            }
            catch (Exception ex)
            {
                throw new Exception("CountUpperLetters expects a non-null string. " + ex.Message);
            }
        }

        //English: Replace numbers with words (e.g., 3 -> three).
        //Example(English) : Input: '3 cats' -> Output: 'three cats'
        public static string ReplaceNumbersWithWords(string sentence)
        {
            try
            {
                if (sentence == null)
                    throw new ArgumentNullException(nameof(sentence));

                // Dictionary to map numbers to words
                Dictionary<string, string> numberWordsDict = new Dictionary<string, string>
            {
                { "0", "zero" },
                { "1", "one" },
                { "2", "two" },
                { "3", "three" },
                { "4", "four" },
                { "5", "five" },
                { "6", "six" },
                { "7", "seven" },
                { "8", "eight" },
                { "9", "nine" }
            };
                // Replace each number with its corresponding word
                // we cant use string instead of var cause it will not work with the dictionary
                foreach (var number in numberWordsDict)
                {
                    sentence = sentence.Replace(number.Key, number.Value);
                }
                return sentence;
            }
            catch (Exception ex)
            {
                throw new Exception("ReplaceNumbersWithWords expects a non-null sentence string. " + ex.Message);
            }
        }

        /* English: Replace tabs with 4 spaces.
        Example (English): Input: '\tTab' -> Output: '    Tab'  */
        public static string ReplaceTabsWithSpaces(string str1)
        {
            try
            {
                if (str1 == null)
                    throw new ArgumentNullException(nameof(str1));
                // Replace each tab character with 4 spaces
                return str1.Replace("\t", "    ");
            }
            catch (Exception ex)
            {
                throw new Exception("ReplaceTabsWithSpaces expects a non-null string. " + ex.Message);
            }
        }

        /*English: Check if string is a valid URL.
        Example (English): Input: 'https://openai.com' -> Output: Valid */
        public static string IsValidUrl(string url)
        {
            try
            {
                if (url == null)
                    throw new ArgumentNullException(nameof(url));
                // Regular expression to check if the URL is valid
                if (Regex.IsMatch(url, "(http|https)://.*\\..*"))
                    return "Valid";
                else
                    return "Invalid";
            }
            catch (Exception ex)
            {
                throw new Exception("IsValidUrl expects a non-null URL string. " + ex.Message);
            }
        }

        /*English: Remove HTML tags from a string.
        Example (English): Input: '<p>Hello</p>' -> Output: 'Hello' */
        public static string RemoveHtmlTags(string html)
        {
            try
            {
                if (html == null)
                    throw new ArgumentNullException(nameof(html));
                // جربت اكتبها بدون علامة استفهام و حذفلي كلشي :/ لان بدونها حتكون greedy
                return Regex.Replace(html, "<.*?>", "");
            }
            catch (Exception ex)
            {
                throw new Exception("RemoveHtmlTags expects a non-null HTML string. " + ex.Message);
            }
        }
        /*English: Convert markdown to plain text.
        Example (English): Input: '**Bold**' -> Output: 'Bold' use replace only*/
        public static string ConvertMarkdownToPlainText(string markdown)
        {
            try
            {
                if (markdown == null)
                    throw new ArgumentNullException(nameof(markdown));
                // Replace markdown syntax with plain text
                markdown = markdown.Replace("**", ""); // Remove bold syntax
                markdown = markdown.Replace("*", "");  // Remove italic syntax
                markdown = markdown.Replace("__", ""); // Remove underline syntax
                return markdown;
            }
            catch (Exception ex)
            {
                throw new Exception("ConvertMarkdownToPlainText expects a non-null markdown string. " + ex.Message);
            }
        }

    }
}