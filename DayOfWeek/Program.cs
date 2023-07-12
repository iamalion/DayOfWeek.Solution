using System;
using DayOfWeek.Models;

namespace DayOfWeek
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a DayOfWeek instance with a date
            DayOfWeekClass dayOfWeek = new DayOfWeekClass("1986-03-23");

            // Get the weekday
            string weekday = dayOfWeek.GetWeekday();

            // Output the result
            Console.WriteLine("Weekday: " + weekday);
        }
    }
}