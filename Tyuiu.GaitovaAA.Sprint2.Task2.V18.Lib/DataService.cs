using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GaitovaAA.Sprint2.Task2.V18.Lib
{
    public class DataService : ISprint2Task2V18
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 2 && x <= 6 && y >=5 && y <= 7) ||
                (x >= 3 && x <= 5 && y >= 3 && y <= 4) ||
                (x >= 6 && x <= 7 && y >= 4 && y <= 11) ||
                (x >= 8 && x <= 11 && y >= 7 && y <= 10) ||
                (x >= 12 && x <= 13 && y >= 3 && y <= 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
