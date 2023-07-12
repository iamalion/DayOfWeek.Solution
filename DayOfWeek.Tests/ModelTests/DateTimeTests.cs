using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayOfWeek.Models;

namespace DayOfWeek.Tests
{
[TestClass]

public class DateTimeTests 
    {
        [TestMethod]

        public void GetWeekday_ReturnsCorrectWeekday()
        {
            string inputDate = "March 25, 1986";
            string expectedWeekday = "Tuesday";

            DayOfWeekClass dayOfWeek = new DayOfWeekClass(inputDate);

            string actualWeekday = dayOfWeek.GetWeekday();

            Assert.AreEqual(expectedWeekday, actualWeekday);
        }
    }
}