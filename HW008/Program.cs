//Удалить вторую цифру трёхзначного числа
int rn = new Random().Next(100, 1000);
Console.WriteLine("Рандомное число: " + rn);

string srn = rn.ToString();
char i = srn[srn.Length - 2];
Console.WriteLine("а это оно же, но без средней цифры: " + srn[srn.Length - 3] + srn[srn.Length - 1]);