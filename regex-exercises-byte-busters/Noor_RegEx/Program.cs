

using System;
using System.Text.RegularExpressions;


class program
{
    // Q1// استخرج ارقام محليه استخدم ان هي تبدبا ارقام 0790 وتنتهي برقم 7

    static void Main(string[] args)
    {


        Regex reg = new Regex(@"0790\d {7}");

        string text = " my number is 07901234567";

        Match match = reg.Match(text);
        if (match.Success)
        {

            Console.WriteLine("matched number+match .value");

        }
        else
        {
            Console.WriteLine("no voild number");



        }

    }
    //q2 //استخدمت ان يكون بدايه سطر حرؤف كبير اوصغير او تحتوي على ارقام او رموز خاصه اويكون طوله 8
    static void Main()

    {
        Regex reg = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*]).{8,}$");

        string password = "MyStrong@123";

        if (reg.IsMatch(password))
        {
            Console.WriteLine("Strong password.");
        }
        else
        {
            Console.WriteLine("Weak password.");
        }
    }


//q3//   او اذاكانت  حرف كبير او صغير  b \بدايه اونهايه استخدمت 


    static void Main()
    {

        Regex reg = new Regex("@\b[A-Z][a-z]*\b");

        string text = "Ali went to Basra and met Noor";

        MatchCollection mathes = reg.Matches(text);

        if (mathes.Count > 0)
        {

            Console.WriteLine("Matched proper Nouns:");

            foreach (Match match in mathes)
            {

                Console.WriteLine(match.Value);


            }
        }
        else
        {
            Console.WriteLine("No proper");


        }

    }






    //q4//ي رقم 0-9 /d يكون واحد اواكثر اي عدد
    //استخدمت matchcollection  يعني هي قائم فيها كل ارقام

    static void Main()
    {
        // Regex لمطابقة جميع الأرقام
        Regex reg = new Regex(@"\d+");

        string text = "I have 2 cats and 10 chickens.";

        MatchCollection matches = reg.Matches(text);

        if (matches.Count > 0)
        {
            Console.WriteLine("Found numbers:");
            foreach (Match match in matches)
            {
                Console.WriteLine("- " + match.Value);
            }
        }
        else
        {
            Console.WriteLine("No numbers .found");

        }
    }

    //q5


    static void Main()
    {

        Regex reg = new Regex(@"\#/w+");

        string text = ("#/w+");

        Console.WriteLine(reg.IsMatch(text));

        //استخرج كلمات التي تحتوي#
    }



    //q6
    //الكود يبحث عن كلمات تنتهي بـ "ing" في النص ويطبعها. يستخدم Regex يطابق بداية كلمة، أي حروف قبل "ing"، ثم نهاية الكلمة

    static void Main()
    {
        string text = "I am coding, running, and learning.";

        Regex reg = new Regex(@"\b\w+ing\b");

        MatchCollection matches = reg.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine("  Word ends ing: " + match.Value);
        }
    }






    //q7
    //رمز الدولار(يحتاج الهروب \ لأنه رمز خاص)

    //+ رقم واحد أو أكثر
    //\.\d{ 1,2})?  نقطة عشرية مع رقم أو رقمين(اختياري)

    static void Main()
    {
        string text = "I spent $100 on food and $29.99 on drinks.";

        Regex reg = new Regex(@"\$\d+(\.\d{1,2})?");

        MatchCollection matches = reg.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine("  moneymatch.Value");
        }
    }

     











    //q8 //رقمين للساعات /d نقطتين/رقمين للساعات للدقيقتن
    static void Main()
    {
        string text = "The meeting is at 12:30.";

        Regex reg = new Regex(@"\d{2}:\d{2}");

        Match match = reg.Match(text);

        if (match.Success)
            Console.WriteLine(" time: " + match.Value);
        else
            Console.WriteLine(" no time  .");
    }


//q9 //  استخراج  4 أرقام للسنه /d رقمين شهرين /d{} رقمين لليوم /d{}
static void Main()
    {
        string text = "Today is 2025-07-10.";

        Regex reg = new Regex(@"\d{4}-\d{2}-\d{2}");

        Match match = reg.Match(text);

        if (match.Success)
            Console.WriteLine(" date: " + match.Value);
        else
            Console.WriteLine(" no  date.");
    }



    //q10لكود يبحث عن كلمات تبدأ بـ "un" ويطبعها من النص.

