// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать
//  сумму его цифр.453 -> 1245 -> 9

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Sum(int num)
{
    if (num == 0) return 0;
    return num % 10 + Sum(num / 10);
}
int number = Sum(num);
Console.WriteLine(number);
