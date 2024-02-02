// Урок 2. Простые Алгоритмы
// Задача 1: Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 7 == 0 && num % 23 == 0)
// {
// Console.WriteLine("Да");
// }
// else
// {
// Console.WriteLine("Нет");
// }



// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

// System.Console.WriteLine("Введите координаты точки X и Y через пробел:");
// string[] coordinates = Console.ReadLine().Split(' ');
// int x = Convert.ToInt32(coordinates[0]);
// int y = Convert.ToInt32(coordinates[1]);
// if (x > 0 && y > 0)
// System.Console.WriteLine("1");
// else if (x < 0 && y > 0)
// System.Console.WriteLine("2");
// else if (x < 0 && y < 0)
// System.Console.WriteLine("3");
// else if (x > 0 && y < 0)
// System.Console.WriteLine("4");
// else
// System.Console.WriteLine("Точка находится на оси координат");



// Задача 3: Напишите программу, которая принимает 
// на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int firstNum = num / 10;
// int secondNum = num % 10;
// int maxNum = firstNum > secondNum ? firstNum : secondNum;
// System.Console.WriteLine(maxNum);



// Задача 4: Напишите программу, которая на вход принимает 
// натуральное число N, а на выходе показывает его цифры через запятую.

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
{
Console.WriteLine(N);
}
else
{
while (N > 0)
{
int currentDigit = N % 10;
N /= 10;
if (N > 0)
{
Console.Write(currentDigit + ",");
}
else
{
Console.WriteLine(currentDigit);
}
}
}