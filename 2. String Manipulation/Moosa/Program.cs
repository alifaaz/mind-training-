using System;
using System.Globalization;

namespace String_mainpulation
{
    class Program
    {
        /*demonstrating that the Compare(String, String, Boolean) method is equivalent to using ToUpper or ToLower
        when comparing strings.*/
        static void CompareStrings(String word1,String word2)
        {
            //1st approch using ToUpper or ToLower
            if (word1.ToUpper() == word2.ToUpper())
            {
                Console.WriteLine("The Strings are equal when capitalized ? " + true);
            }
            //2nd approch using Compare(String, String, Boolean)
            if(String.Compare(word2, word1, true) == 0)
            {
                Console.WriteLine("The Strings are equal when case is ignored ? " + true);
            }

        }

        /*demonstrate how culture affects comparisons*/
        static void CultureAffectCompare(String word1, String word2)
        {
            //for en-Us culture
            int EqulOrBiggerWord = String.Compare(word1, word2, false, new CultureInfo("en-Us"));
            if (EqulOrBiggerWord == 0)
            {
                Console.WriteLine("For en-US: " + word1 + " = " + word2);
            }
            else if (EqulOrBiggerWord < 0)
            {
                Console.WriteLine("For en-US: " + word1 + " < " + word2);
            }
            else Console.WriteLine("For en-US: " + word1 + " > " + word2);

            //for cs-CZ culture
            int EqulOrBiggerWord2 = String.Compare(word1, word2, false, new CultureInfo("cs-CZ"));
            if (EqulOrBiggerWord2 == 0)
            {
                Console.WriteLine("For en-US: " + word1 + " = " + word2);
            }
            else if (EqulOrBiggerWord2 < 0)
            {
                Console.WriteLine("For cs-CZ: " + word1 + " < " + word2);
            }
            else Console.WriteLine("For cs-CZ: " + word1 + " > " + word2);

        }

        /*
         comparing two strings in following three different ways produce three different results.
        a. using linguistic comparison for the en-US culture;
        b. using linguistic case-sensitive comparison for the en-US culture;
        c. using an ordinal comparison. It illustrates how the three methods of comparison
         */
        static void CompareIn3Ways (String word1,String word2)
        {
            //using linguistic comparison for the en-US culture;
            int IsBeforeOrAfterOrSame1 = String.Compare(word1,word2,true, new CultureInfo("en-Us"));
            if (IsBeforeOrAfterOrSame1 == 0)
             Console.WriteLine(word1 + " is the same as " + word2);
            else if (IsBeforeOrAfterOrSame1 < 0)
             Console.WriteLine(word1 + " comes before " + word2);
            else Console.WriteLine(word1 + " comes after " + word2);

            // using linguistic case-sensitive comparison for the en-US culture;
            int IsBeforeOrAfterOrSame2 = String.Compare(word1, word2, false, new CultureInfo("en-Us"));
            if (IsBeforeOrAfterOrSame2 == 0)
                Console.WriteLine(word1 + " is the same as " + word2);
            else if (IsBeforeOrAfterOrSame2 < 0)
                Console.WriteLine(word1 + " comes before " + word2);
            else Console.WriteLine(word1 + " comes after " + word2);

            // using an ordinal comparison.
            int IsBeforeOrAfterOrSame3 = String.Compare(word1, word2, StringComparison.Ordinal);
            if (IsBeforeOrAfterOrSame3 == 0)
                Console.WriteLine(word1 + " is the same as " + word2);
            else if (IsBeforeOrAfterOrSame3 < 0)
                Console.WriteLine(word1 + " comes before " + word2);
            else Console.WriteLine(word1 + " comes after " + word2);
        }

        /*
          demonstrating that you compare ordinals and compare using different sort orders
         */
        static void CompareOrdinalsAndDifferentSortOrders(String word1,String word2)
        {
            // ordinals comparision
            int IsLessGreaterOrEqua1 = String.Compare(word1, word2, StringComparison.Ordinal);
            if (IsLessGreaterOrEqua1 < 0)
                Console.WriteLine(word1 + " is less than " + word2);
            else if (IsLessGreaterOrEqua1 == 0)
                Console.WriteLine(word1 + " is equal to " + word2);
            else Console.WriteLine(word1 + " is greater than " + word2);

            // CurrentCulture comparision
            int IsLessGreaterOrEqua2 = String.Compare(word1, word2, false, CultureInfo.CurrentCulture);
            if (IsLessGreaterOrEqua2 < 0)
                Console.WriteLine(word1 + " is less than " + word2);
            else if (IsLessGreaterOrEqua2 == 0)
                Console.WriteLine(word1 + " is equal to " + word2);
            else Console.WriteLine(word1 + " is greater than " + word2);
        }

        /*
          performing an ordinal comparison of two strings that only differ in case.
         */
        static void OrdinalComparisonDifferInCase (String word1,String word2)
        {
       
            int IsLessGreaterOrEqua = String.Compare(word1, word2,  StringComparison.Ordinal);
            if (IsLessGreaterOrEqua < 0)
                Console.WriteLine(word1 + " is less than " + word2);
            else if (IsLessGreaterOrEqua == 0)
                Console.WriteLine(word1 + " is equal to " + word2);
            else Console.WriteLine(word1 + " is greater than " + word2);
        }
        static void Main(string[] args)
        {
            /*CompareStrings("QrS","qrs");

            CultureAffectCompare("change", "dollar");

            CompareIn3Ways("sister","Sister");

            CompareOrdinalsAndDifferentSortOrders("y", "Y");*/
            OrdinalComparisonDifferInCase("JAVA", "python");

        }
    }
}
