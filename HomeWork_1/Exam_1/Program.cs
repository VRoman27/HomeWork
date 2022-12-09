using Common;
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

double num_1 = EnteringData.DoubleData("Введите первое число: ");
double num_2 = EnteringData.DoubleData("Введите второе число: ");

if(num_1 == num_2)
{
    Console.Write("Числа равны.");
}
else if(num_1 > num_2)
{
    Console.Write("max: ");
    Console.WriteLine(num_1);
    Console.Write("min: ");
    Console.WriteLine(num_2);
}
else
{
    Console.Write("max: ");
    Console.WriteLine(num_2);
    Console.Write("min: ");
    Console.WriteLine(num_1);
}
