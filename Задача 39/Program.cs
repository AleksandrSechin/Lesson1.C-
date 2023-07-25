// Задача 39: Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет на первом месте,
//  а первый - на последнем и т.д.)[1 2 3 4 5] -> [5 4 3 2 1]


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
}

void Return(int[] nums)
{
    int temp = 0;
    int n = nums.Length;
    for (int i = 0; i < n / 2; i++)
    {
        temp = nums[i];
        nums[i] = nums[n - 1 - i];
        nums[n - 1 - i] = temp;
    }
}

int[] array = new int[11];

Fill(array);
Print(array);
Console.WriteLine();
Return(array);
Print(array);