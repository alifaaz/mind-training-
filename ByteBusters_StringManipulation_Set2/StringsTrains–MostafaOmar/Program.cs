using System;

namespace StringsTrains_MostafaOmar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1  :
            int count = Solution.NumberOfCharacterInString("HI");
            Console.WriteLine($"number of characters in : '{count}'");

            //Exercise 2  :
            string input = "hello";
            Console.WriteLine($"input : '{input}' -> output : '{Solution.ConvertToUpper(input)}'");

            //Exercise 3  :
            Console.WriteLine($"input : '{Solution.ConvertToUpper(input)}'" +
                $" -> output : '{Solution.ConvertToLower(input)}'");

            //Exercise 4  :
            input = "welcome";
            string prefix = "wel";
            Console.WriteLine($"Input: '{input}', Prefix: '{prefix}' -> Output: {Solution.IsStartWithGivenPrefix(input,prefix)}");

            //Exercise 5 :
            input = "file.txt";
            string suffix = ".txt";
            Console.WriteLine($"Input: '{input}', Prefix: '{suffix}' -> Output: {Solution.IsEndtWithGivenSuffix(input, suffix)}");

            //Exercise 6 :
            input = "123456";
            Console.WriteLine($"Input: '{input}' -> Output: {Solution.IsStringOnlyDigits(input)}");
            
            //Exercise 7  :
            input = "abcdefg";
            Console.WriteLine($"Input: '{input}' -> Output: {Solution.IsStringOnlyLetters(input)}");
            
            //Exercise 8  :
            Console.WriteLine($"Input: '{input}' -> Output: {Solution.CapitalizeTheFirstCharacterOfString(input)}");

            //Exercise 9  :
            input = "Java Sicript";
            Console.WriteLine($"Input: '{input}' -> Output: {Solution.ReverseUpperToLowerAndLowerToUpper(input)}");

            //Exercise 10 :
            input = "hello world";
            Console.WriteLine($"Input: '{input}' -> Output: {Solution.SplitStringIntoWords(input)}");
            //Exercise 11 :
            input = "hello, world";
            Console.WriteLine($"input: '{input}' output: '{Solution.MergeWordsIntoString(input)}'");
            //Exercise 12 :
            input = "  hello  ";
            Console.WriteLine($"input: '{input}' output: '{Solution.RemovingSpacesFromString(input)}'");
            //Exercise 13 :
            input = "a b c";
            Console.WriteLine($"input: '{input}' output: '{Solution.NumberOfSpaces(input)}'");
            //Exercise 14  :
            input = "user@example.com";
            Console.WriteLine($"input: '{input}' output: '{Solution.CheckIfStringIsAnEmail(input)}'");
            //Exercise 15  :
            input = "abcdefg";
            Console.WriteLine($"input: '{input}' output: '{Solution.ReturnTheFirstFivecharacters(input)}'");
            //Exercise 16  :
            Console.WriteLine($"input: '{input}' output: '{Solution.ReturnTheLastThreecharacters(input)}'");
            //Exercise 17  :
            input = "a,b,c";
            Console.WriteLine($"input: '{input}' output: '{Solution.ReplaceComasWithSemicolons(input)}'");
            //Exercise 18  :
            string FirstWord = "listen";
            string SecondWord = "silent";
            Console.WriteLine($"input: '{FirstWord}' '{SecondWord}' output: '{Solution.CheckIfTwoStringsIsAnagrams(FirstWord, SecondWord)}'");
            //Exercise 19  :
            input = "a1b2c3";
            Console.WriteLine($"input: '{input}' output: '{Solution.FindAllDigit(input)}'");
            //Exercise 20  :
            input = "abc123";
            Console.WriteLine($"input: '{input}' output: '{Solution.FindAllLetters(input)}'");
            //Exercise 21  :
            input = "john.doe@example.com";
            //Console.WriteLine("Please enter your email:");
            //string inputEmail = Console.ReadLine();
            // try and catch
            try
            {
                Console.WriteLine("Masked email: " + Solution.MaskAnEmail(input));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            //Exercise 22  :
            input = "HI";
            Console.WriteLine($"input: '{input}' output: '{Solution.ConvertSenteceToListOfAsciiCodes(input)}'");
            //Exercise 23  :
            input = "hello hello world";
            Console.WriteLine($"input: '{input}' output: '{Solution.RemoveDuplicateWordsFromSentence(input)}'");
            //Exercise 24  :
            input = "s.pdf";
            Console.WriteLine($"input: '{input}' output: '{Solution.RemoveExtensionFromFileName(input)}'");
            //Exercise 25  :
            input = "hello\nworld";
            Console.WriteLine($"input: '{input}' output: '{Solution.ReplaceNewlineWithSpacesInString(input)}'");
            //Exercise 26  :
            input = "2024-02-01";
            Console.WriteLine($"input: '{input}' output: '{Solution.ConvertDateFormat(input)}'");
            //Exercise 27  :
            input = "banana";
            char TargetLetter = 'a';
            Console.WriteLine($"input: '{input}' , '{TargetLetter}' output: '{Solution.CountCharacterAppearingInString(input , TargetLetter)}'");
            //Exercise 28  :
            input = "@hello";
            Console.WriteLine($"input: '{input}' , '{TargetLetter}' output: '{Solution.ContainsSpecialCharacters(input)}'");
            //Exercise 29  :
            input = "snake_case";
            Console.WriteLine($"input: '{input}' output: '{Solution.SnakeToCamel(input)}'");
            //Exercise 30  :
            input = "camelCase";
            Console.WriteLine($"input: '{input}' output: '{Solution.CamelToSnake(input)}'");
            //Exercise 31  :
            input = "123bahe";
            Console.WriteLine($"input: '{input}' output: '{Solution.ReplaceAllNumericValuesInString(input)}'");
            //Exercise 32  :
            input = "Hello World"; // 2
            Console.WriteLine($"input: '{input}' output: '{Solution.CountWordsWithCapitalLetter(input)}'");
            //Exercise 33  :
            input = "education";
            Console.WriteLine($"input: '{input}' output: '{Solution.RemoveAllVowelsFromString(input)}'");
            //Exercise 34  :
            input = "   ";
            Console.WriteLine($"input: '{input}' output: '{Solution.IsStringContainOnlyWhitespace(input)}'");
            //Exercise 35  :
            input = "😊 Hello";
            Console.WriteLine($"input: '{input}' output: '{Solution.ReplaceEmojisWithTag(input)}'");
            //Exercise 36  :
            input = "1111";
            Console.WriteLine($"input: '{input}' output: '{Solution.ConvertBinaryToDecimal(input)}'");
            //Exercise 37  :
            input = "15";
            Console.WriteLine($"input: '{input}' output: '{Solution.ConvertDecimalToBinary(input)}'");
            //Exercise 38  :
            input = "abc";
            Console.WriteLine($"input: '{input}' output: '{Solution.CreateStringPattern(input)}'");
            //Exercise 39  :
            input = "a,b,c";
            Console.WriteLine($"input: '{input}' output: '{Solution.AddSpaceAfterComma(input)}'");
            //Exercise 40  :
            input = "01234567890123456";
            Console.WriteLine($"input: '{input}' output: '{Solution.TrimToMax10Characters(input)}'");
            //Exercise 41 :
            input = "Call me at 0791234567";
            Console.WriteLine($"input: '{input}' output: '{Solution.ExtractPhoneNumberFromSentence(input)}'");
            //Exercise 42  :
            input = "+9647912345678";
            Console.WriteLine($"input: '{input}' output: '{Solution.ConvertPhoneToInternationalFormat(input)}'");
            //Exercise 43  :
            //Exercise 44  :
            input = "Ali went to school.";
            Console.WriteLine($"input: '{input}' output: '{Solution.RedactNames(input)}'");
            //Exercise 45  :
            input = "Hello, كيف حالك؟";
            Console.WriteLine($"input: '{input}' output: '{Solution.DetectArabicLanguage(input)}'");
            //Exercise 46  :
            string input1 = "Hello!";
            string input2 = "Hello";
            Console.WriteLine($"input: '{input1}' vs '{input2}' output: '{Solution.CompareIgnoringPunctuation(input1,input2)}'");
            //Exercise 47  :
            input = "World Health Organization";
            Console.WriteLine($"input: '{input}' output: '{Solution.GenerateAcronymFromPhrase(input)}'");
            //Exercise 48  :
            input = "great day #fun #sun";
            Console.WriteLine($"input: '{input}' output: '{Solution.RemoveHashtags(input)}'");
            //Exercise 49  :
            input = "@user1 hello @user2";
            Console.WriteLine($"input: '{input}' output: '{Solution.ExtractMentions(input)}'");
            //Exercise 50  :
            input = "#love #life";
            Console.WriteLine($"input: '{input}' output: '{Solution.NumberOfHashtagsInSentence(input)}'");
            // Exercise 51  :
            input = "Hi. How are you?";
            Console.WriteLine($"input: '{input}' output: '{Solution.InsertNewLineAfterFullStop(input)}'");
            // Exercise 52  :
            input = "I am fine";
            Console.WriteLine($"input: '{input}' output: '{Solution.ReverseWordsInSentence(input)}'");
            // Exercise 53  :
            input = "banana apple";
            Console.WriteLine($"input: '{input}' output: '{Solution.SortWordsInSentence(input)}'");
            // Exercise 54  :
            input = "My Title";
            Console.WriteLine($"input: '{input}' output: '{Solution.GenerateSlug(input)}'");
            // Exercise 55  :
            input = "Hi There";
            Console.WriteLine($"input: '{input}' output: '{Solution.NumberOfUppercaseCharacters(input)}'");
           
        }
    }
}
