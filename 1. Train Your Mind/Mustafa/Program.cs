// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Q1");
Console.Write("Enter First value:");
double X = double.Parse(Console.ReadLine());
Console.Write("Enter Second value:");
double Y = double.Parse( Console.ReadLine());
double Z = 0;
if (X==Y)
{
    Z = X + Y;
    Z = Z * 3;
}
else Z = X + Y;
Console.Write("Summation equal:");
Console.WriteLine(Z);*/

/*Console.WriteLine("Q2");
const int N = 51;
Console.Write("Enter value to check:");
float n = float.Parse(Console.ReadLine());
float diff = 0;
if (n > N)
{
    diff = n % N;
    diff = diff * 3;
}
else
{
    diff = N - n;
}
Console.Write("Diffrence is ");
Console.WriteLine(diff);*/

//---------------------------------------------

//Console.WriteLine("Q3");
//int a, b ;
//Console.Write("Enter first value to check:");
//a= int.Parse(Console.ReadLine());
//Console.Write("Enter second value to check:");
//b = int.Parse(Console.ReadLine());
//if (a==30 || b==30 || (a+b)==30)
//{
//    Console.WriteLine("true");
//}
//else
//{
//    Console.WriteLine("false");

//}

//---------------------------------------------


//Console.WriteLine("Q5");
//string input;
//Console.Write("Input string to check: ");
//input = Console.ReadLine();
//if (input.StartsWith("if"))
//{
//    Console.WriteLine("true");
//}
//else
//{
//    input = "if " + input;
//    Console.WriteLine("Result string: "+input);
//}

//---------------------------------------------


//Console.WriteLine("Q6");
//string input;
//Console.Write("Input string : ");
//input = Console.ReadLine();
//int pos = 0;
//Console.Write("Enter Postion of Char to remove: ");
//pos = int.Parse(Console.ReadLine());
//while (pos > input.Length)
//{
//    Console.WriteLine("Entered Postion is out of range please retry again");
//    Console.Write("Enter Postion of Char to remove: ");
//    pos = int.Parse(Console.ReadLine());
//}
//input = input.Remove(pos,1);
//Console.WriteLine("Entered Postion after trimed is like: "+ input);

//---------------------------------------------

//Console.WriteLine("Q7");
//string input;
//Console.Write("Input string : ");
//input = Console.ReadLine();
//string reverse = string.Empty;
//Console.Write("Reverse string : ");
//for (int i = input.Length-1; i >= 0; i--)
//{
//    Console.Write(input[i]);
//}

//---------------------------------------------

//Console.WriteLine("Q10");

//Console.Write("Enter Number to check: ");
//double num =double.Parse(Console.ReadLine());

//if (num %3== 0 || num%7==0)
//{
//    Console.WriteLine("true");
//}
//else
//{
//    Console.WriteLine("false");
//}

//---------------------------------------------

//Console.WriteLine("Q12");

//Console.Write("Enter string to check: ");
//string str = Console.ReadLine();
//str = str.ToUpper();
//if (str.StartsWith("C#"))
//{
//    Console.WriteLine("true");
//}
//else
//{
//    Console.WriteLine("false");
//}

//---------------------------------------------

//Console.WriteLine("Q13");

//Console.Write("Enter 1St tempreture to check: ");
//int temp_01 = int.Parse(Console.ReadLine());

//Console.Write("Enter 2nd tempreture to check: ");
//int temp_02 = int.Parse(Console.ReadLine());

//if (temp_01< 0 && temp_02>100 || temp_01 > 100 && temp_02 < 0)
//{
//    Console.WriteLine("true");
//}
//else
//{
//    Console.WriteLine("false");
//}

//---------------------------------------------

//Console.WriteLine("14");

//Console.Write("Enter 1St number to check: ");
//int num_01 = int.Parse(Console.ReadLine());

//Console.Write("Enter 2nd number to check: ");
//int num_02 = int.Parse(Console.ReadLine());

//if ((num_01 >= 100 && num_02 <=200) || (num_01 <=200 && num_02 >100))
//{
//    Console.WriteLine("true");
//}
//else
//{
//    Console.WriteLine("false");
//}

