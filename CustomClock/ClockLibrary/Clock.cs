using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockLibrary
{
    public class Clock
    {
        private void Start()
        {
            for (int i = 0; i < 11; i++)
            {
                Timechanged(i);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
