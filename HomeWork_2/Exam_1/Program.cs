using Common;
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/

int num = 0;

do
{
    num = EnteringData.IntData("Введите трёхзначное число: ");

}
while (!(num < 1000 & num > 99));

int midDigit = (num % 100) / 10;

Console.WriteLine(midDigit);