using Common;
/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

int[] positiveArray = GetArray.CreateRandomArrayInt(10, 100, 1000);
GetArray.PrintTable(positiveArray);
Console.WriteLine($"Найдено {GetArray.CountEvenNumbers(positiveArray)} четных чисел.");
