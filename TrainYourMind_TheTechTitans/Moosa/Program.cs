using System;

namespace ConsoleApp1
{
    class Program
    {
        //First 25 questions

        /*
         التمرين 1
الفكرة والحل باستخدام if  تتم مقارنة رقمين اذا كانا متساويين يتم جمعهما وضرب الناتج بالعدد 3 وطباعته
        واذا  لم يكن الرقمين متساويين يتم فقط جمعهما وطباعة الناتج

         */
        static void TwoNumberSum (int number1, int number2) 
        {
            if (number1 == number2)
            {
                Console.WriteLine(3 * (number1 + number2));
            }
            else
            {
                Console.WriteLine(number1 + number2);
            }
        }
        static void AbsoluteDifference (int number)
        {
            if (number < 51)
            {
                Console.WriteLine(51 - number);
            }
            else
            {
                Console.WriteLine(3*(number - 51));
            }
        }
        static void IsThirty (int number1, int number2)
        {
            if (number1 == 30 || number2 == 30 || number1 + number2 == 30)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);
        }
        static void CheckInt (int number)
        {
            if (number>0 && number < 10 || number > 100 && number < 110 || number > 200 && number < 210)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);
        }
        static void AddIf (String word)
        {
            if (word[0] == 'i' && word[1] == 'f')
            {
                Console.WriteLine(word);
            }
            else Console.WriteLine("if " + word);
        }
        static void RemoveChar(int index, String word)
        {
            Console.WriteLine(word.Remove(index)+word.Substring(index+1));      
        }
        static void ExchangeChar (String word)
        {
            for (int i = 0; i < word.Length; i++) 
            {   
                if (i == 0)
                {
                    Console.Write(word[word.Length - 1]);
                }
                else if (i == word.Length - 1)
                {
                    Console.Write(word[0]);
                }
                else Console.Write(word[i]);

            }
            Console.WriteLine();
        }
        static void Str4Copies (String word)
        {
            char[] NewWord = new char[2];
            for (int i = 0; i < 2; i++)
            {
                NewWord[i] = word[i];
            }
            for (int i =0; i < 4; i++)
            {
                Console.Write(NewWord);
            }
            Console.WriteLine();
        }
        static void StrAddchar (String word) {
            Console.WriteLine(word[word.Length-1] + word + word[word.Length-1]);
        }
        static void Multiple3or7(int number)
        {
            if (number % 3 == 0 || number % 7 == 0)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }
        static void StrAdd3Char (String word)
        {
            char[] First3Char = new char[3];
            for (int i = 0; i < 3; i++)
            {
                First3Char[i] = word[i];
            }
            Console.Write(First3Char);
            Console.Write(word);
            Console.WriteLine(First3Char);
        }
        static void isStartWithCS (String word)
        {
            if (word[0] == 'C' && word[1] == '#')
                Console.WriteLine(true);
            else Console.WriteLine(false);
        }
        static void CheckTemprature (int degree1,int degree2)
        {
            if (degree1 < 0 && degree2 > 100 || degree2 < 0 && degree1 > 100)
                Console.WriteLine(true);
            else Console.WriteLine(false);
        }
        static void IsInRange100to200 (int number1,int number2)
        {
            if (number1 >= 100 && number1 <= 200 || number2 >= 100 && number2 <= 200)
                Console.WriteLine(true);
            else Console.WriteLine(false);
        }
        static void IsInRange20To50v1 (int number1,int number2,int number3)
        {
            if (number1>=20&&number1<=50 || number2 >= 20 && number2 <= 50 || number3 >= 20 && number3 <= 50)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);
        }
        static void IsInRange20To50v2 (int number1, int number2)
        {
            if (number1 >= 20 && number1 <= 50 || number2 >= 20 && number2 <= 50)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);
        }
        static void IsytAppears (String word)
        {
            if (word[1] == 'y' && word[2] == 't')
            {
                word = word.Replace("yt", "");
                Console.WriteLine(word);
            }
            else Console.WriteLine(word);

        }
        static void LargestNumber (int number1,int number2,int number3)
        {
            int LargestNum = number1;
            if (LargestNum<number2)
                LargestNum = number2;
            if (LargestNum < number3)
                LargestNum = number3;
            Console.WriteLine(LargestNum);
        }
        static void ClosestTo100 (int number1,int number2)
        {
            if (number1 == number2)
            {
                Console.WriteLine(0);
            }
            else if (100 - number1 < 100 - number2)
            {
                Console.WriteLine(number1);
            }
            else Console.WriteLine(number2);
        }
        static void IsInRange40To50Or60 (int number1,int number2)
        {
            if ((number1>=40&&number1<=50 && number2 >= 40 && number2 <= 50) || (number1 >= 50 && number1 <= 60 && number2 >= 50 && number2 <= 60))
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);

        }
        static void LargestNumberIn20To30 (int number1,int number2)
        {
            if (number1<20||number1>30 || number2 < 20 || number2 > 30)
            {
                Console.WriteLine(0);
            }
            else if (number1 > number2)
            {
                Console.WriteLine(number1);

            }
            else Console.WriteLine(number2);

        }
        static void IsContainZ (String word)
        {
            int z = 0;
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'z')
                    z++;
            }
            if (z >= 2 && z <= 4)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);

        }
        static void IsSameLastDigit (int number1,int number2)
        {
            while (number1 >= 10 || number2 >= 10) {
                if(number1 >= 10)
                {
                    number1 = number1 % 10;
                }
                if (number2 >= 10)
                {
                    number2 = number2 % 10;
                }
            }

            if (number1 == number2)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);
        }
        static void Last3CharToUpperCase (String word)
        {
            if (word.Length <= 3)
                Console.WriteLine(word.ToUpper());
            else
            {
                char[] NewWord = new char[word.Length];
                for (int i = word.Length-1; i >= 0; i--)
                {
                    if (word.Length-i <= 3)
                        NewWord[i] = word.ToUpper()[i];
                    else NewWord[i] = word[i];
                }
                Console.WriteLine(NewWord);
            }
        }
        static void NcopiesOfString (String word,int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(word);
            }
            Console.WriteLine();
        }

        //Second 25 questions

        static void IsEqual (int number1,int number2)
        {
            if (number1 == number2)
            {
                Console.WriteLine(number1 + " and " + number2 + " are equal.");
            }
            else Console.WriteLine(number1 + " and " + number2 + " are NOT equal.");
        }
        static void IsEvenOrOdd (int number)
        {
            if (number % 2 == 0)
                Console.WriteLine("Even");
            else Console.WriteLine("Odd");
        }
        static void IsPositiveOrNagative (int number)
        {
            if (number > 0)
                Console.WriteLine("Positive");
            else if (number < 0)
                Console.WriteLine("Nagative");
            else Console.WriteLine(0);
        }
        static void LeapYear (int year)
        {
            if (year % 4 == 0)
            {
                if (year%100 == 0)
                {
                    if (year%400 == 0)
                    {
                        Console.WriteLine(year + " is leap");
                    }
                    Console.WriteLine(year + " is NOT leap");
                }
                Console.WriteLine(year + " is leap");
            }
            
        }
        static void IsEligibleForVote (int age)
        {
            if (age >= 18)
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            else Console.WriteLine("You are NOT eligible for casting your vote.");
        }
        static void DisplayValue (int m)
        {
            int n;
            if (m > 0)
                n = 1;
            else if (m == 0)
                n = 0;
            else n = -1;
            Console.WriteLine("n : " + n);
        }
        static void Hieght (int hieght)
        {
            if (hieght < 150)
                Console.WriteLine("The person is Dwarf");
            else if (hieght>=150&&hieght<175)
                Console.WriteLine("The person is Normal");
            else Console.WriteLine("The person is Tall");
        }
        static void coordinatePoint (int X,int Y)
        {
            if (X > 0 && Y > 0)
                Console.WriteLine("The coordinate point (" + X + "," + Y + ") lies in the First quadrant.");
            else if (X < 0 && Y > 0)
                Console.WriteLine("The coordinate point (" + X + "," + Y + ") lies in the Second quadrant.");
            else if (X < 0 && Y < 0 )
                Console.WriteLine("The coordinate point (" + X + "," + Y + ") lies in the Third quadrant.");
            else Console.WriteLine("The coordinate point (" + X + "," + Y + ") lies in the Forth quadrant.");
        }
        static void Main(string[] args)
        {
            /*TwoNumberSum(5, 2);
            AbsoluteDifference(55);
            IsThirty(50, 20);
            CheckInt(105);
            AddIf("moosa");
            RemoveChar(4, "Python");
            ExchangeChar("abcd");
            Str4Copies("js");
            StrAddchar("Red");
            Multiple3or7(10);
            StrAdd3Char("moosa");
            isStartWithCS("C#");
            CheckTemprature(2,120);
            IsInRange100to200(105, 190);
            IsInRange20To50v1(9,25,40);
            IsInRange20To502v2(25, 6);
            IsytAppears("Python");
            LargestNumber(20, 27, 20);
            ClosestTo100(105,106);
            IsInRange40To50Or60(55, 60);
            LargestNumberIn20To30(28, 28);
            IsContainZ("ZZZZ");
            IsSameLastDigit(89,999);
            Last3CharToUpperCase("Javascript");
            NcopiesOfString("JS",1);
            
            IsEqual(10,10);
            IsEvenOrOdd(9);
            IsPositiveOrNagative(-5);
            LeapYear(2100);
            IsEligibleForVote(25);
            DisplayValue(0);
            Hieght(180);
            coordinatePoint(7, -9);*/

        }
    }
}
