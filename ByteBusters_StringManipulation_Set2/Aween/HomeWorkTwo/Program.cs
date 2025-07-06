//using System;

//class Program
//{
//    static void Main()
//    {
//        /*Q1:English: Count the number of characters in a string.
//         * At first we take the users input as a string and save it in a variable named word, then i preferred to use a method
//           named CharCounter so i can get familiar with methods, the method have a parameter, ".Length" is a property in C# we can use
//           it for counting the number of characters in string and in arrays for number of elements, at the end  i called the method
//           in the main method. Also at first i used string count and it doesn't work since it return a number it should be a int.
//            */
//        Console.WriteLine("enter the word");
//        string word = Console.ReadLine();

//        CharCounter(word);
//    }

//    static void CharCounter(string word)
//    {

//            int count = word.Length;
//            Console.WriteLine("the number of the characters in " + "\"" + word + "\"" + " is: " + count);

//    }
//}
//=====

//using System;

//class Program
//{
//    static void Main()
//    {
//        /*Q2:English: Convert a string to uppercase.
//         * Also at first we take the users input as a string and save it in a variable named word, then i used a method
//           named ConvertWordToUpperCase, the method have a parameter, ".ToUpper()" is a Method in C# we can use
//           it for converting a word from lower case to uppercase word, at the end  i called the method
//           in the main method.it was an easy question because i already know about ToUpper() method.
//            */
//        Console.WriteLine("enter the word");
//        string word = Console.ReadLine();

//        CovertWordToUpperCase(word);
//    }

//    static void CovertWordToUpperCase(string word)
//    {

//            string UpperCase = word.ToUpper();
//            Console.WriteLine("The lowercase: " + "\"" + word + "\"" + ", the uppercase: " + UpperCase+".");

//    }
//}
//======

//using System;

//class Program
//{
//    static void Main()
//    {
//        /*Q3:English: Convert a string to lowercase.
//         * this question is te same as the second question we just need to change the method from ToUpper() to ToLower().
//            */
//        Console.WriteLine("enter the word");
//        string word = Console.ReadLine();

//        CovertWordToLowerCase(word);
//    }

//    static void CovertWordToLowerCase(string word)
//    {

//            string LowerCase = word.ToLower();
//            Console.WriteLine("The word: " + "\"" + word + "\"" + ", the Lowercase: " + LowerCase+".");

//    }
//}
//=======

//class Program
//{
//    static void Main()
//    {
//        /*Q4:English: Check if a string starts with a given prefix.
//         * in this question we take two words from the user, and we use nested if statment first if will check if the prefix is 3
//          chars or not, then it compare the word with the prefix to check if they are match or not.
//            */
//        Console.WriteLine("enter the word");
//        string word = Console.ReadLine();
//        Console.WriteLine("enter the word");
//        string prefix = Console.ReadLine();

//        CheckFirst3CharWithPrefix(word, prefix);
//    }

//    static void CheckFirst3CharWithPrefix(string word, string prefix) { 

//        if(prefix.Length == 3){

//        if  (word.Substring(0, 3) == prefix) { 
//                Console.WriteLine("true");
//            }else {
//                Console.WriteLine("false");
//            }

//            } else {         
//            Console.WriteLine("prefix should be 3 chars");

//        }
//    }
//    }

//=========

//using System;
//using System.ComponentModel.Design;

//class Program
//{
//    static void Main()
//    {
//        /*Q5:English: Check if a string ends with a given suffix.
//         * This question is te same as the previous one we need to change the the substring from checking first 3 chars to check 
//          last 3 chars by using ".Length-3".
//            */
//        Console.WriteLine("enter the word");
//        string word = Console.ReadLine();
//        Console.WriteLine("enter the word");
//        string suffix = Console.ReadLine();

//        CheckLast3CharWithSuffix(word, suffix);
//    }

//    static void CheckLast3CharWithSuffix(string word, string suffix) { 

//        if(suffix.Length == 3){

//        if  (word.Substring(word.Length-3) == suffix) { 
//                Console.WriteLine("true");
//            }else {
//                Console.WriteLine("false");
//            }

//            } else {         
//            Console.WriteLine("suffix should be 3 chars");

//        }
//    }
//    }

//========

//using System;
//using System.ComponentModel.Design;

//class Program
//{
//    static void Main()
//    {
//        /*Q8:English: Capitalize the first character of a string.
//         * This question is simple because we already knew about the keywords we need to use, first it take the first letter of
//           the word then it convert it to upper case, ten rewrite the word without the first letter replace it with the capital letter. 
//            */
//        Console.WriteLine("enter the word");
//        string word = Console.ReadLine();

//        ChangeFirstLetterToUpperCase(word);
//    }

//    static void ChangeFirstLetterToUpperCase(string word)
//    {
//        string Uppercaseword = word.Substring(0,1).ToUpper()+word.Substring(1);

//        Console.WriteLine(Uppercaseword);



//    }
//}

//========

//using System;
//using System.ComponentModel.Design;

//class Program
//{
//    static void Main()
//    {
//        /*Q10:English: Split a string into words.
//         * This question as always we take a sentence from the user, we have an array named words to save the splitted words in it
//           by using a method called split which split the sentence just by space, then we use a foreach loop to go through each element 
//           in the array and print it.
//         */
//        Console.WriteLine("enter the sentence");
//        string sentence = Console.ReadLine();


//        string[] words = sentence.Split(' '); 

//        foreach (string word in words)
//        {
//            Console.WriteLine(word);
//        }


//    }
//}




class Program
{
    static void Main()
    {
        /*Q10:English: Split a string into words.
         * This question as always we take a sentence from the user, we have an array named words to save the splitted words in it
           by using a method called split which split the sentence just by space, then we use a foreach loop to go through each element 
           in the array and print it.
         */
        Console.WriteLine("enter the sentence");
        string sentence = Console.ReadLine();


        string[] words = sentence.Split(' ');

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }


    }
}



