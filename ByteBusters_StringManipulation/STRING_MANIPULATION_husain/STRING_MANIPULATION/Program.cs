using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;

namespace STRING_MANIPULATION
{
    internal class Program
    {



        //  1. Write C# Sharp program to demonstrate that the Compare(String, String, Boolean)
        //  method is equivalent to using ToUpper or ToLower when comparing strings.

        static void diffrenceBetweenCompareAndToUpper()
        {
            //  we first copare between 2 string using compare with case ignored
            //  then using ToUpper to capitalize them berfore they are eual



            //  idenify the 2 string that i want to compare
            String string1 = "QRS";
            String string2 = "qrs";


            //  using compare and using true to ignore case sensitivity
            bool areEqualUsingCompare = String.Compare(string1, string2, true) == 0;
            Console.WriteLine(areEqualUsingCompare);

            //  using ToUpper then see if string equal
            bool areEqualUsingToUpper = string1.ToUpper() == string2.ToUpper();
            Console.WriteLine(areEqualUsingToUpper);
        }

        //  2. Write a C# Sharp program to demonstrate how culture affects comparisons.
        //  Note : In Czech – Czech Republic culture, "ch" is a single character that is greater than "d".
        //  However, in English - United States culture, "ch" consists of two characters, and "c" is less than "d".
        static void CulturesDifference()
        {
            //  idenify the 2 string that i want to use in compare
            String string1 = "change";
            String string2 = "dollar";




            // in English Culture

            CultureInfo EnglishCulture = new CultureInfo("en-US");

            //  in Czech Culture 
            CultureInfo CzechCulture = new CultureInfo("cs-CZ");

            //  compareing in English culture

            int compareResultInEnglishCulture = String.Compare(string1, string2, false, EnglishCulture);



            //comparing in czech culture

            int compareResultInCzechCulture = String.Compare(string1, string2, false, CzechCulture);






            //  English culture compareing results 

            String TheBiggerStringInEnglishCulture = "";

            if (compareResultInEnglishCulture == 0)         //  if the string1 and string2 are equal return "=" sign
            {
                TheBiggerStringInEnglishCulture = "=";
            }
            else if (compareResultInEnglishCulture > 0)     //  if the string1 is bigger than string2 return ">" sign
            {
                TheBiggerStringInEnglishCulture = ">";

            }
            else if (compareResultInEnglishCulture < 0)      //  if the string2 is bigger than string1 return "<" sign
            {
                TheBiggerStringInEnglishCulture = "<";
            }
            Console.WriteLine($"For en-US: {string1} {TheBiggerStringInEnglishCulture} {string2}");  //  return the final result of English




            //  Czech Culture compareing results 

            String TheBiggerStringInCzechCulture = "";

            if (compareResultInCzechCulture == 0)         //  if the string1 and string2 are equal return "=" sign
            {
                TheBiggerStringInCzechCulture = "=";
            }
            else if (compareResultInCzechCulture > 0)     //  if the string1 is bigger than string2 return ">" sign
            {
                TheBiggerStringInCzechCulture = ">";

            }
            else if (compareResultInCzechCulture < 0)      //  if the string2 is bigger than string1 return "<" sign
            {
                TheBiggerStringInCzechCulture = "<";
            }
            Console.WriteLine($"For cs-CZ: {string1} {TheBiggerStringInCzechCulture} {string2}");   //  return the final result of Czech









        }


        /*
            3. Write a C# Sharp program to compare two strings in following three different ways produce three different results.
                a. using linguistic comparison for the en-US culture;
                b. using linguistic case-sensitive comparison for the en-US culture;
                c. using an ordinal comparison. It illustrates how the three methods of comparison
                
            NOTE: i think that a branch wanted case-sensitive and 
                    in barnch b wanted case-insensitive you can see
                    that clearly in the output he wanted:
                    
                        Expected Output :
                             'sister' comes before 'Sister'.
                             'sister' is the same as 'Sister'.
                             'sister' comes after 'Sister'.
         */


        //  1. idenitifying the two texts 
        //  2.  comaring them using by using String.Compare and String.CompareOrdinal to do a then b then c

        

        static void threeWayCompare()
        {
            String Text1 = "sister";
            String Text2 = "Sister";

            // fing case-sensitive comparison for the en-US culture;
            //  using String.Compare(Sting, Sting, bool , CultureInfo)
            //  with false in bool as to not ignore case.
            var US_culture = new CultureInfo("en-US");  //  culture en-us
            int compare_US_culture_case_sensitive_Restult = String.Compare(Text1, Text2, false, US_culture);


            //  fing case-insensitive comparison for the en-US culture
            // same as before but with true in bool as to ignore case.
            int compare_US_culture_Restult = String.Compare(Text1, Text2, true, US_culture);

            //  fing ordinal comparison by using String.CompareOrdinal;

            int CompareOrdinal_Restult = String.CompareOrdinal(Text1, Text2);

            //  puting result into a one array
            int[] resultArray = new int[3];
            resultArray[0] = compare_US_culture_case_sensitive_Restult;
            resultArray[1] = compare_US_culture_Restult;
            resultArray[2] = CompareOrdinal_Restult;


            //  printing the final output
            //  the bigger char or string comes after and lowest comes before and if equal they are the same
            //  if the result less than 0 string 2 is bigger and if bigger string 1 is bigger and so on

            String relationResult = "";
            foreach (int i in resultArray)
            {
                if (i < 0)  //  comes before
                {
                    relationResult = "comes before";
                }
                else if (i == 0) //  is the same
                {
                    relationResult = "is the same as";
                }


                else if (i > 0)    //  comes after '
                {
                    relationResult = "comes after";
                }

                Console.WriteLine($"'{Text1}' {relationResult} '{Text2}'");
            }




        }



