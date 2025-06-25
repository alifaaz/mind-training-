using System.ComponentModel.Design;
using System.Globalization;
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

            int compareResultInEnglishCulture = String.Compare(string1,string2,false, EnglishCulture);



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
        static void Main(string[] args)
        {
            idk();
           
        }

       
        
    }
}

