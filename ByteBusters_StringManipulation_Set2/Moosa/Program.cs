using System;

namespace StringsTrainings
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling WordApearingCounts method and print the count
            Console.WriteLine(Solutions.WordApearingCounts("apple","apple banana apple orange apple"));

            //calling ConvertToUpperCase method and print the result
            Console.WriteLine(Solutions.ConvertToUpperCase("moosa"));

            //calling ConvertToLowerCase method and print the result
            Console.WriteLine(Solutions.ConvertToLowerCase("MOOSA"));

            //calling IsStartsWith method and print the result
            Console.WriteLine(Solutions.IsStartsWith("wel","welcome"));

            //calling IsEndsWith method and print the result
            Console.WriteLine(Solutions.IsEndsWith("txt", "file.txt"));

            //calling IsContainOnlyDigits method and print the result
            Console.WriteLine(Solutions.IsContainOnlyDigits("12345"));

            //calling IsContainOnlyLetters method and print the result
            Console.WriteLine(Solutions.IsContainOnlyLetters("abcd"));

            //calling CapitalizeFirstLetter method and print the result
            Console.WriteLine(Solutions.CapitalizeFirstLetter("moosa"));

            //calling ChangeLetterCase method
            Console.WriteLine(Solutions.ChangeLetterCase("MoOsA"));

            //calling SplitString method
            Solutions.SplitString("apple banana apple orange apple");

            //calling JoinString method
            string[] text = { "C#", "Java", "C++" };
            Solutions.JoinString(text);

            //calling RemoveWhiteSpaces method and print the result
            Console.WriteLine(Solutions.RemoveWhiteSpaces(" Hello world "));

            //calling NumberOfSpaces method and print the result
            Console.WriteLine(Solutions.NumberOfSpaces("Hello World"));

            //calling GetFirst5Char method and print the result
            Console.WriteLine(Solutions.GetFirst5Char("Hello world!"));

            //calling GetLast3Char method and print the result
            Console.WriteLine(Solutions.GetLast3Char("Hello world!"));

            //calling ReplaceCommasWithSemicolons method and print the result
            Console.WriteLine(Solutions.ReplaceCommasWithSemicolons("1,2,3,4"));

            //calling AreAnagrams method and print the result
            Console.WriteLine(Solutions.AreAnagrams("listen","silent"));

            //calling FindDigits method and print the result
            Console.WriteLine(Solutions.FindDigits("as65af36"));

            //calling FindLetters method and print the result
            Console.WriteLine(Solutions.FindLetters("as65af36"));

            //calling MaskEmail method and print the result
            Console.WriteLine(Solutions.MaskEmail("tenhst@example.com"));

            //calling ExtractExtension method and print the result
            Console.WriteLine(Solutions.ExtractExtension("image.jpg"));

            //calling ConvertToASCII method and print the result
            Console.WriteLine(Solutions.ConvertToASCII("A B"));

            //calling RemoveDuplicateWords method and print the result
            Console.WriteLine(Solutions.RemoveDuplicateWords("hello hello world"));

            //calling ReplaceNewlinesWithSpaces method and print the result
            Console.WriteLine(Solutions.ReplaceNewlinesWithSpaces("hello\nworld"));

            //calling ConvertDateFrom method and print the result
            Console.WriteLine(Solutions.ConvertDateFrom("2024-01-01"));

            //calling LetterApearingCounts method and print the result
            Console.WriteLine(Solutions.LetterApearingCounts('a'));

            //calling IsContainsSpecialchar method and print the result
            Console.WriteLine(Solutions.IsContainsSpecialchar("$"));

            //calling CovertSnakeToCamel method and print the result
            Console.WriteLine(Solutions.CovertSnakeToCamel("my_name"));

            //calling CamelToSnake method and print the result
            Console.WriteLine(Solutions.CamelToSnake("myName"));

            //calling ReplaceDigitsWithHash method and print the result
            Console.WriteLine(Solutions.ReplaceDigitsWithHash("abcd123"));

            //calling RemoveVowels method and print the result
            Console.WriteLine(Solutions.RemoveVowels("hello"));

            //calling IsOnlyWhiteSpaces method and print the result
            Console.WriteLine(Solutions.IsOnlyWhiteSpaces("   "));

            //calling BinaryToDecimal method and print the result
            Console.WriteLine(Solutions.BinaryToDecimal("101"));

            //calling DecimalToBinary method and print the result
            Console.WriteLine(Solutions.DecimalToBinary("8"));

            //calling CreatePattern method and print the result
            Console.WriteLine(Solutions.CreatePattern("abc"));

            //calling AddSpaceAfterComma method and print the result
            Console.WriteLine(Solutions.AddSpaceAfterComma("a,b,c"));

            //calling TrimOnly10char method and print the result
            Console.WriteLine(Solutions.TrimOnly10char("abcdefghijklmn"));

            //calling ExtractPhoneNumber method and print the result
            Console.WriteLine(Solutions.ExtractPhoneNumber("Call me at 0791234567"));

            //calling ChangePhoneNumberFormat method and print the result
            Console.WriteLine(Solutions.ChangePhoneNumberFormat("+9647912345678"));

            //calling CompareIgnoringPunctuation method and print the result
            Console.WriteLine(Solutions.CompareIgnoringPunctuation("Hello","Hello!"));

            //calling GenerateAcronym method and print the result
            Console.WriteLine(Solutions.GenerateAcronym("World Health Organization"));

            //calling RemoveHashtags method and print the result
            Console.WriteLine(Solutions.RemoveHashtags("great day #fun #sun"));

            //calling ExtractMentions method and print the result
            Console.WriteLine(Solutions.ExtractMentions("@user1 hello @user2"));

            //calling CountNumberHashtags method and print the result
            Console.WriteLine(Solutions.CountNumberHashtags("#love #life"));

            //calling InsertNewline method and print the result
            Console.WriteLine(Solutions.InsertNewline("Hi. How are you?"));

            //calling ReverseWordOrder method and print the result
            Console.WriteLine(Solutions.ReverseWordOrder("I am fine"));

            //calling SortWords method and print the result
            Console.WriteLine(Solutions.SortWords("ban apl"));

            //calling GenerateSlug method and print the result
            Console.WriteLine(Solutions.GenerateSlug("My Title"));

            //calling IsUpperCase method and print the result
            Console.WriteLine(Solutions.CountUpperCase("Hi There"));

            //calling ReplaceNumbersWithWords method and print the result
            Console.WriteLine(Solutions.ReplaceNumbersWithWords("3 cats"));

            //calling PalindromicWords method and print the result
            Console.WriteLine(Solutions.PalindromicWords("madam racecar hello"));

            //calling ReplaceTabs method and print the result
            Console.WriteLine(Solutions.ReplaceTabs("\tTab"));

            //calling RemoveNonEnglishCharacters method and print the result
            Console.WriteLine(Solutions.RemoveNonEnglishCharacters("مرحباA"));

            Console.WriteLine(Solutions.ExtractVideoID("https://youtu.be/abc123"));

            //calling SumExtractNumbers method and print the result
            Console.WriteLine(Solutions.SumExtractNumbers("6abc123"));

            //calling CaeserCipher method and print the result
            Console.WriteLine(Solutions.CaeserCipher("abcx"));

            //calling DecryptCaeserCipher method and print the result
            Console.WriteLine(Solutions.DecryptCaeserCipher("defa"));

            //calling EmailProvider method and print the result
            Console.WriteLine(Solutions.EmailProvider("user@gmail.com"));
        }
    }
}
