using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockEvents
{
   public class Ringer
    {
        public void Unregister(Timer t)
        {
            t.Time -= Ringing;
        }
        public void Register(Timer t)
        {
            t.Time+= Ringing;
        }
        private void Ringing(Object sender,TimerEventArgs e)
        {
            Console.WriteLine($"{e.Message} Ring Ring Ring!");
        } 
    }
}
