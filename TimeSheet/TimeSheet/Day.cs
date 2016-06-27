using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheet
{
    public class Day
    {
        public DateTime Date { get; set; }

        public float HoursWorked { get; set; }

        //time codes sick, vacation, regular
        public enum TimeCodes { sick, vacation, regular}

        public string sick = TimeCodes.sick.ToString();
    }
}
