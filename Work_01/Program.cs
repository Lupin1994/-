Console.WriteLine("Write first number: ");
int F_num = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Write second number: ");
int S_num = int.Parse(Console.ReadLine() ?? "");
if (F_num > S_num)
{
    Console.WriteLine($"max = {F_num} , min = {S_num}");
}
else
    Console.WriteLine($"max = {S_num} , min = {F_num}");