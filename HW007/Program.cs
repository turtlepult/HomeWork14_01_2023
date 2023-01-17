using System.Security.Cryptography.X509Certificates;
//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int rn = new Random().Next(10,99);
Console.WriteLine("Рандомное число: " + rn);
int max = 0;
int r = rn%10;
int x = rn/10;
if (r>=max)
{
    max = r;
     if (x>max)
     {
        max = x;
     }
}
Console.WriteLine("И его наибольшая цифра: " + max);