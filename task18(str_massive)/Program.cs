string[] quaters = {"x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0" , "x > 0, y < 0"};
Console.Write("Введите цифру плоскости координат: ");
int quater = Convert.ToInt32(Console.ReadLine());

if(quater >= 1 && quater <= 4)
{
Console.WriteLine(quaters[quater - 1]);
}
else
{
    Console.WriteLine("Неверный ввод");
}
