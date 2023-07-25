// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их
//  квадраты. Например: 
//  1 4 7 2     1  4 7 2
//  5 9 2 3  => 5 81 2 9
//  8 4 2 4     8  4 2 4

int[,] nums = new int[3, 4];

for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        nums[i, j] = new Random().Next(0, 10);
    }
}

for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}


for (int i = 0; i < nums.GetLength(0); i += 2)
{
    for (int j = 0; j < nums.GetLength(1); j += 2)

        nums[i, j] *= nums[i, j];
}

Console.WriteLine();

for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}