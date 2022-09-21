int Ackermann(int m, int n)
{
    if(m == 0)
    {
        return n + 1;    
    }

    if(m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }

    if(m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    return -1;   
}

Console.Write("Введите положительное число m =  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число n =  ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Ackermann(m, n);

Console.WriteLine(result);