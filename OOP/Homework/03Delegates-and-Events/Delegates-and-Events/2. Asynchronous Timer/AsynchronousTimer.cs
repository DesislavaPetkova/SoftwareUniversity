using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2.Asynchronous_Timer
{
    

    public class AsynchronousTimer
    {
        private Action<int> method;
        private int ticks;
        private int interval;

        public AsynchronousTimer(Action<int> method, int ticks, int interval)
        {
            this.Method = method;
            this.Ticks = ticks;
            this.Interval = interval;

        }

        public Action<int> Method { get; set; }
        public int Ticks { get; set; }
        public int Interval { get; set; }

        public void Run()
        {
            while (this.ticks > 0)
            {
                Thread.Sleep((int)this.interval);
                
                if (this.method != null)
                {
                    this.method((int)this.ticks);
                }

                this.ticks--;
            }
        }
        
    }
}
