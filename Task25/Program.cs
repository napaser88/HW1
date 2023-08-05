// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int NumberDegree(int a, int b){
    int deg = 1;
    for(int i = 1; i <= b; i++){
        deg = a * deg;
    }
    return deg;
}

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int degree = NumberDegree(num1, num2);
Console.WriteLine($"Число {num1} в степени {num2} равно {degree}");
