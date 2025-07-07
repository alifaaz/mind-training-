
using System.IO;
using System.Text.RegularExpressions;

class program
{

    // داله تدل على حرؤف متكرر
    static string GetRepeatedcharacters(string input)
    {

        string repeated = "";

        return repeated;

    }
    //q2
    // استخدم داله نعكس 
    static string countReversedcharcters(string input)
    {

        string reversed = new

         string(input.Reverse().ToArray());

        return reversed;

    }
    //بحث حروف صوتيه في سلسله
    static string GetlengthAsString(string input)
    {
        return input.Length.ToString();
    }

    //داله تحقيق اذا كانت سلسله نصيه نفسها في جهتين

    static string CompareCharacters()
    {
        string a = "noor";
        string b = "noor";

        if (a == b)
        {
            return "True";
        }
        else
        {
            return "False";
        }
    }


    //خول سلسه ال حرف كبيره
    static string convertToUpper(string input)
    {
        return input.ToUpper();
    }

    // الى حرف صغيره
    static string convertToLower(string input)
    {
        return input.ToLower();
    }

    //سلسله تبدي بدايه معينه
    static string CheckStart(string input, string start)
    {

        if (input.StartsWith(start))
        {
            return input;

        }
        else
        {
            return input;
        }

    }
    //سلسه تنتهي بنهايه معينه
    static string CheckEnd(string input, string end)
    {

        if (input.EndsWith(end))
        {
            return input;

        }
        else
        {
            return input;
        }

    }

    // تحقيق يتحوي على ارقام
    static bool IsAllDigits(string input)

    {
        return input.All(c => char.IsDigit(c));
    }


    //تحقيق يحتوي على نص
    static bool IsAlletter(string input)
    {
        return input.All(c => char.IsLetter(c));
    }

    //اةل حرف كابتل
   static string CapitalizeFirstCharacter(string input)
    {
        if (string.IsNullOrEmpty(input)) ;


        return char.ToUpper(input[0]) + input.Substring(1);
    }


    //تحول سلسله الى كلمات
    static string[] splitCharacter(string input)
    {
        return input.Split(' ');
    }




    //تحويل كلمات الى سلسه
    static string joinwords(string[] words)

    {
        return string.Join(" ", words);
    }


    //حذف الفراغات من بدايه ونهايه سلسله
     static string RemoveStartEndspaces(string input)
    {
        return input.Trim ();
    }


    //تحقيق اذا سلسله بصيغه بريد الكتروني
    static string CheckEmailAddress(string email)
    {
        if (email.Contains("@"))
        {
            return email;
        }

        else { return email; }
    }

    //استبدال الفواصل 


  static string ReplecCommaswithSemicolons(string input )
    {
        return input.Replace(";", ",");
}


    //حول جملهالى قاىم رموز
    static string ConvertToAscii(string input)
    {
        string result = "";
        foreach (char c in input)
        {
            result += ((int)c).ToString() + " ";
        }
        return result.Trim();
    }
    //  استخراج امتداد الملف من اسمه
    static string GetFileExtension(string filename)
    {
        int i = filename.LastIndexOf('.');

        if (i == -1)
            return ""; // ماكو نقطة يعني ماكو امتداد

        return filename.Substring(i + 1);
    }

   


    //تريد تحول الى نص جديد بدون شرطات سلفيه بدايه كل كلمه يكون اؤل حرف كبير
    static string SnakeToCamel(string input)
{
    var parts = input.Split('_');
    string result = parts[0];         

    for (int i = 1; i<parts.Length; i++)   
    {
        if (parts[i].Length > 0)               
            result += char.ToUpper(parts[i][0]) + parts[i].Substring(1);
}

return result;                   
}

    // احسب عدد الكلمات المكتوبه باحرف الكبير مطلوب حساب حرف كبيره بين الكلمات 
    static  int CountCapitaLleters(string input)
    {
        int count= 0;
        foreach (char c in input)
        {
            if (!char.Isupper(c)) count++;
            {
                return count;
            }
        }
    }

