using System;
using System.Text.RegularExpressions;

namespace RegularExpression1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 1. Match all phone numbers in a local format like 0790xxxxxxx.
             in this question first we make an object of regex class and pass the pattern to it, then we use matches
             method to find all matching phone number in the given text.
             */
            string phoneText = "My number is 07901234567.";
            Regex phoneRegex = new Regex(@"\b0790\d{7}\b");
            Console.WriteLine(" Phone numbers: " + string.Join(", ", phoneRegex.Matches(phoneText)));

            /* 2.Match all email addresses.
               also at first we make an object of regex class and pass the pattern to it. [A-Za-z0-9,_%+-] this means start with letter ignore the 
            case and then can be digits or it can have special characters then + this means it can repeat more then one time, followed by @
            symbol, again it can have more letters and digits and special charcters, followed by a dot then at least we need 2 more letters for the domain
            like .com, .io etc.
             */
            string emailText = "Contact me at all@example.com or support@halai.io";
            Regex emailRegex = new Regex(@"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b");
            Console.WriteLine("Emails: " + string.Join(", ", emailRegex.Matches(emailText)));


            /* 3. Match any word that starts with a capital letter
               also at first we make an object of regex class and pass the pattern to it, then we use matches method
            to find all matching word in the given text. [A-Z] means start the word with a capital letter followed by [a-z] which means
            lowercase letters, + means it can repeat more then one time.
             */

            string properNounText = "All went to Basra and met Noor.";
            Regex properNounRegex = new Regex(@"[A-Z][a-z]+");
            Console.WriteLine("Proper nouns: " + string.Join(", ", properNounRegex.Matches(properNounText)));

            /* 4. Match all numbers (integers only)
            again at first we make an object of regex class and pass the pattern to it, then we use matches method 
            to find all matching numbers in the given text. \d means detect any digit from 0 to 9, \b means word boundary
            ensures we get whole numbers.
            */

            string numbersText = "I have 2 cats and 10 chickens.";
            Regex numbersRegex = new Regex(@"\b\d+\b");
            Console.WriteLine("Numbers: " + string.Join(", ", numbersRegex.Matches(numbersText)));

            /*5. Match all hashtags
           we do the same as other questions, #\w+ means match any word that starts with # followed by one or more
            word characters it can be letters, digits or underscore.
           */
            string hashtagText = "#blessed #codingLife";
            Regex hashtagRegex = new Regex(@"#\w+");
            Console.WriteLine("Hashtags: " + string.Join(", ", hashtagRegex.Matches(hashtagText)));


            /* 6. Match all words ending in "ing"
         we do the same as other questions,\w+ing means match any word that starts with a word characters and ends with ing,
            \b means word boundary ensures we get whole words.
         */
            string ingText = "I am coding, running, and learning.";
            Regex ingRegex = new Regex(@"\b\w+ing\b");
            Console.WriteLine("Words ending with 'ing': " + string.Join(", ", ingRegex.Matches(ingText)));

            /*8. Match time like 12:30 or 04:55
        we do the same as other questions,\d means any digit, {2} means exactly 2 digits which is the hour then again after : 
            do the same for minutes.
        */
            string timeText = "The meeting is at 12:30.";
            Regex timeRegex = new Regex(@"\b\d{2}:\d{2}\b");
            Console.WriteLine("Times: " + string.Join(", ", timeRegex.Matches(timeText)));

            /*9. Match dates like 2025-07-10
      we do the same as other questions,\d means any digit, {4} means exactly 4 digits which is the year then again after - 
          do the same for month and day, \b means word boundary ensures we get the whole date.
      */
            string dateText = "Today is 2025-07-10";
            Regex dateRegex = new Regex(@"\b\d{4}-\d{2}-\d{2}\b");
            Console.WriteLine("Dates: " + string.Join(", ", dateRegex.Matches(dateText)));

            /*11. Match words starting with "un"
             we do the same as other questions, starting with un any word followed by \w means any word characters
            also + can repeat then \b boundary of the word.
  */
            string unText = "unknown, unhappy, unlocked";
            Regex unRegex = new Regex(@"\bun\w+\b");
            Console.WriteLine("11. Words starting with 'un': " + string.Join(", ", unRegex.Matches(unText)));


            /*13. Validate username (alphanumeric, 4-12 chars)
            ^ means start of the string, [a-zA-Z0-9] means it can be any letter or digit, {4,12} means it can be 
            between 4 to 12 characters long, $ means the end of the string.
  */
            string usernameText = "Ali123";
            Regex usernameRegex = new Regex(@"^[a-zA-Z0-9]{4,12}$");
            Console.WriteLine("13. Is username valid? " + usernameRegex.IsMatch(usernameText));
        }
    }
}