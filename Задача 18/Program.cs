// Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти
//   (x и y)


Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("X > 0, Y > 0");
}
else if (number == 2)
{
    Console.Write("X > 0, Y < 0");
}
else if (number == 3)
{
    Console.Write("X < 0, Y < 0");
}
else if (number == 4)
{
    Console.Write("X < 0, Y > 0");
}
else
{
    Console.Write("Такой четверти нет");
}
