﻿using Common;
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double number = EnteringData.DoubleData("Введите число: ");
double degree = EnteringData.DoubleData("Введите степень: ");

Console.WriteLine(Math.Pow(number,degree));

Console.WriteLine(Сalculation.Pow(number,degree));