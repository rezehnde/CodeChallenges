using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairs = sockMerchant(9, new int[]{10, 20, 20, 10, 10, 30, 50});
            Console.WriteLine("We have found {0} pairs of socks.", pairs);
            Console.ReadLine();
        }

        static bool searchForMyNumber(int number, HashSet<int> databaseSet)
        {
            foreach (int i in databaseSet)
            {
                int subtraction = (number - i);
                if (databaseSet.Contains(subtraction))
                {
                    if ((number - subtraction) == subtraction)
                        return false;
                    else
                        return true;
                }
            }
            return false;
        }

        static int sockMerchant(int n, int[] ar)
        {
            int pairs = 0;
            int[] colorsCount = ar.GroupBy(color => color).Select(color => color.Count()).ToArray();
            foreach (int count in colorsCount)
            {
                pairs += ((count - (count % 2)) / 2);
            }
            return pairs;
        }

        static int[] generateNumbersArray(int size)
        {
            int[] newArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                newArray.SetValue(i, i);
            }
            return newArray;
        }

        static HashSet<int> intersect(HashSet<int> a, HashSet<int> b)
        {
            a.IntersectWith(b);
            return a;
        }

        static HashSet<int> generateNumbers(HashSet<int> set, int size)
        {
            for (int i = 1; i <= size; i++)
            {
                set.Add(new Random().Next(0, 50));
            }
            return set;
        }

        static void binarySearch(int[] set, int searchValue)
        {
            DateTime dateStart = DateTime.Now;

            int start = 0;
            int end = set.Length - 1;
            int pivot = (start + end) / 2;
            int steps = 0;

            Console.WriteLine("start {0} pivot {1} end {2}", start, pivot, end);
            while (set[pivot] != searchValue && start < end)
            {
                steps++;
                if (searchValue < set[pivot])
                {
                    end = pivot - 1;
                }
                else
                {
                    start = pivot + 1;
                }
                pivot = (start + end) / 2;
                Console.WriteLine("start {0} pivot {1} end {2}", start, pivot, end);
            }

            DateTime dateEnd = DateTime.Now;
            Console.WriteLine("binarySearch found {0} in {1} milliseconds and {2} steps", searchValue, (dateEnd - dateStart).TotalMilliseconds.ToString(), steps);
        }

        static void findNumber(int[] set, int number)
        {
            int steps = 0;
            DateTime start = DateTime.Now;
            for (int i = 0; i < set.Length; i++)
            {
                steps++;
                if (i == number)
                {
                    break;
                }
            }
            DateTime end = DateTime.Now;
            Console.WriteLine("findNumber found {0} in {1} milliseconds and {2} steps", number, (end - start).TotalMilliseconds.ToString(), steps);
        }

        static void ON1(HashSet<int> set)
        {
            HashSet<int> newHashSet = new HashSet<int>();
            DateTime start = DateTime.Now;
            foreach (int i in set)
            {
                newHashSet.Add(i);
            }
            DisplaySet(newHashSet);
            DateTime end = DateTime.Now;
            Console.WriteLine("ON elapsedTime: {0}", (end - start).TotalMilliseconds.ToString());
        }

        static void ON2(HashSet<int> set)
        {
            HashSet<int> newHashSet = new HashSet<int>();
            DateTime start = DateTime.Now;
            foreach (int i in set)
            {
                foreach (int j in set)
                {
                    newHashSet.Add(j);
                }
            }
            DisplaySet(newHashSet);
            DateTime end = DateTime.Now;
            Console.WriteLine("ON2 elapsedTime: {0}", (end - start).TotalMilliseconds.ToString());
        }

        static void ON3(HashSet<int> set)
        {
            HashSet<int> newHashSet = new HashSet<int>();
            DateTime start = DateTime.Now;
            foreach (int i in set)
            {
                foreach (int j in set)
                {
                    foreach (int k in set)
                    {
                        newHashSet.Add(k);
                    }
                }
            }
            DisplaySet(newHashSet);
            DateTime end = DateTime.Now;
            Console.WriteLine("ON3 elapsedTime: {0}", (end - start).TotalSeconds.ToString());
        }

        static void ON4(HashSet<int> set)
        {
            HashSet<int> newHashSet = new HashSet<int>();
            DateTime start = DateTime.Now;
            foreach (int i in set)
            {
                foreach (int j in set)
                {
                    foreach (int k in set)
                    {
                        foreach (int l in set)
                        {
                            newHashSet.Add(l);
                        }
                    }
                }
            }
            DisplaySet(newHashSet);
            DateTime end = DateTime.Now;
            Console.WriteLine("ON4 elapsedTime: {0}", (end - start).TotalMilliseconds.ToString());
        }

        static void DisplaySet(HashSet<int> set)
        {
            Console.Write("{");
            foreach (int i in set)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }

        static void Numbers()
        {
            HashSet<int> evenNumbers = new HashSet<int>();
            HashSet<int> oddNumbers = new HashSet<int>();

            for (int i = 0; i < 5; i++)
            {
                // Populate numbers with just even numbers.
                evenNumbers.Add(i * 2);

                // Populate oddNumbers with just odd numbers.
                oddNumbers.Add((i * 2) + 1);
            }

            Console.Write("evenNumbers contains {0} elements: ", evenNumbers.Count);
            DisplaySet(evenNumbers);

            Console.Write("oddNumbers contains {0} elements: ", oddNumbers.Count);
            DisplaySet(oddNumbers);

            HashSet<int> numbers = new HashSet<int>(evenNumbers);
            numbers.UnionWith(oddNumbers);

            Console.Write("numbers contains {0} elements: ", numbers.Count);
            DisplaySet(numbers);
        }
    }
}
