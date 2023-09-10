// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

int GenerateUniqueNumber()//Эту функкцию почерпнул со StackOverflow
{
    HashSet<int> numbers = new HashSet<int>();
    Random r = new Random();
    while (true)
    {
        var n = r.Next(10, 100);
        if (!numbers.Contains(n))
        {
            numbers.Add(n);
            return n;
        }
    }
}

int[,,] CreateRandomArray3D(int rows, int columns, int pages)
{
    int[,,] arr = new int[rows, columns, pages];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = GenerateUniqueNumber();
            }
        }
    }
    return arr;
}

void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k],5} ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Пожалуйста, укажите количество строк массива: ");
int userRow = Convert.ToInt32(Console.ReadLine());
if (userRow <= 0) Console.WriteLine("Недопустимое количество строк массива");
Console.WriteLine("Пожалуйста, укажите количество колонн массива: ");
int userColumn = Convert.ToInt32(Console.ReadLine());
if (userColumn <= 0) Console.WriteLine("Недопустимое количество колонн массива");
Console.WriteLine("Пожалуйста, укажите количество страниц массива: ");
int userPage = Convert.ToInt32(Console.ReadLine());
if (userPage <= 0) Console.WriteLine("Недопустимое количество страниц массива");
int[,,] array3d = CreateRandomArray3D(userRow, userColumn, userPage);
Console.WriteLine($"Трехмерный массив размером {userRow}x{userColumn}x{userPage} ->");
PrintArray3D(array3d);
