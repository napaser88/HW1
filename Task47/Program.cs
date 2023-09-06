// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndDbl(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(matrix[i, j], 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}  ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Пожалуйста, укажите количество строк массива: ");
int userString = Convert.ToInt32(Console.ReadLine());
if (userString <= 0) Console.WriteLine("Недопустимое количество строк массива");
Console.WriteLine("Пожалуйста, укажите количество колонн массива: ");
int userColumn = Convert.ToInt32(Console.ReadLine());
if (userColumn <= 0) Console.WriteLine("Недопустимое количество колонн массива");

Console.WriteLine($"Двумерный массив размером {userString}x{userColumn} ->");
double[,] array2d = CreateMatrixRndDbl(userString, userColumn, -100, 100);
PrintMatrix(array2d);
Console.WriteLine();