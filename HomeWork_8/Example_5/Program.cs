using Common;
//Напишите программу, которая заполнит спирально массив 4 на 4.

int line = InputData.IntData("Введите количество строк: ");
int column = InputData.IntData("Введите количество столбцов: ");
int[,] array = new int[line, column];
FillSpiral(array, 0, 0, 1);
GetArray.Print2DArrayInt(array);

void FillSpiral(int[,] array, int xIndex, int yIndex, int value)
{
    if (xIndex >= 0 && yIndex >= 0 && xIndex < array.GetLength(0) && yIndex < array.GetLength(1))
    {
        if (array[xIndex, yIndex] == 0)
        {
            array[xIndex, yIndex] = value;
            FillSpiral(array, xIndex, yIndex + 1, value + 1);
            FillSpiral(array, xIndex + 1, yIndex, value + 1);
            FillSpiral(array, xIndex, yIndex - 1, value + 1);
            FillSpiral(array, xIndex - 1, yIndex, value + 1);
        }
    }



}