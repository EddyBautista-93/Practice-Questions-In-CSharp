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


        //Given a string, return a new string where the last 3 chars are now in upper case.
        //If the string has less than 3 chars, uppercase whatever is there.Note that
        //str.toUpperCase() returns the uppercase version of a string.
        static string endUp(string str)
        {
            if (str.Length <= 3)
            {
                return str.ToUpper();
            }
            else
            {
                int cut = str.Length - 3;
                String front = str.Substring(0, cut);
                String back = str.Substring(cut);  // this takes from cut to the end
                return front + back.ToUpper();
            }
        }

        static int intMax(int a, int b, int c)
        {
            int max;

            // First check between a and b
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            // Now check between max and c
            if (c > max)
            {
                max = c;
            }

            return max;

            // Could use the built in Math.max(x, y) function which selects the larger
            // of two values.
        }
    



      
        public static void Main(string[] args)
        {
            //Console.WriteLine(evenOrOdd(1));
            //Console.WriteLine(evenOrOdd(2));
            //Console.WriteLine(diff21(19));
            //Console.WriteLine(diff21(10));
            //Console.WriteLine(endUp("Hello"));
            //Console.WriteLine(endUp("hi there"));
            //Console.WriteLine(endUp("hi"));
            Console.WriteLine(intMax(1, 3, 50));
            Console.WriteLine(intMax(1, 123, 50));
            Console.WriteLine(intMax(678, 123, 50));

        }
    }
}
