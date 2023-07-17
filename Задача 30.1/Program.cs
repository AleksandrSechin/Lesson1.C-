// Есть график, где даны отрезок 1 (х1; x2) и отрезок 2 (х3, x4) 
// ​Необходимо составить код, который находит их пересечение. 
// Пересечением двух отрезка 1 и 2 могут быть - отрезок, точка
//  или ничего С клавиатуры вводим х1, x2, х3, x4 и выводим 
//  ответ - границы пересечений отрезков, общую точку или 
//  «не пересекаются»


int x1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int x3 = Convert.ToInt32(Console.ReadLine());
int x4 = Convert.ToInt32(Console.ReadLine());

if (x2 < x1)
{
    int temp = x1;
    x1 = x2;
    x2 = temp;
}
if (x4 < x3)
{
    int temp = x3;
    x3 = x4;
    x4 = temp;
}
int max = Math.Max(x1, x3);
int min = Math.Min(x2, x4);
if (x3 > x2 || x4 < x1)
{
    Console.WriteLine("Не пересекаются");
}
else if (x3 == x2)
{
    Console.WriteLine("Пересекаются в точке " + x3);
}
else if (x1 == x4)
{
    Console.WriteLine("Пересекаются в точке " + x1);
}
else
{
    Console.WriteLine("Пересекаются в диапозоне от " + max + " до " + min);
}