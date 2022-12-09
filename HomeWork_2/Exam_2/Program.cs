/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.*/

bool isParsed = false;
int num = 0;
while (!isParsed)
{
    Console.Write("Введите число: ");
    isParsed = int.TryParse(Console.ReadLine(), out num);
    if (isParsed & num / 100 == 0)
    {
        Console.WriteLine("Нет третьей цифры!");
        isParsed = false;
    }
    else if (!isParsed)
    {
        Console.WriteLine("Это не число!");
    }
}

int thirdDigit = 0;


if (num / 1000 == 0)
{
    thirdDigit = num % 10;
}
else
{
    while (num / 1000 != 0)
    {
        num /= 10;
    }
    thirdDigit = num % 10;
}

Console.WriteLine(thirdDigit);



