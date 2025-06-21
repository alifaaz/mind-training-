using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Threading.Channels;
using System.Transactions;
namespace Husian_Haider
{
    internal class Program
    {
        //part1(1-25)

        /*     
            Q1)
            Write a C# Sharp program to compute the sum of the two numerical values. 
            If the two values are the same, return triple their sum. 
        */
        static void P1Q1()
        {
            Console.WriteLine("enter first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number:");
            int num2 = int.Parse(Console.ReadLine());


            int sum = num1 + num2;
            if (num1 == num2)
            {
                sum *= 3;
            }
            Console.WriteLine(sum);
        }

        /*     
            Q2)
            Write a C# Sharp program to get the absolute difference between n and 51. 
            If n is broader than 51 return triple the absolute difference.  
        */

        static void P1Q2()
        {
            Console.WriteLine("enter the number you want to compaire to 51");
            int n = int.Parse(Console.ReadLine());  // the number that user enter to compaire to 51


            int Diff = 51 - n;  // difference between 51 and number(n)

            // if the Number bigger than difference multiply by 3
            if (n > 51)
            {
                Diff *= -3;
            }
            Console.WriteLine(Diff);
        }


        /*     
            Q3)
            Write a C# Sharp program to check two given integers, 
            and return true if one of them is 30 or if their sum is 30.  
       */


        static void P1Q3()
        {
            Console.WriteLine("first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number:");
            int num2 = int.Parse(Console.ReadLine());

            if ((num1 == 30 | num2 == 30) | (num1 + num2 == 30))
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("False");
            }

        }

        /*     
            Q4)
            Write a C# Sharp program to check a given integer and return true if 
            it is within 10 of 100 or 200.  
       */
        static void P1Q4()
        {
            Console.WriteLine("enter the number:");
            int num = int.Parse(Console.ReadLine());        //  getting the number from the user

            if ((num >= 90 & num <= 110) | (num >= 190 & num <= 210))       //  cheacking if it meets contditions
            {
                //  returning result 

                Console.WriteLine("True");
            }
            else
            {

                Console.WriteLine("False");
            }
        }


        static void P1Q5()
        {
            Console.WriteLine("enter the sentence you want to check");
            String text = Console.ReadLine();   // the user input text

            //  checking for if the text start with the word "if"
            if (text.StartsWith("if "))
            {
                Console.WriteLine(text);        //  retuning the same text if there is "if "

            } else
            {
                Console.WriteLine("if " + text);      //    adding "if " if there is none there    
            }

            //  returning output

        }




        static void P1Q6()
        {
            String Messege = "\"Python\" , 1";
            Console.WriteLine($"enter something like this: {Messege}");
            String InputText = Console.ReadLine();
            String[] list1 = InputText.Split(",");
            //  the word the user want me to manipulate it 
            // to get to the word must frist seperate it from the number then from ""

            String word = list1[0].Substring(list1[0].IndexOf("\"") + 1, list1[0].LastIndexOf("\"") - 1);

            int Index = int.Parse(list1[1]);        // the index of the char to remove from the word

            Console.WriteLine(word.Remove(Index, 1));
        }



        static void P1Q7()
        {
            String textInput = Console.ReadLine();       //  user entering text
            Char FirstLetter = textInput[0];            //  frist letter
            Char LastLetter = textInput[textInput.Length - 1];      //  last 
            String Between = textInput.Substring(1, textInput.Length - 2);      // inbetween text first Letter and last Letter

            //  swaping first and last letters and keeping the rest
            String newText = LastLetter + Between + FirstLetter;

            // showing result
            Console.WriteLine(newText);
        }


        static void P1Q8()
        {
            String textInput = Console.ReadLine(); ;       //  user entering text

            // checking if the user entered more than 2 letter return 4 copies
            if (textInput.Length >= 2)
            {
                String firstCopy = textInput[0].ToString() + textInput[1].ToString();

                //  making 4 copies
                String result = firstCopy + firstCopy + firstCopy + firstCopy;
                Console.WriteLine(result);


            }
            //if the user entered one letter return that one letter
            else
            {
                Console.WriteLine(textInput);
            }
        }

        //  9. Write a C# Sharp program to create a string with the last char added at the
        //  front and back of a given string of length 1 or more.

