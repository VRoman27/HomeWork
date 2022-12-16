using Common;
/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.*/

int num = 0;

do
{
    num = InputData.IntData("Введите число: ");
        if (num / 100 == 0)
    {
        Console.WriteLine("Нет третьей цифры!");
    }

}
while(num / 100 == 0);

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



