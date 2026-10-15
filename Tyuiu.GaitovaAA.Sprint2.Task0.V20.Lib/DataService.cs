//ЗАДАНИЕ
//Написать программу из операций сравнений и арифметических выражений,
//которая вернет логическую последовательность(массив): (True,False,True,False,True,False), при x = 1075, y = 275
// (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) 
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GaitovaAA.Sprint2.Task0.V20.Lib
{
    public class DataService : ISprint2Task0V20
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x > y;
            res[1] = x - 1 == y;
            res[2] = x - 800 == y;
            res[3] = x <= y;
            res[4] = x != y;
            res[5] = x < y;

            return res;
        }
    }
}
