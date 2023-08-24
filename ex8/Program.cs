// принимает число, выдает квадраты чисел
// 5 -> 1, 4 , 9, 

int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string SqFrom1ToN(int num)
{
    int i = 1;
    string res = String.Empty;
    while (i <= num)
    {
        res += " " + Math.Pow(i, 2);
        i++;
    }
    return res;
}
System.Console.Write(SqFrom1ToN(InputNum("введите число: ")));