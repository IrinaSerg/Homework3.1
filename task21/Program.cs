int[] convertToInt(string[] sCoords)
{
    int[] result = new int[sCoords.Length];
    for(int i = 0; i < sCoords.Length; i++)
    {
        result[i] = Convert.ToInt32(sCoords[i]);
    }
    return result;
}

Console.WriteLine("Введите координаты точки A(x,y,z): ");
string sCoordsA = Console.ReadLine();
Console.WriteLine("Введите координаты точки B(x,y,z): ");
string sCoordsB = Console.ReadLine();


int[] coordsA = convertToInt(sCoordsA.Split(","));
int[] coordsB = convertToInt(sCoordsB.Split(","));

double powX = Math.Pow((coordsB[0] - coordsA[0]), 2);
double powY = Math.Pow((coordsB[1] - coordsA[1]), 2);
double powZ = Math.Pow((coordsB[2] - coordsA[2]), 2);
double sum = powX + powY + powZ;
double result = Math.Sqrt(sum);

Console.WriteLine($"Результат: {result.ToString("F2")}");