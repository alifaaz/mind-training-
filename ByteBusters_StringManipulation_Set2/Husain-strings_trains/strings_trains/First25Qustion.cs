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

        public static String textToWordstextToWordstextToWords(String Text)
        {
            String TrimedText = Text.Trim();            //  trim text to not store white Space

            String[] words = TrimedText.Split(" ");
            String showResult = "[" + String.Join(", ", words) + "]";
            return showResult;



        }






    }
}