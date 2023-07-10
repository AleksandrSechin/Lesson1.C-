// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N
// Например, 3 -> -3 -2 -1 0 1 2 3 
//          -2 -> -2 -1 0 1 2 

Console.WriteLine("Введите одно число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 0){
    number = number * -1;
}
for(int x = -number; x <= number; x++){
    Console.Write(x + " ");
}