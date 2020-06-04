using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LB_3
{
    class Program
    {
        static void Main(string[] args)
        {
            new TaskLab().Lab3();
        }
        public class TaskLab
        {
            public void Lab3()
            {
                var tokenSource = new CancellationTokenSource();
                var token = tokenSource.Token;
                new Task(() =>
                {
                    int i = 0;
                    while (!token.IsCancellationRequested)
                    {
                        i++;
                        Console.WriteLine($"Ожидайте {i} шаг!!!");
                        Thread.Sleep(100);
                    }
                }).Start();
                Thread.Sleep(1000);
                tokenSource.Cancel();
                Console.WriteLine("Операции завершены");
                Console.Read();
            }
        }
    }
}
