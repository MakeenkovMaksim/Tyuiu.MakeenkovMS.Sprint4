using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MakeenkovMS.Sprint4.Task6.V14.Lib
{
    public class DataService : ISprint4Task6V14
    {
        public string[] Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, x => x.Length > 3);
            return res;
        }
    }
}