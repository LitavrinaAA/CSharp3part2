/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

bool isPolindrom(int i)
{
    System.Console.WriteLine("проверим");
    if (i < 99999)
    {
        System.Console.WriteLine("Это пятизначное число");
        int i1 = i % 10;
        int i2 = (i / 10) % 10;

        int i4 = (i / 1000) % 10;
        int i5 = (i / 10000) % 10;

        if (((i1 == i5) && (i2 == i4)))
        {
            return true;
        }

    }
    else
    {
        System.Console.WriteLine("Это не пятизначное число");
    }
    return false;

}


if (isPolindrom(InputNum("Полиндром : ")))
    System.Console.WriteLine("да, это полиндром.");
else
    System.Console.WriteLine("нет, это не полиндром.");