//---------------------------------------------

//Console.WriteLine("Q15");

//Console.Write("Enter 1St number to check: ");
//int num_01 = int.Parse(Console.ReadLine());

//Console.Write("Enter 2nd number to check: ");
//int num_02 = int.Parse(Console.ReadLine());


//if ((num_01 >= 20 && num_01 <= 50))
//{
//    if (num_02 < 20 || num_02 > 50)
//    {
//        Console.WriteLine("true");
//    }
//    else
//    {
//        Console.WriteLine("false");
//    }
//}
//else
//{
//    if ((num_02 >= 20 && num_02 <= 50))
//        Console.WriteLine("true");
//    else Console.WriteLine("false");

//}

//---------------------------------------------

//Console.WriteLine("Q18");

//Console.Write("Enter 1St number to check: ");
//int num_01 = int.Parse(Console.ReadLine());

//Console.Write("Enter 2nd number to check: ");
//int num_02 = int.Parse(Console.ReadLine());

//Console.Write("Enter 3rd number to check: ");
//int num_03 = int.Parse(Console.ReadLine());

//if (num_03 > num_02 && num_03 > num_01)
//{
//    Console.WriteLine("Largest Number is: " + num_03);
//}
//else if (num_02 > num_01 && num_02>num_03)
//{
//    Console.WriteLine("Largest Number is: " + num_02);
//}
//else if (num_01 > num_02 && num_01 > num_03)
//{
//    Console.WriteLine("Largest Number is: " + num_01);
//}
//else
//{
//    Console.WriteLine("Numbers are Same");
//}

//---------------------------------------------

//Console.WriteLine("Q20");

//Console.Write("Enter 1St number to check: ");
//int num_01 = int.Parse(Console.ReadLine());

//Console.Write("Enter 2nd number to check: ");
//int num_02 = int.Parse(Console.ReadLine());

//if ((num_01 >= 40 && num_01 <= 50) && (num_02 >= 40 && num_02 <= 50))
//{
//    Console.WriteLine("true");
//} else if ((num_01 >= 40 && num_01 <= 50) || (num_02 >= 40 && num_02 <= 50))
//    Console.WriteLine("true"); else Console.WriteLine("false");

//---------------------------------------------

//Console.WriteLine("Q21");

//Console.Write("Enter 1St number to check: ");
//int num_01 = int.Parse(Console.ReadLine());

//Console.Write("Enter 2nd number to check: ");
//int num_02 = int.Parse(Console.ReadLine());

//if ((num_01 >= 20 && num_01 <= 30) && (num_02 >= 20 && num_02 <= 30))
//{
//    int max = num_01;
//    if (num_02>max) max = num_02;

//    Console.WriteLine("Max number is " + max);
//}
//else Console.WriteLine("Out of range");

//---------------------------------------------

//Console.WriteLine("Q22");

//Console.Write("Enter string to check: ");
//string str = Console.ReadLine();
//int count = 0;
//for (int i = 0; i < str.Length; i++)
//{
//    if (str[i] == 'z') count++;

//}
//if (count >= 2 && count <= 4)
//{
//    Console.WriteLine("True");
//}
//else Console.WriteLine("false");

//---------------------------------------------

//Console.WriteLine("Q23");
//Console.Write("Enter 1St number to check: ");
//int num_01 = int.Parse(Console.ReadLine());

//Console.Write("Enter 2nd number to check: ");
//int num_02 = int.Parse(Console.ReadLine());

//while (num_02 < 0 || num_01 < 0)
//{
//    Console.Write("Re Enter 1st Positive number to check: ");
//    num_01 = int.Parse(Console.ReadLine());

//    Console.Write("Re Enter 2nd Positive number to check: ");
//    num_02 = int.Parse(Console.ReadLine());
//}
//char[] n1 = num_01.ToString().ToCharArray();
//char[] n2 = num_02.ToString().ToCharArray();


//if (n1[n1.Length - 1] == n2[n2.Length - 1])
//    Console.WriteLine("true");
//else Console.WriteLine("false");

//---------------------------------------------

//Console.WriteLine("Q24");

//Console.Write("Enter string to check: ");
//string str = Console.ReadLine();
//int count = 0;

