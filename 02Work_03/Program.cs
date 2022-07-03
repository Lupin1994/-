// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введи номер дня недели: ");
int Day = int.Parse(Console.ReadLine() ?? "");
if (Day > 0 && Day < 6)
{
    Console.WriteLine("Это рабочий день");
}
else
{
    Console.WriteLine("Это выходной день");
}