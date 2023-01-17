//Выяснить, кратно ли число заданному, если нет, вывести остаток.
int rn1 = new Random().Next(100, 1000);
Console.WriteLine("Рандомное число1: " + rn1);

int rn2 = new Random().Next(1, 10);
Console.WriteLine("Рандомное число2: " + rn2);

if (rn1%rn2==0)
{
    Console.WriteLine("число " + rn1 + " кратно числу " + rn2);
}
else
{
    Console.WriteLine("Число " + rn1 + " не кратно числу " + rn2 + " ,остаток от деления: " + rn1 % rn2);
}