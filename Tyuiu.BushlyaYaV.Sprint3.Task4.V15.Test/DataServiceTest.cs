
using Tyuiu.BushlyaYaV.Sprint3.Task4.V15.Lib;

namespace Tyuiu.BushlyaYaV.Sprint3.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VallidCalc()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(-5, 5);
            Assert.AreEqual(res, 623.499);








        }
    }
}