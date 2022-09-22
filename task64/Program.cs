void PrintRange(int m, int n)
{
    if(m > n)
    {
        return;
    }
    Console.Write($"{m} ");
    PrintRange(m + 1, n);
}


Console.Write("Введите натуральное число m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число n = ");
int n = Convert.ToInt32(Console.ReadLine());

PrintRange(m, n);