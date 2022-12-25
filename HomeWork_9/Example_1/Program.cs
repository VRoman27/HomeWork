using Common;
/*Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.*/

int number  = InputData.IntData("Введите число:");
DecreaseNumbers(number);

void DecreaseNumbers(int number, int tmp = 1)
{
    Console.Write($"{number}, ");
    number--;
    if(tmp > number)
    {
        return;
    }
    DecreaseNumbers(number, tmp);
}