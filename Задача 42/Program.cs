// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.45 -> 1011013 -> 112 -> 10

Console.WriteLine("Введите десятичное число: ");
int number = Int32.Parse(Console.ReadLine());
int numberBefore = number;
string result = String.Empty;

while (number > 0)
{
    result = Convert.ToString(number % 2) + result;
    number /= 2;
}
Console.WriteLine($"Число {numberBefore} в двоичной системе {result}");