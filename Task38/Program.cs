// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArray(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }

    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        double roundNum = Math.Round(arr[i], 2);
        if (i < arr.Length - 1) Console.Write($"{roundNum}, ");
        else Console.Write($"{roundNum}");
    }
    Console.Write("]");
}

double MinNumOfArray(double[] arr)
{
    double minNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < minNumber) minNumber = arr[i];
    }
    return minNumber;
}

double MaxNumOfArray(double[] arr)
{
    double maxNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > maxNumber) maxNumber = arr[i];
    }
    return maxNumber;
}

double DifferenceMinMax(double minNumber, double maxNumber)
{
    double diffMaxMin = maxNumber - minNumber;
    double roundDiff = Math.Round(diffMaxMin, 2);
    return roundDiff;
}

Console.WriteLine("Пожалуйста, укажите желаемое количество элементов массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
if(arrSize <= 0)
{
    Console.WriteLine("Невозможно построить массив с указанным количеством элементов.");
}
else
{
    double[] array = CreateArray(arrSize, -100, 100);
    PrintArray(array);
    Console.WriteLine();
    double min = MinNumOfArray(array);
    double max = MaxNumOfArray(array);
    double diff = DifferenceMinMax(min, max);
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {diff}");
}