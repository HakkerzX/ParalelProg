using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LB_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввод число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            new Thread(() => { Lab1(num); }).Start();
        }
        static void Lab1(int num)
        {
            try
            {
                if (num > 0)
                {
                    int max = num;
                    for (int i = 0; i < max; i++)
                    {
                        num += i;
                    }
                    Console.WriteLine($"Ответ: {num}");
                }
                else if (num < 0)
                {
                    int min = num;
                    for (int i = min; i < 0; i++)
                    {
                        num += i;
                    }
                    Console.WriteLine($"Ответ: {num}");
                }
                Console.Read();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }
    }
}
