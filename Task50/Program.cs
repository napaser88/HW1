// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

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

int? FindNumInMatrix(int[,] matrix, int row, int column)
{
    if (row > matrix.GetLength(0) && column > matrix.GetLength(1))
    {
        return null;
    }
    else
    {
        int result = matrix[row - 1, column - 1];
        return result;
    }
}

Console.WriteLine("Пожалуйста, введите нужную строку: ");
int userRow = Convert.ToInt32(Console.ReadLine());
if (userRow < 0) userRow = Math.Abs(userRow);
Console.WriteLine("Пожалуйста, введите нужную колонну: ");
int userColumn = Convert.ToInt32(Console.ReadLine());
if (userColumn < 0) userColumn = Math.Abs(userColumn);

int[,] array2d = CreateMatrixRndInt(10, 10, -10, 10);
int? numInArr = FindNumInMatrix(array2d, userRow, userColumn);

Console.WriteLine("Двумерный массив ->");
PrintMatrix(array2d);

if (numInArr == null)
{
    Console.WriteLine($"Число на позициях {userRow}x{userColumn} отсутствует в массиве");
}
else
{
    Console.WriteLine($"Число на позициях {userRow}x{userColumn} -> {numInArr}");
}