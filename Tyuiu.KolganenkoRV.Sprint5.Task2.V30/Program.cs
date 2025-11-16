using Tyuiu.KolganenkoRV.Sprint5.Task2.V30.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #5 | Выполнила : Колганенко Р. В. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #30                                                             *");
Console.WriteLine("* Выполнил: Колганенко Ринат Витальевич | ИБКСб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[,] matrix = new int[3, 3] { { 3, -1, 3 }, { -2, -5, 0 }, { -8, -7, 2 } };
int rows = matrix.GetUpperBound(0) + 1;
int columns = matrix.Length / rows;
for (int i = 0; i < rows; i++)
{ 
    for (int j = 0; j < columns; j++)
    {
        Console.WriteLine($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
string res = ds.SaveToFileTextData(matrix);
Console.WriteLine("File " + res);
Console.WriteLine("Completed");
Console.ReadKey();
