using Tyuiu.GaitovaAA.Sprint2.Task5.V7.Lib;

namespace Tyuiu.GaitovaAA.Sprint2.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();

            int startYear = 1990;

            Assert.AreEqual("Январь", ds.FindMonthName(startYear, 1));
            
            Assert.AreEqual("Март", ds.FindMonthName(startYear, 3));
           
            Assert.AreEqual("Декабрь", ds.FindMonthName(startYear, 12));

        }
    }
}
