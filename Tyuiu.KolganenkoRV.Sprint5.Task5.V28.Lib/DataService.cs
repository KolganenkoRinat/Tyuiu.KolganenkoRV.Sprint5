using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KolganenkoRV.Sprint5.Task5.V28.Lib
{
    public class DataService : ISprint5Task5V28
    {
        public double LoadFromDataFile(string path)
        {
            
            double min = 10000000000;
            using (StreamReader reader = new StreamReader(path))
            {              
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Разделяем строку по пробелам
                    string[] numbers = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    foreach (string numberStr in numbers)
                    {
                        double x = double.Parse(numberStr, CultureInfo.InvariantCulture);

                        // Ищем минимальное положительное число, кратное 5
                        if ((x > 0) && (x % 5 == 0) && (x < min))
                        {
                            min = x;
                            
                        }
                    }
                }
                double res = 1;
                for (int i = 2; i <= min; i++)
                {
                    res = res * i;
                }
                return res;
            }
        }
    }
}
