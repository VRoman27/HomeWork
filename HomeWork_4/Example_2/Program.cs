using Common;
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int number = EnteringData.IntData("Введите число: ");

Console.WriteLine($"Сумма цифр в числе: {Calculation.SumDigitInNumber(number)}");

