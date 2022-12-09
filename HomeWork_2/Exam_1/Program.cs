/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/

bool isParsed = false;
int num = 0;

while (!isParsed)
{
    Console.Write("Введите число: ");
    isParsed = int.TryParse(Console.ReadLine(), out num);
    if (isParsed & !(num < 1000 & num > 99))
    {
        Console.WriteLine("Не трёхзначное число!");
        isParsed = false;
    }
    else if (!isParsed)
    {
        Console.WriteLine("Это не число!");
    }
}

int midDigit = (num % 100) / 10;

Console.WriteLine(midDigit);