// Напишите программу, которая принимает на вход координаты
// точки (X и Y), где Х и Y не равны 0 и выдает номер слоскости
// в которой находится эта точка


Console.Write("Введите Х: ");
int numberX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int numberY = Convert.ToInt32(Console.ReadLine());

if (numberX == 0) Console.Write("X = 0 ");
if (numberY == 0) Console.Write("Y = 0 ");

if (numberX > 0 && numberY > 0)
{
    Console.Write("I четверть ");
}
else if (numberX < 0 && numberY > 0)
{
    Console.Write("II четверть ");
}
else if (numberX < 0 && numberY < 0)
{
    Console.Write("III четверть ");
}
else if (numberX > 0 && numberY < 0)
{
    Console.Write("IV четверть ");
}