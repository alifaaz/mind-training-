using System;

namespace TrainYourMindTask_MostafaOmar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_1();
            Task_2();
            Task_3();
            Task_4();
            Task_5();
            Task_6();
            Task_7();
            Task_8();
            Task_9();
            Task_10();
            Task_11();
            Task_12();
            Task_13();
            Task_14();
            Task_15();
            Task_16();
            Task_17();
            Task_18();
            Task_19();
            Task_20();
            Task_21();
            Task_22();
            Task_23();
            Task_24();
            Task_25();
        }
        
        /* Section 1 - Task 1
         * Write a C# Sharp program to compute the sum of the two numerical values.
         * If the two values are the same, return triple their sum.
         */
        static void Task_1()
        {
            // first, im gonna read the numbers from the user.
            Console.Write("Enter Number One: ");
            int NumberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number Two: ");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());

            // here im gonna use if and else case and sol the task
            if (NumberOne == NumberTwo) // if NumberOne equal NumberTwo 
            {
                Console.Write("Result: " + 3 * (NumberOne + NumberTwo)); // we gona triple it
            }
            else // if not equal
            {
                Console.Write("Result: " + (NumberOne + NumberTwo)); // we gonna just add them
            }
        }

        /* Section 1 - Task 2
         * Write a C# Sharp program to get the absolute difference between n and 51.
         * If n is broader than 51 return triple the absolute difference.
         */

        static void Task_2()
        {
            // first, im gonna read the n from the user.
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 51) // if n broader than 51 
            {
                Console.Write("Result: " + Math.Abs(3 * (n - 51))); // we will return the abs of (3 * (n - 51))
            }
            else // else 
            {
                Console.Write("Result: " + Math.Abs((n - 51))); // we will return the abs of (n - 51)
            }
        }

        /* Section 1 - Task 3
         * Write a C# Sharp program to check two given integers,
         * and return true if one of them is 30 or if their sum is 30. */
        static void Task_3()
        {
            // first, im gonna read the numbers from the user.
            Console.Write("Enter Number One: ");
            int NumberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number Two: ");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());

            // here im goona write the condition (true if one of them is 30 ) OOOR ( if their sum is 30).
            Console.WriteLine(((NumberOne == 30 || NumberTwo == 30) || (NumberOne + NumberTwo == 30)));
        }

        /* Section 1 - Task 4
        Write a C# Sharp program to check a given integer
        and return true if it is within 10 of 100 or 200. */

        static void Task_4()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine()); // here im gonna enter a number

            Console.WriteLine((number >= 90 && number <= 110) || (number >= 190 && number <= 210));
            // this condition will return true if it is within 10 of 100 or 200
        }
        /* Section 1 - Task 5
         * Write a C# Sharp program to create a string where          
         * 'if' is added to the front of a given string.
         * If the string already begins with 'if', return it unchanged.
         */

        static void Task_5()
        {
            Console.Write("Enter The StringState: "); // First we read string from the user
            string StringState = Console.ReadLine();

            if (StringState.StartsWith("if")) // we make condition if the string start with "if"
            {
                Console.Write(StringState); // we will  return it unchanged
            }
            else // else
            {
                Console.Write("if " + StringState); //we gonna add at the begginning "if"
            }
        }
        /* Section 1 - Task 6
         * Write a C# Sharp program to remove the character at a given position in the string.
         * The given position will be in the range 0..(string length -1) inclusive.
         */
        static void Task_6()
        {
            string StringPython = "Python"; // we put the word "Python" into a variable 

            Console.WriteLine("Enter index of char to remove in \"Python\" ( 0 to " + (StringPython.Length - 1) + " )"); // i used (StringPython.Length - 1 to show the last index to the user
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0 && num < StringPython.Length) // if number is bigger and smaller than the python lengnth
            {
                Console.WriteLine(StringPython.Remove(num, 1));// we will remove the the index that user select based on the method Remove
            }
            else
            {
                Console.WriteLine("Number is out of range");
            }

        }

        /* Section 1 - Task 7
         * Write a C# Sharp program to exchange the first and last characters
         * in a given string and return the new string.
         */
        static void Task_7()
        {
            Console.Write("Enter String:");
            string word = Console.ReadLine(); // read word from the user

            char first = word[0]; // save the first char in variable
            char last = word[word.Length - 1]; // save the last char in variable

            String middle = word.Substring(1, word.Length - 2); // we save the midlle of the word by using Substring method 
            Console.WriteLine(last + middle + first); // here we add them based on the qouestion last then midd then first
        }

        /* Section 1 - Task 8
         * 8. Write a C# Sharp program to create a string which is 4 copies of the 2 front characters of a given string.
         * If the given string length is less than 2 return the original string.
         * */
        static void Task_8()
        {
            Console.Write("Enter String:");
            string word = Console.ReadLine();
            if (word.Length < 2)
            {
                Console.WriteLine(word);
            }
            else
            {
                string front = word.Substring(0, 2); // this will take first 2 frim word
                Console.WriteLine(front + front + front + front); // here we are gonna print it 4 times
            }
        }
        /* Section 1 - Task 9
         * Write a C# Sharp program to create a string with the last char
         * added at the front and back of a given string of length 1 or more.*/
        static void Task_9()
        {
            Console.Write("Enter String:");
            string word = Console.ReadLine();

            char last = word[word.Length - 1]; // taking the last character

            String FrontMiddle = word.Substring(0, word.Length); // take the word from start to the end of the word length
            Console.WriteLine(last + FrontMiddle + last); // puuting last at the start and in the end and between it the FrontMiddle characters

        }
        /* Section 1 - Task 10
         * Write a C# Sharp program to check if a given positive number is a multiple
         * of 3 or 7.
         */
        static void Task_10()
        {
            Console.Write("Enter the Number to check: ");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num <= 0)
            {
                Console.WriteLine("Number should be postive!");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(num % 3 == 0 || num % 7 == 0); // if (num / 7 or 3) = 0 . then the number is  multiple of 3 and saven else false

        }
        /* Section 1 - Task 11
         * Write a C# Sharp program to create a string taking the first 3 characters of
         * a given string. Return the string with the 3 characters added at both the front
         * and back. If the given string length is less than 3, use whatever characters arethere.
         */
        static void Task_11()
        {
            Console.Write("Enter String:");
            string word = Console.ReadLine();
            if (word.Length <= 2) // if word length less than 3 character then
            {
                Console.WriteLine(word + word + word); // print the word 3 time
            }
            else                                       // else
            {
                string front = word.Substring(0, 3);   // take the first 3 characters from the word and
                Console.WriteLine(front + word + front); // Return the string with the 3 characters added at both the front and back
            }
        }
        /* Section 1 - Task 12
         * Write a C# Sharp program to check if a given string starts with 'C#' or not.
         */
        static void Task_12()
        {
            Console.Write("Enter String:");
            string word = Console.ReadLine();
            Console.WriteLine(word.StartsWith("C#")); //StartsWith it will check if its there or no, if its there then true, no then false
        }
        /* Section 1 - Task 13
         * Write a C# Sharp program that checks whether one temperature is less
than 0 and another is greater than 100.

         */
        static void Task_13()
        {
            Console.WriteLine("Enter temperature1: ");
            int temperature1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter temperature2: ");
            int temperature2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((temperature1 > 100 && temperature2 < 0) || (temperature2 > 100 && temperature1 < 0));


        }
        /* Section 1 - Task 14
         * Write a C# Sharp program to check two given integers whether either of
them is in the range 100..200 inclusive.

         */
        static void Task_14()
        {
            Console.Write("Enter Number One: ");
            int NumberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number Two: ");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((NumberOne > 100 && NumberTwo < 200) || (NumberTwo > 100 && NumberOne < 200));
        }
        /* Section 1 - Task 15
         * Write a C# Sharp program to check whether three given integer values are
         * in the range 20..50 inclusive. Return true if 1 or more of them are in the said
         * range otherwise false.
         */
        static void Task_15()
        {
            Console.Write("Enter Number One: ");
            int NumberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number Two: ");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number Three: ");
            int NumberThree = Convert.ToInt32(Console.ReadLine());

            bool istrue = (NumberOne >= 20 && NumberOne <= 50) ||
                          (NumberTwo >= 20 && NumberTwo <= 50) ||
                          (NumberThree >= 20 && NumberThree <= 50);

            Console.WriteLine(istrue);
        }
        /* Section 1 - Task 16
         * Write a C# Sharp program to check whether two given integer values are
         * in the range 20..50 inclusive. Return true if 1 or other is in the range,
         */
        static void Task_16()
        {
            Console.Write("Enter Number One: ");
            int NumberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number Two: ");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((NumberOne >= 20 && NumberOne <= 50) || (NumberTwo >= 20 && NumberTwo <= 50));
            // if num one bigger  or equal  20 and less or equal 50 return true
            // if num two bigger  or equal  20 and less or equal 50 return true
            // if one both of them false then return false
        }
        /* Section 1 - Task 17
         * Write a C# Sharp program to check if a string 'yt' appears at index 1 in a
         * given string. If it appears return a string without 'yt' otherwise return the
         * original string.
         */
        static void Task_17()
        {
            Console.Write("Enter String:");
            string word = Console.ReadLine();

            if (word.Length >= 3 && word.Substring(1, 2) == "yt") // we check if word length bigger than 3, AND "yt" is availbe in index 1 or no
            {
                Console.WriteLine(word.Remove(1, 2)); // if yes then remove it
            }
            else
            {
                Console.WriteLine(word); // if no then print the word
            }
        }
        /* Section 1 - Task 18
         * Write a C# Sharp program to check the largest number among three given
         * integers.
         */
        static void Task_18()
        {
            Console.Write("Enter Number One: ");
            int NumberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number Two: ");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number Three: ");
            int NumberThree = Convert.ToInt32(Console.ReadLine());

            if (NumberOne >= NumberTwo && NumberTwo >= NumberThree) // if number 1 bigger or equal to number 2 AND Number 2 bigger or equal to number 3
            {
                Console.WriteLine(NumberOne);  // print NumberOne
            }
            else if (NumberTwo >= NumberOne && NumberTwo >= NumberThree) // else if number 2 bigger or equal to number 1 AND Number 2 smaller or equal to number 3
            {
                Console.WriteLine(NumberTwo); // print NumberTwo
            }
            else
            {
                Console.WriteLine(NumberThree); // Number Three
            }
        }
        /* Section 1 - Task 19
         * Write a C# Sharp program to check which number is closest to 100 among
         * two given integers. Return 0 if the two numbers are equal.
         */
        static void Task_19()
        {
            Console.Write("Enter Number One: ");
            int NumberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number Two: ");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());

            if (NumberOne == NumberTwo) // if num 1 = num 2
            {
                Console.WriteLine(0); // print 0
            }
            else // else we declare two varible for the diffrent between the numbers and 100
            {
                int Diff_NumOne = Math.Abs(100 - NumberOne); // here we subtrack NumberOne - 100 and put it in Abs in case it went under 0
                int Diff_NumTwo = Math.Abs(100 - NumberTwo); // same here but for num 2

                if (Diff_NumOne < Diff_NumTwo) // if Diff_NumOne less than the Diff_NumTwo 
                {
                    Console.WriteLine(NumberOne); // we will print Diff_NumOne
                }
                else if (Diff_NumTwo < Diff_NumOne)
                {
                    Console.WriteLine(NumberTwo); // print Diff_NumTwo 
                }
                else
                {
                    Console.WriteLine("Both are close"); // if bot are equal we will print "Both are close"
                }
            }
        }
        /* Section 1 - Task 20
         * Write a C# Sharp program to check whether two given integers are in the
         * range 40..50 inclusive, or they are both in the range 50..60 inclusive.
         */

        static void Task_20()
        {
            Console.Write("Enter Number One: ");
            int NumberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number Two: ");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());
            // check  whether two given integers are in the range 40..50 inclusive 
            bool result = ((NumberOne >= 40 && NumberTwo <= 50) && (NumberTwo >= 40 && NumberOne <= 50))
                           ||                                                                               //or
                          ((NumberOne >= 50 && NumberTwo <= 60) && (NumberTwo >= 50 && NumberOne <= 60));   //they are both in the range 50..60 inclusive

            Console.WriteLine(result);     // print result
        }
        /* Section 1 - Task 21
         * Write a C# Sharp program to find the largest value from two positive
         * integer values in the range 20..30 inclusive. Return 0 if neither is in that range.
         */
        static void Task_21()
        {
            Console.Write("Enter Number One: ");
            int NumberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number Two: ");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());

            bool range1 = (NumberOne >= 20 && NumberOne <= 30); // make range 1 for number 1 between 20 - 30
            bool range2 = (NumberTwo >= 20 && NumberTwo <= 30); // make range 2 for number 2 between 20 - 30

            if (range1 && range2) // if both are true
            {
                if (NumberOne > NumberTwo) // and if num1 greater than num 2
                {
                    Console.WriteLine(NumberOne); // print num 1
                }
                else
                {
                    Console.WriteLine(NumberTwo); // print num 2
                }
            }
            else if (range1) // we will take range 1
            {
                Console.WriteLine(NumberOne); //  print num 1
            }
            else if (range2) // we will take range 1
            {
                Console.WriteLine(NumberTwo); // print num 2 
            }

            else // and here we will Return 0 if neither is in that range
            {
                Console.WriteLine(0);
            }
        }
        /* Section 1 - Task 22
         * Write a C# Sharp program to check if a given string contains between 2
         * and 4 'z' characters.
         * Sample Input:
         */
        static void Task_22()
        {
            Console.Write("Enter String:");
            string word = Console.ReadLine();

            int count = 0; // create counter 
            for (int i = 0; i < word.Length; i++) // declare for loop 
            {
                if (word[i] == 'z') // let 'i' pass through 'word' char by char in ieach loop unil it find 'z' character
                {
                    count++; // We increase count in each loop to use it in checking 'z' 
                }
            }
            Console.WriteLine(count >= 2 && count <= 4); // if count >= 2 and count <= 4, it will display true and if dont it will display False
        }
        /* Section 1 - Task 23
         * Write a C# Sharp program to check if two given non-negative integers
         * have the same last digit.
         */
        static void Task_23()
        {
            // read 2 integer number.
            Console.Write("Enter Number One: ");
            int NumberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number Two: ");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());

            if (NumberOne % 10 == NumberTwo % 10) // Check if they have same last digit by Checking through '%'.
            {
                Console.WriteLine(true); // if they are the same in the last digit, return true.
            }
            else
            {
                Console.WriteLine(false);  // if not then false.
            }
        }
        /* Section 1 - Task 24
         * Write a C# Sharp program to convert the last 3 characters of a given string
         * to uppercase. If the length of the string is less than 3, then uppercase all the
         * characters. */
        static void Task_24()
        {
            Console.Write("Enter String:");
            string word = Console.ReadLine();
            if (word.Length < 3)    // if the string(word) less than 3.
            {
                Console.WriteLine(word.ToUpper()); // print it and Upper case it all.
            }
            else
            {
                String front = word.Substring(0, word.Length - 3); // declaring variable 'front' to store all Except last 3.

                String last3 = word.Substring(word.Length - 3); // last 3 character in the string.

                Console.WriteLine(front + last3.ToUpper()); // show the front and last 3 char with uppercase.
            }

        }
        /* Section 1 - Task 25
         * Write a C# Sharp program to create a string which is n (non-negative
         * integer) copies of a given string.
         */
        static void Task_25()
        {
            Console.Write("Enter String:");
            string word = Console.ReadLine();

            Console.Write("Enter Number of copys: ");
            int num = Convert.ToInt32(Console.ReadLine()); // number of copys.

            string result = ""; // Declare a variable and asign it to plain text to store result in it.

            for (int i = 0; i < num; i++) // loop for number of copys .
            {
                result += word; // add the word to the exact plain text .
            }
            Console.WriteLine(result); // print the result.
        }
    }
}
