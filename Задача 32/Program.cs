// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные,
//  и наоборот.[-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] numbers = new int[12];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(-9, 10);
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();

for (int j = 0; j < numbers.Length; j++)
{
    numbers[j] = numbers[j] * -1;
    Console.Write(numbers[j] + " ");
}