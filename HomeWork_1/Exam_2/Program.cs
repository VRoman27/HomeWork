// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
double num_1 = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double num_2 = double.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
double num_3 = double.Parse(Console.ReadLine());

double max = num_1;

if (num_2 > max)
{
    max = num_2;
}
if (num_3 > max)
{
    max = num_3;
}
Console.Write("max: ");
Console.Write(max);