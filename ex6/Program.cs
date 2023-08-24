//расстояние между двумя точки
// a = xA - xB
// b = yA - xB
// a^2 + b^2 = c^2 Math.Pow(value, degree) 
// квадратный корень Math.Sqrt(value)
// c = квадратный корень((xA-xB)^2 + (yA - yB)^2)

int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
double PointDist(int xA, int yA, int xB, int yB ){
    return Math.Sqrt(Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2)); 
}

int xA = InputNum("Введите кординаты x для точки A: ");
int yA = InputNum("Введите кординаты y для точки A: ");
int xB = InputNum("Введите кординаты x для точки B: ");
int yB = InputNum("Введите кординаты y для точки B: ");
double distAB = PointDist(xA, yA, xB, yB);
System.Console.WriteLine($" Расстояние между точками А и В = {distAB}" );
