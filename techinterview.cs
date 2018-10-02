using System;
using System.Collections.Generic;
using System.Linq;

namespace Page104Exercises
{
    class TechInterview
    {
        //1. Given an array of integers, write a method to total the odd numbers.
        public int AddOdds(int[] odds) 
        {
            int oddSum = 0;
            foreach (int i in odds)
            {
                if (i % 2 != 0)
                {
                    oddSum += i;
                }
            }
            return oddSum;
        }
        //or LINQ
        public int AddOdds2(int[] odds)
        {
            int oddSum = (from x in odds where x % 2 != 0 select x).Sum();

           return oddSum;
        }
        //or Lambda
        public int AddOdds3(int[] odds)
        {
            int oddSum = odds.Where(x => x % 2 != 0).Sum();
            return oddSum;
        }

        //2. Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements
        //may be very large numbers.
        public long AddLarge(long[] largeNums)
        {
            return largeNums.Sum();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //1. Given an array of integers, write a method to total the odd numbers.
            int[] odds = new int[] { 24, 42, 81, 21, 451, 57, 56, 60 };

            var techInverview = new TechInterview();
            Console.WriteLine(techInverview.AddOdds(odds));

            var techInterview2 = new TechInterview();
            Console.WriteLine(techInterview2.AddOdds2(odds));

            var techInterview3 = new TechInterview();
            Console.WriteLine(techInterview3.AddOdds3(odds));
            

            //2. Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements
            //may be very large numbers.
            long[] largeNums = new long[] { 435456753, 3452556757652, 9434545488, 9433333, 2435999898, 999999912034020 };

            var techInterview4 = new TechInterview();
            Console.WriteLine(techInterview4.AddLarge(largeNums));


            //3. Given a string, reverse it.
            string reverseIt = "This is how this sentence might be typed in a backwards dimension:";
            Console.WriteLine(reverseIt);

            char[] reversedIt = reverseIt.ToCharArray();
            Array.Reverse(reversedIt);
            Console.WriteLine(reversedIt);


            //4. Given a string, remove any repeated letters.
            string withDupes = "See what this sentence would look like if we removed all duplicate characters:";
            Console.WriteLine(withDupes);

            char[] removeDupes = withDupes.ToCharArray().Distinct().ToArray();
            Console.WriteLine(removeDupes);

            // or without LINQ:
            string withoutDupes = "";
            List<char> withoutDupesList = new List<char>();
            foreach(char c in withDupes)
            {
                if (withoutDupesList.Contains(c)) continue;

                withoutDupes += c.ToString();
                withoutDupesList.Add(c);


            }
            Console.WriteLine(withoutDupes);

            
            //5. FizzBuzz(ugh)
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }

            //or... I found a cool solution online from StackOverflow user Thomas Lavesque that uses Bools:

            for (int i = 1; i <= 100; i++)
            {
                bool fizz = (i % 3 == 0);
                bool buzz = (i % 5 == 0);
                if (fizz && buzz) Console.WriteLine("FizzBuzz");
                else if (fizz) Console.WriteLine("Fizz");
                else if (buzz) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }

                Console.ReadLine();
        }
    }
}
