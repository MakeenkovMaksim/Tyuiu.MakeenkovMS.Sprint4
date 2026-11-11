using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MakeenkovMS.Sprint4.Task3.V18.Lib
{
    public class DataService : ISprint4Task3V18
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int lastRowIndex = rows - 1;
            int max = array[lastRowIndex, 0];

            for (int j = 0; j < columns; j++)
            {
                if (array[lastRowIndex, j] > max)
                {
                    max = array[lastRowIndex, j];
                }
            }
            return max;
        }
    }
}