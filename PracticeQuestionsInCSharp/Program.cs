using System;

namespace PracticeQuestionsInCSharp
{
    class MainClass
    {
        // Even or odd with switch statement
        public static string evenOrOdd(int number)
        {
            return (number % 2 == 0) ? "Even" : "Odd";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(evenOrOdd(1));
            Console.WriteLine(evenOrOdd(2));
            Console.WriteLine(evenOrOdd(3));
            Console.WriteLine(evenOrOdd(4));
            Console.WriteLine(evenOrOdd(5));
        }
    }
}
