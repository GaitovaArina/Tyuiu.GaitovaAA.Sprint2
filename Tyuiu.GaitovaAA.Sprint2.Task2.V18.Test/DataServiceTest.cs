using Tyuiu.GaitovaAA.Sprint2.Task2.V18.Lib;

namespace Tyuiu.GaitovaAA.Sprint2.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 5;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);

            int x1 = 1;
            int y1 = 1;

            bool res1 = ds.CheckDotInShadedArea(x1, y1);
            bool wait1 = false;

            Assert.AreEqual(wait1, res1);
        }
    }
}
