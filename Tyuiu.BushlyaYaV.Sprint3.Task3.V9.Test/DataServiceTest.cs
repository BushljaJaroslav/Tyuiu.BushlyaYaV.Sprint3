using Tyuiu.BushlyaYaV.Sprint3.Task3.V9.Lib;

namespace Tyuiu.BushlyaYaV.Sprint3.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "56hy vfe4r4 vf45b";
            char item = 'w';
            string wait = "wwhy vfewrw vfwwb";
            string res = ds.ReplaceNumOnChar(value, 'w');
            Assert.AreEqual(wait, res);
        }
    }
}