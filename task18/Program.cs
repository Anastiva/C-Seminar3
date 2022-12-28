Console.Write("Введите номер четверти: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number == 1)
{
    Console.WriteLine("Возможные координаты точки - (x > 0); (y > 0)");
}
else if (Number == 2)
{
    Console.WriteLine("Возможные координаты точки - (x < 0); (y > 0)");
}
else if (Number == 3)
{
    Console.WriteLine("Возможные координаты точки - (x < 0); (y < 0)");
}
else if (Number == 4)
{
    Console.WriteLine("Возможные координаты точки - (x > 0); (y < 0)");
}
else
{
   Console.WriteLine("Ошибка");
}