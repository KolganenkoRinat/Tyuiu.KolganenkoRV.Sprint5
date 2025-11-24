using System.Data.SqlTypes;
using Tyuiu.KolganenkoRV.Sprint5.Task7.V15.Lib;

DataService ds = new DataService();
Console.Title = "Спринт #5 | Выполнила : Колганенко Р. В. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #15                                                             *");
Console.WriteLine("* Выполнил: Колганенко Ринат Витальевич | ИБКСб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = @"C:\Users\Ринат\DataSprint5\InPutDataFileTask7V15.txt";
string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7.txt");

Console.WriteLine("Данные находятся в файле " + path);
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
pathSaveFile = ds.LoadDataAndSave(path);
Console.WriteLine("File " + pathSaveFile);
Console.WriteLine("Completed");
Console.ReadKey();