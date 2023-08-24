int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int ThirdNum(int num)
{
    int thirdNum = num % 10;
}

int ConvertNum(int number)
{
    while (number >= 1000) number = number/10;
    return number;
}
int num = InputNum("Введите любое целое число:");
int result = num;

if (Math.Abs(result) >= 100)
{
    int thirdNum = ThirdNum(ConvertNumber(Math.Abs(result)));
    Console.WriteLine($"Третья цифра в числе {num} это {thirdNum}");
} else Console.WriteLine($"Третьей цифры в числе {num} нет");