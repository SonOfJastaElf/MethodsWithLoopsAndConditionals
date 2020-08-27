using System;

namespace MethodExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here's a series of methods I've made to practice coding in C#.  Enjoy!");
        }
        public static void CountDownByOnes()
        {
            int target = -1000;
            for (int i = 1000; i >= target; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void CountUpByThrees()
        {
            for (int n = 3; n <= 999; n += 3)
            {
                Console.WriteLine(n);
            }

        }

        public static bool AreTheseEqual()
        {
            Console.WriteLine("Now put in two numbers, and see if they're equal");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void VotingAge()
        {
            Console.WriteLine("Are you old enough to vote?");

            int vote = int.Parse(Console.ReadLine());

            if (vote >= 18)
            {
                Console.WriteLine("Congratulations, you're old enough to vote!  See you at the polls?");
            }
            else
            {
                Console.WriteLine("Sorry, you're not old enough to vote yet.  Try again in a few years.");
            }
        }

        public static void EvenOrOdd()
        {
            Console.WriteLine("Give me a different number and let's see if it's even or odd");
            int c = int.Parse(Console.ReadLine());
            
            if (c % 2 == 0)
            {
                Console.WriteLine ($"{c} is even!");
            }
            else
            {
                Console.WriteLine($"{c} is odd!");
            }
        }

        public static void IsThisPositive()
        {
            Console.WriteLine("Put in yet another number");
            int d = int.Parse(Console.ReadLine());

           if (d >= 0)
            {
                Console.WriteLine($"{d} is positive");
            }
            else
            {
                Console.WriteLine($"{d} is negative");
            }
        }
    }
}