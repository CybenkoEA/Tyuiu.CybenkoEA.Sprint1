using Tyuiu.CybenkoEA.Sprint1.Task3.V18.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.CybenkoEA.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 10;
            double z = 5;
            var res = ds.CalculateLogic(x, y, z);
            Assert.AreEqual(4, res);
        }
    }
}