// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool ValidateNum(int num)
{
    if (num < 10000 || num > 99999)
    {
        Console.WriteLine("Вы ввели неккоректное число, пожалуйста повторите ввод.");
        return false;
    }
    return true;
}

bool PalindromeCompare(int num)
{
    int firstDigit = num / 10000;
    int secondDigit = num / 1000 % 10;
    int fourthDigit = num / 10 % 10;
    int fifthDigit = num % 10;
    if (firstDigit == fifthDigit && secondDigit == fourthDigit)
    {
        Console.WriteLine($"Число {num} является палиндромом.");
        return true;
    }
    Console.WriteLine($"Число {num} не является палиндромом.");
    return false;
}

Console.WriteLine("Введите пятизначное число:");
int userNum = Convert.ToInt32(Console.ReadLine());

if (ValidateNum(userNum))
{
    PalindromeCompare(userNum);
}
