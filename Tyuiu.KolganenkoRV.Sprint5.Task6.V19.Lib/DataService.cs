using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KolganenkoRV.Sprint5.Task6.V19.Lib
{
    public class DataService : ISprint5Task6V19
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Разбиваем строку на слова и проверяем каждое
                    string[] words = line.Split(' ');
                    foreach (string word in words)
                    {
                        // Если слово состоит ровно из 2 цифр - это двузначное число
                        if ((word.Length == 2) && (char.IsDigit(word[0])) && (char.IsDigit(word[1])))
                        {
                            count++;
                        }
                    }
                }
                return count;
            }
        }
    }
}
