using System;
using System.Linq;
using System.Collections.Generic;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>() { "PacMan", "Game of Thrones", "Raceway", "Call to Duty", "Zonnie", "Think n Fix", "100 Beans" };

            var ordered = games.OrderBy(x => x.Length).ThenBy(j => j);
            foreach (var item in ordered)
            {
                Console.WriteLine($"{item}");
            }

            int[] nums = new int[]{ 1, -4, 7, -12 };
            Console.WriteLine($"Sum of array: {PositiveSum(nums)} ");
            
        }

        static int PositiveSum(int[] arr) => arr.Where(x => x > -1).Sum(x => x);

        static int P(int[] arr)
        {
            return arr.Where(x => x > -1).Sum(x => x);
        }
    }
}
