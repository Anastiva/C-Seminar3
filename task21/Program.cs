Console.WriteLine("Введите координату X 1-ой точки:");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y 1-ой точки:");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату X 2-ой точки:");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y 2-ой точки:");
double Y2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
Console.WriteLine("Расстояние между точками равно " + Math.Round(distance, 3));
