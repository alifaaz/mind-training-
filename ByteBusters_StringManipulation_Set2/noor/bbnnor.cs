using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = 1 + 2;
            var n2 = 2 + 3;
            var n3 = (2, 2);



            Console.WriteLine((n));
            Console.WriteLine((n2));


            if (n3.Item1 == n3.Item2)
            {
                int sum = n3.Item1 + n3.Item2;

                Console.WriteLine(sum * 3);


            }






            //q2

            int[] numbers = new int[3] { 53, 30, 51 };




            for (int i = 0; i < numbers.Length; i++)

            {

                int n = numbers[i];

                int diff = Math.Abs(n - 51);

                if (n > 51)
                {
                    Console.WriteLine(diff * 3);
                }
                else
                {
                    Console.WriteLine(diff);
                }

            }






            //q3

            var st = 0 + 30;
            Console.WriteLine(st); if (st == 30)
            {
                Console.WriteLine(true);


            }
            else
            {
                Console.WriteLine(false);
            }

            st = 5 + 25;
            Console.WriteLine(st);
            if (st == 30)
            {
                Console.WriteLine(true);


            }
            else
            {
                Console.WriteLine(false);
            }

            int a = 20, b = 30;
            st = a + b;
            Console.WriteLine(st);
            if (a == 30 || b == 30 || st == 30)
            {
                Console.WriteLine(true);


            }
            else
            {
                Console.WriteLine(false);
            }


            st = 20 + 25;
            Console.WriteLine(st); ;

            if (st == 30)
            {
                Console.WriteLine(true);


            }
            else
            {
                Console.WriteLine(false);
            }
            //هنا اخذت قيم جمعتهم اذا طلعت ناتجهم 30 اطبعه شرط يكون طبعه true 
            //يطلع true true true fales - نقطه غير شرط لين اذا جمع يطبع 50 تكون صح يعني احد مجموع ساوي 30 تطبع true//


            //q4

            Console.WriteLine(IsNear100or200(103));
            Console.WriteLine(IsNear100or200(90));
            Console.WriteLine(IsNear100or200(89));


            bool IsNear100or200(int number)
            {
                return Math.Abs(number - 100) <= 10 || Math.Abs(number - 200) <= 10;
            }

            //استخدمت method  اسم داله IsNearيعني تكون قريبه بين مسافه بين اعداد هنا هو مطلوب فرق 100او 200 او اقل بعدها استخدمت boolean حتى عرف قيمه true or fales استخدمت return ترجعلي قيمه بعدها استخدمت خاصيه مطلق

            //q5

            Console.WriteLine(AddIf("if else"));

            Console.WriteLine(AddIf("else"));
        }
        static string AddIf(string input)
        {
            if (input.StartsWith("if"))
            {
                return input;
            }
            else
            {
                return "if " + input;
            }
            Console.ReadLine();
            //هنا تم اضافة Add لل if
            // مامطلوب سلسلة input and input هنا تم عمليه //Output 
            // Output: if else
            //طوه ثانيه 
            //ستخدمت static  لان ستخدم بداخله main//







            // إدخال رقم القيد
            Console.Write("Input the Roll Number of the student: ");
            int rollNo = Convert.ToInt32(Console.ReadLine());

            // إدخال الاسم
            Console.Write("Input the Name of the Student: ");
            string name = Console.ReadLine();

            // إدخال الدرجات
            Console.Write("Input the marks of Physics, Chemistry and Computer Application: ");
            int physics = Convert.ToInt32(Console.ReadLine());
            int chemistry = Convert.ToInt32(Console.ReadLine());
            int computer = Convert.ToInt32(Console.ReadLine());

            // هنا حساب المجموعه
            int total = physics + chemistry + computer;

            //     
            float percentage = (total / 3.0f);

            // تحديد القسمة (Division)هنا  
            string division = "";
            if (percentage >= 60)
            {
                division = "First";
            }
            else if (percentage >= 50)
            {
                division = "Second";
            }
            else if (percentage >= 40)
            {
                division = "Third";
            }
            else
            {
                division = "Fail";
            }

            //  طبعت النتجيه 
            Console.WriteLine("\nRoll No : " + rollNo);
            Console.WriteLine("Name of Student : " + name);
            Console.WriteLine("Marks in Physics : " + physics);
            Console.WriteLine("Marks in Chemistry : " + chemistry);
            Console.WriteLine("Marks in Computer Application : " + computer);
            Console.WriteLine("Total Marks = " + total);
            Console.WriteLine("Percentage = " + percentage.ToString("0.00"));
            Console.WriteLine("Division = " + division);
        }



        //سوال طقس

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("أدخل درجة الحرارة (°م): ");
        double temp = Convert.ToDouble(Console.ReadLine());

        if (temp< 0)
        {
            Console.WriteLine("الطقس متجمد");
        }
        else if (temp< 10)
        {
            Console.WriteLine("الطقس بارد جدًا");
        }
        else if (temp < 20)
{
    Console.WriteLine("الطقس بارد");
}
else if (temp < 30)
{
    Console.WriteLine("درجة الحرارة عادية");
}
else if (temp < 40)
{
    Console.WriteLine("إنها ساخنة");
}
else
{
    Console.WriteLine("إنها ساخنة جدًا");
}