    //استخراج ارقام الهاتفه من جمله
    static string ExtractphoneNumber(string input)
    {

        string number = "";

        foreach (char c in input) { if (!char.IsUpper(c))   number += c; }
        return number;
    


    
        //حسب مافهمت استبدل ايمونجي بدل احرف 
        static string ReplaceEmojiwithArabic(string input)
        {
            string result = "";

            foreach( char c in input)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    result += '';
                }
                else {
                    result += c;
                }
            }
            return result;
        }

    //حذف حرؤف الصوتيه من سلسه
        static string Removevowels(string input)

        {
            string result = '';

            string vowels = "aeiouAEIou";

            foreach (char c in input)
            {
                if (vowels.Contains(c))
                {
                    result += c;

                }

                return result;
            }
        }
      //  استخراج اشاره من نص

        static string ExtractMentions(string input)
        {
            string[] words = input.Split(' ');

            foreach (string word in words)
            {
                if (word.StartsWith("@"))
                {
                    return word;
                }
            }
        }

        //منالربط  استخرج رمز فيديو

        static string ExtractYouTubeVideoId(string url)
        {
            int index = url.IndexOf("v=");

            if (index == -1)
                return "";

            string id = url.Substring(index + 2);
            int amp = id.IndexOf('');

            if (amp != -1)
                id = id.Substring(0, amp);

            return id;
        }

        ‏𝓝𝓞𝓞𝓡 َِٰٰ.'❥, [7/7/2025 5:41 PM]
static string ExtractYouTubeVideoId(string url)
        {
            int index = url.IndexOf("v=");

            if (index == -1)
                return "";

            string id = url.Substring(index + 2);
            int amp = id.IndexOf('&');

            if (amp != -1)
                id = id.Substring(0, amp);

            return id;
        }
 

       // شفره رساله مستخدم
static string CaesarEncrypt(string input)
        {
            int key = 26;  
            string cipher = "";

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    cipher += (char)(((c - offset + key) % 26) + offset);
                }
                else
                {
                    cipher += c;
                }
            }

            return cipher;
        }


       //  فك تشفير

        static string CaesarDecrypt(string input, int key)
        {
            string result = "";

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    result += (char)(((c - offset - key + 26) % 26) + offset);
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }



        //استخرج الوسوم من النص ورتبها ترتيب ابجدي
        static string ExtractAndsoethashtags (string input)
        {
            
{
                string[] words = input.Split(' ');


                foreach (string word in words)
                {
                    if (word.StartsWith("#"))
                    {
                        hashtags.Add(word);
                    }
                }

                hashtags.Sort();

                foreach (string tag in hashtags)
                {
                    return;
                }
            }
        }

        //اكتشف عن اسلئه داخل الفقرة

        static  string  DetectQuestions(string input)
        { 
            string[] sentences = input.Split('.');

            foreach (string sentence in sentences)
            {
                if (sentence.Contains("?"))
                {
                      return sentence;
                }
            }
        }

        // قطع بريدنص بعد سطر التوقيع

        static string TruncateAfterSignature(string email)
        {
            int index = email.IndexOf("--");
            if (index == -1)
            {
                return email;
            } 

            
        }

        //طابق تاريخ بنماط مختلفه 

        static string MatchDates(string text)
        {
            string pattern = " ";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                return .Match;
            }
        }
        // استخرج بيانات مفصوله بفواصل منقوطه

        static void ExtractData(string input)
        {
            string[] fields = input.Split(';');

            foreach (string field in fields)
            {
                return
            }
        }


        //صنف السطركعنوان او فقره

        static string ClassifyLine(string line)
        {
            line = line.Trim();

            if (line.Length < 40 && char.IsUpper(line[0]))
            {
                return "Header";
            }
            else
            {
                return "Paragraph";
            }
        }
        //وسم اسماء المنتجات في مراجعه

        static string TagProductNames(string review.string products)
        {
            foreach (string product in products)
            {
                review = review.Replace;
            }
            return review;
        }
