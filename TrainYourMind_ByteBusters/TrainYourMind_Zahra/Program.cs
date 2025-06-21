using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.JavaScript;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Zahra_Solutions
{
    public class Program
    {

        
        /* 1. Write a C# Sharp program to compute the sum of the two numerical values.
            If the two values are the same, return triple their sum.*/
        static int Task_1(int a, int b)
        {
            if (a == b) 
                return 3 * (a + b); // If both integers are equal return triple their sum
            return a + b; // Otherwise, return their sum
        }

        /* 2. Write a C# Sharp program to get the absolute difference between n and 51.
            If n is broader than 51 return triple the absolute difference.*/
        static int Task_2(int n)     
        {
            const int main_value = 51; // Define the main value to compare against
            if (n > main_value) // Check if n is greater than the main value
                return 3 * Math.Abs(main_value - n); // If so, return triple the absolute difference
            return Math.Abs(main_value - n); // Otherwise, return the absolute difference
        }

        
        /* 3. Write a C# Sharp program to check two given integers, 
            and return true if one of them is 30 or if their sum is 30.*/
        static bool Task_3(int x, int y)
        {
            if (x == 30 || y == 30 || x + y == 30) // Check if either integer is 30 or if their sum equals 30
                return true; // If either integer is 30 or their sum is 30, return true
            return false; // Otherwise, return false
        }

        
        /* 4. Write a C# Sharp program to check a given integer and 
            return true if it is within 10 of 100 or 200.*/
        static bool Task_4(int n)
        {
            return (Math.Abs(100 - n) <= 10 || Math.Abs(200 - n) <= 10); // Check if n is within 10 of 100 or 200 and return true if it is 
        }

        /* 5. Write a C# Sharp program to create a string where 'if' is added to the front
            of a given string. If the string already begins with 'if', return it unchanged.*/
        static string Task_5(string str)
        {
            if (str.StartsWith("if")) // Check if the string starts with "if"
                return str; // If it does return the string unchanged
            return "if " + str; // Otherwise prepend "if " to the string and return it
        }
        
        /* 6. Write a C# Sharp program to remove the character at a given position in the string. 
            The given position will be in the range 0..(string length -1) inclusive.*/
        static string Task_6(string str, int pos)
        {
            if (pos < 0 || pos >= str.Length) // Check if the position is out of bounds
                return "position is out of bounds!"; // If so, return the string unchanged
            return str.Remove(pos, 1); // else remove the character at the specified position and return the modified string
        }

        
        /* 7. Write a C# Sharp program to exchange the first and last characters in a
            given string and return the new string.*/
        static string Task_7(string str)
        {
            int length = str.Length; // Get the length of the string
            if (length < 2) // Check if the string is too short to swap characters
                return str; // If so, return the string unchanged
            return str[length - 1] + str.Substring(1, length - 2) + str[0]; // Swap the first and last characters and return the new string
        }

         /* 8. Write a C# Sharp program to create a string which is 4 copies of the 2 front characters of a given string. 
            If the given string length is less than 2 return the original string.*/
        static string Task_8(string str)
        {
            if (str.Length < 2) // Check if the string length is less than 2
                return str; // If so, return the original string
            string front = str.Substring(0, 2) + " "; // Get the first two characters of the string
            return front + front + front + front; // Return the string with the first two characters repeated four times
            // OFC you can use a loop to repeat the string 4 times but why encrease the complexity when you can do it in one line
        }

        /*9. Write a C# Sharp program to create a string with the last char added at the
            front and back of a given string of length 1 or more*/
        static string Task_9(string str)
        {
            if (str.Length < 1) // Check if the string length is less than 1
                return "Where is your String >:( "; // If so, return the original string
            char lastChar = str[str.Length - 1]; // Get the last character of the string
            return lastChar + str + lastChar; // Return the string with the last character added at the front and back
        }

        /* 10. Write a C# Sharp program to check if a given positive number is a multiple of 3 or 7.*/
        static bool Task_10(int n)
        {
            return (n % 3 == 0 || n % 7 == 0); // Check if the number is a multiple of 3 or 7 and return true if it is
        }

        /* 11. Write a C# Sharp program to create a string taking the first 3 characters of
            a given string. Return the string with the 3 characters added at both the front
            and back. If the given string length is less than 3, use whatever characters are there.*/
        static string Task_11(string str)
        {
            if (str.Length < 3) // Check if the string length is less than 3
                return str + str + str; // return the string repeated three times
            string front = str.Substring(0, 3); // Get the first three characters of the string
            return front + str + front; // Return the string with the first three characters added at both the front and back
        }

        // 12. Write a C# Sharp program to check if a given string starts with 'C#' or not.
        static bool Task_12(string str)
        {
            return str.StartsWith("C#"); // if the string starts with "C#" return true
        }

        /* 13. Write a C# Sharp program that checks whether one temperature is less
               than 0 and another is greater than 100*/
        static bool Task_13(int temp1, int temp2)
        {
            if (temp1 < 0 && temp2 > 100 || temp2 < 0 && temp1 > 100) 
                // Check if one temperature is less than 0 and another is greater than 100
                return true; // If so, return true
            return false; // else, return false
        }

        /* 14. Write a C# Sharp program to check two given integers whether either of
               them is in the range 100..200 inclusive.*/
        static bool Task_14(int a, int b)
        {
            return (a >= 100 && a <= 200) || (b >= 100 && b <= 200); // Check if either integer is in the range 100..200 inclusive
        }

        /* 15. Write a C# Sharp program to check whether three given integer values are
               in the range 20..50 inclusive. Return true if 1 or more of them are in the said
               range otherwise false.*/
        static bool Task_15(int a, int b, int c)
        {
            return ((a >= 20 && a <= 50) || (b >= 20 && b <= 50) || (c >= 20 && c <= 50));
                // return true if any of the three integers are in the range 20..50 inclusive
        }
        /* 16. Write a C# Sharp program to check whether two given integer values are
               in the range 20..50 inclusive. Return true if 1 or other is in the range, otherwise false.*/
        static bool Task_16(int a, int b)
        {
            return ((a >= 20 && a <= 50) || (b >= 20 && b <= 50));
            // return true if either of the two integers are in the range 20..50 inclusive
        }

        /* 17. Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. 
               If it appears return a string without 'yt' otherwise return the original string.*/
        static string Task_17(string str)
        {
            if(str.Length < 2 || !str.Substring(1, 2).Equals("yt")) 
                // Check if the string is too short or if "yt" does not appear at index 1
                return str; // If so, return the original string
            return str.Remove(1, 2); // Otherwise, remove "yt" from the string and return the modified string
        }

        // 18. Write a C# Sharp program to check the largest number among three given integers.

        static int Task_18(int x, int y, int z)
        {
            int max = x; // Assume x is the largest number initially
            if (max < y) max = y; // Check if y is greater than x
            if (max < z) max = z; // Check if z is greater than y
            return max; // Return the largest number among the three integers

        }

        /* 19. Write a C# Sharp program to check which number is closest to 100 among
               two given integers. Return 0 if the two numbers are equal*/
        static int Task_19(int a, int b)
        {
            if (a == b) return 0; // If both integers are equal, return 0
            int diffA = 100 - a; // Calculate the difference between a and 100
            int diffB = 100 - b; // Calculate the difference between b and 100
            if (diffA < diffB) return a; // If a is closer to 100, return a
            return b; // else, return b
        }

        /* 20. Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive,
               or they are both in the range 50..60 inclusive*/
        static bool Task_20(int a, int b)
        {
            return ((a >= 40 && a <= 50 && b >= 40 && b <= 50) ||(a >= 50 && a <= 60 && b >= 50 && b <= 60));
                // return true if both integers are in the range 40..50 inclusive or both are in the range 50..60 inclusive
        }

        /* 21. Write a C# Sharp program to find the largest value from two positive
        integer values in the range 20..30 inclusive.Return 0 if neither is in that range.*/
        static int Task_21(int a, int b)
        {
            if ((a < 20 || a > 30) || (b < 20 || b > 30)) // Check if either integer is outside the range 20..30 inclusive
                return 0; // Return 0 if neither integer is in the range 20..30 inclusive
            return Math.Max(a, b); // Return the maximum of a and b
        }

        // 22. Write a C# Sharp program to check if a given string contains between 2 and 4 'z' characters.
        static bool Task_22(string str)
        {
            int count = 0; // Initialize a counter for 'z' characters
            foreach (char c in str) // Iterate through each character in the string
            {
                if (c == 'z') count++; // Increment the counter if the character is 'z'
            }
            return (count >= 2 && count <= 4); // Return true if the count is between 2 and 4 inclusive
        }

        // 23. check if two given non-negative integers have the same last digit.
        static bool Task_23(int a, int b)
        {
            return (a % 10 == b % 10); // If the rank of the ones is equal return true
        }

        /* 24. Write a C# Sharp program to convert the last 3 characters of a given string
            to uppercase. If the length of the string is less than 3, then uppercase all the
            characters*/
        static string Task_24(string str)
        {
            if (str.Length < 3) return str.ToUpper(); // If the string length is less than 3, convert the entire string to uppercase
            return str.Substring(0, str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
            // Otherwise, convert the last 3 characters to uppercase and return the modified string
        }

        // 25. create a string which is n (non-negative integer) copies of a given string
        static void Task_25(string str, int n)
        {
            if (n < 0) 
                Console.WriteLine("U must give a non-negative integer!"); // Check if n is a non-negative integer
            for (int i = 0; i < n; i++) // Loop n times
            {
                Console.Write(str); // Print the string n times
            }
            Console.WriteLine(); // Print a new line after printing the string n times

        }

         // 1. Write a C# Sharp program to accept two integers and check whether they are equal or not.
         static void Task_26()
        {
            Console.Write("Input 1st number: ");
            int x = int.Parse(Console.ReadLine()); // Read the first integer from the user
            Console.Write("Input 2nd number: ");
            int y = int.Parse(Console.ReadLine()); // Read the second integer from the user
            if (x == y) // Check if the two integers are equal
                Console.WriteLine($"{x} and {y} are equal"); // If they are equal, print a message
            else
                Console.WriteLine($"{x} and {y} are not equal!"); // If they are not equal, print a different message
        }

        // 2. Write a C# Sharp program to check whether a given number is even or odd.
        static void Task_27()
        {
            Console.Write("Test Data : ");
            int n = int.Parse(Console.ReadLine()); // Read an integer from the user
            if (n % 2 == 0) // Check if the number is even
                Console.WriteLine($"{n} is an even integer"); // If it is even, print a message
            else
                Console.WriteLine($"{n} is an odd integer"); // If it is odd, print a different message
        }

        // 3. Write a C# Sharp program to check whether a given number is positive or negative
        static void Task_28()
        {
            Console.Write("Test Data : ");
            int n = int.Parse(Console.ReadLine()); // Read an integer from the user
            if (n > 0) // Check if the number is positive
                Console.WriteLine($"{n} is a positive number"); 
            else if (n < 0)
                Console.WriteLine($"{n} is a negative number"); 
            else
                Console.WriteLine($"{n} is a neutral number."); // If the number is zero, print a different message
        }

        /* 4. Write a C# Sharp program to find out whether a given year is a leap year or not
        NOTE: A year is a leap year if it is divisible by 4, except for end-of-century years.
            It is occurring once every four years, which has 366 days including 29 February as an intercalary day.
         */
        static void Task_29()
        {
            Console.Write("Test Data : ");
            int year = int.Parse(Console.ReadLine()); // Read a year from the user
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                /*
                 Check if the year is a leap year
                 Excludes years that are divisible by 100 (ex: 1900 is not a leap year).
•	             year % 400 == 0: Includes years that are divisible by 400(e.g., 2000 is a leap year).
                 */
                Console.WriteLine($"{year} is a leap year"); // If it is a leap year, print a message
            else
                Console.WriteLine($"{year} is not a leap year"); // If it is not a leap year, print a different message
        }

        //5. read the age of a candidate and determine whether it is eligible for casting his/her own vote.
        static void Task_30()
        {
            Console.Write("Test Data : ");
            int age = int.Parse(Console.ReadLine()); // Read the age from the user
            if (age >= 18) // Check if the age is 18 or older (if an adult)
                Console.WriteLine("Congratulation! You are eligible for casting your vote."); // If so, print a message
            else
                Console.WriteLine("unfortunately..You are not eligible for casting your own vote."); // If not, print a different message
        }

        /* 6. Write a C# Sharp program to read the value of an integer m and display the
            value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.*/
        static void Task_31()
        {
            Console.Write("Test Data : ");
            int m = int.Parse(Console.ReadLine()); // Read an integer from the user
            if (m > 0) // Check if m is larger than 0
                Console.WriteLine("The value of n = 1"); // If so, print n = 1
            else if (m == 0) // Check if m is equal to 0
                Console.WriteLine("The value of n = 0"); // If so, print n = 0
            else // If m is less than 0
                Console.WriteLine("The value of n = -1"); // Print n = -1
        }
        /*7. Write a C# Sharp program to accept a person's height in centimeters and
        categorize them according to their height*/
        static void Task_32()
        {
            Console.Write("Input the 1st number: ");
            int first = int.Parse(Console.ReadLine()); // Read the height in centimeters from the user
            Console.Write("Input the 2nd number: ");
            int second = int.Parse(Console.ReadLine()); // Read the second height in centimeters from the user
            Console.Write("Input the 3rd number: ");
            int third = int.Parse(Console.ReadLine()); // Read the third height in centimeters from the user
            int max = Math.Max(first, Math.Max(second, third)); // Find the maximum height among the three inputs
            if (max == first) // Check if the first height is the maximum
                Console.WriteLine("The 1st Number is the greatest among three");
            else if (max == third) // Check if the third height is the maximum
                Console.WriteLine("The 3rd Number is the greatest among three"); 
            else if (max == second)// If neither of the above conditions are true, then the second height is the maximum
                Console.WriteLine("The 2nd Number is the greatest among three"); // Print the maximum height
        }

        /* 9. Write a C# Sharp program to accept a coordinate point in an XY coordinate
        system and determine in which quadrant the coordinate point lies
        Test Data :
        Input the value for X coordinate :7
        Input the value for Y coordinate :9
        Expected Output :
        The coordinate point (7,9) lies in the First quadrant
         */
        static void Task_33()
        {
            Console.Write("Test Data : \nInput the value for X coordinate: ");
            int x = int.Parse(Console.ReadLine()); // Read the X coordinate from the user
            Console.Write("Input the value for Y coordinate: ");
            int y = int.Parse(Console.ReadLine()); // Read the Y coordinate from the user
            if (x > 0 && y > 0) // Check if both coordinates are positive
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant");
            else if (x < 0 && y > 0) // Check if X is negative and Y is positive
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant");
            else if (x < 0 && y < 0) // Check if both coordinates are negative
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant");
            else if (x > 0 && y < 0) // Check if X is positive and Y is negative
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant");
            else if (x == 0 && y != 0) // Check if X is zero and Y is not zero
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the Y-axis");
            else if (y == 0 && x != 0) // Check if Y is zero and X is not zero
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the X-axis");
            else // If both coordinates are zero
                Console.WriteLine("The coordinate point (0,0) is at the origin");
        }


        /*
         10. Write a C# Sharp program to determine the eligibility for admission to a
            professional course based on the following criteria:
            Marks in Maths >=65
            Marks in Phy >=55
            Marks in Chem>=50
            Total in all three subject >=180
            or
            Total in Math and Subjects >=140
         */
        static void Task_34()
        {
            Console.Write("Test Data : \nInput the marks obtained in Physics :");
            int physics = int.Parse(Console.ReadLine()); // Read the marks obtained in Physics
            Console.Write("Input the marks obtained in Chemistry :");
            int chemistry = int.Parse(Console.ReadLine()); // Read the marks obtained in Chemistry
            Console.Write("Input the marks obtained in Mathematics :");
            int mathematics = int.Parse(Console.ReadLine()); // Read the marks obtained in Mathematics
            if (physics >= 65 && chemistry >= 50 && mathematics >= 55 && (physics + chemistry + mathematics) >= 180 ||
                ((physics + mathematics) >= 140 && (chemistry + mathematics) >= 140)) // Check if the candidate meets the eligibility criteria
            {
                Console.WriteLine("The candidate is eligible for admission"); // If so, print a message
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission"); // If not, print a different message
            }
        }

         // 11. Write a C# Sharp program to calculate the root of a quadratic equation.
        static void Task_35()
        {
            Console.Write("Test Data : \nInput the value of a : ");
            double a = double.Parse(Console.ReadLine()); // Read the value of a from the user
            Console.Write("Input the value of b : ");
            double b = double.Parse(Console.ReadLine()); // Read the value of b from the user
            Console.Write("Input the value of c : ");
            double c = double.Parse(Console.ReadLine()); // Read the value of c from the user
            
            double discriminant = b * b - 4 * a * c; // The formula is: x = (-b ± √(b² - 4ac)) / 2a 
            
            if (discriminant < 0) // Check if the discriminant is negative
                Console.WriteLine("Root are imaginary; \nNo Solution"); // If so, print a message indicating no solution

            else if (discriminant == 0) // Check if the discriminant is zero
            {
                double root = -b / (2 * a); // Calculate the single root
                Console.WriteLine($"The root is: {root}"); // Print the root
            }

            else // If the discriminant is positive
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a); // Calculate the first root
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a); // Calculate the second root
                Console.WriteLine($"The roots are: {root1} and {root2}"); // Print both roots
            }
        }

        /*
         12. Write a C# Sharp program to read roll no, name and marks of three
            subjects and calculate the total, percentage and division.
         */
        static void Task_36()
        { 
            Console.Write("Test Data : \nInput the Roll Number of the student :");
            int roll = int.Parse(Console.ReadLine());
            Console.Write("Input the Name of the Student :");
            string name = Console.ReadLine();
            Console.Write("Input the marks of Physics :");
            int Physics = int.Parse(Console.ReadLine());
            Console.Write("Input the marks of Chemistry :");
            int Chemistry = int.Parse(Console.ReadLine());
            Console.Write("Input the marks of Computer Application :");
            int Computer_Application = int.Parse(Console.ReadLine());

            int total = Physics + Chemistry + Computer_Application; // Calculate the total marks
            double percentage = (double)total / 3; // Calculate the percentage
            string division;
            if (percentage >= 70) // Check the percentage to determine the division
                division = "First";
            else if (percentage >= 60)
                division = "Second";
            else if (percentage >= 50)
                division = "Third";
            else
                division = "Fail";

            Console.WriteLine($"\nRoll No : {roll}");
            Console.WriteLine($"Name of Student : {name}");
            Console.WriteLine($"Marks in Physics : {Physics}");
            Console.WriteLine($"Marks in Chemistry : {Chemistry}");
            Console.WriteLine($"Marks in Computer Application : {Computer_Application}");
            Console.WriteLine($"Total Marks = {total}");
            Console.WriteLine($"Percentage = {percentage:F2}"); // Print the percentage formatted to two decimal places
            Console.WriteLine($"Division = {division}"); // Print the division based on the percentage

        }

        /* 13. Write a C# Sharp program to read temperature in centigrade and display a
            suitable message according to the temperature state below:
            Temp < 0 then Freezing weather
            Temp 0-10 then Very Cold weather
            Temp 10-20 then Cold weather
            Temp 20-30 then Normal in Temp
            Temp 30-40 then Its Hot
            Temp >=40 then Its Very Hot */
        static void Task_37()
        {
            Console.WriteLine("Test Data : ");
            int temp = int.Parse(Console.ReadLine()); // Read the temperature in centigrade from the user
            
            if (temp < 0)
                Console.WriteLine("Freezing weather"); // If the temperature is less than 0, print "Freezing weather"
            else if (temp >= 0 && temp < 10)
                Console.WriteLine("Very Cold weather"); // If the temperature is between 0 and 10, print "Very Cold weather"
            else if (temp >= 10 && temp < 20)
                Console.WriteLine("Cold weather"); // If the temperature is between 10 and 20, print "Cold weather"
            else if (temp >= 20 && temp < 30)
                Console.WriteLine("Normal in Temp"); // If the temperature is between 20 and 30, print "Normal in Temp"
            else if (temp >= 30 && temp < 40)
                Console.WriteLine("Its Hot"); // If the temperature is between 30 and 40, print "Its Hot"
            else
                Console.WriteLine("Its Very Hot"); // If the temperature is greater than or equal to 40, print "Its Very Hot"
        }


        // 14. Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.
        static void Task_38()
        {
            Console.WriteLine("Test Data : ");
            int a = int.Parse(Console.ReadLine()); // Read the first angle of the triangle
            int b = int.Parse(Console.ReadLine()); // Read the second angle of the triangle
            int c = int.Parse(Console.ReadLine()); // Read the third angle of the triangle
            if (a <= 0 || b <= 0 || c <= 0) // Check if the angles are valid
                Console.WriteLine("Invalid triangle angles!"); // If not, print an error message  
            else
                {
                if (a == b && b == c) // Check if all angles are equal
                    Console.WriteLine("This is an equilateral triangle."); // If so, print "Equilateral triangle"
                else if (a == b || b == c || a == c) // Check if any two angles are equal
                    Console.WriteLine("This is an isosceles triangle."); // If so, print "Isosceles triangle"
                else
                    Console.WriteLine("This is a scalene triangle."); // If no angles are equal, print "Scalene triangle"
            }
        }

       //15. Write a C# Sharp program to check whether a triangle can be formed by the given angles value.
       static void Task_39()
        {
            Console.WriteLine("Test Data : ");
            int a = int.Parse(Console.ReadLine()); // Read the first angle of the triangle
            int b = int.Parse(Console.ReadLine()); // Read the second angle of the triangle
            int c = int.Parse(Console.ReadLine()); // Read the third angle of the triangle
            if (a <= 0 || b <= 0 || c <= 0 || a + b + c != 180) // Check if the angles are valid and sum to 180 degrees
                Console.WriteLine("The triangle is not valid"); // If not, print an error message
            else
                Console.WriteLine("The triangle is valid"); // If valid, print a success message
        }

        /* 16. Write a C# Sharp program to check whether an alphabet letter is a vowel or a consonant.
            Test Data :
            k
            Expected Output :
            The alphabet is a consonant */
        static void Task_40()
        {
            Console.WriteLine("Test Data: ");
            char letter = char.ToLower(Console.ReadKey().KeyChar); // Read a character from the user and convert it to lowercase
            if ("aeiou".Contains(letter)) // Check if the letter is a vowel
                Console.WriteLine("\nThe alphabet is a vowel"); // If so, print "Vowel"
            else if (char.IsLetter(letter)) // Check if the character is a letter but not a vowel
                Console.WriteLine("\nThe alphabet is a consonant"); // If so, print "Consonant"
            else
                Console.WriteLine("\nInvalid input! Enter an alphabet letter XD"); // If not a letter, print an error message
        }

        /* 17. Write a C# Sharp program to calculate profit and loss on a transaction.
            Test Data :
            500 700
            Expected Output :
            You can book your profit amount : 200 */
        static void Task_41()
        {
            Console.WriteLine("Test Data: ");
            double cost = double.Parse(Console.ReadLine()); // Read the cost price from the user
            double sell = double.Parse(Console.ReadLine()); // Read the selling price from the user
            
            if (sell > cost) // Check if there is a profit
                Console.WriteLine($"You can book your profit amount: {sell - cost}"); // If so, print the profit amount
            else if (sell < cost) // Check if there is a loss
                Console.WriteLine($"You can book your loss amount: {cost - sell}"); // If so, print the loss amount
            else
                Console.WriteLine("No profit, no loss!"); // Else, print a message indicating no profit or loss
        }
        /* 18. Write a C# Sharp program to calculate and print the electricity bill of a customer. From the keyboard, the customer's name, ID, and unit consumed should be taken and displayed along with the total amount due.
                The charge are as follow :
                Unit Charge/unit
                upto 199 @1.20
                200 and above but less than 400 @1.50
                400 and above but less than 600 @1.80
                600 and above @2.00
                If bill exceeds Rs. 400 then a surcharge of 15% will be charged and the minimum bill should be of Rs. 100/-*/

        static void Task_42()
        {
            Console.WriteLine("Test Data: ");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine()); // Read the customer ID from the user
            Console.Write("Name: ");
            string name = Console.ReadLine(); // Read the customer name from the user
            Console.Write("Units Consumed: ");
            double units = double.Parse(Console.ReadLine()); // Read the units consumed from the user
            
            double amount;
            if (units <= 199)
                amount = units * 1.20; // Calculate amount up tp 199 
            else if (units <= 200 && units < 400)
                amount = units * 1.50; // Calculate amount for units 200 and above but less than 400
            else if (units <= 400 && units < 600)
                amount = units * 1.80; // Calculate amount for units 400 and above but less than 600
            else
                amount = units * 2.00; // Calculate amount for units 600 and above

            double surcharge;
            if (amount > 400)
                surcharge = amount * 0.15; // If bill exceeds Rs. 400 then a surcharge of 15% will be charged
            else
                surcharge = 0; // No surcharge if amount is less than or equal to Rs. 400

            double totalAmount = amount + surcharge; // Calculate the total amount including surcharge
            if (totalAmount < 100)
                totalAmount = 100; // Ensure minimum bill is Rs. 100

            //double totalAmount = Math.Max(amount + surcharge, 100); // Ensure minimum bill is Rs. 100

            Console.WriteLine($"\nCustomer IDNO: {id}");
            Console.WriteLine($"Customer Name: {name}");
            Console.WriteLine($"Unit Consumed: {units}");
            Console.WriteLine($"Amount Charges @Rs. {amount / units:F2} per unit: {amount:F2}");
            Console.WriteLine($"Surcharge Amount: {surcharge:F2}");
            Console.WriteLine($"Net Amount Paid By the Customer: {totalAmount:F2}");

            // ما حبيته تعبني, اقيمه 5/10 
        }

        /* 19. Write a program in C# Sharp to accept a grade and declare the equivalent
            description :
            E Excellent
            V Very Good
            G Good
            A Average
            F Fail */

        static void Task_43()
        {
            Console.Write("Test Data : \nInput the grade: ");
            char grade = char.ToUpper(Console.ReadKey().KeyChar); // Read a character from the user and convert it to uppercase
            Console.WriteLine(); // Print a new line to look prettier :)

            switch (grade) // Use a switch statement to determine the description based on the grade
            {
                case 'E':
                    Console.WriteLine("You have chosen: Excellent");
                    break;
                case 'V':
                    Console.WriteLine("You have chosen: Very Good");
                    break;
                case 'G':
                    Console.WriteLine("You have chosen: Good");
                    break;
                case 'A':
                    Console.WriteLine("You have chosen: Average");
                    break;
                case 'F':
                    Console.WriteLine("You have chosen: Fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade!\n" +
                        "Choose on of the following: E, V, G, A, F"); // If the grade is not among our list print invalid!
                    break;
            }
            // اي هسة هذا حلو 8/10
        }

        // 20. Write a C# Sharp program to read any day number as an integer and display the name of the day as a word.
        static void Task_44()
        {
            Console.Write("Test Data : \nchoose a day number of the week: ");
            int dayNumber = int.Parse(Console.ReadLine()); // Read the day number from the user
            
            switch (dayNumber) // Use a switch statement to determine the name of the day
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Huh?! Bro, the week is only 7 days!"); // If the day number is not valid, print an error message
                    break;
            }
        }

        // 21. Write a program in C# Sharp to read any digit, display in the word.
        static void Task_45()
        {
            Console.Write("Test Data : \n");
            int digit = int.Parse(Console.ReadLine()); // Read the digit from the user
            
            switch (digit) // switch statement to determine the word for the digit
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Sorry, I can't read that yet! \nenter a single digit (0-9) pls :)"); // If the input is not a valid digit, print an error message
                    break;
            }
        }

        //22. Write C# Sharp program to read any Month Number in integer and display Month name
        static void Task_46()
        {
            Console.Write("Test Data : \nInput a month number (1-12): ");
            int month = int.Parse(Console.ReadLine()); // Read the month number from the user
            switch(month) // Use a switch statement to determine the name of the month
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("This month is not invented yet! Choose one of the 12 humans' months!"); // If the month number is not valid, print this
                    break;
            }
        }

        /*23. Write a program in C# Sharp to read any Month Number in integer and
            display the number of days for this month.
            Test Data :
            7
            Expected Output:
            Month have 31 days*/
        static void Task_47()
        {
            Console.Write("Test Data : \nInput a month number (1-12): ");
            int month = int.Parse(Console.ReadLine()); // Read the month number from the user
            int days;
            switch (month) // Use a switch statement to determine the number of days in the month
            {
                case 1: // January
                case 3: // March
                case 5: // May
                case 7: // July
                case 8: // August
                case 10: // October
                case 12: // December
                    days = 31; // These months have 31 days
                    break;
                case 4: // April
                case 6: // June
                case 9: // September
                case 11: // November
                    days = 30; // These months have 30 days
                    break;
                case 2: // February
                    days = 28; // February has 28 days, ignoring leap years
                    break;
                default:
                    Console.WriteLine("This month is not invented yet! Choose one of the 12 humans' months!"); 
                    return; // Exit if the month number is invalid
            }
            Console.WriteLine($"Month {month} has {days} days."); // Print the number of days in the month
        }

        /*24. Write a C# Sharp program that calculates the area of geometrical shapes
            using a menu-driven approach.
            Choose a shape to calculate its area:
            1. Rectangle
            2. Square
            3. Triangle
            4. Circle
            5. Trapezoid //متوازي الاضلاع*/
        static void Task_48()
        {
            Console.WriteLine("Choose a shape to calculate its area:");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("4. Circle");
            Console.WriteLine("5. Trapezoid");
            Console.Write("Input your choice: ");
            int choice = int.Parse(Console.ReadLine()); // Read the user's choice
            
            double area = 0; // Initialize area variable
            switch (choice) // Use a switch statement to determine the shape and calculate the area
            {
                case 1: // Rectangle
                    Console.Write("Input length: ");
                    double length = double.Parse(Console.ReadLine());
                    Console.Write("Input width: ");
                    double width = double.Parse(Console.ReadLine());
                    area = length * width; // Area of rectangle = length * width
                    Console.WriteLine($"The area of the rectangle is: {area}"); // Print the area of the rectangle
                    break;
                case 2: // Square
                    Console.Write("Input the side length: ");
                    double side = double.Parse(Console.ReadLine());
                    area = side * side; // Area of square = side^2
                    Console.WriteLine($"The area of the square is: {area}"); // Print the area of the square
                    break;
                case 3: // Triangle
                    Console.Write("Input the base: ");
                    double baseLength = double.Parse(Console.ReadLine());
                    Console.Write("Input the height: ");
                    double height = double.Parse(Console.ReadLine());
                    area = 0.5 * baseLength * height; // Area of triangle = 0.5 * base * height
                    Console.WriteLine($"The area of the triangle is: {area}"); // Print the area of the triangle
                    break;
                case 4: // Circle
                    Console.Write("Input radius of the circle : ");
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI * radius * radius; // Area of circle = π * radius^2
                    Console.WriteLine($"The area is: {area:F6}"); // Print the area of the circle
                    break;
                case 5: // Trapezoid
                    Console.Write("Input length of the first side: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Input length of the second side: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Input height: ");
                    double h = double.Parse(Console.ReadLine());
                    area = ((a + b) / 2) * h; // Area of trapezoid = ((a + b) / 2) * height
                    Console.WriteLine($"The area of the trapezoid is: {area}"); // Print the area of the trapezoid
                    break;
                default:
                    Console.WriteLine("Sorry man, I'm not smart enough for that :)\nChoose between 1-5");
                    return; // Exit if the choice is invalid
            }
        }

        //1. Write a program in C# Sharp to input a string and print it
        static void Task_49()
        {
            Console.Write("nput the string : ");
            string input = Console.ReadLine(); // Read a string from the user
            Console.WriteLine($"The string you entered is : {input}"); // Print the entered string
        }

        //2. Write a C# Sharp program to find the length of a string without using a library function
        static void Task_50()
        {
            Console.Write("Input the string : ");
            string input = Console.ReadLine(); // Read a string from the user
            int length = 0; // Initialize length variable
            
            foreach (char c in input) // Iterate through each character in the string
            {
                length++; // Increment length for each character
            }
            
            Console.WriteLine($"The length of the string is : {length}"); // Print the length of the string
        }

        //3. Write a C# Sharp program to separate individual characters from a string.
        static void Task_51()
        {
            Console.Write("Input the string : ");
            string str = Console.ReadLine(); // Read a string from the user
            
            Console.WriteLine("The characters are:");
            foreach (char ch in str) // Iterate through each character in the string
            {
                Console.WriteLine(ch); // Print each character on a new line
            }
        }

        // 4. Write a program in C# Sharp to print individual characters of the string in reverse order
        static void Task_52()
        {
            Console.Write("Input the string : ");
            string str = Console.ReadLine(); // Read a string from the user
            
            Console.WriteLine("The characters in reverse are:");
            for (int i = str.Length - 1; i >= 0; i--) // Iterate through each character in reverse order
            {
                Console.WriteLine(str[i]); // Print each character on a new line
            }
        }

        //5. Write a program in C# Sharp to count the total number of words in a string.
        static void Task_53()
        {
            Console.Write("Input the string : ");
            string str = Console.ReadLine();

            // Split by whitespace, remove empty entries
            string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries); // ignore and remove any empty strings from the result array.
            // Split the string into words using whitespace as a delimiter 
            int count_words = words.Length;

            Console.WriteLine($"The total number of words in the string is : {count_words}");
        }

        //6. Write a program in C# Sharp to compare two strings without using a string library functions.
        static void Task_54()
        {
            Console.Write("Input the first string: ");
            string str1 = Console.ReadLine(); // Read the first string from the user
            Console.Write("Input the second string: ");
            string str2 = Console.ReadLine(); // Read the second string from the user
            
            if (str1 == str2) // Compare the two strings
                Console.WriteLine("The length of both strings are equal and\nalso, both strings are equal.");
            else
                Console.WriteLine("The two strings are not equal.");
        }

        //7. Write a program in C# Sharp to count the number of alphabets, digits and special characters in a string
        static void Task_55()
        {
            Console.Write("Input the string: ");
            string str = Console.ReadLine(); // Read a string from the user
            
            int alphabets = 0, digits = 0, specials = 0; // Initialize counters
            
            foreach (char c in str) // Iterate through each character in the string
            {
                if (char.IsLetter(c)) // Check if the character is an alphabet
                    alphabets++;
                else if (char.IsDigit(c)) // Check if the character is a digit
                    digits++;
                else if (!char.IsWhiteSpace(c)) // Check if the character is not a whitespace
                    specials++; // Count it as a special character
            }
            
            Console.WriteLine($"Number of Alphabets in the string is : {alphabets}\n" +
                $"Number of Digits in the string is : {digits}\n" +
                $"Number of Special characters in the string is : {specials}");
        }

        //8. Write a program in C# Sharp to copy one string to another string
        static void Task_56()
        {
            Console.Write("Input the first string: ");
            string str1 = Console.ReadLine(); // Read the first string from the user
            string str2 = str1; // Copy the first string to the second string
            int n = str1.Length; // Get the length of the first string
            Console.WriteLine($"The First string is : {str1}"+
                $"\nThe Second string is : {str2}"+
                $"\nNumber of characters copied : {n}"); // Print the copied string
        }

        // 9. Write a C# Sharp program to count the number of vowels or consonants in a string.   
        static void Task_57()
        {
            Console.Write("Input the string :");
            string str = Console.ReadLine();
            str = str.ToLower();
            int vowels = 0;
            int consonants = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if ("aeiou".Contains(str[i]))
                    vowels++;
                else if (char.IsLetter(str[i]))
                    consonants++;
            }
            Console.WriteLine($"\nThe total number of vowel in the string is : {vowels}");
            Console.WriteLine($"\nThe total number of consonant in the string is : {consonants}");

        }

        // 10. Write a C# Sharp program to find the maximum number of characters in a string
        static void Task_58()
        {
            Console.Write("Input your string: ");
            string str = Console.ReadLine().ToLower();

            int maxCount = 0;           // This will keep track of the highest number of times any character appears
            char mostFrequentChar = ' '; // This will store the character that appears the most

            // Go through each character in the string
            for (int i = 0; i < str.Length; i++)
            {
                int count = 0; // This will count how many times the current character appears

                // Compare the current character to every character in the string
                for (int j = 0; j < str.Length; j++)
                    // If the characters match, increase the count
                    if (str[i] == str[j])
                        count++;

                /* If this character appears more times than any previous character,
                    update maxCount and mostFrequentChar */
                if (count > maxCount)
                {
                    maxCount = count;
                    mostFrequentChar = str[i];
                }
            }

            // Show the results here:
            Console.WriteLine($"The Highest frequency of character '{mostFrequentChar}'");
            Console.WriteLine($"appears number of times : {maxCount}");
        }

        // 11. Write a C# Sharp program to sort a string array in ascending order.
        static void Task_59()
        {
            Console.Write("Input the string : ");
            string str = Console.ReadLine(); // Read a string from the user
            char[] characters = str.ToCharArray(); // Convert the string to a character array
            
            Array.Sort(characters); // Sort the character array in ascending order
            /* orrrrr:
            for (int i = 0; i < str.Length; i++) // Iterate through the string
                for (int j = i + 1; j < str.Length; j++) // Compare each character with the next ones
                    if (str[i] > str[j]) // If the current character is greater than the next one
                    {
                        char temp = str[i]; // Swap them
                        str[i] = str[j];
                        str[j] = temp;
                    } */
            Console.WriteLine("After sorting the string appears like :");
            foreach (char c in characters) // Iterate through each character in the sorted array
                Console.Write(c + " "); // Print each character followed by a space
        }

        // 12. Write a C# Sharp program to read a string through the keyboard and sort it using bubble sort.
            
        static void Task_60()
        {
            Console.Write("Test Data : \nInput number of strings : ");
            int n = int.Parse(Console.ReadLine()); // Read the number of strings from the user
            Console.WriteLine("Input " + n + " strings below :");
            string[] strings = new string[n]; // Create an array to hold the strings
            for (int i = 0; i < n; i++) // Read each string from the user
            {
                strings[i] = Console.ReadLine();
            }
            // Bubble sort algorithm to sort the strings
            for (int i = 0; i < n - 1; i++) // Outer loop for the number of passes
            {
                for (int j = 0; j < n - i - 1; j++) // Inner loop for comparing adjacent strings (starts with n - i - 1 which means ex: n=3, i=0, j=0 then compare 1, 2)
                {
                    if (string.Compare(strings[j], strings[j + 1]) > 0) //strings[j] means the first string, strings[j + 1] means the second string
                    // Compare the two strings if the first string is greater than the second string then swap them
                    // 0 means equal, < 0 means first is less than second, > 0 means first is greater than second
                    {
                        // Swap
                        string temp = strings[j];
                        strings[j] = strings[j + 1];
                        strings[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("After sorting the array appears like :");
            foreach (string str in strings) // Iterate through each string in the sorted array
            {
                Console.WriteLine(str); // Print each string on a new line
            }
        }
        // 13. Write a program in C# Sharp to extract a substring from a given string without using the library function.
        static void Task_61()
        {
            Console.Write("Test Data: \nInput the string : ");
            string str = Console.ReadLine(); // Read a string from the user
            Console.Write("Input the position to start extraction :");
            int start = int.Parse(Console.ReadLine()); // Read the starting position for extraction
            Console.Write("Input the length of substring :");
            int length = int.Parse(Console.ReadLine()); // Read the length of the substring
            string str2 = ""; // Initialize an empty string to hold the extracted substring
            for (int i = start; i < start + length; i++) // Iterate from the starting position to the specified length or until the end of the string
            {
                if (i >= str.Length) // Check if the index is out of bounds
                {
                    Console.WriteLine("Out of bounds buddy, check your inputs..");
                    return; // Exit if the index is out of bounds
                }
               str2 += str[i]; // Append the character at the current index to the substring
            }
            Console.WriteLine($"The substring retrieve from the string is : {str2}"); // Print the extracted substring
        }

        // 14. Write a C# Sharp program to check whether a given substring is present in the given string.
        static void Task_62()
        {
            Console.Write("Test Data : \nInput the string : ");
            string str = Console.ReadLine(); // Read a string from the user
            Console.Write("Input the substring to search : ");
            string subStr = Console.ReadLine(); // Read the substring to search for
            
            if (str.Contains(subStr)) // Check if the main string contains the substring
                Console.WriteLine("The substring exists in the string"); // If it does, print this message
            else
                Console.WriteLine("The substring doesn't exist in the string!!"); // If it doesn't, print this message
        }
        // 15. Write a C# Sharp program to read a sentence and replace lowercase characters with uppercase and vice-versa.
        static void Task_63()
        {
            Console.Write("Test Data : \nInput the string : ");
            string str = Console.ReadLine(); // Read a string
            string result = ""; // empty string to hold the result
            
            foreach (char c in str) // شوف الحروف وحدة وحدة
            {
                if (char.IsLower(c)) // اذا الحرف صغير
                    result += char.ToUpper(c); // كبره و ضيفه للنتيجة
                else if (char.IsUpper(c)) // اذا كبير 
                    result += char.ToLower(c); // صغره و ضيفه للنتيجة
                else
                    result += c; // اذا لا هاي و لا هاي مثلا رقم رمز سبيس ف ضيفه مثل ما هو
            }
            
            Console.WriteLine($"The modified string is : {result}"); // و اطبعلي النتيجة و بس والله
        }
        // 16. Write a program in C# Sharp to check the username and password
        /*Test Data :
            Input a username: uesr
            Input a password: pass
            Input a username: abcd
            Input a password: 1234
            Expected Output :
            Password entered successfully!*/
        static void Task_64()
        {
            Console.Write("Input a username: ");
            string username = Console.ReadLine(); // Read username
            Console.Write("Input a password: ");
            string password = Console.ReadLine(); // Read password
            Console.Write("Input a username: ");
            string username2 = Console.ReadLine();
            Console.Write("Input a password: ");
            string password2 = Console.ReadLine();

            if (username == "uesr" && password == "pass" && username2 == "abcd" && password2 == "1234") // if the username and password match the expected values
                Console.WriteLine("Password entered successfully!"); // print this message
            else
                Console.WriteLine("Invalid username or password!"); // if not, print this
        }

        // 17. Write a program in C# Sharp to search for the position of a substring within a string.
        static void Task_65()
        {
            Console.Write("Test Data :\nInput a String: ");
            string str = Console.ReadLine(); // Read the main string
            Console.Write("Input a substring to be found in the string: ");
            string subStr = Console.ReadLine(); // Read the substring
            
            int position = str.IndexOf(subStr); // Find the position of the substring in the main string
            
            if (position == -1) // If the substring is not found
                Console.WriteLine($"'{subStr}' is not in '{str}'!!"); // If not found, print this message
            Console.WriteLine($"Found '{subStr}' in '{str}' at position {position}"); // Print the position
        }

        /*8. Write a C# Sharp program to check whether a character is an alphabet
            and not and if so, check for the case.
            Test Data :
            Input a character: Z
            Expected Output :
            The character is uppercase.*/
        static void Task_66()
        {
            Console.Write("Test Data : \nInput a character: ");
            char ch = Console.ReadKey().KeyChar; // Read a character
            if(!char.IsLetter(ch)) // Check if the character is an alphabet
            {
                Console.WriteLine("\nThe character is not an alphabet!"); // If not, print this
                return; // Terminate!
            }
            // If it is an alphabet, check for the case
            if (char.IsUpper(ch)) // If the character is uppercase
                Console.WriteLine("\nThe character is uppercase.");
            else if (char.IsLower(ch)) // If the character is lowercase
                Console.WriteLine("\nThe character is lowercase.");
        }

        // 9. Write a program in C# Sharp to find the number of times a substring appears in a given string.
        static void Task_67()
        {
            Console.Write("Test Data : \nInput the original string: ");
            string str = Console.ReadLine(); // Read the original string
            Console.Write("Input the string to be searched for: ");
            string subStr = Console.ReadLine(); // Read the substring to search for
            
            int count = 0; // Initialize a counter for occurrences
            int index = str.IndexOf(subStr); // Find the first occurrence of the substring
            
            for (; index != -1; index = str.IndexOf(subStr, index + 1)) // if the substring is found, continue searching for the next occurrence
            {
                // The loop continues until no more occurrences are found (index becomes -1)
                // index = str.IndexOf(subStr, index + 1) means we start searching from the next character after the last found occurrence
                // index + 1 ensures we don't count the same occurrence again( IndexOf(value, startIndex) searches for the value starting from the specified index)

                count++; // Increment the counter for each occurrence found
            }
            Console.WriteLine($"The string '{subStr}' occurs {count} times"); // Print the result
        }

        // 20. Write a program in C# Sharp to insert a substring before the first occurrence of a string.
        static void Task_68()
        {
            Console.Write("Test Data : \nInput the original string: ");
            string str = Console.ReadLine(); // Read the original string
            Console.Write("Input the string to be searched for: ");
            string subStr = Console.ReadLine(); // Read the substring to search for
            Console.Write("Input the string to be inserted: ");
            string insert_str = Console.ReadLine(); // Read the string to be inserted
            
            int index = str.IndexOf(subStr); // Find the first occurrence of the substring
            
            if (index == -1) // -1 means the substring is not there :/
            {
                Console.WriteLine($"'{subStr}' is not found in {str}!!!");
                return; // Terminate the program if the substring is not found
            }
            
            // Insert the new string before the first occurrence of the substring
            string modifiedStr = str.Insert(index, insert_str );
            // Insert(start index, string value) means we insert the insert_str at the index of the first occurrence of subStr
            // اذاكانت subStr موجودة في ال str راح نضيف insert_str قبلها
            Console.WriteLine($"The modified string is: {modifiedStr}"); // Print the modified string
        }

        /*21. Write a C# Sharp program to compare (less than, greater than, equal to)
            two substrings.
            Expected Output :
            str1 = 'computer', str2 = 'system'
            Substring 'mp' in 'computer' is less than substring 'sy' in 'system'.*/
        static void Task_69()
        {
            Console.Write("Test Data : \nInput the first string: ");
            string str1 = Console.ReadLine(); // Read the first string
            Console.Write("Input the second string: ");
            string str2 = Console.ReadLine(); // Read the second string
            
            Console.Write("Input the first substring to compare: ");
            string subStr1 = Console.ReadLine(); // Read the first substring
            Console.Write("Input the second substring to compare: ");
            string subStr2 = Console.ReadLine(); // Read the second substring
            
            int compare = string.Compare(subStr1, subStr2); // Compare the two substrings

            Console.WriteLine($"str1 = '{str1}', str2 = '{str2}'");

            if (compare < 0) // If subStr1 is less than subStr2
                Console.WriteLine($"Substring '{subStr1}' in '{str1}' is less than substring '{subStr2}' in '{str2}'.");
            else if (compare > 0) // If subStr1 is greater than subStr2
                Console.WriteLine($"Substring '{subStr1}' in '{str1}' is greater than substring '{subStr2}' in '{str2}'.");
            else // If they are equal
                Console.WriteLine($"Substring '{subStr1}' in '{str1}' is equal to substring '{subStr2}' in '{str2}'.");
        }

        /*22. Write a C# Sharp program to compare two substrings that only differ in
            case. The first comparison ignores case and the second comparison
            considers case. */
        static void Task_70()
        {
            Console.Write("Input the first string: ");
            string str1 = Console.ReadLine();
            Console.Write("Input the second string: ");
            string str2 = Console.ReadLine();
            Console.Write("Input the first substring to compare: ");
            string subStr1 = Console.ReadLine();
            Console.Write("Input the second substring to compare: ");
            string subStr2 = Console.ReadLine();

            Console.WriteLine($"str1 = '{str1}', str2 = '{str2}'");

            // Ignore case comparison:
            int ignoreCaseCompare = string.Compare(subStr1.ToLower(), subStr2.ToLower());
            if (ignoreCaseCompare > 0)
                Console.WriteLine("Ignore case: \n" +
                    $"Substring '{subStr1}' in '{str1}' is greater than substring '{subStr2}' in '{str2}'.");
            else if (ignoreCaseCompare < 0)
                Console.WriteLine("Ignore case: \n" +
                    $"Substring '{subStr1}' in '{str1}' is less than substring '{subStr2}' in '{str2}'.");
            else
                Console.WriteLine("Ignore case: \n" +
                    $"Substring '{subStr1}' in '{str1}' is equal to substring '{subStr2}' in '{str2}'.");

            // Honor case comparison:
            int honorCaseCompare = string.Compare(subStr1, subStr2);
            if (honorCaseCompare > 0)
                Console.WriteLine("Honor case: \n" +
                    $"Substring '{subStr1}' in '{str1}' is greater than substring '{subStr2}' in '{str2}'.");
            else if (honorCaseCompare < 0)
                Console.WriteLine("Honor case: \n" +
                    $"Substring '{subStr1}' in '{str1}' is less than substring '{subStr2}' in '{str2}'.");
            else
                Console.WriteLine("Honor case: \n" +
                    $"Substring '{subStr1}' in '{str1}' is equal to substring '{subStr2}' in '{str2}'.");
        }

        // 23, 24, 25 are left for later :)

        /*. Write a program in C# Sharp to display the first 10 natural numbers.
            Expected Output :
            1 2 3 4 5 6 7 8 9 10*/
        static void Task_74()
        {
            for(int i = 1; i <= 10; i++) // Loop from 1 to 10
            {
                Console.Write(i + " "); // Print each number followed by a space
            }
        }

        /*2. Write a C# Sharp program to find the sum of the first 10 natural numbers.*/
        static void Task_75()
        {
            int sum = 0;
            Console.Write("The first 10 natural numbers are: ");
            for (int i = 1; i <= 10; i++) // Loop from 1 to 10
            {
                Console.Write(i + " "); // Print numbers with a space
                sum += i; // Add numbers to the sum
            }
            Console.WriteLine($"\nThe Sum is: {sum}"); // Print the total sum
        }

        /*3. Write a C# Sharp program that displays the sum of n natural numbers.*/
        static void Task_76()
        {
            Console.Write("Test Data : ");
            int n = int.Parse(Console.ReadLine()); // Read the number of natural numbers to sum
            int sum = 0; // Initialize sum variable
            
            Console.Write($"The first {n} natural numbers are: ");
            for (int i = 1; i <= n; i++) // Loop from 1 to n
            {
                Console.Write(i + " "); // Print each natural number followed by a space
                sum += i; // Add each number to the sum
            }
            Console.WriteLine($"\nThe Sum of Natural Number up to {n} terms: {sum}"); // Print the total sum
        }

        /*4. Write a C# Sharp program to read 10 numbers and find their average and sum.*/
        static void Task_77()
        {
            int sum = 0;
            Console.WriteLine("Input the 10 numbers :");
            for (int i = 1; i <= 10; i++) // Loop to read 10 numbers
            {
                Console.Write($"Number-{i} : ");
                int num = int.Parse(Console.ReadLine()); // Read each number from the user
                sum += num; // Add the number to the sum
            }
            double average = sum / 10.0; // Calculate the average by dividing the sum by 10.0 to ensure a double result
            Console.WriteLine($"The sum of 10 no is : {sum}"); // Print the sum
            Console.WriteLine($"The Average is : {average:F6}"); // Print the average with 6 decimal places
        }

        /*5. Write a C# Sharp program to display the cube of an integer up to given number.*/
        static void Task_78()
        {
            Console.Write("Input number of terms : ");
            int n = int.Parse(Console.ReadLine()); // Read the number of terms from the user
            
            for (int i = 1; i <= n; i++) // Loop from 1 to n
            {
                int cube = i * i * i; // Calculate the cube of the current number
                Console.WriteLine($"Number is : {i} and cube of the {i} is : {cube}"); // Print the number and its cube
            }
        }
        /*6. Write a program in C# Sharp to display the multiplication table of a given integer.*/
        static void Task_79()
        {
            Console.Write("Input the number (Table to be calculated) : ");
            int n = int.Parse(Console.ReadLine()); // Read the number to be multiplied

            for (int i = 1; i <= 10; i++) // Loop from 1 to 10
            {
                Console.WriteLine($"{n} X {i} = {n * i}"); // Print the multiplication table
            }
        }

        //Task 80 and 81 (Q7 and Q8) are left FOR LATER...
        
        // 9. Write a program in C# Sharp to display a right angle triangle with an asterisk.
        static void Task_80()
        {
            Console.Write("how many rows? ");
            int rows = int.Parse(Console.ReadLine()); // Read the number of rows for the triangle
            for (int i = 0; i < rows; i++) // Loop through each row
            {
                for(int j = 0; j <= i; j++) // Loop through each column in the current row
                {
                    Console.Write("*"); // Print an asterisk for each row
                }
                Console.WriteLine(); // Move to the next line after printing asterisks for the current row
            }
        }

        // 10. Write a program in C# Sharp to display a pattern like a right angle triangle with a number.
        /*
         1
         12
         123
         1234
         */
        static void Task_81()
        {
            Console.Write("how many rows? ");
            int rows = int.Parse(Console.ReadLine()); // Read the number of rows for the triangle
            for (int i = 1; i <= rows; i++) // Loop through each row
            {
                for (int j = 1; j <= i; j++) // Loop through each column in the current row
                {
                    Console.Write(j); // Print the current number
                }
                Console.WriteLine(); // Move to the next line after printing numbers for the current row
            }
        }

        /*11. Write a program in C# Sharp to make such a pattern like a right angle
        triangle with a number which repeats a number in a row. 
        1
        22
        333
        4444
         */
        static void Task_82()
        {
            Console.Write("how many rows? ");
            int rows = int.Parse(Console.ReadLine()); // Read the number of rows for the triangle
            for (int i = 1; i <= rows; i++) // Loop through each row
            {
                for (int j = 1; j <= i; j++) // Loop through each column in the current row
                {
                    Console.Write(i); // Print the current row number
                }
                Console.WriteLine(); // Move to the next line after printing numbers for the current row
            }
        }

        //15. Write a C# Sharp program to calculate the factorial of a given number.
        static int Task_83(int n)
        {
            if(n <=1 )
                return 1; 
            return n * Task_83(n - 1); //recursion

        }
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Test Data: \nInput the number : ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(Task_83(n));
                Console.WriteLine();
            }
        }
    }
}
