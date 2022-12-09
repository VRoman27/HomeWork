/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.*/


bool isParsed = false;
int day = 0;
while (!isParsed)
{
    Console.Write("Введите номер дня недели: ");
    isParsed = int.TryParse(Console.ReadLine(), out day);
    if (isParsed & !(day < 8 & day > 1))
    {
        Console.WriteLine("В неделе 7 дней!");
        isParsed = false;
    }
    else if (!isParsed)
    {
        Console.WriteLine("Это не число!");
    }
}

if (day == 6 | day == 7)
{
    Console.WriteLine("Ура выходной!");
}
else
{
    Console.WriteLine("Опять работа..?");
}
