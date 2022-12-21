using Common;
/*Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.*/

int m = InputData.IntData("Введите количество строк: ");
int n = InputData.IntData("Введите количество столбцов: ");
int[,] array = GetArray.CreateRandom2DArrayInt(m, n, 0, 10);
Console.WriteLine();
GetArray.Print2DArrayInt(array);
double[] meanColumn = MeanInColumn(array);
Console.WriteLine();
GetArray.PrintTableDouble(meanColumn);

double[] MeanInColumn(int[,] array)
{
    double[] mean = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        mean[i] = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            mean[i] += array[j, i];
        }
        mean[i] /= array.GetLength(0);
    }
    return mean;
}
