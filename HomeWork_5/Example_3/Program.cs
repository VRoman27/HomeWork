using Common;
/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.*/

double[] array = EnteringData.DoubleArrayData();
GetArray.PrintTableDouble(array);
(double min, double max) = GetArray.FindMinAndMaxElement(array);
Console.WriteLine($"Min:{min}. Max:{max}");
Console.WriteLine($"Разница: {max - min}");
