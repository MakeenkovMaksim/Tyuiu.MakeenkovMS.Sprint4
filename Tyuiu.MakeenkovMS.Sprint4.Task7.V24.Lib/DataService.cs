using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MakeenkovMS.Sprint4.Task7.V24.Lib
{
    public class DataService : ISprint4Task7V24
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[n, m];
            int prod = 1;
            int countEven = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value[i * m + j].ToString());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] % 2 == 0)
                    {
                        prod *= mtrx[i, j];
                        countEven++;
                    }
                }
            }

            return countEven > 0 ? prod : 0;
        }
    }
}