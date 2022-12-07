// Задача 10

int n = new Random().Next(100,999);
int s = (n % 100) / 10;
Console.WriteLine("Дано число: " + n);
Console.WriteLine("Вторая цифра - " + s);