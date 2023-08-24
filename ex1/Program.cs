//using System.Diagnostics;
//Console.WriteLine("Третьей цифры нет");
Console.WriteLine("Hello");

int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

bool Check(int num)
{
    return num >= 100;
}

int ThirdNum(int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}
int number = InputNum("Введите число: ");
if (Check(number))
{
    int thirdNum = ThirdNum(number);
    Console.WriteLine($"Третья цифра числа {number} равна {thirdNum}");
}else{
     Console.WriteLine("Третьей цифры нет");
}