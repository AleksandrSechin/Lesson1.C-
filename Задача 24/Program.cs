// Напишите программу, которая принимает на вход число А и 
// выдает сумму чисел от 1 до А


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = 1; i <= number; i++)
{
    result += i;  // тоже самое что result = result + 1;
}
Console.WriteLine($"Сумма равна: {result} ");