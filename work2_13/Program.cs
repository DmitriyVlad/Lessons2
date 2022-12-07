// Задача 13

Console.WriteLine("Введите любое число...");
string str = Console.ReadLine();
int n = str.Length;
if(n < 3)
{
    Console.WriteLine("В числе меньше трех цифр!");
}
else
{
Console.WriteLine("Третья цифра - " + str[2]);
}
