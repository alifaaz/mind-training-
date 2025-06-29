using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRING_MANIPULATION
{
    internal class compareClass
    {

        /*  5. Write a C# Sharp program to demonstrate that you compare ordinals and compare using different sort orders.
                Expected Output :
                    CompareOrdinal("xyz"[1], "XYZ"[1]):
                    'y' is greater than 'Y'
                    Compare("xyz"[1], "XYZ"[1]):
                    'y' is less than 'Y'*/


        //  we use CompareOrdinal then Compare to prove they are difference 



        public static void diffrenceBetweenCompareOrdinalAndCompare()
        {
            //  identifying strings
            String firstText = "xyz";
            String secondText = "XYZ";




            //  findind the letter that i want to compare of the two strings
            //  for example i want the 2nd letter of both (index 1) 

            String firstLetter = (firstText[1]).ToString();
            String secondLetter = (secondText[1]).ToString();


            //  find CompareOrdinal value for the two strings

            int CompareOrdinalValue = String.CompareOrdinal(firstLetter, secondLetter);



            //  find Compare value for the two strings

            int CompareValue = String.Compare(firstLetter, secondLetter);


            //  geting the relation from GetRelation function
            String CompareOrdinalRelation = GetRelation(CompareOrdinalValue);
            String CompareRelation = GetRelation(CompareValue);

            //  printing final result messege

            Console.WriteLine("CompareOrdinal(\"{0}\"[1], \"{1}\"[1]): \n '{2}' {3} '{4}'", firstText, secondText, firstLetter, CompareOrdinalRelation, secondLetter);
            Console.WriteLine("Compare(\"{0}\"[1], \"{1}\"[1]): \n '{2}' {3} '{4}'", firstText, secondText, firstLetter, CompareRelation, secondLetter);
        }


        //  this funtion return the relation (greater than , less than or the same as) of two strings
        //  by using the compare result value between them and comparing the value to zero
        public static String GetRelation(int compareResultValue)
        {
            //  printing the final output
            //  the bigger char or string comes after and lowest comes before and if equal they are the same
            //  if the result less than 0 string 2 is bigger and if bigger string 1 is bigger and so on


            String relationResult = " ";



            if (compareResultValue < 0)  //  comes before
            {
                relationResult = "less than";
            }
            else if (compareResultValue == 0) //  is the same
            {
                relationResult = "is the same as";
            }


            else if (compareResultValue > 0)    //  comes after '  
            {
                relationResult = "greater than";
            }

            return relationResult;




        }







        /*
            6. Write a C# Sharp program to perform an ordinal comparison of two strings that only differ in case.
                Expected Output :
                    Compare the numeric values of the corresponding Char objects in each string.
                    str1 = 'JAVA', str2 = 'python'
                    String 'JAVA' is less than String 'python'.
        */


        public static void OrdinalComparisonOfTwoStrings()
        {

            //  identifying texts(Strings) that i want to compare
            String text1 = "JAVA";
            String text2 = "python";


            //  comparing with ordinal the two strings
            int copareOrdinalValue = String.CompareOrdinal(text1, text2);

            //  geting relation between the two String based on the value of the comparison
            String copareOrdinalRelation = GetRelation(copareOrdinalValue);
            Console.WriteLine($"str1 = '{text1}', str2 = '{text2}'\nString '{text1}' is {copareOrdinalRelation} String '{text2}'.");



        }










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


        //  if the u are not comparing with another string return Bad argument: and the value then (value type)


        public static void compareGivenStringWithSetOfStrings(String StringValue, dynamic SetOfStringValue)
        {

            if (SetOfStringValue is String)
            {
                int CompareResult = String.Compare(StringValue, SetOfStringValue);
                Console.WriteLine($"Comparing '{StringValue}' with '{SetOfStringValue}': {CompareResult}");
            }
            else if (SetOfStringValue is Int32)
            {
                Console.WriteLine($"Bad argument: 123 ({SetOfStringValue.GetType()})");
            }
            else
            {
                Console.WriteLine("Bad argument: TestClass (type TestClass)");
            }









        }





        /*

            8. Write a C# Sharp program to compare the current string instance with another string.
                Expected Output :
                    The strings occur in the same position in the sort order.
                    The first string follows the second in the sort order.
                    The first string precedes the second in the sort order.
                    The first string precedes the second in the sort order.
                    The first string follows the second in the sort order.


         */

        public static void compareCurrentStringInstanceWithAnotherString(String currentString, String otherString)
        {

            int compareValue = String.Compare(currentString, otherString);

            if (compareValue < 0)  //  comes before
            {
                Console.WriteLine("The first string precedes the second in the sort order.");
            }
            else if (compareValue == 0) //  is the same
            {
                Console.WriteLine("The strings occur in the same position in the sort order.");
            }


            else if (compareValue > 0)    //  comes after '  
            {
                Console.WriteLine("The first string follows the second in the sort order.");
            }


        }





    }
}
