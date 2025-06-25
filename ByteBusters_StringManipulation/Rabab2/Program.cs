using System;
using System.Globalization;
using System.Linq;
public class Program
{

//Q1
/*
حسب فهمي للسؤال يريد اذا نتيجة المقارنة متساوية نثبت ذلك طبعت نتيجة المقارنتين فقط 
*/
static void Demonstrate()
{
        string str1 = "rabab";
        string str2 = "RABAB";
        Console.Write("String 1 equal: {0} ",String.Compare(str1, str2, true)==0);
        Console.Write("String 2 equal : {0} ", str1.ToUpper() == str2.ToUpper());
}
//Q2
/*
استخدمت الشرط اذا كان ناتج المقارنة اقل من 0  فان في الثقافة الانكيزية قيمة حرف c <d
*/
  static void Culturr()
    {
        CultureInfo english = new CultureInfo("en-US");
        CultureInfo czech = new CultureInfo("cs-CZ");
       string a = "change";
       string b = "dollar";
       
       int result1 = String.Compare(a, b,false,english); 
       if(result1 <0){
           Console.Write("For en-US: change < dollar" );
       }
    }
//Q11
/*
استخدمت عملية الجمع لدمج الجمل
*/
  static void Concatenatestring()
    {
        Console.Write("enter string1  : ");
        string string1 = Console.ReadLine();
         Console.Write("enter string2  : ");
        string string2 = Console.ReadLine();
         Console.Write("enter string3  : ");
        string string3 = Console.ReadLine();
        string fullname = "";
        fullname= string1 + string2 + string3;
        Console.Write(" " , fullname);
    }
//Q12
    static void Concatenatearraystring()
    {
      
        
        string[] str = {"hello ","welcome ","to ","C#"};
        string words = "";
         for(int i=0;i<str.Length;i++)
         {
              words += str[i];
         }
         Console.Write(words);
    }
//Q13
 static void Longest()
    {
      
        
        string str = "hello welcome to C#";
        string words = "hello";
       
        bool result = str.Contains(words);
        Console.Write(result);
    }
//Q14
    static void Objectreferences()
    {
  
        string str1 = "hello";
        string str2 = "hello2";
        str2=String.Copy(str1);
        Console.Write(str2);
        Console.WriteLine(Object.ReferenceEquals(str1, str2));
        str2=str1;
        Console.Write(str2);
        Console.WriteLine(Object.ReferenceEquals(str1, str2));
    }
//Q15
/*
قارنت اخر حرف مع النقطة 
*/
    static void Endsperiod()
    { 
        string str1 = "Actions speak louder than words";
        if(str1[str1.Length-1]=='.')
        {
            Console.Write("true");
        }
        else
        {
            Console.Write("false");
        }
    }
//19
/*
استخدمت الفور للبدأ من اخر index  ثم حولت الحرف الى حرف كبير
*/
  static void Reverseuppercase()
    {
        string str1 = "php";
        string newstring="";
        for(int i=str1.Length-1;i>=0;i--)
        {
           newstring+= str1[i].ToUpper();
        }
        Console.Write(newstring);
    }
//22
   static void Stringreversetolower()
    {
        string str = "Rabab";
        string newstr="";
        for(int i=0;i<str.Length;i++)
        {
            if(char.IsUpper(str[i]))
            {
                newstring += char.ToLower(str[i]);
            }
            else
            {
                newstring += char.ToUpper(str[i]);
            }
        }
        Console.WriteLine(newstring);
    }
//Q23
/*
قسمت طول السلسلة على 2 حتى احصل على اندكس  من خلاله استطيع الوصول الى رقم الحرف الوسط في السلسلة الفردية 
وفي السلسة الزوجية نقصة قيمة الاندكس من الرقم الذ حصلت عليه لكي اصل الى الحرف الذي قبله

*/
    static void Centralcharacter()
{
        string str1 = "Rabab";
        string str2 = "";
        int n = (str1.Length) /2;
        for(int i=0;i<str1.Length;i++)
        {
         if(str1.Length%2==0)
         {
            if(i==n)
            {
                  str2 += str1[i-1];
                  str2 += str1[i];
            } 
         }
         else
            { 
               if(i==n)
              {
                  str2 += str1[i];
              } 
            }
        }
        Console.Write(str2);
}
//24
/*
حولت السترينك الى مصفوفة لكي اصل الى الارقام ثم فرضة اول الرقم هو الرقم الاكبر ثم قارنته مع بقية العناصر 
*/
static void MaxandMinimalnumber()
{
string numbers = "10 20 70 40 50";
string[] parts = numbers.Split(' ');
int[] nums = Array.ConvertAll(parts, int.Parse);
int max =nums[0];
int minimal = nums[0];
foreach (int n in nums)
{
    if(n>max)
    {
        max = n;
    }
    if(n<minimal)
    {
        minimal = n;
    }
    
}Console.WriteLine(minimal+" "+max);
}
//25
/*
سويت عداد لكي يحسبب عدد الاحرف المتكررة ثم شرط اذا العداد اكبر من واحد يعني توجد احرف متكررة
*/
    static void Isograms()
{
        string str1 = "JavaScript";
        bool n = false;
        int contr=0;
        for(int i=0 ;i<str1.Length;i++)
        { 
            if(str1.Count(c => c == str1[i])>1) 
            {
                 contr++;
            }
        } 
        if(contr>1){
             n=false;
        }
        else
        {
            n=true;
        }
        Console.Write(n);
}
//38
/*
ايجاد اطول كلمة بالسلسلة فرضت ان اول كلمة هي الاطول ثم حفظهتها بمتغير لأقرنها مع بقية الكلمات
*/
    static void Longestword()
    {
       
        string[] str = {"abc", "abcd", "abcdef", "pqrstuv"};
        string longest= str[0];
        for(int i=1;i<str.Length;i++)
        {
             if(str[i].Length>longest.Length)
        {
            longest=str[i];
            
        }
        }Console.Write(longest);
        if(str.Length==0)
        {
            Console.Write("Empty array!");
        }
        
    }
//39
/*
لايجاد القرن لسنة معينة جمعة السنة مع 99 ثم قسمتهن على 100 
*/
  static void Century() {
      Console.Write("Enter year: ");
      int year = Convert.ToInt32(Console.ReadLine());
      int century = (year + 99)/100;
      Console.WriteLine(century);
  }
//Q41
/*
حولت الحروف الى الارقام بأستخدام int 
*/
  static void ConvertsASCII()
    {
        Console.Write("enter String : ");
        string str = Console.ReadLine();
        for(int i=0;i<str.Length;i++)
         {
           int ASCII= (int)str[i];
           Console.Write(" " +ASCII);
         }
    }
static void Main(string[] args)
    {
       Demonstrate();
       Culturr();
       Concatenatestring();
       Concatenatearraystring();
       Longest();
       Objectreferences();
       Endsperiod();
       Reverseuppercase();
       Longestword();
       Century();
       ConvertsASCII();
       Stringreversetolower();
       Centralcharacter();
       MaxandMinimalnumber();
       Isograms();

    }
}
