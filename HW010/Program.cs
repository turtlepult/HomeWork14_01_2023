//Найти третью цифру числа или сообщить, что её нет
int rn = new Random().Next(98, 102);
Console.WriteLine("Рандомное число: " + rn);

string srn = rn.ToString();
int length = srn.Length;

if (length<3)
{
    Console.WriteLine("В числе " + rn + " нет третей цифры");
}
else
{
    char i = srn[srn.Length - 1];
    Console.WriteLine("И его третья цифра: " + i);
}