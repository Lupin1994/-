// Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введи число: ");
int Num = int.Parse(Console.ReadLine() ?? "");
int digit_3 = 0;
if(Num<99)
{
    Console.WriteLine("In your number is not thrird digit");
}
if(Num<1000)
{
    digit_3 = Num%10;
    Console.WriteLine($"This is third digit {digit_3}");
}
else
{
    digit_3 = (Num%1000)/100;
    Console.WriteLine("This is third digit");
    Console.WriteLine(digit_3);
}
