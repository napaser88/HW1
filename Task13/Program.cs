// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

bool userNumberValidate(int userNumber)
{
    if (userNumber < 100)
    {
        Console.WriteLine("У введенного числа третьей цифры нет.");
        return false;
    }
    return true;
}

int thirdDigit(int userNumber)
{
    while (userNumber > 999)
    {
        userNumber /= 10;
    }
    return userNumber % 10;
}

Console.WriteLine("Введите целое число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumberValidate(userNumber))
{
    Console.WriteLine($"Третья цифра введенного числа -> {thirdDigit(userNumber)}");
}