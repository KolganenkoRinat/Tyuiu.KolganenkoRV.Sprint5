using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KolganenkoRV.Sprint5.Task1.V21.Lib
{
    public class DataService : ISprint5Task1V21
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string str;
            for (int i = startValue; i <= stopValue; i++)
            {
                y = Math.Round(((2 * i - 3) / (Math.Cos(i) - 2 * i)) + 5 * i - Math.Sin(i), 2);
                str = Convert.ToString(y);
                if (i != stopValue)
                {

                    if (Math.Cos(i) - 2 * i == 0)
                    {
                        File.AppendAllText(path, "0" + Environment.NewLine);
                    }
                    else
                    {
                        File.AppendAllText(path, str + Environment.NewLine);
                    }
                
                }
                else
                {
                    if (Math.Cos(i) - 2 * i == 0)
                    {
                        File.AppendAllText(path, "0");
                    }
                    else
                    {
                        File.AppendAllText(path, str);
                    }
                }
            }
            return path;
        }
    }
}
