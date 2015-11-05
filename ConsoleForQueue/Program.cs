using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomQueue;

namespace ConsoleForQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomQueue<int> queue = new CustomQueue<int>();
            queue.Enqueue(12);
            queue.Enqueue(1);
            queue.Enqueue(1111);
            foreach(var a in queue)
            {
                Console.WriteLine($"{a}");
            }
            Console.Read();
        }
    }
}
