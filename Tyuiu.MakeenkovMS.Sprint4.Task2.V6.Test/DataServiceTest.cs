using Tyuiu.MakeenkovMS.Sprint4.Task2.V6.Lib;

namespace Tyuiu.MakeenkovMS.Sprint4.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 2, 3, 4, 5, 6, 7, 8, 2, 4, 6, 8, 2, 4, 6, 3 };
            int res = ds.Calculate(numsArray);
            int wait = 315;
            Assert.AreEqual(wait, res);
        }
    }
}