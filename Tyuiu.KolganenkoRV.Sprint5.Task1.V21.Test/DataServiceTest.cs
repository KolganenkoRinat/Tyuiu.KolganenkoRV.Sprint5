using Tyuiu.KolganenkoRV.Sprint5.Task1.V21.Lib;

namespace Tyuiu.KolganenkoRV.Sprint5.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Ринат\source\repos\Tyuiu.KolganenkoRV.Sprint5\Tyuiu.KolganenkoRV.Sprint5.Task1.V21\bin\Debug\net8.0\OutPutFileTask1.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
