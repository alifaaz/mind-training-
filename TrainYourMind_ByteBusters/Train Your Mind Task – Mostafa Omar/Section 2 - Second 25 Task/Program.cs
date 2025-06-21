using System;

namespace Section_2___Second_25_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_1();
            Task_2();
            Task_3();
            Task_4();
            Task_5();
            Task_6();
            Task_7();
            Task_8();
            Task_9();
            Task_10();
            Task_11();
            Task_12();
            Task_13();
            Task_14();
            Task_15();
            Task_16();
            Task_17();
            Task_19();
            Task_20();
            Task_21();
            Task_22();
            Task_23();
            Task_24();
        }
        // Section 2 - Task 1
        /* Write a C# Sharp program to accept two integers and check whether they
         * are equal or not.*/
        static void Task_1()
        {
            Console.Write("Enter Number One: ");  // SHOW MESSAGE TO THE USER
            int Num1 = Convert.ToInt32(Console.ReadLine()); // READ NUM 1 FROM THE USER

            Console.Write("Enter Number Two: ");  // SHOW MESSAGE TO THE USER
            int Num2 = Convert.ToInt32(Console.ReadLine()); // READ NUM 2 FROM THE USER

            if (Num1 == Num2) // IF NUM 1 == NUM 2  (RETURN 'TRUE')
            {
                Console.WriteLine(Num1 + " and " + Num2 + " Are Equal"); //  PRINT THIS
            }
            else  // ELSE ('FALSE')
            {
                Console.WriteLine(Num1 + " and " + Num2 + " Are NOT Equal");  // PRINT THIS
            }
        }
        // Section 2 - Task 2
        // Write a C# Sharp program to check whether a given number is even or odd.
        static void Task_2()
        {
            Console.WriteLine("Enter Number to check whether a given number is even or odd");  // SHOW MESSAGE TO THE USER
            int num = Convert.ToInt32(Console.ReadLine()); // READ NUM FROM THE USER

            if (num % 2 == 0) /// IF NUMBER / 2 = 0 AND THERE IS NUMBER IS EVEN
            {
                Console.WriteLine(num + " is Even integer");
            }
            else // ELSE ITS ODD
            {
                Console.WriteLine(num + " is An Odd integer");
            }
        }
        // Section 2 - Task 3
        // Write a C# Sharp program to check whether a given number is positive or negative.
        static void Task_3()
        {
            Console.WriteLine("Enter Number to check whether a given number is even or odd");  // SHOW MESSAGE TO THE USER
            int num = Convert.ToInt32(Console.ReadLine()); // READ NUM FROM THE USER
            if (num < 0)
            {
                Console.WriteLine(num + " is a negative number"); // LESS SO NEGATIVE
            }
            else
            {
                Console.WriteLine(num + " is a positive number"); // MORE THEN POSITIVE
            }
        }
        // Section 2 - Task 4
        // Write a C# Sharp program to find out whether a given year is a leap year or not.
        static void Task_4()
        {
            Console.WriteLine("Enter Year");  // SHOW MESSAGE TO THE USER
            int year = Convert.ToInt32(Console.ReadLine()); // READ YEAR FROM THE USER

            if (year % 4 == 0) // if true, it might be a leap year
            {
                if (year % 100 == 0) // if true, it might be a leap year
                {
                    if (year % 400 == 0) // if true, its leap year
                    {
                        Console.WriteLine(year + " is a leap year");
                    }
                    else // false so itsnot
                    {
                        Console.WriteLine(year + " is NOT a leap year");
                    }
                }
                else // false so itsnot
                {
                    Console.WriteLine(year + " is NOT a leap year");
                }
            }
            else // false so itsnot
            {
                Console.WriteLine(year + " is NOT a leap year");
            }
        }
        // Section 2 - Task 5
        /* Write a C# Sharp program to read the age of a candidate and determine
           whether it is eligible for casting his/her own vote.*/
        static void Task_5()
        {
            Console.WriteLine("Test Data : ");  // SHOW MESSAGE TO THE USER TO ENTER AGE
            int age = Convert.ToInt32(Console.ReadLine()); // VARIABLE FOR AGE
            if (age >= 18)
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            else
                Console.WriteLine("SORRY!, You are NOT eligible for casting your vote.");
        }
        // Section 2 - Task 6
        /* Write a C# Sharp program to read the value of an integer m and display the
         * value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less
           than 0. */
        static void Task_6()
        {
            Console.Write("m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int n;

            if (m > 0)
            {
                n = 1;
            }
            else if (m == 0)
            {
                n = 0;
            }
            else
            {
                n = -1;
            }
            Console.WriteLine("The value of n : " + n);
        }
        // Section 2 - Task 7
        /* Write a C# Sharp program to accept a person's height in centimeters and
           categorize them according to their height.*/
        static void Task_7()
        {
            Console.WriteLine("Enter the height in centimeters: ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (height <= 150)
            {
                Console.WriteLine("قصير");
            }
            else if (height <= 177)
            {
                Console.WriteLine("متوسط");
            }
            else
            {
                Console.WriteLine("طويل");
            }
        }
        // Section 2 - Task 8
        // Write a C# Sharp program to find the largest of three numbers.
        static void Task_8()
        {
            Console.Write("Enter Number One: ");
            int NumberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number Two: ");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number Three: ");
            int NumberThree = Convert.ToInt32(Console.ReadLine());

            if (NumberOne >= NumberTwo && NumberTwo >= NumberThree) // if number 1 bigger or equal to number 2 AND Number 2 bigger or equal to number 3
            {
                Console.WriteLine(NumberOne);  // print NumberOne
            }
            else if (NumberTwo >= NumberOne && NumberTwo >= NumberThree) // else if number 2 bigger or equal to number 1 AND Number 2 smaller or equal to number 3
            {
                Console.WriteLine(NumberTwo); // print NumberTwo
            }
            else
            {
                Console.WriteLine(NumberThree); // Number Three
            }
        }
        // Section 2 - Task 9
        // Write a C# Sharp program to accept a coordinate point in an XY coordinate
        // system and determine in which quadrant the coordinate point lies.
        static void Task_9()
        {
            Console.Write("Enter x cordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y cordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());
            if ((x > 0 && y > 0))  // + , +
            {
                Console.WriteLine("First quadrant");
            }
            else if (x < 0 && y > 0) // - , +
            {
                Console.WriteLine("Second quadrant");
            }
            else if (x < 0 && y < 0) // - , -
            {
                Console.WriteLine("third quadrant");
            }
            else if (x > 0 && y < 0) // + , -
            {
                Console.WriteLine("fourth quadrant");
            }
            else if (x == 0 && y == 0) // 0 , 0
            {
                Console.WriteLine("on orgin");
            }
            else if (x == 0) // 0 , num
                Console.WriteLine("a coordinate point in an Y axis");
            else if (y == 0) // num , 0
                Console.WriteLine("a coordinate point in an X axis");
        }
        // Section 2 - Task 10
        /* Write a C# Sharp program to calculate the root of a quadratic equation.
          Test Data */
        static void Task_10()
        {
            int phy, chem, math, total; // DECLARING THE NEEDED VARIABLE

      
            Console.Write("Input the marks obtained in Physics: ");
            phy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry: ");
            chem = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Mathematics: ");
            math = Convert.ToInt32(Console.ReadLine());
            
            total = phy + chem + math;      // COLLECT THE TOTAL

            if ((math >= 65 && phy >= 55 && // CHECK IF HE IS QUALIFAID OR NOT
                chem >= 50 && total >= 180) ||
                (math >= 65 && total >= 140))
            {
                Console.WriteLine("The candidate is eligible for admission."); 
            }
            else
            {
                Console.WriteLine("The candidate is NOTT eligible for admission.");
            }
        }
        // Section 2 - Task 11
        /* Write a C# Sharp program to calculate the root of a quadratic equation.
          Test Data */
        static void Task_11()
        {
            Console.Write("Enter Number One a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Number Two b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Number Three c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double d = (b * b) - (4 * a * c);  // Discriminant CALCULATION
            double x1, x2;

            if (d == 0)
            {
                Console.WriteLine("Both Roots Are Equal");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.WriteLine("The First Root = ", x1);
                Console.WriteLine("The Second Root = ", x2);
            }
            else if (d > 0)
            {
                Console.WriteLine("Both Roots are Real and Different");
                x1 = (-b + Math.Sqrt(d)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(d)) / (2.0 * a);
                Console.WriteLine("First Root = ", x1);
                Console.WriteLine("Second Root = ", x2);
            }
            else
            {
                Console.WriteLine("Ummm.., Root are imaginary");
            }
            Console.ReadLine();
        }
        // Section 2 - Task 12
        /*Write a C# Sharp program to read roll no, name and marks of three
        subjects and calculate the total, percentage and division.*/
        static void Task_12()
        {
            Console.Write("Input the Roll Number of the student: ");
            int roll = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Name of the Student: ");
            string name = Console.ReadLine();

            Console.WriteLine("Input the marks of Physics, Chemistry and Computer Application: ");
            int phy = Convert.ToInt32(Console.ReadLine());
            int chem = Convert.ToInt32(Console.ReadLine());
            int comp = Convert.ToInt32(Console.ReadLine());

            int total = phy + chem + comp;
            double percentage = total / 3.0;
            string division;

            if (percentage >= 60)
                division = "First";
            else if (percentage >= 50)
                division = "Second";
            else if (percentage >= 40)
                division = "Third";
            else
                division = "Fail";

            Console.WriteLine("\n Roll No : " + roll);
            Console.WriteLine("Name of Student : " + name);
            Console.WriteLine("Marks in Physics : " + phy);
            Console.WriteLine("Marks in Chemistry : " + chem);
            Console.WriteLine("Marks in Computer Application : " + comp);
            Console.WriteLine("Total Marks = " + total);
            Console.WriteLine("Percentage = " + percentage.ToString("F3")); // F3 show .000 after the number
            Console.WriteLine("Division = " + division);
        }
        // Section 2 - Task 13
        /*
        * Write a C# Sharp program to read temperature in centigrade and display a
        *suitable message according to the temperature state below:
        *Temp < 0 then Freezing weather
        *Temp 0-10 then Very Cold weather
        *Temp 10-20 then Cold weather
        *Temp 20-30 then Normal in Temp
        *Temp 30-40 then Its Hot
         Temp >=40 then Its Very Hot */
          static void Task_13()
          {
              Console.Write("Enter temperature in centigrade: ");
              int temp = Convert.ToInt32(Console.ReadLine());
          
              if (temp < 0)
                  Console.WriteLine("Freezing weather");
              else if (temp <= 10)
                  Console.WriteLine("Very Cold weather");
              else if (temp <= 20)
                  Console.WriteLine("Cold weather");
              else if (temp <= 30)
                  Console.WriteLine("Normal in Temp");
              else if (temp <= 40)
                  Console.WriteLine("Its Hot");
              else
                  Console.WriteLine("Its Very Hot");
          }
          // Section 2 - Task 14
          /* Write a C# Sharp program to check whether a triangle is Equilateral,
             Isosceles or Scalene. */
             static void Task_14()
          {
              Console.WriteLine("Enter 'A' side of triangle: ");
              int a = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter 'B' side of triangle: ");
              int b = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter 'C' side of triangle: ");
              int c = Convert.ToInt32(Console.ReadLine());
          
              if (a == b && b == c)
                  Console.WriteLine("equilateral triangle."); // مثلث متساوي الأضلاع
              else if (a == b || b == c || a == c)
                  Console.WriteLine("isosceles triangle."); // مثلث متساوي الساقين
              else
                  Console.WriteLine("scalene triangle."); // مثلث ساق واحدة
          }
          // Section 2 - Task 15
          /* Write a C# Sharp program to check whether a triangle can be formed by
             the given angles value */
             static void Task_15()
          {
              Console.WriteLine("Enter 'A' side of triangle: ");
              int a = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter 'B' side of triangle: ");
              int b = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter 'C' side of triangle: ");
              int c = Convert.ToInt32(Console.ReadLine());

             int sum = a + b + c;
             
             if (sum == 180)
              Console.WriteLine("The triangle is valid.");
             else
              Console.WriteLine("The triangle is not valid.");
             }
        // Section 2 - Task 16
        /* Write a C# Sharp program to check whether an alphabet letter is a vowel
o          or a consonant. */
             static void Task_16()
         {
             Console.Write("Enter an alphabet letter: ");
             char ch = Char.ToLower(Convert.ToChar(Console.ReadLine()));
             
             if (ch == 'a' || ch == 'e' || ch == 'o' || ch == 'u' || ch == 'i')
              Console.WriteLine("The alphabet is a vowel.");
             else
              Console.WriteLine("The alphabet is a consonant.");
             }
        // Section 2 - Task 17
        // Write a C# Sharp program to calculate profit and loss on a transaction.
             static void Task_17()
             {
             Console.Write("cost price: ");
             int c = Convert.ToInt32(Console.ReadLine()); // c = cost
             
             Console.Write("selling price: ");
             int s = Convert.ToInt32(Console.ReadLine()); // s = sell
             
             if (s - c > 0) // if sell bigger than zero, then it is profit
              Console.WriteLine("You can book your profit amount : " + (s - c));
             else if (s - c < 0) // if sell less than zero, then it is loss
              Console.WriteLine("You lost : " +  (c - s));
             else
              Console.WriteLine("No Profit No Loss.");
             }
  
        // Section 2 - Task 19
        /* Write a program in C# Sharp to accept a grade and declare the equivalent
           description :
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
         */
        static void Task_19()
             {
             Console.Write("Input the grade: ");
             char grade = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
             
             string Description = "";
             
             switch (grade)
             {
              case 'E':
                    Description = "Excellent";
                    break;
              case 'V':
                    Description = "Very Good";
                    break;
              case 'G':
                    Description = "Good";
                    break;
              case 'A':
                    Description = "Average";
                    break;
              case 'F':
                    Description = "Fail";
                    break;
              default:
                    Description = "Invalid grade";
                    break;
             }
             Console.WriteLine("You chose : " + Description);
             }

        // Section 2 - Task 20
        /*
         * Write a C# Sharp program to read any day number as an integer and
           display the name of the day as a word.
         */

             static void Task_20()
             {
             Console.Write("Input day number (1 to 7): ");
             int day = Convert.ToInt32(Console.ReadLine());
             
             string DayName = "";
             
             switch (day)
             {
              case 1: 
                    DayName = "Monday";
                    break; 
              case 2: 
                    DayName = "Tuesday"; 
                    break; 
              case 3: 
                    DayName = "Wednesday"; 
                    break; 
              case 4: 
                    DayName = "Thursday"; 
                    break; 
              case 5: 
                    DayName = "Friday"; 
                    break; 
              case 6: 
                    DayName = "Saturday"; 
                    break; 
              case 7: 
                    DayName = "Sunday"; 
                    break; 
              default: 
                    DayName = "Invalid day number"; 
                    break;
             }
             Console.WriteLine(DayName);
             }

        // Section 2 - Task 21
        /* Write a program in C# Sharp to read any digit, display in the word.
         */
        static void Task_21()
             {
             Console.Write("Input a digit (0-9): ");
             int digit = Convert.ToInt32(Console.ReadLine());
             
             string word = "";
             
             switch (digit)
             {
              case 0: 
                    word = "Zero"; 
                    break;
              case 1: 
                    word = "One"; 
                    break;
              case 2: 
                    word = "Two"; 
                    break;
              case 3: 
                    word = "Three"; 
                    break;
              case 4: 
                    word = "Four"; 
                    break;
              case 5: 
                    word = "Five"; 
                    break;
              case 6: 
                    word = "Six"; 
                    break;
              case 7: 
                    word = "Seven"; 
                    break;
              case 8: 
                    word = "Eight"; 
                    break;
              case 9: 
                    word = "Nine"; 
                    break;
              default: 
                    word = "Invalid digit"; 
                    break;
             }
             Console.WriteLine(word);
             }
        // Section 2 - Task 22
        /* Write C# Sharp program to read any Month Number in integer and display
           Month name.
        */
        static void Task_22()
             {
             Console.Write("Input month number (1-12): ");
             int month = Convert.ToInt32(Console.ReadLine());
             
             string monthName = "";
             
             switch (month)
             {
              case 1: 
                    monthName = "January"; 
                    break;
              case 2: 
                    monthName = "February"; 
                    break;
              case 3: 
                    monthName = "March"; 
                    break;
              case 4: 
                    monthName = "April"; 
                    break;
              case 5: 
                    monthName = "May"; 
                    break;
              case 6: 
                    monthName = "June"; 
                    break;
              case 7: 
                    monthName = "July"; 
                    break;
              case 8: 
                    monthName = "August"; 
                    break;
              case 9: 
                    monthName = "September";
                    break;
              case 10: 
                    monthName = "October"; 
                    break;
              case 11: 
                    monthName = "November"; 
                    break;
              case 12: 
                    monthName = "December";
                    break;
              default: 
                    monthName = "Invalid month number"; 
                    break;
             }
             
             Console.WriteLine(monthName);
             }
             // Section 2 - Task 23
             /* Write a program in C# Sharp to read any Month Number in integer and
               display the number of days for this month.
              */
             static void Task_23()
             {
             Console.Write("Input month number (1-12): ");
             int month = Convert.ToInt32(Console.ReadLine());
             
             string days = "";
             
             switch (month)
             {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = "Month has 31 days";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = "Month has 30 days";
                    break;
                case 2:
                  days = "Month has 28 or 29 days (leap)";
                  break;
              default:
                  days = "Invalid month number";
                  break;
             }
             Console.WriteLine(days);
             }
             // Section 2 - Task 24
             /* Write a C# Sharp program that calculates the area of geometrical shapes
                using a menu-driven approach. */
             static void Task_24()
             {
             Console.WriteLine("Menu:");
             Console.WriteLine("1. Circle");
             Console.WriteLine("2. Rectangle");
             Console.WriteLine("3. Triangle");
             Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––");
             Console.Write("Input your choice: ");
             int choice = Convert.ToInt32(Console.ReadLine());
             
             switch (choice)
             {
              case 1:
                  Console.Write("Input radius of the circle: ");
                  double r = Convert.ToDouble(Console.ReadLine());
                  Console.WriteLine("The area is : " + (Math.PI * r * r));
                  break;

              case 2:
                  Console.Write("Input length and Width of the rectangle: ");
                  double l = Convert.ToDouble(Console.ReadLine()); // l == length
                  double w = Convert.ToDouble(Console.ReadLine()); // w == Width
                  Console.WriteLine("The area is : " + (l * w));
                  break;

              case 3:
                  Console.Write("Input base and height of the triangle: ");
                  double bs = Convert.ToDouble(Console.ReadLine());
                  double h = Convert.ToDouble(Console.ReadLine());
                  Console.WriteLine("The area is : " + (0.5 * bs * h));
                  break;

              default:
                  Console.WriteLine("Invalid choice");
                  break;
             }
             }
    
    
    
    }


}