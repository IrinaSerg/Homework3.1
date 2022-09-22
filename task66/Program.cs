int RangeSum(int m, int n)
{
    if(m > n)
    {
        return 0;
    }
        
    return m + RangeSum(m + 1, n);
}


Console.Write("Введите натуральное число m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число n = ");
int n = Convert.ToInt32(Console.ReadLine());

int result = RangeSum(m, n);
Console.WriteLine(result);