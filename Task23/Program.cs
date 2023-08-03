// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

bool ValidateNum(int num)
{
    if (num < 1)
    {
        Console.WriteLine("Вы ввели неккоректное число, пожалуйста повторите ввод");
        return false;
    }
    return true;
}

void CubeTable(int num)
{
    for (int i = 1; i <= num; i++)
    {
        int cube = i * i * i;
        Console.WriteLine($"{i,3} | {cube,5}");
    }
}

Console.WriteLine("Введите натуральное число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

if (ValidateNum(userNum))
{
    Console.WriteLine($"Таблица кубов чисел от 1 до {userNum}:");
    CubeTable(userNum);
}

