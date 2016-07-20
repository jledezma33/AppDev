using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClockLibrary;

namespace CustomClock
{
    class Program : ClockLibrary.ITickable
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();
            
        }

        public void Start()
        {
            ClockLibrary.Clock clock = new Clock();
            clock.Start(this);
        }

        void ITickable.TimeChanged(int elapsedSeconds)
        {
            Console.WriteLine(elapsedSeconds);
        }
        
    }
}
