using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KolganenkoRV.Sprint5.Task4.V17.Lib
{
    public class DataService : ISprint5Task4V17
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = double.Parse(strX, CultureInfo.InvariantCulture);
            double z = Math.Sin(2.0 / (3.0 * x)) + Math.Pow(x, 2);
            double res = Math.Round(z, 3);
            return res;
        }
    }
}
