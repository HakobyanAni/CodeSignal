using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ankap
{
    // Given the string, check if it is a palindrome.

    class Program
    {
        static string ArrayReverse(string inputString)
        {
            char[] str = inputString.ToCharArray();
            Array.Reverse(str);
            return new string(str);
        }

        static bool checkPalindrome(string inputString)
        {
            return ArrayReverse(inputString) == inputString;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("     PALINDROME OR NOT ?");
            Console.WriteLine("Write you experssion, please:");
            string @string = Console.ReadLine();
            if (checkPalindrome(@string))
            {
                Console.WriteLine($"{@string} is palindrome.");
            }
            else
            {
                Console.WriteLine($"{@string} is not palindrome.");
            }
            Console.ReadKey();
        }
    }
}
