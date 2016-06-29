using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheet
{
    public class Day
    {
        public float TotalHours = 0;
        public float RegHours = 0;
        public float SickHours = 0;
        public float VacHours = 0;

        public DateTime Date { get; set; }

        public float HoursWorked { get; set; }

        //time codes sick, vacation, regular
        public enum TimeCodes { REGULAR, SICK, VACATION }

        private DateTime dateTime;
        public string HoursType { get; set; }
        public float hours = 8;
        public TimeCodes value = TimeCodes.REGULAR;

        public Day(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public void Add(TimeCodes timeType, float hours)
        {
            TotalHours += hours;
            if (timeType == TimeCodes.REGULAR)
            {
                RegHours += hours;
            }
            else if (timeType == TimeCodes.SICK)
            {
                SickHours += hours;
            }
            else if (timeType == TimeCodes.VACATION)
            {
                VacHours += hours;
            }
        }
        public bool Validate()
        {
            if (TotalHours <= 24 && TotalHours > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}


