using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClockEvents
{
    public class TimerEventArgs:EventArgs
    {
        private readonly string message;
        public TimerEventArgs()
        {
            message = "Time is over";
        }
        public string Message { get { return message; } }
    }
     public class Timer
    {
        public EventHandler<TimerEventArgs> Time = delegate { };
        protected virtual void OnTheEnding(TimerEventArgs e)
        {
            EventHandler<TimerEventArgs> temp = Time;
            if(temp!=null)
            {
                temp(this, e);
            }

        }
        public void StartTicking(int Seconds)
        {
            for (int i = Seconds; i > 0; i--)
            {
                Console.WriteLine($"{i}");
                Thread.Sleep(1000);
            }
            OnTheEnding(new TimerEventArgs());
        }
    }
}
