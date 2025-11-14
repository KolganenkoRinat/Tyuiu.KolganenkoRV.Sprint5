using Tyuiu.KolganenkoRV.Sprint5.Task0.V5.Lib;

namespace Tyuiu.KolganenkoRV.Sprint5.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Ринат\source\repos\Tyuiu.KolganenkoRV.Sprint5\Tyuiu.KolganenkoRV.Sprint5.Task0.V5\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
