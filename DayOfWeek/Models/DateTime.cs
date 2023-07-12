using System;

namespace DayOfWeek.Models
{
    public class DayOfWeekClass
    {
        private DateTime date;

        public DayOfWeekClass(string dateString)
        {
            date = DateTime.Parse(dateString);
        }

        public string GetWeekday()
        {
            string dayString = string.Empty;
            switch (date.DayOfWeek)
            {
                case System.DayOfWeek.Sunday:
                    dayString = "Sunday";
                    break;
                case System.DayOfWeek.Monday:
                    dayString = "Monday";
                    break;
                case System.DayOfWeek.Tuesday:
                    dayString = "Tuesday";
                    break;
                case System.DayOfWeek.Wednesday:
                    dayString = "Wednesday";
                    break;
                case System.DayOfWeek.Thursday:
                    dayString = "Thursday";
                    break;
                case System.DayOfWeek.Friday:
                    dayString = "Friday";
                    break;
                case System.DayOfWeek.Saturday:
                    dayString = "Saturday";
                    break;
            }
            return dayString;
        }
    }
}