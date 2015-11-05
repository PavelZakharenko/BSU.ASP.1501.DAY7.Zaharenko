using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockEvents
{
     public class Student
    {
        public void Register(Timer t)
        {
            t.Time += StudentMessage;
        }
        public void Unregister(Timer t)
        {
            t.Time -= StudentMessage;
        }
        private void StudentMessage(Object sender,TimerEventArgs e)
        {
            Console.WriteLine($"{e.Message} Deadline! NOOOOOOO!");
        }
    }
}
