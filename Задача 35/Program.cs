// Задача 35: Задайте одномерный массив из 123 случайных 
// чисел. Найдите количество элементов массива, значения 
// которых лежат в отрезке [10,99]. Пример для массива из 5,
//  а не 123 элементов. В своём решении сделайте для 
// 123 [5, 18, 123, 6, 2] -> 1     [1, 2, 3, 6, 2] -> 0 


int[] numbers = new int[5];
int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 10);
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();

for (int j = 0; j < numbers.Length / 2; j++)
{
    
}
Console.WriteLine($"Количество элементов {count}");

