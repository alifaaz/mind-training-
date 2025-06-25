using System;
using System.ComponentModel;
using System.Globalization;


namespace StringManipulation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----1----");
            StringCompare("QRS", "qrs");

            Console.WriteLine("\n----2----");
            CultureComparison("change", "dollar");
        }

        //1. Write C# Sharp program to demonstrate that the Compare(String, String, Boolean) method is equivalent to using ToUpper or ToLower when comparing strings.
        //    Expected Output :
        //    Comparing 'QRS' and 'qrs':
        //    The Strings are equal when capitalized? true
        //    The Strings are equal when case is ignored? true

        static void StringCompare(string string1, string string2)
        {
            Console.WriteLine($"Comparing {string1} and {string2}:");

            //1. Convert each string to Upper casses and check it with equality operator '==' to see if this behavior is same as String.Compare method.
            bool stringCompareToUpper = string1.ToUpper() == string2.ToUpper();

            //2.Use String.Compare method with true to ignoreCase, this will compare two string ignoring case sensitivity if true o/p will be 0.
            // Then use equality operator and compare it to 0 to get true when they equal, or false when they are not equal.
            bool stringCompareMethod = String.Compare(string1, string2, ignoreCase: true) == 0;

            //3. Cnsole out the resault
            Console.WriteLine($"The Strings are equal when capitaized? {stringCompareToUpper}");
            Console.WriteLine($"The Strings are equal when capitaized? {stringCompareMethod}");
        }

        //2. Write a C# Sharp program to demonstrate how culture affects comparisons.
        //    Note : In Czech – Czech Republic culture, "ch" is a single character that is greater than "d". However, in English - United States culture, "ch" consists of two characters, and "c" is less than "d".
        //    Expected Output :
        //    For en-US: change<dollar
        //    For cs-CZ: change> dollar
        static void CultureComparison(string str1, string str2)
        {
            //1. First set the culture info for each language
            CultureInfo USA_Culture = new CultureInfo("en-US");
            CultureInfo CZ_Culture = new CultureInfo("cs-CZ");

            //2. Compare between two strings and get the result. if 
            int resultEn = USA_Culture.CompareInfo.Compare(str1, str2);
            int resultCz = CZ_Culture.CompareInfo.Compare(str1, str2);

            //3. If result < 0 means its str1 before str2, result > 0 str1 after str2 , if it's 0 will be equal
            Console.WriteLine("For en-US: change " + (resultEn < 0 ? "<" : resultEn > 0 ? ">" : "==") + " dollar");
            Console.WriteLine("For cs-CZ: change " + (resultCz < 0 ? "<" : resultCz > 0 ? ">" : "==") + " dollar");
        }

        //3. Write a C# Sharp program to compare two strings in following three different ways produce three different results.
        //a. using linguistic comparison for the en-US culture.
        //b. using linguistic case-sensitive comparison for the en-US culture.
        //c. using an ordinal comparison.It illustrates how the three methods of comparison
        //    Expected Output :
        //    'sister' comes before 'Sister'.
        //    'sister' is the same as 'Sister'.
        //    'sister' comes after 'Sister'.

    } }