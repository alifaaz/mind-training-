using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndArrayTasks
{
    public static class Helpers
    {
        public static List<string> CreateListUntilStop()
        {
            List<string> items = new List<string>();
            Console.WriteLine("Enter items (type 'Stop' to Stop Entering items):");

            int i = 1;
            while (true)
            {
                Console.Write($"Item {i} : ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Your input is Null or White Spaces");
                    continue;
                }
                // Check if user typed "stop" 
                if (string.Compare(input, "stop", ignoreCase: true) == 0)
                {
                    break;
                }
                items.Add(input);
                i++;
            }
            return items;
        }
        public static List<string> PrintList(string PrintingSequence, List<string> MyList)
        {
            try
            {
                Console.WriteLine($"\n--- {PrintingSequence} ---");

                if (MyList == null || MyList.Count == 0)
                {
                    Console.WriteLine("The list is empty or null.");
                    return MyList;
                }

                for(int i = 0; i < MyList.Count; i++)
                {
                    Console.WriteLine($"Item {i + 1}: {MyList[i]}");
                }
                Console.WriteLine("-------------------------");

                return MyList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown Error" + ex.Message);
                return MyList;
            }
        }

        internal static void PrintList(string v1, object v2)
        {
            throw new NotImplementedException();
        }
    }
}
