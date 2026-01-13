class StringManipulation
{
    static void Main()
    {
        // Question 1.
        compareVsUpperAndLower("qrs", "QRS");
        // Question 2.
    }

    /*
    1. Write C# Sharp program to demonstrate that the Compare(String, String, Boolean)
    method is equivalent to using ToUpper or ToLower when comparing strings.
    */
    static void compareVsUpperAndLower(string string1, string string2)
    {
        // Doing the Upper strings first
        string upperString1 = string1.ToUpper();
        string upperString2 = string2.ToUpper();

        bool usingUpper = upperString1 == upperString2;
        bool usingUpperCompare = String.Compare(string1, string2, true) == 0;

        Console.WriteLine($"This is the output of using: \nUpper: {usingUpper}\nCompare: {usingUpperCompare}");

        // Now, doing the Lower strings
        string lowerString1 = string1.ToLower();
        string lowerString2 = string2.ToLower();

        bool usingLower = lowerString1 == lowerString2;
        bool usingLowerCompare = String.Compare(string1, string2, true) == 0;

        Console.WriteLine($"This is the output of using: \nLower: {usingLower}\nCompare: {usingLowerCompare}");
    }

    /*

    */
}
