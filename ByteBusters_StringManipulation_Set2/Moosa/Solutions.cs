using System;


namespace StringsTrainings
{
    public class Solutions
    {
        //دالة تحسب عدد تكرار كلمة معينة
        //نوزع الكلمات بمصفوفة وباستخدام اللوب نفحص الكلمات الي تشبه الكلمة المراد معرفة تكرارها
        public static int WordApearingCounts(String word, String sentence)
        {
            try
            {
                String[] wordsAfterSplit;
                wordsAfterSplit = sentence.Split(' ');
                int count = 0;
                foreach (String str in wordsAfterSplit)
                {
                    if (str == word)
                        count++;
                }
                return count;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return 0;
            }
        }

        //دالة تحول كل حروف الكلمة الى حروف كبيرة
        public static String ConvertToUpperCase(String word)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";
            try
            {
                return word.ToUpper();
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";

            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";

            }
        }

        //دالة تحول كل حروف الكلمة الى حروف صغيرة
        public static String ConvertToLowerCase(String word)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";
            try
            {
                return word.ToLower();
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";

            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";

            }
        }

        //دالة لفحص اذا كانت الكلمة او الجملة تبدأ بحرف او كلمة معينة
        public static bool IsStartsWith(String word, String sentance)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");
            try
            {
                return sentance.StartsWith(word) ? true : false;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return false;
            }
        }

        //دالة لفحص اذا كانت الكلمة او الجملة تنتهي بحرف او كلمة معينة
        public static bool IsEndsWith(String word, String sentance)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");
            try
            {
                return sentance.EndsWith(word) ? true : false;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return false;
            }

        }

        //دالة للتحقق مما إذا كانت السلسلة تحتوي فقط على أرقام
        public static bool IsContainOnlyDigits(String word)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");
            try
            {
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
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return false;
            }

        }

        //دالة للتحقق مما إذا كانت السلسلة تحتوي فقط على حروف
        public static bool IsContainOnlyLetters(String word)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");
            try
            {
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
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return false;
            }

        }

        //دالة لتحويل الحرف الاول من الكلمة الى حرف كبير
        public static String CapitalizeFirstLetter(String word)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";
            try
            {
                return word.ToUpper()[0] + word.Substring(1);
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لتبديل حالة كل حرف, الكبير الى صغير وبالعكس
        public static String ChangeLetterCase(String word)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";
            try
            {
                String word2 = "";
                for (int i = 0; i < word.Length; i++)
                {
                    //فحص اذا كان الحرف كبير يتم تحويله الى حرف صغير وبالعكس
                    word2 += char.IsUpper(word[i]) ? char.ToLower(word[i]) : char.ToUpper(word[i]);
                }
                return word2;
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }

        }

        //دالة لتقسيم السترنك الى كلمات منفصلة
        public static void SplitString(String sentance)
        {
            //safety check
            if (IsOnlyWhiteSpaces(sentance))
                Console.WriteLine("You must type some word");
            try
            {
                String[] wordsAfterSplit = sentance.Split(' ');

                foreach (String str in wordsAfterSplit)
                {
                    Console.WriteLine(str);
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }

        }

        //دالة لتحويل الكلمات الى سلسلة واحدة
        public static void JoinString(String[] words)
        {
            try
            {
                Console.WriteLine(String.Join(" ", words));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }

        //دالة لازالة الفراغات من بداية ونهاية الكلمة
        public static String RemoveWhiteSpaces(String word)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");
            try
            {
                return word.Trim();
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }

        }

        //دالة لمعرفة عدد الفراغات الموجودة بالجملة
        public static int NumberOfSpaces(String sentance)
        {
            try
            {
                int count = 0;
                for (int i = 0; i < sentance.Length; i++)
                {
                    //فحص كل حرف اذا كان يساوي فراغ يتم زيادة العداد
                    if (sentance[i] == ' ')
                        count++;
                }
                return count;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return 0;
            }
        }

        //دالة لطباعة اول خمسة حروف
        public static String GetFirst5Char(String word)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";
            try
            {
                return word.Length <= 5 ? word : word.Substring(0, 5);
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لطباعة اول خمسة حروف
        public static String GetLast3Char(String word)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");
            try
            {
                return word.Length <= 3 ? word : word.Substring(word.Length - 3);
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لاتستبدال الفاصلة بالفاصلة المنقوطة
        public static String ReplaceCommasWithSemicolons(String word)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";
            try
            {
                return word.Replace(",", ";");
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لمعرفة اذا كانت كلمتين لديهما نفس الحروف بترتيب مختلف
        public static bool AreAnagrams(string word1, string word2)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word1) && IsOnlyWhiteSpaces(word2))
                Console.WriteLine("You must type some word");
            try
            {
                if (word1.Length != word2.Length) return false;

                char[] ConvertedWord1 = word1.ToLower().ToCharArray();
                char[] ConvertedWord2 = word2.ToLower().ToCharArray();

                Array.Sort(ConvertedWord1);
                Array.Sort(ConvertedWord2);

                for (int i = 0; i < ConvertedWord1.Length; i++)
                    if (ConvertedWord1[i] != ConvertedWord2[i]) return false;

                return true;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return false;
            }
        }

        //دالة لاستخراج الارقام من السلسلة
        public static String FindDigits(String word)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");
            try
            {
                String result = "";
                foreach (char check in word)
                    if (char.IsDigit(check))
                        result += check;
                return result;
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لاستخراج الحروف من السلسلة
        public static String FindLetters(String word)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";
            try
            {
                String result = "";
                foreach (char check in word)
                    if (char.IsLetter(check))
                        result += check;
                return result;
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لاخفاء البريد الالكتروني
        public static String MaskEmail(String email)
        {
            //safety check
            if (!email.Contains("@") || !email.Contains("."))
                return "You must type email";
            try
            {
                int IndexOfat = email.IndexOf('@');
                if (IndexOfat <= 1) return email;

                String first = email.Substring(0, 1);
                String masked = new String('*', IndexOfat - 1);
                String last = email.Substring(IndexOfat);

                return first + masked + last;
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لتحويل الحروف الى اسكي كود
        public static String ConvertToASCII(String word)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";
            try
            {
                String result = "";
                foreach (char check in word)
                {
                    //حتى لا يحول الفراغ للاسكي كود
                    if (check != ' ')
                        result += Convert.ToInt32(check) + " ";
                }
                return result;
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لحذف الكلمات المكررة
        public static String RemoveDuplicateWords(String sentence)
        {
            //safety check
            if (IsOnlyWhiteSpaces(sentence))
                return "You must type some word";
            try
            {
                String result = "";
                String[] words = sentence.Split(' ');

                foreach (String word in words)
                    //يفحص اذا الكلمة غير موجودة يضيفها
                    if (!result.Contains(word))
                        result += word + " ";

                return result.Trim();
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لاستخراج الامتداد من اسم الملف
        public static String ExtractExtension(String fileName)
        {
            //safety check
            if (IsOnlyWhiteSpaces(fileName))
                return "You must type some word";
            try
            {
                if (!fileName.Contains("."))
                    return "is not a file";
                else return fileName.Substring(fileName.IndexOf(".") + 1);
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لتبديل السطر الى فراغ بين الكلمات
        public static String ReplaceNewlinesWithSpaces(String sentance)
        {
            //safety check
            if (IsOnlyWhiteSpaces(sentance))
                return "You must type some word";
            try
            {
                return sentance.Replace("\n", " ");
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لتغير شكل كتابة التاريخ
        public static String ConvertDateFrom(String date)
        {
            //safety check
            if (IsOnlyWhiteSpaces(date))
                return "You must type some word";
            try
            {
                return date.Substring(8, 2) + "/" + date.Substring(5, 2) + "/" + date.Substring(0, 4);
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لمعرفة تكرار حرف معين في كلمة
        public static int LetterApearingCounts(char letter)
        {
            try
            {
                String word = "banana";
                int count = 0;
                foreach (char check in word)
                {
                    if (check == letter)
                        count++;
                }
                return count;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return 0;
            }
        }

        //دالة لمعرفة اذا كانت توجد رموز
        public static bool IsContainsSpecialchar(String word)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");
            try
            {
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
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return false;
            }
        }

        //دالة للتحويل من سنيك الى كمل
        public static String CovertSnakeToCamel(String sentance)
        {
            //safety check
            if (IsOnlyWhiteSpaces(sentance))
                return "You must type some word";
            try
            {
                string[] parts = sentance.Split('_');
                string result = parts[0];

                for (int i = 1; i < parts.Length; i++)
                    if (parts[i].Length > 0)
                        result += char.ToUpper(parts[i][0]) + parts[i].Substring(1);

                return result;
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة للتحويل من كمل الى سنيك
        public static String CamelToSnake(String sentance)
        {
            //safety check
            if (IsOnlyWhiteSpaces(sentance))
                return "You must type some word";
            try
            {
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
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لتبديل الارقام بهاش
        public static String ReplaceDigitsWithHash(string word)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";
            try
            {
                string result = "";

                foreach (char check in word)
                    result += char.IsDigit(check) ? '#' : check;

                return result;
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لحذف حروف العلة
        public static string RemoveVowels(string word)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";
            try
            {
                string result = "";
                string vowels = "aeiouAEIOU";

                foreach (char c in word)
                    if (!vowels.Contains(c))
                        result += c;

                return result;
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لمعرفة اذا كان الادخال فراغ فقط
        public static bool IsOnlyWhiteSpaces(String word)
        {
            try
            {
                int count = 0;
                foreach (char check in word)
                {
                    if (char.IsWhiteSpace(check))
                        count++;
                }
                if (count == word.Length)
                    return true;

                else return false;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return false;
            }
        }

        //دالة لتحويل الباينري الى دسمل
        public static int BinaryToDecimal(string binary)
        {
            //safety check
            if (IsOnlyWhiteSpaces(binary))
                Console.WriteLine("You must type some word");
            try
            {
                int result = 0;

                foreach (char c in binary)
                {
                    result = result * 2 + (c == '1' ? 1 : 0);
                }

                return result;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return 0;
            }
        }

        //دالة لتحويل الدسمل الى باينري
        public static string DecimalToBinary(string number)
        {
            //safety check
            if (IsOnlyWhiteSpaces(number))
                return "You must type some word";
            try
            {
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
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لكتابة بنمط اخر
        public static string CreatePattern(string word)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";
            try
            {
                return string.Join("-", word.ToCharArray());
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لاضافة فراغ بعد الفارزو
        public static string AddSpaceAfterComma(string sentence)
        {
            //safety check
            if (IsOnlyWhiteSpaces(sentence))
                return "You must type some word";
            try
            {
                return sentence.Replace(",", ", ");
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لاقتطاع 10 حروف فقط
        public static string TrimOnly10char(string word)
        {
            //safety check
            if (IsOnlyWhiteSpaces(word))
                return "You must type some word";
            try
            {
                return word.Length <= 10 ? word : word.Substring(0, 10);
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لاستحراج رقم الهاتف
        public static String ExtractPhoneNumber(String sentance)
        {
            try
            {
                return FindDigits(sentance);
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لكتاة رقم الهاتف رقم دولي
        public static String ChangePhoneNumberFormat(String number)
        {
            //safety check
            if (IsOnlyWhiteSpaces(number))
                return "You must type some word";
            try
            {
                return number.Replace("+", "00");
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }

        }

        //مدالة لقارنة كلمتين بدون علامات الترقيم
        public static bool CompareIgnoringPunctuation(String word1, String word2)
        {
            if (IsOnlyWhiteSpaces(word1) && IsOnlyWhiteSpaces(word2))
                Console.WriteLine("You must type some word");
            try
            {
                String removedPunctuationWord1 = "";
                String removedPunctuationWord2 = "";

                foreach (char check in word1)
                {
                    if (!char.IsPunctuation(check))
                        removedPunctuationWord1 += check;
                }
                foreach (char check in word2)
                {
                    if (!char.IsPunctuation(check))
                        removedPunctuationWord2 += check;
                }
                return removedPunctuationWord1 == removedPunctuationWord2;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return false;
            }
        }

        //دالة لانشاء اختصار من اسم
        public static String GenerateAcronym(String name)
        {
            if (IsOnlyWhiteSpaces(name))
                Console.WriteLine("You must type some word");
            try
            {
                String[] words = name.Split(' ');
                String acronym = "";
                foreach (String check in words)
                {
                    acronym += check[0];
                }
                return acronym;
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }

        }

        //دالة لحذف الهاشتاك
        public static String RemoveHashtags(String word)
        {
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");
            try
            {
                return word.Replace("#", "");
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لاستخراج الاشارات @
        public static String ExtractMentions(String sentance)
        {
            if (IsOnlyWhiteSpaces(sentance))
                Console.WriteLine("You must type some word");
            try
            {
                String[] words = sentance.Split(' ');
                String result = "";
                foreach (String check in words)
                {
                    if (check.StartsWith('@'))
                        result += check + " ";
                }
                return result;
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }



        }

        //دالة لحساب عدد الهاشتاك
        public static int CountNumberHashtags(String sentance)
        {
            if (IsOnlyWhiteSpaces(sentance))
                Console.WriteLine("You must type some word");
            try
            {
                int count = 0;
                foreach (char check in sentance)
                {
                    if (check == '#')
                        count++;
                }

                return count;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return 0;
            }


        }

        //دالة لاضافة سطر جديد بعد اي نقطة
        public static String InsertNewline(String sentance)
        {
            if (IsOnlyWhiteSpaces(sentance))
                Console.WriteLine("You must type some word");
            try
            {
                return sentance.Replace(". ", ".\n");
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }

        }

        //دالة لطباعة الجملة بالعكس
        public static String ReverseWordOrder(String sentance)
        {
            if (IsOnlyWhiteSpaces(sentance))
                Console.WriteLine("You must type some word");
            try
            {
                String[] words = sentance.Split(' ');
                String result = "";
                for (int i = words.Length - 1; i >= 0; i--)
                {
                    result += words[i] + " ";
                }
                return result;
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لترتيب الكلمات 
        public static String SortWords(String sentance)
        {
            if (IsOnlyWhiteSpaces(sentance))
                Console.WriteLine("You must type some word");
            try
            {
                String[] words = sentance.Split(' ');
                Array.Sort(words);
                return String.Join(" ", words);
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لتكوين slug
        public static String GenerateSlug(String sentance)
        {
            if (IsOnlyWhiteSpaces(sentance))
                Console.WriteLine("You must type some word");
            try
            {
                return sentance.ToLower().Replace(" ", "-");
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لحساب عدد الاحرف الكبيرة
        public static int CountUpperCase(String sentance)
        {
            if (IsOnlyWhiteSpaces(sentance))
                Console.WriteLine("You must type some word");
            try
            {
                int count = 0;
                foreach (char check in sentance)
                {
                    if (char.IsUpper(check))
                        count++;
                }
                return count;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return 0;
            }

        }

        //دالة لتحويل الارقام الى كتابة
        public static String ReplaceNumbersWithWords(String sentance)
        {
            if (IsOnlyWhiteSpaces(sentance))
                Console.WriteLine("You must type some word");
            try
            {
                string[] numberWords = { "zero", "one", "two", "three", "four",
                             "five", "six", "seven", "eight", "nine" };

                string result = "";

                foreach (char check in sentance)
                {
                    if (char.IsDigit(check))
                        result += numberWords[check - '0'];
                    else
                        result += check;
                }

                return result;
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لطباعة الكلمات التي يمكن قراءتها من الجهتين Palindrom
        public static String PalindromicWords(String sentance)
        {

            if (IsOnlyWhiteSpaces(sentance))
                Console.WriteLine("You must type some word");
            try
            {
                String[] words = sentance.Split(' ');
                String results = "";
                for (int i = 0; i < words.Length; i++)
                {
                    if (IsPalindrom(words[i]))
                        results += words[i] + " ";
                }
                return results;
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }

        }

        //Helper method to check if the given word is Palindrom
        public static bool IsPalindrom(String word)
        {
            String reversedWord = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }
            return reversedWord == word;
        }

        //دالة لاستبدال التاب باربع فراغات
        public static String ReplaceTabs(String word)
        {

            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");
            try
            {
                return word.Replace("\t", "    ");
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لحذف الحروف غير الانكليزية
        public static String RemoveNonEnglishCharacters(String word)
        {
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");
            try
            {
                String resul = "";
                foreach (char check in word)
                {
                    if (check >= 'A' && check <= 'Z' || check >= 'a' && check <= 'z')
                        resul += check;
                }
                return resul;
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }

        }

        //دالة لاستخراج الايدي من فيديو اليوتيوب
        public static String ExtractVideoID (String URL)
        {
            if (IsOnlyWhiteSpaces(URL))
                Console.WriteLine("You must type some word");
            try
            {
                String resul = "";
                return URL.Substring(URL.LastIndexOf("/") + 1);
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        //دالة لجمع الارقام المستخرجة من نص
        public static int SumExtractNumbers(String word)
        {
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");
            try
            {
                String numbers = FindDigits(word);
                int sum = 0;
                foreach (char check in numbers)
                {
                    sum += check - '0';

                }
                return sum;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return 0;
            }
        }

        //دالة للتشفير باستخدام قيصر
        public static String CaeserCipher(String word)
        {
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");
            try
            {
                String result = "";
                foreach (char i in word)
                {
                    if (i >= 'a' && i <= 'w' || i >= 'A' && i <= 'W')
                        result += (char)(i + 3);
                    else if (i >= 'x' && i <= 'z' || i >= 'X' && i <= 'Z')
                        result += (char)(i - 23);

                }
                return result;
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }

        }

        //دالة لفك تشفير قيصر
        public static String DecryptCaeserCipher(String word)
        {
            if (IsOnlyWhiteSpaces(word))
                Console.WriteLine("You must type some word");
            try
            {
                String result = "";
                foreach (char i in word)
                {
                    if (i >= 'd' && i <= 'z' || i >= 'D' && i <= 'Z')
                        result += (char)(i - 3);
                    else if (i >= 'a' && i <= 'c' || i >= 'A' && i <= 'C')
                        result += (char)(i + 23);

                }
                return result;
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }

        }

        //دالة لاستخراج مزود البريد
        public static String EmailProvider (String Email)
        {
            if (IsOnlyWhiteSpaces(Email))
                Console.WriteLine("You must type some word");
            try
            {
                return Email.Substring(Email.IndexOf("@") + 1);
            }
            catch (ArgumentNullException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
            
        }
    }
}
