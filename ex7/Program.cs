//расстояние между двумя точки
// a = xA - xB
// b = yA - xB
// a^2 + b^2 = c^2 Math.Pow(value, degree) 
// квадратный корень Math.Sqrt(value)
// c = квадратный корень((xA-xB)^2 + (yA - yB)^2)

int[] InputNum(String mess)
{
    System.Console.Write(mess);
    int[] intArray = new int[2];
    System.Console.Write("x:");
    intArray[0] = int.Parse(Console.ReadLine()!);
    System.Console.Write("y:");
    intArray[1] = int.Parse(Console.ReadLine()!);
    return intArray;
}
double PointDist(int[] pA, int[] pB ){
    return Math.Sqrt(Math.Pow((pA[0] - pB[0]), 2) + Math.Pow((pA[1] - pB[1]), 2)); 
}

int[] pointA = InputNum("Введите кординаты для точки A: ");
int[] pointB = InputNum("Введите кординаты для точки B: ");

double distAB = PointDist(pointA, pointB);
System.Console.WriteLine($" Расстояние между точками А и В = {Math.Round(distAB,3)}" );
