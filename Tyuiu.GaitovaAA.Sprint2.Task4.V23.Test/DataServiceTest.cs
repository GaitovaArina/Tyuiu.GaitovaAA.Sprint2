using Tyuiu.GaitovaAA.Sprint2.Task4.V23.Lib;

namespace Tyuiu.GaitovaAA.Sprint2.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 1.063;
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
