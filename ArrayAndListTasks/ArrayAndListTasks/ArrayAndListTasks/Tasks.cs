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


    }
}
