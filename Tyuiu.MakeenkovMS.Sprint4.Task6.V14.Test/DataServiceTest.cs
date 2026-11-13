using Tyuiu.MakeenkovMS.Sprint4.Task6.V14.Lib;

namespace Tyuiu.MakeenkovMS.Sprint4.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var months = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };
            string[] res = ds.Calculate(months);
            string[] wait = new string[] { "Январь", "Февраль", "Март", "Апрель", "Июнь", "Июль" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}