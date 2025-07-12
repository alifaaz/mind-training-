using System;

namespace regex_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.Write("Enter your phone number: ");
            //string UserInput = Console.ReadLine();

            //Console.WriteLine(RegecFunctions.MatchAllPhoneNumberInLocalFormat(UserInput));

            //Console.Write("Enter your Email Address: ");
            //string UserInput = Console.ReadLine();
            //2
            //Console.WriteLine(RegecFunctions.MatchAllEmailAddress(UserInput));
            //3
            //Console.Write("Enter words: ");
            //string UserInput = Console.ReadLine();
            //RegecFunctions.MatchAnyWordStartWithCapitalLetter(UserInput);

            //4
            string UserInput = "I have 2 cats and 10 chickens.";
            Console.WriteLine(RegecFunctions.MatchAllNumbers(UserInput));
            //5
            UserInput = "#blessed #codingLife";
            Console.WriteLine(RegecFunctions.MatchAllHashtags(UserInput));
            //6
            UserInput = "I am coding, running, and learning.";
            Console.WriteLine(RegecFunctions.MatchAllWordEndWithIng(UserInput));

            //7
            UserInput = "I spent $100 on food and $29.99 on drinks.";
            RegecFunctions.FindAllCirrencyAmount(UserInput);
            //8
            UserInput = "The meeting is at 12:30.";
            RegecFunctions.MatchAllTime(UserInput);
            //9
            UserInput = "Today is 2025-07-10";
            Console.WriteLine(RegecFunctions.MatchDates(UserInput));
            //10
            UserInput = " هذه كلمة عربية.";
            Console.WriteLine(RegecFunctions.FindArabicWords(UserInput));
            //11
            UserInput = "unknown, unhappy, unlocked";
            Console.WriteLine(RegecFunctions.FindWordsStartWithUn(UserInput));
            //12
            UserInput = "ئەمە وشەیەکی کوردییە";
            Console.WriteLine(RegecFunctions.FindKurdishWords(UserInput));
            //13
            UserInput = "Ali123";
            Console.WriteLine(RegecFunctions.ValidateUserName(UserInput));

            //14
            UserInput = "<div>Hello</div>";
            Console.WriteLine(RegecFunctions.MatchAntHtmlTag(UserInput));

            //15
            UserInput = "How are you? Is this okay?";
            Console.WriteLine(RegecFunctions.MatchAnySentenceEndingWithQuestionMark(UserInput));
            //16
            UserInput = "this is is a test";
            Console.WriteLine(RegecFunctions.FindDuplicateWords(UserInput));

            //17
            UserInput = "photo.jpg, resume.pdf";
            Console.WriteLine(RegecFunctions.ExtractValidFileExtensions(UserInput));
            //18
            UserInput = "ب 12345";
            Console.WriteLine(RegecFunctions.MatchIraqiLicensePlates(UserInput));
            //19
            UserInput = "تَجْرِبَةٌ";
            Console.WriteLine(RegecFunctions.FindWordsWithDiacritics(UserInput));
            //20
            UserInput = "Visit https://halal.io today!";
            Console.WriteLine(RegecFunctions.ExtractURLs(UserInput));
            //21
            UserInput = "aA1!1234";
            Console.WriteLine(RegecFunctions.ValidateStrongPassword(UserInput));
            //25
            UserInput = "سعره ١٢٣ د.ع";
            Console.WriteLine(RegecFunctions.MatchArabicNumerals(UserInput));
            //26
            UserInput = "loooool, yessss";
            Console.WriteLine(RegecFunctions.MatchRepeatedCharacters(UserInput));
            //27
            UserInput = "بسم الله الرحمن الرحيم";
            Console.WriteLine(RegecFunctions.ExtractQuranicBasmalah(UserInput));

        }

    }
}


    