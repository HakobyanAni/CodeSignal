using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
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
