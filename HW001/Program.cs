﻿//По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите первое число: ");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine());

if ((n2*n2) == n1)
{
     Console.WriteLine("Число: " + n1 + " является квадратом числа: " + n2);
}
else
{
    Console.WriteLine("Число: " + n1 + " НЕ является квадратом числа: " + n2);
}