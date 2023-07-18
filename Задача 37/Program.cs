// Задача 37: Найдите произведение пар чисел в одномерном 
// массиве. Парой считаем первый и последний элемент, второй и
//  предпоследний и т.д. Результат запишите в новом массиве.
//  [1 2 3 4 5] -> 5 8 3     [6 7 3 6] -> 36 21


int[] numbers = new int[7];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 10);
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < numbers.Length / 2; i++)
{
    Console.Write(numbers[i] * numbers[numbers.Length - 1 - i] + " ");
}
if (numbers.Length % 2 != 0)
{
    Console.Write(numbers[numbers.Length / 2] + " ");
}



// int[] numbers = {1,2,3,4,5};

// for(int i = 0 ; i < numbers.Length/2;i++){
// Console.Write(numbers[i] * numbers[numbers.Length - 1 - i]);
// }
// if(numbers.Length % 2 != 0){
// Console.WriteLine(numbers[numbers.Length/2]);
// }