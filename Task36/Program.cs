// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int SumNumbersOfNotEvenPositionArray(int[] arr)
{
    int sumNumNotEvenPos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0) sumNumNotEvenPos += arr[i];
    }
    return sumNumNotEvenPos;
}

Console.WriteLine("Пожалуйста, укажите желаемое количество элементов массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
if(arrSize <= 0)
{
    Console.WriteLine("Невозможно построить массив с указанным количеством элементов.");
}
else
{
    int[] array = CreateArray(arrSize, -100, 100);
    PrintArray(array);
    Console.WriteLine();
    int sum = SumNumbersOfNotEvenPositionArray(array);
    Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях = {sum}");
}