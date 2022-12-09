using Common;
/*Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.*/
double x1 = EnteringData.DoubleData("Введите x1: ");
double y1 = EnteringData.DoubleData("Введите y1: ");
double z1 = EnteringData.DoubleData("Введите z1: ");
double x2 = EnteringData.DoubleData("Введите x2: ");
double y2 = EnteringData.DoubleData("Введите y2: ");
double z2 = EnteringData.DoubleData("Введите z2: ");

Console.WriteLine(Сalculation.Length3D(x1, y1, z1, x2, y2, z2));


