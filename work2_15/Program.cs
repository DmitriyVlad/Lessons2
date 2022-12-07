// Задача 15

int day = new Random().Next(1,7);
if(day < 6)
{
    Console.WriteLine(day + " - это рабочий день");
}
else
{
    Console.WriteLine(day + " - это выходной!!!");
}
