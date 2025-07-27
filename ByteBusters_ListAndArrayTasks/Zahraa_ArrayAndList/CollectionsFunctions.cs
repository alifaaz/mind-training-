using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zahraa_ArrayAndList;

namespace ZahraaCollections
{
    internal class CollectionsFunctions
    {
        // English: Create a list of 5 numbers.
        // Example (English): input: [1, 2, 3, 4, 5] -> output: [1, 2, 3, 4, 5]
        public static List<int> CreateListOfNumbers(int size = 5)
        {
            try
            {
                Helpers.ValidateInput(size);

                List<int> numbers = new List<int>();
                for (int i = 1; i <= size; i++)
                {
                    Console.Write($"Enter number {i}: ");
                    numbers.Add(int.Parse(Console.ReadLine()));
                }
                return numbers;
            }
            catch (Exception ex)
            {
                throw new Exception("CreateListOfNumbers expects a non-null integer. " + ex.Message);
            }

        }

        // English: Find the length of a list.
        // Example (English): input: [10, 20, 30] -> output: 3
        public static int FindLengthOfList(List<int> numbers)
        {
            try
            {
                Helpers.ValidateInput(numbers);

                if (numbers == null)
                    throw new ArgumentNullException(nameof(numbers), "The list cannot be null.");
                return numbers.Count;
            }
            catch (Exception ex)
            {
                throw new Exception("FindLengthOfList expects a non-null integer. " + ex.Message);
            }

        }

        // English: Access the first and last element of a list.
        // Example (English): input: [5, 10, 15, 20] -> output: 5 and 20

        public static void FirstAndLastElement(List<int> numbers)
        {
            try
            {
                Helpers.ValidateInput(numbers);
                int first = numbers[0];
                int last = numbers[numbers.Count - 1];
                Console.WriteLine($"{first} and {last}");
            }
            catch (Exception ex)
            {
                throw new Exception("FirstAndLastElement expects a non-null integer. " + ex.Message);
            }
        }

        //Append an item to a list.
        //Example input: [1, 2, 3] -> append(4) -> [1, 2, 3, 4]
        public static List<int> AppendItem(List<int> numbers, int item)
        {
            try
            {
                Helpers.ValidateInput(numbers);

                numbers.Add(item);
                return numbers;
            }
            catch (Exception ex)
            {
                throw new Exception("AppendItem expects a non-null integer. " + ex.Message);
            }
        }

        // English: Remove an item from a list by value.
        // example: input: [1, 2, 3] -> remove(2) -> [1, 3]
        public static List<int> RemoveItemByValue(List<int> numbers, int value)
        {
            try
            {
                Helpers.ValidateInput(numbers);

                numbers.Remove(value);
                return numbers;
            }
            catch (Exception ex)
            {
                throw new Exception("RemoveItemByValue expects a non-null integer. " + ex.Message);
            }
        }

        // Sort a list of numbers in ascending order.
        //Example (English): input: [3, 1, 2] -> sorted -> [1, 2, 3]
        public static List<int> SortAscending(List<int> numbers)
        {
            try
            {
                Helpers.ValidateInput(numbers);
                numbers.Sort();
                return numbers;
            }
            catch (Exception ex)
            {
                throw new Exception("SortAscending expects a non-null integer. " + ex.Message);
            }
        }

        // Reverse the elements in a list.
        // Example (English): input: [1, 2, 3] -> reversed -> [3, 2, 1]
        public static List<int> ReverseList(List<int> numbers)
        {
            try
            {
                Helpers.ValidateInput(numbers);
                numbers.Reverse();
                return numbers;
            }
            catch (Exception ex)
            {
                throw new Exception("ReverseList expects a non-null integer. " + ex.Message);
            }
        }

        // Check if a value exists in a list
        //Example(English) : input: [1, 2, 3] -> check 2 -> True
        public static bool ContainsValue(List<int> numbers, int value)
        {
            try
            {
                Helpers.ValidateInput(numbers);
                return numbers.Contains(value);
            }
            catch (Exception ex)
            {
                throw new Exception("ContainsValue expects a non-null integer. " + ex.Message);
            }
        }

