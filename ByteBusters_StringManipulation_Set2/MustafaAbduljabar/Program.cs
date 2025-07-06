// See https://aka.ms/new-console-template for more information
using strings;

Console.Write("Input string to Process: ");
string input = Console.ReadLine();
//Console.Write("Input prefex to check: ");
//string prefex = Console.ReadLine();

Console.WriteLine(StringHelper.ExtractPhoneNumber(input));
