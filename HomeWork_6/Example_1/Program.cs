using Common;
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
double[] array = InputData.DoubleArrayData();
GetArray.PrintTableDouble(array);
Console.WriteLine($"{CountNumbersMoreZero(array)} чисел больше нуля.");

int CountNumbersMoreZero(double[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
