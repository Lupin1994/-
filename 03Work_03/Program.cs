﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Write N:");
int N = int.Parse(Console.ReadLine()??"");
for (int i = 1; i <= N; i++)
{
    Console.WriteLine("------------------------------------");
    Console.WriteLine($"| Число = {i} | Куб числа = {i * i * i} |");
}