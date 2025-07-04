using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StringsTrains_MostafaOmar
{
        public class Solution
        {
        //Exercise 1  :
        //Count the number of characters in a string.
        //------------------------------------------------------------
        //Sol
        // i will use method length to count the number of string

        public static int NumberOfCharacterInString(string str) // string will take the name or whatever it is
            {
                int NumberOfCharInString = str.Length; // initialze variable to store length in it
                return NumberOfCharInString;
            }
        //Exercise 2  :
        //English: Convert a string to uppercase.
        //Example(English): Input: 'hello' -> Output: 'HELLO'
        //------------------------------------------------------------
        // Sol:
        // to solve this problem i will use ToUpper Method that help me to convert
        // every character in string To Upper case

        public static string ConvertToUpper(string input)
        {
            string InputToUpper = input.ToUpper();
            return InputToUpper;
        
        }
        //Exercise 3  :
        //English: Convert a string to lowercase.
        //------------------------------------------------------------
        // Sol:
        // to solve this problem i will use ToLower Method that help me to convert
        // every character in string to Lower case
            public static string ConvertToLower(string input)
            {
                string InputToLower = input.ToLower();
                return InputToLower;
            }

            //Exercise 4  :
            //English: Check if a string starts with a given prefix.
            //Arabic: تحقق مما إذا كانت السلسلة تبدأ بمقدمة معينة.
            //Example (English): Input: 'welcome', Prefix: 'wel' -> Output: True
            //------------------------------------------------------------
            //sol
            //im gonna use bool function to return me true or false, and use the method 
            //start with() to check if its start with the given prefix
            public static bool IsStartWithGivenPrefix (string input, string prefix)
            {
            return input.StartsWith(prefix);
            }
            //Exercise 5  :
            //English: Check if a string ends with a given suffix.
            //Arabic: تحقق مما إذا كانت السلسلة تنتهي بنهاية معينة.
            //Example (English): Input: 'file.txt', Suffix: '.txt' -> Output: True
            //------------------------------------------------------------
            //sol
            //im gonna use bool function to return me true or false, and use the method 
            //start with() to check if its start with the given suffix
            public static bool IsEndtWithGivenSuffix (string input, string suffix)
            {
            return input.EndsWith(suffix);
            }

            //Exercise 6  :
            //English: Check if a string contains only digits.
            //Arabic: تحقق مما إذا كانت السلسلة تحتوي فقط على أرقام.
            //Example (English): Input: '123456' -> Output: True
            //------------------------------------------------------------
            //sol
            //i will use for each to chaeck every character in input string
            //if its digit return true, if its not digit return false
            public static bool IsStringOnlyDigits (string input)
        {
            foreach (char character in input)
            {
                if (!char.IsDigit(character)) 
                    return false;
            }
            return true;
        }

        //Exercise 7  :
        //English: Check if a string contains only letters.
        //Arabic: تحقق مما إذا كانت السلسلة تحتوي فقط على أحرف.
        //Example (English): Input: 'hello' -> Output: True
        //------------------------------------------------------------
        //i will use for each to chaeck every Letter in input string
        //if its Letter return true, if its not Letter return false
        public static bool IsStringOnlyLetters(string input)
        {
            foreach (char Letter in input)
            {
                if (!char.IsLetter(Letter))
                    return false;
            }
            return true;
        }

        //Exercise 8  :
        //English: Capitalize the first character of a string.
        //Arabic: اجعل أول حرف في السلسلة كبيرًا.
        //Example (English): Input: 'hello' -> Output: 'Hello'
        //------------------------------------------------------------
        // i will take the first index and uppercase it
        // and i will update the the rest of the string to start from index 1
        public static string CapitalizeTheFirstCharacterOfString (string input)
        {
            string FirstLetter = input[0].ToString();
            input = input.Substring(1);
            return FirstLetter.ToUpper() + input;
        }

        //Exercise 9  :
        //English: Swap the case of each character in a string.
        //Arabic: بدّل حالة كل حرف في السلسلة.
        //Example (English): Input: 'HeLLo' -> Output: 'hEllO'
        //------------------------------------------------------------
        //sol
        // راح اعرف متغيرين واحد يشوف اذا جان كابتل وواحد يشوف اذا جان سمول
        // بعدها اسوي السمول كبتل والكبتل سمول
        public static string ReverseUpperToLowerAndLowerToUpper(string input)
        {

            string ReversedString = ""; // نخزن الحروف المعدلة هنا

            for (int i = 0; i < input.Length; i++)
            {
                char CurrentChar = input[i];

                // إذا كان كابتل نحوله الى سمول
                if (char.IsUpper(CurrentChar))
                {
                    ReversedString += char.ToLower(CurrentChar);
                }
                // إذا كان سمول نحوله الى كابتل
                else if (char.IsLower(CurrentChar))
                {
                    ReversedString += char.ToUpper(CurrentChar);
                }
                // إذا كان رقم او أي شيء ثاني نخليه نفس ما هوة
                else
                {
                    ReversedString += CurrentChar;
                }
            }
            return ReversedString;
        }
        //Exercise 10  :
        //English: Split a string into words.
        //Example(English): Input: 'hello world' -> Output: ['hello', 'world']
        //------------------------------------------------------------
        //declare variable to store result in t
        // make for loop to check if the words conatain spaces
        // if its contain we put comma and if there is no spase we add 
        // the character to the result and we return the result after the loop end
        public static string SplitStringIntoWords(string input)
        {
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    result += ", ";
                }
                else
                {
                    result += input[i];
                }
            }
            return result;
        }
        //Exercise 11  :
        //English: Join a list of words into a string.
        //Arabic: حوّل قائمة كلمات إلى سلسلة واحدة.
        //Example (English): Input: ['hello', 'world'] -> Output: 'hello world'
        //------------------------------------------------------------
        // same thing but here we gonna change the condtion from spase to coma
        // and the result will be added with the orignal string
        public static string MergeWordsIntoString(string input)
        {
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ',')
                {
                    result += ' ';
                }
                else
                {
                    result += input[i];
                }
            }
            return result;
        }
        //Exercise 12  :
        //English: Remove leading and trailing whitespace from a string.
        //Example (English): Input: '  hello  ' -> Output: 'hello'
        //------------------------------------------------------------
        // i will make for loop, if there is no spase add the character to the string
        public static string RemovingSpacesFromString(string input)
        {
            //string StringWithoutSpaces = "";
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] != ' ')
            //        StringWithoutSpaces += input[i];
            //}
            //return StringWithoutSpaces;
            // هذا غلط لأن يجيك كل الفراغات اللي بلكود
            // راح استعمل دالة اسمها ترم هية راح تسوي الشغل المطلوب بالسؤال
            // تحذف الفراغات من البداية والنهاية
            return input.Trim();
        }
        //Exercise 13  :
        //English: Count the number of spaces in a string.
        //Example (English): Input: 'a b c' -> Output: 2
        //------------------------------------------------------------
        //sol 
        //i will initalize count variable and create for loop to check
        // if its space i will increasee the counter

        public static int NumberOfSpaces(string input)
        {
            //int counter = 0;
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] == ' ')
            //        counter++;
            //}
            //return counter;

            // change the sol after the meeting
            return input.Length - input.Replace(" ", "").Length;
        }
        //Exercise 14  :
        //English: Check if a string is an email address format.
        //Example (English): Input: 'user@example.com' -> Output: True
        //------------------------------------------------------------
        //
        public static bool CheckIfStringIsAnEmail(string input)
        {
            return input.EndsWith("@example.com");
        }
        //Exercise 15  :
        //English: Get the first 5 characters of a string.
        //Example (English): Input: 'abcdefg' -> Output: 'abcde'
        //------------------------------------------------------------
        //sol
        //i will use substring method to return only first 5
        public static string ReturnTheFirstFivecharacters (string input)
        {
            return input.Substring(0, 5);
        }
        //Exercise 16  :
        //English: Get the last 3 characters of a string.
        //Example (English): Input: 'abcdefg' -> Output: 'efg'
        //------------------------------------------------------------
        // sol
        // i also gonna use the substring method to chose the last 3 only
        public static string ReturnTheLastThreecharacters(string input)
        {
            return input.Substring(input.Length - 3);
        }
        //Exercise 17  :
        //English: Replace commas with semicolons in a string.
        //Example (English): Input: 'a,b,c' -> Output: 'a;b;c'
        //------------------------------------------------------------
        // i will use the replace function to replace coma with ;
        public static string ReplaceComasWithSemicolons(string input)
        {
            return input.Replace(",", ";");
        }
        //Exercise 18  :
        //English: Check if two strings are anagrams.
        //Example (English): Input: 'listen', 'silent' -> Output: True
        //------------------------------------------------------------
        //first i will check the length, if one is taller than the other then its false
        //second i will convert the 2 inputs to array
        //to user the sort method from Array class and check if they are equall to eachother

        public static bool CheckIfTwoStringsIsAnagrams (string FirstInput, string SecondInput)
        {
            if (FirstInput.Length != SecondInput.Length)
                return false;
           
            char[] FirstInputInCharArray = FirstInput.ToCharArray();
            char[] SecondInputInCharArray = SecondInput.ToCharArray();

            Array.Sort(FirstInputInCharArray);
            Array.Sort(SecondInputInCharArray);

            string SortedFirstInputInCharArray = new string(FirstInputInCharArray);
            string SortedSecondInputInCharArray = new string(SecondInputInCharArray);

            return SortedFirstInputInCharArray == SortedSecondInputInCharArray;
        }
        //Exercise 19  :
        //English: Find all the digits in a string.
        //Example (English): Input: 'a1b2c3' -> Output: ['1', '2', '3']
        //------------------------------------------------------------
        //i will convert the string to array of characters and check if the input is digit
        // if its digit i will add it to new string
        public static string FindAllDigit(string input)
        {
            char[] InputInCharArray = input.ToCharArray();
            string DigitsInInput = ("");
            for (int i = 0; i < InputInCharArray.Length; i++)
            {
                if (char.IsDigit(InputInCharArray[i]))
                {
                    // so i dont add , before the first digit
                    if (DigitsInInput.Length > 0)
                        DigitsInInput += ",";
                    DigitsInInput += InputInCharArray[i];
                }
            }
            return DigitsInInput;
        }
        //Exercise 20  :
        //English: Find all the letters in a string.
        //Arabic: استخرج جميع الأحرف من السلسلة.
        //Example (English): Input: 'abc123' -> Output: ['a', 'b', 'c']
        //------------------------------------------------------------
        //SOL
        //i will do the same but use the methode IsLetter
        public static string FindAllLetters(string input)
        {
            char[] InputInCharArray = input.ToCharArray();
            string LettersInInput = ("");
            for (int i = 0; i < InputInCharArray.Length; i++)
            {
                if (char.IsLetter(InputInCharArray[i]))
                {
                    // so i dont add , before the first digit
                    if (LettersInInput.Length > 0)
                        LettersInInput += ",";
                    LettersInInput += InputInCharArray[i];
                }
            }
            return LettersInInput;
        }
        //Exercise 21  :
        //English: Mask an email address (e.g., a*** @domain.com).
        //Example(English) : Input: 'john.doe@example.com' -> Output: 'j***@example.com'
        //------------------------------------------------------------
        //sol
        //1- im gonna use the method that i created before to CheckIfStringIsAnEmail or not
        // if its email we continue, if its not we gonna throw new argument exception message to the user "Invalid email format"
        //2- next im gonna split the email into 3 things, 
        // first letter
        //the mask (after the first letter to the @ sign) 
        // here i will need to save the index of the @ sign in to an variable so i can use it 
        // and last the domain
        //3- i will take the mask and replase it all to *
        //4 - put them all together 
        public static string MaskAnEmail(string InputEmail)
        {
            //safety check, if is not true we throw exception
            if (!CheckIfStringIsAnEmail(InputEmail))
                 throw new ArgumentException("Invalid email format");

            int position = InputEmail.IndexOf('@');

            string FirstLetter = InputEmail.Substring(0, 1);
            string domain = InputEmail.Substring(position);

            string MaskInput = InputEmail.Substring(1, position - 1);

            char[] MaskInputInCharArray = MaskInput.ToCharArray();

            for (int i = 0; i < MaskInput.Length; i++)
                MaskInputInCharArray[i] = '*';

            string MaskInputString = new string(MaskInputInCharArray);

            return FirstLetter + MaskInputString + domain;
        }
        //Exercise 22  :
        //English: Convert a sentence into a list of ASCII codes.
        //Example(English): Input: 'Hi' -> Output: [72, 105]
        //------------------------------------------------------------
        //sol
        //i will take string and put it in character of array
        //initialize int AsciiCodes to store AsciiCodes
        //for loop for 
        public static string ConvertSenteceToListOfAsciiCodes(string inputSentence)
        {
                char[] chars = inputSentence.ToCharArray();
                int[] AsciiCodes = new int[chars.Length];

                for (int i = 0; i < chars.Length; i++)
                {
                    AsciiCodes[i] = (int)chars[i];
                }
                return string.Join(", ", AsciiCodes);
        }
        //Exercise 23  :
        //English: Remove duplicate words from a sentence.
        //Example (English): Input: 'hello hello world' -> Output: 'hello world'
        //------------------------------------------------------------
        //Sol
        //split the sentence into words using spaces ' '
        //loop through each word and checks if it shown before
        //if the word is not a duplicate it adds it to the result string
        public static string RemoveDuplicateWordsFromSentence(string sentence)
        {
            string[] words = sentence.Split(' ');

            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (result.Contains(words[i]) == false)
                {
                    result += words[i] + " ";
                }
            }

            // remove last space
            return result.TrimEnd();

        }


        //Exercise 24  :
        //English: Extract the file extension from a filename.
        //Example (English): Input: 'report.pdf' -> Output: 'pdf'
        //------------------------------------------------------------
        //sol
        // there is a method that i can use which is in the class path
        //  Path.GetExtension, and i need to remove the '.' so i will 
        // use trim method to remove it from the output
        public static string RemoveExtensionFromFileName(string FileName)
        {
            string extension = Path.GetExtension(FileName);
            return extension.Trim('.');
        }
        //Exercise 25  :
        //English: Replace newlines with spaces in a string.
        //Example (English): Input: 'hello\nworld' -> Output: 'hello world'
        //------------------------------------------------------------
        //sol
        // i will use the replace method
        public static string ReplaceNewlineWithSpacesInString(string input)
        {
            return input.Replace("\n", " ");
        }
        //Exercise 26  :
        //English: Convert a string date from 'YYYY-MM-DD' to 'DD/MM/YYYY'.
        //Example (English): Input: '2024-01-01' -> Output: '01/01/2024'
        //------------------------------------------------------------
        //sol
        //i can split it to three variables and put the year at the end in the add
        // but i found this method from structer that called DateTime and i wanted to 
        // learn how to use it so i implemted it here

        public static string ConvertDateFormat(string inputDate)
        {
            DateTime Newdate = DateTime.Parse(inputDate); 
            return Newdate.ToString("dd/MM/yyyy");    
        }

        //Exercise 27  :
        //English: Find how many times a specific character appears in a string.
        //Example (English): Input: 'banana', Char: 'a' -> Output: 3
        //------------------------------------------------------------
        //sol
        //i will define counter to calculate appearing of char in string
        // if char = the target letter which the user will chose it, we stop add counter +1
        //if not we will repeat the foreach for the next letter, after all we return num of char apper in string
        public static int CountCharacterAppearingInString (string InputString, char TargetLetter)
        {
            int counter = 0;
            foreach (char character in InputString)
                {
                    if (character == TargetLetter)
                    {
                        counter++;
                    }
                }
            return counter;
        }

        //Exercise 28  :
        //English: Check if a string contains any special characters.
        //Example (English): Input: 'hello@!' -> Output: True
        //------------------------------------------------------------
        //i will use char method that check if the string is leter or digit
        // if not it is false and have special characters
        public static bool ContainsSpecialCharacters(string input)
        {
            foreach (char character in input)
            {
                if (!char.IsLetterOrDigit(character))
                {
                    return true;
                }
            }
            return false;
        }
        //Exercise 29  :
        //English: Convert snake_case to camelCase.
        //------------------------------------------------------------
        //sol
        //split it using _ from snake case
        // the first word gonna be in small letters
        // we pass into each word and we make the first letter as upper case
        public static string SnakeToCamel(string input)
        {

            string[] InputWordsSplited = input.Split('_');
            //safety check
            if (InputWordsSplited.Length == 0) 
                return input;
            // first word to lower
            string camelCase = InputWordsSplited[0].ToLower(); 
            
            for (int i = 1; i < InputWordsSplited.Length; i++)
            {
                if (InputWordsSplited[i].Length > 0)
                {
                    string word = InputWordsSplited[i];
                    string firstChar = char.ToUpper(word[0]).ToString();
                    string RestOfTheWord = "";

                    if (word.Length > 1)
                        RestOfTheWord = word.Substring(1).ToLower();

                    camelCase += firstChar + RestOfTheWord;
                }
            }
            return camelCase;
        }
        // Exercise 30  :
        // English: Convert camelCase to snake_case.
        // Example (English): Input: 'myName' -> Output: 'my_name'
        //------------------------------------------------------------
        //sol
        //i will find the upper case letter, then put '_' before it and lower it
        // if its not upper i will just add it

        public static string CamelToSnake(string input)
        {
            string result = "";

            foreach (char letter in input)
            {
                if (char.IsUpper(letter))
                {
                    // إذا حرف كبير، نضيف "_" ثم نحوله إلى صغير
                    result += "_" + char.ToLower(letter);
                }
                else
                {
                    result += letter;
                }
            }
            return result;
        }

        //Exercise 31  :
        //English: Replace all numeric values in a string with #.
        //Example (English): Input: 'abc123' -> Output: 'abc###'
        //------------------------------------------------------------
        //sol
        //i'll check if the char is digit, if it is i will add # to inputresult
        // if not i will add it to the inputresult without any change
        public static string ReplaceAllNumericValuesInString(string input)
        {
            string InputResult = "";
            foreach (char character in input)
            {
                if (char.IsDigit(character))
                    InputResult += "#";
                else
                    InputResult += character;
            }
            return InputResult;
        }
        //Exercise 32  :
        //English: Count how many words are capitalized.
        //Arabic: احسب عدد الكلمات المكتوبة بأحرف كبيرة.
        //Example (English): Input: 'HeLLo World' -> Output: 2
        //------------------------------------------------------------
        //sol
        //i will split the sentence into words
        //creat variable counter to save num of words that have capital
        // we check if it have capital or no using IsCapital var (IsCapital )
        // if i found one in word i go out , if i didnt illl continue searching
        // after it i will increase the counter
        public static int CountWordsWithCapitalLetter(string sentence)
        {
            string[] words = sentence.Split(' ');
            int count = 0;

            foreach (string word in words)
            {
                bool IsCapital = false;

                foreach (char character in word)
                {
                    if (char.IsUpper(character))
                    {
                        IsCapital = true;
                        break;
                    }
                }
                if (IsCapital)
                    count++;
            }
            return count;
        }
        //Exercise 33  :
        //English: Remove all vowels from a string.
        //Arabic: احذف كل الحروف الصوتية من السلسلة.
        //Example (English): Input: 'education' -> Output: 'dctn'
        //------------------------------------------------------------
        
        public static string RemoveAllVowelsFromString(string input)
        {
            string WordWithoutVowels = "";
            foreach (char letter in input)
            {
                char VowelsLower = char.ToLower(letter);

                if (VowelsLower == 'a' || VowelsLower == 'e' || VowelsLower == 'i' ||
                VowelsLower == 'o' || VowelsLower == 'u')
                {
                    WordWithoutVowels += "";
                }
                else
                {
                    WordWithoutVowels += VowelsLower;
                }
            }
            return WordWithoutVowels;
        }
        //Exercise 34  :
        //English: Check if a string contains only whitespace.
        //Example (English): Input: '    ' -> Output: True
        //------------------------------------------------------------
        //sol
        public static bool IsStringContainOnlyWhitespace(string input)
        {
            string InputResult = "";
            foreach (char character in input)
            {
                if (character != ' ')
                    return false;
            }
            return true;
        }
        //Exercise 35  :
        //English: Replace emojis with[EMOJI] tag.
        //Example (English): Input: '😊 Hello' -> Output: '[EMOJI] Hello'
        //مثا        ل  (بالعربية): الإدخال: '😊 Hello' ← الناتج: '[EMOJI] Hello'
        //------------------------------------------------------------
        ///  ///  ///  ///  ///  ///
        public static string ReplaceEmojisWithTag(string input)
        {
            string InputResult = "";

            foreach (char character in input)
            {
                if (  !char.IsLetterOrDigit(character) && 
                      !char.IsWhiteSpace(character) && 
                      !char.IsPunctuation(character)&&
                      !char.IsSymbol(character)
                    )
                {
                    InputResult += "[EMOJI]";
                }
                else
                {
                    InputResult += character;
                }
            }
            return InputResult;
        }

        //Exercise 36  :
        //English: Convert binary string to decimal.
        //Arabic: حوّل سلسلة ثنائية إلى عدد عشري.
        //Example (English): Input: '1010' -> Output: 10
        //------------------------------------------------------------
        // convert string to int and to binary
        public static int ConvertBinaryToDecimal(string InputInBinary)
        {
            return Convert.ToInt32(InputInBinary, 2); //2 mean binary
        }

        //Exercise 37  :
        //English: Convert decimal string to binary.
        //Arabic: حوّل رقم عشري إلى سلسلة ثنائية.
        //Example (English): Input: '10' -> Output: '1010'
        public static string ConvertDecimalToBinary(string InputInDecimal)
        {
            int number = int.Parse(InputInDecimal);          
            string binary = Convert.ToString(number, 2);     
            return binary;
        }
        //------------------------------------------------------------
        //Exercise 38  :
        //English: Create a string pattern like 'A-B-C'.
        //Example (English): Input: 'abc' -> Output: 'a-b-c'
        //i add - after eah character and delete the last -
        public static string CreateStringPattern(string input)
        {
            string InputResult = "";

            foreach (char character in input)
            {
                if (char.IsLetter(character))
                {
                    InputResult += character;
                    InputResult += "-";
                }
            }
            InputResult = InputResult.TrimEnd('-');  

            return InputResult;
        }

        //Exercise 39  :
        //English: Add a space after every comma.
        //Arabic: أضف مسافة بعد كل فاصلة.
        //Example (English): Input: 'a,b,c' -> Output: 'a, b, c'
        //------------------------------------------------------------
        // same here but i check if there is coma, if there is add space to it
        // and remove the last
        public static string AddSpaceAfterComma(string input)
        {
            string result = "";

            foreach (char character in input)
            {
                if (character == ',')
                {
                    result += ", ";
                }
                else
                {
                    result += character;
                }
            }
            return result;
        }

        //Exercise 40  :
        //English: Trim a string to a maximum of 10 characters.
        //Arabic: اقطع السلسلة إلى 10 أحرف كحد أقصى.
        //Example (English): Input: 'abcdefghijk' -> Output: 'abcdefghij'
        //------------------------------------------------------------
        //sol
        // i make a condition where input length should be less than 10
        public static string TrimToMax10Characters(string input)
        {
            if (input.Length > 10)
                return input.Substring(0, 10);  // ناخذ أول 10 حروف فقط

            return input;  // إذا أقل من 10، نرجع النص مثل ما هو
        }
        //Exercise 41  :
        //English: Extract phone number from a sentence.
        //Example (English): Input: 'Call me at 0791234567' -> Output: '0791234567'
        //------------------------------------------------------------
        // i make variable to store the pone number in it inly through h condition
        // that say it sould be digit

        public static string ExtractPhoneNumberFromSentence(string InputSentence)
        {
            string PhoneNumber = "";
            string InputResult = "";
            foreach (char character in InputSentence)
            {
                if (char.IsDigit(character))
                    PhoneNumber += character;
            }
            return PhoneNumber;
        }
        //Exercise 42  :
        //English: Format phone number to international style.
        //Example (English): Input: '+9647912345678' -> Output: '009647912345678'
        //------------------------------------------------------------
        // i replace + with 00
        public static string ConvertPhoneToInternationalFormat(string input)
        {
            return input.Replace("+", "00");
        }
        //Exercise 43  :
        //English: Parse a sentence and identify verbs.
        //Arabic: حلل الجملة لاكتشاف الأفعال.
        //Example (English): Input: 'I run and jump' -> Verbs: ['run', 'jump']
        //------------------------------------------------------------
        //

        //Exercise 44  :
        //English: Redact names from a document.
        //Arabic: احجب الأسماء من وثيقة.
        //Example (English): Input: 'Ali went to school.' -> Output: '[REDACTED] went to school.'
        //------------------------------------------------------------
        // i declare array of string with some names
        // for each nem in array we replace it with the word [REDACTED]
        public static string RedactNames(string document)
        {
            string[] NamesArray = { "Ali", "Mostafa", "Omar" };
            foreach (string name in NamesArray)
            {
                document = document.Replace(name, "[REDACTED]");
            }
            return document;
        }
        //Exercise 45  :
        //English: Detect language of a sentence.
        //Arabic: اكتشف لغة الجملة.
        //Example (English): Input: 'Hello, كيف حالك؟' -> Output: 'Arabic'
        //------------------------------------------------------------
        // if char == Unicode range for Arabic
        // we return arabic if its != we return english

        public static string DetectArabicLanguage(string sentence)
        {
            foreach (char character in sentence)
            {
                if (character >= 0x0600 && character <= 0x06FF) // Unicode range for Arabic
                {
                    return "Arabic";
                }
            }
            return "English";
        }
        //Exercise 46  :
        //English: Compare two strings ignoring punctuation.
        //Arabic: قارن بين سلسلتين مع تجاهل علامات الترقيم.
        //Example (English): Input: 'Hello!' vs 'Hello' -> Output: True
        //------------------------------------------------------------
        // first i delete the punctuation in strings
        // aafter that i check if its equall or not
        public static bool CompareIgnoringPunctuation(string str1, string str2)
        {
            string CleanStr1 = RemovePunctuation(str1);
            string CleanStr2 = RemovePunctuation(str2);

            return CleanStr1 == CleanStr2;
        }

        // function to remove all the Punctuation from string
        public static string RemovePunctuation(string input)
        {
            string Result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsPunctuation(input[i]))
                {
                    Result += input[i];
                }
            }
            return Result;
        }

        //Exercise 47  :
        //English: Generate acronym from a phrase.
        //Example (English): Input: 'World Health Organization' -> Output: 'WHO'
        //------------------------------------------------------------
        // split the sentence to words and convert first letter to capital and take it

        public static string GenerateAcronymFromPhrase(string phrase)
        {
            string[] words = phrase.Split(' ');
            string acronym = "";

            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                    acronym += char.ToUpper(word[0]);
            }

            return acronym;
        }
        //Exercise 48  :
        //English: Remove hashtags from a sentence.
        //Example (English): Input: 'great day #fun #sun' -> Output: 'great day fun sun'
        //------------------------------------------------------------
        //sol:
        // i use trim('#') to remove it from any place in the sentence
        // using for loop 
        public static string RemoveHashtags(string sentence)
        {
            string[] words = sentence.Split(' ');
            string SentenceWithoutHashtags = "";

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i].Trim('#');

                SentenceWithoutHashtags += word + " ";
            }
            return SentenceWithoutHashtags;
        }
        //Exercise 49  :
        //English: Extract mentions (e.g., @user) from text.
        //Arabic: استخرج الإشارات (مثل @user) من النص.
        //Example (English): Input: '@user1 hello @user2' -> Output: ['@user1', '@user2']
        //------------------------------------------------------------
        //i split the text and make for loop to return the word that start with@
        // and printing them together 
        public static string ExtractMentions(string text)
        {
            string[] words = text.Split(' ');
            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].StartsWith("@"))
                {
                    result += words[i] + " ";
                }
            }
            return result.TrimEnd();
        }
        //Exercise 50  :
        //English: Count number of hashtags in a sentence.
        //Example (English): Input: '#love #life' -> Output: 2
        //------------------------------------------------------------
        // check each character in input if its there i add the counter
        public static int NumberOfHashtagsInSentence(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '#')
                    counter++;
            }
            return counter;
        }
        // Exercise 51  :
        // English: Insert newline after every full stop.
        // Example (English): Input: 'Hi. How are you?' -> Output: 'Hi.\nHow are you?'
        // ------------------------------------------------------------
        // id i see . in the input i add new line
        public static string InsertNewLineAfterFullStop(string input)
        {
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                result += input[i];

                if (input[i] == '.')
                {
                    result += '\n'; // add new line after dot
                }
            }
            return result;
        }
        // Exercise 52  :
        // English: Reverse word order in a sentence.
        // Arabic: اعكس ترتيب الكلمات في جملة.
        // Example (English): Input: 'I am fine' -> Output: 'fine am I'
        // ------------------------------------------------------------
        // split the sentence and print them in reverse (i--)
        public static string ReverseWordsInSentence(string sentence)
        {
            string[] words = sentence.Split(' ');
            string result = "";

            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }

            return result.TrimEnd();
        }
        // Exercise 53  :
        // English: Sort words alphabetically in a sentence.
        // Example (English): Input: 'banana apple' -> Output: 'apple banana'
        // ------------------------------------------------------------
        public static string SortWordsInSentence(string sentence)
        {
            string[] words = sentence.Split(' ');
            Array.Sort(words); 

            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                result += words[i] + " ";
            }

            return result.TrimEnd();
        }
        // Exercise 54  :
        // English: Generate a slug from a title.
        // Example (English): Input: 'My Title' -> Output: 'my-title'
        // ------------------------------------------------------------
        public static string GenerateSlug(string title)

        {
            //put the title in smallcace and split it
            string[] words = title.ToLower().Split(' '); 
            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                result += words[i];

                if (i != words.Length - 1)
                {
                    // add - between words
                    result += "-"; 
                }
            }

            return result;
        }

        // Exercise 55  :
        // English: Count the number of uppercase letters.
        // Arabic: احسب عدد الحروف الكبيرة.
        // Example (English): Input: 'Hi There' -> Output: 2
        // ------------------------------------------------------------
        // sol 
        public static int NumberOfUppercaseCharacters(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                    counter++;
            }
            return counter;
        }
        // Exercise 56  :
        // English: Replace numbers with words (e.g., 3 -> three).
        // Arabic: استبدل الأرقام بكلماتها(مثال: 3 ← ثلاثة).
        // Example(English) : Input: '3 cats' -> Output: 'three cats'
        // ------------------------------------------------------------
        // Exercise 57  :
        // English: Find palindromic words in a paragraph.
        // Arabic: اكتشف الكلمات العكسية في فقرة.
        // Example (English): Input: 'madam racecar hello' -> Output: ['madam', 'racecar']
        // ------------------------------------------------------------
        // Exercise 58  :
        // English: Replace tabs with 4 spaces.
        // Arabic: استبدل علامات الجدولة بـ 4 فراغات.
        // Example (English): Input: '\tTab' -> Output: '    Tab'
        // ------------------------------------------------------------
        // Exercise 59  :
        // English: Check if string is valid JSON.
        // Arabic: تحقق مما إذا كانت السلسلة بصيغة JSON صحيحة.
        // Example (English): Input: '{"key": 123}' -> Output: Valid
        // ------------------------------------------------------------
        // Exercise 60  :
        // English: Check if string is a valid URL.
        // Arabic: تحقق مما إذا كانت السلسلة رابط URL صحيح.
        // Example (English): Input: 'https://openai.com' -> Output: Valid
        //         ------------------------------------------------------------
        //         Exercise 61  :
        //         English: Remove HTML tags from a string.
        //         Arabic: احذف الوسوم HTML من السلسلة.
        //         Example (English): Input: '<p>Hello</p>' -> Output: 'Hello'
        //م ث ا      ل  (بالعربية): الإدخال: '<p>Hello</p>' ← الناتج: 'Hello'
        //         ------------------------------------------------------------
        //         Exercise 62  :
        //         English: Convert markdown to plain text.
        //         Arabic: حوّل markdown إلى نص عادي.
        //         Example (English): Input: '**Bold**' -> Output: 'Bold'
        //م ث ا      ل  (بالعربية): الإدخال: '**Bold**' ← الناتج: 'Bold'
        //         ------------------------------------------------------------
        //         Exercise 63  :
        //         English: Detect and correct common typos.
        //         Arabic: اكتشف وصحح الأخطاء الإملائية الشائعة.
        //         Example (English): Input: 'teh' -> Output: 'the'
        //م ث ا      ل  (بالعربية): الإدخال: 'teh' ← الناتج: 'the'
        //         ------------------------------------------------------------
        //         Exercise 64  :
        //         English: Validate password strength.
        //         Arabic: تحقق من قوة كلمة المرور.
        //         Example (English): Input: 'Pass123!' -> Output: Strong
        //م ث ا      ل  (بالعربية): الإدخال: 'Pass123!' ← الناتج: قوية
        //         ------------------------------------------------------------
        //         Exercise 65  :
        //         English: Remove non-English characters.
        //         Arabic: احذف الأحرف غير الإنجليزية.
        //         Example (English): Input: 'مرحبا' -> Output: ''
        //م ث ا      ل  (بالعربية): الإدخال: 'مرحبا' ← الناتج: ''
        //         ------------------------------------------------------------
        //         Exercise 66  :
        //         English: Extract YouTube video ID from a URL.
        //         Arabic: استخرج رمز فيديو YouTube من الرابط.
        //         Example (English): Input: 'https://youtu.be/abc123' -> Output: 'abc123'
        //م ث ا      ل  (بالعربية): الإدخال: 'https://youtu.be/abc123' ← الناتج: 'abc123'
        //         ------------------------------------------------------------
        //         Exercise 67  :
        //         English: Shorten text to a summary (first sentence).
        //         Arabic: اختصر النص إلى الجملة الأولى.
        //         Example (English): Input: 'Hello. How are you?' -> Output: 'Hello.'
        //م ث ا      ل  (بالعربية): الإدخال: 'Hello. How are you?' ← الناتج: 'Hello.'
        //         ------------------------------------------------------------
        //         Exercise 68  :
        //         English: Check for repeated words.
        //         Arabic: تحقق من الكلمات المكررة.
        //         Example (English): Input: 'hello hello' -> Output: True
        //م ث ا      ل  (بالعربية): الإدخال: 'hello hello' ← الناتج: صحيح
        //         ------------------------------------------------------------
        //         Exercise 69  :
        //         English: Remove stop words from sentence.
        //         Arabic: احذف كلمات التوقف من الجملة.
        //         Example (English): Input: 'this is a test' -> Output: 'test'
        //م ث ا      ل  (بالعربية): الإدخال: 'this is a test' ← الناتج: 'test'
        //         ------------------------------------------------------------
        //         Exercise 70  :
        //         English: Translate string from English to Arabic.
        //         Arabic: ترجم النص من الإنجليزية إلى العربية.
        //         Example (English): Input: 'Hello' -> Output: 'مرحبا'
        //م ث ا      ل  (بالعربية): الإدخال: 'Hello' ← الناتج: 'مرحبا'
        //         ------------------------------------------------------------
        //         Exercise 71  :
        //         English: Extract quoted text from a paragraph.
        //         Arabic: استخرج النص المقتبس من فقرة.
        //         Example (English): Input: 'He said "hello"' -> Output: '"hello"'
        //م ث ا      ل  (بالعربية): الإدخال: 'He said "hello"' ← الناتج: '"hello"'
        //         ------------------------------------------------------------
        //         Exercise 72  :
        //         English: Convert text to Morse code.
        //         Arabic: حوّل النص إلى شيفرة مورس.
        //         Example (English): Input: 'SOS' -> Output: '... --- ...'
        //م ث ا      ل  (بالعربية): الإدخال: 'SOS' ← الناتج: '... --- ...'
        //         ------------------------------------------------------------
        //         Exercise 73  :
        //         English: Check for profanity in string.
        //         Arabic: تحقق من وجود كلمات نابية في النص.
        //         Example (English): Input: 'badword here' -> Output: True
        //م ث ا      ل  (بالعربية): الإدخال: 'badword here' ← الناتج: صحيح
        //         ------------------------------------------------------------
        //         Exercise 74  :
        //         English: Encrypt a message using Caesar cipher.
        //         Arabic: شفّر رسالة باستخدام شيفرة قيصر.
        //         Example(English): Input: 'abc' -> Output: 'def'
        //م ثا       ل (بالعربية) : الإدخال: 'abc' ← الناتج: 'def'
        //         ------------------------------------------------------------
        //         Exercise 75  :
        //         English: Decrypt Caesar cipher text.
        //         Arabic: فك شفرة قيصر من نص مشفر.
        //         Example (English): Input: 'def' -> Output: 'abc'
        //م ث ا      ل  (بالعربية): الإدخال: 'def' ← الناتج: 'abc'
        //         ------------------------------------------------------------
        //         Exercise 76  :
        //         English: Identify email provider from email address.
        //         Arabic: استخرج مزود البريد من العنوان.
        //         Example (English): Input: 'user@gmail.com' -> Output: 'gmail.com'
        //م ث ا      ل  (بالعربية): الإدخال: 'user@gmail.com' ← الناتج: 'gmail.com'
        //         ------------------------------------------------------------
        //         Exercise 77  :
        //         English: Normalize accented characters (é -> e).
        //         Arabic: حوّل الأحرف المُعلمة إلى شكلها الطبيعي(é ← e).
        //         Example(English) : Input: 'José' -> Output: 'Jose'
        //م ثا       ل (بالعربية) : الإدخال: 'José' ← الناتج: 'Jose'
        //         ------------------------------------------------------------
        //         Exercise 78  :
        //         English: Split text into sentences.
        //         Arabic: قسّم النص إلى جمل.
        //         Example (English): Input: 'Hi. Bye.' -> Output: ['Hi.', 'Bye.']
        //م ث ا      ل  (بالعربية): الإدخال: 'Hi. Bye.' ← الناتج: ['Hi.', 'Bye.']
        //         ------------------------------------------------------------
        //         Exercise 79  :
        //         English: Extract numbers from string and sum them.
        //         Arabic: استخرج الأرقام من النص واجمعها.
        //         Example (English): Input: '3, 4, and 5' -> Output: 12
        //م ث ا      ل  (بالعربية): الإدخال: '3, 4, and 5' ← الناتج: 12
        //         ------------------------------------------------------------
        //         Exercise 80  :
        //         English: Detect palindrome phrases (with spaces).
        //         Arabic: تحقق من وجود عبارات معكوسة.
        //         Example (English): Input: 'A man a plan a canal Panama' -> Output: True
        //م ث ا      ل  (بالعربية): الإدخال: 'A man a plan a canal Panama' ← الناتج: صحيح
        //         ------------------------------------------------------------
        //         Exercise 81  :
        //         English: Format sentence with proper punctuation.
        //         Arabic: نسّق الجملة بعلامات الترقيم الصحيحة.
        //         Example (English): Input: 'hello world' -> Output: 'Hello world.'
        //م ث ا      ل  (بالعربية): الإدخال: 'hello world' ← الناتج: 'Hello world.'
        //         ------------------------------------------------------------
        //         Exercise 82  :
        //         English: Create string preview with ellipsis (...).
        //         Arabic: أنشئ معاينة للنص مع(...) إذا طال.
        //         Example(English): Input: 'This is long text' -> Output: 'This is long...'
        //م ثا       ل (بالعربية) : الإدخال: 'This is long text' ← الناتج: 'This is long...'
        //         ------------------------------------------------------------
        //         Exercise 83  :
        //         English: Find most common letter in text.
        //         Arabic: اكتشف الحرف الأكثر تكرارًا.
        //         Example(English): Input: 'apple banana apple' -> Output: 'a'
        //م ثا       ل (بالعربية) : الإدخال: 'apple banana apple' ← الناتج: 'a'
        //         ------------------------------------------------------------
        //         Exercise 84  :
        //         English: Replace proper names with placeholders.
        //         Arabic: استبدل الأسماء الخاصة بعناصر عامة.
        //         Example(English): Input: 'Ali went home' -> Output: '[NAME] went home'
        //م ثا       ل (بالعربية) : الإدخال: 'Ali went home' ← الناتج: '[NAME] went home'
        //         ------------------------------------------------------------
        //         Exercise 85  :
        //         English: Add timestamp to beginning of sentence.
        //         Arabic: أضف توقيتًا لبداية الجملة.
        //         Example (English): Input: 'Meeting starts' -> Output: '[08:00] Meeting starts'
        //م ث ا      ل  (بالعربية): الإدخال: 'Meeting starts' ← الناتج: '[08:00] Meeting starts'
        //         ------------------------------------------------------------
        //         Exercise 86  :
        //         English: Align text to the center.
        //         Arabic: وسّط النص في السطر.
        //         Example (English): Input: 'Hi' -> Output: '  Hi  '
        //م ث ا      ل  (بالعربية): الإدخال: 'Hi' ← الناتج: '  Hi  '
        //         ------------------------------------------------------------
        //         Exercise 87  :
        //         English: Justify text to fixed width.
        //         Arabic: ضبط النص ليتناسب مع عرض معين.
        //         Example (English): Input: 'Align this' -> Output: 'Align  this'
        //م ث ا      ل  (بالعربية): الإدخال: 'Align this' ← الناتج: 'Align  this'
        //         ------------------------------------------------------------
        //         Exercise 88  :
        //         English: Count total lines in a paragraph.
        //         Arabic: احسب عدد الأسطر في فقرة.
        //         Example (English): Input: 'Line1\nLine2' -> Output: 2
        //م ث ا      ل  (بالعربية): الإدخال: 'Line1\nLine2' ← الناتج: 2
        //         ------------------------------------------------------------
        //         Exercise 89  :
        //         English: Detect questions in paragraph.
        //         Arabic: اكتشف الأسئلة داخل الفقرة.
        //         Example (English): Input: 'What is your name?' -> Output: True
        //م ث ا      ل  (بالعربية): الإدخال: 'What is your name?' ← الناتج: صحيح
        //         ------------------------------------------------------------
        //         Exercise 90  :
        //         English: Convert time format '2:30 PM' to 24h.
        //         Arabic: حوّل الوقت من '2:30 PM' إلى 24 ساعة.
        //         Example (English): Input: '2:30 PM' -> Output: '14:30'
        //م ث ا      ل  (بالعربية): الإدخال: '2:30 PM' ← الناتج: '14:30'
        //         ------------------------------------------------------------
        //         Exercise 91  :
        //         English: Extract hashtags and sort them.
        //         Arabic: استخرج الوسوم ورتبها.
        //         Example (English): Input: '#fun #life #code' -> Output: ['#code', '#fun', '#life']
        //م ث ا      ل  (بالعربية): الإدخال: '#fun #life #code' ← الناتج: ['#code', '#fun', '#life']
        //         ------------------------------------------------------------
        //         Exercise 92  :
        //         English: Add prefix to each word.
        //         Arabic: أضف بادئة لكل كلمة.
        //         Example (English): Input: 'run fast' -> Output: 'pre_run pre_fast'
        //م ث ا      ل  (بالعربية): الإدخال: 'run fast' ← الناتج: 'pre_run pre_fast'
        //         ------------------------------------------------------------
        //         Exercise 93  :
        //         English: Truncate email body after signature line.
        //         Arabic: اقطع نص البريد بعد السطر التوقيعي.
        //         Example (English): Input: 'Thanks\n--\nAli' -> Output: 'Thanks'
        //م ث ا      ل  (بالعربية): الإدخال: 'Thanks\n--\nAli' ← الناتج: 'Thanks'
        //         ------------------------------------------------------------
        //         Exercise 94  :
        //         English: Format bibliography entries from raw string.
        //         Arabic: نسّق مراجع من نص خام.
        //         Example (English): Input: 'Book: Python 101, Author: Ali' -> Output: Formatted Reference
        //م ث ا      ل  (بالعربية): الإدخال: 'Book: Python 101, Author: Ali' ← الناتج: مرجع منسق
        //         ------------------------------------------------------------
        //         Exercise 95  :
        //         English: Split string by multiple delimiters.
        //         Arabic: قسّم سلسلة باستخدام عدة فواصل.
        //         Example (English): Input: 'a;b,c|d' -> Output: ['a', 'b', 'c', 'd']
        //م ث ا      ل  (بالعربية): الإدخال: 'a;b,c|d' ← الناتج: ['a', 'b', 'c', 'd']
        //         ------------------------------------------------------------
        //         Exercise 96  :
        //         English: Validate IBAN number format.
        //         Arabic: تحقق من تنسيق رقم IBAN.
        //         Example (English): Input: 'IQ44 1234 5678 9012' -> Output: Valid IBAN
        //م ث ا      ل  (بالعربية): الإدخال: 'IQ44 1234 5678 9012' ← الناتج: IBAN صحيح
        //         ------------------------------------------------------------
        //         Exercise 97  :
        //         English: Match date in different formats.
        //         Arabic: طابق التواريخ بأنماط مختلفة.
        //         Example (English): Input: '2023/01/01' -> Output: '2023-01-01'
        //م ث ا      ل  (بالعربية): الإدخال: '2023/01/01' ← الناتج: '2023-01-01'
        //         ------------------------------------------------------------
        //         Exercise 98  :
        //         English: Tag product names in review text.
        //         Arabic: وسم أسماء المنتجات في مراجعة.
        //         Example (English): Input: 'I love my MacBook' -> Output: 'MacBook:PRODUCT'
        //م ث ا      ل  (بالعربية): الإدخال: 'I love my MacBook' ← الناتج: 'MacBook:PRODUCT'
        //         ------------------------------------------------------------
        //         Exercise 99  :
        //         English: Extract data from semi-colon separated fields.
        //         Arabic: استخرج بيانات مفصولة بفواصل منقوطة.
        //         Example (English): Input: 'field1;field2;field3' -> Output: ['field1', 'field2', 'field3']
        //م ث ا      ل  (بالعربية): الإدخال: 'field1;field2;field3' ← الناتج: ['field1', 'field2', 'field3']
        //         ------------------------------------------------------------
        //Exercise 100  :
        //English: Classify line as header or paragraph.
        //Arabic: صنّف السطر كعنوان أو فقرة.
        //Example (English): Input: '## Title' -> Output: 'Header'
        //------------------------------------------------------------

    }


}
