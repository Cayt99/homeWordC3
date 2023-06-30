// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки A по оси X: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки A по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки A по оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки B по оси X: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки B по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки B по оси Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

if (x1 == 0 && y1 == 0 && z1 == 0 && x2 == 0 && y2 == 0 && z2 == 0)
{
    Console.WriteLine("Ошибка: все координаты равны нулю. Невозможно вычислить расстояние.");
}
else
{
    double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
    Console.WriteLine($"Расстояние: {d}");
}
