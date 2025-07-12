using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace regex_exercises
{
    public class RegecFunctions
    {


        // 1. Match all phone numbers in a local format like 0790xxxxxxx
        // Test String: My number is 07901234567.
        // Goal: Match numbers starting with 0790 and 7 digits.
        // Arabic: استخراج أرقام الهواتف المحلية
        // Kurdish: ژمارە تەلەفۆنە ناوخۆییەکان بدۆزەرەوە
        // 
        //sol, i will create regex to solve this problem
        public static string MatchAllPhoneNumberInLocalFormat(string phoneNumber)
        {
            string pattern = @"^0790\d{7}$";
            try
            {
                // safety check
                ValidateInput.IsInputNullOrWhiteSpaces(phoneNumber);
                bool IsphoneNumberMatchPattren = (Regex.IsMatch(phoneNumber, pattern));
                if (IsphoneNumberMatchPattren)
                {
                    return "Valid phone number.";
                }
                else
                {
                    return "Invalid input";
                }

            }
            catch (Exception eror)
            {
                throw new Exception("Error occurred:" + eror.Message);
            }
        }

        // 2. Match all email addresses
        // Test String: Contact me at ali@example.com or support @halal.io
        // Goal: Extract emails
        // Arabic: استخراج البريد الإلكتروني
        // Kurdish: ئیمەیلەکان بدۆزەرەوە
        // 

        public static string MatchAllEmailAddress(string EmailAddress)
        {
            string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

            try
            {
                // safety check
                ValidateInput.IsInputNullOrWhiteSpaces(EmailAddress);

                bool IsMatchAllEmailAddress = (Regex.IsMatch(EmailAddress, pattern));
                if (IsMatchAllEmailAddress)
                {
                    return "Valid Email Address.";
                }
                else
                {
                    return "Invalid Email Address format.";
                }

            }
            catch (Exception eror)
            {
                throw new Exception("Error occurred: " + eror.Message);
            }
        }
        // 3. Match any word that starts with a capital letter
        // Test String: Ali went to Basra and met Noor.
        // Goal: Find proper nouns
        // Arabic: إيجاد أسماء العلم
        // Kurdish: ناونیشانی خاس بدۆزەوە
        // 
        public static string MatchAnyWordStartWithCapitalLetter(string InputString)
        {
            string pattern = @"\b[A-Z][a-z]+\b";

            try
            {
                // safety check
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                bool IsProperNouns = Regex.IsMatch(InputString, pattern);
                if (!IsProperNouns)
                {
                    return "No word starts with capital letter";
                }
                else
                {
                    return "There is one or more word with Capital letter";
                }
            }
            catch (Exception eror)
            {
                throw new Exception("Error occurred: " + eror.Message);
            }
        }
        // 4. Match all numbers (integers only)
        // Test String: I have 2 cats and 10 chickens.
        // Arabic: إيجاد الأرقام
        // Kurdish: ژمارەیەکان بدۆزەوە
        // 
        public static string MatchAllNumbers(string InputString)
        {
            string pattern = @"\d+";
            try
            {
                // safety check
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                MatchCollection matches = Regex.Matches(InputString, pattern);

                int NumberOfAppearingNumbers = matches.Count;

                if (NumberOfAppearingNumbers == 0)
                {
                    return "No numbers found in the input";
                }
                else
                {
                    string result = $"There are {NumberOfAppearingNumbers} numbers in the input:";
                    foreach (Match match in matches)
                    {
                        result += $"\n- {match.Value}";
                    }
                    return result;
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error occurred: " + error.Message);
            }
        }


        // 5. Match all hashtags
        // Test String: #blessed #codingLife
        // Arabic: استخراج الهاشتاغ
        // Kurdish: هاشتاکەکان بدۆزەوە
        // 
        public static string MatchAllHashtags(string InputString)
        {
            string pattern = @"#\w+";
            try
            {
                // safety check
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                MatchCollection matches = Regex.Matches(InputString, pattern);

                int NumberOfAppearingHashtags = matches.Count;

                if (NumberOfAppearingHashtags == 0)
                {
                    return "No Hashtags found in the input";
                }
                else
                {
                    string result = $"There are {NumberOfAppearingHashtags} Hashtags in the input:";
                    foreach (Match match in matches)
                    {
                        result += $"\n- {match.Value}";
                    }
                    return result;
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error occurred: " + error.Message);
            }
        }

        // 6. Match all words ending in "ing"
        // Test String: I am coding, running, and learning.
        // Arabic: الكلمات التي تنتهي بـ ing
        // Kurdish: وشەکان کە بە ing کۆتایی دەن
        // 
        public static string MatchAllWordEndWithIng(string InputString)
        {
            string pattern = @"\b\w+ing\b";

            try
            {
                // safety check
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                MatchCollection matches = Regex.Matches(InputString, pattern);

                int NumberOfAppearingING = matches.Count;

                if (NumberOfAppearingING == 0)
                {
                    return "No 'ing' found in the input";
                }
                else
                {
                    string result = $"There are {NumberOfAppearingING} 'ing' in the input:";
                    foreach (Match match in matches)
                    {
                        result += $"\n- {match.Value}";
                    }
                    return result;
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error occurred: " + error.Message);
            }
        }

        // 7. Find all currency amounts ($100, $29.99)
        // Test String: I spent $100 on food and $29.99 on drinks.
        // Arabic: المبالغ المالية
        // Kurdish: بڕی پارە بدۆزەوە
        // 
        public static bool FindAllCirrencyAmount(string InputString)
        {
            string pattern = @"\$\d+(\.\d{2})?";
            // ? mean it might be there might be not
            try
            {
                // safety check
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                MatchCollection matches = Regex.Matches(InputString, pattern);

                int NumberOfAppearingCurrencyAmount = matches.Count;

                if (NumberOfAppearingCurrencyAmount == 0)
                {
                    Console.WriteLine("No Currency Amount found in the input");
                    return false;
                }
                else
                {
                    Console.WriteLine($"There are {NumberOfAppearingCurrencyAmount} Currency Amount in the input:");
                    foreach (Match match in matches)
                    {
                        Console.WriteLine($"- {match.Value}");
                    }
                    return true;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occurred: " + error.Message);
                return false;
            }
        }
        // 8. Match time like 12:30 or 04:55
        // Test String: The meeting is at 12:30.
        // Arabic: مطابقة الوقت
        // Kurdish: کاتی بە شێوەی hh:mm بدۆزەوە
        // 
        public static bool MatchAllTime(string InputString)
        {
            string pattern = @"\b([01]\d|2[0-3]):[0-5]\d\b";
            try
            {
                // safety check
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                MatchCollection matches = Regex.Matches(InputString, pattern);

                int NumberOfTimes = matches.Count;

                if (NumberOfTimes == 0)
                {
                    Console.WriteLine("No Time found in the input");
                    return false;
                }
                else
                {
                    Console.WriteLine($"There are {NumberOfTimes} time in the input:");
                    foreach (Match match in matches)
                    {
                        Console.WriteLine($"- {match.Value}");
                    }
                    return true;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occurred: " + error.Message);
                return false;
            }
        }
        // 9. Match dates like 2025-07-10
        // Test String: Today is 2025-07-10
        // Arabic: استخراج التاريخ
        // Kurdish: ڕێکەوتەکان بدۆزەوە
        // 
        public static string MatchDates(string InputString)
        {
            string pattern = @"\b\d{4}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01])\b";

            try
            {
                // safety check
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                MatchCollection matches = Regex.Matches(InputString, pattern);

                int NumberOfAppearingDates = matches.Count;

                if (NumberOfAppearingDates == 0)
                {
                    return "No 'Date' was found in the input";
                }
                else
                {
                    string dates = $"There are {NumberOfAppearingDates} 'Date' in the input:";
                    foreach (Match match in matches)
                    {
                        dates += $"\n- {match.Value}";
                    }
                    return dates;
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error occurred: " + error.Message);
            }
        }
        // 10. Match a single Arabic word
        // Test String: هذه كلمة عربية.
        // Arabic: استخراج كلمة عربية واحدة
        // Kurdish: وشەی عەرەبی بدۆزەوە
        // 
        // 
        public static string FindArabicWords(string InputString)
        {
            string pattern = @"\b[\u0621-\u064A]+\b"; ;

            try
            {
                // safety check
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                MatchCollection matches = Regex.Matches(InputString, pattern);

                int NumberOfAppearingArabicWords = matches.Count;

                if (NumberOfAppearingArabicWords == 0)
                {
                    return "No 'Date' was found in the input";
                }
                else
                {
                    string ArabicWords = $"There are {NumberOfAppearingArabicWords} 'Arabic' Words in the input:";
                    foreach (Match match in matches)
                    {
                        ArabicWords += $"\n- {match.Value}";
                    }
                    return ArabicWords;
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error occurred: " + error.Message);
            }
        }

        // 11. Match any word that starts with “un”
        // Test String: unknown, unhappy, unlocked
        // Arabic: الكلمات التي تبدأ بـ un
        // Kurdish: وشەکان کە بە un دەست پێدەکەن
        // 
        public static string FindWordsStartWithUn(string InputString)
        {
            string pattern = @"\bun\w*\b";

            try
            {
                // safety check
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                MatchCollection matches = Regex.Matches(InputString, pattern);

                int NumberOfAppearingUn = matches.Count;

                if (NumberOfAppearingUn == 0)
                {
                    return "No 'un' was found in the input";
                }
                else
                {
                    string UnInwords = $"There are {NumberOfAppearingUn} 'un' in the input:";
                    foreach (Match match in matches)
                    {
                        UnInwords += $"\n- {match.Value}";
                    }
                    return UnInwords;
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error occurred: " + error.Message);
            }
        }
        // 12. Match all Kurdish words (basic check)
        // Test String: ئەمە وشەیەکی کوردییە
        // Arabic: مطابقة الكلمات الكردية
        // Kurdish: وشەی کوردی بدۆزەوە
        // 
        public static string FindKurdishWords(string InputString)
        {
            string pattern = @"\b[\u0600-\u06FF]+\b";

            try
            {
                // safety check
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                MatchCollection matches = Regex.Matches(InputString, pattern);

                int NumberOfAppearingUn = matches.Count;

                if (NumberOfAppearingUn == 0)
                {
                    return "No 'Kurdish Words' was found in the input";
                }
                else
                {
                    string KurdishWords = $"There are {NumberOfAppearingUn} 'Kurdish Words' in the input:";
                    foreach (Match match in matches)
                    {
                        KurdishWords += $"\n- {match.Value}";
                    }
                    return KurdishWords;
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error occurred: " + error.Message);
            }
        }
        // 13. Validate a username (alphanumeric, 4–12 chars)
        // Test String: Ali123
        // Arabic: التحقق من صحة اسم المستخدم
        // Kurdish: ناوی بەکارهێنەر پشتڕاست بکەوە
        // 
        public static string ValidateUserName(string InputUserName)
        {
            string pattern = @"^\w{4,12}$";

            try
            {
                // safety check
                ValidateInput.IsInputNullOrWhiteSpaces(InputUserName);

                MatchCollection matches = Regex.Matches(InputUserName, pattern);

                int NumberOfAppearingUserName = matches.Count;

                if (NumberOfAppearingUserName == 0)
                {
                    return "No 'User Name' was found in the input";
                }
                else
                {
                    return "Valid UserName";
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error occurred: " + error.Message);
            }
        }
        // 14. Match any HTML tag
        // Test String: <div>Hello</div>
        // Arabic: مطابقة الوسوم
        // Ku
        // rdish: تاگە HTML ـکان بدۆزەوە
        // 
        public static string MatchAntHtmlTag(string InputString)
        {
            string pattern = @"<[^>]+>";

            try
            {
                // safety check
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                MatchCollection matches = Regex.Matches(InputString, pattern);

                int NumberOfAppearinHtmlTags = matches.Count;

                if (NumberOfAppearinHtmlTags == 0)
                {
                    return "No 'Html Tags' was found in the input";
                }
                else
                {
                    string HtmlTags = $"There are {NumberOfAppearinHtmlTags} 'Html Tags' in the input:";
                    foreach (Match match in matches)
                    {
                        HtmlTags += $"\n- {match.Value}";
                    }
                    return HtmlTags;
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error occurred: " + error.Message);
            }
        }
        // 15. Match any sentence ending with a question mark
        // Test String: How are you? Is this okay?
        // Arabic: الأسئلة
        // Kurdish: پرسیارەکان بدۆزەوە
        // 
        public static string MatchAnySentenceEndingWithQuestionMark(string InputString)
        {
            string pattren = @"[^.?!]*\?";

            try
            {
                // safety check
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                MatchCollection matches = Regex.Matches(InputString, pattren);

                int NumberOfAppearinQouestionMarkInSentence = matches.Count;

                if (NumberOfAppearinQouestionMarkInSentence == 0)
                {
                    return "No '?' was found in the input";
                }
                else
                {
                    string QouestionMarks = $"There are {NumberOfAppearinQouestionMarkInSentence} Sentence ending with Qouestion mark :";
                    foreach (Match match in matches)
                    {
                        QouestionMarks += $"\n- {match.Value}";
                    }
                    return QouestionMarks;
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error occurred: " + error.Message);
            }
        }
        // 16. Find duplicate words
        // Test String: this is is a test
        // Arabic: تكرار الكلمات
        // Kurdish: وشەی دووجارکراو بدۆزەوە
        // 
        public static string FindDuplicateWords(string InputString)
        {
            string pattern = @"\b(\w+)\s+\1\b";

            try
            {
                // safety check
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                MatchCollection matches = Regex.Matches(InputString, pattern);

                int NumberOfAppearingDuplicatedWords = matches.Count;

                if (NumberOfAppearingDuplicatedWords == 0)
                {
                    return "No 'Duplicated Words' was found in the input";
                }
                else
                {
                    string DuplicatedWords = $"There are {NumberOfAppearingDuplicatedWords} Duplicated Words in the input :";
                    foreach (Match match in matches)
                    {
                        DuplicatedWords += $"\n- {match.Value}";
                    }
                    return DuplicatedWords;
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error occurred: " + error.Message);
            }
        }
        // 17. Extract file extensions(.jpg, .pdf)
        // Test String: photo.jpg, resume.pdf
        // Arabic: استخراج الامتدادات
        // Kurdish: پاشگرەکانی فایل بدۆزەوە
        // 
        public static string ExtractValidFileExtensions(string InputString)
        {
            string pattern = @"\.\w{2,}";

            try
            {
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                MatchCollection matches = Regex.Matches(InputString, pattern);

                int NumberOfAppearingFileExtension = matches.Count;
                if (NumberOfAppearingFileExtension == 0)
                {
                    return "No valid 'file extensions' found in input";
                }

                string FileExtinsions = $"\"There are {NumberOfAppearingFileExtension} 'file extensions' in the input:";
                foreach (Match match in matches)
                {
                    FileExtinsions += $"\n- {match.Value}";
                }

                return FileExtinsions;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred: " + ex.Message);
            }
        }

        // 18. Match Iraqi license plates(e.g., ب 12345)
        // Test String: ب 12345
        // Arabic: مطابقة رقم السيارة
        // Kurdish: ژمارەی ئۆتۆمبێلە عێراقییەکان بدۆزەوە
        // 
        public static string MatchIraqiLicensePlates(string InputString)
        {
            // Pattern: Arabic letter (isolated) followed by space, then exactly 5 digits
            string pattern = @"\b[أ-ي]\s\d{5}\b";

            try
            {
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                MatchCollection matches = Regex.Matches(InputString, pattern);

                int NumberOfAppearingPlates = matches.Count;

                if (NumberOfAppearingPlates == 0)
                {
                    return "No 'Iraqi license plates' were found in the input";
                }
                else
                {
                    string FoundPlates = $"There are {NumberOfAppearingPlates} 'Iraqi license plates' in the input:";
                    foreach (Match match in matches)
                    {
                        FoundPlates += $"\n- {match.Value}";
                    }
                    return FoundPlates;
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error occurred: " + error.Message);
            }
        }
        // 19. Find words with diacritics(Arabic harakat)
        // Test String: تَجْرِبَةٌ
        // Arabic: علامات التشكيل
        // Kurdish: نیشانەکانی تەشکیل بدۆزەوە
        // 
        public static string FindWordsWithDiacritics(string InputString)
        {
            // Arabic harakat range \u064B to \u0652
            string pattern = @"\b[\u0621-\u064A]*[\u064B-\u0652]+[\u0621-\u064A]*\b";

            try
            {
                // safety check
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                MatchCollection matches = Regex.Matches(InputString, pattern);

                int NumberOfWordsWithHarakat = matches.Count;

                if (NumberOfWordsWithHarakat == 0)
                {
                    return "No 'words with diacritics' were found in the input";
                }
                else
                {
                    string WordsWithHarakat = $"There are {NumberOfWordsWithHarakat} 'words with diacritics' in the input:";
                    foreach (Match match in matches)
                    {
                        WordsWithHarakat += $"\n- {match.Value}";
                    }
                    return WordsWithHarakat;
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error occurred: " + error.Message);
            }
        }
     
        // 20. Extract URLs
        // Test String: Visit https://halal.io today!
        // Arabic: روابط الإنترنت
        // Kurdish: بەستەرەکان بدۆزەوە
        //
        public static string ExtractURLs(string InputString)
        {
            string pattern = @"https?:\/\/[^\s]+";

            try
            {
                // safety check
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                 MatchCollection matches = Regex.Matches(InputString, pattern);

                int NumberOfAppearingURLs = matches.Count;

                if (NumberOfAppearingURLs == 0)
                {
                    return "No 'URLs' were found in the input";
                }
                else
                {
                    string URLsFound = $"There are {NumberOfAppearingURLs} 'URLs' in the input:";
                    foreach (Match match in matches)
                    {
                        URLsFound += $"\n- {match.Value}";
                    }
                    return URLsFound;
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error occurred: " + error.Message);
            }
        }


        // 21. Validate strong password
        // Arabic: التحقق من قوة كلمة المرور
        // Kurdish: پشتڕاستکردنی نهێنوشەی بەهێز
        //
        public static string ValidateStrongPassword(string InputString)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&]).{8,}$";

            try
            {
                // safety check
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                bool isStrongPassword = Regex.IsMatch(InputString, pattern);

                if (isStrongPassword)
                {
                    return "The input is a strong password.";
                }
                else
                {
                    return "The input is NOT a strong password." +
                           "Must contain at least one lowercase letter" +
                           ",uppercase letter, one digit, one special character and " +
                           "At least 8 characters long";
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error occurred: " + error.Message);
            }
        }

      
        // 25. Match numbers in Arabic numerals(١٢٣٤٥)
        // Test String: سعره ١٢٣ د.ع
        // Arabic: الأرقام العربية
        // Kurdish: ژمارەی عەرەبییەکان بدۆزەوە
        // 
        public static string MatchArabicNumerals(string InputString)
        {
            string pattern = @"[\u0660-\u0669]+";
            try
            {
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                MatchCollection matches = Regex.Matches(InputString, pattern);
                
                int NumberOfArabicNumbers = matches.Count;

                if (NumberOfArabicNumbers == 0)
                    return "No Arabic numerals were found in the input";

                string ArabicNumbersFound = $"There are {NumberOfArabicNumbers} Arabic numerals in the input:";
                foreach (Match match in matches)
                    ArabicNumbersFound += $"\n- {match.Value}";
                return ArabicNumbersFound;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred: " + ex.Message);
            }
        }

        // 26. Match repeated character sequences
        // Test String: loooool, yessss
        // Arabic: الحروف المتكررة
        // Kurdish: پێکراوەی وشەکان بدۆزەوە
        // 
        public static string MatchRepeatedCharacters(string InputString)
        {
            string pattern = @"(\w)\1+";
            try
            {
                ValidateInput.IsInputNullOrWhiteSpaces(InputString);

                MatchCollection matches = Regex.Matches(InputString, pattern);

                int NumberOfRepeatedCharacterFound = matches.Count;

                if (NumberOfRepeatedCharacterFound == 0)
                    return "No Arabic numerals were found in the input";

                string RepeatedCharacterFound = $"There are {NumberOfRepeatedCharacterFound} repeated character sequences in the input:";
                foreach (Match match in matches)
                    RepeatedCharacterFound += $"\n- {match.Value}";
                return RepeatedCharacterFound;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred: " + ex.Message);
            }
        }


        // 27. Extract Quranic Basmalah only
        // Arabic: البسملة
        // Kurdish: دەسپێکی سۆرەکان بدۆزەوە
        // 
        public static string ExtractQuranicBasmalah(string input)
        {
            string pattern = @"\bبسم الله الرحمن الرحيم\b";

            try
            {
                ValidateInput.IsInputNullOrWhiteSpaces(input);
                var match = Regex.Match(input, pattern);
                if (!match.Success)
                    return "Basmalah was not found in the input";

                return $"Basmalah found: {match.Value}";
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred: " + ex.Message);
            }
        }

    }
}