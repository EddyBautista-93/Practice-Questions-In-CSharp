using System;
using System.Runtime.CompilerServices;

namespace PracticeQuestionsInCSharp
{
    class MainClass
    {
        // Even or odd with switch statement
         static string evenOrOdd(int number)
        {
            return (number % 2 == 0) ? "Even" : "Odd";
        }

        //Given an int n, return the absolute difference between n and 21
        //, except return double the absolute difference if n is over 21
        static int diff21(int n)
        {
            if (n == 0)
            {
                return 21;
            }
            else if (n < 21)
            {
                int result = 21 - n;
                return result;

            }
            else if (n > 21)
            {
                int result = n - 21;
                return result * 2;
            }
            return 0;
        }
            

        public static void Main(string[] args)
        {
            //Console.WriteLine(evenOrOdd(1));
            //Console.WriteLine(evenOrOdd(2));
            Console.WriteLine(diff21(19));
            Console.WriteLine(diff21(10));

        }
    }
}