//w*→ أي عدد من الحروف أو الأرقام بعد un(بما في ذلك 0)

    static void Main()
    {
        string text = "unknown, unhappy, unlocke, done";

        Regex reg = new Regex(@"\bun\w*");

        MatchCollection matches = reg.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine("Matched word: " + match.Value);
        }
    }







//يطابق كل كلمة فيها حروف كردية أو
//ربية ويطبعها من النص
//q12
static void Main()
    {
        string text = "ئەمە وشەیەکی کوردییە This is English.";

        Regex reg = new Regex(@"[\u0600-\u06FF]+");

        MatchCollection matches = reg.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine("كلمة كردية/عربية: " + match.Value);
        }
    }


    //q13//
    //استخدمت ايضا بدايه وحرف او ارقام او تتبد 4-12


    static void Main()
    {
        Regex reg = new Regex(@"^[a-zA-Z0-9]{4,12}$");

        string username = "Ali123";

        if (reg.IsMatch(username))
        {
            Console.WriteLine("Valid username.");
        }
        else
        {
            Console.WriteLine("Invalid username.");
        }

    }



    //q14//هذا الكود يبحث عن أي كلمة بين < > يعني كل وسوم الـHTML مثل <div> و</div> ويطبعهم.

    static void Main()
    {
        string text = "<div>Hello</div>";

        Regex reg = new Regex(@"<[^>]+>");

        var matches = reg.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine("وسم: " + match.Value);
        }
    }


  //q15   أي شيء ما عدا(نقطة، تعجب،//  استفهام)

//نتهي بعلامة استفهام

    static void Main()
    {
        string text = "How are you? Is this okay? I'm fine.";

        Regex reg = new Regex(@"[^.?!]*\?");

        MatchCollection matches = reg.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine("سؤال: " + match.Value.Trim());
        }
    }








    //17ستخدمت بدايه نقطه استخدمت يكون حرف صغير حروف كبيره
    //ستخدمت MatchCollection تجمع لي جميع احرف ارقام

    static void Main()
    {
        // Regex لاستخراج الامتدادات
        Regex reg = new Regex(@"\.[a-zA-Z0-9]+");

        string text = "photo.jpg, resume.pdf";

        MatchCollection matches = reg.Matches(text);

        if (matches.Count > 0)
        {
            Console.WriteLine("Found extensions:");
            foreach (Match match in matches)
            {
                Console.WriteLine("- " + match.Value);
            }
        }
        else
        {

            Console.WriteLine("No extensions found.");
        }
    }

    //18
      static void Main() { 
    
        // نمط يطابق 5 أرقام متبوعة بمسافة ثم حرف عربي
        Regex reg = new Regex(@"^\d{5}\s[\u0600-\u06FF]$");

        string text = "12345 ب";

        Console.WriteLine(reg.IsMatch(text));  // سيطبع True إذا صحيح، False إذا لا
    }





//q20   http and https بختصار الكود يبحث  عن اول رابط في النص

static void Main()
    {
        string text = "Visit https://halal.io today!";
        Regex reg = new Regex(@"https?://[^\s]+");

        Match match = reg.Match(text);

        if (match.Success)
            Console.WriteLine(" link: " + match.Value);
        else
            Console.WriteLine(" no link.");
    }







//q21//regex فيها حرف صغير  كبير رمز خاص طولها من8او اكثر
static void Main()
{
    string password = "Strong@123";

    Regex reg = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$");

    if (reg.IsMatch(password))
    {
        Console.WriteLine("stroing password");
    }
    else
    {
        Console.WriteLine("weak password");
    }
}

