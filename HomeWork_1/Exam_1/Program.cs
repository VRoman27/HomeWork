// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
double num_1 = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double num_2 = double.Parse(Console.ReadLine());

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
