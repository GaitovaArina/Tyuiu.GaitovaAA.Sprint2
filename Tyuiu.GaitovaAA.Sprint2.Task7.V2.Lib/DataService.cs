using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GaitovaAA.Sprint2.Task7.V2.Lib
{
    public class DataService : ISprint2Task7V2
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Проверка попадания в заштрихованную область:
            // 1) Точка лежит в нижней полусфере или на окружности радиуса 1: x^2 + y^2 <= 1 (с погрешностью для вещественных чисел)
            // 2) y <= 0 (нижняя часть плоскости)
            // 3) y <= x / 2 (под прямой)
            // 4) x находится в пределах от -1 до 1 (или ограничивается окружностью)

            bool inCircle = (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1);
            bool belowLine = (y <= x / 2);
            bool inBottomHalf = (y <= 0);
            bool inXRange = (x >= -1 && x <= 1);

            if (inCircle && belowLine && inBottomHalf && inXRange)
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