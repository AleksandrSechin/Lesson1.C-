// Напишите программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98


Console.WriteLine("Генерируем трехзначное число");

int number = new Random().Next(100, 1000);

Console.WriteLine(number);

int number1 = number % 10;
int number2 = number / 100;

Console.WriteLine($"Вывести первую и последнюю цифру числа {number2}{number1}");
