using System;
using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        //Q1.at first it ask the user to enter two numbers, and then compare them if they are equal it will multiply the sum of the two numbers
        // byte 3 as required by the question, if not it will just add them together and show the result which is stored in num3 variable.
        // at fisrt i had an idea about it and i tried it without if it worked but not clean code and i forgot how to use user input, i just 
        // writted the numbers manually in variable but then after i watched some tutorials i found out how to use input so i changed my answer.

        //Console.WriteLine("write the number one");
        //int num1 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("write the number two");
        //int num2 = Convert.ToInt32(Console.ReadLine());

        //var num3 = 0;

        //if (num1 == num2)
        //{
        //    num3 = (num1 + num2) * 3;
        //}
        //else
        //{
        //    num3 = num1 + num2;
        //}

        //Console.WriteLine(num3);

        ////Q2. this one is similar to the first question but the difference is we use subtraction instead of addition,
        //// as the first Question i faced the same issues with the user input.

        //Console.WriteLine("write the number one");
        //int num1 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("write the number two");
        //int num2 = Convert.ToInt32(Console.ReadLine());

        //var num3 = 0;

        //if (num2 > num1)
        //{
        //    num3 = (num2 - num1) * 3;
        //}
        //else
        //{
        //    num3 = num2 - num1;
        //}

        //Console.WriteLine(num3);


        ////Q3. this one also takes tow numbers, then put the sum of the two numbers in a variable named num3, after that 
        //// by using if statement the second number will compare to the given number(30) or the sum of the two numbers to (30) the OR 
        //// operator will be true if one of them is true, otherwise it will print false.
        //Console.WriteLine("write the number one");
        //int num1 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("write the number two");
        //int num2 = Convert.ToInt32(Console.ReadLine());

        //var num3 = num1 + num2;


        //if (num2 == 30 || num3 == 30)
        //{
        //    Console.WriteLine("true");
        //}
        //else
        //{
        //    Console.WriteLine("false");
        //}


        ////Q4. i did not understand the question, i solve it in some way but the results was not same as the practice sheet and 
        //// i wrote it in another file, i deleted it accidently i just leave it because of time.

        ////Q5. also it takes the word from the user and save it in a string named word, then it take the first index from the given word
        //// compare it to the letter 'i' also the second index to the letter 'f', it should be both true to print it as it is because of using
        //// AND(&&) operator, otherwise it will and if to the original word 

        //Console.WriteLine("write the word");
        //string word = Console.ReadLine();


        //if (word[0] == 'i' && word[1] == 'f')
        //{
        //    Console.WriteLine(word);
        //}
        //else
        //{
        //    Console.WriteLine("if " + word);
        //}


        //Q6.


        //Q7. at first sight i did not get the question but then i searched for it and tried to understand it, even tho i did not
        // get it fully. first it checks the word length to make sure it's more then one letter, then it takes the last letter and put it in the 
        // first index, then it takes the second letter and put it in the second index, after that it takes the first letter and put it in the last index.

        //Console.WriteLine("write the word");
        //string word = Console.ReadLine();

        //if (word.Length>1)
        //{
        //    var result=word.Substring(word.Length - 1) + word.Substring(1, word.Length - 2) + word.Substring(0, 1);
        //    Console.WriteLine(result);
        //}
        //else
        //{
        //    Console.WriteLine("it should be more then one letter."+"("+word+")");
        //}

        //Q8.as always it take a word from a user, then checks the length of the word, take the first two letter by using Substring 
        //method, print the result 4 times otherwise just print the original word.
        //Console.WriteLine("write the word");
        //string word = Console.ReadLine();

        //if (word.Length > 2)
        //{
        //    var result = word.Substring(0,1) ;
        //    Console.WriteLine(result+result+result+result
        //        );
        //}
        //else
        //{
        //    Console.WriteLine(word);
        //}


        //Q11.because it is similar with question 8 i just changed feu words like check first three letter instead of first two letter.
        //Console.WriteLine("write the word");
        //string word = Console.ReadLine();

        //if (word.Length > 2)
        //{
        //    var result = word.Substring(0, 3);
        //    Console.WriteLine(result + word + result );
        //}
        //else
        //{
        //    Console.WriteLine(word+word+word);
        //}


        //Q12.i get the idea but i needed to search for the exact method name, after that was easy since it's prepared method.
        //Console.WriteLine("write the word");
        //string word = Console.ReadLine();
        //if (word.StartsWith("C#"))
        //{
        //    Console.WriteLine("true");
        //}
        //else
        //{
        //    Console.WriteLine("false");
        //}


        ////Q13.also this one too was easy since i like using if statement so right after reading the question i can think of the slotion.
        //Console.WriteLine("write first temperature");
        //int word = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("write second temperature ");
        //int word2 = Convert.ToInt32(Console.ReadLine());

        //if (word < 0 && word2>100) {
        //    Console.WriteLine("true");
        //}
        //else
        //{
        //    Console.WriteLine("false");

        //}

        //Q14. this one also was similar to the others so i could think of the code easily.also there is many ways to solve it but
        // i did it using the codes it is familiar for me معل عیلم it's not a clean easy professional code but at least it works and i can understand it.
        Console.WriteLine("write first temperature");
        int word = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("write second temperature ");
        int word2 = Convert.ToInt32(Console.ReadLine());

        if ((word > 100 && word < 200) || (word2 > 100 && word2 < 200))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");

        }

    }
}