using System;
using static System.Math;


// By Mohemmed Najim
public class TaskSolutions
{

    public void Task_1()
    {
        /* Write a C# Sharp program to compute the sum of the two numerical values.
        If the two values are the same, return triple their sum        
        Sample Input:
        1, 2
        3, 2
        2, 2
        Expected Output:
        3
        5
        12
        */
        //Define number1 and get user input
        Console.WriteLine("Plz enter num1: \t");
        int num1 = Convert.ToInt32(Console.ReadLine());
        //Define number2 and get user input
        Console.WriteLine("Plz enter num2: \t");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int result = num1 + num2;
        if (num1 == num2)
            Console.Write("Sum of the two numerical values: " + result * 3);
        else
            Console.Write("Triple their sum: " + result);

    }

    public void Task_2()
    {
        /*Write a C# Sharp program to get the absolute difference between n and 51.
         If n is broader than 51 return triple the absolute difference.
        Sample Input:
        53
        30
        51
        Expected Output:
        6
        21
        0
        */
        const int constValue = 51;
        //Define n and get user input
        Console.WriteLine("Plz enter n: \t");
        int n = Convert.ToInt32(Console.ReadLine());
        //Check  n larger than  51
        if (n > constValue)
            Console.Write("Result: " + (n - constValue) * 3);
        else
            Console.Write("Result: " + (constValue - n));
    }

    public void Task_3()
    {
        /*Write a C# Sharp program to check two given integers, 
         and return true if one of them is 30 or if their sum is 30.
        Sample Input:
        30, 0
        25, 5
        20, 30
        20, 25
        Expected Output:
        True
        True
        True
        False

        */

        //Define number1 and get user input
        Console.WriteLine("Plz enter num1: \t");
        int num1 = Convert.ToInt32(Console.ReadLine());
        //Define number2 and get user input
        Console.WriteLine("Plz enter num2: \t");
        int num2 = Convert.ToInt32(Console.ReadLine());
        //Sum of two number
        int result = num1 + num2;
        //Check if one of them is 30 or if their sum is 30
        if ((result == 30)||(num1 == 30)||(num2 == 30))
            Console.Write("Output: True");
        else
            Console.Write("Output: False");

    }

    public void Task_4()
    {
        /*Write a C# Sharp program to check a given integer and return true 
         if it is within 10 of 100 or 200.
        Sample Input:
        103
        90
        89
        Expected Output:
        True
        True
        False
        */
        const int top1 = 100;
        const int top2 = 200;
        const int constVal = 10;
        //Define number and get user input
        Console.WriteLine("Plz enter num: \t");
        int num = Convert.ToInt32(Console.ReadLine());
        //Check if it is within 10 of 100 or 200
        if ((Math.Abs(num - top1) <= constVal) || (Math.Abs(num - top2) <= constVal))
            Console.Write("Output: True");
        else
            Console.Write("Output: False");

    }

    public void Task_5()
    {
        /*Write a C# Sharp program to create a string where 'if' 
         is added to the front of a given string. If the string already begins with 'if',
        return it unchanged.
        Sample Input:
        "if else"
        "else"
        Expected Output:
        if else
        if else
        */
        //Define string and get user input
        Console.WriteLine("Plz enter string: \t");
        string? str = Console.ReadLine();
        //Check If the string already begins with 'if'
        if (str.StartsWith("if"))
            Console.Write("Output: " + str);
        else
            Console.Write("Output: " + "if " + str);
    }

    public void Task_6()
    {
        /*Write a C# Sharp program to remove the character at a given position in the string. 
         The given position will be in the range 0..(string length -1) inclusive.
        Sample Input:
        "Python", 1
        "Python", o
        "Python", 4
        Expected Output:
        Pthon
        ython
        Pythn
        */
        //Define string and get user input
        Console.WriteLine("Plz enter string: \t");
        string? str = Console.ReadLine();

        Console.WriteLine("Plz enter Index Char to remove: \t");
        int indexChar = Convert.ToInt32(Console.ReadLine());
        // Check Index char in range string length
        if (indexChar < str.Length)
            Console.Write("Output: " + str?.Remove(indexChar, 1));
        else
            Console.WriteLine("Plz check the index out of range");
    }

    public void Task_7()
    {
        /*Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
        Sample Input:
        "abcd"
        "a"
        "xy"
        Expected Output:
        dbca
        a
        yx
        */
        //Define string and get user input
        Console.WriteLine("Plz enter string: \t");
        string? str = Console.ReadLine();
        // Check string length if greatar than 1 do swap else only print string  
        if (str.Length > 1)
        {
            str = str[str.Length - 1] + str.Substring(1, str.Length - 2) + str[0];
        }
        Console.Write("Output: " + str);
    }

    public void Task_8()
    {
        /*Write a C# Sharp program to create a string which is 4 copies of the 2 front characters of a given string. 
         If the given string length is less than 2 return the original string.
        Sample Input:
        "C Sharp"
        "JS"
        "a"
        Expected Output:
        C C C C 
        JSJSJSJS
        a
        */
        //Define string and get user input
        Console.WriteLine("Plz enter string: \t");
        string? str = Console.ReadLine();
        // Check string length if greatar than 1 do swap else only print string  
        if (str.Length > 1)
        {
            // Keep the first 2 char 
            string tempStr = str.Substring(0, 2);
            // Store result
            str = "";
            // 4 copies of the 2 front characters of a given string
            for (int i = 0; i < 4; i++)
                str += tempStr;
        }
        Console.Write("Output: " + str);
    }

    public void Task_9()
    {
        /*Write a C# Sharp program to create a string with the last char added at the front and back of a given string of length 1 or more.
        Sample Input:
        "Red"
        "Green"
        "1"
        Expected Output:
        dRedd
        nGreenn
        111
        */
        //Define string and get user input
        Console.WriteLine("Plz enter string: \t");
        string? str = Console.ReadLine();

        if (str.Length > 0)
        {
            // last char added at the front and back of a given string of length 1
            str = str[str.Length - 1] + str + str[str.Length - 1];
        }
        Console.Write("Output: " + str);
    }

