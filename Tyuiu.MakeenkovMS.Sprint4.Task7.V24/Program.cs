using Tyuiu.MakeenkovMS.Sprint4.Task7.V24.Lib;

namespace Tyuiu.MakeenkovMS.Sprint4.Task7.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int n = 5;
            int m = 3;
            string value = "651827384219648";

            Console.Title = "Спринт #4 | Выполнил: Макеенков М. С. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Макеенков М. С. | ПИНб-26-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"651827384219648\". Преобразуйте ее  *");
            Console.WriteLine("* в матрицу 5 на 3 и подсчитайте произведение четных чисел.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Исходная строка: {value}");
            Console.WriteLine($"Размер матрицы: {n} х {m}");

            int[,] mtrx = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value[i * m + j].ToString());
                }
            }

            Console.WriteLine("\nМатрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n, m, value);

            Console.WriteLine($"Произведение четных чисел равно: {res}");

            Console.ReadKey();
        }
    }
}