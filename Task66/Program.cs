// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumRangeNumbers(int numM, int numN)
{
    if (numM == numN) return numM;
    else if (numM < numN) return numN + SumRangeNumbers(numM, numN - 1);
    else return numN + SumRangeNumbers(numM, numN + 1);
}

Console.WriteLine("Введите первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
if (numberM < 0) numberM = Math.Abs(numberM);
Console.WriteLine("Введите второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberN < 0) numberN = Math.Abs(numberN);

int amount = SumRangeNumbers(numberM, numberN);
Console.WriteLine($"Сумма чисел в промежутке от {numberM} до {numberN} равна {amount}");