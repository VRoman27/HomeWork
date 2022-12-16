using Common;
/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

int[] positiveArray = GetArray.CreateRandomArrayInt(10, 100, 1000);
GetArray.PrintTableInt(positiveArray);
Console.WriteLine($"Найдено {CountEvenNumbers(positiveArray)} четных чисел.");

int CountEvenNumbers(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) return -1;
            if (array[i] % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }