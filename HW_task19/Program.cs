Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);

if (number >= 10000 && number < 100000 && stringNumber[0] == stringNumber[4] && stringNumber[1] == stringNumber[3])
{
    Console.Write("Число палиндром");
}
else if (number >= 10000 && number < 100000 && stringNumber[0] != stringNumber[4] && stringNumber[1] != stringNumber[3])
{
    Console.Write("Число не является палиндромом");
}
else
{
    Console.Write("Ошибка ввода");
}