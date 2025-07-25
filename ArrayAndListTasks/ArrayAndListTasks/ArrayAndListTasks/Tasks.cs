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
            catch (Exception e)
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
                foreach (int i in numbers)
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
                if (numbers.Count >= 2)
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
        //------------------------------ Exercise 5 ----------------------------------------------------//
        //  أزل عنصرًا من القائمة باستخدام قيمته.
        public List<int> RemoveItemToList(List<int> numbers, int element)
        {
            try
            {
                if (numbers.Count > 0)
                    if (numbers.Contains(element))
                        numbers.Remove(element);
                    else
                        return numbers;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return numbers;
        }
        //------------------------------ Exercise 6 ----------------------------------------------------//
        //  رتّب قائمة الأرقام تصاعديًا.
        public List<int> SortList(List<int> numbers)
        {
            try
            {
                if (numbers.Count > 0)
                    numbers.Sort();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return numbers;
        }
        //------------------------------ Exercise 7 ----------------------------------------------------//
        //   اعكس ترتيب العناصر في القائمة.
        public List<int> ReverseList(List<int> numbers)
        {
            try
            {
                if (numbers.Count > 0)
                    numbers.Reverse();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return numbers;
        }
        //------------------------------ Exercise 8 ----------------------------------------------------//
        //  تحقق مما إذا كانت قيمة موجودة في القائمة.
        public bool isExists(List<int> numbers, int element)
        {
            try
            {
                if (numbers.Count > 0)
                    return numbers.Contains(element);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        //------------------------------ Exercise 9 ----------------------------------------------------//
        //    عدّ عدد مرات ظهور قيمة معينة في القائمة.
        public int CountElement(List<int> numbers, int element)
        {
            int count = 0;
            try
            {
                if (numbers.Count > 0)
                    foreach (var item in numbers)
                    {
                        if (item == element) count++;
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return count;
        }
        //------------------------------ Exercise 10 ----------------------------------------------------//
        //     احصل على موقع (فهرس) قيمة معينة في القائمة.
        public int IndexOfValue(List<int> numbers, int element)
        {
            int index = -1;
            try
            {
                if (numbers.Count > 0)
                    foreach (var item in numbers)
                    {
                        index++;
                        if (item == element)
                            return index;
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return -1;
        }
        //------------------------------ Exercise 11 ----------------------------------------------------//
        //   ادمج قائمتين معًا.
        public List<int> ConcatTwoLists(List<int> numbers1, List<int> numbers2)
        {
            try
            {
                if (numbers1.Count > 0 || numbers2.Count > 0)
                    foreach (var item in numbers2)
                    {
                        numbers1.Add(item);
                    }
                return numbers1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return numbers1;
        }
        //------------------------------ Exercise 12 ----------------------------------------------------//
        //  جزّئ القائمة للحصول على أول 3 عناصر. طبعا سويته عام فاي رقم ادخله يطع الك عدد العناصر
        public List<int> SliceList(List<int> numbers, int NoElement)
        {
            List<int> result = new List<int>() { };
            try
            {
                if (numbers.Count > 0 && NoElement < numbers.Count)
                {
                    for (int i = 0; i < NoElement; i++)
                    {
                        result.Add(numbers[i]);
                    }
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }
        //------------------------------ Exercise 13 ----------------------------------------------------//
        //  احذف جميع العناصر من القائمة.
        public List<int> ClearAll(List<int> numbers)
        {
            List<int> result = new List<int>() { };
            try
            {
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }
        //------------------------------ Exercise 14 ----------------------------------------------------//
        //  انسخ القائمة إلى متغير جديد.
        public List<int> CopyList(List<int> numbers)
        {
            List<int> result = new List<int>() { };
            try
            {
                if (numbers.Count > 0)
                    return result = numbers;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }
        //------------------------------ Exercise 15 ----------------------------------------------------//
        //  أدرج قيمة في الموقع الثاني من القائمة. او اي موقع حسب اي عنوان يرسل
        public List<int> InsertByIndex(List<int> numbers, int element, int index)
        {
            List<int> result = new List<int>() { };
            try
            {
                if (numbers.Count > 0 && index < numbers.Count)
                    for (int i = 0; i < numbers.Count; i++)
                        if (i == index)
                        {
                            result.Add(element);
                            result.Add(numbers[i]);
                        }
                        else
                            result.Add(numbers[i]);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }
        //------------------------------ Exercise 16 ----------------------------------------------------//
        //     احذف الأعداد الزوجية من القائمة.
        public List<int> FilterOutEvenEumbers(List<int> numbers)
        {
            List<int> result = new List<int>() { };
            try
            {
                if (numbers.Count > 0)
                    foreach (var item in numbers)
                    {
                        if (item % 2 != 0)
                            result.Add(item);                            
                    }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }
        //------------------------------ Exercise 17 ----------------------------------------------------//
        //   أزل العناصر المكررة من القائمة.
        public List<int> RemoveDuplicates(List<int> numbers)
        {
            List<int> result = new List<int>() { };
            try
            {
                if (numbers.Count > 0)
                    return result = numbers.Distinct().ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }
        //------------------------------ Exercise 18 ----------------------------------------------------//
        //  أوجد أكبر وأصغر قيمة في القائمة.
        public void MaxAndMin(List<int> numbers, out int maxElement, out int minElement)
        {
            maxElement = numbers[0];
            minElement = numbers[0];
            try
            {
                if (numbers.Count >= 2)
                {
                    maxElement = numbers.Max();
                    minElement = numbers.Min();
                }
                else
                {
                    maxElement = 0;
                    minElement = 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}


