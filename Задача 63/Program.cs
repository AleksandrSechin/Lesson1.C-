// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные
// числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
string Numbers(int a, int n)
{
    if (a <= n)
    {
        return $"{a} " + Numbers(a + 1, n);
    }
    else
        return String.Empty;
}
Console.WriteLine(Numbers(a, n));
