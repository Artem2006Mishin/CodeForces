using System;
using System.Linq;

namespace codeforces
{
    internal class Program
    {
        static void Solve()
        {
            long[] nk = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
            long n = nk[0];
            long k = nk[1];

            long[] boxes = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

            long maxElement = boxes.Max();
            long minElement = boxes.Min();
            int countMax = boxes.Count(x => x ==  maxElement);
            if (countMax == 1)
            {
                if (maxElement - minElement - 1 > k)
                {
                    Console.WriteLine("Jerry");
                    return;
                }
            }
            else
            {
                if (maxElement - minElement > k)
                {
                    Console.WriteLine("Jerry");
                    return;
                }
            }            

            long sum = boxes.Sum();
            if (sum % 2 == 0)
            {
                Console.WriteLine("Jerry");
            }
            else
            {
                Console.WriteLine("Tom");
            }
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()!);
            while (t-- > 0)
            {
                Solve();
            }
        }
    }
}
