double getConst(string name)
{
    Console.Write($"{name} = ");
    return Convert.ToDouble(Console.ReadLine());
}

double getX(double k1, double b1, double k2, double b2) 
{
   return (b1 - b2) / (k2 - k1);
}

double getY(double k1, double b1, double x)
{
    return k1 * x + b1;
}


Console.WriteLine("Введите значения для: ");   

double k1 = getConst("k1");
double b1 = getConst("b1");
double k2 = getConst("k2");
double b2 = getConst("b2");

double x = getX(k1, b1, k2, b2);
double y = getY(k1, b1, x);

Console.WriteLine($"{x};{y}");