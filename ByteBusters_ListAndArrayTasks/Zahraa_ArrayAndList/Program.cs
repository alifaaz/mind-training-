using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zahraa_ArrayAndList;

namespace ZahraaCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(7);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            //CollectionsFunctions.AppendItem(list, 6);
            //Helpers.PrintNumbers(list);
            //CollectionsFunctions.SplitIntoChunks(list);
            //CollectionsFunctions.ConditionalSublist(list);
            //Helpers.PrintNumbers(list);
            Console.WriteLine(CollectionsFunctions.FindAverage(list));
            //Helpers.PrintNumbers(CollectionsFunctions.RemoveDuplicates(list));
            ////Helpers.PrintNumbers(list);
            ////CollectionsFunctions.FirstAndLastElement(list);
            //string[] stringArray = { "Apple", "Banana", "cherry" };
            Helpers.PrintNumbers(CollectionsFunctions.CreateListFromString("1,2,3"));
            //List<string> lowerCaseStrings = CollectionsFunctions.ConvertToLowercase(stringArray.ToList());
            //Helpers.PrintStrings(lowerCaseStrings);

            List<List<int>> listOfLists = new List<List<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 4, 5, 6 },
                new List<int> { 7, 8, 9 }
            };
            Helpers.PrintNumbers(CollectionsFunctions.Flatten<int>(listOfLists));
            List<List<string>> listOfstrings = new List<List<string>>
            {
                new List<string> { "my","name" },
                new List<string> { "is" },
                new List<string> { "Zetta","sama" }
            };
            Helpers.PrintStrings(CollectionsFunctions.Flatten<string>(listOfstrings));


            List<int> list1 = new List<int> { 1, 2, 3 };
            //Helpers.PrintNumbers(CollectionsFunctions.InsertValueAtIndex(list1, 2,5));
            List<int> list2 = new List<int> { 3,2,2,2,1,3 };
            Console.WriteLine(CollectionsFunctions.Compare2Lists(list1, list2));
            
            Helpers.PrintNumbers(CollectionsFunctions.ReverseList(list1));
            Console.WriteLine(CollectionsFunctions.ContainsValue(list1,1));
            Helpers.PrintNumbers(CollectionsFunctions.ConcatenateLists(list1, list2));

            List<string> Fruits = new List<string> { "apple", "banana", "cherry", "avocado", "blueberry" };
            Console.WriteLine(CollectionsFunctions.CountStringsStartingWith(Fruits,'b'));
        }
    }
}