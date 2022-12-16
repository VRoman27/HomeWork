using Common;
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double number = EnteringData.DoubleData("Введите число: ");
int degree = EnteringData.IntData("Введите степень: ");

Console.WriteLine(Pow(number, degree));

double Pow(double num, int degree)
{
    double result = 0;
    if (degree == 0)
    {
        result = 1;
    }
    else if (degree >= 1)
    {
        result = num;
        for (int i = 1; i < degree; i++)
        {
            result *= num;
        }
    }
    else if (degree <= -1)
    {
        result = 1 / num;
        for (int i = -1; i > degree; i--)
        {
            result /= num;
        }
    }
    else
    {
        return -1;
    }


    return result;
}