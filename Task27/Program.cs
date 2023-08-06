// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigits(int num)
{
    int sum = 0;
    while(num != 0)
    {
        sum += num % 10;
        num = num / 10;   
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
int summary = SumOfDigits(userNum);
Console.WriteLine($"Сумма цифр в числе {userNum} равна {summary}");