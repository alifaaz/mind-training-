
﻿using System;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
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

            // Q13
            // CheckIfWordSubStringFromSentence("'Kill two birds with one stone'", "birds");

            // Q14
            // CopyAndAssign2Variables("JAVA", "Python");
            // Q15
            //CheckIfStringHaveDotAtTheEnd("Actions speak louder than words.");
            //CheckIfStringHaveDotAtTheEnd("Actions speak louder. than words");
            //Q16
            // CheckIfStringOccursAtTheEndOfAnotherString("abcЙࠉ", "Å");

            //Q17
            //CheckIfStringEndWithParticularSubString("xyzPQR", "PQR");
            // Q18
            //ReverseGivenStringAndUpperIt("aabb");
            // Q19
            //ReverseGivenStringAndUpperIt("java");
            //Q20
            //string OriginalString = "aaaaabbbbccc";
            //string StringAfterRemovingDuplicates = RemoveDuplicateFromString(OriginalString);
            //Console.WriteLine("Original String: " + OriginalString);
            //Console.WriteLine("After removing duplicates: " + StringAfterRemovingDuplicates);

            //Q21
            //string input = "BDEFGAABEF";
            //int LongestSubStringLength = FindLengthOfLongestSubstringWithoutRepeating(input);
            //Console.WriteLine("Original String: " + input);
            //Console.WriteLine("Length of the longest substring without repeating characters of the said string:");
            //Console.WriteLine(LongestSubStringLength + "\n");

            // Q22
            // string str = "Java Sicript";
            // Console.WriteLine("Original string: " + str);
            // Console.WriteLine("After reversing the case of all characters of the said string: " + ReverseUpperToLowerAndLowerToUpper(str));
            //Q23
            // CheckIfStringIsIsogram("programming");

            //Q24
            //GetMiddleCharactersOfString("cola");
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

        static void ConcatenateThreeStringsAndDisplay()
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

        static void ConcatenateStringArrayValues()
        {
            string[] words = { "hello", "welcome", "to", "C#", "Sharp", "create", "Windows", "client", "applications" };
            // here i gonna print it in the same way that i add it 

            string Concatenate1 = string.Join(" ", words);

            Console.WriteLine(Concatenate1);

            string Concatenate2 =
                words[0] + " " + words[8] + words[3] + " " + words[4] + " " + words[7] + " " + words[5] + " " + words[2] + " " + words[1] + " " + words[6];
            Console.WriteLine(Concatenate2);
        }

        /////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////

        //13. Write a C# Sharp program to determine whether the string "birds"
        //    is a substring of a familiar string.

        //Note : Quotation 'two birds with one stone'.

        //Expected Output :

        //'birds' is in the string 'Kill two birds with one stone': True                   
        //'birds begins at character position 10 

        //sol
        // i will declare 2 vaiabiles one for sentence and one for the word
        // i will use IndexOf() method to check if its there and from which index it start

        static void CheckIfWordSubStringFromSentence(string sentence, string word)
        {
            // use IndexOf() method to check if word in sentence
            // and from which index it start
            int CheckIfWordInSentense = sentence.IndexOf(word);

            if (CheckIfWordInSentense != -1)
            {
                Console.WriteLine($"'{word}' is in the string '{sentence}' : True");
                Console.WriteLine($"'{word}' begins with position {CheckIfWordInSentense}");
            }
            else
            {
                Console.WriteLine($"'{word}' is not in the Quotation sentence '{sentence}'");
            }

        }

        // 14. Write a C# Sharp program to create two string objects with different values.
        // When it calls the Copy method to assign the first value to the second string,
        // the output indicates that the strings represent different object references.
        // However, their values are now equal.On the other hand, when the first string is assigned
        // to the second string, the two strings have identical values.
        // This is because they represent the same object reference.

        // Expected Output :

        // s1 = 'JAVA'
        // s2 = 'Python''

        /* هنا راح استعمل دالة الكوبي الخاصة بالسترنك 
         * وبعدها اجرب اساوي القيم واشوف شنو يصير
         * 
         * طبعا اني اعرف شنو يصير فراح اطبع العنوان الخاص بالمتغير بالذاكرة 
         * حتى ابين الفرق بين الطريقتين
         */

        static void CopyAndAssign2Variables(string str1, string str2)
        {
            // هنا حاولت استعمل ال& والبوينتر* بس مكدرت بالسترنك وبالسي شارب
            // فبت عن دالة تساعدني اوصل للرفرنس بس مو حقيقي بلذاكرة
            // 
            int RefrenseOfStr1 = RuntimeHelpers.GetHashCode(str1);
            int RefrenseOfStr2 = RuntimeHelpers.GetHashCode(str2);

            // show the strings and there address
            Console.WriteLine($"s1 = {str1} and address of s1: {RefrenseOfStr1}");
            Console.WriteLine($"s2 = {str2} and address of s2: {RefrenseOfStr2} \n\n");

            // هنا راح اجرب استعمل الكوبي من كلاس السترنك
            str2 = String.Copy(str1);
            // ارجع اخزن من جديد حتى نشوف شنو تغير
            RefrenseOfStr1 = RuntimeHelpers.GetHashCode(str1);
            RefrenseOfStr2 = RuntimeHelpers.GetHashCode(str2);

            Console.WriteLine($"s1 = {str1} and address of s1: {RefrenseOfStr1}");
            Console.WriteLine($"s2 = {str2} and address of s2: {RefrenseOfStr2}\n\n");


            str2 = str1;
            // ارجع اخزن من جديد حتى نشوف شنو تغير بعد ما استعملت المساواة
            RefrenseOfStr1 = RuntimeHelpers.GetHashCode(str1);
            RefrenseOfStr2 = RuntimeHelpers.GetHashCode(str2);

            Console.WriteLine($"s1 = {str1} and address of s1: {RefrenseOfStr1}");
            Console.WriteLine($"s2 = {str2} and address of s2: {RefrenseOfStr2}");

        }

        // 15. Write a C# Sharp program to indicate whether each string in an array ends with a period (".").

        // Expected Output :

        // 'Actions speak louder than words' ends in a period: False                        
        // 'Hello!' ends in a period: False                                                 
        // 'Python.' ends in a period: True                                                 
        // 'PHP.' ends in a period: True                                                    
        // 'random' ends in a period: False

        // راح اعرف متغير يحتوي على النقطة 
        // واستعمل دالة تشوف اذا النقطة موجودة بنهاية الجملة او لا
        // اطبع ترو اذا موجودة واطبع فالس اذا مموجودة

        static void CheckIfStringHaveDotAtTheEnd(string sentence)
        {
            char dot = '.';
            // نشوف اذا النقطة موجودة بنهاية الجملة لو لا عن طريق دالة ايند وذ 
            bool IfSentenceEndWithDot = sentence.EndsWith(dot.ToString());

            // اذا الجملة تنتهي بنقطة
            if (IfSentenceEndWithDot)
            {   // اطبع ترو
                Console.WriteLine($"'{sentence}' ends in a period : True");
            }
            else // واذا لا اطبع فولس
            {
                Console.WriteLine($"'{sentence}' ends in a period: False ");
            }
        }
        // 16. Write C# Sharp program to check whether a string occurs at the end of another string.

        // Expected Output :

        // Search for the target string "Å" in the string "abcЙࠉ".                                                       

        // Using the English(United Kingdom) - "en-GB" culture:                                                         
        // Case sensitive:                                                                                               
        //   The string to search ends with the target string: False

        // Case insensitive:                                                                                             
        //   The string to search ends with the target string: False

        // Using the English(Australia) - "en-AU" culture:                                                              
        // Case sensitive:                                                                                               
        //   The string to search ends with the target string: False

        // Case insensitive:                                                                                             
        //   The string to search ends with the target string: False

        // sol:
        // راح استمعمل دالة الايند وذ واسوي اربع متغيرات بوليان حتى اتحقق من كل حالة 
        // مطلوبة بالسؤال
        // واطبع النتائج نفس ما مطلوبة
        static void CheckIfStringOccursAtTheEndOfAnotherString(string str1, string str2)
        {

            bool CheckifStr1EndWithStr2_CaseSensitiveEnGBCulture = str1.EndsWith(str2, false, new CultureInfo("en-GB"));
            Console.WriteLine("Case Sensitive \"En-GB\" Culture");
            Console.WriteLine($"The string to search ends with the target string: {CheckifStr1EndWithStr2_CaseSensitiveEnGBCulture} \n");

            bool CheckifStr1EndWithStr2_CaseInSensitiveEnGBCulture = str1.EndsWith(str2, true, new CultureInfo("en-GB"));
            Console.WriteLine($"Case In Sensitive \"En-GB\" Culture ");
            Console.WriteLine($"The string to search ends with the target string: {CheckifStr1EndWithStr2_CaseInSensitiveEnGBCulture} \n");

            bool CheckifStr1EndWithStr2_CaseSensitiveEnAUCulture = str1.EndsWith(str2, false, new CultureInfo("en-AU"));
            Console.WriteLine($"Case Sensitive \"En-AU\" Culture  ");
            Console.WriteLine($"The string to search ends with the target string: {CheckifStr1EndWithStr2_CaseSensitiveEnAUCulture} \n");

            bool CheckifStr1EndWithStr2_CaseInSensitiveEnAUCulture = str1.EndsWith(str2, true, new CultureInfo("en-AU"));

            Console.WriteLine($"Case In Sensitive \"En-AU\" Culture");
            Console.WriteLine($"The string to search ends with the target string: {CheckifStr1EndWithStr2_CaseInSensitiveEnAUCulture}");
        }

        // 17. Write a C# Sharp program to determine whether a string ends with a particular substring.

        // Note : The results are affected by the choice of culture, whether case is ignored, and whether an ordinal comparison is performed.

        // Expected Output :

        // Determine whether a string ends with another string, using                       
        // different values of StringComparison.
        // The current culture is en-US.

        // StringComparison.CurrentCulture:                                                 
        // "xyzPQR" ends with "PQR".                                                        
        // "xyzPQR" ends with "PQR".


        //Sol
        // فكرته قريبة للسؤال القبلة بس فرق بانواع المقارنة والطباعة
        // هلمرة راح استخدم دالة
        // StringComparison.
        //  enum واللي هية   
      
        static void CheckIfStringEndWithParticularSubString (string str1, string str2)
        {
            bool CheckifStr1EndWithStr2_CurrentCultureCaseSensitive = str1.EndsWith(str2, StringComparison.CurrentCulture);
            Console.WriteLine("Current Culture Case Sensitive");
            Console.WriteLine($"{str1} ends with {str2} : {CheckifStr1EndWithStr2_CurrentCultureCaseSensitive} \n");

            bool CheckifStr1EndWithStr2_CurrentCultureIgnoreCase = str1.EndsWith(str2, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine("Current Culture Ignore Case");
            Console.WriteLine($"{str1} ends with {str2} : {CheckifStr1EndWithStr2_CurrentCultureIgnoreCase}\n");

            bool CheckifStr1EndWithStr2_OrdinalCaseSensetive = str1.EndsWith(str2, StringComparison.Ordinal);
            Console.WriteLine("Ordinal");
            Console.WriteLine($"{str1} ends with {str2} : {CheckifStr1EndWithStr2_OrdinalCaseSensetive} \n");

            bool CheckifStr1EndWithStr2_OrdinalIgnoreCase = str1.EndsWith(str2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Ordinal Ignore Case");
            Console.WriteLine($"{str1} ends with {str2} : {CheckifStr1EndWithStr2_OrdinalIgnoreCase}");
        }

      

    
        // 19. Write a C# Sharp program to reverse a given string in uppercase.
           
        // Expected Output :
           
        // Original string: php
        // Said string in uppercase: PHP
        // Original string: java
        // Said string in uppercase: AVAJ
        // Original string: abcd
        // Said string in uppercase: DCBA

        //Sol 
        // راح استخدم متغيرين  واحد للجملة وواحد للجملة المعكوسة
        // استخدم فور لوب اقلب بيها الكلمة وبعدها اسويها كابتل بدالة
        // to upper
        static void ReverseGivenStringAndUpperIt (string GivenString)
        {
            string ReverseAndUpperTheGivenString = "";
            // هنا راح اخذ الطول من الاخير وانقص الأي واحد واحد
            for (int i = GivenString.Length - 1; i >= 0; i--)
            {   
                // راح احفظ الاحرف بمتغير جديد، راح ياخذ اخر حرف ويحطة بلبداية ويستمر ليما تنتهي الاحرف وتنعكس كل الكلمة
                ReverseAndUpperTheGivenString += GivenString[i];
            }
            // هنا راح اطبعها، بس قبلها راح اسويها كابتل وراها تنطبع
            Console.WriteLine(ReverseAndUpperTheGivenString.ToUpper());
        }


        // 20. Write a C# Sharp program to remove duplicate characters from a given string.

        // Expected Output :

        // Original String: aaaaaabbbbccc
        // After removing duplicates characters from the said string:
        // abc
        // Original String: Python
        // After removing duplicates characters from the said string:
        // Python
        // Original String: Java
        // After removing duplicates characters from the said string:
        // Jav

        //Sol
        // حيكون عدنا 3 متغيرات واحد للجملة وواحد للحرف الحالي حتى نقارن بيه
        // وواحد نحط بيه الكلمة بدون التكرار 
        // واسوي فور لوب حتى اخذ حرف حرف من السترنك للكاركتر


        static string RemoveDuplicateFromString (string str)
        {
            
            string StringWithoutDuplicate = "";
            // لوب يخلينا نفتر على كل عنصر بعناصر السترنك
            for (int i = 0; i < str.Length; i++)
            {
                char CurrentChar = str[i];
               // اذا السترنك المبيها تكرار ما تحتوي على الكركتر الحالي
                if (!StringWithoutDuplicate.Contains(CurrentChar))
                {
                    // ضيفلها الكرنت كركتر
                    StringWithoutDuplicate += CurrentChar;
                }
            }
            return StringWithoutDuplicate;
        }

        //21. Write a C# Sharp program to find the length of the longest substring without repeating characters in a given string.

        //Expected Output :

        //Original String: aaaaaabbbbccc
        //Length of the longest substring without repeating characters of the said string:
        //2
        //Original String: BDEFGAABEF
        //Length of the longest substring without repeating characters of the said string:
        //6
        //Original String: Python
        //Length of the longest substring without repeating characters of the said string:
        //6
        //Original String: Java
        //Length of the longest substring without repeating characters of the said string:
        //3

        //sol 
        // اخذ كلمة ، اسوي متغير احفظ بي السب سترنك، ومتغير لأطول سب سترنك 
        // ومتغير رابع للحرف الحالي حتى اقارن بيه
        // حسوي نستد لووب حتى نجيك مرتين مرة اذا الحرف متكرر نخرج للايلس والشرط الثاني يكون للطول اذا اكبر ناخذه
        static int FindLengthOfLongestSubstringWithoutRepeating(string input)
        {

            string CurrentSubString = "";
            int LengthOfLongestSubstring = 0;

            for (int i = 0; i < input.Length; i++)
            {
                CurrentSubString = "";

                for (int j = i; j < input.Length; j++)
                {
                    char CurrentChar = input[j];
                    // اذا جانت السب سترنك مبيها الكاركتر 
                    if (!CurrentSubString.Contains(CurrentChar))
                    { // ضيفها لمتغير السب سترنك
                        CurrentSubString += CurrentChar;
                    }
                    else // اذا بيها الكاركتر
                    {
                        break; //اطلع
                    }
                }
                // شرط حتى ناخذ طول اطول كلمة
                if (CurrentSubString.Length > LengthOfLongestSubstring)
                    LengthOfLongestSubstring = CurrentSubString.Length;
                // اذا مو اكبر يبقة نفسة تلقائيا الي هوة الاكبر
            }
            return LengthOfLongestSubstring;
        }
        
        //22. Write a C# Sharp program to reverse the case (upper->lower, lower->upper) of all the characters in a given string.
        //
        //Expected Output :
        //
        //Original string: PHP
        //After reversing the case of all characters of the said string: php
        //
        //Original string: JavaScript
        //After reversing the case of all characters of the said string: jAVAsCRIPT
        //
        //Original string: Python 3.0
        //After reversing the case of all characters of the said string: pYTHON 3.0

        //sol
        // راح اعرف متغيرين واحد يشوف اذا جان كابتل وواحد يشوف اذا جان سمول
        // بعدها اسوي السمول كبتل والكبتل سمول

        static string ReverseUpperToLowerAndLowerToUpper (string input)
        {

            string ReversedString = ""; // نخزن الحروف المعدلة هنا

            for (int i = 0; i < input.Length; i++)
            {
                char CurrentChar = input[i];

                // إذا كان كابتل نحوله الى سمول
                if (char.IsUpper(CurrentChar))
                {
                    ReversedString += char.ToLower(CurrentChar);
                }
                // إذا كان سمول نحوله الى كابتل
                else if (char.IsLower(CurrentChar))
                {
                    ReversedString += char.ToUpper(CurrentChar);
                }
                // إذا كان رقم او أي شيء ثاني نخليه نفس ما هوة
                else
                {
                    ReversedString += CurrentChar;
                }
            }
            return ReversedString;


        }
        // 23. Write a C# Sharp program to find the central character(s) in a given string.
        // Return the middle character if the string length is odd and return two middle characters
        // if the string length is even.
           
        // Expected Output :
           
        // Original string: Python
        // Middle character(s) of the said string: th
           
        // Original string: PHP
        // Middle character(s) of the said string: H
           
        // Original string: C#
        // Middle character(s) of the said string: C#


        // sol:
        // راح اجيك طول الكلمة اذا زوجي نطبع حرفين من الوسط واذا فردي نطبع حرف واحد

        static void GetMiddleCharactersOfString(string input)
        {
            int length = input.Length;

            // اذا طول الجملة فردي نطبع حرف واحد
            if (length % 2 != 0)
            {
                int MiddleIndex = length / 2;
                char MiddleChar = input[MiddleIndex];
                Console.WriteLine("Original string: " + input);
                Console.WriteLine("Middle character(s) of the said string: " + MiddleChar);
            }
            else // اذا طول الجملة زوجي نطبع حرفين
            {
                int MiddleIndex1 = (length / 2) - 1;
                int MiddleIndex2 = length / 2;

                string MiddleChars = input[MiddleIndex1].ToString() + input[MiddleIndex2].ToString();

                Console.WriteLine("Original string: " + input);
                Console.WriteLine("Middle character(s) of the said string: " + MiddleChars);
            }
        }
       

        // 25. Write a C# Sharp program to check whether a given string is an “isograms” or not. Return True or False.

        // Expected Output :
        // Original string: Python
        // Check the said string is an 'isograms' or not! True

        // sol:
        // نحول الحروف الى سمول ونتأكد اذا كل حرف يظهر مرة وحدة فقط

        static void CheckIfStringIsIsogram(string input)
        {
            string lower = input.ToLower();
            bool IsIsogram = true;

            for (int i = 0; i < lower.Length; i++)
            {
                char current = lower[i];

                if (lower.IndexOf(current) != lower.LastIndexOf(current))
                {
                    IsIsogram = false;
                    break;
                }
            }
            Console.WriteLine("Original string: " + input);
            Console.WriteLine("Check the said string is an 'isograms' or not! " + IsIsogram);
        }

    }
}
