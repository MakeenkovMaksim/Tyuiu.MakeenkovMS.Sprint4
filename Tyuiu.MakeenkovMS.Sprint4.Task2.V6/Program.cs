using Tyuiu.MakeenkovMS.Sprint4.Task2.V6.Lib;

namespace Tyuiu.MakeenkovMS.Sprint4.Task2.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Макеенков М. С. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* SPRINT #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Макеенков Максим Сергеевич | ПИНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов, заполненный        *");
            Console.WriteLine("* случайными в диапазоне от 2 до 8. Подсчитать произведение нечетных      *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i < len; i++)
            {
                numsArray[i] = rnd.Next(2, 9);
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i < len; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArray);
            Console.WriteLine("Произведение нечетных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}