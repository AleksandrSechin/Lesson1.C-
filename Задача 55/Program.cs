// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки
// на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя


int[,] nums = new int[3,3];

for(int i = 0; i < nums.GetLength(0); i++){
    for(int j = 0;j < nums.GetLength(1);j++){
        nums[i,j] = new Random().Next(0,10);
    }
}

for(int i = 0;i < nums.GetLength(0);i++){
    for(int j = 0;j < nums.GetLength(1);j++)
    {
        Console.Write(nums[i,j] + " ");
    }
    Console.WriteLine();
}

int[,] nums1 = new int[3,3];

for(int i = 0; i < nums.GetLength(1); i++)
{
    for(int j = 0; j < nums.GetLength(0); j++){

        nums1[i, j] = nums[j, i];
    }
}

Console.WriteLine();
for(int i = 0; i < nums1.GetLength(1); i++)
{
    for(int j = 0; j < nums1.GetLength(0); j++){
        Console.Write(nums1[i,j] + " ");
    }
    Console.WriteLine();
}

// Второй вариант 

int[,] nums = new int[4, 4];

for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        nums[i, j] = new Random().Next(0, 10);
    }
}

void Print(int[,] nums)
{
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            Console.Write(nums[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Change(int[,] nums)
{
    int temp;
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = i; j < nums.GetLength(1); j++)
        {
            temp = nums[i, j];
            nums[i, j] = nums[j, i];
            nums[j, i] = temp;
        }
    }
    return nums;
}

Print(nums);
Console.WriteLine();
if (nums.GetLength(0) == nums.GetLength(1))
{
    int[,] ChangeArray = Change(nums);
    Print(ChangeArray);
}
else
{
    Console.WriteLine("Поменять местами строки и столбцы невозможно");
}
