using Tyuiu.GaitovaAA.Sprint2.Task7.V2.Lib;

namespace Tyuiu.GaitovaAA.Sprint2.Task7.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Гаитова А. А.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант 2                                                               *");
            Console.WriteLine("* Выполнила: Гаитова А. А.                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает исходные данные (вещественные)  *");
            Console.WriteLine("* и вычисляет, находится ли точка с координатами X, Y в заштрихованной    *");
            Console.WriteLine("* области.                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);

            if (res)
            {
                Console.WriteLine($"Точка с координатами ({x}, {y}) находится в заштрихованной области.");
            }
            else
            {
                Console.WriteLine($"Точка с координатами ({x}, {y}) НЕ находится в заштрихованной области.");
            }

            Console.ReadKey();
        }
    }
}