double getConst(string name)
{
    Console.Write($"{name} = ");
    return Convert.ToDouble(Console.ReadLine());
}

double getY(double x, double k, double b) 
{
   return k * x + b; 
}

double[,] getLine(double k, double b)
{
    double[,] points = new double[2, 2];
    for(int i = 0; i < 2; i++)
    {
        points[i,0] = i;
        points[i,1] = getY(i, k, b);
    }
    return points;
}

Console.WriteLine("Введите значения для: ");   

double k1 = getConst("k1");
double b1 = getConst("b1");
double k2 = getConst("k2");
double b2 = getConst("b2");

double[,] lineA = getLine(k1, b1);
double[,] lineB = getLine(k2, b2);

Console.WriteLine("Линия 1");
Console.WriteLine($"x1 = {lineA[0,0]}, y1 = {lineA[0,1]}, x2 = {lineA[1,0]}, y2 = {lineA[1,1]}");
Console.WriteLine("Линия 2");
Console.WriteLine($"x1 = {lineB[0,0]}, y1 = {lineB[0,1]}, x2 = {lineB[1,0]}, y2 = {lineB[1,1]}");