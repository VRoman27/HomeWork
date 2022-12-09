using Common;
/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/


int num = EnteringData.IntData("Введите число: ");

while (num > 99999 | num < 10000)
{
    Console.WriteLine("Нужно пятизначное число!");
    num = EnteringData.IntData("Введите число: ");
}
MultiDigitNumbers.ItsPalindrome(num);


