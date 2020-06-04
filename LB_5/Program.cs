using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Lab5();
            Console.Read();
        }
        static async Task Lab5()
        {
            var result = await Method(100);

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }

        static async Task<int[]> Method(int n)
        {
            return await Task.Run(() =>
            {
                var range = Enumerable.Range(0, n);
                return range.ToArray();
            });
        }
    }
}
