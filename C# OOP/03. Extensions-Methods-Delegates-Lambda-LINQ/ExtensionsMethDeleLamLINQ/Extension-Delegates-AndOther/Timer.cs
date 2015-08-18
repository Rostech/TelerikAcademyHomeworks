
namespace Extension_Delegates_AndOther
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Threading;

    /*
     7. Timer

        Using delegates write a class Timer that can execute certain method at each t seconds.
    */

    class Timer
    {

        private uint timeSpan;
        private uint executeCount;
        private Delegate d;

        public Timer(uint seconds,  Delegate deleg, uint executeCount)
        {
            this.TimeSpan = seconds;
            this.D = deleg;
            this.ExecuteCount = executeCount;
        }

        public uint TimeSpan
        {
            get
            {
                return this.timeSpan;
            }
            set
            {
                this.timeSpan = value;
            }
        }
        public Delegate D
        {
            get
            {
                return this.d;
            }
            set
            {
                this.d = value;
            }
        }
        public uint ExecuteCount
        {
            get
            {
                return this.executeCount;
            }
            set
            {
                this.executeCount = value;
            }
        }
        public void StartTimer()
        {
            for(int i = 0; i <= executeCount; i++)
            {
                Console.Write("\r");
                Console.Write("{0,-10}", this.D.DynamicInvoke() + " " + i + " (seconds)");
                Thread.Sleep((int)this.TimeSpan * 1000);
            }
        }
    }
}
