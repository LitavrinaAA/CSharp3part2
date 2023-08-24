// задача 17 принимает координаты [x,y]
// x != 0 y != 0  и выдает номер четверти

int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int Quarter(int x, int y){
    int num = 0;
    if (x>0 && y>0)
    num = 1;
    else if (x < 0 && y > 0)
    num = 2;
    else if (x < 0 && y < 0)
    num = 3;
    else if (x > 0 && y < 0)
    num = 4;
    return num;
}

int x = InputNum("Введите координаты х: ");
int y = InputNum("Введите координаты y: ");

int quarterXY = Quarter(x,y);
if(quarterXY==0)System.Console.WriteLine("Точка лежит на границе четвертей");
else System.Console.WriteLine($"Точка с координатами {x} и {y} лежит в {quarterXY} четверти");