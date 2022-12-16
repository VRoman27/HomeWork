using Common;
/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/

int num = EnteringData.IntData("Введите число: ");

GetArray.PrintTableInt(PowTableElemets(GetArray.GenElementsInOrder(num), 3));

int[] PowTableElemets(int[] array, int degree) //Возведение в степень каждого элемента массива
    {

        for (int i = 1; i <= array.Length; i++)
        {
            array[i - 1] = (int)Math.Pow((double)i, degree);
        }

        return array;
    }