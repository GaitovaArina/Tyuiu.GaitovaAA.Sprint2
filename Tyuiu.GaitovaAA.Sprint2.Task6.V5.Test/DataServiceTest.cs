using Tyuiu.GaitovaAA.Sprint2.Task6.V5.Lib;

namespace Tyuiu.GaitovaAA.Sprint2.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardValue()
        {
            DataService ds = new DataService();

            Assert.AreEqual("шестерка", ds.FindCardValue(6));
            Assert.AreEqual("валет", ds.FindCardValue(11));
            Assert.AreEqual("туз", ds.FindCardValue(14));
        }
    }
}