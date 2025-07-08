using System.Text.RegularExpressions;

namespace StringManipulation_2ndSet_Zahra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;


            while (true)
            {
                Console.Write("Hello, World!\nEnter your string...");
                string UserString = Console.ReadLine();

                if (UserString == null)
                {
                    Console.WriteLine("Bruh, you need to write something...");
                    return;
                }
                var result = StringFunctions.TranslateToArabic(UserString);
                Console.WriteLine(result + "\n");
                // string.Join means joining the elements of the array with a separator
                //Console.WriteLine($"--> [\'{string.Join("\',\'", sols)}\']\n");

                //Console.WriteLine($"{StringFunctions.FormatPhoneNumber(UserString)}\n");

            }
            /* print an array of words FROM string[] SplitIntoWords(string string1) sunction
            string[] words = StringFunctions.SplitIntoWords(UserString);
            Console.WriteLine("Words in the string:");
            Console.Write("[");
            foreach (string word in words)
            {
                Console.Write($"'{word}' ");
            }
            Console.Write("]\n");

            // Join words back into a single string
            string joinedString = StringFunctions.JoinWords(words);
            Console.WriteLine($"Joined string: '{joinedString}'");*/
        }
    }
}