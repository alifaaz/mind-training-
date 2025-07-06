namespace strings_trains
{
    internal class mainFile
    {
        static void Main(string[] args)
        {




            //  qestion 1 result

            Console.WriteLine("enter a text to find its length");

            //  calling function to ask for text then find length
            Console.WriteLine($"Output: {First25Qustion.StringLength()}");




            //  qustion 2 result

            Console.WriteLine("\nenter the text to turn to upper case");

            //   calling a function that turns text to upperCase
            Console.WriteLine($"Output: {First25Qustion.toUpperCaseConverter()}");




            //  qustion 3 result

            Console.WriteLine("\nenter the text to turn to Lower case");

            //   calling a function that turns text to LowerCase
            Console.WriteLine($"Output: {First25Qustion.toLowerCaseConverter()}");




            //  qustion 4 result

            Console.WriteLine("\nenter the text that u want to check for prefix first ");


            //  calling the fucction that checks for prefix
            Console.WriteLine($"Output: {First25Qustion.startWithPrefix()}");






            //  qustion 5 result  

            Console.WriteLine("\nenter the text that u want to check for Suffix first ");


            //  calling the fucction that checks for prefix
            Console.WriteLine($"Output: {First25Qustion.endsWithSuffix()}");



            //  qustion 6 result

            Console.WriteLine("\ntesting if the string is numeric");

            //  if Conversion Result is bigger than 0 that means it did covert to int
            //  so its numeric
            if (First25Qustion.StringToIntConverter() > 0)
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("False");

            }



            //  qustion 7 result

            Console.WriteLine("\ntesting if String is letters only:");

            //  if Conversion Result is lower than 0 that means it did not covert to int
            //  so its letters only String
            if (First25Qustion.StringToIntConverter() == 0)
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("False");

            }






            //  qustion 8 result

            Console.WriteLine("\ngiting title of a word ");
            String WordBeforeTitled = Console.ReadLine();
            Console.WriteLine(First25Qustion.Title(WordBeforeTitled));




            //  qustion 9 result
            Console.Write("\nEnter a word or evern a long text: ");
            String word = Console.ReadLine();

            Console.WriteLine(First25Qustion.OpesitesCaseConversion(word));


            //  qustion 10 result
            Console.WriteLine("\nEnter text to get list of words:");
            String textBefeoreTurningToWords = Console.ReadLine();

            Console.WriteLine(First25Qustion.stringToArrayFormat(textBefeoreTurningToWords));


            //  من وجاي راح اكتب كومنت عربي


            // حل السؤال ال11

            String[] arrayListToTestQ11 = ["hello", "word"];
            String stringOfWords = First25Qustion.listToArrayConverison(arrayListToTestQ11);
            Console.WriteLine(stringOfWords);

            //  حل السؤال ال 12

            String BeforeTrimString = "    hello   ";
            String afterTrimingString = BeforeTrimString.Trim();
            Console.WriteLine(afterTrimingString);


            //  حل السؤال ال 13

            String textstringQ13 = "The books that are on the table are mine, and the pens that are nearby are also included.";
            Console.WriteLine(First25Qustion.Count(textstringQ13, "are", false));


            //  حل سؤال 14

            String textCheckQ14 = "user@example.com";
            Console.WriteLine(First25Qustion.EmailCheck(textCheckQ14));



            //  حل السؤال ال 15


            String StringTestQ15 = "characters";
            Console.WriteLine(First25Qustion.firstFiveLetters(StringTestQ15));

            //  حل السؤال ال 16


            String StringTestQ16 = "characters";
            Console.WriteLine(First25Qustion.lastThreeLetters(StringTestQ16));


            //  حل السؤال ال 17

            String StringTestQ17 = "a,b,c";
            Console.WriteLine(First25Qustion.replacingCommasWithSemicolons(StringTestQ17));


            //  حل السؤال ال 18


            String word1 = "listen";
            String word2 = "silent";


            Console.Write(First25Qustion.areAnagrams(word1, word2));


            //  حل السؤال ال 19

            //  نرتب المصفوفة بالطرية الي يريد نطبعها


            String inputQ19 = "a1b2c3";

            List<String> listOfTheNumbers = First25Qustion.numericListFunction(inputQ19);

            String ListFormat = "[ "+(String.Join(", ", listOfTheNumbers))+ " ]";
           
           Console.WriteLine(ListFormat);


























        }
























    }
}
