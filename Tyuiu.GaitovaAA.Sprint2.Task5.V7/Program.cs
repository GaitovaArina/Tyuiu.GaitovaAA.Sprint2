using Tyuiu.GaitovaAA.Sprint2.Task5.V7.Lib;

namespace Tyuiu.GaitovaAA.Sprint2.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Гаитова А. А.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант 7                                                               *");
            Console.WriteLine("* Выполнила: Гаитова А. А.                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* С начала 1990 года по некоторой день прошло n месяцев и 2 дня.          *");
            Console.WriteLine("* Определить название месяца (январь, февраль и т. п.) этого дня.         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startYear = 1990;
            Console.WriteLine($"Начальный год: {startYear}");

            Console.WriteLine("Введите количество прошедших месяцев (n):");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.FindMonthName(startYear,n);
            Console.WriteLine($"Месяц: {res}");

            Console.ReadKey();
        }
    }
}