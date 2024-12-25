using Tyuiu.ShanginAA.Sprint4.Task6.V20.Lib;

namespace Tyuiu.ShanginAA.Sprint4.Task6.V20
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
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
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

            var predmet = new string[] { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература" };

            Console.WriteLine("Исходный массив: ");

            string[] mas = ds.Calculate(predmet);

            for (int i = 0; i <= predmet.Length - 1; i++)
            {
                Console.WriteLine(predmet[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("элементы, длина которых меньше 10 символов");
            for (int i = 0; i <= mas.Length - 1; i++)
            {
                Console.WriteLine(mas[i]);
            }

            Console.ReadKey();


        }
    }
}