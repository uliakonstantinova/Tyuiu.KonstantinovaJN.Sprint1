using Tyuiu.KonstantinovaJN.Sprint1.Task2.V17.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint1.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 120;
            var res = ds.ConvertMinutesToHours(x);
            Assert.AreEqual(2, res);
        }
    }
}
