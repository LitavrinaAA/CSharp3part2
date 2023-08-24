// по заданной четверти вывести диапозон допустимых значений

int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void NumbersInQ(int q1234){
    if (q1234 == 1)
         System.Console.Write("x > 0, y > 0");
    else if (q1234 == 2)
         System.Console.Write("x < 0, y > 0"); 
    else if (q1234 == 3)
        System.Console.Write("x < 0, y < 0"); 
    else if (q1234 == 4)
        System.Console.Write("x > 0, y < 0"); 
    else   
        System.Console.Write ("Введено не корректное значение.");
}

NumbersInQ(InputNum("Введите номер четверти: "));
