using System.Windows.Markup;
using Tyuiu.KolganenkoRV.Sprint5.Task6.V19.Lib;

namespace Tyuiu.KolganenkoRV.Sprint5.Task6.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Ринат\DataSprint5\InPutDataFileTask5V28.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        public void TestMethod2()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Ринат\DataSprint5\InPutDataFileTask5V28.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
