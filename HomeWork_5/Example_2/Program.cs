using Common;
/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/

int[] array = GetArray.CreateRandomArrayInt(5, 0, 11);
GetArray.PrintTableInt(array);
Console.WriteLine($"Сумма элементов на нечётных позициях равна: {SumNotEvenIndexElement(array)}.");

int SumNotEvenIndexElement(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }
        return sum;
    }
