// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.

void Fill(int[] numbers)
{
    int n = numbers.Length;
    int i = 0;
    while (i < n)
    {
        numbers[i] = new Random().Next(1, 15);
        i++;
    }
}

void Print(int[] nums)
{
    int n = nums.Length;
    int i = 0;
    while (i < n)
    {
        Console.Write(nums[i] + " ");
        i++;
    }
    Console.WriteLine();
}

int[] Copy(int[] nums)
{
    int n = nums.Length;
    int i = 0;
    int[] newArray = new int[n];
    while (i < n)
    {
        newArray[i] = nums[i];
        i++;
    }
    return newArray;
}

int[] array = new int[10];

Fill(array);
Print(array);
int[] array1 = Copy(array);
Print(array1);