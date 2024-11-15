using Tyuiu.KonstantinovaJN.Sprint1.Task5.V4.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double k = 13257;
            DataService ds = new DataService();
            double v = ds.SecondsToHours((int)k);
            double res = v;

            int result = Convert.ToInt32(res);

            int wait = 3;
            Assert.AreEqual(wait, result);
        }
    }
}