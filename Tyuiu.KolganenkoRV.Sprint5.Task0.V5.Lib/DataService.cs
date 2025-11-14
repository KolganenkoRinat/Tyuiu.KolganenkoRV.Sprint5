using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.KolganenkoRV.Sprint5.Task0.V5.Lib
{
    public class DataService : ISprint5Task0V5
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = Math.Log((x + 1) / (x + 2));
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
