using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    // Now we will define an n-interesting polygon. A 1-interesting polygon is just a square with a side of length 1. An n-interesting polygon is obtained by 
    // taking the n - 1-interesting polygon and appending 1-interesting polygons to its rim, side by side.Your task is to find the area of a polygon for a given n.

    class Program
    {
        static int ShapeArea(int n)
        {
            return n * n + (n - 1) * (n - 1);
        }

        static void Main(string[] args)
        {
            string numb = Console.ReadLine();
            int number = Convert.ToInt32(numb);
            int shapeArea = ShapeArea(number);

            Console.WriteLine(shapeArea);

            Console.ReadKey();
        }
    }
}
