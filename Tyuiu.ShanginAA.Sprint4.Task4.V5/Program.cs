using Tyuiu.ShanginAA.Sprint4.Task4.V5.Lib;

namespace Tyuiu.ShanginAA.Sprint4.Task4.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Шангин А. А. | ИСП6-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Шангин Артём Александрович | ИСПб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
            Console.WriteLine("* числовому отрезку [6, 15] сумму всех делителей                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5];

            Console.WriteLine("Введите элементы матрицы размером 5x5 (значения от 3 до 9):");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int value;
                    while (true)
                    {
                        Console.Write($"Введите элемент массива [{i + 1}, {j + 1}]: ");
                        if (int.TryParse(Console.ReadLine(), out value) && value >= 3 && value <= 9)
                        {
                            matrix[i, j] = value;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Некорректное значение. Введите число от 3 до 9.");
                        }
                    }
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var result = ds.Calculate(matrix);
            Console.WriteLine("Сумма четных элемнтов массива: " + result);

            Console.ReadKey();


        }
    }
}