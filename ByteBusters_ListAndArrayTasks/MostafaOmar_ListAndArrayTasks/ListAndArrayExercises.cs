using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ListAndArrayTasks
{
    public static class ListAndArrayExercises
    {
        //Exercise 1    
        //English: Create a list of 5 numbers.
        //Arabic: أنشئ قائمة تحتوي على 5 أرقام.
        //Kurdish: لیستیەک دروست بکە کە ٥ ژمارە تێدایە.
        //Example (English): input: [1, 2, 3, 4, 5]
        //     (بالعربية): الإدخال: [1، 2، 3، 4، 5]
        //----------------------------------------
        public static void CreateListOfNumbers()
        {
            try
            {
                // Create a list
                List<float> numbers = new List<float>();
                float number;

                Console.WriteLine("Enter 5 numbers");

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Number " + (i + 1) + ": ");
                    string input = Console.ReadLine();
                    // Check If input is A number or not
                    if (ValidateInput.IsValidNumber(input))
                    {
                        number = float.Parse(input);
                        numbers.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Error, Ur input is not A number!");
                        // repeat the same i So we stuck in loop if the user keep entering wrong input
                        i--; 
                    }
                }
                // Print the List
                Console.WriteLine("The Numbers That U enterd in the List");
                foreach (float num in numbers)
                {
                    Console.WriteLine(num);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown Error! Please Try Again" + ex.Message);
            }
        }
        //Exercise 2    
        //English: Find the length of a list.
        //Arabic: أوجد طول القائمة.
        //Kurdish: درێژی لیستەکە بدۆزەرەوە.
        //Example (English): input: [10, 20, 30] -> output: 3
        //     (بالعربية): الإدخال: [10، 20، 30] ← الناتج: 3
        //    
        public static string FindLentghOfAlist()
        {
            try
            {
                // here i created a class with function to create a list
                List<string> MyList = Helpers.CreateListUntilStop();

                Console.WriteLine("\nItems you entered:");
                foreach (string item in MyList)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-----------------");
                return $"The Length Of MY LIST IS '{MyList.Count}'";
            }
            catch(Exception ex)
            {
                return "Unknown Error" + ex.Message;
            }
        }
        //Exercise 3    
        //English: Access the first and last element of a list.
        //Arabic: الوصول إلى أول وآخر عنصر في القائمة.
        //Kurdish: دەستیپێکی و کۆتایی لیستەکە ببینە.
        //Example (English): input: [5, 10, 15, 20] -> output: 5 and 20
        //     (بالعربية): الإدخال: [5، 10، 15، 20] ← الناتج: 5 و 20
        //    
        public static string AccessFirstAndLastElemenOfList()
        {
            try
            {
                List<string> MyList = Helpers.CreateListUntilStop();

                Console.WriteLine("\nItems you entered:");
                foreach (string item in MyList)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-----------------");
                
                return $"First input '{MyList[0]}', And last Input '{MyList[MyList.Count() - 1]}'";
            }
            catch (Exception ex)
            {
                return "Unknown Error" + ex.Message;
            }
        }
        //Exercise 4    
        //English: Append an item to a list.
        //Arabic: أضف عنصرًا إلى نهاية القائمة.
        //Kurdish: وشەیەک زیاد بکە بۆ لیستەکە.
        //Example (English): input: [1, 2, 3] -> append(4) -> [1, 2, 3, 4]
        //     (بالعربية): الإدخال: [1، 2، 3] ← أضف 4 ← [1، 2، 3، 4]
        //   
        public static void AppendItemToList()
        {
            try
            {
                List<string> MyList = Helpers.CreateListUntilStop();

                // here is a function i create to help me print the list 
                Helpers.PrintList("Items you entered", MyList);

                // we dont have append in list so i used add
                MyList.Add("I ADD THIS BY 'add'");
                Helpers.PrintList("List After append", MyList);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown Error" + ex.Message); 
            }
        }
        //Exercise 5    
        //English: Remove an item from a list by value.
        //Arabic: أزل عنصرًا من القائمة باستخدام قيمته.
        //Kurdish: وشەیەک بسڕەوە بە بەکارهێنانی نرخەکە.
        //Example (English): input: [1, 2, 3] -> remove(2) -> [1, 3]
        //     (بالعربية): الإدخال: [1، 2، 3] ← احذف 2 ← [1، 3]
        //    
        public static void RemoveAnItemFromList()
        {
            try
            {
                List<string> MyList = Helpers.CreateListUntilStop();

                Helpers.PrintList("Items you entered", MyList);

                //I will delet item here
                Console.Write("Enter the index (start from 0) of the item u want to delete: ");
                int IndexOfDeletedItem = int.Parse(Console.ReadLine());

                MyList.RemoveAt(IndexOfDeletedItem);
                Helpers.PrintList("List After append", MyList);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown Error" + ex.Message);
            }
        }
        //Exercise 6    
        //English: Sort a list of numbers in ascending order.
        //Arabic: رتّب قائمة الأرقام تصاعديًا.
        //Kurdish: لیستی ژمارەکان بە شێوەی زیادبوون ڕیز بکە.
        //Example (English): input: [3, 1, 2] -> sorted -> [1, 2, 3]
        //     (بالعربية): الإدخال: [3، 1، 2] ← بعد الترتيب ← [1، 2، 3]
        //  
        public static void SortAlistOfNumbersInAscending()
        {
            try
            {
                List<string> MyList = Helpers.CreateListUntilStop();

                Helpers.PrintList("Items you entered", MyList);
                MyList.Sort();
                Helpers.PrintList("List After Ordeer", MyList);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown Error" + ex.Message);
            }
        }
        //Exercise 7    
        //English: Reverse the elements in a list.
        //Arabic: اعكس ترتيب العناصر في القائمة.
        //Kurdish: ڕیزبەندی لیستەکە بگۆڕە بۆ دواوە.
        //Example (English): input: [1, 2, 3] -> reversed -> [3, 2, 1]
        //     (بالعربية): الإدخال: [1، 2، 3] ← المعكوس ← [3، 2، 1]
        //    
        public static void ReverseTheElemntInTheList()
        {
            try
            {
                List<string> MyList = Helpers.CreateListUntilStop();

                Helpers.PrintList("Items you entered", MyList);
                MyList.Reverse();
                Helpers.PrintList("List After Reversed", MyList);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown Error" + ex.Message);
            }
        }
        //Exercise 8    
        //English: Check if a value exists in a list.
        //Arabic: تحقق مما إذا كانت قيمة موجودة في القائمة.
        //Kurdish: پشکنین بکە ئەگەر نرخێک لە لیستەکەدا هەیە.
        //Example (English): input: [1, 2, 3] -> check 2 -> True
        //     (بالعربية): الإدخال: [1، 2، 3] ← تحقق من 2 ← صحيح
        //    
        public static bool CheckIfItemInList()
        {
            try
            {
                List<string> MyList = Helpers.CreateListUntilStop();

                Helpers.PrintList("Items you entered", MyList);

                string CheckedInput;
                Console.WriteLine("Enter the value to check if it exists or not: ");
                CheckedInput = Console.ReadLine();

                return MyList.Contains(CheckedInput) ? true : false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown Error" + ex.Message);
                return false;
            }
        }
        //Exercise 9    
        //English: Count how many times a value appears in a list.
        //Arabic: عدّ عدد مرات ظهور قيمة معينة في القائمة.
        //Kurdish: ژمارەی جارەکانی دانانی نرخێک بدۆزەرەوە.
        //Example (English): input: [1, 2, 2, 3] -> count(2) -> 2
        //     (بالعربية): الإدخال: [1، 2، 2، 3] ← عدد 2 ← 2
        //  

        public static int CheckValueAppearsInList()
        {
            try
            {
                List<string> MyList = Helpers.CreateListUntilStop();
                Helpers.PrintList("Items you entered", MyList);
               
                Console.Write("Enter The Value to check How Many times It shown: ");
                string CheckValueAppears = Console.ReadLine();
                int AppearsInList = 0;
                foreach (string appears in MyList)
                {
                    if (appears == CheckValueAppears)
                        AppearsInList++;
                }
                return AppearsInList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown Error" + ex.Message);
                return 0;
            }
        }
        //Exercise 10    
        //English: Get the index of a specific value in a list.
        //Arabic: احصل على موقع (فهرس) قيمة معينة في القائمة.
        //Kurdish: شوێنی (index) نرخێک لە لیستەکەدا بدۆزەرەوە.
        //Example (English): input: [4, 5, 6] -> index(5) -> 1
        //     (بالعربية): الإدخال: [4، 5، 6] ← موقع 5 ← 1
        //   
        public static string GetIndexValue()
        {
            try
            {
                List<string> MyList = Helpers.CreateListUntilStop();

                Helpers.PrintList("Items you entered", MyList);

                Console.Write("Enter the index (start from 0) of the item u want to See: ");
                
                int IndexOfItem = int.Parse(Console.ReadLine());
                string Value = MyList[IndexOfItem];
                return $"Index Of {IndexOfItem} have The Value: {Value}";
            }
            catch (Exception ex)
            {
                return "Unknown Error" + ex.Message;

               
            }
        }


    }
}

        
       
      
          
         
        //Exercise 11    
        //English: Concatenate two lists together.
        //Arabic: ادمج قائمتين معًا.
        //Kurdish: دوو لیست بەیەکەوە پەیوەندیبکە.
        //Example (English): input: [1, 2] + [3, 4] -> [1, 2, 3, 4]
        //     (بالعربية): الإدخال: [1، 2] + [3، 4] ← [1، 2، 3، 4]
        //    
        //Exercise 12    
        //English: Slice a list to get the first 3 elements.
        //Arabic: جزّئ القائمة للحصول على أول 3 عناصر.
        //Kurdish: لە لیستەکە سێ یەکەم دانە هەڵبژێرە.
        //Example (English): input: [5, 6, 7, 8] -> [:3] -> [5, 6, 7]
        //     (بالعربية): الإدخال: [5، 6، 7، 8] ← [:3] ← [5، 6، 7]
        //    
        //Exercise 13    
        //English: Clear all items from a list.
        //Arabic: احذف جميع العناصر من القائمة.
        //Kurdish: هەموو دانەکانی لیستەکە بسڕەوە.
        //Example (English): input: [1, 2, 3] -> clear() -> []
        //     (بالعربية): الإدخال: [1، 2، 3] ← حذف الكل ← []
        //    Exercise 14    
        //
        //English: Copy a list into another variable.
        //Arabic: انسخ القائمة إلى متغير جديد.
        //Kurdish: لیستەکە بڵاو بکەوە بۆ گۆڕاوێکی نوێ.
        //Example (English): input: a = [1, 2, 3]; b = a.copy()
        //     (بالعربية): a = [1، 2، 3]؛ b = a.copy()
        //    
        //Exercise 15    
        //English: Insert a value at index 2.
        //Arabic: أدرج قيمة في الموقع الثاني من القائمة.
        //Kurdish: نرخیەک دابنێ لە شوێنی ٢یەم.
        //Example (English): input: [0, 1, 2] -> insert(2, 5) -> [0, 1, 5, 2]
        //     (بالعربية): الإدخال: [0، 1، 2] ← أدخل 5 عند الموضع 2 ← [0، 1، 5، 2]
        //    
        //Exercise 16    
        //English: Filter out even numbers from a list.
        //Arabic: احذف الأعداد الزوجية من القائمة.
        //Kurdish: ژمارەکانی جفت لە لیستەکە بسڕەوە.
        //Example (English): input: [1, 2, 3, 4] -> output: [1, 3]
        //     (بالعربية): الإدخال: [1، 2، 3، 4] ← الناتج: [1، 3]
        //    
        //Exercise 17    
        //English: Remove duplicates from a list.
        //Arabic: أزل العناصر المكررة من القائمة.
        //Kurdish: دووبارەبوونەوەکان لە لیستەکە بسڕەوە.
        //Example (English): input: [1, 2, 2, 3] -> output: [1, 2, 3]
        //     (بالعربية): الإدخال: [1، 2، 2، 3] ← الناتج: [1، 2، 3]
        //    
        //Exercise 18    
        //English: Find the maximum and minimum in a list.
        //Arabic: أوجد أكبر وأصغر قيمة في القائمة.
        //Kurdish: زۆرترین و کەمترین نرخ لە لیستەکە بدۆزەرەوە.
        //Example (English): input: [5, 3, 9] -> max=9, min=3
        //     (بالعربية): الإدخال: [5، 3، 9] ← الأكبر: 9، الأصغر: 3
        //    
        //Exercise 19    
        //English: Sum all elements in a list.
        //Arabic: اجمع جميع عناصر القائمة.
        //Kurdish: کۆی گشتی دانەکان لە لیستەکە هەژمەر بکە.
        //Example (English): input: [1, 2, 3] -> sum=6
        //     (بالعربية): الإدخال: [1، 2، 3] ← المجموع: 6
        //    
        //Exercise 20    
        //English: Create a list from a string of comma-separated numbers.
        //Arabic: حوّل سلسلة مفصولة بفواصل إلى قائمة.
        //Kurdish: جۆرەکانی String بە ',' ببە لیست.
        //Example (English): input: '1,2,3' -> ['1','2','3']
        //     (بالعربية): الإدخال: '1,2,3' ← ['1','2','3']
        //
        //    
        //Exercise 21    
        //English: Convert all strings in a list to lowercase.
        //Arabic: حوّل جميع النصوص في القائمة إلى حروف صغيرة.
        //Kurdish: هەموو نووسەکان بگۆڕە بۆ پیتە بچوک.
        //Example (English): input: ['Hi', 'There'] -> ['hi', 'there']
        //     (بالعربية): الإدخال: ['Hi', 'There'] ← ['hi', 'there']
        //    
        //Exercise 22    
        //English: Find the average of a list of grades.
        //Arabic: أوجد معدل الدرجات في القائمة.
        //Kurdish: ناوەڕۆکی لیستەکە بکاربێنە بۆ هەژمەرکردنی نمرەکان.
        //Example (English): input: [90, 80, 100] -> average=90
        //     (بالعربية): الإدخال: [90، 80، 100] ← المعدل: 90
        //    
        //Exercise 23    
        //English: Create a sublist from a list based on condition.
        //Arabic: أنشئ قائمة فرعية حسب شرط معين.
        //Kurdish: لیستێک دروست بکە کە سەر بە تایبەتمەندییەکەیە.
        //Example (English): input: [1, 2, 3, 4] -> filter >2 -> [3,4]
        //     (بالعربية): الإدخال: [1، 2، 3، 4] ← فلتر أكبر من 2 ← [3، 4]
        //    
        //Exercise 24    
        //English: Split a list into chunks of 3 items.
        //Arabic: قسّم القائمة إلى أجزاء كل منها يحتوي على 3 عناصر.
        //Kurdish: لیستەکە بە بەشەکان بنێرە، هەر بەش ٣ دانەی تێدایە.
        //Example (English): input: [1,2,3,4,5,6,7,8] -> [[1,2,3],[4,5,6],[7,8]]
        //     (بالعربية): الإدخال: [1،2،3،4،5،6،7،8] ← [[1،2،3]،[4،5،6]،[7،8]]
        //    
        //Exercise 25    
        //English: Sort a list of dictionaries by a key.
        //Arabic: رتب قائمة من القواميس حسب مفتاح معين.
        //Kurdish: لیستی Dictionary بە کلیدی دیاریکراو ڕیزبکە.
        //Example (English): input: [{'a': 2}, {'a': 1}] -> sort by 'a'
        //     (بالعربية): الإدخال: [{'a': 2}, {'a': 1}] ← الترتيب حسب a
        //    
        //Exercise 26    
        //English: Combine two lists into a dictionary (zip).
        //Arabic: ادمج قائمتين باستخدام zip لإنشاء قاموس.
        //Kurdish: دوو لیست بە zip پەیوەندیبکە بۆ دروستکردنی Dictionary.
        //Example (English): input: ['a','b'], [1,2] -> {'a':1, 'b':2}
        //     (بالعربية): الإدخال: ['a','b']، [1،2] ← {'a':1، 'b':2}
        //    
        //Exercise 27    
        //English: Flatten a list of lists.
        //Arabic: حوّل قائمة القوائم إلى قائمة واحدة.
        //Kurdish: لیستی لیستەکان ڕووڵ بکە بۆ لیستێکی یەکە.
        //Example (English): input: [[1,2],[3,4]] -> [1,2,3,4]
        //     (بالعربية): الإدخال: [[1،2]،[3،4]] ← [1،2،3،4]
        //    
        //Exercise 28    
        //English: Get unique elements from a list.
        //Arabic: احصل على العناصر الفريدة فقط.
        //Kurdish: دانەیەکی یەکجار دەرخستنی لیست بدۆزەرەوە.
        //Example (English): input: [1,2,2,3] -> [1,2,3]
        //     (بالعربية): الإدخال: [1،2،2،3] ← [1،2،3]
        //    
        //Exercise 29    
        //English: Rotate a list left by 2 positions.
        //Arabic: دوّر العناصر في القائمة لليسار بمقدار موقعين.
        //Kurdish: لیستەکە بگۆڕە بۆ پۆزیشنی ٢ لە چەپەوە.
        //Example (English): input: [1,2,3,4] -> [3,4,1,2]
        //     (بالعربية): الإدخال: [1،2،3،4] ← [3،4،1،2]
        //    
        //Exercise 30    
        //English: Count how many strings start with a specific letter.
        //Arabic: عد كم عدد النصوص التي تبدأ بحرف معين.
        //Kurdish: ژمارەی وشەکان کە بە پیتی دیاریکراو دەستپێدەکەن بپارێزە.
        //Example (English): input: ['apple', 'banana'] -> startswith 'a' -> 1
        //     (بالعربية): الإدخال: ['apple', 'banana'] ← تبدأ بـ a ← 1
        //    
        //Exercise 31    
        //English: Write a function to remove nested empty lists.
        //Arabic: اكتب دالة لإزالة القوائم الفارغة المتداخلة.
        //Kurdish: فانکشنی بۆ سڕینەوەی لیستی بەتاڵی ناوخۆ دروست بکە.
        //Example (English): input: [1, [], [2, []]] -> output: [1, [2]]
        //     (بالعربية): الإدخال: [1، []، [2، []]] ← الناتج: [1، [2]]
        //    
        //Exercise 32    
        //English: Group a list of words by their starting letter.
        //Arabic: جمّع الكلمات في القائمة حسب الحرف الأول.
        //Kurdish: وشەکان گروپ بکە بە پیتی دەستپێکەوەیان.
        //Example (English): input: ['apple', 'banana', 'apricot'] -> {'a': ['apple','apricot'], 'b': ['banana']}
        //     (بالعربية): الإدخال: ['apple', 'banana', 'apricot'] ← {'a': ['apple','apricot'], 'b': ['banana']}
        //    
        //Exercise 33    
        //English: Find the longest increasing subsequence in a list.
        //Arabic: أوجد أطول تسلسل تصاعدي في القائمة.
        //Kurdish: دروستکردنی زنجیرەی زیاتبوونی درێژترین.
        //Example (English): input: [1, 2, 3, 2, 3, 4, 5] -> output: [1, 2, 3, 4, 5]
        //     (بالعربية): الإدخال: [1، 2، 3، 2، 3، 4، 5] ← الناتج: [1، 2، 3، 4، 5]
        //    
        //Exercise 34    
        //English: Validate if two lists have the same elements regardless of order.
        //Arabic: تحقق مما إذا كانت قائمتان تحتويان على نفس العناصر بغض النظر عن الترتيب.
        //Kurdish: پشکنینی هاوشێوەیی دوو لیست، بەبێ تێچوونی ڕیز.
        //Example (English): input: [1, 2, 3], [3, 2, 1] -> True
        //    
        //Exercise 35    
        //English: Detect a duplicate with O(n) time and O(1) space.
        //Arabic: اكتشف العناصر المكررة باستخدام وقت O(n) ومساحة O(1).
        //Kurdish: دۆزینەوەی دووبارەبوون بە کاتی O(n) و بێ بەکارهێنانی بەرگەی زیات.
        //Example (English): input: [1,2,3,4,2] -> output: 2
        //    
        //Exercise 36    
        //English: Merge two sorted lists without using built-in sort.
        //Arabic: ادمج قائمتين مرتبتين بدون استخدام دوال الترتيب.
        //Kurdish: دوو لیستی ڕیزکراو بەیەکەوە بگرە بێ بەکارهێنانی sort.
        //Example (English): input: [1, 3, 5], [2, 4, 6] -> output: [1,2,3,4,5,6]
        //    
        //Exercise 37    
        //English: Find the intersection of multiple lists.
        //Arabic: أوجد العناصر المشتركة بين عدة قوائم.
        //Kurdish: یەکسانی لە ناو چەند لیست بدۆزەرەوە.
        //Example (English): input: [1,2,3], [2,3,4] -> output: [2,3]
        //    
        //Exercise 38    
        //English: Replace every nth element with a specific value.
        //Arabic: استبدل كل عنصر رقم n بقيمة محددة.
        //Kurdish: هەر دانەی nیەم لە لیست بگۆڕە بە نرخێکی دیاریکراو.
        //Example (English): input: [1,2,3,4,5] -> replace every 2nd -> [1,'x',3,'x',5]
        //    
        //Exercise 39    
        //English: Count frequency of items and return as dictionary.
        //Arabic: احسب تكرار العناصر وأرجعها كقاموس.
        //Kurdish: ژمارەی جارەکانی هەر نرخێک بپارێزە و وەک Dictionary پێشکەش بکە.
        //Example (English): input: [1,2,2,3,1,1] -> output: {1:3, 2:2, 3:1}
        //    
        //Exercise 40    
        //English: Chunk a list and process each chunk in parallel (conceptually).
        //Arabic: قسّم القائمة ونفّذ على كل جزء بشكل متوازٍ (مفاهيميًا).
        //Kurdish: لیستەکە بە بەشەکان بشکێنە و هەر بەش بە شێوەی parallel کاربکە (فکری).
        //Example (English): input: [1,2,3,4,5,6] -> chunks: [1,2], [3,4], [5,6]
        //    
    

