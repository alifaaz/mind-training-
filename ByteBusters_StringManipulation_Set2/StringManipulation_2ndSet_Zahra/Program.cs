using System.Text.RegularExpressions;
namespace StringManipulation_2ndSet_Zahra
{
    class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                Console.Write("Hello, World!\nEnter your string...");
                string UserString = Console.ReadLine();

                if (UserString == null)
                {
                    Console.WriteLine("Bruh, you need to write something...");
                    return;
                }
                var digits = StringFunctions.IdentifyVerbs(UserString);
                Console.WriteLine($"--> [\'{string.Join("\',\'", digits)}\']\n");

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