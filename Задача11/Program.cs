// Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа. 
// Например:78 -> 8  12-> 2  85 -> 8

Console.WriteLine("Генерируем двухзначное число");

int number = new Random().Next(10, 99);

Console.WriteLine(number);

int number1 = number % 10;
int number2 = number /= 10;

if (number1 > number2)
{
    Console.WriteLine($"Наибольшая цифра {number1}");
}
else Console.WriteLine($"Наибольшая цифра {number2}");