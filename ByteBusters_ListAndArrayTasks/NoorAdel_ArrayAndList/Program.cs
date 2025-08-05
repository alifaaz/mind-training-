using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {

        static void Main()
        {


            //    Createlist();
            //    Printlist();
            //    InsertList();
            //    CopyList();
            //    EvevList();
            //    Sumlist();
            //    Rotatleft();
            //    Startlist();
            //    ZipList();
            //    firstlist();
            //    Reverslist();
            //    Appendelist();
            //    Removelist();
            //    Stortlist();
            //    CommonElements();
            //    Summllist();
            //    Commalist();
            //ConvertTolowercase();
            //inexlist();
        //    Clearlist();
        //}



        //}

        //1
        //public static void Createlist()
        //{
        //    List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
        //    foreach (int i in list)


        //        Console.WriteLine(i);


        //}


        ////q2 طول 
        //public static void Printlist()
        //{
        //    List<int> list = new List<int>() { 10, 20, 30 };


        //    int length = list.Count;

        //    Console.WriteLine(" length of the list:" + length);
        //}


        ////q3 طبع اول واخر 
        //public static void firstlist()
        //{
        //    List<int> list = new List<int>() { 5, 10, 15, 20 };

        //    int First = list.First();
        //    Console.WriteLine(First);

        //    int End = list.Last();
        //    Console.WriteLine(End);

        //}


        //q4 اضافه عنصر 4

        //public static void Appendelist()
        //{
        //    List<int> klist = new List<int>() { 1, 2, 3, };

        //    klist.Add(4);
        //    foreach (int i in klist)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}


        //q5 حذف اول عنصر

        //public static void Removelist()
        //{
        //    List<int> list = new List<int>() { 1, 2, 3, };

        //    list.Remove(1);
        //    foreach (int i in list)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}



        ////q6 تترتيب  تصاعديا
        //public static void Stortlist()
        //{
        //    List<int> list = new List<int>() { 3, 2, 1, };

        //    list.Sort();
        //    foreach (int i in list)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        ////7 عكس
        //public static void Reverslist()
        //{

        //    List<int> list = new List<int>()
        //    { 3,2,1};

        //    list.Reverse();

        //    foreach (int i in list)
        //    {



        //        Console.WriteLine(i);
        //    }

        //}

        ////8 تحقيق 2من
        //public static void Checklist()
        //{
        //    List<int> list = new List<int>() { 1, 2, 3 };
        //    foreach (int i in list)
        //    {
        //        if (list.Contains(2))
        //        {
        //            Console.WriteLine("Number 2 exisits in the list.");
        //        }




        //    }
        //}


        ////q10
        //public static void inexlist()
        //{
        //    List<int> list = new List<int>() { 4,5,6};

        //    list.IndexOf(list[1]);
        //    Console.WriteLine(list[1]);

        //}



        //q13 مسح جميع عناصر
        //public static  void Clearlist()
        //{
        //    List<int> list = new List<int>() { 1,2, 3 };

        //    list.Clear();
        //    Console.WriteLine("list after clear:"+ string.Join(",",list));
        //    foreach (int i in list)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}


        //q14
        //public static void CopyList()

        //{

        //    List<int> mylist = new List<int>() { 1, 2, 3, };

        //    int copy = mylist.Count;

        //    foreach (int i in mylist)
        //    {

        //        Console.WriteLine(i);
        //    }
        //}








        //// q15  بدل من (1,2)ادرج
        //public static void InsertList()
        //{
        //    List<int> list = new List<int>() { 0, 1, 2 };

        //    list.Insert(2, 5);

        //    foreach (int i in list)
        //    {
        //        Console.WriteLine(i + " ");
        //    }

        //}

        //q16 delet even
        //public static void EvevList()

        //{

        //    List<int> list = new List<int>() { 1, 2, 3, 4 };


        //    list.RemoveAll(i => i % 2 == 0);
        //    foreach (int i in list)
        //    {



        //        Console.WriteLine(i);

        //    }
        //}

        //q17 list مجموع
        //public static void Sumlist()
        //{

        //    List<int> list = new List<int>() { 1, 2, 3 };

        //    int totalsum = 0;

        //    foreach (int i in list)
        //    {
        //        totalsum += i;
        //    }

        //    Console.WriteLine(totalsum);

        //}

        //q18 اجمع اكبر عنصر اصغر عنصر





        ////q20 حول سلسه مفصولة الئ قوائم
        //public static void Commalist()
        //{
        //    string input = "1,2,3";
        //    List<int> numbers = input.Split(',').Select(int.Parse).ToList();
        //    foreach (int number in numbers)
        //    {
        //        Console.WriteLine(number);
        //    }

        //}

        //    q21 تحول اول حرف بقائم الئ صغيره

        //    public static void ConvertTolowercase()
        //{
        //    List<string> input = new List<string>() { "Hi", "There" };
        //    for (int i = 0; i < input.Count; i++)
        //    {
        //        input[i] = input[i].ToLower();
        //    }
        //        Console.WriteLine("lowercas list:");
        //    foreach (var item in input)
        //    {
        //        Console.WriteLine(item);
        //    }

        //}







        //q26 استخدمت داله دمج zip
        //public static void ZipList()
        //{
        //    List<string> letters = new List<string>() { "a", "b" };
        //    List<int> numbers = new List<int>() { 1, 2 };

        //    var zipped = letters.Zip(numbers, (letter, number) => $"{letter} is of {number}");

        //    foreach (var item in zipped)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}


        //q29 عكس لليسار
        //public static void Rotatleft()
        //{
        //    List<int> list = new List<int>() { 1, 2, 3, 4 };

        //    int first = list[0];
        //    int secod = list[1];


        //    list.Remove(0);
        //    list.Remove(0);

        //    list.Add(first);
        //    list.Add(secod);


        //    Console.WriteLine("rotat left of the list :");


        //    foreach (int i in list)
        //    {
        //        Console.WriteLine(i + " ");
        //    }

        //}

        ////q30
        //public static void Startlist()
        //{


        //    List<string> list = new List<string>() { "apple", "banan" };

        //    char letter = 'a';
        //    int count = 0;
        //    foreach (string word in list)
        //    {
        //        if (word.StartsWith(letter.ToString()))
        //        {
        //            count++;
        //        }
        //    }
        //    Console.WriteLine("count  = " + count);



        //}


        //q36 دمج قائمتين
        //public static void Summllist()
        //{
        //    List<int> list1 = new List<int>() { 1, 3, 5 };
        //    List<int> list2 = new List<int>() { 2, 4, 6 };
        //    list1.AddRange(list2);
        //    foreach (int item in list1)
        //    {
        //        Console.WriteLine(item + " ");
        //    }
        //}

        //q37 اطبع عنصر مشترك

        //public static void CommonElements()
        //{
        //    List<int> list1 = new List<int>() { 1, 2, 3 };
        //    List<int> list2 = new List<int>() { 2, 3, 4 };

        //    var Common = list1.Intersect(list2);
        //    Console.WriteLine(Common);
        //    foreach (var item in Common)
        //    {
        //        Console.WriteLine(item);


        //    }


        //}











    }
}





















