using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Box(){
            List<object> emptyList = new List<object>();
            emptyList.Add(7);
            emptyList.Add(28);
            emptyList.Add(-1);
            emptyList.Add(true);
            emptyList.Add("chair");
            int sum = 0;
            foreach (var objects in emptyList)
            {
                Console.WriteLine(objects);
                if (objects is int)
                {
                    sum += (int)objects;
                }
            }
            Console.WriteLine(sum);
        }

        static void Main(string[] args)
        {
            Box();
        }
    }
}
