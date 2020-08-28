using System;

namespace MethodExercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            var target = -1000;
            CountDownByOnes(target);

            CountUpByThrees();

            Console.WriteLine("Now put in two numbers, and see if they're equal");
            var userInput1 = Console.ReadLine();
            var userInput2 = Console.ReadLine();
            var a = int.Parse(userInput1);
            var b = int.Parse(userInput2);
            AreTheseEqual(a, b);

            Console.WriteLine("Are you old enough to vote?");
            var userInput3 = Console.ReadLine();
            var voteAge = int.Parse(userInput3);
            VotingAge(voteAge);

            Console.WriteLine("Give me a different number and let's see if it's even or odd");
            var userInput4 = Console.ReadLine();
            var c = int.Parse(userInput4);
            EvenOrOdd(c);
 
            Console.WriteLine("Put in yet another number");
            var userInput5 = Console.ReadLine();
            var d = int.Parse(userInput5);
            IsThisPositive(d);

        }

        public static void CountDownByOnes(int target)
            {
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

            public static bool AreTheseEqual(int a, int b)
            {
                if (a == b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public static void VotingAge(int voteAge)
            {
                if (voteAge >= 18)
                {
                    Console.WriteLine("Congratulations, you're old enough to vote!  See you at the polls?");
                }
                else
                {
                    Console.WriteLine("Sorry, you're not old enough to vote yet.  Try again in a few years.");
                }
            }
            public static void EvenOrOdd(int c)
            {
                if (c % 2 == 0)
                {
                    Console.WriteLine($"{c} is even!");
                }
                else
                {
                    Console.WriteLine($"{c} is odd!");
                }
            }

            public static void IsThisPositive(int d)
            {
                if (d > 0)
                {
                    Console.WriteLine($"{d} is positive");
                }
                else if (d == 0)
                {
                    Console.WriteLine("0 is neither positive nor negative");
                }
                else
                {
                    Console.WriteLine($"{d} is negative");
                }
            }
    }
}