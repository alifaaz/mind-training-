using System.Diagnostics.Metrics;

namespace strings_trains
{
    internal class First25Qustion
    {
        /*  Exercise 1  :
         
                English: Count the number of characters in a string.
                Arabic: احسب عدد الأحرف في سلسلة.

                Example (English): Input: 'hello' -> Output: 5
                    مثال (بالعربية): الإدخال: 'hello' ← الناتج: 5

         */

        public static int StringLength()
        {

            //  user input
            Console.Write("Input: ");
            String text = Console.ReadLine();

            //  get length of the text
            int Length = text.Length;
            return Length;

        }


        /*  Exercise 2  :
                
                English: Convert a string to uppercase.
                Arabic: حوّل سلسلة إلى أحرف كبيرة.

                Example (English): Input: 'hello' -> Output: 'HELLO'
                مثال (بالعربية): الإدخال: 'hello' ← الناتج: 'HELLO'

         */

        public static String toUpperCaseConverter()
        {
            //  user input
            Console.Write("Input: ");
            String text = Console.ReadLine();

            //  turn text to upper case
            String UpperCaseText = text.ToUpper();
            return UpperCaseText;
        }





        /*  Exercise 3  :
                
                English: Convert a string to lowercase.
                Arabic: حوّل سلسلة إلى أحرف صغيرة.
                Example(English): Input: 'HELLO' -> Output: 'hello'
                مثال(بالعربية) : الإدخال: 'HELLO' ← الناتج: 'hello'
          
         */


        public static String toLowerCaseConverter()
        {
            //  user input
            Console.Write("Input: ");
            String text = Console.ReadLine();

            //  turn text to upper case
            String LowerCaseText = text.ToLower();
            return LowerCaseText;
        }


        /*  Exercise 4  :

                English: Check if a string starts with a given prefix.
                Arabic: تحقق مما إذا كانت السلسلة تبدأ بمقدمة معينة.
                Example (English): Input: 'welcome', Prefix: 'wel' -> Output: True
                مثال (بالعربية): الإدخال: 'welcome'، المقدمة: 'wel' ← الناتج: صحيح
                
        */



        public static bool startWithPrefix()
        {
            //  user input
            Console.Write("Input: ");
            String text = Console.ReadLine();

            //  get prefix from user
            Console.Write("write the Prefix you want us to check: ");
            String Prefix = Console.ReadLine();


            //  returning result if the text start with the same prefix return True if not return False
            bool DoesStartWithPerfix = text.StartsWith(Prefix);
            return DoesStartWithPerfix;




        }



        /*  Exercise 5  :
                  

                English: Check if a string ends with a given suffix.
                Arabic: تحقق مما إذا كانت السلسلة تنتهي بنهاية معينة.
                Example (English): Input: 'file.txt', Suffix: '.txt' -> Output: True
                مثال (بالعربية): الإدخال: 'file.txt' ← الناتج: صحيح
         
        
        */



        public static bool endsWithSuffix()
        {
            //  user input
            Console.Write("Input: ");
            String text = Console.ReadLine();

            //  get prefix from user
            Console.Write("write the Suffix you want us to check: ");
            String Suffix = Console.ReadLine();


            //  returning result if the text start with the same prefix return True if not return False
            bool DoesStartWithPerfix = text.EndsWith(Suffix);
            return DoesStartWithPerfix;




        }




        /*  Exercise 6  :
         
                English: Check if a string contains only digits.
                Arabic: تحقق مما إذا كانت السلسلة تحتوي فقط على أرقام.
                Example (English): Input: '123456' -> Output: True
                مثال (بالعربية): الإدخال: '123456' ← الناتج: صحيح
        */





        //  we use TryParse to get two values bool and int
        //  we use the bool value (success) to know if it is possible to turn String to numbers(int)
        //  and use int value (ConversionResult) to return the result of the Convert
        public static int StringToIntConverter()
        {
            String UserInputText = Console.ReadLine();

            bool success = int.TryParse(UserInputText, out int ConversionResult);

            if (success)
            {
                return ConversionResult;

            }
            else
            {
                return 0;
            }


        }


        /*  Exercise 7  :
         
                English: Check if a string contains only letters.
                Arabic: تحقق مما إذا كانت السلسلة تحتوي فقط على أحرف.
                Example (English): Input: 'hello' -> Output: True
                مثال (بالعربية): الإدخال: 'hello' ← الناتج: صحيح
        */


        //  we dont have to make a Function for it we can just use the StringToIntConverter() function
        //  form previous Exercise








        /*  Exercise 8  :
         
                English: Capitalize the first character of a string.
                Arabic: اجعل أول حرف في السلسلة كبيرًا.
                Example (English): Input: 'hello' -> Output: 'Hello'
                مثال (بالعربية): الإدخال: 'hello' ← الناتج: 'Hello'
        */


