using System;
using System.Linq;

namespace codeforces
{
    internal class Program
    {
        static int Gcd(int a, int b) => b == 0 ? a : Gcd(b, a % b);

        static void Solve()
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] numbers = Console.ReadLine()!
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int maxElement = numbers.Max();
            var nonMaxElements = numbers.Where(x => x != maxElement).ToArray();

            if (nonMaxElements.Length == 0)
            {
                Console.WriteLine("No");
                return;
            }

            int gcdC = nonMaxElements.Aggregate(Gcd);
            if (gcdC != maxElement)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(string.Join(" ", numbers.Select(x => x == maxElement ? "2" : "1")));
            }
            else
            {
                Console.WriteLine("No");
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
