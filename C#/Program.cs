// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя)
// Например, -3 -> 9   4 -> 16

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int mul_number = number * number;
Console.WriteLine(mul_number);

// или Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($" Ваш результат {number * number}");