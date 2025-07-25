// كل واحد يسوي كلاس بيه شغله وطبعا على فرع باسمه
using ArrayAndListTasks;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

Tasks task = new Tasks();

//int[] numbers = task.ListOfNumbers(5);
//if (numbers.Length > 0)
//{
//    foreach (int number in numbers)
//    {
//        Console.Write(number + ", ");
//    }
//}

//Console.WriteLine("Length of List = \t"+task.LengthOfList(new List<int>(){ 1, 3, 4, 5}));

//int first;
//int last;
//task.FirstAndLastElement(new List<int>() { 1, 3, 4, 5 }, out  first, out  last);
//Console.WriteLine("First element = {0} and Last Element {1}", first, last);

//List<int> numbers = new List<int>() { 1, 3, 4, 5 };
//numbers = task.AppendItemToList(numbers, 55);
//foreach (int number in numbers)
//{
//    Console.Write(number + ", ");
//}

//List<int> numbers = new List<int>() { 1, 3, 4, 5 };
//numbers = task.RemoveItemToList(numbers, 5);
//foreach (int number in numbers)
//{
//    Console.Write(number + ", ");
//}

//List<int> numbers = new List<int>() { 22, 3, 4, 5 };
//numbers = task.SortList(numbers);
//foreach (int number in numbers)
//{
//    Console.Write(number + ", ");
//}

//List<int> numbers = new List<int>() { 22, 3, 4, 5 };
//numbers = task.ReverseList(numbers);
//foreach (int number in numbers)
//{
//    Console.Write(number + ", ");
//}

//Console.WriteLine("is found = \t" + task.isExists(new List<int>() { 1, 3, 4, 5 }, 41));

//Console.WriteLine("count 4 in list = \t" + task.CountElement(new List<int>() { 1, 3, 4, 5, 4 }, 11));

//Console.WriteLine("index 4 in list = \t" + task.IndexOfValue(new List<int>() { 1, 3, 4, 5, 4 }, 3));

//List<int> numbers1 = new List<int>() { 22, 3, 4, 5 };
//List<int> numbers2 = new List<int>() { 2, 8, 14, 75 };
//numbers1 = task.ConcatTwoLists(numbers1, numbers2);
//foreach (int number in numbers1)
//{
//    Console.Write(number + ", ");
//}

//List<int> numbers = new List<int>() { 2, 8, 14, 75 };
//numbers = task.SliceList(numbers, 5);
//foreach (int number in numbers)
//{
//    Console.Write(number + ", ");
//}

//List<int> numbers = new List<int>() { 2, 8, 14, 75 };
//numbers = task.ClearAll(numbers);
//foreach (int number in numbers)
//{
//    Console.Write(number + ", ");
//}

//List<int> numbers = new List<int>() { 2, 8, 14, 75 };
//List<int> numbers1 = new List<int>();
//numbers1 = task.CopyList(numbers);
//foreach (int number in numbers1)
//{
//    Console.Write(number + ", ");
//}

//List<int> numbers = new List<int>() { 2, 8, 14, 75 };
//numbers = task.InsertByIndex(numbers, 99, 2);
//foreach (int number in numbers)
//{
//    Console.Write(number + ", ");
//}

List<int> numbers = new List<int>() { 2, 8, 14, 75, 3, 11 };
numbers = task.FilterOutEvenEumbers(numbers);
foreach (int number in numbers)
{
    Console.Write(number + ", ");
}