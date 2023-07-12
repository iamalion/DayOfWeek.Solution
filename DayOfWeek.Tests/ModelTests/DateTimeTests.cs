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

        [TestMethod]
        public void GetWeekday_ReturnsError()
        {
            string inputDate = "abcdef";
            string expectedError = "There was an error.";

            try
            {
            DayOfWeekClass dayOfWeek = new DayOfWeekClass(inputDate);
            string weekday = dayOfWeek.GetWeekday();

            Assert.Fail("No exception was thrown.");
            }
            catch (System.InvalidOperationException ex)
            {
                Assert.AreEqual(expectedError, ex.Message);
            }
        }
    }
}