using Tyuiu.KonstantinovaJN.Sprint1.Task4.V21.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint1.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 5;
            double wait = 1.375;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}