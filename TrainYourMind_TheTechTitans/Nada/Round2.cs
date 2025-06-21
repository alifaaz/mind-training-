using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;


namespace HelloWorld
{
    public class Round2
    {
        // 1. Write a C# Sharp program to accept two integers and check whether they are equal or not.
        //Sample Input => Expected Output:
        //5, 5 => o/p 5 and 5 are equal
        public static string CheckEquality(int num1,int num2)
        {
            return num1 == num2
                    ? $"{num1} and {num2} are equal"
                    : $"{num1} and {num2} are not equal";
        }

        //2. Write a C# Sharp program to check whether a given number is even or odd.
        //Sample Input => Expected Output:
        //15 => o/p 15 is an odd integer
        public static string CheckEvenOrOddNumber (int num)
        {
            return num % 2 == 1 ? $"{num} is an odd integer" : $"{num} is an even integer";
        }

        //3. Write a C# Sharp program to check whether a given number is positive or negative.
        //Sample Input => Expected Output:
        //14 => o/p 14 is a positive number
        public static string CheckPositiveOrNegativeNumber(int num)
        {
            return num >= 0 ? $"{num} is a positive number" : $"{num} is a negative number";
        }

        //4. Write a C# Sharp program to find out whether a given year is a leap year or not.
        //Sample Input => Expected Output:
        //2016 => o/p 2016 is a leap year.
        public static string CheckLeapYear(int year)
        {
            return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                ? $"{year} is a leap year" : $"{year} is not a leap year";
        }

        //5. Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
        //Sample Input => Expected Output:
        //21 => o/p Congratulation! You are eligible for casting your vote.
        public static string CheckCandidate(int age)
        {
            return age >= 18 ? "Congratulation! You are eligible for casting your vote" : "Unfortunately! You are not eligible for casting your vote";
        }

        //6. Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
        //Sample Input => Expected Output:
        //-5 => o/p The value of n = -1
        public static string DisplayN (int num)
        {
            return num > 0 ? "The value of n = 1" : num == 0? "The value of n = 0" : "The value of n = -1";
        }

        //7. Write a C# Sharp program to accept a person's height in centimeters and categorize them according to their height.
        //Sample Input => Expected Output:
        //135 => o/p The person is Dwarf.
        public static string CategorizeHeight(int heightCm)
        {
            if (heightCm < 140)
                return "The person is Dwarf";
            else if (heightCm >= 140 && heightCm < 165)
                return "The person is of Average height";
            else if (heightCm >= 165 && heightCm < 185)
                return "The person is Tall";
            else
                return "The person is Very Tall";
        }

        //8. Write a C# Sharp program to find the largest of three numbers.
        //Sample Input => Expected Output:
        //25, 63, 10 => o/p The 2nd Number is the greatest among three
        public static string FindMaxNumber(int num1,int num2,int num3)
        {
            int MaxNumber = Math.Max(num1, Math.Max(num2, num3));
            return MaxNumber == num1 ? "The 1st Number is the greatest among three"
                : MaxNumber == num2 ? "The 2nd Number is the greatest among three"
                : "The 3rd Number is the greatest among three";
        }

        //9. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        //Sample Input => Expected Output:
        //7, 9 => o/p The coordinate point(7,9) lies in the First quadrant.
        public static string DetermineQuadrant(int x, int y)
        {
            if (x > 0 && y > 0)
                return $"The coordinate point ({x},{y}) lies in the First quadrant";
            else if (x < 0 && y > 0)
                return $"The coordinate point ({x},{y}) lies in the Second quadrant";
            else if (x < 0 && y < 0)
                return $"The coordinate point ({x},{y}) lies in the Third quadrant";
            else if (x > 0 && y < 0)
                return $"The coordinate point ({x},{y}) lies in the Fourth quadrant";
            else if (x == 0 && y != 0)
                return $"The coordinate point ({x},{y}) lies on the Y axis";
            else if (y == 0 && x != 0)
                return $"The coordinate point ({x},{y}) lies on the X axis";
            else
                return $"The coordinate point ({x},{y}) is at the origin";
        }

        //10. Write a C# Sharp program to determine the eligibility for admission to a professional course based on the following criteria:
        //Marks in Maths >=65
        //Marks in Phy >=55
        //Marks in Chem>=50
        //Total in all three subject >=180
        //or
        //Total in Math and Subjects >=140
        //Test Data :
        //Input the marks obtained in Physics :65
        //Input the marks obtained in Chemistry :51
        //Input the marks obtained in Mathematics :72
        //Expected Output :
        //The candidate is eligible for admission.




    }
}

