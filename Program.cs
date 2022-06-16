// Определение четверти координатной плоскости  по X и Y.

Console.WriteLine("Введите X:");
int X = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y:");
int Y = int.Parse(Console.ReadLine());

Console.WriteLine($"Координаты X:{X}, Y:{Y}");

if (X > 0 && Y > 0)
{
    Console.WriteLine(1);
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine(2);
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine(3);
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine(4);
}
else{
    Console.WriteLine("Координаты не принадлежат четверти!");
}