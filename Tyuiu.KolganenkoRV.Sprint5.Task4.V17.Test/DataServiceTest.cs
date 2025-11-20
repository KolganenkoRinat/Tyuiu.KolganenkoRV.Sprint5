using Tyuiu.KolganenkoRV.Sprint5.Task4.V17.Lib;

namespace Tyuiu.KolganenkoRV.Sprint5.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Ринат\DataSprint5\InPutDataFileTask4V17.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
