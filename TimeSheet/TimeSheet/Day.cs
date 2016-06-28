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
        public enum TimeCodes { REGULAR, SICK, VACATION }

        private DateTime dateTime;

        public Day(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public void Add(TimeCodes timeType, float hours)
        {

        }


        public bool Validate()
        {
            return true;
        }

        
    }
}