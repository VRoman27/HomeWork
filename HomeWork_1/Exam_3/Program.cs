using Common;
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка)

int num = InputData.IntData("Введите число: ");

if (num%2 == 0)
{
    Console.Write("Чётное");
}
else
{
    Console.Write("нечётное");
}