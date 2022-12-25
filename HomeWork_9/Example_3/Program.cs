using Common;
/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/
int numberM = InputData.IntData("Введите число M:");
int numberN = InputData.IntData("Введите число N:");
Console.WriteLine($"A({numberM}, {numberN}) = {Akkerman(numberM, numberN)}");

int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}
