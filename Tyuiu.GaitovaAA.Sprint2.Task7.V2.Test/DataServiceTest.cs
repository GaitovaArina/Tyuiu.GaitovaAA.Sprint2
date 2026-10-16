using Tyuiu.GaitovaAA.Sprint2.Task7.V2.Lib;

namespace Tyuiu.GaitovaAA.Sprint2.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0;
            double y = -0.5;
            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(true, res);
        }
    }
}