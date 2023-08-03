// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double DistanceThreePoints(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int cat1 = x1 - x2;
    int cat2 = y1 - y2;
    int cat3 = z1 - z2;
    double result = Math.Sqrt(cat1 * cat1 + cat2 * cat2 + cat3 * cat3);
    return result;
}

Console.WriteLine("Введите координаты первой точки A:");
Console.Write("X: ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки B:");
Console.Write("X: ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z2Coordinate = Convert.ToInt32(Console.ReadLine());

double result = DistanceThreePoints(x1Coordinate, y1Coordinate, z1Coordinate, x2Coordinate, y2Coordinate, z2Coordinate);
double disResult = Math.Round(result, 2);
Console.WriteLine($"Расстояние между точками A и В равно: {disResult}");

