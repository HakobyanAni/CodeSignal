using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codesignal4
{
    // Given an array of integers, find the pair of adjacent
    // elements that has the largest product and return that product.

    class Program
    {
        public static int adjacentElementsProduct(int[] inputArray)
        {
            int product = 0;
            List<int> pr = new List<int>();
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                product = inputArray[i] * inputArray[i + 1];
                pr.Add(product);
            }
            return pr.Max();
        }
        static void Main(string[] args)
        {
            int[] inputArray = { 3, 6, 2, -5, 7, 3 };
            Console.WriteLine(adjacentElementsProduct(inputArray));

            Console.ReadKey();
        }
    }
}
