// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное целое число:");
int userNumber = Convert.ToInt32(Console.ReadLine());
int secondDigit = userNumber / 10 % 10;
if (userNumber < 99 || userNumber > 999)
{
    Console.WriteLine("Вы ввели число, не соответствующее запросу. Введите целое трехзначное число(три цифры, без запятых)");
}
else
{
    Console.WriteLine($"Вторая цифра введенного числа -> {secondDigit}");
}