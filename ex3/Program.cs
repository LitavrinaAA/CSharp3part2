Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
if ( num < 100)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}
String numToStr = num.ToString();
char secondNum = numToStr[2];

Console.WriteLine($"Вторым числом в {num} будет число {secondNum}");