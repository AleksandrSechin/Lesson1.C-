// Напишите программу, которая принимает на вход координаты
//  двух точек и находит расстояние между ними в 2D пространстве.
//  A (3,6); B (2,1) -> 5,09    A (7,-5); B (1,-1) -> 7,21

Console.Clear();

Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine(result); 
// или Console.WriteLine($"{Math.Round(result, 1)}");
// чтобы округлить к ближайшему целому числу