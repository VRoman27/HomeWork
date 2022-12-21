using Common;
/*Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.*/

int m = InputData.IntData("Введите количество строк: ");
int n = InputData.IntData("Введите количество столбцов: ");
double[,] array = GetArray.CreateRandom2DArrayDouble(m, n);
GetArray.Print2DArrayDouble(array);