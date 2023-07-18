// Задача 33: Задайте массив. Напишите программу, которая 
//  определяет, присутствует ли заданное число в массиве.4; 
//  массив [6, 7, 19, 345, 3] -> нет; 
//  массив [6, 7, 19, 345, 3] -> да


int[] numbers = new int[12];
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(-9, 10);
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();

string result = "Нет";
for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] == num)
    {
        result = "Да";
        break;
    }
}
Console.WriteLine(result);