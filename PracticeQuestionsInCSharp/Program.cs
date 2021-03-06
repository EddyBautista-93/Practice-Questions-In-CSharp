﻿using System;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Generic;

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

        static int MakeNegative(int number)
        {
          return -Math.Abs(number);
        }

        static void DescendingOrder(int num)
        {
             int[] result = num.ToString().Select(o => Convert.ToInt32(o)).ToArray();
            

            
        }



        public static bool IsPangram(string input)
        {
            // Create a hash table to mark the  
            // characters present in the string 
            // By default all the elements of  
            // mark would be false. 
            bool[] mark = new bool[26];

            // For indexing in mark[] 
            int index = 0;

            // Traverse all characters 
            for (int i = 0; i < input.Length; i++)
            {
                // If uppercase character, subtract 'A' 
                // to find index. 
                if ('A' <= input[i] &&
                        input[i] <= 'Z')

                    index = input[i] - 'A';

                // If lowercase character,  
                // subtract 'a' to find 
                // index. 
                else if ('a' <= input[i] &&
                            input[i] <= 'z')

                    index = input[i] - 'a';

                // Mark current character 
                mark[index] = true;
            }

            // Return false if any 
            // character is unmarked 
            for (int i = 0; i <= 25; i++)
                if (mark[i] == false)
                    return (false);

            // If all characters 
            // were present 
            return (true);

            throw new NotImplementedException();
        }

        //FIRST go in expression bodied members in c#
        public static string Speak(string name) => $"One for {name}, one for me.";

        public static string tickets(int[] peopleInLine)
        {
            int d25 = 0;
            int d50 = 0;
            for (int i = 0; i < peopleInLine.Length; i++)
            {
                if (peopleInLine[i] == 25) d25++;
                if (peopleInLine[i] == 50)
                {
                    d25--;
                    d50++;
                }
                if (peopleInLine[i] == 100)
                {
                    if (d50 > 0)
                    {
                        d50--;
                        d25--;
                    }
                    else
                    {
                        d25 -= 3;
                    }
                }
                if (d25 < 0) return "NO";
            }
            return "YES";
        }

        static string Reverse(String x) => string.Join(" ", x.Split(' ').Select(s => new String(s.Reverse().ToArray())));

        public static int Test(string numbers)
        {
            var ints = numbers.Split(' ').Select(int.Parse).ToList();
            var unique = ints.GroupBy(n => n % 2).OrderBy(c => c.Count()).First().First();
            return ints.FindIndex(c => c == unique) + 1;

        }
        public static int[] DeleteNth(int[] arr, int x)
        {
            return arr.Where((t, i) => arr.Take(i + 1).Count(s => s == t) <= x).ToArray();
        }


        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            //creates a score list to compare the two
            List<int> scores = new List<int>() { 0, 0 };
            //loops throygh both arrays
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i]) scores[0]++;
                else if (a[i] < b[i]) scores[1]++;

            }
            Console.WriteLine(scores);
            return scores;
        }

        static long aVeryBigSum(long[] ar)
        {
            long sum = ar.Sum();
            Console.WriteLine(sum);
            return sum;

        }

        public static int difference(int[,] arr,
                                 int n)
        {

            // Initialize sums of diagonals 
            int d1 = 0, d2 = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    // finding sum of primary diagonal 
                    if (i == j)
                        d1 += arr[i, j];

                    // finding sum of secondary diagonal 
                    if (i == n - j - 1)
                        d2 += arr[i, j];
                }
            }

            // Absolute difference of the 
            // sums across the diagonals 
            return Math.Abs(d1 - d2);
        }

        // Driver Code 
        public static void Main()
        {
            int n = 3;

            int[,] arr ={{11, 2, 4},
                     {4 , 5, 6},
                     {10, 8, -12}};

            Console.Write(difference(arr, n));

        }
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
            //Console.WriteLine(DuplicateEncodeRemix("din"));
            //Console.WriteLine("(((");
            //Console.WriteLine(DuplicateEncodeRemix("recede"));
            //Console.WriteLine("()()()");
            //Console.WriteLine(DuplicateEncodeRemix("success"));
            //Console.WriteLine(")())())");
            //Console.WriteLine(MakeNegative(1));
            //Console.WriteLine(MakeNegative(-5));
            //Console.WriteLine(MakeNegative(10));
            //DescendingOrder(243);
            //DescendingOrder(24345);
            //DescendingOrder(2430589);
            //Console.WriteLine(Speak("EDDY"));
            //Console.WriteLine(Speak("CELESTE"));
            //Console.WriteLine(Reverse("This is an example!"));/
            //Console.WriteLine(Test("213243542321"));÷
            //List<int> alice = new List<int>() { 5, 6, 7 };
            //List<int> bob = new List<int>() { 3, 6, 10 };
            //alice.ForEach(Console.WriteLine);
            //bob.ForEach(Console.WriteLine);
            //compareTriplets(alice, bob);
            //long[] bigSumArray = { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            //aVeryBigSum(bigSumArray);

        }
    }
}
