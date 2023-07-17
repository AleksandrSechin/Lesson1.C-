// Задача 28: Напишите программу, которая принимает на вход
//  число N и выдаёт произведение чисел от 1 до N
//  4 -> 24

Console.Write("Введите число: ");
long number = Convert.ToInt64(Console.ReadLine()); // long и 64 тип данных
int result = 1;
for (int i = 1; i <= number; i++)
{
    result *= i; 
}
Console.WriteLine($"Произведение равно: {result}");