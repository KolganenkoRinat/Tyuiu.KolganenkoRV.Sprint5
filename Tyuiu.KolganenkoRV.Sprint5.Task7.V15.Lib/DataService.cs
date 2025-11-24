using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KolganenkoRV.Sprint5.Task7.V15.Lib
{
    public class DataService : ISprint5Task7V15
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    StringBuilder resultLine = new StringBuilder();
                    string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        if (word.Length != 2)
                        {
                            if (resultLine.Length > 0)
                                resultLine.Append(" ");
                            resultLine.Append(word);
                        }
                    }

                    if (resultLine.Length > 0)
                    {
                        File.AppendAllText(pathSaveFile, resultLine.ToString() + Environment.NewLine);
                    }
                }
            }
            return pathSaveFile;
        }   
    }
}
