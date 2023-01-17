//Показать вторую цифру трёхзначного числа
int random_number = new Random().Next(100, 1000);
Console.WriteLine("Рандомное число: " + random_number);

string strrandom_number = random_number.ToString();
char i = strrandom_number[strrandom_number.Length - 2];
Console.WriteLine("И его средняя цифра: " + i);