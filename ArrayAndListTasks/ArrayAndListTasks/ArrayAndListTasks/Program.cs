// كل واحد يسوي كلاس بيه شغله وطبعا على فرع باسمه
using ArrayAndListTasks;
using System.Collections.Generic;

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

int first;
int last;
task.FirstAndLastElement(new List<int>() { 1, 3, 4, 5 }, out  first, out  last);
Console.WriteLine("First element = {0} and Last Element {1}", first, last);


