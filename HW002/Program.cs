//По заданному номеру дня недели вывести его название
Console.Write("Введите номер дня недели:");
int num_day = int.Parse(Console.ReadLine() ?? "0");

switch (num_day)
{
    case 1:
        Console.Write("Понедельник");
    break;

    case 2:
        Console.Write("Вторник");
    break;

    case 3:
        Console.Write("Среда");
    break;

    case 4:
        Console.Write("Четверг");
    break;

    case 5:
        Console.Write("Пятница");
    break;

    case 6:
        Console.Write("Суббота");
    break;

    case 7:
        Console.Write("Воскресение");
    break;

    default: 
        Console.Write("некоректный номер дня недели!!!!");
    break;
}