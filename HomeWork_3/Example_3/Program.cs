using Common;
/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/

int num = EnteringData.IntData("Введите число: ");

GetArray.PrintTable(GetArray.PowTableElemetsInt(GetArray.GenElementsInOrder(num), 3));

