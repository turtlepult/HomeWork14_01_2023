
//Показать последнюю цифру трёхзначного числа
int random_number = new Random().Next(100, 1000);
Console.WriteLine("Рандомное число: " + random_number);

string strrandom_number = random_number.ToString();
char i = strrandom_number[strrandom_number.Length - 1];
Console.WriteLine("И его последняя цифра: " + i);