// На вход принимает два числа и проверяет является ли первое число квадратом второго
// a = 25 b = 5 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if(number2 * number2 == number1){
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
} 