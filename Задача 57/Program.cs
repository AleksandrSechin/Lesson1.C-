// Задача 57. Составить частотный словарь элементов двумерного массива. Частотный словарь
// содержит информацию о том, сколько раз встречается элемент входных данных


int[,] nums = new int[3, 3];

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
Console.WriteLine();

int count = 0;
for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        for (int x = 0; x < nums.GetLength(0); x++)
        {
            for (int y = 0; y < nums.GetLength(1); y++)
            {
                if (nums[i, j] == nums[x, y])
                {
                    count++;
                }
            }
        }
        Console.WriteLine(nums[i, j] + " - " + count);
        count = 0;
    }
}


// Второй вариант без дублирования на выходе

int[,] nums = new int[3, 3];

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
Console.WriteLine();

int[] numbers = new int[10];

for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        numbers[nums[i, j]] += 1;
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{i} - {numbers[i]}");
    Console.WriteLine();
}
