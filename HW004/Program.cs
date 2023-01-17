// Показать четные числа от 1 до N
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ??"0");

for (int i = - num; i <= num; i++)
{
    if (i%2==0)
    {
        Console.WriteLine(i);
    }
}