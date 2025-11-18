using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KolganenkoRV.Sprint5.Task3.V9.Lib
{
    public class DataService : ISprint5Task3V9
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            double z = Math.Round(Math.Pow(x, 3) / (Math.Pow(x, 2) - 1), 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            { 
                writer.Write(BitConverter.GetBytes(z));
            }
            return path;
        }
    }
}
