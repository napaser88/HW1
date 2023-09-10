// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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

void DescendRowInArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int d = 0; d < matrix.GetLength(1) - j - 1; d++)
            {
                if (matrix[i, d] < matrix[i, d + 1])
                {
                    (matrix[i, d], matrix[i, d + 1]) = (matrix[i, d + 1], matrix[i, d]);
                }
            }
        }
    }
}

Console.WriteLine("Пожалуйста, укажите количество строк массива: ");
int userRow = Convert.ToInt32(Console.ReadLine());
if (userRow <= 0) Console.WriteLine("Недопустимое количество строк массива");
Console.WriteLine("Пожалуйста, укажите количество колонн массива: ");
int userColumn = Convert.ToInt32(Console.ReadLine());
if (userColumn <= 0) Console.WriteLine("Недопустимое количество колонн массива");

int[,] array2d = CreateMatrixRndInt(userRow, userColumn, 1, 10);
Console.WriteLine($"Двумерный массив размером {userRow}x{userColumn} ->");
PrintMatrix(array2d);
Console.WriteLine($"Двумерный массив размером {userRow}x{userColumn} с упорядоченными по убыванию строками ->");
DescendRowInArray(array2d);
PrintMatrix(array2d);
