using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        ReverseIntNumber();
    }

    /// <summary>Compares the two sting by culture.</summary>
    static void CompareTwoStingByCulture()
    {
        //here we enter two strings and compare using culture
        Console.Write("Enter First One: ");
        string word_03 = Console.ReadLine(); //enter first string
        Console.Write("Enter Second One: ");
        string word_04 = Console.ReadLine(); //enter second string

        CultureInfo _Us = new CultureInfo("en-US"); //make variable for culture Us
        CultureInfo _CZ = new CultureInfo("cs-CZ"); //make variable for culture cz
        int _USresult = string.Compare(word_03, word_04, false, _Us);  //compare by ignore case and use US culture
        int _CZresult = string.Compare(word_03, word_04, false, _CZ);  //compare by ignore case and use _CZ culture\

        switch (_USresult)
        {
            case 0:
                Console.WriteLine($"Two words are Equal in Us culture {word_03} = {word_04}");
                break;
            case 1:
                Console.WriteLine($"First word are greater than second in Us culture {word_03} > {word_04}");
                break;

            default:
                Console.WriteLine($"First word are smaller than second in Us culture {word_03} < {word_04}");
                break;
        }


        switch (_CZresult)
        {
            case 0:
                Console.WriteLine($"Two words are Equal in CZ culture {word_03} = {word_04}");
                break;
            case 1:
                Console.WriteLine($"First word are greater than second in CZ culture {word_03} > {word_04}");
                break;

            default:
                Console.WriteLine($"First word are smaller than second in CZ culture {word_03} < {word_04}");
                break;
        }
    }
    static void CompareTwoStringUsingLinguistic_Casesensitive_Ordinal()
    {
        //here we input two string and make compare between them using three methods
        Console.Write("Enter First One: ");
        string word_03 = Console.ReadLine(); //enter first string
        Console.Write("Enter Second One: ");
        string word_04 = Console.ReadLine(); //enter second string

        CultureInfo _Us = new CultureInfo("en-US"); //make variable for culture Us

        Console.WriteLine("Notes 0 means Equal, 1 means 1st string greater, -1 means 2nd string is greater"); //notes when print
        int LinguisticResult = string.Compare(word_03, word_04, true, _Us); //case-insensitive
        Console.WriteLine($"LinguisticResult {getResult(LinguisticResult)}");
        int CasesensitiveResult = string.Compare(word_03, word_04, false, _Us); //case-sensitive
        Console.WriteLine($"CasesensitiveResult {getResult(CasesensitiveResult)}");
        int OrdinalResult = string.CompareOrdinal(word_03, word_04); //Ordinal
        Console.WriteLine($"OrdinalResult {getResult(OrdinalResult)}");


        static int getResult(int result)
        {
            switch (result)
            {
                case 0:
                    return 0;
                    break;
                case 1:
                    return 1;
                    break;
                default:
                    return -1;
                    break;
            }
        }

    }
    /// <summary>Checks the chars.</summary>
    static void CheckChars()
    {
        //here we enter string and check if Chars is Uniqu or not
        Console.Write("Enter string to check chars if unique or not: ");
        string charsArray = Console.ReadLine(); //enter  string
        int flag = 0; //Flag when is identical 

        for (int i = 0; i < charsArray.Length; i++) // trace chars in string
        {
            for (int j = i + 1; j < charsArray.Length; j++)
            {
                if (charsArray[j] == charsArray[i])
                {
                    flag = 1;
                }
            }
        }
        if (flag == 0)
        {
            Console.WriteLine("There is no Duplicate chars in Entered String");
        }
        else
        {
            Console.WriteLine("There is a Duplicate chars in Entered String");
        }
    }
    static void CharsToAscII()
    {
        //here user input string then convert string to ASCII code but format as HexaDecimal
        Console.Write("Enter string to convert to Ascii: ");
        string charsArray = Console.ReadLine(); //enter  string
        for (int i = 0; i < charsArray.Length; i++)
        {
            int decimalVal = charsArray[i];
            Console.Write(string.Format("{0:X}", decimalVal) + " ");
        }
    }
    static void PrintRepetationOfChars()
    {
        //here user input string then find repetion of each chars
        Console.Write("Enter string to Check Chars Repetions: ");
        string charsArray = Console.ReadLine(); //enter  string
        charsArray = charsArray.Replace(" ", ""); //remove whitespaces 
        int count = 1;
        List<KeyValuePair<char, int>> repetedchars = new List<KeyValuePair<char, int>>();
        for (int i = 0; i < charsArray.Length; i++)
        {
            for (int j = i + 1; j < charsArray.Length; j++)
            {
                if (charsArray[j] == charsArray[i])
                {
                    count++;
                    repetedchars.Add(new KeyValuePair<char, int>(charsArray[i], count));
                }

            }
            count = 1;
        }
        var noDuplicateKeys = repetedchars
    .GroupBy(x => x.Key) // group chars as Groups then Each Group has Count and maybe Two counts then We arrange as Desc after that we get first value
    .Select(g => g.OrderByDescending(i => i.Value).First())
            .ToList();
        foreach (var item in noDuplicateKeys)
        {
            Console.WriteLine($"char: {item.Key}, Frequency: {item.Value}");
        }

    }
    static void CenteryOfYear()
    {
        //here user input any year as int then find century
        Console.Write("Enter Year: ");
        int _year = int.Parse(Console.ReadLine()); // read year from user

        int century = (_year + 99) / 100; // converting

        Console.WriteLine($"Century is {century}");
    }
    static void FindLargestString()
    {
        //here we create array of string then find largest string using Length
        Console.Write("Enter number of strings that Length of String Array: "); //Determine String Length
        int StringLength = int.Parse(Console.ReadLine()); //read length from user

        string[] strings = new string[StringLength]; // create array of strings

        //trace on array to enter each string alone
        for (int i = 0; i < StringLength; i++)
        {
            Console.Write($"Enter String No.{i + 1}: ");
            strings[i] = Console.ReadLine();
        }

        string LargestString = strings[0];  //suggest that first string is largest one

        foreach (var item in strings)
        {
            //trace on strings and compare largest one with other
            if (item.Length > LargestString.Length)
            {
                LargestString = item;
            }
        }
        Console.WriteLine($"Largest String is: {LargestString}"); //print largest one found
    }
    static void CountRepetionOfSubString()
    {
        //here user input string Main and substring then we check the substring how many times appear
        Console.Write("Enter Main String: ");
        string MainString = Console.ReadLine();

        Console.Write("Enter SubString to check how many repetion in String: ");
        string substring = Console.ReadLine();
        int count, searchIndex, startIndex; //initialize some variable we use
        count = searchIndex = startIndex = 0;

        while (true)
        {
            searchIndex = MainString.IndexOf(substring, startIndex);
            if (searchIndex != -1)
            {
                count++;
                startIndex = searchIndex + substring.Length;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"SubStrings Appears {count} times in MainString");
    }
    static void CharPosition()
    {
        //here user input string then get postion of each char using ABC postions
        Console.Write("Enter string to get postions of Chars: ");
        string charsArray = Console.ReadLine(); //enter  string
        charsArray = charsArray.Replace(" ", ""); //remove all whitespace
        charsArray.ToLower(); //convert all chars to lowercase
        //Console.Write(charsArray);
        for (int i = 0; i < charsArray.Length; i++)
        {
            if (char.IsLetter(charsArray[i])) //check only letters
            {
                int postion = charsArray[i] - 'a' + 1;
                Console.Write($"{postion} ");
            }
        }
    }
    
    static void ReverseIntNumber()
    {      //here we get number form user and reverse and make concation with its orginal 
        int number = 0;
        while (number <= 0) //check while negative number
        {
            Console.Write("Enter Positive Int Number: ");
            number = int.Parse(Console.ReadLine());
        }
        char[] reverse = number.ToString().ToCharArray(); //convert number to string 
        Array.Reverse(reverse); //reverse string
        string reverseNo = new string(reverse); //make new string from reverse number
        reverseNo = number.ToString() + reverseNo; //concation orginal and reverse
        Console.WriteLine(reverseNo);

    }



}
