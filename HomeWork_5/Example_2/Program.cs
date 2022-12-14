using Common;
/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/

int[] array = GetArray.CreateRandomArrayInt(5, 0, 11);
GetArray.PrintTable(array);
Console.WriteLine($"Сумма элементов на нечётных позициях равна: {GetArray.SumNotEvenIndexElement(array)}.");