        /*
        
            4. Write a C# Sharp program to compare three versions of the letter "I". The results are affected by culture choice, 
            whether the case is ignored, and whether an ordinal comparison is performed.
                Expected Output :
                    Compare three versions of the letter I using different values of StringComparison.
                    The current culture is en-US.
                    StringComparison.CurrentCulture:
                    LATIN SMALL LETTER I (U+0069) is less than LATIN SMALL LETTER DOTLESS I (U+0131)
                    LATIN SMALL LETTER I (U+0069) is less than LATIN CAPITAL LETTER I (U+0049)
                    LATIN SMALL LETTER DOTLESS I (U+0131) is greater than LATIN CAPITAL LETTER I (U+0049)

        */

        //  fist set the current culture to en-US 
        //  then uses compare to compare the three with StringComparison.currentCulture

        static void CompareLetterI_InthreeUnicodes() 
        {
            //  ideantifying the three letter we wants to compare
            String FirstChar = "\u0069";
            String SecondChar = "\u0131";
            String ThirdChar = "\u0049";



            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("CurrentCulture is {0}.", CultureInfo.CurrentCulture.Name);

            //  current culture is en-US
            
            int compareResultBetweenFirstandSecond = String.Compare(FirstChar, SecondChar, StringComparison.CurrentCulture);
            int compareResultBetweenFirstandThird = String.Compare(FirstChar, SecondChar, StringComparison.CurrentCulture);
            int compareResult3BetweenSecondandThird = String.Compare( SecondChar,ThirdChar, StringComparison.CurrentCulture);

            //  puting result into a one array
            int[] resultArray = new int[3];
            resultArray[0] = compareResultBetweenFirstandSecond;
            resultArray[1] = compareResultBetweenFirstandThird;
            resultArray[2] = compareResult3BetweenSecondandThird;


            //  printing the final output
            //  the bigger char or string comes after and lowest comes before and if equal they are the same
            //  if the result less than 0 string 2 is bigger and if bigger string 1 is bigger and so on

            String relationResult = "";
            List<String> relationList = new List<String>();
            foreach (int i in resultArray)
            {
                if (i < 0)  //  comes before
                {
                    relationResult = "less than";
                }
                else if (i == 0) //  is the same
                {
                    relationResult = "is the same as";
                }


                else if (i > 0)    //  comes after '  
                {
                    relationResult = "greater than";
                }
                relationList.Add(relationResult);

            }
            
            Console.WriteLine($"LATIN SMALL LETTER I (U+0069) is {relationList[0]} LATIN SMALL LETTER DOTLESS I (U+0131)");
            Console.WriteLine($"LATIN SMALL LETTER I (U+0069) is {relationList[1]} LATIN CAPITAL LETTER I (U+0049)");
            Console.WriteLine($"LATIN SMALL LETTER DOTLESS I (U+0131) is {relationList[2]} LATIN CAPITAL LETTER I (U+0049)");


        }

        static void Main(string[] args) 
        {

            //  testing 7

            /*

           7. Write a C# Sharp program to compare a given string with a set of strings.
               Expected Output :
                   Bad argument: TestClass (type TestClass)
                   Comparing 'some text' with 'TestClass': -1
                   Bad argument: 123 (type Int32)
                   Comparing 'some text' with '123': 1
                   Comparing 'some text' with 'some text': 0
                   Comparing 'some text' with 'Some Text': -1

       */

            Console.WriteLine("testing 7 ");
            compareClass.compareGivenStringWithSetOfStrings("some text",100.1);
            compareClass.compareGivenStringWithSetOfStrings("some text", "TestClass");
            compareClass.compareGivenStringWithSetOfStrings("some text", 123);
            compareClass.compareGivenStringWithSetOfStrings("some text", "123");
            compareClass.compareGivenStringWithSetOfStrings("some text", "some text");
            compareClass.compareGivenStringWithSetOfStrings("some text", "Some Text");




            //  testing 8


            /*

                 8. Write a C# Sharp program to compare the current string instance with another string.
                      Expected Output :
                            The strings occur in the same position in the sort order.
                            The first string follows the second in the sort order.
                            The first string precedes the second in the sort order.
                            The first string precedes the second in the sort order.
                            The first string follows the second in the sort order.


            */


            Console.WriteLine("\ntesting 8 ");
            compareClass.compareCurrentStringInstanceWithAnotherString("ali", "ali");
            compareClass.compareCurrentStringInstanceWithAnotherString("husain", "ali");
            compareClass.compareCurrentStringInstanceWithAnotherString("ali", "Mohammed");
            compareClass.compareCurrentStringInstanceWithAnotherString("hassan", "Yusef");
            compareClass.compareCurrentStringInstanceWithAnotherString("Nada", "ali");

        }


    }
}

