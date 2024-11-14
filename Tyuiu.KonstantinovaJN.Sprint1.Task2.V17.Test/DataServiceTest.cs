using Tyuiu.KonstantinovaJN.Sprint1.Task2.V17.Lib;
using Tyuiu.KonstantinovaJN.Sprint1.Task2.V17.Lib.MinutesToHoursLibrary;

namespace Tyuiu.KonstantinovaJN.Sprint1.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void MinutesToHours_ValidInput_ReturnsCorrectHours()
        {

            int minutes = 120;
            int expectedHours = 2;
            int actualHours = TimeConverter.MinutesToHours(minutes);
            Assert.AreEqual(expectedHours, actualHours);
        }

        [TestMethod]
        public void MinutesToHours_ZeroMinutes_ReturnsZeroHours()
        {
            int minutes = 0;
            int expectedHours = 0;
            int actualHours = TimeConverter.MinutesToHours(minutes);
            Assert.AreEqual(expectedHours, actualHours);
        }
    }
}