//q22
    static void Main()
    {
        // نمط يطابق الإيموجي الأساسية
        Regex reg = new Regex(@"[\u2600-\u27BF\u1F600-\u1F64F]");

        string text = "Here is a smile 😀 and a heart ❤️.";

        MatchCollection matches = reg.Matches(text);

        if (matches.Count > 0)
        {
            Console.WriteLine("Matched Emojis:");
            foreach (Match match in matches)
            {
                Console.WriteLine("- " + match.Value);
            }
        }
        else
        {
            Console.WriteLine("No emojis found.");
        }
    }







    //q23//الـRegex يتأكد أن عنوان IP فيه 4 //أرقام مفصولة بنقا، وكل رقم بين 0 و255.

    static void Main()
    {
        // Regex يتحقق من شكل IP (الأرقام من 0 إلى 255)
        Regex reg = new Regex(@"^((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)\.){3}(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)$");

        string text = "192.168.0.1";

        if (reg.IsMatch(text))
        {
            Console.WriteLine("عنوان IP صالح.");
        }
        else
        {
            Console.WriteLine("عنوان IP غير صالح.");
        }
    }




    //q24
    static void Main()
    {
        // Regex لمطابقة مراجع الآيات
        Regex reg = new Regex(@"\b\d+:\d+\b");

        string text = "See 2:255 for Ayat al-Kursi";

        MatchCollection matches = reg.Matches(text);

        if (matches.Count > 0)
        {
            Console.WriteLine("Found surah references:");
            foreach (Match match in matches)
            {
                Console.WriteLine("- " + match.Value);
            }
        }
        else
        {
            Console.WriteLine("No surah references found.");
        }
    }

    //حد الكلمة\d+ رقم واحد أو أكثر (رقم السوره

    //+d قم واحد أو أكثر(رقم الآية   





    //q25//الكود يكتشف الحروف المكررة مثل "oooo" أو "ssss" ويطبعها من النص

    static void Main()
    {
        string text = "loooool, yessss";

        Regex reg = new Regex(@"(\w)\1+");

        MatchCollection matches = reg.Matches(text);

        if (matches.Count > 0)
        {
            Console.WriteLine("Found repeated characters:");
            foreach (Match match in matches)
            {
                Console.WriteLine("- " + match.Value);
            }
        }
        else
        {
            Console.WriteLine("No repeated characters found.");
        }
    }




//q27
static void Main() { 


        string text = "هذه بداية السورة: بسم الله الرحمن الرحيم ثم تلاوة الآيات.";

    Regex reg = new Regex(@"بسم الله الرحمن الرحيم");

    Match match = reg.Match(text);

        if (match.Success)
        {
            Console.WriteLine("وجدنا البسملة: " + match.Value);
        }
        else
{
    Console.WriteLine("لم يتم العثور على البسملة.");
}
    }






    //q28  
    static void Main()
    {
        // Regex لمطابقة رقم IBAN يبدأ بـ IQ
        // {2}/d   رقمين
       //{  { 1130}
        Regex reg = new Regex(@"^IQ\d{2}[A-Z0-9]{11,30}$");

        string text = "IQ44NBIQ123456789012345";

        Match match = reg.Match(text);

        if (match.Success)
        {
            Console.WriteLine("Matched IBAN Number");
        }
        else
        {
            Console.WriteLine("No IBAN Number found.");
        }
    }








    //q29 // بدايه معرفv  احرف  صغيره احرف كبيره ارقام شزطة-
    //شرطيه سفليه

    static void Main()
    {


        string text = "https://www.youtube.com/watch?v=abc123xyz";

        Regex reg = new Regex(@"v=([a-zA-Z0-9_-]+)");

        Match match = reg.Match(text);

        if (match.Success)
        {
            string videoId = match.Groups[1].Value;
            Console.WriteLine("YouTube Video ID: " + videoId);
        }
        else
        {
            Console.WriteLine("No video ID found.");
        }

    }




//q30

    static void Main()
    {
        string text = "{ \"name\": \"Ali\", \"age\": \"30\" }";

        // Regex لاستخراج أول زوج مفتاح-قيمة
        Regex reg = new Regex(@"""([^""]+)""\s*:\s*""([^""]+)""");

        Match match = reg.Match(text);

        if (match.Success)
        {
            string key = match.Groups[1].Value;
            string value = match.Groups[2].Value;
            Console.WriteLine($"{key}: {value}");
        }
        else
        {
            Console.WriteLine("No key-value pair found.");
        }
    }
  }

//([^"]+)"\s*:\s*"([^"]+)"

//مجموعة رقم 1: ([^"]+) هذه تطابق المفتاح (key)

//مجموعة رقم 2: ([^"]+) هذه تطابق القيمة// (value)























