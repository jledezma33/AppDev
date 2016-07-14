using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();
        }

        private void Start()
        {

        }

        void ITickable.TimeChanged(int elapsedSeconds)
        {

        }
    }
}
