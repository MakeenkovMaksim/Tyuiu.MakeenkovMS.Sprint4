using Tyuiu.MakeenkovMS.Sprint4.Task7.V24.Lib;

namespace Tyuiu.MakeenkovMS.Sprint4.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int n = 5;
            int m = 3;
            string value = "651827384219648";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, value);
            int wait = 1179648;
            Assert.AreEqual(wait, res);
        }
    }
}