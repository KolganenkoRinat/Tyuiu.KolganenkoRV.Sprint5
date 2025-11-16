using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.KolganenkoRV.Sprint5.Task2.V30.Lib
{
    public class DataService : ISprint5Task2V30
    {
        public string SaveToFileTextData(int[,] matrix)
        {

            string directory = @"C:\Users\Ринат\source\repos\Tyuiu.KolganenkoRV.Sprint5\Tyuiu.KolganenkoRV.Sprint5.Task2.V30\bin\Debug\net8.0\";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            string path = Path.Combine(directory, "OutPutFileTask2.csv");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                { 
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        if (matrix[i, j] < 0)
                        {
                            matrix[i, j] = 0;
                        }                       
                    }
                }
            }
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }
                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else 
                {
                    File.AppendAllText(path, str);
                }
                str = "";
            }
            return path;
        }
    }
}
