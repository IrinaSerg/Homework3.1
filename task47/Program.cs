Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] twoDimArray = new double[m, n];
Random rnd = new Random();

void PrintArray(double[,] math)
{
    for (int i = 0; i < math.GetLength(0); i++)
    {
        for (int j = 0; j < math.GetLength(1); j++)
        { 
            Console.Write($"{math[i, j]} "); 
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        { 
            matr[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0); 
        }
    }
}

FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);