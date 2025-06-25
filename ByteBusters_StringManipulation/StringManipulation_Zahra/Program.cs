namespace zahra
{
    class Program
        {

        /* Write C# Sharp program to demonstrate that the Compare(String, String, Boolean)
        method is equivalent to using ToUpper or ToLower when comparing strings.
        Expected Output :
        Comparing 'QRS' and 'qrs':                                                       
        The Strings are equal when capitalized? true                                     
        The Strings are equal when case is ignored? true
        ---
        To solve this task, I will creat a method called compareStrings that will take two strings from the user,
        I'll compare them using the string.Compare method with the ignoreCase parameter set to true (which ignores case differences),
        and then I'll compare them again using ToUpper() to see if the results are the same
        finally, I'll print the results to the console وبس والله
        */
        static void CompareStrings()
        {
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();

            // if compare(string str1, string str2) == 0 then the strings are equal even if they have different cases!
            bool CmpIgnoreCase = string.Compare(str1, str2, true) == 0;

            // now we'll see the results compared with ToUpper() function (supposed to be the same as CmpIgnoreCase)
            bool CmpIgnoreUpper = string.Compare(str1.ToUpper(), str2.ToUpper()) == 0;

            Console.WriteLine($"Comparing '{str1}' and '{str2}':");

            Console.WriteLine($"The Strings are equal when capitalized? {CmpIgnoreUpper}");
            Console.WriteLine($"The Strings are equal when case is ignored? {CmpIgnoreCase}");

        }

        /* Write a C# Sharp program to concatenate three strings and display the result.
        Expected Output :
        Don't count your chickens, before the eggs, have hatched
        ---
        I'll take three strings from the user and concatenate them using + operator then print the result
         */
        static void ConcatenateStrings()
        {
            // asking the user to enter three strings
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();
            Console.Write("Enter third string: ");
            string str3 = Console.ReadLine();

            // printing the concatenated strings by using + operator
            Console.WriteLine("\n" + str1 + ", " + str2 + ", " + str3);
        }

        /* Write a C# Sharp program to determine whether the string "birds" is a substring of a
        familiar string.
        Note : Quotation 'two birds with one stone'.
        Expected Output :
        'birds' is in the string 'Kill two birds with one stone': True
        'birds begins at character position 10
        ----
        To solve this task, I will first check if the substring "birds" is present in the string "Kill two birds with one stone"
        by using the string.Contains(substring) method if it finds it, then I'll find the position of the substring by using the string.IndexOf(substring) method
        and finally I'll print the results to the console :)
         */
        static void IsSubstring()
        {
            // NOTE: the solution can be dynamic by taking the strings from the user but for simplicity, I'll use the static way 

            //Console.WriteLine("Enter the main string: ");
            //string str = Console.ReadLine();
            //Console.WriteLine("Enter the substring to check: ");
            //string subStr = Console.ReadLine();

            string str = "Kill two birds with one stone";
            string subStr = "birds";

            // To check if the substring is in the string
            bool isInString = str.Contains(subStr);
            // To find the position of the substring in the string
            int position = str.IndexOf(subStr);

            Console.WriteLine($"'{subStr}' is in the string '{str}': {isInString}");
            // If the substring is found, print its position
            if (isInString)
                Console.WriteLine($"'{subStr}' begins at character position {position}");
        }

        /* Write a C# Sharp program to create two string objects with different values.
        When it calls the Copy method to assign the first value to the second string, the output
        indicates that the strings represent different object references. However, their values are
        now equal. On the other hand, when the first string is assigned to the second string, the two
        strings have identical values. This is because they represent the same object reference.
        Expected Output :
        s1 = 'JAVA'
        s2 = 'Python'
        ----
        To solve this task, I will create two string variables s1 and s2 with different values,
        then I'll use the string.Copy() to copy the value of s1 to s2,
        finally I'll print the values of both strings before and after the copy operation to show the difference
         */
        static void StringCopy()
        {
            Console.Write("Enter the first string:");
            string s1 = Console.ReadLine(); // "JAVA"
            Console.Write("Enter the second string:");
            string s2 = Console.ReadLine(); // "Python"

            // Showing the original values of s1 and s2
            Console.WriteLine($"s1 = '{s1}'");
            Console.WriteLine($"s2 = '{s2}'");

            // Copying the value of s1 to s2, copy() creates a new object reference for s2
            s2 = string.Copy(s1);

            //s2 = s1; // This would also work, but it doesn't create a new object reference

            Console.WriteLine($"\nAfter copying: \ns1 = '{s1}'");
            Console.WriteLine($"s2 = '{s2}'");

            //Console.WriteLine($"s1 and s2 are equal? {s1 == s2}"); // True
        }

        /*Write a C# Sharp program to indicate whether each string in an array ends with a period(".").
        Expected Output :
        'Actions speak louder than words' ends in a period: False
        'Hello!' ends in a period: False

        ----
        To solve this task, I will create an array of strings and take a number of sentences from the user,
        then I'll check if each sentence ends with a period using the string.EndsWith() method 
        */
        static void EndsWithPeriod()
        {
            Console.Write("How many sentences do you want?  ");
            int n = int.Parse(Console.ReadLine());
            string[] sentences = new string[n];

            // Taking the sentences from the user
            for (int i = 0; i < sentences.Length; i++)
            {
                Console.Write($"Sentence {i + 1}: ");
                sentences[i] = Console.ReadLine();
            }

            // Checking if each sentence ends with a period
            for (int i = 0; i < sentences.Length; i++)
            {
                bool endsWithPeriod = sentences[i].EndsWith(".");
                Console.WriteLine($"'{sentences[i]}' ends in a period: {endsWithPeriod}");
            }

        }

        /* Write a C# Sharp program to reverse a given string in uppercase.
        Expected Output :
        Original string: abcd
        Said string in uppercase: DCBA
        ----
        To solve this task, I will take a string from the user and convert it to uppercase
        then i'll create a character array from the string to store each character,
        then I'll reverse the character array using Array.Reverse() method then print it with a loop
         */
        static void ReverseStringUpper()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine().ToUpper();

            // creating a character array from the string
            char[] ToCharArray = str.ToCharArray();

            // reversing the character array then printing it
            Console.Write($"Said string in uppercase: ");
            Array.Reverse(ToCharArray);
            for (int i = 0; i < ToCharArray.Length; i++)
            {
                Console.Write(ToCharArray[i]);

            }
        }

        /* Write a C# Sharp program to reverse the case (upper->lower, lower->upper) of all the
        characters in a given string.
        Expected Output :
        Original string: JavaScript
        After reversing the case of all characters of the said string: jAVAsCRIPT
        -----
        To solve this task, I will take a string from the user,
        then I'll create a character array from the string to store each character,
        then I'll loop through the characters and check if each character is upper or lower case to reverse its case,
        finally I'll print the new string with the reversed case
        */
        static void ReverseCase()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            // making an empty string to store the reversed case characters
            string reversedCaseString = "";

            // converting the string to a character array
            char[] chars = str.ToCharArray();

            // checking each character and reversing its case
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsUpper(chars[i]))
                {
                    chars[i] = char.ToLower(chars[i]);
                }
                else if (char.IsLower(chars[i]))
                {
                    chars[i] = char.ToUpper(chars[i]);
                }
                // adding the character to the empty string
                reversedCaseString += chars[i];
            }
            Console.WriteLine($"Original string: {str}");   
            Console.WriteLine($"After reversing the case of all characters of the said string: {reversedCaseString}");
        }

        /*Write a C# Sharp program to find the central character(s) in a given string. Return the
        middle character if the string length is odd and return two middle characters if the string
        length is even.
        Expected Output :
        Original string: Python
        Middle character(s) of the said string: th
        ------
        To solve this task, i'll take the user's string and chech if its length is even or odd,
        if even , I'll take the two middle characters by calculating the middle index
        if odd, I'll take the one middle character using the same way
         */
        static void StringMiddleCharacter()
        {
            Console.Write("Original string: ");
            string str = Console.ReadLine();

            
            if (str.Length % 2 == 0) // even length
            {
                // two middle characters
                int midIndex = str.Length / 2;
                // we'll take the two characters at midIndex-1 and midIndex 
                // ex: midIndex = 3 for "Python" (length 6), so we take str[2] and str[3] = "th"
                Console.WriteLine($"Middle character(s) of the said string: {str[midIndex - 1]}{str[midIndex]}");
            }
            else // odd length
            {
                // one middle character
                int midIndex = str.Length / 2;
                Console.WriteLine($"Middle character(s) of the said string: {str[midIndex]}");
            }
        }

        /*24. Write a C# Sharp program to find the maximum and minimum number from a given string
        of numbers separated by a single space.
        Expected Output :
        Original string of numbers: 3 4 8 9 0 2 1
        Maximum and minimum number of the said string: 9, 0
        Original string of numbers: -2 -1 0 4 10
        Maximum and minimum number of the said string: 10, -2
        ----
        To solve this task i'll take the string, remove the spaces then put all the numbers inside an 
        array of integers. After that i'll print the max and min by using the bulit-in methods
        */
        static void MaxMinFromSrting()
        {
            Console.WriteLine("Original string of numbers: ");
            string str = Console.ReadLine();
            int length = str.Length;

            // Split the string into parts
            string[] parts = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Convert to integers
            int[] nums = Array.ConvertAll(parts, int.Parse);


            Console.WriteLine($"Maximum and minimum number of the said string: {nums.Max()}, {nums.Min()}");
        }

        /*39. Write a C# Sharp program to find the century of a given year.
        Sample Data:
        (1435) -> "15th century"
        ----
        To solve this task I'll take the year as an input from the user then i'll take the first two digits
        as a substring then i'll convert it to an integer to add 1 to find then print the centery of the given year.
         */
        static void CenturyOfYear()
        {
            Console.Write("Enter the year: ");
            string year = Console.ReadLine();

            // Take the first two digits
            string subYear = year.Substring(0, 2);
            // Convert them to int and add 1 to it 
            int centery = int.Parse(subYear) + 1;
            
            // Print the result, if it ends with 1 add st, 2 nd, 3 rd else print th
            if (centery % 10 == 1)
                Console.WriteLine($"({year})-> \"{centery}st century\"");
            else if (centery % 10 == 2)
                Console.WriteLine($"({year})-> \"{centery}nd century\"");
            else if (centery % 10 == 3)
                Console.WriteLine($"({year})-> \"{centery}rd century\"");
            else
                Console.WriteLine($"({year})-> \"{centery}th century\"");
        }

        /*33. Write a C# Sharp program to reverse a positive integer and add the reversed number to
        the original number.
        Sample Data:
        (456) - > 456654
        (-123) -> "Input a positive number."
        ------
        To solve this task, I'll take an integer from the user if the number is positive, i'll convert it to a string,
        then I'll reverse the string and concatenate it with the original number, finally I'll print the result.
        if the number is negative, I'll print a message to the user to input a positive number and that's it :)
         */
        static void ReverseInteger()
        {
            Console.Write("Enter a number to reverse: ");
            //string number = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string StringNum = number.ToString();
            string reversedNumber = "";

            // if the number is positive
            if (number >= 0)
            {
                for(int i = 0; i < StringNum.Length; i++)
                    // store the reversed number in a string
                    reversedNumber += StringNum[StringNum.Length - 1 - i];

                Console.WriteLine($"({number}) ->  {StringNum + reversedNumber}");
            }
            else
                Console.WriteLine("Input a positive number.");
        }

        /* Write a C# Sharp program to count a specific string (case sensitive) in given text.
         -----
        To solve this task, I'll take a text and a specific string(subString) from the user 
        and then I'll count how many times the subString appears in the text then i'll keep track of the index
        and when there's no more subString in the text, I'll print this results :)
         */
        static void CountSpecificString()
        {
            Console.Write("Enter the text: ");
            string text = Console.ReadLine();
            Console.Write("Enter the string to count: ");
            string SubString = Console.ReadLine();

            // to count the appearances of the sub string
            int count = 0;
            // to keep track of the index in the text
            int index = 0;

            // while the specific string is found in the text
            while ((index = text.IndexOf(SubString, index)) != -1)
            {
                // Increment the count for each appearance
                count++;
                // Move the index forward to continue searching(to avoid counting the same substring again)
                index += SubString.Length;
            }
            Console.WriteLine($"The string '{SubString}' appears {count} times in the text.");
        }
        static void Main(string[] args)
        {
            //StringCopy();
            //IsSubstring();
            while (true)
            {
                CountSpecificString();
                //ReverseInteger();
                //CenturyOfYear();
                //MaxMinFromSrting();
                //StringMiddleCharacter();
                //ReverseCase();
                //ReverseStringUpper();
                //EndsWithPeriod();
                //ConcatenateStrings();
                //CompareStrings(); 

                Console.WriteLine();
            }
           
        }
    }
}
