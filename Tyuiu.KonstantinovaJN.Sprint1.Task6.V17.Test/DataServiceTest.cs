using Tyuiu.KonstantinovaJN.Sprint1.Task6.V17.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint1.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string e = "aa aaaa aaaaaaaaa";
            DataService ds = new DataService();
            bool res = ds.CheckPalindrome(e);
            bool wait = true;
            Assert.AreEqual(true, res);
            
        }
    }
}