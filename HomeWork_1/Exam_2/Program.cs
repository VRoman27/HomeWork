using Common;
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

double num_1 = EnteringData.DoubleData("Введите первое число: ");
double num_2 = EnteringData.DoubleData("Введите второе число: ");
double num_3 = EnteringData.DoubleData("Введите третье число: ");

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