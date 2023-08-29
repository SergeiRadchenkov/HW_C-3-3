/* Напишите программу, которая принимает 
на вход координаты двух точек и находит расстояние 
между ними в 3D пространстве.
A (3,6,8), B(2,1,-7) -> 15.84
A (7,-5,0), B(1,-1,9) -> 11.53 */

int[] GetCoor (string message)
{
    int[] coordinates = new int[3];
    Console.Write(message + "X:");
    coordinates[0] = int.Parse(Console.ReadLine()!);
    Console.Write(message + "Y:");
    coordinates[1] = int.Parse(Console.ReadLine()!);
    Console.Write(message + "Z:");
    coordinates[1] = int.Parse(Console.ReadLine()!);
    
    return coordinates;
}

double Distance(int[] pointA, int[] pointB)
{
    int deltaX = pointA[0] - pointB[0];
    int deltaY = pointA[1] - pointB[1];
    int deltaZ = pointA[2] - pointB[2];
    double dist = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2));
    return dist;
}

int[] pointA = GetCoor("Введите для точки А координату ");
int[] pointB = GetCoor("Введите для точки B координату ");
double result = Distance(pointA, pointB);
result = Math.Round(result, 2);
Console.WriteLine(result);