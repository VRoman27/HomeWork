using Common;
/*Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.*/

int line = InputData.IntData("Введите количество строк: ");
int column = InputData.IntData("Введите количество столбцов: ");
int[,] array = GetArray.CreateRandom2DArrayInt(line, column, 0, 10);
GetArray.Print2DArrayInt(array);
int[] sumLine = SumLine(array);
Console.WriteLine($"Наименьшая сумма в строке id{FindIndexMinElement(sumLine)}");

int FindIndexMinElement(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}

int[] SumLine(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum[i] = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i,j];
        }
    }
    return sum;
}
