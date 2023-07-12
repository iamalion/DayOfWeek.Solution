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
            string inputDate = "March 26, 1986";
            string expectedWeekday = "Wednesday";

            DayOfWeekClass dayOfWeek = new DayOfWeekClass(inputDate);

            string actualWeekday = dayOfWeek.GetWeekday();

            Assert.AreEqual(expectedWeekday, actualWeekday);
        }
    }
}