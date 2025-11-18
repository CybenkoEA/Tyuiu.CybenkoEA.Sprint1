using Tyuiu.CybenkoEA.Sprint1.Task3.V18.Lib;
namespace Tyuiu.CybenkoEA.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.CalculateLogic(10, 10, 5);
            Assert.AreEqual(4, res);
        }
    }
}