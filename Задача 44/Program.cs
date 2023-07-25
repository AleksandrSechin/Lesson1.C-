// Задача 44: Не используя рекурсию, выведите первые N чисел
//  Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//  Если N = 5 -> 0 1 1 2 3    Если N = 3 -> 0 1 1
//  Если N = 7 -> 0 1 1 2 3 5 8 

int[] Fill(int number)
{
    int[] num = new int[number];
    num[1] = 1;
    num[0] = 0;
    for (int i = 2; i < num.Length; i++)
    {
        num[i] = num[i - 1] + num[i - 2];
    }
    return num;
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

int[] numbers = Fill(15);
Print(numbers);