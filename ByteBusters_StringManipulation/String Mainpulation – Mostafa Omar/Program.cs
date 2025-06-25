using System;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Threading;
namespace String_Mainpulation___Mostafa_Omar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1
            // CompareVsToUpperAndToLower("QRS", "qrs");
            // Q2
            // DemonstrateCaltureAffect("change", "dollar");
            // Q3
            // ComparesStringsInThreeWays("sister", "Sister");
            // Q4
            // CompareThreeVersionOfI();
            // Q5
            // CompareOrdinalAndlinguistic("xyz", "XYZ");
            // Q6
            //OrdinalComparision("JAVA", "python");

            // Q8
            //CompareStringWitAnotherString("apple", "apple");
            //CompareStringWitAnotherString("banana", "apple");
            //CompareStringWitAnotherString("apple", "banana");
            //CompareStringWitAnotherString("a", "b");
            //CompareStringWitAnotherString("zebra", "ant");

            // Q11
            // ConcatenateThreeStringsAndDisplay();

            // Q12
            // ConcatenateStringArrayValues();

        }

        /* 1. Write C# Sharp program to demonstrate that the Compare(String, String, Boolean) method
           is equivalent to using ToUpper or ToLower when comparing strings. */

        /* as i understand from this qouestion, i need to explain that the method 'Compare' and
           methods 'ToUpper or ToLower' are equivalent when it comes to string. */

        /* sol
        * Actually it depends on how we code it,
        * if we are comparing strings between lower case and upper case
        * its NOT equivalent
        * BUT
        * if we ignore lower case and upper case (case diffrences),
          then YES compare method and ToUpper and ToLower comparition equivalent. */

        static void CompareVsToUpperAndToLower(string str1, string str2) // str mean string.
        {
            bool areEqualWithUpper = str1.ToUpper() == str2.ToUpper();
            bool areEqualWithLower = str1.ToLower() == str2.ToLower();

            // here i used compare method and put it 'true' to iqnore case of upper and lower.
            // "note" if we put it 'false' it will NOT ignore case of upper and lower.
            bool areEqualWithCompare = String.Compare(str1, str2, true) == 0;

            Console.WriteLine("Comparig '" + str1 + "' And '" + str2 + "'\n");
            Console.WriteLine("The Strings are equivalent using ToUpper:" + areEqualWithUpper);
            Console.WriteLine("The Strings are equivalent using ToLower:" + areEqualWithLower);

            //as i said before if we ignore case sensitive
            Console.WriteLine("The Strings are equivalent using Compare method:" + areEqualWithCompare);
        }
        /* 2. Write a C# Sharp program to demonstrate how culture affects comparisons.
         * Note : In Czech – Czech Republic culture, "ch" is a single character that is greater than "d".
         * However, in English - United States culture, "ch" consists of two characters, and "c" is less than "d".
         */

        /* sol\
         * i didnt know that info so i went to search :)
         * i found out that compare method has an object that supply culture spesific comparition info
         * so im gonna use it and compare with zero within if else statement
         */
        static void DemonstrateCaltureAffect(string str1, string str2)
        {
            // here we gonna compare them based on string + case of upper and lower and culture info (language and country)
            int InEnglish = string.Compare(str1, str2, false, new CultureInfo("en-US"));
            int InCzech = string.Compare(str1, str2, false, new CultureInfo("cs-CZ"));

            Console.Write("For en-US: " + str1 + " ");
            // if its less than zero ( النص الاول اصغر من النص الثاني)
            if (InEnglish < 0)
                // print '<'
                Console.Write("<");
            // else if its bigger than 0  (النص الاول اكبر من النص الثاني )
            else if (InEnglish > 0)
                // print '>'
                Console.Write(">");
            // if they are equal
            else
                // print "=="
                Console.Write("==");

            Console.WriteLine(" " + str2);

            Console.Write("For cs-CZ: " + str1 + " ");
            // if its less than zero ( النص الاول اصغر من النص الثاني)
            if (InCzech < 0)
                // print '<' 
                Console.Write("<");
            // else if its bigger than 0 (النص الاول اكبر من النص الثاني)
            else if (InCzech > 0)
                // print '>'
                Console.Write(">");
            // if they are equal
            else
                // print "=="
                Console.Write("==");

            Console.WriteLine(" " + str2);
        }
        /* 3. Write a C# Sharp program to compare two strings
         * in following three different ways produce three different results.
         */
        //a. using linguistic comparison for the en-US culture
        //b. using linguistic case-sensitive comparison for the en-US culture;
        //c. using an ordinal comparison.
        // It illustrates how the three methods of comparison

        /* sol\
         * 1- im gonna use compare method
         * 2- use if and else to help me show the result 
         */
        static void ComparesStringsInThreeWays(string str1, string str2)
        {
            // a using linguistic comparison for the en-US culture
            int LinguisticComparisoInEnglish = string.Compare(str1, str2, true, new CultureInfo("en-US"));
            Console.WriteLine("a. using linguistic comparison for the en-US culture");
            Compare2StringsPrintResult(str1, str2, LinguisticComparisoInEnglish);
            Console.WriteLine("\n");

            // b using linguistic case-sensitive comparison for the en-US culture
            int LinguisticCaseSensitiveComparisonInEnglish = string.Compare(str1, str2, false, new CultureInfo("en-US"));
            Console.WriteLine("b. using linguistic case-sensitive comparison for the en-US culture");
            Compare2StringsPrintResult(str1, str2, LinguisticCaseSensitiveComparisonInEnglish);
            Console.WriteLine("\n");

            // c (binary compartion , case sensetive) 
            int OrdinalComparison = string.CompareOrdinal(str1, str2);
            Console.WriteLine("c. using an ordinal comparison");
            Compare2StringsPrintResult(str1, str2, OrdinalComparison);
            Console.WriteLine("\n");
        }

        static void Compare2StringsPrintResult(string a, string b, int result)
        {
            // if result of compare less than zero
            if (result < 0)
                Console.WriteLine($"{a} comes before {b}");
            else if (result > 0)
                Console.WriteLine($"{a} comes after  {b}");
            else
                Console.WriteLine($"{a} is the same as {b}");
        }

        /* 4. Write a C# Sharp program to compare three versions of the letter "I".
         * The results are affected by culture choice, whether the case is ignored,
         * and whether an ordinal comparison is performed. */

        static void CompareThreeVersionOfI()
        {
            string smallI = "i";    // U+0069
            string dotlessI = "ı";  // U+0131
            string capitalI = "I";  // U+0049  

            var enCulture = new CultureInfo("en-US"); // here im storing 'cultureinfo' in a var so it be smaller to use in the code

            // compare in current culture en-us
            Console.WriteLine("Compare in Current Culture en-us");

            PrintResult("LATIN SMALL LETTER I (U+0069)", "LATIN SMALL LETTER DOTLESS I (U+0131)",
                string.Compare(smallI, dotlessI, false, enCulture));
            PrintResult("LATIN SMALL LETTER I (U+0069)", "LATIN CAPITAL LETTER I (U+0049)",
                string.Compare(smallI, capitalI, false, enCulture));
            PrintResult("LATIN SMALL LETTER DOTLESS I (U+0131)", "LATIN CAPITAL LETTER I (U+0049)",
                string.Compare(dotlessI, capitalI, false, enCulture));
            Console.WriteLine("\n");

            // compare with  Current Culture ignore case
            Console.WriteLine("Compare with Current Culture ignore case");
            PrintResult("LATIN SMALL LETTER I (U+0069)", "LATIN SMALL LETTER DOTLESS I (U+0131)",
                string.Compare(smallI, dotlessI, true, enCulture));
            PrintResult("LATIN SMALL LETTER I (U+0069)", "LATIN CAPITAL LETTER I (U+0049)",
                string.Compare(smallI, capitalI, true, enCulture));
            PrintResult("LATIN SMALL LETTER DOTLESS I (U+0131)", "LATIN CAPITAL LETTER I (U+0049)",
                string.Compare(dotlessI, capitalI, true, enCulture));
            Console.WriteLine("\n");

            // store the method 'compare ordinal' in variable
            var OrdinalCompare = StringComparison.Ordinal;
            // compare in ordinal 
            Console.WriteLine("compare in ordinal way ");
            PrintResult("LATIN SMALL LETTER I (U+0069)", "LATIN SMALL LETTER DOTLESS I (U+0131)",
                string.Compare(smallI, dotlessI, OrdinalCompare));
            PrintResult("LATIN SMALL LETTER I (U+0069)", "LATIN CAPITAL LETTER I (U+0049)",
                string.Compare(smallI, capitalI, OrdinalCompare));
            PrintResult("LATIN SMALL LETTER DOTLESS I (U+0131)", "LATIN CAPITAL LETTER I (U+0049)",
                string.Compare(dotlessI, capitalI, OrdinalCompare));
            Console.WriteLine("\n");

            // store the method 'compare ordinal ignore cases' in variable
            Console.WriteLine("compare in ordinal way ignore cases ");

            var OrdinalCompareIgnoreCase = StringComparison.OrdinalIgnoreCase;
            PrintResult("LATIN SMALL LETTER I (U+0069)", "LATIN SMALL LETTER DOTLESS I (U+0131)",
                string.Compare(smallI, dotlessI, OrdinalCompareIgnoreCase));
            PrintResult("LATIN SMALL LETTER I (U+0069)", "LATIN CAPITAL LETTER I (U+0049)",
                string.Compare(smallI, capitalI, OrdinalCompareIgnoreCase));
            PrintResult("LATIN SMALL LETTER DOTLESS I (U+0131)", "LATIN CAPITAL LETTER I (U+0049)",
                string.Compare(dotlessI, capitalI, OrdinalCompareIgnoreCase));
        }

        static void PrintResult(string a, string b, int result)
        {
            // if result of compare less than zero
            if (result < 0)
                Console.WriteLine($"{a} 'is less than' {b}");
            else if (result > 0)
                Console.WriteLine($"{a} 'is greater than' {b}");
            else
                Console.WriteLine($"{a} 'is equal to' {b}");
        }

        //5.Write a C# Sharp program to demonstrate that you compare ordinals and compare using different sort orders.
        //Expected Output :
        //CompareOrdinal("xyz"[1], "XYZ"[1]) :
        //   'y' is greater than 'Y'
        //Compare("xyz"[1], "XYZ"[1]) :
        //   'y' is less than 'Y'

        // i will define tow strings and store the index1 with char variable and then compare it as the qoestion want and print the result using function

        static void CompareOrdinalAndlinguistic(String str1, String str2)
        {
            char LowerY = str1[1];
            char UpperY = str2[1];
            Console.WriteLine($"Compare Ordinal(\"{str1}\"[1], \"{str2}\"[1]) :");
            int OrdinalCompare = string.Compare(LowerY.ToString(), UpperY.ToString(), StringComparison.Ordinal);

            if (OrdinalCompare > 0)
                Console.WriteLine($"   '{LowerY}' is greater than '{UpperY}'");
            else if (OrdinalCompare < 0)
                Console.WriteLine($"   '{LowerY}' is less than '{UpperY}'");
            else
                Console.WriteLine($"   '{LowerY}' is equal to '{UpperY}'");

            Console.WriteLine($"Culture Compare(\"{str1}\"[1], \"{str2}\"[1]) :");

            int CultureCompare = string.Compare(LowerY.ToString(), UpperY.ToString(), false, new CultureInfo("en-US"));

            if (CultureCompare > 0)
                Console.WriteLine($"   '{LowerY}' is greater than '{UpperY}'");
            else if (CultureCompare < 0)
                Console.WriteLine($"   '{LowerY}' is less than '{UpperY}'");
            else
                Console.WriteLine($"   '{LowerY}' is equal to '{UpperY}'");

        }
        // 6. Write a C# Sharp program to perform an ordinal comparison of two strings that only differ in case.

        // Expected Output :

        // Compare the numeric values of the corresponding Char objects in each string.     
        // str1 = 'JAVA', str2 = 'python'                                                   
        // String 'JAVA' is less than String 'python'.

        // i will compare them in ordinal way
        static void OrdinalComparision(String str1, String str2)
        {

            int OrdinalCompare = String.Compare(str1, str2, StringComparison.Ordinal);
            PrintResult(str1, str2, OrdinalCompare); // method that i used earlier
        }

        // 8. Write a C# Sharp program to compare the current string instance with another string.
        // Expected Output :

        // The strings occur in the same position in the sort order.                        
        // The first string follows the second in the sort order.                           

        // The first string precedes the second in the sort order.                          
        // The first string precedes the second in the sort order.                          
        // The first string follows the second in the sort order.

        // i will make function with 2 strings and i will use compare function
        // and print all the possible results in if else case

        static void CompareStringWitAnotherString(String str1, String str2)
        {
            int result = string.Compare(str1, str2);

            if (result == 0)
                Console.WriteLine("The strings occur in the same position in the sort order.");
            else if (result > 0)
                Console.WriteLine("The first string follows the second in the sort order.");
            else
                Console.WriteLine("The first string precedes the second in the sort order.");
        }
       /* 11. Write a C# Sharp program to concatenate three strings and display the result.

        Expected Output :
        
        Don't count your chickens, before the eggs, have hatched.
       */
       
        // sol: define three strings and add them together toget the right output
        
        static void ConcatenateThreeStringsAndDisplay ()
        {
            string str1 = "Don't count your chickens, ";
            string str2 = "before the eggs, ";
            string str3 = "have hatched.";

            // Concatenate the 3 strings
            string result = str1 + str2 + str3;

            Console.WriteLine(result);
        }

        /*
         * 12. Write a C# Sharp program to concatenate string array values.

         Expected Output :
         
         hello welcome to C# Sharp create Windows client applications                     
                                                                                          
         hello applicationsC# Sharp client create to welcome Windows
         */

        // i will create string array and print it as it shown in the output
        
        static void ConcatenateStringArrayValues ()
        {
            string[] words = { "hello", "welcome", "to", "C#", "Sharp", "create", "Windows", "client", "applications" };
            // here i gonna print it in the same way that i add it 

            string Concatenate1 = ""; // declare string to store in it
            for (int i = 0; i < words.Length; i++)
            {
                Concatenate1 += words[i]; // add the word from zero to the end 

                if (i < words.Length - 1)
                {
                    Concatenate1 += " "; // if last thing in the word is not space we add " "
                }
            }

            Console.WriteLine(Concatenate1);

            string Concatenate2 = words[0] + " " + words[8] + words[3] + " " + words[4] + " " + words[7] + " " + words[5] + " " + words[2] + " " + words[1] + " " + words[6];
            Console.WriteLine(Concatenate2);
        }
    }


    }