        // Count how many times a value appears in a list.
        // Example(English) : input: [1, 2, 2, 3] -> count(2) -> 2
        public static int CountValueOccurrences(List<int> numbers, int value)
        {
            try
            {
                Helpers.ValidateInput(numbers);
                int count = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == value)
                    {
                        count++;
                    }
                }
                return count;
            }
            catch (Exception ex)
            {
                throw new Exception("CountValueOccurrences expects a non-null integer. " + ex.Message);
            }
        }

        // Get the index of a specific value in a list.
        // Example (English): input: [4, 5, 6] -> index(5) -> 1
        public static int GetIndexOfValue(List<int> numbers, int value)
        {
            try
            {
                Helpers.ValidateInput(numbers);
                return numbers.IndexOf(value);
            }
            catch (Exception ex)
            {
                throw new Exception("GetIndexOfValue expects a non-null integer. " + ex.Message);
            }
        }

        // Concatenate two lists together.
        // Example(English) : input: [1, 2] + [3, 4] -> [1, 2, 3, 4]
        public static List<int> ConcatenateLists(List<int> list1, List<int> list2)
        {
            try
            {
                Helpers.ValidateInput(list1);
                Helpers.ValidateInput(list2);
                List<int> concatenatedList = new List<int>(list1);
                concatenatedList.AddRange(list2);
                return concatenatedList;
            }
            catch (Exception ex)
            {
                throw new Exception("ConcatenateLists expects non-null integers. " + ex.Message);
            }
        }

        // Slice a list to get the first 3 elements.
        // Example(English) : input: [5, 6, 7, 8] -> [:3] -> [5, 6, 7]
        public static List<int> SliceList(List<int> numbers, int count = 3)
        {
            try
            {
                Helpers.ValidateInput(numbers);
                // Take will return the first 'count' elements from the list and ToList will convert it to a List<int>
                return numbers.Take(count).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("SliceList expects a non-null integer. " + ex.Message);
            }
        }

        // Clear all items from a list.
        // Example(English) : input: [1, 2, 3] -> clear() -> []
        public static List<int> ClearList(List<int> numbers)
        {
            try
            {
                Helpers.ValidateInput(numbers);
                numbers.Clear();
                return numbers;
            }
            catch (Exception ex)
            {
                throw new Exception("ClearList expects a non-null integer. " + ex.Message);
            }
        }

        // Insert a value at index 2.
        // Example (English): input: [0, 1, 2] -> insert(2, 5) -> [0, 1, 5, 2]
        public static List<int> InsertValueAtIndex(List<int> numbers, int index, int value)
        {
            try
            {
                Helpers.ValidateInput(numbers);
                if (index < 0 || index > numbers.Count)
                    throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                numbers.Insert(index, value);
                return numbers;
            }
            catch (Exception ex)
            {
                throw new Exception("InsertValueAtIndex expects a non-null integer. " + ex.Message);
            }
        }

        // Filter out even numbers from a list.
        // Example (English): input: [1, 2, 3, 4] -> output: [1, 3]
        public static List<int> FilterEvenNumbers(List<int> numbers)
        {
            try
            {
                Helpers.ValidateInput(numbers);
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        numbers.RemoveAt(i);
                    }
                }
                return numbers;
            }
            catch (Exception ex)
            {
                throw new Exception("FilterEvenNumbers expects a non-null integer. " + ex.Message);
            }
        }

        /*English: Remove duplicates from a list.
          Example (English): input: [1, 2, 2, 3] -> output: [1, 2, 3]*/
        public static List<int> RemoveDuplicates(List<int> numbers)
        {
            try
            {
                Helpers.ValidateInput(numbers);
                // The hashset will automatically handle duplicates مثل ما شرح استاذ محمد في المحاضرة
                HashSet<int> uniqueNumbers = new HashSet<int>(numbers);
                return uniqueNumbers.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("RemoveDuplicates expects a non-null integer. " + ex.Message);
            }
        }

        // Find the maximum and minimum in a list.
        // Example (English): input: [5, 3, 9] -> max=9, min=3
        public static void FindMaxAndMin(List<int> numbers)
        {
            try
            {
                Helpers.ValidateInput(numbers);
                Helpers.IsEmpty(numbers);

                int max = numbers[0];
                int min = numbers[0];
                foreach (int number in numbers)
                {
                    if (number > max)
                        max = number;
                    if (number < min)
                        min = number;
                }
                Console.WriteLine($"max={max}, min={min}");
            }
            catch (Exception ex)
            {
                throw new Exception("FindMaxAndMin expects a non-null integer. " + ex.Message);
            }
        }

        // Sum all elements in a list.
        public static int SumAllElements(List<int> numbers)
        {
            try
            {
                Helpers.ValidateInput(numbers);
                Helpers.IsEmpty(numbers);

                return numbers.Sum();
            }
            catch (Exception ex)
            {
                throw new Exception("SumAllElements expects a non-null integer. " + ex.Message);
            }
        }

        // Create a list from a string of comma-separated numbers.
        // Example (English): input: '1,2,3' -> ['1','2','3']

        public static List<int> CreateListFromString(string input)
        {
            try
            {
                Helpers.ValidateInput(input);

                // Split the input string by commas and convert each part to an integer then return as a list
                List<int> numbers = input.Split(',').Select(int.Parse).ToList();
                return numbers;
            }
            catch (Exception ex)
            {
                throw new Exception("CreateListFromString expects a non-null string. " + ex.Message);
            }
        }

        // Convert all strings in a list to lowercase.
        // Example (English): input: ['Hi', 'There'] -> ['hi', 'there']
        public static List<string> ConvertToLowercase(List<string> strings)
        {
            try
            {
                Helpers.ValidateInput(strings);
                for (int i = 0; i < strings.Count; i++)
                {
                    strings[i] = strings[i].ToLower();
                }
                return strings;
            }
            catch (Exception ex)
            {
                throw new Exception("ConvertToLowercase expects a non-null string. " + ex.Message);
            }
        }

        // Find the average of a list of grades.
        // Example (English): input: [90, 80, 100] -> average=90

        public static double FindAverage(List<int> grades)
        {
            try
            {
                Helpers.ValidateInput(grades);
                Helpers.IsEmpty(grades);

                return grades.Average();
            }
            catch (Exception ex)
            {
                throw new Exception("FindAverage expects a non-null integer. " + ex.Message);
            }
        }

        // Create a sublist from a list based on condition.
        // Example (English): input: [1, 2, 3, 4] -> filter >2 -> [3,4]
        public static List<int> ConditionalSublist(List<int> numbers, int threshold = 2)
        {
            try
            {
                Helpers.ValidateInput(numbers);
                Helpers.IsEmpty(numbers);
                // Here we are filtering the numbers that are greater than the threshold
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= threshold)
                    {
                        numbers.RemoveAt(i);
                        i--; // Adjust index after removal
                    }
                }
                return numbers;
            }
            catch (Exception ex)
            {
                throw new Exception("ConditionalSublist expects a non-null integer. " + ex.Message);
            }
        }

        // Split a list into chunks of 3 items.
        // Example(English) : input: [1, 2, 3, 4, 5, 6, 7, 8] -> [[1, 2, 3],[4, 5, 6],[7, 8]]
        public static void SplitIntoChunks(List<int> numbers, int chunkSize = 3)
        {
            try
            {
                Helpers.ValidateInput(numbers);
                Helpers.IsEmpty(numbers);

                for (int i = 0; i < numbers.Count; i += chunkSize)
                {
                    Console.Write("[[");
                    for (int j = i; j < i + chunkSize && j < numbers.Count; j++)
                    {
                        Console.Write(numbers[j]);
                        if (j < i + chunkSize - 1 && j < numbers.Count - 1)
                            Console.Write(", ");
                    }
                    Console.Write("]]");
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                throw new Exception("SplitIntoChunks expects a non-null integer. " + ex.Message);
            }
        }

        // flatten a list of lists into a single list.
        public static List<T> Flatten<T>(List<List<T>> list)
        {
            try
            {
                Helpers.IsEmpty(list);
                // Using SelectMany to flatten the list of lists into a single list
                // (sublist => sublist) means we are selecting each sublist and flattening it
                return list.SelectMany(sublist => sublist).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Flatten expects a non-null list of lists. " + ex.Message);
            }
        }

        // Get unique elements from a list
        public static List<T> GetUniqueElements<T>(List<T> list)
        {
            try
            {
                Helpers.IsEmpty(list);

                return new HashSet<T>(list).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("GetUniqueElements expects a non-null list. " + ex.Message);
            }
        }

        // Validate if two lists have the same elements regardless of order.
        public static bool Compare2Lists<T>(List<T> list1, List<T> list2)
        {
            try
            {
                Helpers.ValidateInput(list1);
                Helpers.ValidateInput(list2);

                // Using HashSet to compare the two lists
                return new HashSet<T>(list1).SetEquals(list2);
            }
            catch (Exception ex)
            {
                throw new Exception("AreListsEqual expects non-null lists. " + ex.Message);
            }
        }

        // Count how many strings start with a specific letter.
        // Example(English) : input: ['apple', 'banana'] -> startswith 'a' -> 1
        public static int CountStringsStartingWith(List<string> strings, char letter)
        {
            try
            {
                Helpers.ValidateInput(strings);
                Helpers.IsEmpty(strings);

                int count = 0;
                foreach (var str in strings)
                {
                    if (str.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        count++;
                    }
                }
                return count;
            }
            catch (Exception ex)
            {
                throw new Exception("CountStringsStartingWith expects a non-null list of strings. " + ex.Message);
            }
        }

    }
}