        public static String Title(String UserInputWord)
        {


            Char firstLetter = Char.ToUpper(UserInputWord[0]);    //  capitalize first Letter

            //  or String firstLetter = (UserInputText[0].ToString).ToUpper();

            String RestOfText = UserInputWord.Substring(1);     //  cliping the rest of the word after taking first letter

            String TitleWord = firstLetter + RestOfText;    //  joining the to parts to get titled word

            return TitleWord;

        }





        /*  Exercise 9  :

                English: Swap the case of each character in a string.
                Arabic: بدّل حالة كل حرف في السلسلة.
                Example (English): Input: 'HeLLo' -> Output: 'hEllO'
                مثال (بالعربية): الإدخال: 'HeLLo' ← الناتج: 'hEllO'

        */

        public static String OpesitesCaseConversion(String UserTextInput)
        {

            //  remving white space because its not nessery to leave 
            String UserTextInputWitoutWhiteSpace = UserTextInput.Trim();

            //  geting the letters of the user text to convert their case one by one
            Char[] userLetters = UserTextInputWitoutWhiteSpace.ToCharArray();

            //  making List array that store each opsite case of each letter 
            List<Char> newWordArray = new List<Char>();
            foreach (Char Letter in userLetters)
            {

                if (Letter == Char.ToUpper(Letter))      // if the letter is Upper turn  to lower
                {

                    newWordArray.Add(Char.ToLower(Letter));


                }
                else                    // if the letter is lower turn  to upper
                {
                    newWordArray.Add(Char.ToUpper(Letter));
                }
            }


            String newWord = String.Concat(newWordArray);

            return newWord;

        }










        /*  Exercise 10  :
         
                English: Split a string into words.
                Arabic: قسّم السلسلة إلى كلمات.
                Example (English): Input: 'hello world' -> Output: ['hello', 'world']
                مثال (بالعربية): الإدخال: 'hello world' ← الناتج: ['hello', 'world']
        */



        //  we use split to turn String Text to seperate words in Array 




        public static String stringToArrayFormat(String Text)
        {
            String TrimedText = Text.Trim();            //  trim text to not store white Space

            String[] wordsArray = TrimedText.Split(" ");
            String showResult = arrayFormat(wordsArray);
            return showResult;



        }

        //  نكدر نسوي فنكشن شغلتها تطبع صيغة المصفوفة

        public static String arrayFormat(String[] words)
        {

            String showResult = "[" + String.Join(", ", words) + "]";
            return showResult;
        }




        /*
        Exercise 11  :
        English: Join a list of words into a string.
        Arabic: حوّل قائمة كلمات إلى سلسلة واحدة.
        Example (English): Input: ['hello', 'world'] -> Output: 'hello world'
        مثال (بالعربية): الإدخال: ['hello', 'world'] ← الناتج: 'hello world'
        */


        /*
            نستخدم الجوين حتى نربط عناصر المصفوفة سوية ونحولها  لسترنك
        
        */
        public static String listToArrayConverison(String[] arrayWords)
        {
            String StringOfWords = String.Join(" ", arrayWords);
            return StringOfWords;
        }




        /*
        Exercise 12  :
        English: Remove leading and trailing whitespace from a string.
        Arabic: احذف الفراغات من بداية ونهاية السلسلة.
        Example (English): Input: '  hello  ' -> Output: 'hello'
        مثال (بالعربية): الإدخال: '  hello  ' ← الناتج: 'hello'
        */

        //  هنانه ما احتاج فنكشن حتى اسوي مطلب السؤال هيه موجودة من الاصل


        /*
        Exercise 13  :
        English: Count the number of spaces in a string.
        Arabic: احسب عدد الفراغات في السلسلة.
        Example (English): Input: 'a b c' -> Output: 2
        مثال (بالعربية): الإدخال: 'a b c' ← الناتج: 2
        */

        /*شلون نسوي فنكشن حساب عدد مرات المقاطع المتكررة بالجملة*/
        //  اول شي نحول العبارة الى حرف صغير اذا ما راد المتخدم حساسية الاحرف الكبيره عن الصغيره
       
        
        
        public static int Count(String fullText,String PartOfText,bool CaseSensitive)
        {
            if (!CaseSensitive)
            {
                PartOfText = PartOfText.ToLower();
            }

            //   اخذ النص الكامل اعرف طوله واسوي لوب على اساس طوله حتلى يشمل الفحص كل النص 

            int FullTextLength = fullText.Length;


            //  هسه اعرف طول جزء النص المطلوب فحص تكراره

            int L = PartOfText.Length;

            int counter = 0;

            //  يبدي بالصفر وينهي بالهل قيمة حتى مجاوز طول النص الكامل وطلع خطأ ويزداد واحد واحد
            for (int i = 0;i<= FullTextLength-L;i++)   
            {

                //  اخذ مقطع من النص الاساسي للمقارنة بي
                //  يبدي بنقطة البداية وينهي بطول النص المطلوب

                String comparingPart = fullText.Substring(i, L);

                //  نبحث عن تشابه اذا صار تشابه نزيد العداد واحد
                int checkingForMaches = String.Compare(comparingPart,PartOfText, !CaseSensitive);
                if (checkingForMaches == 0) 
                {
                    counter++;
                }
                
                
            }

            return counter;

        }




