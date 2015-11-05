using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClockEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            var Ringer = new Ringer();
            var student = new Student();
            student.Register(timer);
             Ringer.Register(timer);
            timer.StartTicking(5);
            Thread.Sleep(1000);
            Ringer.Unregister(timer);
            timer.StartTicking(3);
            Console.Read();
        }
    }
}