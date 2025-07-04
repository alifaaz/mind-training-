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

            Console.WriteLine(First25Qustion.textToWordstextToWordstextToWords(textBefeoreTurningToWords));
        }
    }
}
