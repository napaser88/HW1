// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] AverageOfArray(int[,] matrix)
{
    {
        double sum = 0;
        double[] array = new double[matrix.GetLength(1)];

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, j];
            }
            array[j] = sum / matrix.GetLength(0);
            sum = 0;
        }
        return array;
    }
}

void PrintAverageOfArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double roundNum = Math.Round(arr[i], 2);
        Console.WriteLine($"Среднее арифметическое {i + 1} столбца массива -> {roundNum}");
    }
}

Console.WriteLine("Пожалуйста, укажите количество строк массива: ");
int userRow = Convert.ToInt32(Console.ReadLine());
if (userRow <= 0) Console.WriteLine("Недопустимое количество строк массива");
Console.WriteLine("Пожалуйста, укажите количество колонн массива: ");
int userColumn = Convert.ToInt32(Console.ReadLine());
if (userColumn <= 0) Console.WriteLine("Недопустимое количество колонн массива");

int[,] array2d = CreateMatrixRndInt(userRow, userColumn, 1, 10);
Console.WriteLine($"Двумерный мвссив размером {userRow}x{userColumn} ->");
PrintMatrix(array2d);

double[] avrg = AverageOfArray(array2d);
PrintAverageOfArray(avrg);

