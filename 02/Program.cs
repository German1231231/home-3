Console.Write("Введите первую координату точки A(x1): ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую координату точки A(y1): ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую координату точки A(z1): ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую координату точки B(x2): ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую координату точки B(y2): ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую координату точки B(z2): ");
int z2 = Convert.ToInt32(Console.ReadLine());

int x = x2 - x1;
int y = y2 - y1;
int z = z2 - z1;

double sum = Math.Sqrt((x * x) + (y * y) + (z * z));
double result = Math.Round(sum, 2);
Console.WriteLine(result);