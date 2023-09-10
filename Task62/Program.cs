// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateLoopMatrix(int a, int b)
{
    int count = 1;
    int[,] arr = new int[a, b];
    int round = 0;
    while (true)
    {
        for (int i = 0 + round; i < arr.GetLength(1) - 1 - round; i++)
        {
            arr[0 + round, i] = count;
            count += 1;
            if (count > a * b) return arr;
        }
        for (int j = 0 + round; j < arr.GetLength(0) - 1 - round; j++)
        {
            arr[j, b - 1 - round] = count;
            count += 1;
            if (count > a * b) return arr;
        }
        for (int i = arr.GetLength(1) - 1 - round; i > 0 + round; i--)
        {
            arr[arr.GetLength(1) - 1 - round, i] = count;
            count += 1;
            if (count > a * b) return arr;
        }
        for (int j = arr.GetLength(0) - 1 - round; j > 0 + round; j--)
        {
            arr[j, 0 + round] = count;
            count += 1;
            if (count > a * b) return arr;
        }
        round += 1;
    }
    return arr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],2}  ");
        }
        Console.WriteLine();
    }
}

int[,] loopArr = CreateLoopMatrix(4, 4);
PrintMatrix(loopArr);