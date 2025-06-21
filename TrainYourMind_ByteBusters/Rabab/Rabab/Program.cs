using System;


class Program
{
//Q1
/*
    الوصف:
1- الفكرة ان اسخرج ثلاثة اضعاف الرقم اذا كان العددين متساويين عملت شرط لأختبار اذا الرقمين متساووين ومن ثم وضعة المعادلة الرقم *6 هنا سيكون الناتج ضعف العدد وهو المطلوب.
التحديات التي واجهتني كانت تخص syntax اللغة فقط.
2-الفكرة كانت واضحة لم اواجه مشكلة ب ايجاد الحل
3-واجهة مشكلة في syntax اللغة احتاج ان ادرس اللغة جيدا بمعنى ان الفكرة بعقلي لاكن لا اعرف كيف اطبقها, ايضا واجهة مشكلة بقراءة الأخطاء في compiler اللغة
    */
static void sum()
{

        Console.Write("Enter first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        
        if(number1 == number2){
            int topic = number1*6;
            Console.Write("the topic :"+topic);
        }
        else
        {
            int sum = number1+number2;
            Console.Write("the sum :"+sum);
        }
}
//Q2
/*
الوصف :
عملت شرط اذا كان العدد اكبر من 51 يستخرج الفرق وضعف الفرق اما اذا اقل فيستخرج فقط الفرق 
*/
static void diff()
{
        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if(n>51){
            int d = n-51;
            int t = d*3;
            Console.Write("the diff t : "+ t);
        }
        else
        {
            int diff = 51-n;
            Console.Write("the diff : "+ diff);
        }
}
//Q3

static void chicn()
{
        Console.Write("Enter first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        if((number1 + number2 == 30) || number1 == 30 || number2 == 30)
        {
            Console.Write("true");
        }
        else
        {
            Console.Write("false");
        }
}
//Q4
static void qfor()
{
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        int[] numbers = {1,2,3,4,5,6,7,8,9,10}; 
        int num1= number-200 ;
        int num2= number-200 ;
        for (int i = 0; i < numbers.Length; i++){
            if((num1 == numbers[i]){
                Console.Write("true");
            }
             else
        {
            Console.Write("false");
        }
        }
}
//Q5
 static void remstr()
{
        Console.Write("Enter string: ");
        string mystring = Console.ReadLine();
        Console.Write("Enter position: ");
        int position = Convert.ToInt32(Console.ReadLine());
       
            for(int i=0; i<= mystring.Length-1;i++)
            {
                if(position == mystring[i])
                {
                   mystring[i]=null; 
                }
            }
            Console.Write(mystring);
}
//Q6

static void adif()
{
    Console.Write("enter string");
    string myString = Console.ReadLine();
    if(myString[0]=="i" && myString[1]=="f")
    {

        Console.Write(myString);
    }
    if(myString[0]!="i" && myString[1]!="f")
    {
        myString[0]="i";
        myString[1]="f";
        Console.Write(myString);
    }
}
//Q7
/*
الوصف:
في هذا التمرين سويت متغير لأحفظ اول حرف ومتغير لحفظ اخر حرف لاكن توجد اخطاء كثيرة اولا لايمكن حفظ سلسلة في حرف وايضًا عملية الاستبدال خطأ 
احتاج ان افهم اللغة جيدا
*/
 static void exchange()
{
        Console.Write("Enter string: ");
        string mystring = Console.ReadLine();
         for(int i=0; i<= mystring.Length-1;i++)
            {
              char a = mystring[0]
              char b = mystring[mystring.Length-1];
               mystring[0] = b;
               mystring[Length-1] = a;
            }
            Console.Write(mystring);
}
//Q8
/*
الوصف:
في هذا التمرين استخدمة الدال الجاهزة substring  ومن ثم سويت لوب ليكرر الحرفين 4 مرات 
التحدي الذي واجهني هو ان استخرج اول حرفين
*/
 static void strrep()
{
        Console.Write("Enter string: ");
        string mystring = Console.ReadLine();
        if(mystring.Length-1>=2)
        {
            string fstr = mystring.Substring(0,2);
            for(int i=0;i<4;i++)
            {
                Console.Write(fstr);
            }
        }
        else
        {
            Console.Write(mystring);
        }
}
//Q9
/*
الوصف:
البرنامج فكرته بسيطه لانحتاج الى لوب او شرط فقط نحتاج حفظ اخر حرف ومن ثم بأستخدام +نجمع السلسلة فس سلسلة جديدة لدي اطلاع على الفكرة من قبل 
*/
 static void reandch()
{
        Console.Write("Enter string: ");
        string mystring = Console.ReadLine();
        char lastc =mystring[mystring.Length-1];
        string newstr = lastc + mystring + lastc;
        Console.Write(newstr);
     
}
//Q10
/*
الوصف:
في هذا التمرين اردت جمع مضاعفات العدد 3 والعدد7 في مصفوفه ومن ثم اقارن العدد المدخل في المصفوفة
مضاعفات العدد هو حاصل ضرب العدد في الاعداد الطبيعية عدا الصفر اذن وضعت شرط اولا ان استثني العدد 0 والأعداد السالبة البرنامج فيه مشاكل لم استطع حلها بعد.
*/
 static void mults()
{
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number != 0 && number>0)
        {
            for(int i=1;i<1000;i++)
            {
                int[] multhre = 3 *i;
                int[] mulsev = 7*i;
            }
            for(int t=1;t<=multhre(multhre.Length);multhre++)
            {
                for(int s=1;s<=mulsev(mulsev.Length);mulsev++)
                {
                    if(number ==multhre[t] || number ==mulsev[s])
                    {
                        Console.Write("true");
                    }
                }
            }
        }
}
//Q11
 static void strrep()
{
        Console.Write("Enter string: ");
        string mystring = Console.ReadLine();
        if(mystring.Length-1>=2)
        {
            string fstr = mystring.Substring(0,3);
            string newstr = fstr + mystring + fstr;
           Console.Write(newstr);
        }
        if(mystring.Length-1<=2)
        {
            string fstr = mystring.Substring(0,3);
            string newstr = fstr + mystring + fstr;
            Console.Write(newstr); 
        }
}
//Q12
/*
الوصف:
الصعوبة التي واجهتني لم اكن اعرف كيف اقارن حرف بسلسلة
*/
 static void comstr()
{
        Console.Write("Enter string: ");
        string str = Console.ReadLine();
        string nstr="";
    if(str[0]=='C' && str[1]=='#')
    {
        Console.Write("true");
    }
    else
    {
        Console.Write("false");
    }
}
//Q13
 static void temp()
{
        Console.Write("Enter number1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        if(n1<0 && n2>100 || n1>100 && n2<0)
        {
            Console.Write("true");
        }
        else
        {
            Console.Write("false");
        }
}
//Q14
 static void rang()
{
        Console.Write("Enter number1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        if(n1>=100 && n2<=200 || n1<=200 && n2>=100)
        {
            Console.Write("true");
        }
        else
        {
            Console.Write("false");
        }
}
//Q15
 static void mults()
{
        Console.Write("Enter number1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number2: ");
        int n3 = Convert.ToInt32(Console.ReadLine());
        if((n1>=20 && n1<=50) || (n2<=50 && n2>=20) || (n3<=50 && n3>=20))
        {
            Console.Write("true");
        }
        else
        {
            Console.Write("false");
        }
}
//Q16
 static void qsix()
{
        Console.Write("Enter number1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
     
        if((n1>=20 && n1<=50) || (n2<=50 && n2>=20))
        {
            Console.Write("true");
        }
        else
        {
            Console.Write("false");
        }
}
//Q17

 static void comr()
{
        Console.Write("Enter string: ");
        string str = Console.ReadLine();
        string nstr="";
    if(str[1]=='y' && str[2]=='t')
    {
        nstr = str[0]+str.Substring(3);
        Console.Write(nstr);
    }
    else
    {
        Console.Write(str);
    }
}
//Q18
 static void larg()
{
        Console.Write("Enter number1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number2: ");
        int n3 = Convert.ToInt32(Console.ReadLine());
        int large=n1;
     
            if(n2>large)
        {
            large=n2;
        }
            if(n3>large)
        {
            large=n3;
        }
       
        Console.Write(large);
}
//Q19
         static void qnin()
{
        Console.Write("Enter number1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
       if(100-n1 < 100-n2)
       {
           Console.Write(n1);
       }
       else if(n1==n2)
       {
           Console.Write("0");
       }
       else
       {
           Console.Write(n2);
       }
        
}
//Q20
 static void qtonty()
{
        Console.Write("Enter number1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
       
        if((n1>=40 && n1<=50) && (n2>=40 && n2<=50)||(n1>=50 && n1<=60) && (n2>=50 && n2<=60))
        {
            Console.Write("true");
        }
        else
        {
            Console.Write("false");
        }
}
//Q21
 static void qlargeran()
{
        Console.Write("Enter number1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int max = n1;
        if((n1>=20 && n1<=30) && (n2>=20 && n2<=30))
        {
             if(n2>max)
        {
            max=n2;
            
        }
        Console.Write(max);
        }
        else
        {
            Console.Write("0");
        }
}
//Q22
    static void comstr()
{
        Console.Write("Enter string: ");
        string str = Console.ReadLine();
        int cont =0;
        for(int i=0;i<=str.Length-1;i++)
        {
            if(str[i]== 'z')
            {
                cont++;
            }
        }
        if(cont>=2 && cont<=4)
            {
                Console.Write("true");
            }
            else 
            {
                Console.Write("false");
            }
}
//Q24
    static void struper()
{
        Console.Write("Enter string: ");
        string str = Console.ReadLine();
    if(str.Length >3)
    {
        string ns = str.Substring(str.Length-3).ToUpper();
        string ns2 = str.Substring(0,str.Length-3);
        string newstr = ns2+ns;
        Console.Write(newstr);
    }
    else
    {
       string nstr2 = str.ToUpper();
       Console.Write(nstr2);
    }
}
//Q25
 static void qfif()
{
    
        Console.Write("Enter string: ");
        string str = Console.ReadLine();
        Console.Write("Enter number2: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if(n>0)
        {
            for(int i=0;i<n;i++)
        {
            Console.Write(str);
        }
        }
}
   static void Main(string[] args)
  {
       sum();
       diff();
       chicn();
       qfor();
       adif();
       remstr();
       adif();
exchange();
strrep();
reandch();
mults();
strrep();
comstr();
temp();
rang();
mults();
qsix();
comr();
larg();
qnin();
qtonty();
qlargeran();
comstr();
struper();
qfif();
  }
}