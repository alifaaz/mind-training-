using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noor_CC_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                string str1 = "QRS";
                string str2 = "qrs";

                Console.WriteLine($"Comparing '{str1}' and '{str2}':");
                CompareStrings(str1, str2);

                Console.ReadLine();

                static void CompareStrings(string a, string b)
                {

                    if (a.ToUpper() == b.ToUpper())
                    {
                        Console.WriteLine("The strings are equal when capitalized? true");
                    }
                    else
                    {
                        Console.WriteLine("The strings are equal when capitalized? false");
                    }

                    if (String.Compare(a, b, true) == 0)
                    {
                        Console.WriteLine("The strings are equal when case is ignored? true");
                    }
                    else
                    {
                        Console.WriteLine("The strings are equal when case is ignored? false");
                    }
                }

            }
            // function داله تسوي مقارنه سلسلتين نصين string
            // عملت مقارنه نصوص toupper والحاله استخدمته compressing ثم استخدمت if وتقارن باستخدام true


            //q.5
            char ch1 = "xyz"[1];
            char ch2 = "XYZ"[1];

            Console.WriteLine(" CompaerOrdind(\"xzy\"[1],\"XZY\"[1]");


            Console.WriteLine($"CompareOrdinal(\"xyz\"[1], \"XYZ\"[1]):");
            int resultOrdinal = String.CompareOrdinal(ch1.ToString(), ch2.ToString());
            if (resultOrdinal == 0)
                Console.WriteLine($"'{ch1}' is equal to '{ch2}'");
            else if (resultOrdinal > 0)
                Console.WriteLine($"'{ch1}' is greater than '{ch2}'");
            else
                Console.WriteLine($"'{ch1}' is less than '{ch2}'");

            Console.WriteLine();

            Console.WriteLine($"Compare(\"xyz\"[1], \"XYZ\"[1]):");
            int resultCulture = String.Compare(ch1.ToString(), ch2.ToString());
            if (resultCulture == 0)
                Console.WriteLine("'{ch1}' is equal to '{ch2}'");
            else if (resultCulture > 0)
                Console.WriteLine("'{ch1}' is greater than '{ch2}'");
            else
                Console.WriteLine("'{ch1}' is less than '{ch2}'");
            //  هذا المقارنه تعمد الاعدادات الثقافيه مقارنه باستخدم// camaper حول لعد ممكن استخدمت  char قارن 
            //  ثم بعدها استخدمت if تم بيهم مقارنه


            //q4


            Console.WriteLine("Compare three versions of the letter I using different values of StringComparison.");
            Console.WriteLine("The current culture is " + CultureInfo.CurrentCulture.Name);

            string letter1 = "I";
            string letter2 = "i";
            string letter3 = "İ";

            Compare(letter1, letter2);
            Compare(letter1, letter3);
            Compare(letter2, letter3);
        }

        static void Compare(string a, string b)
        {
            Console.WriteLine($"\nComparing '{a}' and '{b}':");

            Console.WriteLine("CurrentCulture, IgnoreCase: " +
                string.Equals(a, b, StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine("InvariantCulture, IgnoreCase: " +
                string.Equals(a, b, StringComparison.InvariantCultureIgnoreCase));

            Console.WriteLine("Ordinal: " +
                string.Equals(a, b, StringComparison.Ordinal));

            Console.WriteLine("OrdinalIgnoreCase: " +
                string.Equals(a, b, StringComparison.OrdinalIgnoreCase));

            //سطر اول يطبع العنوان حتى المستخدم يعرف شنو البرنامج اطبع شنو اللثقافه نعرف3متغيراتتحوي على
            //حروف مختلفه تقارن حرفين حسب
            //الثقافه الحاليه
            //وتجاهل بين حروف كبيره والصغيره هنا يمكني استخدمه بطريقه ifصح اصير مطوله بس أسهل


            //q38

            {
                string[] words = { "abcd", "efgh", "ijkl", "mnop" };

                for (int i = 0; i < words.Length; i++)
                {
                    string newWord = Rearrange(words[i]);
                    Console.WriteLine($"{words[i]} --> {newWord}");
                }
            }

            static string Rearrange(string word)
            {
                if (word.Length < 4) return word;

                char[] rearranged = new char[4];
                rearranged[0] = word[2];
                rearranged[1] = word[0];
                rearranged[2] = word[3];
                rearranged[3] = word[1];

                return new string(rearranged);
            }
            //استخدمت مصفوفه سكينه داله اسمه rearrange تعيد ترتيب أحرف استخدمت for بعدها استخدمت دالة static بعدها استخدمت if
            //طولindex اكتب حدؤد اري



            //39
            {
                int year;

                Console.Write("Enter a year: ");
                year = Convert.ToInt32(Console.ReadLine());

                string century = GetCentury(year);

                Console.WriteLine($"{year} → {century}");
            }

            static string GetCentury(int year)
            {
                int centuryNumber = (year + 99) / 100;

                string suffix;
                if (centuryNumber % 100 >= 11 && centuryNumber % 100 <= 13)
                    suffix = "th";
                else if (centuryNumber % 10 == 1)
                    suffix = "st";
                else if (centuryNumber % 10 == 2)
                    suffix = "nd";
                else if (centuryNumber % 10 == 3)
                    suffix = "rd";
                else
                    suffix = "th";

                return centuryNumber + suffix + " century";
            }

            // يطلب من المستخدم يدخل
            // سنه ثم حسب ياقرن هذه السنه يمن خلل حساب رب فدقرن برنامج بعده يتم الحديديه st او
            // ht تم استخدام داله اسمه get century ؤيتم تحقيق من حالات الخاصه لضمان



            //q40



            Console.Write("أدخل النص: ");
            string text = Console.ReadLine();

            text = text.Replace(" ", "").ToLower();

            int[] count = new int[26];
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (c >= 'a' && c <= 'z')
                {
                    int index = c - 'a';
                    count[index]++;
                }
            }


            int max = 0;
            for (int i = 0; i < 26; i++)
            {
                if (count[i] > max)
                {
                    max = count[i];
                }
            }


            if (max <= 1)
            {
                Console.WriteLine("ماكو حروف مكررة.");
            }
            else
            {
                Console.Write("أكثر الحروف تكراراً: ");
                for (int i = 0; i < 26; i++)
                {
                    if (count[i] == max)
                    {
                        char letter = (char)(i + 'a');
                        Console.Write(letter + " ");

                    }
                }
            }

            // قمت بقراءة نص من المستخدم، ثم أزلت الفراغات وحولته إلى حروف صغيرة
            // أنشأت مصفوفة لحساب عدد مرات تكرار كل حرف من a إلى z
            //باستخدام حلقة for و if حسبت تكرار كل حرف ثم استخرجت أعلى تكرار
            //



            //36

            Console.Write("   text: ");
            string text = Console.ReadLine();

            Console.Write(" number: ");

            for (int i = 0; i < text.Length; i++)
            {
                char c = char.ToLower(text[i]);
                if (c >= 'a' && c <= 'z')
                {
                    int position = c - 'a' + 1;
                    Console.Write(position + " ");
                }
                //نقرا الجمله المستخدم باستخدام console readline نمر على كل حرف باستخدام for
                //نستخدم char towlower اذا الحرف بين aوz نحسب تريب


            }

            //q25
            string[] str = { "pathon", "PHP", "C#", "Javascript" };


            foreach (string word in str)
            {
                Console.WriteLine("Original string: " + word);
                Console.WriteLine("Check the said string is an 'isograms' or not! " + IsIsogram(word));
                Console.WriteLine();
            }
        }

        static bool IsIsogram(string text)
        {
            text = text.ToLower();

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];


                if (!char.IsLetter(c))
                    continue;

                for (int j = i + 1; j < text.Length; j++)
                {
                    if (c == text[j])
                        return false;

                }
            }

            return true;

        }
        //Isogram هو
        // بكلمه Python مختلف true
        //C# True



        //q19

        static void main()
        {
            ReverseAndUpper("php");
            ReverseAndUpper("java");
            ReverseAndUpper("abcd");

        }
        static void ReverseAndUpper(string text)
        {
            Console.WriteLine("Original string: " + text);


            string upper = text.ToUpper();


            string reversed = "";
            for (int i = upper.Length - 1; i >= 0; i--)
            {
                reversed += upper[i];
            }

            Console.WriteLine("Said string in uppercase: " + reversed);
            Console.WriteLine();

            //الدالة ReverseAndUpper تستقبل كلمة
            //نحولها إلى حروف كبيرة باستخدام Toupper.l
            // نستخدم for بالعكس حتى نعكس الكلمة.

            //نطبع الجملة الأصلية والنتيجة































        }
    }
    }   


    


