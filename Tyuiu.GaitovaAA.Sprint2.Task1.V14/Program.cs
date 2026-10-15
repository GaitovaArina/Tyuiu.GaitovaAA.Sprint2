using Tyuiu.GaitovaAA.Sprint2.Task1.V14.Lib;

namespace Tyuiu.GaitovaAA.Sprint2.Task1.V14
{
    class Program
    {
         static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 185;
            int b = 216;
            int c = 174;
            int d = 917;

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнила: Гаитова А. А. | ПКТб-26-1";
            //Длина строки 75 символов
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                              *");
            Console.WriteLine("* Тема: Логические операции                                                              *");
            Console.WriteLine("* Задание #1                                                                             *");
            Console.WriteLine("* Вариант #14                                                                            *");
            Console.WriteLine("* Выполнила: Гаитова А. А. | ПКТб-26-1                                                   *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                               *");
            Console.WriteLine("* Написать программу из операций сравнения                                               *");
            Console.WriteLine("* а также арифметических выражений,которая вернет логическую последовательность(массив): *");
            Console.WriteLine("* (False, True, True, True, True, False), при a = 185, b = 216, c = 174, d = 91          *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();

        }
    }
}