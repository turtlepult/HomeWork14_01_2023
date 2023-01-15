//Выяснить является ли число чётным
Console.Write("Введите число, для проверки его на четность: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.Write("Число является четным!");
}
else
{
    Console.Write("Число является нечетным!");
}