//if (str.Length < 3)
//    Console.WriteLine("Length is Less 3 and Output String is " + str.ToUpper());
//else
//{
//    char[] chars = str.ToCharArray();
//    chars = chars.Reverse().ToArray();
//    Console.WriteLine(chars);
//    for (int i = 0; i < 3; i++)
//    {
//        chars[i] = char.ToUpper(chars[i]);
//    }
//    chars = chars.Reverse().ToArray();
//    Console.WriteLine(chars);
//}

//---------------------------------------------

//Console.WriteLine("Q25");

//Console.Write("Enter string to dublicate: ");
//string str = Console.ReadLine();
//Console.Write("Enter number of copies non-negative: ");
//int count = int.Parse(Console.ReadLine());

//while (count < 0)
//{
//    Console.Write("re Enter number of copies non-negative: ");
//    count = int.Parse(Console.ReadLine());

//}
//string newstr = "";
//for (int i = 0; i < count; i++)
//{
//   newstr= newstr.Insert(0, str);
//}
//Console.WriteLine(newstr);

//---------------------------------------------

//Console.WriteLine("Q26");

//Console.Write("Enter 1St number to check: ");
//int num_01 = int.Parse(Console.ReadLine());

//Console.Write("Enter 2nd number to check: ");
//int num_02 = int.Parse(Console.ReadLine());

//if (num_02 == num_01)
//{
//    Console.WriteLine("equal numbers");
//}
//else
//{
//    if (num_02 != num_01)
//        Console.WriteLine("not equal");
//}
//---------------------------------------------

//Console.WriteLine("Q27");

//Console.Write("Enter  number to check: ");
//int num_01 = int.Parse(Console.ReadLine());

//if (num_01 % 2 == 0)
//{
//    Console.WriteLine("number is even");
//}
//else Console.WriteLine("Number is Odd");

//---------------------------------------------

//Console.WriteLine("Q27");

//Console.Write("Enter  number to check: ");
//int num_01 = int.Parse(Console.ReadLine());

//if (num_01 < 0)
//{
//    Console.WriteLine("number is negative");
//}
//else if (num_01 > 0) Console.WriteLine("Number is positive");
//else Console.WriteLine("Number is 0");

//---------------------------------------------

//Console.WriteLine("Q28");

//Console.Write("Enter  Year to check: ");
//int num_01 = int.Parse(Console.ReadLine());

//if (DateTime.IsLeapYear(num_01))
//{
//    Console.WriteLine("{0} is a Leap Year.", num_01);
//}

//else
//{
//    Console.WriteLine("{0} is not a Leap Year.", num_01);
//}

//---------------------------------------------

//Console.WriteLine("Q29");

//Console.Write("Enter  age to check: ");
//int num_01 = int.Parse(Console.ReadLine());
//if (num_01 >=18)
//{
//    Console.WriteLine("Congratulation! You are eligible for casting your vote.");
//}
//else
//{
//    Console.WriteLine("Sorry! You are not eligible for casting your vote.");
//}


//---------------------------------------------

//Console.WriteLine("Q30");
//Console.Write("Enter  number to check: ");
//int num_01 = int.Parse(Console.ReadLine());
//if (num_01 == 0)
//    Console.WriteLine("0");
//else if (num_01>0)
//{
//    Console.WriteLine("1");
//}
//else
//{
//    Console.WriteLine("-1");
//}

//---------------------------------------------

Console.WriteLine("Q31");


Console.Write("Enter 1st number to check: ");
int num_01 = int.Parse(Console.ReadLine());
Console.Write("Enter 2nd number to check: ");
int num_02 = int.Parse(Console.ReadLine());
Console.Write("Enter 3rd number to check: ");
int num_03 = int.Parse(Console.ReadLine());


if (num_01 > num_02 && num_01 > num_03)
    Console.WriteLine("Largest is 1st");
else if (num_02 > num_01 && num_02 > num_03)
    Console.WriteLine("Largest is 2nd");
else if (num_03 > num_01 && num_03 > num_02)
    Console.WriteLine("Largest is 3rd");
else Console.WriteLine("Equal");