    public void Task_10()
    {
        /*Write a C# Sharp program to check if a given positive number is a multiple of 3 or 7.
        Sample Input:
        3
        14
        12
        37
        Expected Output:
        True
        True
        True
        False
        */
        //Define positive number and get user input
        Console.WriteLine("Plz enter number: \t");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            // Check if a given positive number is a multiple of 3 or 7
            if ((num % 3 == 0) || (num % 7 == 0))
                Console.Write("Output: True");
            else
                Console.Write("Output: False");
        }
        else
            Console.Write("The number less than zero (negative)");
    }

    public void Task_11()
    {
        /*Write a C# Sharp program to create a string taking the first 3 characters of a given string. Return the string with the 3 characters added at both the front and back. If the given string length is less than 3, use whatever characters are there.
        Sample Input:
        "Python"
        "JS"
        "Code"
        Expected Output:
        PytPythonPyt
        JSJSJS
        CodCodeCod
        */
        //Define string and get user input
        Console.WriteLine("Plz enter string: \t");
        string? str = Console.ReadLine();
        if (str.Length > 2)
        {
            // 3 characters added at both the front and back
            str = str.Substring(0, 3) + str + str.Substring(0, 3);
        }
        Console.Write("Output: " + str);
    }

    public void Task_12()
    {
        /*Write a C# Sharp program to check if a given string starts with 'C#' or not.
        Sample Input:
        "C# Sharp"
        "C#"
        "C++"
        Expected Output:
        True
        True
        False
        */
        //Define string and get user input
        Console.WriteLine("Plz enter string: \t");
        string? str = Console.ReadLine();
        // Check if a given string starts with 'C#'
        if (str.Substring(0, 2) == "C#")
        {
            Console.Write("Output: True");
        }
        else
            Console.Write("Output: False");
    }

    public void Task_13()
    {
        /*Write a C# Sharp program that checks whether one temperature is less than 0 and another is greater than 100.
        Sample Input:
        120, -1
        -1, 120
        2, 120
        Expected Output:
        True
        True
        False
        */
        //Define first degree and get user input
        Console.WriteLine("Plz enter first degree: \t");
        int firstDegree = Convert.ToInt32(Console.ReadLine());
        //Define second degree and get user input
        Console.WriteLine("Plz enter second degree: \t");
        int secondDegree = Convert.ToInt32(Console.ReadLine());
        //Check whether one temperature is less than 0 and another is greater than 100
        if ((firstDegree < 0) || (secondDegree < 0))
            if ((firstDegree > 100) || (secondDegree > 100))
                Console.Write("Output: True");
            else
                Console.Write("Output: False");
        else
            Console.Write("Output: False");
    }

    public void Task_14()
    {
        /*Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.
        Sample Input:
            100, 199
        250, 300
        105, 190
        Expected Output:
        True
        False
        True
        */
        //Define num1 and get user input
        Console.WriteLine("Plz enter num1: \t");
        int num1 = Convert.ToInt32(Console.ReadLine());
        //Define num2 and get user input
        Console.WriteLine("Plz enter num2: \t");
        int num2 = Convert.ToInt32(Console.ReadLine());
        //Check whether one temperature is less than 0 and another is greater than 100
        if ((num1 >= 100) && (num2 >= 100))
            if ((num1 <= 200) && (num2 <= 200))
                Console.Write("Output: True");
            else
                Console.Write("Output: False");
        else
            Console.Write("Output: False");
    }

    public void Task_15()
    {
        /*Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive. Return true if 1 or more of them are in the said range otherwise false.
        Sample Input:
            11, 20, 12
        30, 30, 17
        25, 35, 50
        15, 12, 8
        Expected Output:
        True
        True
        True
        False
        */
        //Define num1 and get user input
        Console.WriteLine("Plz enter num1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        //Define num2 and get user input
        Console.WriteLine("Plz enter num2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        //Define num3 and get user input
        Console.WriteLine("Plz enter num3: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        //Check whether three given integer values are in the range 20..50
        if ((num1 >= 20 && num1 <= 50) || (num2 >= 20 && num2 <= 50) || (num3 >= 20 && num3 <= 50))
            Console.Write("Output: True");
        else
            Console.Write("Output: False");
    }

    public void Task_16()
    {
        /*Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. Return true if 1 or other is in the range, otherwise false.
        Sample Input:
            20, 84
        14, 50
        11, 45
        25, 40
        Expected Output:
        True
        True
        True
        False
        */
        //Define num1 and get user input
        Console.WriteLine("Plz enter num1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        //Define num2 and get user input
        Console.WriteLine("Plz enter num2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        //Check whether two given integer values are in the range 20..50
        if ((num1 >= 20 && num1 <= 50) || (num2 >= 20 && num2 <= 50))
            Console.Write("Output: True");
        else
            Console.Write("Output: False");
    }

    public void Task_17()
    {
        /*/*Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. If it appears return a string without 'yt' otherwise return the original string.
         Sample Input:
             "Python"
         "ytade"
         "jsues"
         Expected Output:
         Phon
         ytade
         jsues
         */
        //Define string and get user input
        Console.WriteLine("Plz enter string: \t");
        string? str = Console.ReadLine();
        // Check if a string 'yt' appears at index 1 in a given string
        if (str.Substring(1, 2) == "yt")
        {
            str = str[0] + str.Substring(3, str.Length - 3);
        }
        Console.Write("Output:" + str);
    }

    public void Task_18()
    {
        /*Write a C# Sharp program to check the largest number among three given integers.
        Sample Input:
            1,2,3
        1,3,2
        1,1,1
        1,2,2
        Expected Output:
        3
        3
        1
        2
        */
        //Define num1 and get user input
        Console.WriteLine("Plz enter num1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        //Define num2 and get user input
        Console.WriteLine("Plz enter num2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        //Define num3 and get user input
        Console.WriteLine("Plz enter num3: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        //Check the largest number among three given integers
        if (num1 >= num2 && num1 >= num3)
            Console.Write("Output: " + num1);
        else if (num2 >= num1 && num2 >= num3)
            Console.Write("Output: " + num2);
        else if (num3 >= num1 && num3 >= num2)
            Console.Write("Output: " + num3);
    }

    public void Task_19()
    {
        /*Write a C# Sharp program to check which number is closest to 100 among two given integers. Return 0 if the two numbers are equal.
        Sample Input:
            78, 95
        95, 95
        99, 70
        Expected Output:
        95
        0
        99
        */
        //Define num1 and get user input
        Console.WriteLine("Plz enter num1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        //Define num2 and get user input
        Console.WriteLine("Plz enter num2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        //Return 0 if the two numbers are equal
        if (num1 == num2)
            Console.Write("Output: " + 0);
        else if (Math.Abs(100 - num1) < Math.Abs(100 - num2))
            Console.Write("Output: " + num1);
        else if (Math.Abs(100 - num2) < Math.Abs(100 - num1))
            Console.Write("Output: " + num2);
    }

    public void Task_20()
    {
        /*Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive.
        Sample Input:
            78, 95
        25, 35
        40, 50
        55, 60
        Expected Output:
        False
        False
        True
        True
        */
        //Define num1 and get user input
        Console.WriteLine("Plz enter num1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        //Define num2 and get user input
        Console.WriteLine("Plz enter num2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        //Check whether two given integers are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive
        if (((num1 >= 40 && num1 <= 50) && (num2 >= 40 && num2 <= 50)) || ((num1 > 50 && num1 <= 60) && (num2 > 50 && num2 <= 60)))
            Console.Write("Output: True");
        else
            Console.Write("Output: False");
    }

    public void Task_21()
    {
        /*Write a C# Sharp program to find the largest value from two positive integer values in the range 20..30 inclusive. Return 0 if neither is in that range.
        Sample Input:
            78, 95
        20, 30
        21, 25
        28, 28
        Expected Output:
        0
        30
        25
        28
        */
        //Define num1 and get user input
        Console.WriteLine("Plz enter num1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        //Define num2 and get user input
        Console.WriteLine("Plz enter num2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        //Check the largest value from two positive integer values in the range 20..30 inclusive. Return 0 if neither is in that range.
        if ((num1 >= 20 && num1 <= 30) || (num2 >= 20 && num2 <= 30))
            if (num1 >= num2)
                Console.Write("Output: " + num1);
            else
                Console.Write("Output: " + num2);
        else
            Console.Write("Output: 0");
    }

    public void Task_22()
    {
       /*Write a C# Sharp program to check if a given string contains between 2 and 4 'z' characters.
    Sample Input:
        "frizz"
    "zane"
    "Zazz"
    "false"
    "zzzz"
    "ZZZZ"
    Expected Output:
    True
    False
    True
    False
    True
    False
    */

    //Define string and get user input
    Console.WriteLine("Plz enter string: \t");
        string? str = Console.ReadLine();
        int zCount = 0;
        // Check if a given string contains between 2 and 4 'z' characters
        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == 'Z' || str[i] == 'z')
            { zCount++; }
        }
        if (zCount >= 2 && zCount <= 4)
        {
            Console.Write("Output: True");
        }
        else
            Console.Write("Output: False");
    }

    public void Task_23()
    {
       /*Write a C# Sharp program to check if two given non-negative integers have the same last digit.
        Sample Input:
            123, 456
        12, 512
        7, 87
        12, 45
        Expected Output:
        False
        True
        True
        False
        */
        //Define num1 and get user input
        Console.WriteLine("Plz enter num1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        //Define num2 and get user input
        Console.WriteLine("Plz enter num2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        //Check if two given non-negative integers have the same last digit
        if (num1 % 10 == num2 % 10)
            Console.Write("Output: True");
        else
            Console.Write("Output: False");
    }

    public void Task_24()
    {
       /*Write a C# Sharp program to convert the last 3 characters of a given string to uppercase. If the length of the string is less than 3, then uppercase all the characters.
        Sample Input:
            "Python"
        "Javascript"
        "js"
        "PHP"
        Expected Output:
        PytHON
        JavascrIPT
        JS
        PHP
        */
        //Define string and get user input
        Console.WriteLine("Plz enter string: \t");
        string? str = Console.ReadLine();
        // Check if a string 'yt' appears at index 1 in a given string
        if (str.Length < 3)
            str = str.ToUpper();
        else
            str = str.Substring(0, str.Length - 3) + (str.Substring(str.Length - 3)).ToUpper();
        Console.Write("Output:" + str);
    }

    public void Task_25()
    {
       /*Write a C# Sharp program to create a string which is n (non-negative integer) copies of a given string.
        Sample Input:
            "JS", 2
        "JS", 3
        "JS", 1
        Expected Output:
        JSJS
        JSJSJS
        JS
        */
        //Define string and get user input
        Console.WriteLine("Plz enter string:");
        string? str = Console.ReadLine();
        Console.WriteLine("Plz enter non-negative integer:");
        int n = Convert.ToInt32(Console.ReadLine());
        string result = "";
        if (n > 0)
        {
            for (int i = 0; i < n; i++)
                result += str;
            Console.WriteLine("Output: " + result);
        }
        else
            Console.WriteLine("Plz check the n");
    }

    public void Task_1_1()
    {
       /*Write a C# Sharp program to accept two integers and check whether they are equal or not.
        Test Data:
            Input 1st number: 5
        Input 2nd number: 5
        Expected Output :
        5 and 5 are equal
        */
        //Define num1 and get user input
        Console.WriteLine("Plz enter num1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        //Define num2 and get user input
        Console.WriteLine("Plz enter num2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        //Check whether they are equal or not.
        if (num1 == num2)
            Console.Write(num1 + " and " + num2 + " are equal.");
        else
            Console.Write("Not equal");
    }

    public void Task_1_2()
    {
       /*Write a C# Sharp program to check whether a given number is even or odd.
        Test Data: 15
        Expected Output :
        15 is an odd integer
        */
        //Define num and get user input
        Console.WriteLine("Plz enter num: ");
        int num = Convert.ToInt32(Console.ReadLine());
        //Check  whether a given number is even or odd.
        if (num % 2 == 0)
            Console.Write(num + " is an EVEN integer ");
        else
            Console.Write(num + " is an ODD integer ");
    }

    public void Task_1_3()
    {
       /*Write a C# Sharp program to check whether a given number is positive or negative.
        Test Data: 14
        Expected Output :
        14 is a positive number
        */
        //Define num and get user input
        Console.WriteLine("Plz enter num: ");
        int num = Convert.ToInt32(Console.ReadLine());
        //Check whether a given number is positive or negative
        if (num > 0)
            Console.Write(num + " is a positive number ");
        else
            Console.Write(num + " is a negative number ");
    }

    public void Task_1_4()
    {
       /*Write a C# Sharp program to find out whether a given year is a leap year or not.
        Test Data: 2016
        Expected Output :
        2016 is a leap year.
        */
        //Define year and get user input
        Console.WriteLine("Plz enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        //Check  whether a given number is even or odd.
        if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            Console.Write(year + " is a leap year");
        else
            Console.Write(year + " is not a leap year");
    }

    public void Task_1_5()
    {
       /*Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
        Test Data: 21
        Expected Output:
        Congratulation! You are eligible for casting your vote.
        */
        //Define age and get user input
        Console.WriteLine("Plz enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        //Check  whether it is eligible for casting his/her own vote.
        if (age >= 18)
            Console.Write(" Congratulation! You are eligible for casting your vote.");
        else
            Console.Write(" You are not eligible for casting your vote.");
    }

    public void Task_1_6()
    {
       /*Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
        Test Data: -5
        Expected Output:
        The value of n = -1
        */
        //Define m and get user input
        Console.WriteLine("Plz enter m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        //Check n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
        if (m > 0)
            Console.Write(" The value of n = 1");
        else if (m == 0)
            Console.Write(" The value of n = 0");
        else
            Console.Write(" The value of n = -1");
    }

    public void Task_1_7()
    {
       /*Write a C# Sharp program to accept a person's height in centimeters and categorize them according to their height.
        Test Data: 135
        Expected Output :
        The person is Dwarf.
        */
        // Dwarf (below 150cm), Average (150cm-175cm), Tall (175cm-195cm), and Abnormal (above 195cm)
        //Define height and get user input
        Console.WriteLine("Plz enter height: ");
        int height = Convert.ToInt32(Console.ReadLine());

        //Check categorize them according to their height.
        if (height < 150)
            Console.Write(" The person is Dwarf");
        else if (height >= 150 && height < 175)
            Console.Write(" The person is Average");
        else if (height >= 175 && height < 195)
            Console.Write(" The person is Tall");
        else
            Console.Write(" The person is Abnormal");
    }

    public void Task_1_8()
    {
       /*Write a C# Sharp program to find the largest of three numbers.
        Test Data:
            Input the 1st number :25
        Input the 2nd number :63
        Input the 3rd number :10
        Expected Output :
        The 2nd Number is the greatest among three
        */
        //Define num1 and get user input
        Console.WriteLine("Input the 1st number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        //Define num2 and get user input
        Console.WriteLine("Input the 2nd number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        //Define num3 and get user input
        Console.WriteLine("Input the 3rd number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        //Check the largest of three numbers
        if (num1 >= num2 && num1 >= num3)
            Console.Write("The 1st Number is the greatest among three");
        else if (num2 >= num1 && num2 >= num3)
            Console.Write("The 2nd Number is the greatest among three");
        else if (num3 >= num1 && num3 >= num2)
            Console.Write("The 3rd Number is the greatest among three");
    }

    public void Task_1_9()
    {
       /*Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        Test Data:
        Input the value for X coordinate :7
        Input the value for Y coordinate :9
        Expected Output :
        The coordinate point(7, 9) lies in the First quadrant.
        */
        //Define X and get user input
        Console.WriteLine("Input the value for X coordinate: ");
        int X = Convert.ToInt32(Console.ReadLine());
        //Define Y and get user input
        Console.WriteLine("Input the value for Y coordinate: ");
        int Y = Convert.ToInt32(Console.ReadLine());
        //Check the largest of three numbers
        if (X >= 0 && Y >= 0)
            Console.Write("The coordinate point (" + X + "," + Y + ") lies in the First quadrant.");
        else if (X < 0 && Y >= 0)
            Console.Write("The coordinate point (" + X + "," + Y + ") lies in the Second quadrant.");
        else if (X < 0 && Y < 0)
            Console.Write("The coordinate point (" + X + "," + Y + ") lies in the third quadrant.");
        else if (X >= 0 && Y < 0)
            Console.Write("The coordinate point (" + X + "," + Y + ") lies in the Fourth quadrant.");
    }

    public void Task_1_10()
    {
       /*Write a C# Sharp program to determine the eligibility for admission to a professional course based on the following criteria:
        Marks in Maths >= 65
        Marks in Phy >= 55
        Marks in Chem >= 50
        Total in all three subject >= 180
        or
        Total in Math and Subjects >= 140
        Test Data :
        Input the marks obtained in Physics: 65
        Input the marks obtained in Chemistry: 51
        Input the marks obtained in Mathematics: 72
        Expected Output :
        The candidate is eligible for admission.
        */
        //Define Maths and get user input
        Console.Write("Input the marks obtained in Mathematics: \t");
        int Maths = Convert.ToInt32(Console.ReadLine());
        //Define Phy and get user input
        Console.Write("Input the marks obtained in Physics: \t");
        int Phy = Convert.ToInt32(Console.ReadLine());
        //Define Chemistry and get user input
        Console.Write("Input the marks obtained in Chemistry: \t");
        int Chem = Convert.ToInt32(Console.ReadLine());
        //Determine the eligibility for admission to a professional course
        if (Maths >= 65)
            if (Phy >= 55)
                if (Chem >= 50)
                    if (((Maths + Phy + Chem) >= 180) || ((Maths + Phy + Chem) >= 140))
                        Console.Write("The candidate is eligible for admission.");
                    else
                        Console.Write("The candidate is ineligible for admission.");
                else
                    Console.Write("The candidate is ineligible for admission.");
            else
                Console.Write("The candidate is ineligible for admission.");
        else
            Console.Write("The candidate is ineligible for admission.");        
    }

    public void Task_1_11()
    {
       /*Write a C# Sharp program to calculate the root of a quadratic equation.
        Test Data:
        Input the value of a: 1
        Input the value of b: 5
        Input the value of c: 7
        Expected Output :
        Root are imaginary;
        No Solution.
        */
        //Define a and get user input
        Console.Write("Input the value of a: \t");
        int a = Convert.ToInt32(Console.ReadLine());
        //Define b and get user input
        Console.Write("Input the value of b: \t");
        int b = Convert.ToInt32(Console.ReadLine());
        //Define c and get user input
        Console.Write("Input the value of c: \t");
        int c = Convert.ToInt32(Console.ReadLine());
        // Calculate the root of a quadratic equation
        double discriminant, root1, root2;
        discriminant = b * b - 4 * a * c;  // Calculating the discriminant
        if (discriminant == 0)
        {
            root1 = -b / (2.0 * a);
            root2 = root1;
            Console.WriteLine("First Root Root1 = \t" + root1);
            Console.WriteLine("Second Root Root2 = \t" + root2);
        }
        else if (discriminant > 0)
        {
            root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("First Root Root1 = \t" + root1);
            Console.WriteLine("Second Root Root2 = \t" + root2);
        }
        else
        {
            Console.Write("No Sol");
        }

    }

    public void Task_1_12()
    {
       /*Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
        Test Data:
            Input the Roll Number of the student: 784
        Input the Name of the Student :James
        Input the marks of Physics, Chemistry and Computer Application: 70 80 90
        Expected Output :
        Roll No : 784
        Name of Student: James
        Marks in Physics: 70
        Marks in Chemistry: 80
        Marks in Computer Application : 90
        Total Marks = 240
        Percentage = 80.00
        Division = First
        */
        int total, Av;
        string division;
        //Define Roll Number and get user input
        Console.Write("Input the Roll Number of the student: \t");
        int rollNumber = Convert.ToInt32(Console.ReadLine());
        //Define Name and get user input
        Console.Write("Input the Name of the Student: \t");
        string name = Console.ReadLine();
        //Define Physics and get user input
        Console.Write("Input the marks of Physics: \t");
        int physics = Convert.ToInt32(Console.ReadLine());
        //Define Chemistry and get user input
        Console.Write("Input the marks of Chemistry: \t");
        int chemistry = Convert.ToInt32(Console.ReadLine());
        //Define Computer Application and get user input
        Console.Write("Input the marks of Computer Application: \t");
        int computerApplication = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Roll No : \t" + rollNumber);
        Console.WriteLine("Name of Student : \t" + name);
        Console.WriteLine("Marks in Physics : \t" + physics);
        Console.WriteLine("Marks in Chemistry : \t" + chemistry);
        Console.WriteLine("Marks in Computer Application : \t" + computerApplication);
        total = physics + chemistry + computerApplication;
        Console.WriteLine("Total Marks =  \t" + total);
        Av = total / 3;
        Console.WriteLine("Percentage =  \t" + Av);
        if (Av >= 60)
            division = "First";
        else if (Av < 60 && Av >= 48)
            division = "Second";
        else if (Av < 48 && Av >= 36)
            division = "Pass";
        else
            division = "Fail";
        Console.WriteLine("Division =  \t" + division);
    }

    public void Task_1_13()
    {
       /*Write a C# Sharp program to read temperature in centigrade and display a suitable message according to the temperature state below:
        Temp< 0 then Freezing weather
        Temp 0 - 10 then Very Cold weather
        Temp 10 - 20 then Cold weather
        Temp 20 - 30 then Normal in Temp
        Temp 30 - 40 then Its Hot
        Temp >= 40 then Its Very Hot
        Test Data :
        42
        Expected Output :
        Its very hot.
        */
        //Define temperature and get user input
        Console.Write("Input the Temp: \t");
        int Temp = Convert.ToInt32(Console.ReadLine());
        //Check temperature
        if (Temp < 0)
            Console.WriteLine("Then Freezing weather");
        else if (Temp >= 0 && Temp < 10)
            Console.WriteLine("Then Very Cold weather");
        else if (Temp >= 10 && Temp < 20)
            Console.WriteLine("Then Cold weather");
        else if (Temp >= 20 && Temp < 30)
            Console.WriteLine("Then Normal weather");
        else if (Temp >= 30 && Temp < 40)
            Console.WriteLine("Then Its Hot");
        else if (Temp >= 40)
            Console.WriteLine("Then Its Very Hot");
    }

    public void Task_1_14()
    {
       /*Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.
        Test Data:
        50 50 60
        Expected Output :
        This is an isosceles triangle.
        */
        //Define cornar1 and get user input
        Console.Write("Input the cornar1: \t");
        int cornar1 = Convert.ToInt32(Console.ReadLine());
        //Define cornar2 and get user input
        Console.Write("Input the cornar2: \t");
        int cornar2 = Convert.ToInt32(Console.ReadLine());
        //Define cornar3 and get user input
        Console.Write("Input the cornar3: \t");
        int cornar3 = Convert.ToInt32(Console.ReadLine());
        //Check whether a triangle is Equilateral, Isosceles or Scalene.
        if (cornar1 == cornar2 && cornar1 == cornar3)
            Console.WriteLine("This is an Equilateral triangle");
        else if (cornar1 == cornar2 || cornar1 == cornar3 || cornar2 == cornar3)
            Console.WriteLine("This is an Isosceles triangle");
        else
            Console.WriteLine("This is a Scalene triangle");
    }

    public void Task_1_15()
    {
       /*Write a C# Sharp program to check whether a triangle can be formed by the given angles value.
        Test Data:
        40 55 65
        Expected Output :
        The triangle is not valid.
        */
        //Define angle1 and get user input
        Console.Write("Input the angle1: \t");
        int angle1 = Convert.ToInt32(Console.ReadLine());
        //Define cornar2 and get user input
        Console.Write("Input the angle2: \t");
        int angle2 = Convert.ToInt32(Console.ReadLine());
        //Define angle3 and get user input
        Console.Write("Input the angle3: \t");
        int angle3 = Convert.ToInt32(Console.ReadLine());
        //Check whether a triangle can be formed by the given angles value
        if ((angle1 + angle2 + angle3) == 180)
            Console.WriteLine("The triangle is valid");
        else
            Console.WriteLine("The triangle is not valid");
    }

    public void Task_1_16()
    {
       /*Write a C# Sharp program to check whether an alphabet letter is a vowel or a consonant.
        Test Data:
        k
        Expected Output:
        The alphabet is a consonant.
        */
        //Define alphabet and get user input
        Console.Write("Input the alphabet: \t");
        char alphabet = Convert.ToChar(Console.Read());
        //Check whether an alphabet letter is a vowel or a consonant.
        if (alphabet == 'A' || alphabet == 'a' || alphabet == 'E' || alphabet == 'e' || alphabet == 'I' || alphabet == 'i' || alphabet == 'O' || alphabet == 'o' || alphabet == 'U' || alphabet == 'u')
            Console.WriteLine("The alphabet is a vowel.");
        else
            Console.WriteLine("The alphabet is a consonant.");
    }

    public void Task_1_17()
    {
       /*Write a C# Sharp program to calculate profit and loss on a transaction.
        Test Data:
        500 700
        Expected Output :
        You can book your profit amount : 200
        */
        //Define sPrice and get user input
        Console.Write("Input the sell Price: \t");
        int sPrice = Convert.ToInt32(Console.ReadLine());
        //Define bPrice and get user input
        Console.Write("Input the buy Price: \t");
        int bPrice = Convert.ToInt32(Console.ReadLine());
        //Calculate profit and loss on a transaction.
        if (sPrice < bPrice)
            Console.WriteLine("You can book your profit amount: " + (bPrice - sPrice));
        else if (bPrice < sPrice)
            Console.WriteLine("You can book your loss amount: " + (bPrice - sPrice));
        else
            Console.WriteLine("no profit no loss");
    }

    public void Task_1_18()
    {
       /*Write a C# Sharp program to calculate and print the electricity bill of a customer. From the keyboard, the customer's name, ID, and unit consumed should be taken and displayed along with the total amount due.
        The charge are as follow :
        Unit
        Charge / unit
        upto 199
        @1.20
        200 and above but less than 400
        @1.50
        400 and above but less than 600
        @1.80
        600 and above
        @2.00

        If bill exceeds Rs. 400 then a surcharge of 15 % will be charged and the minimum bill should be of Rs. 100 / -
        Test Data:
            1001
        James
        800
        Expected Output :
        Customer IDNO :1001
        Customer Name :James
        unit Consumed: 800
        Amount Charges @Rs. 2.00 per unit : 1600.00
        Surchage Amount : 240.00
        Net Amount Paid By the Customer : 1840.00
        */
        double charge;
        //Define customer ID and and get user input
        Console.Write("Input the customer ID: \t");
        int customerID = Convert.ToInt32(Console.ReadLine());
        //Define customer name and and get user input
        Console.Write("Input the customer name: \t");
        string customerName = Console.ReadLine();
        //Define consumed units and get user input
        Console.Write("Input the consumed units: \t");
        int consumedUnits = Convert.ToInt32(Console.ReadLine());
        // Determining the charge based on consumed units
        if (consumedUnits < 200)
            charge = 1.20;
        else if (consumedUnits >= 200 && consumedUnits < 400)
            charge = 1.50;
        else if (consumedUnits >= 400 && consumedUnits < 600)
            charge = 1.80;
        else
            charge = 2.00;
        double gramt = consumedUnits * charge;  // Calculating gross amount
        double surchg = 0;
        if (gramt > 300)
            surchg = gramt * 15 / 100.0;  // Calculating surcharge if the gross amount exceeds 300
        double netamt;
        netamt = gramt + surchg;  // Calculating net amount
        if (netamt < 100)
            netamt = 100;  // Setting minimum net amount as 100
        Console.WriteLine("Customer ID  NO :  " + customerID);
        Console.WriteLine("Customer Name :  " + customerName);
        Console.WriteLine("Unit Consumed :  " + consumedUnits);
        Console.WriteLine("Amount Charges @Rs. " + charge + "  per unit  " + gramt);
        Console.WriteLine("Surchage Amount :  " + surchg);
        Console.WriteLine("Net Amount Paid By the Customer :  " + netamt);
    }

    public void Task_1_19()
    {
       /*Write a program in C# Sharp to accept a grade and declare the equivalent description :
        Grade
        Description
        E
        Excellent
        V
        Very Good
        G
        Good
        A
        Average
        F
        Fail
        Test Data :
        Input the grade: a
        Expected Output:
        You have chosen: Average
        */
        //Define grade and and get user input
        Console.Write("Input the grade: \t");
        char grade = Convert.ToChar(Console.ReadLine());
        // declare the equivalent description
        if (grade == 'a' || grade == 'A')
            Console.WriteLine("Average");
        else if (grade == 'e' || grade == 'E')
            Console.WriteLine("Excellent");
        else if (grade == 'f' || grade == 'F')
            Console.WriteLine("Fail");
        else if (grade == 'g' || grade == 'G')
            Console.WriteLine("Good");
        else if (grade == 'v' || grade == 'V')
            Console.WriteLine("Very Good");
    }

    public void Task_1_20()
    {
       /*Write a C# Sharp program to read any day number as an integer and display the name of the day as a word.
        Test Data:
        4
        Expected Output :
        Thursday
        */
        //Define day number and get user input
        Console.Write("Input the day number: \t");
        int dayNumber = Convert.ToInt32(Console.ReadLine());
        // check day number 
        if (dayNumber == 1)
            Console.WriteLine("Saturday ");
        else if (dayNumber == 2)
            Console.WriteLine("Sunday ");
        else if (dayNumber == 3)
            Console.WriteLine("Monday ");
        else if (dayNumber == 4)
            Console.WriteLine("Tuesday ");
        else if (dayNumber == 5)
            Console.WriteLine("Wednesday ");
        else if (dayNumber == 6)
            Console.WriteLine("Thursday ");
        else if (dayNumber == 7)
            Console.WriteLine("Friday ");
        else
            Console.WriteLine("Not in range 1 - 7 ");
    }

    public void Task_1_21()
    {
       /*Write a program in C# Sharp to read any digit, display in the word.
        Test Data:
        4
        Expected Output :
        Four
        */
        //Define digit and get user input
        Console.Write("Input the digit: \t");
        int digit = Convert.ToInt32(Console.ReadLine());
        // check day number 
        if (digit == 1)
            Console.WriteLine("One ");
        else if (digit == 2)
            Console.WriteLine("Two ");
        else if (digit == 3)
            Console.WriteLine("Three ");
        else if (digit == 4)
            Console.WriteLine("Four ");
        else if (digit == 5)
            Console.WriteLine("Five ");
        else if (digit == 6)
            Console.WriteLine("Six ");
        else if (digit == 7)
            Console.WriteLine("Seven ");
        else if (digit == 8)
            Console.WriteLine("Eigth ");
        else if (digit == 9)
            Console.WriteLine("Nine ");
        else
            Console.WriteLine("Not in range 1 - 9 ");
    }

    public void Task_1_22()
    {
       /*Write C# Sharp program to read any Month Number in integer and display Month name.
        Test Data :
        4
        Expected Output:
        April
        */
        //Define Month No and get user input
        Console.Write("Input the Month No. : \t");
        int monthNo = Convert.ToInt32(Console.ReadLine());
        // check month number 
        if (monthNo == 1)
            Console.WriteLine("January ");
        else if (monthNo == 2)
            Console.WriteLine("February ");
        else if (monthNo == 3)
            Console.WriteLine("March ");
        else if (monthNo == 4)
            Console.WriteLine("April ");
        else if (monthNo == 5)
            Console.WriteLine("May ");
        else if (monthNo == 6)
            Console.WriteLine("June ");
        else if (monthNo == 7)
            Console.WriteLine("July ");
        else if (monthNo == 8)
            Console.WriteLine("August ");
        else if (monthNo == 9)
            Console.WriteLine("September ");
        else if (monthNo == 10)
            Console.WriteLine("October ");
        else if (monthNo == 11)
            Console.WriteLine("November ");
        else if (monthNo == 12)
            Console.WriteLine("December ");
        else
            Console.WriteLine("Not in range 1 - 12 ");
    }

    public void Task_1_23()
    {
       /*Write a program in C# Sharp to read any Month Number in integer and display the number of days for this month.
        Test Data:
        7
        Expected Output:
        Month have 31 days
        */
        //Define Month No and get user input
        Console.Write("Input the Month No. : \t");
        int monthNo = Convert.ToInt32(Console.ReadLine());
        // check month number 
        switch (monthNo)  // Switch statement based on the entered month number
        {
            case 1: Console.Write("Month has 31 days. \n"); break;
            case 3: Console.Write("Month has 31 days. \n"); break;
            case 5: Console.Write("Month has 31 days. \n"); break;
            case 7: Console.Write("Month has 31 days. \n"); break;
            case 8: Console.Write("Month has 31 days. \n"); break;
            case 10: Console.Write("Month has 31 days. \n"); break;
            case 12: Console.Write("Month has 31 days. \n"); break;

            case 2: Console.Write("The 2nd month is February and has 28 days or In leap years has 29 days. \n"); break;

            case 4: Console.Write("Month has 30 days. \n"); break;
            case 6: Console.Write("Month has 30 days. \n"); break;
            case 9: Console.Write("Month has 30 days. \n"); break;
            case 11: Console.Write("Month has 30 days. \n"); break;
            default:
                Console.Write("Invalid Month number.\nPlease try again ....\n"); break;
        }
    }

    public void Task_1_24()
    {
       /*Write a C# Sharp program that calculates the area of geometrical shapes using a menu-driven approach.
        Test Data:
        Input your choice: 1
        Input radius of the circle: 5
        Expected Output :
        The area is : 78.500000
        */
        double area = 0.0;
        Console.Write("Input 1 for area of circle\n");
        Console.Write("Input 2 for area of rectangle\n");
        Console.Write("Input 3 for area of triangle\n");
        Console.Write("Input your choice : ");
        int choice = Convert.ToInt32(Console.ReadLine());  // Reading the user's choice
        if (choice == 1)
        {
            //Define radius of the circle and get user input
            Console.Write("Input radius of the circle : \t");
            int r = Convert.ToInt32(Console.ReadLine());
            area = 3.14 * r * r;
        }
        else if (choice == 2)
        {
            //Define length and get user input
            Console.Write("Input length of the rectangle : \t");
            int l = Convert.ToInt32(Console.ReadLine());
            //Define width and get user input
            Console.Write("Input width of the rectangle : \t");
            int w = Convert.ToInt32(Console.ReadLine());
            area = l * w;
        }
        else if (choice == 3)
        {
            //Define Base and get user input
            Console.Write("Input the base of the triangle : \t");
            int b = Convert.ToInt32(Console.ReadLine());
            //Define height and get user input
            Console.Write("Input the height of the triangle : \t");
            int h = Convert.ToInt32(Console.ReadLine());
            area = 0.5 * b * h;
        }
        Console.Write("The area is : " + area);
    }

    public void Task_2_1()
    {
       /*Write a program in C# Sharp to input a string and print it.
        Test Data:
        Input the string : Welcome,     halalAlmashakl
        Expected Output:
        The string you entered is : Welcome,     halalAlmashakl
        */
        //Define string and get user input
        Console.Write("Input the string : \t");
        string str = Console.ReadLine();
        Console.Write("The string you entered is : \t" + str);
    }

    public void Task_2_2()
    {
       /*Write a C# Sharp program to find the length of a string without using a library function.
        Test Data:
        Input the string :     halalAlmashakl.com
        Expected Output:
        Length of the string is : 15
        */
        int countChar = 0;
        //Define string and get user input
        Console.Write("Input the string : \t");
        string str = Console.ReadLine();
        foreach (char chr in str)
        {
            countChar++;
        }
        Console.Write("Length of the string is : \t" + countChar);
    }

    public void Task_2_3()
    {
       /*Write a C# Sharp program to separate individual characters from a string.
        */
        //Define string and get user input
        Console.Write("Input the string : \t");
        string str = Console.ReadLine();
        foreach (char chr in str)
        {
            Console.WriteLine(chr);
        }
    }

    public void Task_2_4()
    {
       /*Write a program in C# Sharp to print individual characters of the string in reverse order.
        */
        //Define string and get user input
        Console.Write("Input the string : \t");
        string str = Console.ReadLine();
        string inverseStr = "";
        foreach (char chr in str)
        {
            inverseStr = chr + inverseStr;
        }
        Console.WriteLine("The string in reverse order : " + inverseStr);
    }

    public void Task_2_5()
    {
       /*Write a program in C# Sharp to count the total number of words in a string.
        Test Data:
        Input the string : This is halalAlmashakl.com
        Expected Output:
        Total number of words in the string is : 3
        */
        //Define string and get user input
        Console.Write("Input the string : \t");
        string str = Console.ReadLine();
        int worcCount = 1;
        foreach (char chr in str)
        {
            if (chr == ' ' || chr == '\n' || chr == '\t')
            {
                worcCount++;
            }
        }
        Console.WriteLine("The number of words in the string is : " + worcCount);
    }

    public void Task_2_6()
    {
       /*Write a program in C# Sharp to compare two strings without using a string library functions.
        Test Data:
        Input the 1st string : This is first string
        Input the 2nd string : This is first string
        Expected Output:
        The length of both strings are equal and
        also, both strings are equal.
        */

        //Define string1 and get user input
        Console.Write("Input the 1st string : \t");
        string str1 = Console.ReadLine();
        //Define string2 and get user input
        Console.Write("Input the 2nd string : \t");
        string str2 = Console.ReadLine();
        if (str1.Length == str2.Length)
            if (str1 == str2)
                Console.WriteLine("The length of both strings are equal and \r\nalso, both strings are equal.");
            else
                Console.WriteLine("The length of both strings are equal and \r\nalso, both strings are not equal.");
        else
            Console.WriteLine("The length of both strings are not equal and \r\nalso, both strings are not equal.");
    }

    public void Task_2_7()
    {
       /*Write a program in C# Sharp to count the number of alphabets, digits and special characters in a string.
        Test Data:
        Input the string : Welcome to     halalAlmashakl.com
        Expected Output:
        Number of Alphabets in the string is : 21
        Number of Digits in the string is : 1
        Number of Special characters in the string is : 4
        */
        //Define string and get user input
        Console.Write("Input the string : \t");
        string str = Console.ReadLine();
        int Alphabets = 0, Digits = 0, Special = 0;
        foreach (char chr in str)
        {
            if (chr >= '0' && chr <= '9')
            {
                Digits++;
            }
            else if ((chr >= 'A' && chr <= 'Z') || (chr >= 'a' && chr <= 'z'))
            {
                Alphabets++;
            }
            else
                Special++;
        }
        Console.WriteLine("Number of Alphabets in the string is : " + Alphabets);
        Console.WriteLine("Number of Digits in the string is : " + Digits);
        Console.WriteLine("Number of Special in the string is : " + Special);
    }

    public void Task_2_8()
    {
       /*Write a program in C# Sharp to copy one string to another string.
        Test Data:
        Input the string : This is a string to be copied.
        Expected Output :
        The First string is : This is a string to be copied.
        The Second string is : This is a string to be copied. 
        Number of characters copied : 31
        */
        //Define string1 and get user input
        Console.Write("Input the string1 : \t");
        string str1 = Console.ReadLine();
        string str2 = "";
        int countCopy = 0;
        foreach (char chr in str1)
        {
            str2 += chr;
            countCopy++;
        }
        Console.WriteLine("The First string is  : " + str1);
        Console.WriteLine("The Second string is  : " + str2);
        Console.WriteLine("Number of characters copied : " + countCopy);
    }

    public void Task_2_9()
    {
       /*Write a C# Sharp program to count the number of vowels or consonants in a string.
        Test Data:
        Input the string : Welcome to     halalAlmashakl.com
        Expected Output:
        The total number of vowel in the string is : 9
        The total number of consonant in the string is : 12
        */
        //Define string and get user input
        Console.Write("Input the string : \t");
        string str = Console.ReadLine();
        int vowelsCount = 0;
        int consonantsCount = 0;
        foreach (char chr in str)
        {
            // Check vowels or consonants
            if (chr == 'A' || chr == 'a' || chr == 'E' || chr == 'e' || chr == 'I' || chr == 'i' || chr == 'O' || chr == 'o' || chr == 'U' || chr == 'u')
                vowelsCount++;
            else
                consonantsCount++;
        }
        Console.WriteLine("The total number of vowel in the string is  : " + vowelsCount);
        Console.WriteLine("The total number of consonant in the string is : " + consonantsCount);
    }

    public void Task_2_10()
    {
       /*Write a C# Sharp program to find the maximum number of characters in a string.
        Test Data:
        Input the string : Welcome to     halalAlmashakl.com
        Expected Output:
        The Highest frequency of character 'e'
        appears number of times : 4
        */
        //Define string and get user input        
        Console.Write("Input the string : \t");
        string str = Console.ReadLine();
        char chrr = ' ';
        int chrCount = 0;
        foreach (char chr in str)
        {
            int tempCount = str.Split(chr).Length - 1;
            if (tempCount > chrCount)
            {
                chrCount = tempCount;
                chrr = chr;
            }
        }
        Console.WriteLine("The Highest frequency of character  : " + chrr);
        Console.WriteLine("appears number of times : " + chrCount);
    }

    public void Task_2_11()
    {
       /*Write a C# Sharp program to sort a string array in ascending order.
        Test Data:
        Input the string : this is a string
        Expected Output:
        After sorting the string appears like:
        a g h i i i n r s s s t t
        */
        //Define string and get user input
        Console.Write("Input the string : \t");
        string str = Console.ReadLine();
        char[] sortStr = str.ToCharArray(0, str.Length);
        for (int i = 0; i < sortStr.Length; i++)
            for (int j = 0; j < sortStr.Length; j++)
            {
                // Check ascending order
                if (sortStr[i] < sortStr[j])
                {
                    //Swap chr if not ascending order
                    char temp = sortStr[i];
                    sortStr[i] = sortStr[j];
                    sortStr[j] = temp;
                }
            }
        //print result
        foreach (char chr in sortStr)
        {
            Console.Write(" " + chr);
        }
    }

    public void Task_2_12()
    {
       /*Write a C# Sharp program to read a string through the keyboard and sort it using bubble sort.
        Test Data:
        Input number of strings :3
        Input 3 strings below :
        abcd
        zxcv
        mnop
        Expected Output:
            After sorting the array appears like : 
        abcd
        mnop
        zxcv
        */
        //Define number of string and get user input
        Console.Write("Input number of string : \t");
        int numberOfStr = Convert.ToInt32(Console.ReadLine());
        string[] arrayOfStr = new string[numberOfStr];
        //Define strings and get user input
        for (int i = 0; i < numberOfStr; i++)
        {
            Console.Write("Input the string : \t");
            arrayOfStr[i] = Console.ReadLine();
        }

        for (int i = 0; i < numberOfStr; i++)
            for (int j = 0; j < numberOfStr; j++)
            {
                // Check ascending order
                if (arrayOfStr[i][0] < arrayOfStr[j][0])
                {
                    //Swap string if not ascending order
                    string temp = arrayOfStr[i];
                    arrayOfStr[i] = arrayOfStr[j];
                    arrayOfStr[j] = temp;
                }
            }
        //print result
        foreach (string sttr in arrayOfStr)
        {
            Console.Write(" " + sttr);
        }
    }

    public void Task_2_13()
    {
       /*Write a program in C# Sharp to extract a substring from a given string without using the library function.
        Test Data:
        Input the string : This is a test string
        Input the position to start extraction: 5
        Input the length of substring: 5
        Expected Output :
        The substring retrieve from the string is :  is a
        */
        //Define strings and get user input
        Console.Write("Input the string : \t");
        string str = Console.ReadLine();
        //Define position to start extraction and get user input
        Console.Write("Input the position to start extraction : \t");
        int pos = Convert.ToInt32(Console.ReadLine());
        //Define length of substring and get user input
        Console.Write("Input the length of substring : \t");
        int len = Convert.ToInt32(Console.ReadLine());
        Console.Write("The substring retrieve from the string is : \t");
        for (int i = pos; i < pos + len; i++)
        {
            Console.Write(str[i]);
        }
    }

    public void Task_2_14()
    {
       /*Write a C# Sharp program to check whether a given substring is present in the given string.
        Test Data:
        Input the string : This is a Test String
        Input the substring to search : Test
        Expected Output:
        The substring exists in the string
        */
        //Define strings and get user input
        Console.Write("Input the string : \t");
        string str = Console.ReadLine();
        //Define position to start extraction and get user input
        Console.Write("Input the substring to search : \t");
        string subStringSearch = Console.ReadLine();
        string[] arrayOfString = str.Split(' ');
        int flag = 0;
        foreach (string sttr in arrayOfString)
        {
            if (sttr == subStringSearch)
                flag = 1;
        }
        if (flag == 1)
            Console.Write("The substring exists in the string");
        else
            Console.Write("The substring Not exists in the string");
    }

    public void Task_2_15()
    {
       /*Write a C# Sharp program to read a sentence and replace lowercase characters with uppercase and vice-versa.
        Test Data:
        Input the string : This is a string
        Expected Output:
        After conversion, the string is : tHIS IS A STRING
        */
        //Define strings and get user input
        Console.Write("Input the string : \t");
        string str = Console.ReadLine();
        string newStr = "";
        foreach (char chr in str)
        {
            if ((int)chr >= 65 && (int)chr <= 90)
                newStr += (char)((int)chr + 32);
            else if ((int)chr >= 97 && (int)chr <= 122)
                newStr += (char)((int)chr - 32);
        }
        Console.Write("After conversion, the string is : \t" + newStr);
    }

    public void Task_2_16()
    {
       /*Write a program in C# Sharp to check the username and password.
        Test Data:
        Input a username: uesr
        Input a password: pass
        Input a username: abcd
        Input a password: 1234
        Expected Output :
        Password entered successfully!
        */
        //Define username and get user input
        Console.Write("Input a username : \t");
        string username = Console.ReadLine();
        //Define password and get user input
        Console.Write("Input a password : \t");
        string password = Console.ReadLine();

        //Define username and get user input
        Console.Write("Input a username to test : \t");
        string uName = Console.ReadLine();
        //Define password and get user input
        Console.Write("Input a password to test : \t");
        string pass = Console.ReadLine();
        if (username == uName && password == pass)
            Console.Write("entered successfully!");
        else
            Console.Write("username or password are wrong");
    }

    public void Task_2_17()
    {
       /*Write a program in C# Sharp to search for the position of a substring within a string.
        Test Data:
        Input a String: this is a string
        Input a substring to be found in the string: is
        Expected Output :
        Found 'is' in 'this is a string' at position 2
        */
        //Define strings and get user input
        Console.Write("Input the string : \t");
        string str = Console.ReadLine();
        //Define word and get user input
        Console.Write("Input a substring to be found in the string:\t");
        string substringForSearch = Console.ReadLine();
        for (int i = 0; i < str.Length - 1 - substringForSearch.Length; i++)
        {
            if (str.Substring(i, substringForSearch.Length) == substringForSearch)
                Console.WriteLine("Found '" + substringForSearch + "' in 'this is a string' at position \t" + i);
        }
    }

    public void Task_2_18()
    {
       /*Write a C# Sharp program to check whether a character is an alphabet and not and if so, check for the case.
        Test Data:
        Input a character: Z
        Expected Output:
        The character is uppercase.
        */
        //Define char and get user input
        Console.Write("Input a character: \t");
        char chr = Convert.ToChar(Console.ReadLine());
        if ((chr >= 'A' && chr <= 'Z') || (chr >= 'a' && chr <= 'z'))
        {
            if (chr >= 'A' && chr <= 'Z')
                Console.WriteLine("The character is uppercase.\t");
            else
                Console.WriteLine("The character is lawercase.\t");
        }
        else
            Console.WriteLine("Not Alphabet\t");
    }

    public void Task_2_19()
    {
       /*Write a program in C# Sharp to find the number of times a substring appears in a given string.
        Test Data:
        Input the original string : this is original string
        Input the string to be searched for : str
        Expected Output :
        The string 'str' occurs 1 times
        */
        //Define strings and get user input
        Console.Write("Input the string : \t");
        string str = Console.ReadLine();
        //Define word and get user input
        Console.Write("Input the string to be searched for:\t");
        string substringForSearch = Console.ReadLine();
        int numberOfTimes = 0;
        for (int i = 0; i < str.Length - 1 - substringForSearch.Length; i++)
            {
                if (str.Substring(i, substringForSearch.Length) == substringForSearch)
                    numberOfTimes++;
            }
        Console.WriteLine("The string '" + substringForSearch + "' occurs " + numberOfTimes + " times");
    }

    public void Task_2_20()
    {
       /*Write a program in C# Sharp to insert a substring before the first occurrence of a string.
        Test Data:
        Input the original string : this is a string
        Input the string to be searched for : a
        Input the string to be inserted : test
        Expected Output :
        The modified string is : this is test a string
        */
        //Define strings and get user input
        Console.Write("Input the string : \t");
        string str = Console.ReadLine();
        //Define word and get user input
        Console.Write("Input the string to be searched for:\t");
        string substringForSearch = Console.ReadLine();
        //Define inserted word and get user input
        Console.Write("Input the string to be inserted:\t");
        string insertedWord = Console.ReadLine();
        string newStr = "";
        for (int i = 0; i < str.Length - 1 - substringForSearch.Length; i++)
            {
                if (str.Substring(i, substringForSearch.Length) == substringForSearch)
                {
                    newStr = str.Substring(0, i - 1) + " " + insertedWord + " " + str.Substring(i, str.Length - i);
                    break;
                }
            }
        Console.WriteLine("The modified string is: \t" + newStr);
    }

    public void Task_2_21()
    {
       /*Write a C# Sharp program to compare (less than, greater than, equal to) two substrings.
        Expected Output:
        str1 = 'computer', str2 = 'system'
        Substring 'mp' in 'computer' is less than substring 'sy' in 'system'.
        */
        //Define string1 and get user input
        Console.Write("Input the string1 : \t");
        string str1 = Console.ReadLine();
        //Define string2 and get user input
        Console.Write("Input the string2 : \t");
        string str2 = Console.ReadLine();
        string subStr1 = str1.Substring(0, 2);
        string subStr2 = str2.Substring(2, 2);
        if (subStr1[0] < subStr2[0])
            Console.WriteLine("Substring '" + subStr1 + "' in '" + str1 + "' is less than substring '" + subStr2 + "' in '" + str2 + "'.");
        else if (subStr1[0] > subStr2[0])
            Console.WriteLine("Substring '" + subStr1 + "' in '" + str1 + "' is greater than substring '" + subStr2 + "' in '" + str2 + "'.");
        else
            Console.WriteLine("Substring '" + subStr1 + "' in '" + str1 + "' is equal to substring '" + subStr2 + "' in '" + str2 + "'.");
    }

    public void Task_2_22()
    {
       /*Write a C# Sharp program to compare two substrings that only differ in case. The first comparison ignores case and the second comparison considers case.
        Expected Output:
        str1 = 'COMPUTER', str2 = 'computer'
        Ignore case:
            Substring 'MP' in 'COMPUTER' is equal to substring 'mp' in 'compu                                                                              
        Honor case:
            Substring 'MP' in 'COMPUTER' is greater than substring 'mp' in 'computer'.
            */
            //Define string1 and get user input
            Console.Write("Input the string1 : \t");
            string str1 = Console.ReadLine();
            //Define string2 and get user input
            Console.Write("Input the string2 : \t");
            string str2 = Console.ReadLine();
            string subStr1 = str1.Substring(2, 2);
            string subStr2 = str2.Substring(2, 2);
            Console.WriteLine("Ignore case:  ");
            if (string.Equals(subStr1, subStr1, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Substring '" + subStr1 + "' in '" + str1 + "' is equal to substring '" + subStr2 + "' in '" + str2 + "'.");
            else
                Console.WriteLine("Substring '" + subStr1 + "' in '" + str1 + "' is not equal to substring '" + subStr2 + "' in '" + str2 + "'.");
            Console.WriteLine("Honor case:  ");
            if (subStr1[0] < subStr2[0])
                Console.WriteLine("Substring '" + subStr1 + "' in '" + str1 + "' is less than substring '" + subStr2 + "' in '" + str2 + "'.");
            else if (subStr1[0] > subStr2[0])
                Console.WriteLine("Substring '" + subStr1 + "' in '" + str1 + "' is greater than substring '" + subStr2 + "' in '" + str2 + "'.");
            else
                Console.WriteLine("Substring '" + subStr1 + "' in '" + str1 + "' is equal to substring '" + subStr2 + "' in '" + str2 + "'.");
        }

    public void Task_2_23()
    {
       /*Write a C# Sharp program to compare two substrings using different cultures and ignore the substring case.
        Expected Output:
        str1 = 'COMPUTER', str2 = 'computer'
        Ignore case, Turkish culture:                                                    
        Substring 'UT' in 'COMPUTER' is equal to substring 'ut' in 'computer'.
        Ignore case, invariant culture:                                                  
        Substring 'UT' in 'COMPUTER' is equal to substring 'ut' in 'computer'.
        */
        //Define string1 and get user input
        Console.Write("Input the string1 : \t");
        string str1 = Console.ReadLine();
        //Define string2 and get user input
        Console.Write("Input the string2 : \t");
        string str2 = Console.ReadLine();
        string subStr1 = str1.Substring(2, 2);
        string subStr2 = str2.Substring(2, 2);
        if (subStr1.ToLower() == subStr2.ToLower())
        {
            Console.WriteLine("Ignore case, Turkish culture:  ");
            Console.WriteLine("Substring '" + subStr1 + "' in '" + str1 + "' is equal to substring '" + subStr2 + "' in '" + str2 + "'.");
            Console.WriteLine("Ignore case, invariant culture: ");
            Console.WriteLine("Substring '" + subStr1 + "' in '" + str1 + "' is equal to substring '" + subStr2 + "' in '" + str2 + "'.");
        }
        else
            Console.WriteLine("Substring '" + subStr1 + "' in '" + str1 + "' is Not equal to substring '" + subStr2 + "' in '" + str2 + "'.");
    }

    public void Task_2_24()
    {
       /*Write a C# Sharp program to compare the last names of two people. It then lists them in alphabetical order.
        Expected Output:
        Sorted alphabetically by last name:
        Michel Jhonson
        John Peterson
        */
        //Define Name1 and get user input
        Console.Write("Input the Name1 : \t");
        string Name1 = Console.ReadLine();
        //Define Name2 and get user input
        Console.Write("Input the  Name2 : \t");
        string Name2 = Console.ReadLine();
        string lastName1 = Name1.Substring(Name1.LastIndexOf(' ') + 1);
        string lastName2 = Name2.Substring(Name2.LastIndexOf(' ') + 1);
        Console.WriteLine("Sorted alphabetically by last name: \t");
        if (lastName1[0] < lastName2[0])
        {
            Console.WriteLine(Name1);
            Console.WriteLine(Name2);
        }
        else
        {
            Console.WriteLine(Name2);
            Console.WriteLine(Name1);
        }
    }

}