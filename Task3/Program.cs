// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
 int start = 1;
 int end = Convert.ToInt32(Console.ReadLine());

if (end >= 1)
{
    for (int i = 1; i <= end; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}
else if (end <= -1)
{
    for (int i = -1; i >= end; i--)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}
else
{
    Console.WriteLine("Введенное число равно нулю.");
}