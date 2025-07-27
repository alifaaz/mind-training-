using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfNumbers();
            FindListLength();
            FirstAndLastElm();
            AppendItems();
            RemoveElement(5);
            SortList();
            ReverseList();
            ValueExists(2);
            ValueAppearance(1);
            ConcatenateLists();
            First3Element();
            ClearList();
            CopyList();
            InsertToSpecificIndex(1, 33);
            OddNumbers();
            FindMaxInList();
            SumAllEleList();
            StringToList();
            LowercaseList();
            AvarageInList();
            Sublist();
            ThreeChunks();
            SortListDictionaries();
            FlattenListofLists();
            UniqueElement();
            StartSpecificLetter('a');
            GroupListsByStartingLetter();
            ValidateSameElements();
            DuplicateEle();
            Merge2SortedList();
            FindIntersection();
            ReplaceWithSpecificValue('x');

        }

        /* 1. Create a list of 5 numbers.   
         * first we need to create a list and then specify the type of te list which is int and then 
         * i added 5 numbers as required in the question, after that i used foreach loop to literate
         * over the list and print each number.
         */
        static void ListOfNumbers()
        {
            try
            {
                List<int> Numbers = new List<int> { 1, 2, 3, 4, 5 };
                Console.WriteLine("Q1. ");
                foreach (int num in Numbers)
                {
                    Console.WriteLine(num);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        //--------------------------------------------------------------------------------------------------------
        /* 2. Find the length of a list.  
        * first we check if the list contain any numbers or not, then we do find the length of the list by using 
        * count property of the list.
        */

        static void FindListLength()
        {
            try
            {
                List<int> Numbers = new List<int> { 1, 2, 3, 4 };
                if (Numbers.Count != 0)

                    Console.WriteLine("Q2. Length = " + Numbers.Count);
                else
                    Console.WriteLine("Q2. List is empty");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        //--------------------------------------------------------------------------------------------------------
        /*3. Access the first and last element of a list.
         again we check the list then we access the first index of the list which is 0 and the last index 
         which is count-1.
         */
        static void FirstAndLastElm() {
            {
                try
                {
                    List<int> Numbers = new List<int> { 1, 2, 3, 4 };
                    if (Numbers.Count != 0)

                        Console.WriteLine("Q3. First Element = " + Numbers[0] + ", Last Element = " + Numbers[Numbers.Count - 1]);

                    else
                        Console.WriteLine("Q3. List is empty");
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }

        //--------------------------------------------------------------------------------------------------------
        /*4. Append an item to a list.
         * check the list then add an item by using Add method of the list.
         */
        static void AppendItems()
        {
            try
            {
                List<int> Numbers = new List<int> { 1, 2, 3, 4 };
                if (Numbers.Count != 0) {

                    Numbers.Add(5);

                    Console.WriteLine("Q4. " + string.Join(", ", Numbers));

                }
                else {
                    Console.WriteLine("Q4. List is empty");
                } }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        //--------------------------------------------------------------------------------------------------------
        /*5. Remove an item from a list by value.
         again check if the list is empty or not and check if the number you want to remove is exist or not in the list
        then by using remove method we can easily remove that number we gave it by the parameter.*/
        static void RemoveElement(int remove)
        {
            try
            {
                List<int> Numbers = new List<int> { 1, 2, 3, 4 };
                if (Numbers.Count != 0 && Numbers.Contains(remove))
                {
                    Numbers.Remove(remove);

                    Console.WriteLine("Q5. " + string.Join(", ", Numbers));
                }
                else
                {
                    Console.WriteLine("Q5. List is empty or it does not contain that number.");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        //--------------------------------------------------------------------------------------------------------
        /*6. Sort a list of numbers in ascending order.
   again check if the list is empty or not and then by using sort method we can sort our list.*/
        static void SortList()
        {
            try
            {
                List<int> Numbers = new List<int> { 3, 55, 66, 8, 1, 90 };
                if (Numbers.Count != 0)
                {
                    Numbers.Sort();
                    Console.WriteLine("Q6. " + string.Join(", ", Numbers));

                }
                else
                {
                    Console.WriteLine("Q6. List is empty.");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        //--------------------------------------------------------------------------------------------------------
        /*7. Reverse the elements in a list.
        again check if the list is empty or not and then by using reverse method we can reverse 
        the elements in our list.*/
        static void ReverseList()
        {
            try
            {
                List<int> Numbers = new List<int> { 10, 20, 30 };
                if (Numbers.Count != 0)
                {
                    Numbers.Reverse();
                    Console.WriteLine("Q7. " + string.Join(", ", Numbers));

                }
                else
                {
                    Console.WriteLine("Q7. List is empty.");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        //--------------------------------------------------------------------------------------------------------
        /*8. Check if a value exists in a list.
         first check again then check for the given parameter if exist true, actually i wanted to solve it without 
        using predefined methods but i could not find find a proper way so i just used predefined method.
        */
        static void ValueExists(int num)
        {
            try
            {
                List<int> Numbers = new List<int> { 1, 3, 44, 87, 69 };
                if (Numbers.Count != 0)

                    Console.WriteLine("Q8. " + Numbers.Contains(num));
                else
                {
                    Console.WriteLine("Q8. There is no element in the list.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //---------------------------------------------------------------------------------------------------------
        /*9. Count how many times a value appears in a list.
         after creating the list we use foreach loop to go throw the list and check if that element is 
        equal to the given value by a parameter then we need to increase the count by one.
        */
        static void ValueAppearance(int value)
        {
            try
            {
                List<int> Numbers = new List<int> { 1, 2, 2, 3 };
                int count = 0;
                foreach (int Ele in Numbers)
                {
                    if (Ele == value) count++;
                }
                Console.WriteLine("Q9. Count of " + value + " = " + count);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        //---------------------------------------------------------------------------------------------------------
        /*11. Concatenate two lists together.
         first we create tow lists and then we use for loop to go throw the second list and add each element to
        the first list by using add method then join it together and print it.
         */
        static void ConcatenateLists()
        {
            try
            {
                List<int> FirstList = new List<int> { 1, 2 };
                List<int> SecondList = new List<int> { 3, 4 };
                for (int j = 0; j < SecondList.Count; j++) FirstList.Add(SecondList[j]);
                Console.WriteLine("Q11. " + string.Join(", ", FirstList));
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        //-------------------------------------------------------------------------------------------------------
        /*12. Slice a list to get the first 3 elements.
         * first we check to see if the list has more then 3 elements or not, if it has then we use a for loop
         * to go throw List1 and add the first 3 elements to List2, end join it and print it.
     
    */
        static void First3Element()
        {
            try
            {
                List<int> List1 = new List<int> { 1, 4, 77, 80, 32 };
                List<int> List2 = new List<int>();

                if (List1.Count >= 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        List2.Add(List1[i]);
                    }
                    Console.WriteLine("Q12. " + string.Join(", ", List2));
                }
                else
                {
                    Console.WriteLine("Q12. The list is less then 3 elements.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------   
        /*13. Clear all items from a list.
         nothing complicated just easily use clear method and everything will be deleted.*/
        static void ClearList()
        {
            try
            {
                List<int> Numbers = new List<int> { 1, 2, 3 };
                Numbers.Clear();
                Console.WriteLine("Q13. List cleared. Count = " + Numbers.Count);

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        //-------------------------------------------------------------------------------------------------------
        /*14. Copy a list into another variable.
        again check if the list is empty or not, create second list copy first list to second one.*/
        static void CopyList()
        {
            try
            {
                List<int> List1 = new List<int> { 1, 2, 3, 4 };

                if (List1.Count != 0)
                {
                    List<int> List2 = new List<int>(List1);

                    Console.WriteLine("Q14. " + string.Join(", ", List2));
                }
                else
                {
                    Console.WriteLine("Q14. List is empty.");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        //-------------------------------------------------------------------------------------------------------
        /*15. Insert a value at index 2.
       again check if the list is empty or not, then remove the given index to change the value of it 
        first we need to delete the current value and then we add the new value since we already we does 
        have te value and if there was no index then a message will appear by exception.*/
        static void InsertToSpecificIndex(int index, int value)
        {
            try
            {
                List<int> Numbers = new List<int> { 1, 2, 3, 4 };

                if (Numbers.Count != 0)
                {
                    Numbers.RemoveAt(index);
                    Numbers.Insert(index, value);
                    Console.WriteLine("Q15. " + string.Join(", ", Numbers));
                }
                else
                {
                    Console.WriteLine("Q15. List is empty.");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        //-------------------------------------------------------------------------------------------------------
        /*16. Filter out even numbers from a list.
         * we create our list and an empty list to store the odd numbers, foreach 
         * to go throw the list one by one to do an equation take the number and divide it by 2 if the result was 
         * not equal to zero then it mean's it is odd number.
         */
        static void OddNumbers()
        {
            try
            {
                List<int> Numbers = new List<int> { 1, 2, 3, 4, 5 };
                List<int> odds = new List<int>();
                foreach (int n in Numbers)
                {
                    if (n % 2 != 0) odds.Add(n);
                }
                Console.WriteLine("Q16. " + string.Join(", ", odds));
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        //------------------------------------------------------------------------------------------------------
        /*18. Find the maximum and minimum in a list.
        again check if the list is empty or not, then i used prepared method to find maximum 
        number in the list.*/
        static void FindMaxInList()
        {
            try
            {
                List<int> Numbers = new List<int> { 1, 2, 33, 4 };

                if (Numbers.Count != 0)
                {
                    Console.WriteLine("Q18. Max = " + Numbers.Max() + ", Min = " + Numbers.Min());


                }
                else
                {
                    Console.WriteLine("Q18. List is empty.");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        //-------------------------------------------------------------------------------------------------------
        /*19. Sum all elements in a list.
       again check if the list is empty or not, then we create a variable to store the sum of the elements
        and then we use for loop to go throw the list and add each element to the sum variable, 
        finally we print the sum.
        */
        static void SumAllEleList()
        {
            try
            {
                List<int> Numbers = new List<int> { 1, 2, 33, 4 };
                int sum = 0;
                if (Numbers.Count != 0)
                {
                    for (int i = 0; i < Numbers.Count; i++)
                    {
                        sum += Numbers[i];

                    }
                    Console.WriteLine("Q19. Sum of all elements = " + sum);
                }
                else
                {
                    Console.WriteLine("Q19. List is empty.");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        //-------------------------------------------------------------------------------------------------------
        /*20. Create a list from a string of comma-separated numbers.
         after creating the string we use Split method to split the string by comma and store it in an array,
         then we create a new list and add each element of the array to the list by using a for loop,
         finally we print the list by using string.Join method to join the elements of the list with a comma.
         */
        static void StringToList()
        {
            try
            {
                string Numbers = "1,2,3";
                string[] Move = Numbers.Split(',');
                List<string> List = new List<string>();
                int sum = 0;

                for (int i = 0; i < Move.Length; i++)
                {
                    List.Add(Move[i]);
                }
                Console.WriteLine("Q20. [" + string.Join(", ", List) + "]");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        //-------------------------------------------------------------------------------------------------------
        /*21. Convert all strings in a list to lowercase.
         by using a for loop we go throw the list and convert each element to lowercase
            and then we print the list.
         */
        static void LowercaseList()
        {
            try
            {
                List<string> WordList = new List<string> { "Hi", "There" };

                for (int i = 0; i < WordList.Count; i++)
                {
                    WordList[i] = WordList[i].ToLower();
                }
                Console.WriteLine("Q21. [" + string.Join(", ", WordList) + "]");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        //-------------------------------------------------------------------------------------------------------
        /*22. Find the average of a list of grades.
         we create tow variables one for the sum and one for the result,
         then we go throw the list by foreach loop and add each element to the sum variable,
         finally we divide the sum by the count of the list to get the average and print it.
         */
        static void AvarageInList()
        {
            try
            {
                List<int> Numbers = new List<int> { 90, 80, 100 };
                int sum = 0;
                int result = 0;
                foreach (int n in Numbers)
                {
                    sum += n;
                    result = sum / Numbers.Count;
                }
                Console.WriteLine("Q22. " + result);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        //-------------------------------------------------------------------------------------------------------
        /*23. Create a sublist from a list based on condition.
         after creating a list of 5 elements we use GetRange method to get the sublist
            starting from index 2 and taking 2 elements, then we print the sublist.
         */
        static void Sublist()
        {
            try
            {

                List<int> List = new List<int> { 1, 2, 3, 4, 5 };
                List<int> subList = List.GetRange(2, 2);

                Console.WriteLine("Q23. Sublist: " + string.Join(", ", subList));
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        //-------------------------------------------------------------------------------------------------------
        /*24.  Split a list into chunks of 3 items
        after creating a list of 9 elements we use GetRange method to get the first 3 elements 
        and then the second 3 elements and finally the last 3 elements, then we print them.
         */
        static void ThreeChunks()
        {
            try
            {

                List<int> List = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                List<int> subList1 = List.GetRange(0, 3);
                List<int> subList2 = List.GetRange(3, 3);
                List<int> subList3 = List.GetRange(6, 3);

                Console.WriteLine("Q24. First Chunk: [" + string.Join(", ", subList1) + "] " +
                    "Second Chunk: [" + string.Join(", ", subList2) + "] " +
                     "Third Chunk: [" + string.Join(", ", subList3) + "] ");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
      //-------------------------------------------------------------------------------------------------------

        /*25.  Sort a list of dictionaries by a key.
        after creating a string list and an int list we create a dictionary to store the keys and values,
        then we go throw the keys list by for loop and add each key and value to the dictionary not equal in the 
        keys and values list then we will get an exception, finally we print the dictionary.
         */
        static void SortListDictionaries()
        {
            try
            {
                List<string> keys = new List<string> { "a", "b", "c" };
                List<int> values = new List<int> { 1, 2, 3 };
                Dictionary<string, int> result = new Dictionary<string, int>();

                for (int i = 0; i < keys.Count; i++)
                {
                    result[keys[i]] = values[i];
                }
                Console.Write("Q25. [ ");
                foreach (var KeyValuePair in result)
                    Console.Write($" {KeyValuePair.Key}:{KeyValuePair.Value}");
                Console.Write(" ]");
                Console.WriteLine();
            }


            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------

        /*27. Flatten a list of lists.
         after creating a list of type List<int> which is a list of lists,
        then we go throw the list by foreach loop and check if the current element is a list or not,
        if it was a list then we go throw that list and add each element to the flat list,
        if it was not a list then we just add that element to the flat list, finally we print the flat list.
         */
        static void FlattenListofLists()
        {
            try
            {
                List<List<int>> nested = new List<List<int>> {
                    new List<int> {1, 2},
                    new List<int> {3, 4}
                };
                List<int> flat = new List<int>();

                foreach (var sublist in nested)
                {
                    foreach (var item in sublist)
                    {
                        flat.Add(item);
                    }
                }

                Console.WriteLine("Q27. " + string.Join(", ", flat));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------

        /*28. Get unique elements from a list.
        after creating the list we create an empty list to store the unique elements,
        then we go throw the list by foreach loop and check if the current element is already in the unique list,
        if it was not then we add it to the unique list, finally we print the unique list.
         */
        static void UniqueElement()
        {
            try
            {
                List<int> List = new List<int> { 1, 2, 2, 3 };
                List<int> Unique = new List<int>();

                foreach (int num in List)
                {
                    if (!Unique.Contains(num))
                    {
                        Unique.Add(num);
                    }
                }

                Console.WriteLine("Q28. " + string.Join(", ", Unique));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        //------------------------------------------------------------------------------------------------------
        /*30. Count how many strings start with a specific letter.
        create a list of words and then we use foreach loop to go throw the list and check if the first letter 
        of the word is equal to the letter we gave it by a parameter, if it was equal then we add that word to the
        matches list, finally we print the count of the matches and the matches themselves.
         */
        static void StartSpecificLetter(char Letter)
        {
            try
            {
                List<string> words = new List<string> { "apple", "banana", "Apricot", "avocado", "Berry", "art" };
                List<string> matches = new List<string>();

                foreach (string word in words)
                {
                    if (word.StartsWith(Letter.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        matches.Add(word);
                    }
                }

                Console.WriteLine($"Q30. Number of words starting with '{Letter}' (case insensitive): {matches.Count} [{string.Join(", ", matches)}]");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        //------------------------------------------------------------------------------------------------------
        /*32. Group a list of words by their starting letter.
        after creating the list we create a dictionary to store the words by their starting letter,
        then we go throw the list by foreach loop and check if the first letter of the word is already in 
        the dictionary if it was not then we add it to the dictionary and add the word to the list of that letter,
        if it was already in the dictionary then we just add the word to the list of that letter.
        finally we print the dictionary.
         */
        static void GroupListsByStartingLetter()
        {
            try
            {
                List<string> words = new List<string> { "apple", "banana", "apricot", "cherry", "Berry", "Avocado" };

                Dictionary<char, List<string>> wordGroups = new Dictionary<char, List<string>>();

                foreach (string word in words)
                {
                    if (string.IsNullOrEmpty(word)) continue;

                    char firstLetter = char.ToLower(word[0]);

                    if (!wordGroups.ContainsKey(firstLetter))
                    {
                        wordGroups[firstLetter] = new List<string>();
                    }

                    wordGroups[firstLetter].Add(word);
                }

                Console.WriteLine("Q32. Words grouped by starting letter (case-insensitive):");
                foreach (var group in wordGroups)
                {
                    Console.WriteLine($"\n'{group.Key}':");
                    foreach (string word in group.Value)
                    {
                        Console.WriteLine($"- {word}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
        //------------------------------------------------------------------------------------------------------
        /*34. Validate if two lists have the same elements regardless of order.
       create two lists and sort them, then we check if the first element of the first list is equal to the 
        first element of the second list, if they are equal then we go throw the lists and check if all elements
        are equal or not, if they are equal then we print true else we print false.
         */
        static void ValidateSameElements()
        {
            try
            {
                List<int> list1 = new List<int> { 1, 2, 3 };
                List<int> list2 = new List<int> { 3, 2, 1 };

                list1.Sort();
                list2.Sort();

                bool same = true;
                for (int i = 0; i < list1.Count; i++)
                {
                    if (list1[i] != list2[i])
                    {
                        same = false;
                        break;
                    }
                }

                Console.WriteLine("Q34. Same elements? " + same);
            }
            catch
            {
                Console.WriteLine("Error.");
            }

        }
        //------------------------------------------------------------------------------------------------------
        /*35. Detect a duplicate with O(n) time and O(1) space.
      after creating the list we sort it first then we go throw the list by for loop and check if the current 
        element is equal to the next  one if it was equal then we print that element and break the loop.
         */
        static void DuplicateEle()
        {
            try
            {
                List<int> numbers = new List<int> { 1, 2, 3, 4, 2 };

                numbers.Sort();

                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        Console.WriteLine("Q35. Duplicate: " + numbers[i]);
                        break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error.");
            }

        }
        //------------------------------------------------------------------------------------------------------
        /*36. Merge two sorted lists without using built-in sort.
        after creating three lists we use while loop to go throw the first tow lists and compare them
        if first element of the first list is less than the first element of the second list
        then we add that element to the result list and increase the index of the first list by one, else
        we add the first element of the second list to the result list and increase the index of the second list by one.
        And the the second while loop we check if the first list still has elements then we add them to the result list,
        Also the third while loop do the same for second list, finally we print the result list.
        .*/
        static void Merge2SortedList()
        {
            try
            {
                List<int> a = new List<int> { 1, 3, 5, 8 };
                List<int> b = new List<int> { 2, 4, 6 };
                List<int> result = new List<int>();

                int i = 0, j = 0;
                while (i < a.Count && j < b.Count)
                {
                    if (a[i] < b[j])
                    {
                        result.Add(a[i]);
                        i++;
                    }
                    else
                    {
                        result.Add(b[j]);
                        j++;
                    }
                }

                while (i < a.Count)
                {
                    result.Add(a[i]);
                    i++;
                }
                while (j < b.Count)
                {
                    result.Add(b[j]);
                    j++;
                }
                Console.Write("Q36. [ ");
                foreach (int n in result)
                    Console.Write(n + " ");
            
            Console.WriteLine("]");
        }
            catch
            {
                Console.WriteLine("Error.");
        } }

        //------------------------------------------------------------------------------------------------------
        /*37. Find the intersection of multiple lists.
        first we create 3 lists one of them is empty to store the intersection of the tow lists, by foreach
        loop we go throw both lists and check if the first element is equal to the second one if the first element
        was equal to the second one and it is not already in the result list then we add it to the result list, again 
        print the result list by foreach.
         */
        static void FindIntersection()
        {
            try
            {
                List<int> a = new List<int> { 1, 2, 3 };
                List<int> b = new List<int> { 2, 3, 4 };
                List<int> result = new List<int>();

                foreach (int num in a)
                {
                    foreach (int val in b)
                    {
                        if (num == val && !result.Contains(num))
                        {
                            result.Add(num);
                        }
                    }
                }
                Console.Write("Q37. [ ");
                foreach (int x in result)
                    Console.Write(x + " ");

                Console.WriteLine("]");
            }
            catch
            {
                Console.WriteLine("Error.");
            }

        }
        //------------------------------------------------------------------------------------------------------
        /*38. Replace every nth element with a specific value.
       we create a list with object type which allow us to store different types of data,
        then we use a for loop to go throw the list and check if the index is equal to n-1 then we 
        replace that element with a specific value that we give it by a parameter, after that
        we print the list by foreach loop.
        */
        static void ReplaceWithSpecificValue(char value)
        {
            try
            {
                List<object> list = new List<object> { 1, 2, 3, 4, 5 };
                int n = 2;

                for (int i = n - 1; i < list.Count; i += n)
                {
                    list[i] = value;
                }
                Console.Write("Q38. [ ");

                foreach (var item in list)
                {
                    Console.Write(item + " ");

                   
                }
                Console.WriteLine("]");

            }
            catch
            {
                Console.WriteLine("Error.");
            }

        }




        //------------------------------------------------------------------------------------------------------
        //I solved 32 questions out of 40, i tried with the other 8 but i could not understand it so i
        //leave it for now, i will try to solve them later, which are 10, 17, 26, 29, 31, 33, 39 and 40.
        //-------------------------------------------------------------------------------------------------------


    }
}

