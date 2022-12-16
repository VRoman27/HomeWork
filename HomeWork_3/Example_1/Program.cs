using Common;
/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/


int num = InputData.IntData("Введите число: ");

while (num > 99999 | num < 10000)
{
    Console.WriteLine("Нужно пятизначное число!");
    num = InputData.IntData("Введите число: ");
}
ItsPalindrome(num);

int InvertDigitPosition(int number, int numDigit)
    {
        int newNumber = 0;
        for (int i = numDigit - 1; i >= 0; i--)
        {
            newNumber = newNumber + (number % 10) * (int)Math.Pow(10, (double)i);
            number /= 10;
        }
        return newNumber;
    }

void ItsPalindrome(int x)
    {
        if (x == InvertDigitPosition(x, 5))
        {
            Console.WriteLine("Это полиндром");
        }
        else
        {
            Console.WriteLine("Это не полиндром");
        }
    }


