using Tyuiu.KolganenkoRV.Sprint5.Task3.V9.Lib;

namespace Tyuiu.KolganenkoRV.Sprint5.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Ринат\AppData\Local\Temp\OutPutFileTask3.bin";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
