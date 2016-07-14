using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockLibrary
{
    interface iTickable
    {
         public void TimeChanged(int elapsedSeconds)
        {

        }
    }
}
