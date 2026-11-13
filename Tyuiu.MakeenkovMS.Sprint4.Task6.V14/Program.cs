using Tyuiu.MakeenkovMS.Sprint4.Task6.V14.Lib;

namespace Tyuiu.MakeenkovMS.Sprint4.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Макеенков М. С. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Макеенков М. С. | ПИНб-26-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Январь\", \"Февраль\", \"Март\",         *");
            Console.WriteLine("* \"Апрель\", \"Май\", \"Июнь\", \"Июль\"], используя класс Array,        *");
            Console.WriteLine("* выведите элементы массива, длина которых больше 3 символа.              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < months.Length; i++)
            {
                Console.WriteLine(months[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] res = ds.Calculate(months);

            Console.WriteLine("Элементы массива, длина которых больше 3 символов:");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}