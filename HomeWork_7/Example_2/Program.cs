using Common;
/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

int m = InputData.IntData("Введите количество строк: ");
int n = InputData.IntData("Введите количество столбцов: ");
int[,] array = GetArray.CreateRandom2DArrayInt(m, n, 0, 50);
GetArray.Print2DArrayInt(array);


int findM = InputData.IntData("Введите индекс строки: ");
int findN = InputData.IntData("Введите индекс столбца: ");

if (FindElementIn2DArray(array, findM, findN))
{
    Console.WriteLine($"Элемент ({findM},{findN}): {array[findM, findN]}");

}
else
{
    Console.WriteLine("Нет такого элемента!");
}


bool FindElementIn2DArray(int[,] array, int lineIndex, int columnIndex)
{
    if (lineIndex < 0 | lineIndex > array.GetLength(0) - 1 | columnIndex < 0 | columnIndex > array.GetLength(1) - 1)
    {
        return false;
    }
    else
    {
        return true;

    }
}

