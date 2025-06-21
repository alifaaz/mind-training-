using System;
using System.ComponentModel;


namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n---1---");
            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum(3, 2));
            Console.WriteLine(Sum(2, 2));

            Console.WriteLine("\n---2---");
            Console.WriteLine(AbsoluteDifference(53));
            Console.WriteLine(AbsoluteDifference(30));
            Console.WriteLine(AbsoluteDifference(51));

            Console.WriteLine("\n---3---");
            Console.WriteLine(IsThirty(30, 0));
            Console.WriteLine(IsThirty(25, 5));
            Console.WriteLine(IsThirty(20, 30));
            Console.WriteLine(IsThirty(20, 25));

            Console.WriteLine("\n---4---");
            Console.WriteLine(IsWithin10Of100Or200(103));
            Console.WriteLine(IsWithin10Of100Or200(90));
            Console.WriteLine(IsWithin10Of100Or200(89));

            Console.WriteLine("\n---5---");
            Console.WriteLine(IsIfFront("if else"));
            Console.WriteLine(IsIfFront("else"));

            Console.WriteLine("\n---6---");
            Console.WriteLine(RemoveCharacterAtGivenPosition("Python", 1));
            Console.WriteLine(RemoveCharacterAtGivenPosition("Python", 0));
            Console.WriteLine(RemoveCharacterAtGivenPosition("Python", 4));

            Console.WriteLine("\n---7---");
            Console.WriteLine(ExchangeFirstAndLastCharacters("abcd"));
            Console.WriteLine(ExchangeFirstAndLastCharacters("a"));
            Console.WriteLine(ExchangeFirstAndLastCharacters("xy"));

            Console.WriteLine("\n---8---");
            Console.WriteLine(CopyFirstTwoCharacters("C Sharp"));
            Console.WriteLine(CopyFirstTwoCharacters("JS"));
            Console.WriteLine(CopyFirstTwoCharacters("a"));

            Console.WriteLine("\n---9---");
            Console.WriteLine(LastCharAddFrontAndBack("Red"));
            Console.WriteLine(LastCharAddFrontAndBack("Green"));
            Console.WriteLine(LastCharAddFrontAndBack("1"));

            Console.WriteLine("\n---10---");
            Console.WriteLine(MultipleOf7Or3(3));
            Console.WriteLine(MultipleOf7Or3(14));
            Console.WriteLine(MultipleOf7Or3(12));
            Console.WriteLine(MultipleOf7Or3(37));

            Console.WriteLine("\n---11---");
            Console.WriteLine(First3Characters("Python"));
            Console.WriteLine(First3Characters("JS"));
            Console.WriteLine(First3Characters("Code"));

            Console.WriteLine("\n---12---");
            Console.WriteLine(IsStartWithCSharp("C# Sharp"));
            Console.WriteLine(IsStartWithCSharp("C#"));
            Console.WriteLine(IsStartWithCSharp("C++"));

            Console.WriteLine("\n---13---");
            Console.WriteLine(CheckWeather(120, -1));
            Console.WriteLine(CheckWeather(-1, 120));
            Console.WriteLine(CheckWeather(2, 120));

            Console.WriteLine("\n---14---");
            Console.WriteLine(CheckRange100To200(100, 199));
            Console.WriteLine(CheckRange100To200(250, 300));
            Console.WriteLine(CheckRange100To200(105, 190));

            Console.WriteLine("\n---15---");
            Console.WriteLine(CheckRange20To50(11, 20, 12));
            Console.WriteLine(CheckRange20To50(30, 30, 17));
            Console.WriteLine(CheckRange20To50(25, 35, 50));
            Console.WriteLine(CheckRange20To50(15, 12, 8));

            Console.WriteLine("\n---16---");
            Console.WriteLine(CheckRange2Num20To50(20, 84));
            Console.WriteLine(CheckRange2Num20To50(14, 50));
            Console.WriteLine(CheckRange2Num20To50(11, 45));
            Console.WriteLine(CheckRange2Num20To50(25, 40));

            Console.WriteLine("\n---17---");
            Console.WriteLine(CheckIndex1yt("Python"));
            Console.WriteLine(CheckIndex1yt("ytade"));
            Console.WriteLine(CheckIndex1yt("jsues"));

            Console.WriteLine("\n---18---");
            Console.WriteLine(MaxNumber(1, 2, 3));
            Console.WriteLine(MaxNumber(1, 3, 2));
            Console.WriteLine(MaxNumber(1, 1, 1));
            Console.WriteLine(MaxNumber(1, 2, 2));

            Console.WriteLine("\n---19---");
            Console.WriteLine(ClosetNumberTo100(78, 95));
            Console.WriteLine(ClosetNumberTo100(95, 95));
            Console.WriteLine(ClosetNumberTo100(99, 70));

            Console.WriteLine("\n---20---");
            Console.WriteLine(CheckRange40to50Or50to60(78, 95));
            Console.WriteLine(CheckRange40to50Or50to60(25, 35));
            Console.WriteLine(CheckRange40to50Or50to60(40, 50));
            Console.WriteLine(CheckRange40to50Or50to60(55, 60));

            Console.WriteLine("\n---21---");
            Console.WriteLine(CheckLargestNumberRange20to30(78, 95));
            Console.WriteLine(CheckLargestNumberRange20to30(20, 30));
            Console.WriteLine(CheckLargestNumberRange20to30(21, 25));
            Console.WriteLine(CheckLargestNumberRange20to30(28, 28));

            Console.WriteLine("\n---22---");
            Console.WriteLine(CountZ("frizz"));
            Console.WriteLine(CountZ("zane"));
            Console.WriteLine(CountZ("Zazz"));
            Console.WriteLine(CountZ("false"));
            Console.WriteLine(CountZ("zzzz"));
            Console.WriteLine(CountZ("ZZZZ"));

            Console.WriteLine("\n---23---");
            Console.WriteLine(CheckLastDigit(123, 456));
            Console.WriteLine(CheckLastDigit(12, 512));
            Console.WriteLine(CheckLastDigit(7, 87));
            Console.WriteLine(CheckLastDigit(12, 45));

            Console.WriteLine("\n---24---");
            Console.WriteLine(UppercaseLast3Digits("Python"));
            Console.WriteLine(UppercaseLast3Digits("Javascript"));
            Console.WriteLine(UppercaseLast3Digits("js"));
            Console.WriteLine(UppercaseLast3Digits("PHP"));

            Console.WriteLine("\n---25---");
            Console.WriteLine(StringNCopy("JS", 2));
            Console.WriteLine(StringNCopy("JS", 3));
            Console.WriteLine(StringNCopy("JS", 1));

            //------------Round 2-----------
            Console.WriteLine("\n---1---");
            Console.WriteLine(Round2.CheckEquality(5, 5));

            Console.WriteLine("\n---2---");
            Console.WriteLine(Round2.CheckEvenOrOddNumber(15));

            Console.WriteLine("\n---3---");
            Console.WriteLine(Round2.CheckPositiveOrNegativeNumber(14));

            Console.WriteLine("\n---4---");
            Console.WriteLine(Round2.CheckLeapYear(2016));

            Console.WriteLine("\n---5---");
            Console.WriteLine(Round2.CheckCandidate(21));

            Console.WriteLine("\n---6---");
            Console.WriteLine(Round2.DisplayN(-5));

            Console.WriteLine("\n---7---");
            Console.WriteLine(Round2.CategorizeHeight(135));

            Console.WriteLine("\n---8---");
            Console.WriteLine(Round2.FindMaxNumber(25, 63, 10));

            Console.WriteLine("\n---9---");
            Console.WriteLine(Round2.DetermineQuadrant(7, 9));
        }

        //1.Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.
        //Sample Input => Expected Output:
        //1, 2  => o/p  3
        //3, 2 => o/p  5
        //2, 2 => o/p  12
        static int Sum(int x, int y)
        {
            if (x == y)
            {
                return (x + y) * 3;
            }
            else
            {
                return x + y;
            }
        }


        //2. Write a C# Sharp program to get the absolute difference between n and 51. If n is broader than 51 return triple the absolute difference.
        //Sample Input => Expected Output:
        //53 => o/p  6
        //30 => o/p  21
        //51 => o/p  0
        static int AbsoluteDifference(int x)
        {
            if (x > 51) { return (x - 51) * 3; }
            else { return 51 - x; }
        }

        //3. Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
        //Sample Input => Expected Output:
        //30, 0  => o/p  True
        //25, 5  => o/p  True
        //20, 30  => o/p  True
        //20, 25  => o/p  False
        static bool IsThirty(int x, int y)
        {
            return (x == 30 || y == 30 || x + y == 30);
        }

        //4. Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
        //Sample Input => Expected Output:
        //103 => o/p  True
        //90 => o/p  True
        //89 => o/p  False
        static bool IsWithin10Of100Or200(int x)
        {
            return ((Math.Abs(x - 100) <= 10) || (Math.Abs(x - 200) <= 10));
        }

        //5. Write a C# Sharp program to create a string where 'if' is added to the front of a given string. If the string already begins with 'if', return it unchanged.
        //Sample Input => Expected Output:
        //"if else" => o/p if else
        //"else" => o/p if else
        static string IsIfFront(string x)
        {
            if (x.StartsWith("if")) { return x; } else { return "if " + x; }
        }

        //6. Write a C# Sharp program to remove the character at a given position in the string. The given position will be in the range 0..(string length -1) inclusive.
        //Sample Input => Expected Output:
        //"Python", 1 => o/p Pthon
        //"Python", 0 => o/p ython
        //"Python", 4 => o/p Pythn
        static string RemoveCharacterAtGivenPosition(string word, int index)
        {
            return word.Remove(index, 1);
        }

        //7. Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
        //Sample Input => Expected Output:
        //"abcd" => o/p dbca
        //"a"    => o/p a
        //"xy"   => o/p yx
        static string ExchangeFirstAndLastCharacters(string word)
        {
            int wordLength = word.Length;

            return (wordLength <= 1 ? word : (word[wordLength - 1] + word.Substring(1, wordLength - 2) + word[0]));
        }

        //8. Write a C# Sharp program to create a string which is 4 copies of the 2 front characters of a given string. If the given string length is less than 2 return the original string.
        //Sample Input => Expected Output:
        //"C Sharp" => o/p C C C C 
        //"JS"      => o/p JSJSJSJS
        //"a"       => o/p a

        static string CopyFirstTwoCharacters(string word)
        {
            if (word.Length < 2) return word;
            else
            {
                string firstTwoCharacters = word[..2];
                //Ways of getting the first two characters of a string:
                //   1. word[..2] was Suggested by VS
                //   2. word.Remove(2)
                //   3. word.Substring(0,2)

                return (String.Concat(Enumerable.Repeat(firstTwoCharacters, 4)));
            }
        }

        //9. Write a C# Sharp program to create a string with the last char added at the front and back of a given string of length 1 or more
        //Sample Input => Expected Output:
        //"Red"   => o/p dRedd
        //"Green" => o/p nGreenn
        //"1"     => o/p 111
        static string LastCharAddFrontAndBack(string word)
        {
            //word[^1] = word[word.Length-1] Suggested by VS
            //I used ToString Method cause ther's gonna be a problem when concatenating char and string
            return word.Length < 1 ? word : word[^1].ToString() + word + word[^1].ToString();
        }

        //10. Write a C# Sharp program to check if a given positive number is a multiple of 3 or 7.
        //Sample Input => Expected Output:
        //3  => o/p True
        //14 => o/p True
        //12 => o/p True
        //37 => o/p False
        static bool MultipleOf7Or3(int number)
        {
            return (Math.Abs(number) % 3 == 0 || Math.Abs(number) % 7 == 0);
        }

        //11. Write a C# Sharp program to create a string taking the first 3 characters of a given string. Return the string with the 3 characters added at both the front and back. If the given string length is less than 3, use whatever characters are there.
        //Sample Input => Expected Output:
        //"Python" => o/p PytPythonPyt
        //"JS"     => o/p JSJSJS
        //"Code"   => o/p CodCodeCod
        static string First3Characters(string word)
        {
            return word.Length < 3 ?
                String.Concat(Enumerable.Repeat(word, 3))
                : String.Concat(word[..3], word, word[..3]);
        }

        //12. Write a C# Sharp program to check if a given string starts with 'C#' or not.
        //Sample Input => Expected Output:
        //"C# Sharp" => o/p True
        //"C#"       => o/p True
        //"C++"      => o/p False
        static bool IsStartWithCSharp(string word)
        {
            //CurrentCultureIgnoreCase To Ignore Case Sensitivity
            return word.StartsWith("C#", StringComparison.CurrentCultureIgnoreCase);
        }

        //13. Write a C# Sharp program that checks whether one temperature is less than 0 and another is greater than 100.
        //Sample Input => Expected Output:
        //120, -1 => o/p True
        //-1, 120 => o/p True
        //2, 120  => o/p False
        static bool CheckWeather(int temp1, int temp2)
        {
            return (temp1 < 0 && temp2 > 100)
                || (temp1 > 100 && temp2 < 0);
        }

        //14. Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.
        //Sample Input => Expected Output:
        //100, 199 => o/p True
        //250, 300 => o/p False
        //105, 190 => o/p True
        static bool CheckRange100To200(int num1, int num2)
        {
            return (num1 <= 200 && num1 >= 100)
                || (num2 <= 200 && num2 >= 100);
        }

        //15. Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive. Return true if 1 or more of them are in the said range otherwise false.
        //Sample Input => Expected Output:
        //11, 20, 12    => o/p True
        //30, 30, 17    => o/p True
        //25, 35, 50    => o/p True
        //15, 12, 8     => o/p False
        static bool CheckRange20To50(int num1, int num2, int num3)
        {
            return (num1 >= 20 && num1 <= 50)
                || (num2 >= 20 && num2 <= 50)
                || (num3 >= 20 && num3 <= 50);
        }

        //16. Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. Return true if 1 or other is in the range, otherwise false.
        //Sample Input => Expected Output:
        //20, 84  => o/p True
        //14, 50  => o/p True
        //11, 45  => o/p True
        //25, 40  => o/p False
        static bool CheckRange2Num20To50(int num1, int num2)
        {
            return (num1 >= 20 && num1 <= 50)
                ^ (num2 >= 20 && num2 <= 50);
        }

        //17. Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. If it appears return a string without 'yt' otherwise return the original string.
        //Sample Input => Expected Output:
        //"Python" => o/p Phon
        //"ytade"  => o/p ytade
        //"jsues"  => o/p jsues
        static string CheckIndex1yt(string word)
        {
            return (word.Length >= 3 && word.Substring(1, 2) == "yt") ? word[0] + word[3..] : word;
        }

        //18. Write a C# Sharp program to check the largest number among three given integers.
        //Sample Input => Expected Output:
        //1,2,3   => o/p 3
        //1,3,2   => o/p 3
        //1,1,1   => o/p 1
        //1,2,2   => o/p 2
        static int MaxNumber(int num1, int num2, int num3)
        {
            return Math.Max(num1, Math.Max(num2, num3));
        }

        //19. Write a C# Sharp program to check which number is closest to 100 among two given integers. Return 0 if the two numbers are equal.
        //Sample Input => Expected Output:
        //78, 95  => o/p 95
        //95, 95  => o/p 0
        //99, 70  => o/p 99
        static int ClosetNumberTo100(int num1, int num2)
        {
            int num1to100 = Math.Abs(num1 - 100);
            int num2to100 = Math.Abs(num2 - 100);

            if (num1to100 == num2to100) { return 0; }
            else
            {
                return (num1to100 < num2to100) ? num1 : num2;
            }
        }

        //20. Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive.
        //Sample Input => Expected Output:
        //78, 95  => o/p False
        //25, 35  => o/p False
        //40, 50  => o/p True
        //55, 60  => o/p True
        static bool CheckRange40to50Or50to60(int num1, int num2)
        {
            return (num1 >= 40 && num1 <= 50 && num2 >= 40 && num2 <= 50)
                    ||
                    (num1 >= 50 && num1 <= 60 && num2 >= 50 && num2 <= 60);
        }
        //21. Write a C# Sharp program to find the largest value from two positive integer values in the range 20..30 inclusive. Return 0 if neither is in that range.
        //Sample Input => Expected Output:
        //78, 95  => o/p 0
        //20, 30  => o/p 30
        //21, 25  => o/p 25
        //28, 28  => o/p 28
        static int CheckLargestNumberRange20to30(int num1, int num2)
        {
            return ((num1 > 20 && num2 < 30) || (num2 > 20 && num1 < 30) ? Math.Max(num1, num2) : 0);
        }

        //22. Write a C# Sharp program to check if a given string contains between 2 and 4 'z' characters.
        //Sample Input => Expected Output:
        //"frizz" => o/p True
        //"zane"  => o/p False
        //"Zazz"  => o/p True
        //"false" => o/p False
        //"zzzz"  => o/p True
        //"ZZZZ"  => o/p False
        static bool CountZ(string word)
        {
            int ZCount = word.Count(c => c == 'z');
            return ZCount >= 2 && ZCount <= 4;
        }

        //23. Write a C# Sharp program to check if two given non-negative integers have the same last digit.
        //Sample Input => Expected Output:
        //123, 456 => o/p False
        //12, 512  => o/p True
        //7, 87    => o/p True
        //12, 45   => o/p False
        static bool CheckLastDigit(int num1, int num2)
        {
            string num1String = num1.ToString();
            string num2String = num2.ToString();

            return num1String[^1] == num2String[^1];
        }

        //24. Write a C# Sharp program to convert the last 3 characters of a given string to uppercase. If the length of the string is less than 3, then uppercase all the characters.
        //Sample Input => Expected Output:
        //"Python"     => o/p PytHON
        //"Javascript" => o/p JavascrIPT
        //"js"         => o/p JS
        //"PHP"        => o/p PHP
        static string UppercaseLast3Digits(string word)
        {
            if (word.Length < 3) return word.ToUpper();
            else
            {
                return word.Substring(0, word.Length - 3) + word.Substring(word.Length - 3, 3).ToUpper();
            }
        }

        //25. Write a C# Sharp program to create a string which is n (non-negative integer) copies of a given string.
        //Sample Input => Expected Output:
        //"JS", 2 => o/p JSJS
        //"JS", 3 => o/p JSJSJS
        //"JS", 1 => o/p J
        static string StringNCopy(string word, int copy)
        {
            return String.Concat(Enumerable.Repeat(word, Math.Abs(copy)));
        }
    }
}

