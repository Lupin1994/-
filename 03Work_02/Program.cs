// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
double dis_AB = 0;

Console.WriteLine("Write coordinete (.) A:");
Console.WriteLine("Write x = ");
int x_A = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Write y = ");
int y_A = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Write z = ");
int z_A = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"(.) A = ({x_A} , {y_A} , {z_A})");

Console.WriteLine("Write coordinete (.) B:");
Console.WriteLine("Write x = ");
int x_B = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Write y = ");
int y_B = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Write z = ");
int z_B = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"(.) B = ({x_B} , {y_B} , {z_B})");

Console.WriteLine("Calculate the distance between (.) A and (.) B");
dis_AB = Convert.ToInt32(Math.Sqrt((x_B - x_A) + (y_B - y_A) + (z_B - z_A)));
Console.WriteLine($"AB = {dis_AB}");