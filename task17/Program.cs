Console.Write("Введите координату X: ");
int X = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if(X > 0 && Y > 0)
{
    Console.WriteLine("Точка находится в первой четверти");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Точка находится во второй четверти");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Точка находится в третьей четверти");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Точка находится в четвертой четверти");
}
else
{
    Console.WriteLine("Начало оси координат");
}