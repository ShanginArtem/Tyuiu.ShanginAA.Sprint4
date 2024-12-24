using Tyuiu.ShanginAA.Sprint4.Task0.V5.Lib;

namespace Tyuiu.ShanginAA.Sprint4.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            var res = ds.GetSumEvenArrEl(array);
            int wait = 32;
            Assert.AreEqual(wait, res);
        }
    }
}