        /*
        Exercise 14  :
        English: Check if a string is an email address format.
        Arabic: تحقق مما إذا كانت السلسلة بصيغة بريد إلكتروني.
        Example (English): Input: 'user@example.com' -> Output: True
        مثال (بالعربية): الإدخال: 'user@example.com' ← الناتج: صحيح
        */

        /*حسب فهمي للسؤال انو يريد اجيك اذا جان ايميل معين
         @exapmle.comeمثل */
        public static bool EmailCheck(String emailToBeTested)
        {
            //  افصل النص على اساس @ واجيك الباقي اذا هوه ايميل 
            String[] UserEmailArry = emailToBeTested.Split('@');
            
            //  نتاكد انو جزء الاسم للايمل ما بي فراغ او نقطة
            bool leftSideConditionsMeet = ((!UserEmailArry[0].Contains(" ")) & (!UserEmailArry[0].Contains(".")));

            //  ثانيا الجزء الثاني لازم يسوايلي نفس نوع الايميل الاريده
            bool rightSideConditionsMeet = UserEmailArry[1] == "example.com";


            //  true اذا تحقق الشرطين يطلع
            if ((leftSideConditionsMeet) & (rightSideConditionsMeet)) {
                return true;
            }
            else
            {
                return false;
            }
        }



        /*
        Exercise 15  :
        English: Get the first 5 characters of a string.
        Arabic: احصل على أول 5 أحرف من السلسلة.
        Example (English): Input: 'abcdefg' -> Output: 'abcde'
        مثال (بالعربية): الإدخال: 'abcdefg' ← الناتج: 'abcde'
        */

        public static String firstFiveLetters(String text) {

            String firstFiveLetters = text.Substring(0,5);
            return firstFiveLetters;
        
        
        }

        /*
        Exercise 16  :
        English: Get the last 3 characters of a string.
        Arabic: احصل على آخر 3 أحرف من السلسلة.
        Example (English): Input: 'abcdefg' -> Output: 'efg'
        مثال (بالعربية): الإدخال: 'abcdefg' ← الناتج: 'efg'
        */

        public static String lastThreeLetters(String text)
        {
            int postionOfLastThreeLetters = text.Length - 3;
            String lastThreeLetters = text.Substring(postionOfLastThreeLetters, 3);
            return lastThreeLetters;


        }


        /*
        Exercise 17  :
        English: Replace commas with semicolons in a string.
        Arabic: استبدل الفواصل بفواصل منقوطة.
        Example (English): Input: 'a,b,c' -> Output: 'a;b;c'
        مثال (بالعربية): الإدخال: 'a,b,c' ← الناتج: 'a;b;c'
        */

        public static String replacingCommasWithSemicolons(String text) 
        {

            String afterResult = text.Replace(",",";") ; 
            return afterResult;

        }





        /*
        Exercise 18  :
        English: Check if two strings are anagrams.
        Arabic: تحقق مما إذا كانت سلسلتان هما أناغرام.
        Example (English): Input: 'listen', 'silent' -> Output: True
        مثال (بالعربية): الإدخال: 'listen' و 'silent' ← الناتج: صحيح
        */


        public static String areAnagrams(String word1 , String word2)
        {
            //  نحول الكلمتين الى مصفوفتين احرف 
            char[] WordArray1 = word1.ToCharArray();


            char[] WordArray2 = word2.ToCharArray();


            //  نرتب المصفوفتين
            char[] b = WordArray1;
            Array.Sort(WordArray1);
            char[] a = WordArray1;
            Array.Sort(WordArray2);

            //  نرجع المصفوفتين لنص لتسهيل المقارنه

            String Word1AfterSorted = new string(WordArray1);
            String Word2AfterSorted = new string(WordArray2); 


            //  نقارن المصفوفتين اذا متشابه معناها هيه اناغرام

            if (Word1AfterSorted == Word2AfterSorted)
            {
                return "True";
            }
            else
            {
                return "False";
            }

        }

        /*
        Exercise 19  :
        English: Find all the digits in a string.
        Arabic: استخرج جميع الأرقام من السلسلة.
        Example (English): Input: 'a1b2c3' -> Output: ['1', '2', '3']
        مثال (بالعربية): الإدخال: 'a1b2c3' ← الناتج: ['1', '2', '3']
        */
        public static List<String> numericListFunction(String text1)
        {

            //  نسوي مصفوفت لست حتة اجمع بيها الارقام
            List<String> numericList = new List<String>();


            
            for(int i = 0; i < text1.Length; i++)
            {
                bool success = int.TryParse(text1[i].ToString(), out int number);
                if (success) 
                {
                    String numberInChar = Convert.ToString(number);
                    numericList.Add(numberInChar);

                } 



            }
            return numericList;



        }
























    }
}
