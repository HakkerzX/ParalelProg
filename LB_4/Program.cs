using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                array.Add(i);
            }

            array.AsParallel().ForAll(x =>
            {
                double value = Math.Pow(x, 2);
                Console.WriteLine($"{x}^2 = {value}");
            });
            Console.Read();
        }
    }
}
