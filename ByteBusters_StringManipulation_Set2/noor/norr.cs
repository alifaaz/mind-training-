
using System.IO;

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


    }





