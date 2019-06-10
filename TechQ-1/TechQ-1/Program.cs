using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechQ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(TotalOddNum(numbers));
            
            //Q2
            int[] bigNumbers = new int[] { 1000, 234905234, 29034092, 1210239 };
            Console.WriteLine(SumArray(bigNumbers));

            //Q3
            string aString = "wow I forget everything";
            Console.WriteLine(ReverseString(aString));

            //Q4
            string repeatString = "oohh hhooww wwoonnddeerrffuull";
            RemoveRepeats(repeatString);

            //Q5
            FizzBuzz();
            Console.ReadLine();

        }

        //Question 1
        static int TotalOddNum(int[] numbers)
        {
            int total = 0;

            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    total += num;
                }
            }

            return total;
        }
        //Question 2
        static long SumArray(int[] numbers)
        {
            long total = 0;

            foreach (var num in numbers)
            {
                total += num;
            }

            return total;
        }
        //Question 3
        static string ReverseString(string myString)
        {
            char[] charArray = myString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        //Question 4
        static void RemoveRepeats(string myString)
        {
            char[] charArray = myString.ToCharArray().Distinct().ToArray();
            Console.WriteLine(charArray);
        }
        //Question 5
        static void FizzBuzz()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