        static void P1Q9()
        {
            Console.WriteLine("enter the word: ");      //  user input
            String word = Console.ReadLine();
            Char LastLetter = word[word.Length - 1];        //  finding the last letter

            String newWord = LastLetter + word + LastLetter;     //  making the new word 
            Console.WriteLine(newWord);     //  output
        }




        static void P1Q10()
        {
            Console.WriteLine("enter the number: ");
            int num = int.Parse(Console.ReadLine());

            //  cheacking if the number can be muliplied by 7 or 3
            if ((num % 3 == 0) | (num % 7 == 0))
            {
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
            }
        }



        static void P1Q11()
        {
            Console.WriteLine("enter the word: ");
            String word = Console.ReadLine();       //  the user input word
            if (word.Length >= 3)
            {
                String FTL = word[0].ToString() + word[1].ToString() + word[2].ToString();        //  finding the first three letters

                String newWord = FTL + word + FTL;     //  making the new word 
                Console.WriteLine(newWord);     //  output
            }
            else if (word.Length == 2)
            {
                String FTL = word;        //  finding the first two letters

                String newWord = FTL + word + FTL;     //  making the new word 
                Console.WriteLine(newWord);     //  output
            }
            else {

                String FL = word;        //  finding the first letter

                String newWord = FL + word + FL;     //  making the new word 
                Console.WriteLine(newWord);     //  output

            }
        }

        static void P1Q12() {
            Console.WriteLine("enter the text: ");
            String text = Console.ReadLine();       //  user input

            //  checking if the text start with c# or C# 
            if ((text.StartsWith("C#")) | (text.StartsWith("c#")))
            {
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
            }

        }