Console.ReadLine();

// استخدمت اول utf8 حتى يتحولي حروف ابجديه ثم حولت double  اخذت درجه حراره استخدمت if اذا temp <0 يطبع طقس متجمد كذالك خطوات بعدها نفس استخدمت

//  هذا يخلي الشاشة تنتظر قبل ما تغلق



// q8
string[] inputs = { "C Sharp", "JS", "a" };

for (int i = 0; i < inputs.Length; i++)
{


    Console.WriteLine(CreateString(inputs[i]));

}


string CreateString(string str)
{
    if (str.Length < 2)
        return str;

    string frontChars = str.Substring(0, 2);
    return frontChars + frontChars + frontChars + frontChars;

    Console.ReadLine();
    //استخدم هنا مدخلات Aarry 
    // ثم استخدمت داله createstring
    //ثم استخدمت شرط اخرشي رجعت  return




    //q10



    string[] samples = { "Red", "Green", "1" };

    for (int i = 0; i < samples.Length; i++)
    {
        string str = samples[i];

        char last = str[str.Length - 1];
        string result = last + str + last;
        Console.WriteLine(result);
    }


    //استخدمت Aarry  واستخدمت for سلسلةطول   string str خزن لل for 
    // String result  last اول هي تضيف حرف بالبدايه d
    //last للحرف نهايه




    //q11

    int[] numbers = { 3, 14, 12, 37 };

    for (int i = 0; i < numbers.Length; i++)
    {
        int num = numbers[i];

        if (num > 0 && (num % 3 == 0 || num % 7 == 0))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");

        }

        //عملت شرط num من مضاعغات 3
        //يتنفذ true او fales

        //q23


        Console.Write("أدخل قيمة x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("أدخل عدد الحدود: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double sum = 1.0;
        double term = 1.0;

        for (int i = 0; i <= n; i++)
        {

            term *= x / i;
            sum += term;
        }
        Console.WriteLine("Sum: " + sum.ToString("F6"));
        Console.WriteLine("numberOfTerms: " + n);
        Console.WriteLine("Value of x: " + x.ToString("F6"));

    }


    //بدايه سويت عمليه ادخال البيانات
    // ثم حؤلت doubel ثم int n استخدمت for عدد حدوديه
    //(  
    //ثم طلبت منه ينفذ  sum عندا خال x وحد 5يطلع ودخلت قيمه 3//
    //f6 هي تعنيtostring






    // q24  end


    Console.Write("أدخل قيمة x: ");
    double x = Convert.ToDouble(Console.ReadLine());

    Console.Write("أدخل عدد الحدود: ");
    int numberOfTerms = Convert.ToInt32(Console.ReadLine());

    double sum = 0;

    for (int i = 0; i < numberOfTerms; i++)
    {
        double term = Math.Pow(x, 2 * i + 1);
        sum += (i % 2 == 0) ? term : -term;
    }

    Console.WriteLine($" sum = {sum}");
}


//بدايه سويت عمليه ادخال البيانات
// ثم حؤلت doubel ثم int n استخدمت for عدد حدوديه
//(i%2==0)هذا كان الحد تبديل الاشاره
//ثم طلبت منه ينفذ sum عندا خال x وحد 5يطلع //


