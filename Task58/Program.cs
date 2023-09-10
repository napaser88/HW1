// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication(int[,] matr1, int[,] matr2)
{
    int multi = 0;
    int[,] arr = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int d = 0; d < arr.GetLength(1); d++)
            {
                multi += matr1[i, d] * matr2[d, j];
            }
            arr[i, j] = multi;
        }
    }
    return arr;
}

int[,] matrix1 = CreateMatrixRndInt(2, 2, 1, 10);
Console.WriteLine("Первая матрица ->");
PrintMatrix(matrix1);
int[,] matrix2 = CreateMatrixRndInt(2, 2, 1, 10);
Console.WriteLine("Вторая матрица ->");
PrintMatrix(matrix2);
int[,] multiMatrix = MatrixMultiplication(matrix1, matrix2);
Console.WriteLine("Произведение матриц ->");
PrintMatrix(multiMatrix);
