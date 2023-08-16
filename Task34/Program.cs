﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int AmountEvenNum(int[] arr)
{
    int amountEvenNumbers = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            amountEvenNumbers++;
        }
    }
    return amountEvenNumbers;
}

Console.WriteLine("Пожалуйста, укажите желаемое количество элементов массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
if(arrSize <= 0)
{
    Console.WriteLine("Невозможно построить массив с указанным количеством элементов.");
}
else
{
    int[] array = CreateArray(arrSize, 100, 999);
    PrintArray(array);
    Console.WriteLine();
    int amount = AmountEvenNum(array);
    Console.WriteLine($"Количество чётных чисел в массиве = {amount}");
}
