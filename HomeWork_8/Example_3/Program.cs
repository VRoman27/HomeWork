using Common;
/*Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.*/
int line1 = InputData.IntData("Введите количество строк первой матрицы: ");
int column1 = InputData.IntData("Введите количество столбцов первой матрицы: ");
int line2 = InputData.IntData("Введите количество строк второй матрицы: ");
int column2 = InputData.IntData("Введите количество столбцов второй матрицы: ");
Console.WriteLine("Первая матрица:");
int[,] array1 = GetArray.CreateRandom2DArrayInt(line1, column1, 0, 10);
GetArray.Print2DArrayInt(array1);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
int[,] array2 = GetArray.CreateRandom2DArrayInt(line2, column2, 0, 10);
GetArray.Print2DArrayInt(array2);
Console.WriteLine();
Console.WriteLine("Результат умножения:");
try
{
    int[,] result = MultiplyMatrix(array1, array2);
    GetArray.Print2DArrayInt(result);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


int[,] MultiplyMatrix(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    result[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
        return result;
    }
    else throw new Exception("Нельзя преремножить такие матрицы");
}
