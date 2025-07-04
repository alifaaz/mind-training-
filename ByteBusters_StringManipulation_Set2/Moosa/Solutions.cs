using System;


namespace StringsTrainings
{
   public class Solutions
    {
        //دالة تحسب عدد تكرار كلمة معينة
        //نوزع الكلمات بمصفوفة وباستخدام اللوب نفحص الكلمات الي تشبه الكلمة المراد معرفة تكرارها
        public static int WordApearingCounts(String word,String sentence)
        {
            if (word == null|| sentence==null)
                throw new ArgumentNullException(nameof(word));

            String[] wordsAfterSplit;
            wordsAfterSplit = sentence.Split(' ');
            int count=0;
            foreach (String str in wordsAfterSplit)
            {
                if (str == word)
                    count++;
            }
            return count;
        }

        //دالة تحول كل حروف الكلمة الى حروف كبيرة
        public static String ConvertToUpperCase(String word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";

           else return word.ToUpper();
        }

        //دالة تحول كل حروف الكلمة الى حروف صغيرة
        public static String ConvertToLowerCase(String word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";

            return word.ToLower();
        }

        //دالة لفحص اذا كانت الكلمة او الجملة تبدأ بحرف او كلمة معينة
        public static bool IsStartsWith(String word,String sentance)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");
            
            return sentance.StartsWith(word) ? true : false;
        }

