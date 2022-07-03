Console.WriteLine("Write first number: ");
int F_num = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Write second number: ");
int S_num = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Write third number: ");
int T_num = int.Parse(Console.ReadLine() ?? "");
int max = F_num;
if (max < S_num)
{
    max = S_num;
}
if (max < T_num)
{
    max = T_num;
}
Console.WriteLine($"max = {max}");

