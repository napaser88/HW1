// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool ValidateDay(int userDay)
{
    if (userDay < 1 || userDay > 7)
    {
        Console.WriteLine("Введите число от 1 до 7, соответсвующее дню недели(1-понеделник...7-воскресенье)");
        return false;
    }
    return true;
}

void weekendDay(int userDay)
{
    if (userDay > 5)
    {
        Console.WriteLine("Ура! Наконец-то выходной!");
    }
    else
    {
        Console.WriteLine("Это не выходной...Пашем дальше...");
    }
}

Console.WriteLine("Всё просто, вы вводите целое число от 1 до 7, соответсвующее дню недели, а программа проверит является ли день выходным:");
int userDay = Convert.ToInt32(Console.ReadLine());
if (ValidateDay(userDay))
{
    weekendDay(userDay);
}

// Это второе (менее изящное) решение:
// if (userDay < 1 || userDay > 7)
// {
//     Console.WriteLine("Введите число от 1 до 7, соответсвующее дню недели(1-понеделник...7-воскресенье)");
// }
// else
// {
//     if (userDay == 1) Console.WriteLine("Это не выходной...Пашем дальше...");
//     if (userDay == 2) Console.WriteLine("Это не выходной...Пашем дальше...");
//     if (userDay == 3) Console.WriteLine("Это не выходной...Пашем дальше...");
//     if (userDay == 4) Console.WriteLine("Это не выходной...Пашем дальше...");
//     if (userDay == 5) Console.WriteLine("Это не выходной...Пашем дальше...");
//     if (userDay == 6) Console.WriteLine("Ура! Наконец-то выходной!");
//     if (userDay == 7) Console.WriteLine("Ура! Наконец-то выходной!");  
// }