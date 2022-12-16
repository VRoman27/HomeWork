using Common;
// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

int n = InputData.IntData("Введите число: ");

for (int i = 1; i < n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
        Console.Write(", ");
    }
}

if (n % 2 == 0)
{
    Console.Write(n);
}