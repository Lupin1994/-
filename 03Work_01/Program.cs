// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.
Console.WriteLine("Write your number:");
int number = int.Parse(Console.ReadLine()??"");
int Palindrom = number;
int rev = 0;
int i = 0;
int dig = 0;
while (i < 5)
{
    dig = number % 10;
    rev = rev * 10 + dig;
    i++;
    number = number / 10;
}
Console.WriteLine(rev);
if (rev == Palindrom)
{
    Console.WriteLine("Your number is Palindrom:");
}
else
{
    Console.WriteLine("Your number is not Palindrom:");
}