        static void P1Q13() {
            Console.WriteLine("enter temps like that: 30 , 60 ");
            String temps = Console.ReadLine();          //  user input
            String[] splitList = temps.Split(",");      //  spliting string to a list at get each temp

            int firstTemp = int.Parse(splitList[0]);    // first temperture
            int secondTemp = int.Parse(splitList[1]);   //  seconf temperture

            if (((firstTemp < 0) & (secondTemp > 100)) | ((secondTemp < 0) & (firstTemp > 100)))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        static void P1Q14()
        {
            Console.WriteLine("enter numbers like that: 100 , 190 ");
            String temps = Console.ReadLine();      //  user input
            String[] splitList = temps.Split(",");      //  spliting string to a list at get each number

            int num1 = int.Parse(splitList[0]);    // first number
            int num2 = int.Parse(splitList[1]);   //  second number

            if ((num1 >= 100 & num1 <= 200) & (num2 >= 100 & num2 <= 200))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }




        static void P1Q15()
        {
            Console.WriteLine("enter numbers like that: 17 , 30 , 10 ");
            String nums = Console.ReadLine();          //  user input
            String[] splitList = nums.Split(",");      //  spliting string to a list at get each number

            int num1 = int.Parse(splitList[0]);    // first number
            int num2 = int.Parse(splitList[1]);   //  second number
            int num3 = int.Parse(splitList[2]);   //  third number

            if ((num1 >= 20 & num1 <= 50) | (num2 >= 20 & num2 <= 50) | (num3 >= 20 & num3 <= 50))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }


        static void P1Q16()
        {
            Console.WriteLine("enter numbers like that: 17 , 30  ");
            String nums = Console.ReadLine();          //  user input
            String[] splitList = nums.Split(",");      //  spliting string to a list at get each number

            int num1 = int.Parse(splitList[0]);    // first number
            int num2 = int.Parse(splitList[1]);   //  second number


            // XOR Meaning only if one is True and other is Flase it will be True
            if ((num1 >= 20 & num1 <= 50) ^ (num2 >= 20 & num2 <= 50))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }


        static void P1Q17() {
            Console.WriteLine("enter the text: ");
            String Word = Console.ReadLine();
            int inderOfYT = Word.IndexOf("yt");
            if (inderOfYT == 1)
            {
                String NewWord = Word.Remove(1, 2);

                Console.WriteLine(NewWord);
            }
            else {
                Console.WriteLine(Word);
            }

        }


        static void P1Q18()
        {
            Console.WriteLine("enter numbers like that: 1 , 3 , 2 ");
            String nums = Console.ReadLine();          //  user input
            String[] splitList = nums.Split(",");      //  spliting string to a list at get each number

            int num1 = int.Parse(splitList[0]);    // first number
            int num2 = int.Parse(splitList[1]);   //  second number
            int num3 = int.Parse(splitList[2]);   //  third number

            if ((num1 > num2) & (num1 > num3))
            {
                Console.WriteLine($"number {num1} is the bigger number");

            }
            else if ((num2 > num1) & (num2 > num3)) {
                Console.WriteLine($"number {num2} is the bigger number");
            }
            else {
                Console.WriteLine($"number {num3} is the bigger number");
            }

        }



        static void P1Q19()
        {
            Console.WriteLine("enter numbers like that: 77 , 98  ");
            String nums = Console.ReadLine();          //  user input
            String[] splitList = nums.Split(",");      //  spliting string to a list at get each number

            int num1 = int.Parse(splitList[0]);    // first number
            int num2 = int.Parse(splitList[1]);   //  second number

            //  finding the how close the numbers are to 100

            int num1Close = 100 - num1;
            int num2Close = 100 - num2;

            //  the less the value the closest
            if (num1Close < num2Close)
            {
                Console.WriteLine(num1);
            }
            else if (num2Close < num1Close)
            {
                Console.WriteLine(num2);
            }
            else {
                Console.WriteLine(0);   //  if the are at the same close return 0
            }


        }



        static void P1Q20()
        {
            Console.WriteLine("enter numbers like that: 40 , 45 ");
            String temps = Console.ReadLine();      //  user input
            String[] splitList = temps.Split(",");      //  spliting string to a list at get each number

            int num1 = int.Parse(splitList[0]);    // first number
            int num2 = int.Parse(splitList[1]);   //  second number

            if (((num1 >= 40 & num1 <= 50) & (num2 >= 40 & num2 <= 50)) | ((num1 >= 50 & num1 <= 60) & (num2 >= 50 & num2 <= 60)))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }




        static void P1Q21()
        {
            Console.WriteLine("enter numbers like that: 20 , 30 ");
            String temps = Console.ReadLine();      //  user input
            String[] splitList = temps.Split(",");      //  spliting string to a list at get each number

            int num1 = int.Parse(splitList[0]);    // first number
            int num2 = int.Parse(splitList[1]);   //  second number

            if ((num1 >= 20 & num1 <= 30) & (num2 >= 20 & num2 <= 30)) {
                if (num1 > num2)
                {
                    Console.WriteLine(num1);
                }
                else {
                    Console.WriteLine(num2);
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        static void P1Q22()
        {
            Console.WriteLine("enter a word like this: zane ");
            String word = Console.ReadLine();      //  user input
            int Zcounter = 0;
            for (int i = 0; i <= word.Length - 1; i++) {
                if (word[i] == 'z') {
                    Zcounter++;
                }
            }

            //  if the z counts between 2 and 4 we get True
            if (Zcounter >= 2 & Zcounter <= 4) {
                Console.WriteLine("True");
            } else { Console.WriteLine("False"); }

        }


        static void P1Q23()
        {
            Console.WriteLine("Enter two non-negative number like that: 123, 456 ");
            String temps = Console.ReadLine();      //  user input
            String[] splitList = temps.Split(",");      //  spliting string to a list at get each number

            String num1 = splitList[0].Trim();
            String num2 = splitList[1].Trim();

            Char lastnum1 = num1[num1.Length - 1];
            Char lastnum2 = num2[num2.Length - 1];
            if (lastnum1 == lastnum2)
            {
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
            }

        }




        static void P1Q24()
        { 
            Console.WriteLine("enter any text: ");
            String word = Console.ReadLine();      //  user input
            if (word.Length >= 3)
            {
                String SubWord = word.Substring(0, word.Length - 3);
                Console.WriteLine(SubWord);
                String lastThreeLetter = word.Substring(word.Length - 3);
                Console.WriteLine(lastThreeLetter);
                String NewWord = SubWord + lastThreeLetter.ToUpper();
                Console.WriteLine(NewWord);
            }
            else
            {
                Console.WriteLine(word.ToUpper());
            }

        }

        static void Main(string[] args)
        {


            P1Q1();
            P1Q2();
            P1Q3();
            P1Q4();
            P1Q5();
            P1Q6();
            P1Q7();
            P1Q8();
            P1Q9();
            P1Q10();
            P1Q11();
            P1Q12();
            P1Q13();
            P1Q14();
            P1Q15();
            P1Q16();
            P1Q17();
            P1Q18();
            P1Q19();
            P1Q20();
            P1Q21(); 
            P1Q22();
            P1Q23();
            P1Q24();


        }
    }
}
