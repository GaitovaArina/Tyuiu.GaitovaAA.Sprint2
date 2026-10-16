using Tyuiu.GaitovaAA.Sprint2.Task6.V5.Lib;

namespace Tyuiu.GaitovaAA.Sprint2.Task6.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Гаитова А. А.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант 5                                                               *");
            Console.WriteLine("* Выполнила: Гаитова А. А.                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По заданному номеру карты k (6 <= k <= 14) определить достоинство       *");
            Console.WriteLine("* соответствующей карты с помощью сокращенной формы switch.               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер карты (от 6 до 14):");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (k >= 6 && k <= 14)
            {
                string res = ds.FindCardValue(k);
                Console.WriteLine($"Достоинство карты: {res}");
            }
            else
            {
                Console.WriteLine("Введено неверное значение! Номер должен быть от 6 до 14.");
            }

            Console.ReadKey();
        }
    }
}