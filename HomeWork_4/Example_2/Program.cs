using Common;
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int number = EnteringData.IntData("Введите число: ");

Console.WriteLine($"Сумма цифр в числе: {SumDigitInNumber(number)}");

int SumDigitInNumber(int number)
{
    int sum = 0;
    if (number < 0) number *= -1;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }

    return sum;
}