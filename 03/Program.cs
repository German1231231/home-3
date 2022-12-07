Console.Write("Введите число от 1 до 10: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int a = 0;

if(n >= 1 && n < 10)
{
    for(int i = 1; i <= n; i++)
    {
        array[a] = i * i * i;
        a++;
    }
}

else
{
    Console.WriteLine("Введено неверное число");
}

Console.WriteLine("[{0}]", string.Join(", ", array));
