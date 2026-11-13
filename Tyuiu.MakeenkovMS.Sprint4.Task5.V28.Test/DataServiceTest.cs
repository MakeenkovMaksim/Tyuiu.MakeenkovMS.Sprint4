using Tyuiu.MakeenkovMS.Sprint4.Task5.V28.Lib;

namespace Tyuiu.MakeenkovMS.Sprint4.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] {
                { -6, 3, -1, 0, 2 },
                { -4, 1, -2, 3, -5 },
                { 0, -3, 2, -6, 1 },
                { 3, -5, 0, 2, -1 },
                { -2, 1, -4, 3, 0 }
            };

            int[,] res = ds.Calculate(mas2);

            int[,] wait = new int[5, 5] {
                { 0, 3, 0, 0, 2 },
                { 0, 1, 0, 3, 0 },
                { 0, 0, 2, 0, 1 },
                { 3, 0, 0, 2, 0 },
                { 0, 1, 0, 3, 0 }
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}