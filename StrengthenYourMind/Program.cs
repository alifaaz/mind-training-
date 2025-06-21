using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace StrengthenYourMind;


// by Hussein Sattar
internal class Program
{
    static void Main(string[] args)
    {
        qd22();
    }

    /* 
     * 
     * This Group of questions is omited

    static int Q1(int x, int y)
    {// Sum of two numbers, triple if they are equal
        return x == y ? (x + y) * 3 : x + y;
    }

    static int Q2(int n)
    {// Absolute difference betwenn n & 51, Trilple the result if n > 51
        return n > 51? Math.Abs(n - 51) * 3 : Math.Abs(n - 51);
    }

    static bool Q3(int x, int y)
    {
        return x == 30 || y == 30 || (x + y) == 30;
    }
    */
    #region Group D
    static void qd1()
    { // first 10 natural numbers.
        for (int i = 1; i <= 10; i++) 
            Console.Write(i + " ");
    }

    static void qd2()
    { // the sum of the first 10 natural numbers.
        int sum = 0;
        Console.WriteLine("The first 10 natural number is :");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
            sum += i;
        }
        Console.WriteLine($"\nThe Sum is : {sum}");
    }

    static void qd3(int n)
    {
        int sum = 0;
        Console.WriteLine($"The first {n} natural number is :");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
            sum += i;
        }
        Console.WriteLine($"\nThe Sum of Natural Number upto {n} terms : {sum}");
    }


    static void qd4()
    {
        int sum = 0;
        Console.WriteLine($"Input the 10 numbers :");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Number-{i}:");
            int x = Convert.ToInt32(Console.ReadLine());
            sum += x;
        }
        Console.WriteLine($"\n\nThe sum of 10 no is :{sum}");
        Console.WriteLine($"The Average is :{sum / 10}");
    }

    static void qd5 (int n)
    {
        Console.WriteLine($"Input number of terms : {n}");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Number is : {i} and cube of the {i} is :{Math.Pow(i,3)}");
        }
    }

    static void qd6(int n)
    {
        Console.WriteLine($"Input the number (Table to be calculated) : {n}");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} X {i.ToString().PadLeft(2)} = {(n*i).ToString().PadLeft(4)}");
            
        }
    }

    static void qd7(int n)
    {
        Console.WriteLine($"Multiplication table from 1 to {n}");
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= 10; j++)
                Console.Write($"{j} X {i.ToString().PadLeft(2)} = {(j * i).ToString().PadLeft(3)}  | ");
            Console.WriteLine("\n" + new string('-',160));

        }
    }

    static void qd8(int n)
    {
        int sum = 0;
        int x = 1;
        Console.Write("The odd numbers are: ");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(x + " ");
            sum += x;
            x += 2;
        }
        Console.WriteLine($"\nThe Sum of odd Natural Number upto {n} terms : {sum}");
    }

    static void qd9()
    {
       
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 0; j < i; j++)
                Console.Write("*");
            Console.WriteLine();
        }
    }

    static void qd10()
    {

        for (int i = 1; i <= 4; i++)
        {
            for (int j = 0; j < i; j++)
                Console.Write(j+1);
            Console.WriteLine();
        }
    }

    static void qd11()
    {

        for (int i = 1; i <= 4; i++)
        {
            for (int j = 0; j < i; j++)
                Console.Write(i);
            Console.WriteLine();
        }
    }

    static void qd12()
    {
        int x = 1;
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 0; j < i; j++)
                Console.Write(x++ + " ");
            Console.WriteLine();
        }
    }

    static void qd13()
    {
        int x = 1;
        for (int i = 1; i <= 4; i++)
        {
            Console.Write(new string(' ',4 - i));

            for (int j = 1; j <= i; j++)
            {
                Console.Write(x++ + " ");
            }
            Console.WriteLine();
        }
    }

    static void qd14()
    {
        for (int i = 1; i <= 4; i++)
        {
            Console.Write(new string(' ', 4 - i));

            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static int qd15(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        int sum = 1;
        for(int i = n;i > 0 ; i--)
        {
            sum *= i;
        }
        Console.WriteLine($"The Factorial of {n} is: {sum}");

        return sum;
    }

    static void qd16(int n)
    {
        int sum = 0;
        int x = 2;
        Console.Write("The even numbers are: ");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(x + " ");
            sum += x;
            x += 2;
        }
        Console.WriteLine($"\nThe Sum of even Natural Number upto {n} terms : {sum}");
    }

    static void qd17()
    {
        for (int i = 1; i <= 4; i++)
        {
            Console.Write(new string(' ', 4 - i));

            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }

    static void qd18(double n)
    {
        double sum = 1, term;
        int p = 2;
        Console.Write("Input the value of x = ");
        int x = Convert.ToInt32(Console.ReadLine());
        for(int i = 1;i <= n; i++)
        {
            term = (Math.Pow(x, p) / qd15(p)) * -1; //qd15 is calculating the factorial
            term *= (i % 2 == 0) ? -1 : 1;
            sum += term; 
            p += 2;
        }
        Console.WriteLine($"the sum = {sum}");
    }

    static void qd19(int n)
    {
        double sum = 0;
        for(int i = 1; i <= n ; i++)
        {
            sum += 1d/ (double)i;
        }
        Console.WriteLine($"Sum of Series upto {n} terms : {sum}") ;
    }

    static void qd20() {

        for (int i = 1; i <= 3; i++)
        {
            Console.Write(new string(' ', 3 - i));

            for (int j = 1; j <= i*2 - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void qd21(int n)
    {
        long x = 9;
        long sum = 0;
        for (int i = 1; i<=n ; i++)
        {
            sum += x;
            Console.Write(x + " ");
            x = (x * 10) + 9;
        }
        Console.WriteLine($"\nThe sum of the series = {sum}") ;
    }

    static void qd22()
    {
        bool x = true;
        for (int i = 1; i<= 5 ; i++)
        {
            int val = x ? 1 : 0;

            for (int j = 1;j<= i ; j++)
            {
                Console.Write(val) ;
                val = 1 - val ;
            }

            Console.WriteLine() ;
            x = !x ;
        }
    }

    static void qd23(double n)
    {
        double sum = 0, term;
        int p = 0;
        Console.Write("Input the value of x = ");
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            term = (Math.Pow(x, p) / qd15(p)) ;
            sum += term; //qd15 is calculating the factorial\
            p++;
        }
        Console.WriteLine($"the sum = {sum}");
    }

    static void qd24(double n)
    {
        double sum = 0, term;
        int p = 1;
        Console.Write("Input the value of x = ");
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            term = (Math.Pow(x, p));
            term *= (i % 2 == 0) ? -1 : 1;
            sum += term; 
            p += 2;
        }
        Console.WriteLine($"the sum = {sum}");
    }

    static void qd25(int n)
    {
        int sum = 0;
        Console.WriteLine("The square natural upto 5 terms are : ");
        for(int i = 1;i <= n; i++)
        {
            Console.Write(i*i + " ");
            sum += i*i;
        }
        Console.WriteLine($"The Sum of Square Natural Number upto {n} terms = {sum}");
    }

    #endregion

}
