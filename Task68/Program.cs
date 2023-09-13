// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckFunc(int numN, int numM)
{
    if (numN == 0) return numM + 1;
    else if (numM == 0) return AckFunc(numN - 1, 1);
    else return AckFunc(numN - 1, AckFunc(numN, numM - 1));
}

Console.WriteLine("Введите первое натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberN < 0) numberN = Math.Abs(numberN);
Console.WriteLine("Введите второе натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
if (numberM < 0) numberM = Math.Abs(numberM);

int result = AckFunc(numberN, numberM);
Console.WriteLine($"Результат вычисления функции Аккермана -> {result}");