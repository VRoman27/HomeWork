using Common;
//Напишите программу, которая заполнит спирально массив 4 на 4.

int line = InputData.IntData("Введите количество строк: ");
int column = InputData.IntData("Введите количество столбцов: ");
int[,] array = new int[line, column];
FillSpiral(array);
Print2DArray(array);

void FillSpiral(int[,] array)
{
    int startX = 0, finishX = array.GetLength(0) - 1,
        startY = 0, finisY = array.GetLength(1) - 1;
    int currentX = 0, currentY = 0;
    int number = 1;

    while (number < array.Length)
    {
        currentX = startX;
        for (currentY = startY; currentY < finisY; currentY++)
        {
            array[currentX, currentY] = number;
            number++;
        }
        finisY--;
        for (currentX = startX; currentX < finishX; currentX++)
        {
            array[currentX, currentY] = number;
            number++;
        }
        finishX--;
        for (currentY = finisY + 1; currentY > startY; currentY--)
        {
            array[currentX, currentY] = number;
            number++;
        }
        startY++;
        for (currentX = finishX + 1; currentX > startX; currentX--)
        {
            array[currentX, currentY] = number;
            number++;
        }
        startX++;
    }



}


void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 == 0) Console.Write("0" + array[i, j] + " ");
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}











