// كل واحد يسوي كلاس بيه شغله وطبعا على فرع باسمه
using ArrayAndListTasks;

Tasks task = new Tasks();

int[] numbers = task.ListOfNumbers(5);
if(numbers.Length > 0)
{
    foreach(int number in numbers)
    {
        Console.Write(number+", ");
    }
}