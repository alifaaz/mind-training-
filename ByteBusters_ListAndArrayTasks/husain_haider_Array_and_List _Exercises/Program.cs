using System.Diagnostics.Metrics;


    internal class Program
{
    static void Main(string[] args)
    {

        CommaSeparatedToList();




        /*Exercise 1    
        English: Create a list of 5 numbers.
        Arabic: أنشئ قائمة تحتوي على 5 أرقام.
        Kurdish: لیستیەک دروست بکە کە ٥ ژمارە تێدایە.
        Example (English): input: [1, 2, 3, 4, 5]
        مثال (بالعربية): الإدخال: [1، 2، 3، 4، 5]
        */


        static void ListOfFiveNums()
        {

            Console.Write("enter the array contant:");
            String input = Console.ReadLine();

            //  truning input to array

            //  removing barket 
            String inputwithOutBrakets = input.Substring(1, input.IndexOf("]", 1) - 1);

            List<String> numbersList = inputwithOutBrakets.Split(",").ToList();

            foreach (String number in numbersList)
            {
                Console.WriteLine(number);
            }
        }






        /*Exercise 2    
        English: Find the length of a list.
        Arabic: أوجد طول القائمة.
        Kurdish: درێژی لیستەکە بدۆزەرەوە.
        Example (English): input: [10, 20, 30] -> output: 3
        مثال (بالعربية): الإدخال: [10، 20، 30] ← الناتج: 3


        */


        //  we can simply use the Count method

        static void LengthOfList()
        {
            List<int> numbers = new List<int> { 10, 20, 30 };
            Console.WriteLine(numbers.Count);
        }



        /*Exercise 3    
        English: Access the first and last element of a list.
        Arabic: الوصول إلى أول وآخر عنصر في القائمة.
        Kurdish: دەستیپێکی و کۆتایی لیستەکە ببینە.
        Example (English): input: [5, 10, 15, 20] -> output: 5 and 20
        مثال (بالعربية): الإدخال: [5، 10، 15، 20] ← الناتج: 5 و 20
        */



        //  we can simply use the First and last methodes

        static void LastElement()
        {
            List<int> numbers = new List<int> { 5, 10, 15, 20 };
            int firstElement = numbers.First();
            int lastElement = numbers.Last();
            Console.WriteLine(firstElement + " is the first and " + lastElement + " is the last");
        }


        /*Exercise 4    
        English: Append an item to a list.
        Arabic: أضف عنصرًا إلى نهاية القائمة.
        Kurdish: وشەیەک زیاد بکە بۆ لیستەکە.
        Example (English): input: [1, 2, 3] -> append(4) -> [1, 2, 3, 4]
        مثال (بالعربية): الإدخال: [1، 2، 3] ← أضف 4 ← [1، 2، 3، 4]
        */

        //  we can simply use the add method
        static void append(int numberEneteredToList = 4)
        {
            List<int> input = new List<int> { 1, 2, 3 };
            input.Add(numberEneteredToList);
            foreach (int number in input)
            {
                Console.WriteLine(number);
            }

        }

        /*Exercise 5    
        English: Remove an item from a list by value.
        Arabic: أزل عنصرًا من القائمة باستخدام قيمته.
        Kurdish: وشەیەک بسڕەوە بە بەکارهێنانی نرخەکە.
        Example (English): input: [1, 2, 3] -> remove(2) -> [1, 3]
        مثال (بالعربية): الإدخال: [1، 2، 3] ← احذف 2 ← [1، 3]
        */


        //  we can simply use the remove method

        static void RemoveLastElemnt(int numberRemovedFromList = 2)
        {
            List<int> input = new List<int> { 1, 2, 3 };
            input.Remove(numberRemovedFromList);
            foreach (int number in input)
            {
                Console.WriteLine(number);
            }

        }

        /*Exercise 6    
        English: Sort a list of numbers in ascending order.
        Arabic: رتّب قائمة الأرقام تصاعديًا.
        Kurdish: لیستی ژمارەکان بە شێوەی زیادبوون ڕیز بکە.
        Example (English): input: [3, 1, 2] -> sorted -> [1, 2, 3]
        مثال (بالعربية): الإدخال: [3، 1، 2] ← بعد الترتيب ← [1، 2، 3]

        */


        //  we can simply use the sort method
        static void SortingList()
        {
            List<int> input = new List<int> { 3, 1, 2 };

            input.Sort();
            foreach (int number in input)
            {
                Console.WriteLine(number);
            }

        }



        /*Exercise 7    
        English: Reverse the elements in a list.
        Arabic: اعكس ترتيب العناصر في القائمة.
        Kurdish: ڕیزبەندی لیستەکە بگۆڕە بۆ دواوە.
        Example (English): input: [1, 2, 3] -> reversed -> [3, 2, 1]
        مثال (بالعربية): الإدخال: [1، 2، 3] ← المعكوس ← [3، 2، 1]

        */



        //  we can simply use the Reverse method
        static void ReverseSortingList()
        {
            List<int> input = new List<int> { 1, 2, 3 };

            input.Reverse();
            foreach (int number in input)
            {
                Console.WriteLine(number);
            }

        }

        /*    
        Exercise 8    
        English: Check if a value exists in a list.
        Arabic: تحقق مما إذا كانت قيمة موجودة في القائمة.
        Kurdish: پشکنین بکە ئەگەر نرخێک لە لیستەکەدا هەیە.
        Example (English): input: [1, 2, 3] -> check 2 -> True
        مثال (بالعربية): الإدخال: [1، 2، 3] ← تحقق من 2 ← صحيح

        */


        //  we can simply use the Contains method
        static void CheckValue(int checkValue = 2)
        {
            List<int> input = new List<int> { 1, 2, 3 };


            Console.WriteLine(input.Contains(checkValue));

        }




        /*Exercise 9    
        English: Count how many times a value appears in a list.
        Arabic: عدّ عدد مرات ظهور قيمة معينة في القائمة.
        Kurdish: ژمارەی جارەکانی دانانی نرخێک بدۆزەرەوە.
        Example (English): input: [1, 2, 2, 3] -> count(2) -> 2
        مثال (بالعربية): الإدخال: [1، 2، 2، 3] ← عدد 2 ← 2

        */

        //  we use foreach to check for repetition within the list

        static void repetitionValue(int checkValue = 2)
        {
            List<int> input = new List<int> { 1, 2, 2, 3 };

            int counter = 0;    // count times of repetition
            foreach (int number in input)
            {
                if (number == checkValue)
                { counter++; }
            }


            Console.WriteLine(counter);

        }



        /*   
        Exercise 10    
        English: Get the index of a specific value in a list.
        Arabic: احصل على موقع (فهرس) قيمة معينة في القائمة.
        Kurdish: شوێنی (index) نرخێک لە لیستەکەدا بدۆزەرەوە.
        Example (English): input: [4, 5, 6] -> index(5) -> 1
        مثال (بالعربية): الإدخال: [4، 5، 6] ← موقع 5 ← 1
         */




        //  we can simply use the IndexOf method
        static void idexOfValueInList(int checkValue = 5)
        {
            List<int> input = new List<int> { 4, 5, 6 };


            Console.WriteLine(input.IndexOf(5));

        }




        /*    
        Exercise 11    
        English: Concatenate two lists together.
        Arabic: ادمج قائمتين معًا.
        Kurdish: دوو لیست بەیەکەوە پەیوەندیبکە.
        Example (English): input: [1, 2] + [3, 4] -> [1, 2, 3, 4]
        مثال (بالعربية): الإدخال: [1، 2] + [3، 4] ← [1، 2، 3، 4]

        */



        //  we can simply use the AddRange   method
        static void ConcatenateLists()
        {
            List<int> List1 = new List<int> { 1, 2 };
            List<int> List2 = new List<int> { 3, 4 };


            //  adding the second list on the end of the first list

            List1.AddRange(List2);

            foreach (int number in List1)
            {
                Console.WriteLine(number);
            }


        }

        /*    
        Exercise 12    
        English: Slice a list to get the first 3 elements.
        Arabic: جزّئ القائمة للحصول على أول 3 عناصر.
        Kurdish: لە لیستەکە سێ یەکەم دانە هەڵبژێرە.
        Example (English): input: [5, 6, 7, 8] -> [:3] -> [5, 6, 7]
        مثال (بالعربية): الإدخال: [5، 6، 7، 8] ← [:3] ← [5، 6، 7]

        */


        static void SliceFirstThreeElements()
        {
            List<int> input = new List<int> { 5, 6, 7, 8 };

            var output = input.Slice(0, 3);
            foreach (int number in output)
            {
                Console.WriteLine(number);


            }

        }


        /*    
        Exercise 13    
        English: Clear all items from a list.
        Arabic: احذف جميع العناصر من القائمة.
        Kurdish: هەموو دانەکانی لیستەکە بسڕەوە.
        Example (English): input: [1, 2, 3] -> clear() -> []
        مثال (بالعربية): الإدخال: [1، 2، 3] ← حذف الكل ← []

        */


        static void ClearList()
        {
            List<int> input = new List<int> { 3, 1, 2 };

            input.Clear();
            foreach (int number in input)
            {
                Console.WriteLine(number);
            }

        }



        /*    Exercise 14    

        English: Copy a list into another variable.
        Arabic: انسخ القائمة إلى متغير جديد.
        Kurdish: لیستەکە بڵاو بکەوە بۆ گۆڕاوێکی نوێ.
        Example (English): input: a = [1, 2, 3]; b = a.copy()
        مثال (بالعربية): a = [1، 2، 3]؛ b = a.copy()
        */



        // there isnt much to explain here
        // i just made a copy using equal sign

        static void CopyList()
        {
            List<int> original = new List<int> { 1, 2, 3 };
            List<int> Copy1 = new List<int>(original);


            foreach (int number in Copy1)
            {
                Console.WriteLine(number);
            }

        }


        /*
        Exercise 15    
        English: Insert a value at index 2.
        Arabic: أدرج قيمة في الموقع الثاني من القائمة.
        Kurdish: نرخیەک دابنێ لە شوێنی ٢یەم.
        Example (English): input: [0, 1, 2] -> insert(2, 5) -> [0, 1, 5, 2]
        مثال (بالعربية): الإدخال: [0، 1، 2] ← أدخل 5 عند الموضع 2 ← [0، 1، 5، 2]

        */

        //  we slimpy use the Insert method 


        static void InsertList(int position = 2, int InsertedValue = 5)
        {
            List<int> input = new List<int> { 0, 1, 2 };


            input.Insert(position, InsertedValue);

            foreach (int number in input)
            {
                Console.WriteLine(number);
            }

        }







        /*
        Exercise 16    
        English: Filter out even numbers from a list.
        Arabic: احذف الأعداد الزوجية من القائمة.
        Kurdish: ژمارەکانی جفت لە لیستەکە بسڕەوە.
        Example (English): input: [1, 2, 3, 4] -> output: [1, 3]
        مثال (بالعربية): الإدخال: [1، 2، 3، 4] ← الناتج: [1، 3]
        */


        static void FilterOutEven()
        {
            List<int> input = new List<int> { 1, 2, 3, 4 };

            int number;
            for (int numberIndex = 0; numberIndex < input.Count; numberIndex++)
            {
                number = input[numberIndex];
                if (number % 2 == 0)
                {
                    input.RemoveAt(numberIndex);
                }
            }

            Console.WriteLine("[" + String.Join(',', input) + "]");
        }



        /*    
        Exercise 17    
        English: Remove duplicates from a list.
        Arabic: أزل العناصر المكررة من القائمة.
        Kurdish: دووبارەبوونەوەکان لە لیستەکە بسڕەوە.
        Example (English): input: [1, 2, 2, 3] -> output: [1, 2, 3]
        مثال (بالعربية): الإدخال: [1، 2، 2، 3] ← الناتج: [1، 2، 3]

        */



        //  we compare the number to the next of it if i its similar we remove it

        static void FilterOutDuplicate()
        {
            List<int> input = new List<int> { 1, 2, 2, 3 };

            int number;
            int nextNumber;

            //  the end is set to the number before the last so we can compare to the next of it (the last number)
            for (int numberIndex = 0; numberIndex < input.Count - 1; numberIndex++)
            {
                number = input[numberIndex];
                nextNumber = input[numberIndex + 1];
                if (number == nextNumber)
                {
                    input.RemoveAt(numberIndex);
                }
            }

            Console.WriteLine("[" + String.Join(',', input) + "]");
        }





        /*    
        Exercise 18    
        English: Find the maximum and minimum in a list.
        Arabic: أوجد أكبر وأصغر قيمة في القائمة.
        Kurdish: زۆرترین و کەمترین نرخ لە لیستەکە بدۆزەرەوە.
        Example (English): input: [5, 3, 9] -> max=9, min=3
        مثال (بالعربية): الإدخال: [5، 3، 9] ← الأكبر: 9، الأصغر: 3
        */



        static void MaxAndMinNumber()
        {
            //  we can simly use the max and min method to get maximum and minimum value
            List<int> input = new List<int> { 5, 3, 9  };

            int maxNumber = input.Max();
            int minNumber = input.Min();

            Console.WriteLine($"maximum number is:{maxNumber} and minimum number is: {minNumber}");
        }



        /*    
        Exercise 19    
        English: Sum all elements in a list.
        Arabic: اجمع جميع عناصر القائمة.
        Kurdish: کۆی گشتی دانەکان لە لیستەکە هەژمەر بکە.
        Example (English): input: [1, 2, 3] -> sum=6
        مثال (بالعربية): الإدخال: [1، 2، 3] ← المجموع: 6
        */



        static void SumList()
        {

            //  we simply use sum to get the sum of all elemnt of the list

            List<int> input = new List<int> { 1,2,3 };
            int SumOflist = input.Sum();

            Console.WriteLine($"the sum is {SumOflist}");
        }







        /*  
        Exercise 20    
        English: Create a list from a string of comma-separated numbers.
        Arabic: حوّل سلسلة مفصولة بفواصل إلى قائمة.
        Kurdish: جۆرەکانی String بە ',' ببە لیست.
        Example (English): input: '1,2,3' -> ['1','2','3']
        مثال (بالعربية): الإدخال: '1,2,3' ← ['1','2','3']
        */


        //  we can separate using split method then you can print result using join
        static void CommaSeparatedToList()
        {
            String input = "1,2,3";

            List<String> inputList = input.Split(',').ToList();

            Console.WriteLine("[" + String.Join(',', input) + "]");

        }




    }
}

