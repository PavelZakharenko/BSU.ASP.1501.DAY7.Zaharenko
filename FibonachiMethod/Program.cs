using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiMethod
{
    class Program
    {
        public static IEnumerator<int> GetNumbers()
        {
            int prev = 0;
            int current = 1;
            int temp;
            for(int i=1;i<10;i++)
            {
                temp = current;
                yield return current=prev + current;
                prev = temp;

            }
        }
        static void Main(string[] args)
        {
            IEnumerator<int> iterator = GetNumbers();
            bool more = true;
            while(more)
            {
                more = iterator.MoveNext();
                Console.WriteLine("Current={1}", more, iterator.Current);
            }
            Console.Read();

        }
    }
}
