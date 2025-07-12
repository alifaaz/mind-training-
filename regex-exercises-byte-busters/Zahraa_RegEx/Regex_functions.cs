using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Zahraa_RegEx
{
    internal class Regex_functions
    {
        /*1. Match all phone numbers in a local format like 0790xxxxxxx
        Test String: My number is 07901234567.
        output: 07901234567 */
        public static string ExtractPhoneNumber(string PhoneNumber)
        {
            try
            {
                helpers.ValidateInput(PhoneNumber);

                // \b stands for word boundary, ensuring that the match is not part of a larger number.
                Match match = Regex.Match(PhoneNumber, @"\b0790\d{7}\b");
                
                if (match.Success)
                    return match.Value + ". Well done ;) ";
                else
                    return "Bro! you need a number of 11 numbers that starts with 0790, Try again!";
            }
            catch (Exception ex) 
            {
                throw new Exception("ExtractPhoneNumber expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Test String: Contact me at ali@example.com or support@halal.io 
         * Goal: Extract emails */
        public static string ExtractEmails(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match a simple email format
                Match match = Regex.Match(input, @"[a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\..*"); 
                
                if (match.Success)
                    return "--> (" + match.Value + ")  Well done ;) ";
                else
                    return "Bro! you need to enter a VALID Email Address, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractEmails expects a non-null phrase string. " + ex.Message);
            }
        }

        /* Match any word that starts with a capital letter
        Test String: Ali went to Basra and met Noor.
        Goal: Find proper nouns */
        public static string ExtractProperNouns(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match words starting with a capital letter
                var matches = Regex.Matches(input, "[A-Z][a-z]+");
                
                if (matches.Count > 0)
                    return  string.Join(", ", matches.Select(m => m.Value)) + " is a proper noun, Well done ;) ";
                else
                    return "Bro! you need to enter a proper noun, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractProperNouns expects a non-null phrase string. " + ex.Message);
            }
        }
        /*Match all numbers (integers only)
        Test String: I have 2 cats and 10 chickens. */
        public static string ExtractIntegers(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match integers
                var matches = Regex.Matches(input, "\\d+");
                
                if (matches.Count > 0)
                    return string.Join(", ", matches.Select(m => m.Value)) + " are the integers found, Well done ;) ";
                else
                    return "Bro! you need to enter an integer, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractIntegers expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Match all hashtags
        Test String: #blessed #codingLife */
        public static string ExtractHashtags(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match hashtags
                var matches = Regex.Matches(input, "#[a-zA-Z0-9_]+");
                
                if (matches.Count > 0)
                    return string.Join(", ", matches.Select(m => m.Value)) + " are the hashtags found, Well done ;) ";
                else
                    return "Bro! you need to enter a hashtag, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractHashtags expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Match all words ending in "ing"
        Test String: I am coding, running, and learning. */
        public static string ExtractWordsEndingWithIng(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match words ending with "ing"
                var matches = Regex.Matches(input, "\\w+ing");
                
                if (matches.Count > 0)
                    return string.Join(", ", matches.Select(m => m.Value)) + " are the words ending with 'ing', Well done ;) ";
                else
                    return "Bro! you need to enter a word ending with 'ing', Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractWordsEndingWithIng expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Find all currency amounts ($100, $29.99)
        Test String: I spent $100 on food and $29.99 on drinks. */
        public static string ExtractCurrencyAmounts(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match currency amounts
                var matches = Regex.Matches(input, @"(\$100|\$29\.99)");
                
                if (matches.Count > 0)
                    return string.Join(", ", matches.Select(m => m.Value)) + " are the currency amounts found, Well done ;) ";
                else
                    return "Bro! you need to enter a currency amount, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractCurrencyAmounts expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Match time like 12:30 or 04:55
        Test String: The meeting is at 12:30. */
        public static string ExtractTime(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match time in HH:MM format
                var matches = Regex.Matches(input, "\\d{2}:\\d{2}");
                
                if (matches.Count > 0)
                    return string.Join(", ", matches.Select(m => m.Value)) + " are the times found, Well done ;) ";
                else
                    return "Bro! you need to enter a valid time in HH:MM format, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractTime expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Match dates like 2025-07-10
        Test String: Today is 2025-07-10 */
        public static string ExtractDates(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match dates in YYYY-MM-DD format
                var matches = Regex.Matches(input, @"\d{4}-\d{2}-\d{2}");
                
                if (matches.Count > 0)
                    return string.Join(", ", matches.Select(m => m.Value)) + " are the dates found, Well done ;) ";
                else
                    return "Bro! you need to enter a valid date in YYYY-MM-DD format, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractDates expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Match a single Arabic word
        Test String: هذه كلمة عربية. */
        public static string ExtractArabicWord(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match a single Arabic word
                Match match = Regex.Match(input, @"[\u0600-\u06FF]+");
                
                if (match.Success)
                    return match.Value + " is the Arabic word found, Well done ;) ";
                else
                    return "Bro! you need to enter an Arabic word, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractArabicWord expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Match any word that starts with “un”
        Test String: unknown, unhappy, unlocked */
        public static string ExtractWordsStartingWithUn(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match words starting with "un"
                var matches = Regex.Matches(input, "un\\w*");
                
                if (matches.Count > 0)
                    return string.Join(", ", matches.Select(m => m.Value)) + " are the words starting with 'un', Well done ;) ";
                else
                    return "Bro! you need to enter a word starting with 'un', Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractWordsStartingWithUn expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Match all Kurdish words (basic check)
        Test String: ئەمە وشەیەکی کوردییە */
        public static string ExtractKurdishWord(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // using Unicode range for Kurdish characters (same as Arabic I guess)
                Match match = Regex.Match(input, @"[\u0600-\u06FF]+");
                
                if (match.Success)
                    return match.Value + " is the Kurdish word found, Well done ;) ";
                else
                    return "Bro! you need to enter a Kurdish word, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractKurdishWord expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Validate a username (alphanumeric, 4–12 chars)
        Test String: Ali123 */
        public static string ValidateUsername(string username)
        {
            try
            {
                helpers.ValidateInput(username);
                // Regex pattern to validate username
                Match match = Regex.Match(username, @"^[a-zA-Z][a-zA-Z0-9]{4,12}");
                
                if (match.Success)
                    return match.Value + " is a valid username, Well done ;) ";
                else
                    return "Bro! you need to enter a valid username (alphanumeric, 4–12 chars), Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ValidateUsername expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Match any HTML tag
        Test String: <div>Hello</div> */
        public static string ExtractHtmlTag(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match HTML tags
                var matches = Regex.Matches(input, "<.*?>");
               
                if (matches.Count > 0)
                    return string.Join(", ", matches.Select(m => m.Value)) + " are the HTML tags found, Well done ;) ";
                else
                    return "Bro! you need to enter a valid HTML tag, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractHtmlTag expects a non-null phrase string. " + ex.Message);
            }
        }

        /* Match any sentence ending with a question mark
        Test String: How are you? Is this okay? */
        public static string ExtractQuestionSentences(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // NOTE: [^?]* matches zero or more characters that are not a question mark.
                var matches = Regex.Matches(input, @"[^?].*\?");
                
                if (matches.Count > 0)
                    return string.Join(", ", matches.Select(m => m.Value)) + " are the question sentences found, Well done ;) ";
                else
                    return "Bro! you need to enter a sentence ending with a question mark, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractQuestionSentences expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Find duplicate words
        Test String: this is is a test */
        public static string FindDuplicateWords(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // \b(\w+)\b(?=.*\b\1\b) هاي لكيتها جاهزة بكوكل من بحثت عن التكرارا بالريجكس
                // \b marks word boundaries,
                // (\w+) captures a word,
                // \1 refers to the same word,
                // (?=.*) checks if it appears again

                var matches = Regex.Matches(input, @"\b(\w+)\b(?=.*\b\1\b)");
                
                if (matches.Count > 0)
                    return string.Join(", ", matches.Select(m => m.Value)) + " are the duplicate words found, Well done ;) ";
                else
                    return "Bro! you need to enter a phrase with duplicate words, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("FindDuplicateWords expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Extract file extensions (.jpg, .pdf)
        Test String: photo.jpg, resume.pdf */
        public static string ExtractFileExtensions(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match file extensions
                var matches = Regex.Matches(input, @"\.\w+");
                
                if (matches.Count > 0)
                    return string.Join(", ", matches.Select(m => m.Value)) + " are the file extensions found, Well done ;) ";
                else
                    return "Bro! you need to enter a valid file extension, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractFileExtensions expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Match Iraqi license plates (e.g., ب 12345)
        Test String: ب 12345 (use unicode for arabic chars*/
        public static string ExtractIraqiLicensePlate(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match Iraqi license plates

                Match match = Regex.Match(input, @"\d{5}[\u0600-\u06FF]+");
                
                if (match.Success)
                    return match.Value + " is the Iraqi license plate found, Well done ;) ";
                else
                    return "Bro! you need to enter a valid Iraqi license plate (e.g., ب 12345), Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractIraqiLicensePlate expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Find words with diacritics (Arabic harakat)
        Test String: تَجْرِبَةٌ */
        public static string ExtractWordsWithDiacritics(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match Iraqi license plates
                var matches = Regex.Matches(input, @"[\u064E\u0650\u064F\u06E2\u0651\u0646\u064F\u064C]+");

                if (matches.Count > 0)
                    return string.Join(", ", matches.Select(m => m.Value)) + " are the Harakat found, Well done ;) ";
                else
                    return "Bro! you need to enter an arabic word with diacritics, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractWordsWithDiacritics expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Extract URLs
        Test String: Visit https://halal.io today! */
        public static string IsValidUrl(string url)
        {
            try
            {
                helpers.ValidateInput(url);

                // Regular expression to check if the URL is valid
                Match match = Regex.Match(url, @"\b(http|https)://.*\..*\b");
                if (match.Success)
                    return match.Value + " is a valid URL, Well done ;) ";
                
                else
                    return "Bro! you need to enter a valid URL, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("IsValidUrl expects a non-null URL string. " + ex.Message);
            }
        }

        // Validate strong password
        public static string ValidateStrongPassword(string password)
        {
            try
            {
                helpers.ValidateInput(password);
                // Regex pattern to validate strong password (From StackOverflow)
                Match match = Regex.Match(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
                
                if (match.Success)
                    return match.Value + " is a strong password, Well done ;) ";
                else
                    return "Bro! you need to enter a strong password (at least 8 characters, one uppercase, one lowercase, one digit, and one special character), Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ValidateStrongPassword expects a non-null password string. " + ex.Message);
            }
        }

        /* Match emojis (basic)
        Test String: 😊 ❤️ 🔥 */
        public static string ExtractEmojis(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match emojis (basic)
                var matches = Regex.Matches(input, @"[\uD83C-\uDBFF\uDC00-\uDFFF\u2764-\uFE0F]+");
                
                if (matches.Count > 0)
                    return string.Join(", ", matches.Select(m => m.Value)) + " are the emojis found, Well done ;) ";
                else
                    return "Bro! you need to enter an emoji, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractEmojis expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Match valid IPv4 addresses
        Test String: 192.168.0.1 
        --------------------------------
        Regex pattern explanation (xxxx.xxxx.xxxx.xxxx) :

        ^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)  --> الجزء الأول
        \.
        (25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)   --> الثاني
        \.
        (25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)   --> الثالث
        \.
        (25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$  --> الرابع

        |       | التعبير       |   | المعنى             |
        | ------------------ | ------------------------- |
        | `25[0-5]`          | يقبل فقط 250 إلى 255      |
        | `2[0-4][0-9]`      | يقبل فقط 200 إلى 249      |
        | `[01]?[0-9][0-9]?` | يقبل الأرقام من 0 إلى 199  |

         */
        public static string IsValidIpv4Adress(string input) 
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match valid IPv4 addresses (from the web)
                Match match = Regex.Match(input, @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
                
                if (match.Success)
                    return match.Value + " is a valid IPv4 address, Well done ;) ";
                else
                    return "Bro! you need to enter a valid IPv4 address, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractEmail expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Find Quran surah references (e.g., 2:255)
         Test String: See 2:255 for Ayat al-Kursi */
        public static string ExtractQuranSurahReferences(string input)
            {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match Quran surah references (max: 114 Surah, 286 Aya)
                var matches = Regex.Matches(input, @"\b\d{1,3}:\d{1,3}\b");
                
                if (matches.Count > 0)
                    return string.Join(", ", matches.Select(m => m.Value)) + " are the Quran surah references found, Well done ;) ";
                else
                    return "Bro! you need to enter a valid Quran surah reference (e.g., 2:255), Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractQuranSurahReferences expects a non-null phrase string. " + ex.Message);
            }
        }

        /* Match numbers in Arabic numerals (١٢٣٤٥)
        Test String: سعره ١٢٣ د.ع */
        public static string ExtractArabicNumerals(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match Arabic (You mean هندية) numerals (١٢٣٤٥)
                var matches = Regex.Matches(input, @"[\u0660-\u0669]+");
                
                if (matches.Count > 0)
                    return string.Join(", ", matches.Select(m => m.Value)) + " are the Arabic numerals found, Well done ;) ";
                else
                    return "Bro! you need to enter a valid Arabic numeral, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractArabicNumerals expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Match repeated character sequences
        Test String: loooool, yessss */
        public static string ExtractRepeatedCharacterSequences(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match repeated character sequences
                // (\w) matches any word character (alphanumeric or underscore),
                // \1{2,} matches the same character repeated 2 or more times.
                var matches = Regex.Matches(input, @"(\w)\1{2,}");
                
                if (matches.Count > 0)
                    return string.Join(", ", matches.Select(m => m.Value)) + " are the repeated character sequences found, Well done ;) ";
                else
                    return "Bro! you need to enter a phrase with repeated character sequences, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractRepeatedCharacterSequences expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Extract Quranic Basmalah only*/
        public static string ExtractQuranicBasmalah(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match Quranic Basmalah
                Match match = Regex.Match(input, @"بسم الله الرحمنِ الرحيم");
                
                if (match.Success)
                    return match.Value + " is the Quranic Basmalah found, Well done ;) ";
                else
                    return "Bro! you need to enter the Quranic Basmalah, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractQuranicBasmalah expects a non-null phrase string. " + ex.Message);
            }
        }

        /*Extract YouTube video ID
        Test String: https://www.youtube.com/watch?v=abc123xyz */
        public static string ExtractYouTubeVideoId(string input)
        {
            try
            {
                helpers.ValidateInput(input);
                // Regex pattern to match YouTube video ID
                Match match = Regex.Match(input, @"youtube\.com/watch\?v=([a-zA-Z0-9_-]{11})");
                
                if (match.Success)
                    return match.Groups[1].Value + " is the YouTube video ID found, Well done ;) ";
                else
                    return "Bro! you need to enter a valid YouTube video URL, Try again!";
            }
            catch (Exception ex)
            {
                throw new Exception("ExtractYouTubeVideoId expects a non-null phrase string. " + ex.Message);
            }
        }
    }
}
