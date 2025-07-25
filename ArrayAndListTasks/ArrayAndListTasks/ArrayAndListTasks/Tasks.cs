using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndListTasks
{
    internal class Tasks
    {
        Random rnd = new Random();
        //------------------------------ Exercise 1 ----------------------------------------------------//
        // أنشئ قائمة تحتوي على 5 أرقام او حسب الرقم اللي ارسله للداله من استدعيها
        public int[] ListOfNumbers(int noElement)
        {
            try
            {
                int[] numbers = new int[noElement];
                for (int i = 0; i < noElement; i++)
                {
                    // اضيف اعداد عشوائيا بالعدد اللي اني نطيته
                    numbers[i] = rnd.Next(100);
                }
                return numbers;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }            
        }
        //------------------------------ Exercise 2 ----------------------------------------------------//
        // أوجد طول القائمة
        public int LengthOfList(List<int> numbers)
        {
            try
            {
                int lenList = 0;
                // افتر على كل العناصر وازيد العداد بمقدار واحد في كل عنصر
                foreach(int i in numbers)
                {
                    lenList++;
                }
                return lenList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        //------------------------------ Exercise 3 ----------------------------------------------------//
        // الوصول إلى أول وآخر عنصر في القائمة.
        public void FirstAndLastElement(List<int> numbers, out int firstElement, out int lastElement)
        {
            firstElement = 0;
            lastElement = 0;
            try
            {
                if(numbers.Count >= 2)
                {
                    firstElement = numbers[0];
                    // استخدمت داله التاسك اللي قبلها حتى ارجع طول ال List
                    lastElement = numbers[LengthOfList(numbers) - 1];
                }
                else
                {
                    firstElement = 0;
                    lastElement = 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //------------------------------ Exercise 4 ----------------------------------------------------//
        //  أضف عنصرًا إلى نهاية القائمة.
        public List<int> AppendItemToList(List<int> numbers, int element)
        {

            try
            {
                numbers.Add(element);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return numbers;
        }

    }
}


