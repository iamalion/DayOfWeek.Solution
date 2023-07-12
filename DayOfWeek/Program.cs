using System;
using DayOfWeek.Models;

namespace DayOfWeek
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
            Console.WriteLine("Want to know what weekday you were born on? Or what weekday the moon landing happened? Or the weekday of any given date ever?? (With some exceptions.... let's not talk abou that time they just decided that they needed to skip forward three weeks in October....)");
            Console.WriteLine("~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
            Console.WriteLine("Look no further! Enter any date and I'll tell you what day of the week it was.");
            Console.WriteLine("~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
            Console.WriteLine("Write any date (for example March 23, 1986):");
            string date = Console.ReadLine();

            try
            {
                DayOfWeekClass dayOfWeek = new DayOfWeekClass(date);
                string weekday = dayOfWeek.GetWeekday();
                Console.WriteLine($"The weekday of {date} is {weekday}! How cool is that!");
            }
            catch (System.InvalidOperationException ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            
        }
    }
}