//q22

int rows = 5;
for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)

        if ((i + j) % 2 == 0)
        {
            Console.Write("1");
        }
        else
        {
            Console.WriteLine("0");
        }
}
Console.WriteLine();

//اول بينه نطبع حدوديه ثم استخدمت for i forj وناخذ شرط يقبل قسمه على ثننين يظهر واحد else يطبع صفر




//q21
int rows = 4;
for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= rows - 1; j++)

        Console.WriteLine("");
    {

    }

    for (int k = 1; k <= i; k++)

    {
        Console.WriteLine("*");

    }
    Console.WriteLine();

    // استخدمت 3for يكون شكل هرم


    //q 24 .8 حساب لاعدداد فرديه

    Console.Write("Input number of terms: ");
    int n = Convert.ToInt32(Console.ReadLine());


    int sum = 0;
    Console.Write("The odd numbers are: ");


    for (int i = 0; i < n; i++)
    {
        int oddNumber = 2 * i + 1;
        Console.Write(oddNumber + " ");
        sum += oddNumber;


        Console.WriteLine("\nThe Sum of odd Natural Number up to " + n + " terms: " + sum);
    }

    //نقوم بتعرف sum حتى لتخزين المجموع بعدها نبطبع رسال الاعداد الفرديه استخدم حلقه for نحسب المعادله i+1*2
    // اذا i = 0 نحصل على 1 عندما i = 1نحصل عل3 بعد
    //انتهاء نقوم بطباعة مجموع الاعداد فرديه




    //q25 اخر سوال

    Console.Write("Input the number of terms: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int sum = 0;

    Console.Write("The square natural upto " + n + " terms are: ");

    for (int i = 1; i <= n; i++)
    {
        Console.Write((i * i) + " ");
        sum = sum + (i * i);
    }

    Console.WriteLine();
    Console.WriteLine("The Sum of Square Natural Number upto " + n + " terms = " + sum);
}
//بدايه اطبع رساله رقم كتب نص حول عدد صحيح int sum=0استخدمت نجمع نواتج  ثم اطبع بدايه سطراستخدم for ثم نحسب رقم حالي i*i نضيف ناتج التربيع sum نحسب مجموع نهائي







//q1. 25  يعني اخر نقطه رقم

for (int i = 1; i <= 10; i++)
{
    Console.Write(i + " ");





}
//طبع الاعداد طبيعيه من 1 لل10


//q2.25

int sum = 0;

Console.WriteLine("The first 10 natural number is :");

for (int i = 1; i <= 10; i++)
{
    Console.Write(i + " ");
    sum = sum + i;
}

Console.WriteLine();
Console.WriteLine("The Sum is : " + sum);
//نبدا متغير صفر استخدم forبعدها اجمع // بعد// الحلقه طبع وجمع نطبع مجموعه نهايه//


//q5.25
Console.Write("Input number of terms: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Number is : " + i + " and cube of the " + i + " is :" + (i * i * i));
}

//  عمل for  حلقه ثم اضرب مكعب بنفسه ٣مرات يطبع النتيجه بنفسي تنسيق



//q10.25
int rows = 4; // Number of rows

for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j); // يطبع  لي مثل شجره for معطى حد 4 استخدمت   
    }
    Console.WriteLine();


    //q22

    string str1 = "COMPUTER";
    string str2 = "computer";

    string sub1 = "MP";
    string sub2 = "mp";

    Console.WriteLine("Ignore case:");
    if (sub1.ToLower() == sub2.ToLower())
    {
        Console.WriteLine("Substring '" + sub1 + "' equals '" + sub2 + "' (ignore case)");
    }

    Console.WriteLine("Honor case:");
    if (sub1 == sub2)
    {
        Console.WriteLine("Substrings are equal (with case)");
    }
    else
    {
        Console.WriteLine("Substring '" + sub1 + "' is not equal to '" + sub2 + "' (case sensitive)");
    }
    //نقارن Mp mp  حول الى حروف صغيره مره بدون حساسيه حرف كبير وصغيراستخدمت if ثم طبعت ناتج





    Console.ReadLine();











}
                }
            }


  