using Tyuiu.KonstantinovaJN.Sprint1.Task0.V1.Lib;
namespace Tyuiu.KonstantinovaJN.Sprint1.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(-6, res);
        }
    }
}