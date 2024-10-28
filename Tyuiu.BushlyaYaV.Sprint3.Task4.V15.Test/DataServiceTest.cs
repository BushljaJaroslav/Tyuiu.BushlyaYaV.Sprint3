
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

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 9.787;
            Assert.AreEqual(wait,res);








        }
    }
}