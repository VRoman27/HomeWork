using Common;
/*Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.*/

int numberM = InputData.IntData("Введите число M:");
int numberN = InputData.IntData("Введите число N:");
int sum;
if (numberM > numberN) sum = Sum(numberN, numberM);
else sum = Sum(numberM, numberN);
Console.WriteLine($"Сумма чисел от {numberM} до {numberN} равна: {sum}");

int Sum(int m, int n)
{
    int result = 0;
    if (m <= n)
    {
        result += m;
        m++;
        return result + Sum(m, n);
    }
    return result;

}