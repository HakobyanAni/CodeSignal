using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    // Ratiorg got statues of different sizes as a present from CodeMaster for his birthday, each statue
    // having an non-negative integer size. Since he likes to make things perfect, he wants to arrange them 
    // from smallest to largest so that each statue will be bigger than the previous one exactly by 1. He may 
    // need some additional statues to be able to accomplish that. Help him figure out the minimum number of additional statues needed.

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
