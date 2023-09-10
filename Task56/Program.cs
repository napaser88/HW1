// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] SmallerSumNumberInRow(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i, j];

        }
    }
    return sum;
}

void PrintSmallerRow(int[] array)
{
    int step = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[step]) step = i;
    }
    Console.WriteLine($"Строка массива с наименьшей суммой элементов -> {step + 1}");
}

int[,] array2d = CreateMatrixRndInt(5, 5, 1, 10);
Console.WriteLine($"Двумерный массив размером {5}x{5} ->");
PrintMatrix(array2d);
int[] sumArr = SmallerSumNumberInRow(array2d);
PrintSmallerRow(sumArr);