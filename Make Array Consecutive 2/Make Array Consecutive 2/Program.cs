using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static int MakeArrayConsecutive2(int[] statues)
        {
            Array.Sort(statues);
            List<int> absent = new List<int>();
            for (int i = 0; i < statues.Length - 1; i++)
            {
                int a = statues[i];
                while (statues[i + 1] - a > 1)
                {
                    a += 1;
                    absent.Add(a);
                }
            }
            return absent.Count();
        }

        static void Main(string[] args)
        {
            int[] statues = new int[] { 6, 3, 2, 8 };
            int count = MakeArrayConsecutive2(statues);

            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
