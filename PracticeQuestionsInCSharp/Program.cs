using System;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Linq;
using System.Text;

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


        //uppercase every first letter in  word with a string input
         static string ToUpperEveryWord(string s)
        {
            // Check for empty string.  
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            } 
            // got rid of 5 lines if code for just this! Never stop improving!!!
            return String.Join(" ", s.Split().Select(i => Char.ToUpper(i[0]) + i.Substring(1)));
        }

        //another way to do every first letter uppercase
         static string ToJadenCase(string phrase)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
        }

        //The goal of this exercise is to convert a string to a new string where
        //each character in the new string is "(" if that character appears only once
        //in the original string, or ")" if that character appears more than once in the
        //original string. Ignore capitalization when determining if a character is a duplicate.
        static string DuplicateEncode(string word)
        {
            //StringBuilder is a dynamic object which will expands
            //a memory dynamically to accommodate the modifications of string
            //instead of creating a new instance in the memory.
            StringBuilder sb = new StringBuilder();
            var chars = word.ToLower().ToCharArray();

            foreach(char c in chars)
            {
                if (chars.Where(ch => ch == c).Count() > 1)

                    sb.Append(")");
                else
                    sb.Append("(");
            }
            return sb.ToString();
        }

        // a shorter way of doing it from a solution on codewars
        public static string DuplicateEncodeRemix(string word)
        {
            return new string(word.ToLower().Select(ch => word.ToLower().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray());
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
            //Console.WriteLine(intMax(1, 3, 50));
            //Console.WriteLine(intMax(1, 123, 50));
            //Console.WriteLine(intMax(678, 123, 50));
            //Console.WriteLine(ToUpperEveryWord("How can mirrors be real if our eyes aren't real"));
            //Console.WriteLine(ToJadenCase("How can mirrors be real if our eyes aren't real"));
            //Console.WriteLine(DuplicateEncode("din"));
            //Console.WriteLine("(((");
            //Console.WriteLine(DuplicateEncode("recede"));
            //Console.WriteLine("()()()");
            //Console.WriteLine(DuplicateEncode("success"));
            //Console.WriteLine(")())())");
            Console.WriteLine(DuplicateEncodeRemix("din"));
            Console.WriteLine("(((");
            Console.WriteLine(DuplicateEncodeRemix("recede"));
            Console.WriteLine("()()()");
            Console.WriteLine(DuplicateEncodeRemix("success"));
            Console.WriteLine(")())())");

        }
    }
}