        //دالة لفحص اذا كانت الكلمة او الجملة تنتهي بحرف او كلمة معينة
        public static bool IsEndsWith(String word,String sentance)
        {
            if (word == null||sentance==null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");

            return sentance.EndsWith(word) ? true : false;
        }

        //دالة للتحقق مما إذا كانت السلسلة تحتوي فقط على أرقام
        public static bool IsContainOnlyDigits(String word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");

            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsDigit(word[i]))
                    count++;
            }
            if (count == word.Length)
                return true;
            else return false;
        }

        //دالة للتحقق مما إذا كانت السلسلة تحتوي فقط على حروف
        public static bool IsContainOnlyLetters(String word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");

            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsLetter(word[i]))
                    count++;
            }
            if (count == word.Length)
                return true;
            else return false;
        }

        //دالة لتحويل الحرف الاول من الكلمة الى حرف كبير
        public static String CapitalizeFirstLetter (String word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";

            else
            return word.ToUpper()[0] + word.Substring(1);

        }

        //دالة لتبديل حالة كل حرف, الكبير الى صغير وبالعكس
        public static String ChangeLetterCase (String word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";
            else
            {
                String word2 = "";
                for (int i = 0; i < word.Length; i++)
                {
                    //فحص اذا كان الحرف كبير يتم تحويله الى حرف صغير وبالعكس
                    word2 += char.IsUpper(word[i]) ? char.ToLower(word[i]) : char.ToUpper(word[i]);
                }
                return word2;
            }

        }

        //دالة لتقسيم السترنك الى كلمات منفصلة
        public static void SplitString (String sentance)
        {
            if (sentance == null)
                throw new ArgumentNullException(nameof(sentance));

            //safety check
            if (IsOnlyWhiteSpaces(sentance))
                Console.WriteLine("You must type some word");

            String[] wordsAfterSplit = sentance.Split(' ');
            
            foreach (String str in wordsAfterSplit)
            {
                Console.WriteLine(str);
            }
        }  

        //دالة لتحويل الكلمات الى سلسلة واحدة
        public static void JoinString(String[] words)
        {
            if (words == null)
                throw new ArgumentNullException(nameof(words));

            Console.WriteLine(String.Join(" ", words));

        }

        //دالة لازالة الفراغات من بداية ونهاية الكلمة
        public static String RemoveWhiteSpaces (String word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");

            return word.Trim();
        }

        //دالة لمعرفة عدد الفراغات الموجودة بالجملة
        public static int NumberOfSpaces (String sentance)
        {
            if (sentance == null)
                throw new ArgumentNullException(nameof(sentance));

            int count = 0;
            for (int i = 0; i < sentance.Length; i++)
            {
                //فحص كل حرف اذا كان يساوي فراغ يتم زيادة العداد
                if (sentance[i] == ' ')
                    count++;
            }
            return count;
        }

        //دالة لطباعة اول خمسة حروف
        public static String GetFirst5Char(String word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";

            return word.Length <= 5 ? word : word.Substring(0, 5);
        }

        //دالة لطباعة اول خمسة حروف
        public static String GetLast3Char(String word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");

            return word.Length <= 3 ? word : word.Substring(word.Length - 3);
        }

        //دالة لاتستبدال الفاصلة بالفاصلة المنقوطة
        public static String ReplaceCommasWithSemicolons(String word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";

            return word.Replace(",", ";");
        }

        //دالة لمعرفة اذا كانت كلمتين لديهما نفس الحروف بترتيب مختلف
        public static bool AreAnagrams(string word1, string word2)
        {
            if (word1 == null || word2 == null)
                throw new ArgumentNullException(nameof(word1));

            //safety check
            if (IsOnlyWhiteSpaces(word1)&& IsOnlyWhiteSpaces(word2))
                Console.WriteLine("You must type some word");

            if (word1.Length != word2.Length) return false;

            char[] ConvertedWord1 = word1.ToLower().ToCharArray();
            char[] ConvertedWord2 = word2.ToLower().ToCharArray();

            Array.Sort(ConvertedWord1);
            Array.Sort(ConvertedWord2);

            for (int i = 0; i < ConvertedWord1.Length; i++)
                if (ConvertedWord1[i] != ConvertedWord2[i]) return false;

            return true;
        }

        //دالة لاستخراج الارقام من السلسلة
        public static String FindDigits (String word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");

            String result = "";
            foreach (char check in word)
                if (char.IsDigit(check))
                    result += check;
            return result;
        }

        //دالة لاستخراج الارقام من السلسلة
        public static String FindLetters(String word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";

            String result = "";
            foreach (char check in word)
                if (char.IsLetter(check))
                    result += check;
            return result;
        }

        //دالة لاخفاء البريد الالكتروني
        public static String MaskEmail(String email)
        {
            if (email == null)
                throw new ArgumentNullException(nameof(email));

            //safety check
            if (!email.Contains("@")|| !email.Contains("."))
                return "You must type email";

            int IndexOfat = email.IndexOf('@');
            if (IndexOfat <= 1) return email;

            String first = email.Substring(0, 1);
            String masked = new String('*', IndexOfat - 1);
            String last = email.Substring(IndexOfat);

            return first + masked + last;
        }

        //دالة لتحويل الحروف الى اسكي كود
        public static String ConvertToASCII (String word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";

            String result="";
            foreach(char check in word)
            {
                //حتى لا يحول الفراغ للاسكي كود
                if(check!=' ')
                result += Convert.ToInt32(check)+" ";
            }
            return result;
        }

        //دالة لحذف الكلمات المكررة
        public static String RemoveDuplicateWords(String sentence)
        {
            if (sentence == null)
                throw new ArgumentNullException(nameof(sentence));

            //safety check
            if (IsOnlyWhiteSpaces(sentence))
                return "You must type some word";

            String result = "";
            String[] words = sentence.Split(' ');

            foreach (String word in words)
                //يفحص اذا الكلمة غير موجودة يضيفها
                if (!result.Contains(word))
                    result += word + " ";

            return result.Trim();
        }

        //دالة لاستخراج الامتداد من اسم الملف
        public static String ExtractExtension(String fileName)
        {
            if (fileName == null)
                throw new ArgumentNullException(nameof(fileName));

            //safety check
            if (IsOnlyWhiteSpaces(fileName))
                return "You must type some word";

            if (!fileName.Contains("."))
                return "is not a file";
            else return fileName.Substring(fileName.IndexOf(".") + 1);

        }

        //دالة لتبديل السطر الى فراغ بين الكلمات
        public static String ReplaceNewlinesWithSpaces(String sentance)
        {
            if (sentance == null)
                throw new ArgumentNullException(nameof(sentance));

            //safety check
            if (IsOnlyWhiteSpaces(sentance))
                return "You must type some word";

            return sentance.Replace("\n", " ");
        }

        //دالة لتغير شكل كتابة التاريخ
        public static String ConvertDateFrom (String date)
        {
            if (date == null)
                throw new ArgumentNullException(nameof(date));

            //safety check
            if (IsOnlyWhiteSpaces(date))
                return "You must type some word";

            return date.Substring(8, 2) + "/" + date.Substring(5, 2) + "/" + date.Substring(0, 4);
        }

        //دالة لمعرفة تكرار حرف معين في كلمة
        public static int LetterApearingCounts(char letter)
        {
            if (letter == null)
                throw new ArgumentNullException(nameof(letter));

            String word = "banana";
            int count = 0;
            foreach (char check in word)
            {
                if (check == letter)
                    count++;
            }
            return count;
        }

        //دالة لمعرفة اذا كانت توجد رموز
        public static bool IsContainsSpecialchar (String word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");

            int count = 0;
            
                foreach (char check in word)
                {
                    if (char.IsSymbol(check) && count != 1)
                        count++;
                }
            if (count == 1)
                 return true;
            else return false;
        }

        //دالة للتحويل من سنيك الى كمل
        public static String CovertSnakeToCamel (String sentance)
        {
            if (sentance == null)
                throw new ArgumentNullException(nameof(sentance));

            //safety check
            if (IsOnlyWhiteSpaces(sentance))
                return "You must type some word";

            string[] parts = sentance.Split('_');
            string result = parts[0];

            for (int i = 1; i < parts.Length; i++)
                if (parts[i].Length > 0)
                    result += char.ToUpper(parts[i][0]) + parts[i].Substring(1);

            return result;
        }

        //دالة للتحويل من كمل الى سنيك
        public static String CamelToSnake (String sentance)
        {
            if (sentance == null)
                throw new ArgumentNullException(nameof(sentance));

            //safety check
            if (IsOnlyWhiteSpaces(sentance))
                return "You must type some word";

            string result = "";
            foreach (char check in sentance)
            {
                if (char.IsUpper(check))
                    result += "_" + char.ToLower(check);
                else
                    result += check;
            }

            return result;
        }

        //دالة لتبديل الارقام بهاش
        public static String ReplaceDigitsWithHash(string word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";

            string result = "";

            foreach (char check in word)
                result += char.IsDigit(check) ? '#' : check;

            return result;
        }

        //دالة لحذف حروف العلة
        public static string RemoveVowels(string word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";

            string result = "";
            string vowels = "aeiouAEIOU";

            foreach (char c in word)
                if (!vowels.Contains(c))
                    result += c;

            return result;
        }

        //دالة لمعرفة اذا كان الادخال فراغ فقط
        public static bool IsOnlyWhiteSpaces (String word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            int count = 0;
            foreach(char check in word)
            {
                if(char.IsWhiteSpace(check))
                    count++;
            }
            if (count == word.Length)
                return true;

            else return false;
        }

        //دالة لتحويل الباينري الى دسمل
        public static int BinaryToDecimal(string binary)
        {
            if (binary == null)
                throw new ArgumentNullException(nameof(binary));

            //safety check
            if (IsOnlyWhiteSpaces(binary))
                Console.WriteLine("You must type some word");

            int result = 0;

            foreach (char c in binary)
            {
                result = result * 2 + (c == '1' ? 1 : 0);
            }

            return result;
        }

        //دالة لتحويل الدسمل الى باينري
        public static string DecimalToBinary(string number)
        {
            if (number == null)
                throw new ArgumentNullException(nameof(number));

            //safety check
            if (IsOnlyWhiteSpaces(number))
                return "You must type some word";

            int n = int.Parse(number);
            string result = "";

            if (n == 0) return "0";

            while (n > 0)
            {
                result = (n % 2) + result;
                n /= 2;
            }

            return result;
        }

        //دالة لكتابة بنمط اخر
        public static string CreatePattern(string word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";

            return string.Join("-", word.ToCharArray());
        }

        //دالة لاضافة فراغ بعد الفارزو
        public static string AddSpaceAfterComma(string sentence)
        {
            if (sentence == null)
                throw new ArgumentNullException(nameof(sentence));

            //safety check
            if (IsOnlyWhiteSpaces(sentence))
                return "You must type some word";

            return sentence.Replace(",", ", ");
        }

        //دالة لاقتطاع 10 حروف فقط
        public static string TrimOnly10char(string word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";

            return word.Length <= 10 ? word : word.Substring(0, 10);
        }

    }

}
